using MonthlySalesProfit.Entities;

namespace MonthlySalesProfit.Repositories
{
    public interface IProdutoRepository
    {
        List<Produto> GetProdutos();
        void SetProdutos(List<Produto> produtos);
    }
}
