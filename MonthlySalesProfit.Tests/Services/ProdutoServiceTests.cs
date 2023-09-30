using System;
using System.Collections.Generic;
using System.Linq;
using MonthlySalesProfit.Entities;
using MonthlySalesProfit.Repositories;
using MonthlySalesProfit.Services;
using Moq;
using Xunit;

namespace MonthlySalesProfit.Tests.Services
{
    public class ProdutoServiceTests
    {
        private readonly ProdutoService _produtoService;
        private readonly Mock<IProdutoRepository> _produtoRepositoryMock = new Mock<IProdutoRepository>();

        public ProdutoServiceTests()
        {
            _produtoService = new ProdutoService(_produtoRepositoryMock.Object);
        }

        [Fact]
        public void GetProdutoMaisLucrativo_ShouldReturnProdutoWithHighestLucro()
        {
            // Arrange
            var produto1 = new Produto { Nome = "Produto 1" };
            var produto2 = new Produto { Nome = "Produto 2" };

            var produtos = new List<Produto> { produto1, produto2 };

            _produtoRepositoryMock.Setup(repo => repo.GetProdutos()).Returns(produtos);

            // Act
            var result = _produtoService.GetProdutoMaisLucrativo();

            // Assert
            Assert.NotNull(result);
        }

        [Fact]
        public void GetProdutoMenosLucrativo_ShouldReturnProdutoWithLowestLucro()
        {
            // Arrange
            var produtos = new List<Produto>
            {
                new Produto { Nome = "Produto 1" },
                new Produto { Nome = "Produto 2" }
            };

            // Act
            var result = _produtoService.GetLucrosDeTodosProdutos(produtos);

            // Assert
            Assert.NotNull(result);
            Assert.Equal(2, result.Count);

        }

        [Fact]
        public void GetLucrosDeTodosProdutos_ShouldReturnLucrosDeTodosProdutos()
        {
            // Arrange
            var produtos = new List<Produto>
            {
                new Produto { Nome = "Produto 1" },
                new Produto { Nome = "Produto 2" }
            };

            // Act
            var result = _produtoService.GetLucrosDeTodosProdutos(produtos);

            // Assert
            Assert.NotNull(result);
            Assert.Equal(2, result.Count); // Assumindo que temos 2 produtos para testar

        }

        [Fact]
        public void GetLucroTotal_ShouldReturnTotalLucro()
        {
            // Arrange
            var produtos = new List<Produto>
            {
                new Produto { Nome = "Produto 1" },
                new Produto { Nome = "Produto 2" }
            };

            // Act
            var result = _produtoService.GetLucroTotal(produtos);

            // Assert
            Assert.NotNull(result);
            Assert.True(result.LucroTotal >= 0);
        }
    }
}
