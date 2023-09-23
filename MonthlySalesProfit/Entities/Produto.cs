namespace MonthlySalesProfit.Entities
{
    public class Produto
    {
        public string Nome { get; set; }
        public int QuantidadeVendida { get; set; }
        public decimal MargemDeLucro { get; set; }
        public decimal PrecoUnitario { get; set; }

        public decimal CalcularLucro()
        {
            return QuantidadeVendida * PrecoUnitario * MargemDeLucro;
        }
    }
}
