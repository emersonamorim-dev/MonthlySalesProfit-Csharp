using MonthlySalesProfit.Entities;

namespace MonthlySalesProfit.Repositories
{
    public class ProdutoRepository : IProdutoRepository
    {
        private List<Produto> _produtos;

        public List<Produto> GetProdutos()
        {
            return _produtos;
        }

        public void SetProdutos(List<Produto> produtos)
        {
            _produtos = produtos;
        }
    }
}
