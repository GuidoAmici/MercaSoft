using Control;
using Entities;

namespace Data
{
    public class RecordDao
    {
        // CREATE methods

        public static void AddLogInRecord(User user)
        {
            DAO dao = new();

            string description = "Log In";
            string query = "insert into UserRecords (UserID,Description) values (@userID,@description)";

            try
            {
                dao.OpenConnection();
                dao.SetConsult(query);
                dao.SetParameter("@userID", user.ID);
                dao.SetParameter("@description", description);
                dao.ExecuteConsult();
            }
            catch (Exception) { throw; }
            finally { dao.CloseConnection(); }
        }

        public static void AddLogOutRecord(User user)
        {
            DAO dao = new();

            string description = "Log Out";
            string query = "insert into UserRecords (UserID,Description) values (@userID,@description)";

            try
            {
                dao.OpenConnection();
                dao.SetConsult(query);
                dao.SetParameter("@userID", user.ID);
                dao.SetParameter("@description", description);
                dao.ExecuteConsult();
            }
            catch (Exception) { throw; }
            finally { dao.CloseConnection(); }
        }

        public static void AddStockRecord(User user, Item item, string description)
        {
            DAO dao = new();
            string query = "insert into StockRecords (UserID, Description, ItemID, " +
                "StockAvailable, StockInProductionQueue, StockOversold, StockReservedAsSupply, StockMissingSupplies) " +
                "values (@userID, @description, @itemID, " +
                "@stockAvailable, @stockInProductionQueue, @stockOversold, @stockReservedAsSupply, @stockMissingSupplies)";

            try
            {
                dao.OpenConnection();
                dao.SetConsult(query);
                dao.SetParameter("@userID", user.ID);
                dao.SetParameter("@description", description);
                dao.SetParameter("@itemID", item.ID);
                dao.SetParameter("@stockAvailable", item.Stock.Available);
                dao.SetParameter("@stockInProductionQueue", item.Stock.InProductionQueue);
                dao.SetParameter("@stockOversold", item.Stock.Oversold);
                dao.SetParameter("@stockReservedAsSupply", item.Stock.ReservedAsSupply);
                dao.SetParameter("@stockMissingSupplies", item.Stock.MissingSupplies);
                dao.ExecuteConsult();
            }
            catch (Exception) { throw; }
            finally { dao.CloseConnection(); }
        }

        // READ methods

        // UPDATE methods

        // DELETE methods
    }
}