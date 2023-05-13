using Control;
using Entities;

namespace Data
{
    public class ProductionOrderDAO
    {
        public static void Add(ProductionOrder productionOrder, User user)
        {
            DAO dao = new();
            string query = "insert into ProductionOrders (UserID, ProducedItemID, Quantity) " +
                "values (@userID, @productionOrderID, @productionOrderQuantity)";
            try
            {
                dao.OpenConnection();
                dao.SetConsult(query);
                dao.SetParameter("@userID", user.ID);
                dao.SetParameter("@productionOrderID", productionOrder.ID);
                dao.SetParameter("@productionOrderQuantity", productionOrder.Quantity);
                dao.ExecuteConsult();
            }
            catch (Exception) { throw; }
            finally { dao.CloseConnection(); }
        }

        public static List<ProductionOrder> Get()
        {
            DAO dao = new();
            string query = "select * from Companies";

            List<ProductionOrder> list = new();
            ProductionOrder obj;
            Item item;
            User user;

            try
            {
                dao.OpenConnection();
                dao.SetConsult(query);
                dao.ExecuteConsult();

                while (dao.Reader.Read())
                {
                    item = ItemDao.GetItemByID((int)dao.Reader["ProducedItemID"]);
                    user = UserDao.GetUserByID((int)dao.Reader["UserID"]);

                    obj = new(
                        (int)dao.Reader["ID"],
                        user,
                        (DateTime)dao.Reader["DateTime"],
                        item,
                        (int)dao.Reader["Quantity"]
                        );

                    list.Add(obj);
                }
                return list;
            }
            catch (Exception) { throw; }
            finally { dao.CloseConnection(); }
        }

        public static ProductionOrder Get(int productionOrderID)
        {
            DAO dao = new();
            string query = $"select * from Companies where ID = @productionOrderID";

            ProductionOrder obj;
            Item item;
            User user;

            try
            {
                dao.OpenConnection();
                dao.SetConsult(query);
                dao.SetParameter("@productionOrderID", productionOrderID);
                dao.ExecuteConsult();

                dao.Reader.Read();

                item = ItemDao.GetItemByID((int)dao.Reader["ProducedItemID"]);
                user = UserDao.GetUserByID((int)dao.Reader["UserID"]);

                obj = new(
                    (int)dao.Reader["ID"],
                    user,
                    (DateTime)dao.Reader["DateTime"],
                    item,
                    (int)dao.Reader["Quantity"]
                    );

                return obj;
            }
            catch (Exception) { throw; }
            finally { dao.CloseConnection(); }
        }
    }
}
