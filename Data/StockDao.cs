using Control;
using Entities;

namespace Data
{
    public class StockDao
    {
        // CREATE methods

        // READ methods

        // UPDATE methods
        public static void Update(Item item)
        {
            DAO dao = new();

            string query = "update Items set " +
                "StockAvailable = @stockAvailable, " +
                "StockInProductionQueue = @stockInProductionQueue, " +
                "StockOversold = @stockOversold, " +
                "StockReservedAsSupply = @stockReservedAsSupply, " +
                "StockMissingSupplies = @stockMissingSupplies " +
                "where ID = @itemID";

            try
            {
                dao.OpenConnection();
                dao.SetConsult(query);
                dao.SetParameter("@stockAvailable", item.ID);
                dao.SetParameter("@stockInProductionQueue", item.ID);
                dao.SetParameter("@stockOversold", item.ID);
                dao.SetParameter("@stockReservedAsSupply", item.ID);
                dao.SetParameter("@stockMissingSupplies", item.ID);
                dao.SetParameter("@itemID", item.ID);
                dao.ExecuteConsult();
            }
            catch (Exception) { throw; }
            finally { dao.CloseConnection(); }
        }

        // DELETE methods

    }
}
