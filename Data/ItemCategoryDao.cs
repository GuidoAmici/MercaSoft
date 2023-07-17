using Control;
using Entities;

namespace Data
{
    public static class ItemCategoryDao
    {
        // CREATE methods

        public static List<ItemCategory> Get()
        {
            DAO dao = new();
            string query = "select * from ItemCategories";
            List<ItemCategory> list = new();
            ItemCategory obj;

            try
            {
                dao.OpenConnection();
                dao.SetConsult(query);
                dao.ExecuteConsult();

                while (dao.Reader.Read())
                {
                    obj = new(
                        (int)dao.Reader["ID"],
                        (string)dao.Reader["Name"],
                        (bool)dao.Reader["IsActive"]
                    );

                    list.Add(obj);
                }

                return list;
            }
            catch (Exception) { throw; }
            finally { dao.CloseConnection(); }
        }

        public static ItemCategory Get(int itemCategoryID)
        {
            DAO dao = new();
            string query = "select * from ItemCategories where ID = @itemCategoryID";
            ItemCategory obj;

            try
            {
                dao.OpenConnection();
                dao.SetConsult(query);
                dao.SetParameter("@itemCategoryID", itemCategoryID);
                dao.ExecuteConsult();

                dao.Reader.Read();

                obj = new(
                    (int)dao.Reader["ID"],
                    (string)dao.Reader["Name"],
                    (bool)dao.Reader["IsActive"]
                );

                return obj;
            }
            catch (Exception) { throw; }
            finally { dao.CloseConnection(); }
        }

        // READ methods


        // UPDATE methods


        // DELETE methods
    }
}
