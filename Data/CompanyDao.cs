using Control;
using Entities;

namespace Data
{
    public static class CompanyDao
    {
        public static List<Company> GetCompanies()
        {
            DAO dao = new();
            string getCompanies = "select * from Companies";
            List<Company> list = new();
            Company obj;

            try
            {
                dao.OpenConnection();
                dao.SetConsult(getCompanies);
                dao.ExecuteConsult();

                while (dao.Reader.Read())
                {
                    obj = new(
                        (int)dao.Reader["ID"],
                        (string)dao.Reader["Name"],
                        (bool)dao.Reader["IsClient"],
                        (bool)dao.Reader["IsSupplier"]
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