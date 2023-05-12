using Control;
using Entities;

namespace Data
{

    public static class ItemDao
    {
        public static List<Item> GetItemsForSale(bool isForSale)
        {
            DAO dao = new();
            string query = "select * from Items where IsForSale = @isForSale";
            List<Item> list = new();
            Item obj;
            ItemCategory itemCategory;

            try
            {
                dao.OpenConnection();
                dao.SetParameter("@isForSale", isForSale);
                dao.SetConsult(query);
                dao.ExecuteConsult();

                while (dao.Reader.Read())
                {
                    itemCategory = ItemCategoryDao.Get((int)dao.Reader["ItemCategoryID"]);

                    obj = new();
                    obj.ID = (int)dao.Reader["ID"];
                    obj.Name = (string)dao.Reader["Name"];
                    obj.IsForSale = (bool)dao.Reader["IsForSale"];
                    obj.Price = Convert.IsDBNull(dao.Reader["Price"]) ? 0.0f : Convert.ToSingle(dao.Reader["Price"]);
                    obj.Stock = (int)dao.Reader["Stock"];
                    obj.ItemCategory = itemCategory;
                    obj.Description = Convert.IsDBNull(dao.Reader["Description"]) ? null : (string)dao.Reader["Description"];
                    obj.CodeName = Convert.IsDBNull(dao.Reader["CodeName"]) ? null : (string)dao.Reader["CodeName"];
                    obj.BarCode = Convert.IsDBNull(dao.Reader["BarCode"]) ? null : (int)dao.Reader["BarCode"];

                    list.Add(obj);
                }
                return list;
            }
            catch (Exception) { throw; }
            finally { dao.CloseConnection(); }
        }

        public static List<Item> GetProducibleItems(bool producible)
        {
            DAO dao = new();
            string query = "select * from Items where Producible = @producible";
            List<Item> list = new();
            Item obj;
            ItemCategory itemCategory;

            try
            {
                dao.OpenConnection();
                dao.SetParameter("@producible", producible);
                dao.SetConsult(query);
                dao.ExecuteConsult();

                while (dao.Reader.Read())
                {
                    itemCategory = ItemCategoryDao.Get((int)dao.Reader["ItemCategoryID"]);

                    obj = new();
                    obj.ID = (int)dao.Reader["ID"];
                    obj.Name = (string)dao.Reader["Name"];
                    obj.IsForSale = (bool)dao.Reader["IsForSale"];
                    obj.Price = Convert.IsDBNull(dao.Reader["Price"]) ? 0.0f : Convert.ToSingle(dao.Reader["Price"]);
                    obj.Stock = (int)dao.Reader["Stock"];
                    obj.ItemCategory = itemCategory;
                    obj.Description = Convert.IsDBNull(dao.Reader["Description"]) ? null : (string)dao.Reader["Description"];
                    obj.CodeName = Convert.IsDBNull(dao.Reader["CodeName"]) ? null : (string)dao.Reader["CodeName"];
                    obj.BarCode = Convert.IsDBNull(dao.Reader["BarCode"]) ? null : (int)dao.Reader["BarCode"];

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
            string query = $"select * from Items inner join SupplyItems on SupplyItems.SupplyItemID = Items.ID " +
                $"where SupplyItems.ProducedItemID = {item.ID}";
            List<Item> list = new();
            Item obj;
            ItemCategory itemCategory;

            try
            {
                dao.OpenConnection();
                dao.SetConsult(query);
                dao.ExecuteConsult();

                while (dao.Reader.Read())
                {
                    itemCategory = ItemCategoryDao.Get((int)dao.Reader["ItemCategoryID"]);

                    obj = new();
                    obj.ID = (int)dao.Reader["ID"];
                    obj.Name = (string)dao.Reader["Name"];
                    obj.IsForSale = (bool)dao.Reader["IsForSale"];
                    obj.Price = Convert.IsDBNull(dao.Reader["Price"]) ? 0.0f : Convert.ToSingle(dao.Reader["Price"]);
                    obj.Stock = (int)dao.Reader["Stock"];
                    obj.ItemCategory = itemCategory;
                    obj.Description = Convert.IsDBNull(dao.Reader["Description"]) ? null : (string)dao.Reader["Description"];
                    obj.CodeName = Convert.IsDBNull(dao.Reader["CodeName"]) ? null : (string)dao.Reader["CodeName"];
                    obj.BarCode = Convert.IsDBNull(dao.Reader["BarCode"]) ? null : (int)dao.Reader["BarCode"];
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
