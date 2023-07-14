using Data;
using Entities;

namespace Control
{
    public static class Cloud
    {
        // GET methods

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
            List<Company> list = CompanyDao.GetAll();
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

        public static List<ProductionOrder> GetProductionOrders()
        {
            return ProductionOrderDAO.GetAll();
        }

        // SET methods

        public static void SubmitProductionOrder(ProductionOrder productionOrder, List<Item> supplyList)
        {
            ProductionOrderDAO.Add(productionOrder, Sesion.User);

            productionOrder.Item.Stock.InProductionQueue += productionOrder.Quantity;
            StockDao.Update(productionOrder.Item);

            int requiredQuantity;
            Stock stockRecord;

            foreach (Item supply in supplyList)
            {
                requiredQuantity = (int)(productionOrder.Quantity * supply.SuppliedQuantity);
                stockRecord = new();
                if (supply.Stock.Available >= requiredQuantity)
                {
                    supply.Stock.Available -= requiredQuantity;
                    supply.Stock.ReservedAsSupply += requiredQuantity;

                    stockRecord.Available -= requiredQuantity;
                    stockRecord.ReservedAsSupply += requiredQuantity;
                }
                else
                {
                    supply.Stock.ReservedAsSupply += supply.Stock.Available;
                    supply.Stock.MissingSupplies += supply.Stock.Available - requiredQuantity;
                    supply.Stock.Available = 0;

                    stockRecord.ReservedAsSupply += supply.Stock.Available;
                    stockRecord.MissingSupplies += supply.Stock.Available - requiredQuantity;
                }

                StockDao.Update(supply);
                supply.Stock = stockRecord;
                RecordDao.AddStockRecord(Sesion.User, supply, $"Production Order Nº {productionOrder.ID}");
            }
        }

        public static void UploadItem(Item item)
        {
            ItemDao.AddItem(item);
            ItemDao.AssociateSupplies(item, item.Supplies);
        }
    }
}
