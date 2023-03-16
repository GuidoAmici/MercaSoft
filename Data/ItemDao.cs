using Control;
using Entities;

namespace Data
{

    public static class ItemDao
    {
        public static List<Item> GetItems(bool isForSale)
        {
            DAO dao = new();
            string getItems = "select * from Items where IsForSale = @isForSale";
            List<Item> list = new();
            Item obj;
            List<Category> categories = CategoryDao.GetCategories();

            try
            {
                dao.OpenConnection();
                dao.SetConsult(getItems);
                dao.SetParameter("@isForSale", isForSale);
                dao.ExecuteConsult();

                while (dao.Reader.Read())
                {
                    obj = new(
                        (int)dao.Reader["ID"],
                        (string)dao.Reader["Name"],
                        (bool)dao.Reader["IsForSale"],
                        (float)dao.Reader["Price"],
                        (int)dao.Reader["Stock"],
                        (Category)categories[(int)dao.Reader["CategoryID"]],
                        (string)dao.Reader["Description"],
                        (string)dao.Reader["CodeName"],
                        (int)dao.Reader["BarCode"]
                        );

                    list.Add(obj);
                }
                return list;
            }
            catch (Exception) { throw; }
            finally { dao.CloseConnection(); }
        }
        public static List<Item> GetSupplies(Item item)
        {
            DAO dao = new();
            string getItems = "select * from Items where SupplyItems.ProducedItemID = @ItemID " +
                "inner join Supplies.ProducedItemID = Items.ID";
            List<Item> list = new();
            Item obj;
            List<Category> categories = CategoryDao.GetCategories();

            try
            {
                dao.OpenConnection();
                dao.SetConsult(getItems);
                dao.SetParameter("ItemID", item.ID);
                dao.ExecuteConsult();

                while (dao.Reader.Read())
                {
                    obj = new(
                        (int)dao.Reader["ID"],
                        (string)dao.Reader["Name"],
                        (bool)dao.Reader["IsForSale"],
                        (float)dao.Reader["Price"],
                        (int)dao.Reader["Stock"],
                        (Category)categories[(int)dao.Reader["CategoryID"]],
                        (string)dao.Reader["Description"],
                        (string)dao.Reader["CodeName"],
                        (int)dao.Reader["BarCode"]
                        );
                    obj.SuppliedQuantity = (int)dao.Reader["Quantity"];

                    list.Add(obj);
                }
                return list;
            }
            catch (Exception) { throw; }
            finally { dao.CloseConnection(); }
        }
    }
}
