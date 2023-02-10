using Entities;
using Data;

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
    }
}
