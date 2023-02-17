using Data;
using Entities;

namespace Control
{
    public static class Info
    {
        public static List<Category> GetCategories(bool isActive)
        {
            List<Category> list = CategoryDao.GetCategories();
            if (isActive)
            {
                foreach (Category obj in list)
                {
                    if (!obj.IsActive)
                    {
                        list.Remove(obj);
                    }
                }
            }
            return list;
        }

        public static List<Company> LoadClients()
        {
            List<Company> list = CompanyDao.GetCompanies();
            foreach (Company company in list)
            {
                if (!company.IsClient)
                    list.Remove(company);
            }
            return list;
        }
    }
}
