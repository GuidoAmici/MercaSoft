namespace Entities
{
    public class Stock
    {
        //TODO Implemetar sistema de tipos de stock por pieza
        //1. Disponible: stock listo para vender
        //2. Reservado para producción: existencias necesarias para terminar alguna o varias ordenes de producción
        //3. En producción: ya hay una orden de producción en cola por esta cantidad
        //4. Facturado: sigue en el depósito y todavía no está pago
        public int Avaiable { get; set; }
        public int InProductionQueue { get; set; }
        public int ReservedAsSupply { get; set; }
        public int MissingOversold { get; set; }

        public Stock() { }

        public override string ToString()
        {
            return Avaiable.ToString();
        }

    }
}
