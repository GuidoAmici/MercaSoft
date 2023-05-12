using Data;
using Entities;

namespace Control
{
    public static class Info
    {
        public static List<ItemCategory> GetCategories(bool isActive)
        {
            List<ItemCategory> list = ItemCategoryDao.Get();
            if (isActive)
            {
                foreach (ItemCategory obj in list)
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

        public static List<Item> GetItemsForSale()
        {
            return ItemDao.GetItemsForSale(true);
        }

        public static List<Item> GetProducibleItems()
        {
            return ItemDao.GetProducibleItems(true);
        }

        public static List<Item> GetProductionSupplies(Item itemProduced)
        {
            return ItemDao.GetSupplies(itemProduced);
        }
    }
}
