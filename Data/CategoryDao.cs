using Control;
using Entities;

namespace Data
{
    public class CategoryDao
    {
        public static List<Category> GetCategories()
        {
            DAO dao = new();
            string GetAllCategoies = "select * from Categories";
            List<Category> list = new();
            Category obj;

            try
            {
                dao.OpenConnection();
                dao.SetConsult(GetAllCategoies);
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
    }
}
