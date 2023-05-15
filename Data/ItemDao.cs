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
                dao.SetConsult(query);
                dao.SetParameter("@isForSale", isForSale);
                dao.ExecuteConsult();

                while (dao.Reader.Read())
                {
                    itemCategory = ItemCategoryDao.Get((int)dao.Reader["ItemCategoryID"]);

                    obj = new();
                    obj.ID = (int)dao.Reader["ID"];
                    obj.Name = (string)dao.Reader["Name"];
                    obj.IsForSale = (bool)dao.Reader["IsForSale"];
                    obj.Price = Convert.IsDBNull(dao.Reader["Price"]) ? 0.0f : Convert.ToSingle(dao.Reader["Price"]);
                    obj.Stock.Available = (int)dao.Reader["StockAvailable"];
                    obj.Stock.InProductionQueue = (int)dao.Reader["StockInProductionQueue"];
                    obj.Stock.Oversold = (int)dao.Reader["StockOversold"];
                    obj.Stock.ReservedAsSupply = (int)dao.Reader["StockReservedAsSupply"];
                    obj.Stock.MissingSupplies = (int)dao.Reader["StockMissingSupplies"];
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
                dao.SetConsult(query);
                dao.SetParameter("@producible", producible);
                dao.ExecuteConsult();

                while (dao.Reader.Read())
                {
                    itemCategory = ItemCategoryDao.Get((int)dao.Reader["ItemCategoryID"]);

                    obj = new();
                    obj.ID = (int)dao.Reader["ID"];
                    obj.Name = (string)dao.Reader["Name"];
                    obj.IsForSale = (bool)dao.Reader["IsForSale"];
                    obj.Price = Convert.IsDBNull(dao.Reader["Price"]) ? 0.0f : Convert.ToSingle(dao.Reader["Price"]);
                    obj.Stock.Available = (int)dao.Reader["StockAvailable"];
                    obj.Stock.InProductionQueue = (int)dao.Reader["StockInProductionQueue"];
                    obj.Stock.Oversold = (int)dao.Reader["StockOversold"];
                    obj.Stock.ReservedAsSupply = (int)dao.Reader["StockReservedAsSupply"];
                    obj.Stock.MissingSupplies = (int)dao.Reader["StockMissingSupplies"];
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
            string query = "select * from Items inner join SupplyItems on SupplyItems.SupplyItemID = Items.ID " +
                "where SupplyItems.ProducedItemID = @itemID";
            List<Item> list = new();
            Item obj;
            ItemCategory itemCategory;

            try
            {
                dao.OpenConnection();
                dao.SetConsult(query);
                dao.SetParameter("@itemID", item.ID);
                dao.ExecuteConsult();

                while (dao.Reader.Read())
                {
                    itemCategory = ItemCategoryDao.Get((int)dao.Reader["ItemCategoryID"]);

                    obj = new();
                    obj.ID = (int)dao.Reader["ID"];
                    obj.Name = (string)dao.Reader["Name"];
                    obj.IsForSale = (bool)dao.Reader["IsForSale"];
                    obj.Price = Convert.IsDBNull(dao.Reader["Price"]) ? 0.0f : Convert.ToSingle(dao.Reader["Price"]);
                    obj.Stock.Available = (int)dao.Reader["StockAvailable"];
                    obj.Stock.InProductionQueue = (int)dao.Reader["StockInProductionQueue"];
                    obj.Stock.Oversold = (int)dao.Reader["StockOversold"];
                    obj.Stock.ReservedAsSupply = (int)dao.Reader["StockReservedAsSupply"];
                    obj.Stock.MissingSupplies = (int)dao.Reader["StockMissingSupplies"];
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

        internal static Item GetItemByID(int itemID)
        {
            DAO dao = new();

            string query = "select * from Items where ID = @itemID";
            Item obj;
            ItemCategory itemCategory;

            try
            {
                dao.OpenConnection();
                dao.SetConsult(query);
                dao.SetParameter("@itemID", itemID);
                dao.ExecuteConsult();

                dao.Reader.Read();

                itemCategory = ItemCategoryDao.Get((int)dao.Reader["ItemCategoryID"]);

                obj = new();
                obj.ID = (int)dao.Reader["ID"];
                obj.Name = (string)dao.Reader["Name"];
                obj.IsForSale = (bool)dao.Reader["IsForSale"];
                obj.Price = Convert.IsDBNull(dao.Reader["Price"]) ? 0.0f : Convert.ToSingle(dao.Reader["Price"]);
                obj.Stock.Available = (int)dao.Reader["StockAvailable"];
                obj.Stock.InProductionQueue = (int)dao.Reader["StockInProductionQueue"];
                obj.Stock.Oversold = (int)dao.Reader["StockOversold"];
                obj.Stock.ReservedAsSupply = (int)dao.Reader["StockReservedAsSupply"];
                obj.Stock.MissingSupplies = (int)dao.Reader["StockMissingSupplies"];
                obj.ItemCategory = itemCategory;
                obj.Description = Convert.IsDBNull(dao.Reader["Description"]) ? null : (string)dao.Reader["Description"];
                obj.CodeName = Convert.IsDBNull(dao.Reader["CodeName"]) ? null : (string)dao.Reader["CodeName"];
                obj.BarCode = Convert.IsDBNull(dao.Reader["BarCode"]) ? null : (int)dao.Reader["BarCode"];

                return obj;
            }
            catch (Exception) { throw; }
            finally { dao.CloseConnection(); }
        }

        public static void Update(Item item)
        {
            DAO dao = new();

            string query = "update Items set " +
                "Name = @name, " +
                "Price = @price, " +
                "ItemCategoryID = @itemCategoryID, " +
                "Producible = @producible, " +
                "IsForSale = @isForSale, " +
                "Description = @description, " +
                "CodeName = @codeName, " +
                "BarCode = @barCode " +
                "where ID = @itemID";

            try
            {
                dao.OpenConnection();
                dao.SetConsult(query);
                dao.SetParameter("@name", item.ID);
                dao.SetParameter("@price", item.ID);
                dao.SetParameter("@itemCategoryID", item.ID);
                dao.SetParameter("@producible", item.ID);
                dao.SetParameter("@isForSale", item.ID);
                dao.SetParameter("@description", item.ID);
                dao.SetParameter("@codeName", item.ID);
                dao.SetParameter("@barCode", item.ID);
                dao.SetParameter("@itemID", item.ID);
                dao.ExecuteConsult();
            }
            catch (Exception) { throw; }
            finally { dao.CloseConnection(); }
        }
    }
}
