namespace Entities
{
    public class ProductionOrder
    {
        public int ID { get; set; }
        public DateTime Date { get; set; }
        public Item Item { get; set; }

        public ProductionOrder() { }

        public override string ToString()
        {
            return $"Orden de Producción Nº {ID}";
        }
    }
}
