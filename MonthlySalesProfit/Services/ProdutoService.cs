using MonthlySalesProfit.DTOs;
using MonthlySalesProfit.Entities;
using MonthlySalesProfit.Repositories;

namespace MonthlySalesProfit.Services
{
    public class ProdutoService
    {
        private readonly IProdutoRepository _produtoRepository;

        public ProdutoService(IProdutoRepository produtoRepository)
        {
            _produtoRepository = produtoRepository;
        }

        public ProdutoDTO GetProdutoMaisLucrativo()
        {
            var produtos = _produtoRepository.GetProdutos();
            var produto = produtos.OrderByDescending(p => p.CalcularLucro()).First();
            return new ProdutoDTO { Nome = produto.Nome, Lucro = produto.CalcularLucro() };
        }

        public ProdutoDTO GetProdutoMenosLucrativo()
        {
            var produtos = _produtoRepository.GetProdutos();
            var produto = produtos.OrderBy(p => p.CalcularLucro()).First();
            return new ProdutoDTO { Nome = produto.Nome, Lucro = produto.CalcularLucro() };
        }

        public List<ProdutoDTO> GetLucrosDeTodosProdutos(List<Produto> produtos)
        {
            return produtos.Select(p => new ProdutoDTO
            {
                Nome = p.Nome,
                Lucro = p.CalcularLucro()
            }).ToList();
        }

        public LucroTotalDTO GetLucroTotal(List<Produto> produtos)
        {
            decimal lucroTotal = 0;

            foreach (var produto in produtos)
            {
                lucroTotal += produto.CalcularLucro();
            }

            return new LucroTotalDTO { LucroTotal = lucroTotal };
        }
    }

}