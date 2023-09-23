using Microsoft.AspNetCore.Mvc;
using MonthlySalesProfit.DTOs;
using MonthlySalesProfit.Entities;
using MonthlySalesProfit.Repositories;
using MonthlySalesProfit.Services;

namespace MonthlySalesProfit.Controllers
{
    [Route("api/produtos")]
    [ApiController]
    public class ProdutoController : ControllerBase
    {
        private readonly ProdutoService _produtoService;
        private readonly IProdutoRepository _produtoRepository;

        public ProdutoController(IProdutoRepository produtoRepository)
        {
            _produtoRepository = produtoRepository;
            _produtoService = new ProdutoService(_produtoRepository);
        }

        [HttpPost("lucro-medio")]
        public ActionResult<IEnumerable<ProdutoDTO>> GetLucroProdutos([FromBody] List<Produto> produtos)
        {
            _produtoRepository.SetProdutos(produtos);

            var maisLucrativo = _produtoService.GetProdutoMaisLucrativo();
            var menosLucrativo = _produtoService.GetProdutoMenosLucrativo();

            return new List<ProdutoDTO> { maisLucrativo, menosLucrativo };
        }

        [HttpPost("lucro-total")]
        public ActionResult<decimal> GetLucroTotalProdutos([FromBody] List<Produto> produtos)
        {
            decimal lucroTotal = 0;

            foreach (var produto in produtos)
            {
                lucroTotal += produto.CalcularLucro();
            }

            return lucroTotal;
        }
    }
}
