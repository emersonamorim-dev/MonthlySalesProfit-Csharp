# MonthlySalesProfit-API-Csharp 🚀 🔄 🌐

Codificação de APIRest que se chama `MonthlySalesProfit` é uma aplicação ASP.NET Core que fornece endpoints para calcular e obter informações
sobre o lucro de produtos de tecnologia. A aplicação permite que os usuários determinem qual produto 
gerou mais lucro, qual gerou menos lucro, e também o lucro total de todos os produtos.

## Funcionalidades

1. **Calcular o Produto Mais Lucrativo**: A API pode determinar qual produto, dentre uma lista fornecida, gerou o maior lucro.
2. **Calcular o Produto Menos Lucrativo**: A API pode determinar qual produto, dentre uma lista fornecida, gerou o menor lucro.
3. **Obter Lucro Total**: A API pode calcular o lucro total de uma lista de produtos fornecida.

## Endpoints

### Método Post para requisição no Swagger ou Postman:
- `POST /api/produtos/lucro-medio`: Retorna o produto mais lucrativo e o menos lucrativo de uma lista de produtos fornecida.

```
[
    {"Nome": "Memória", "QuantidadeVendida": 954, "MargemDeLucro": 0.05, "PrecoUnitario": 1.50},
    {"Nome": "Placa Mãe", "QuantidadeVendida": 336, "MargemDeLucro": 0.08, "PrecoUnitario": 500.00},
    {"Nome": "HD", "QuantidadeVendida": 335, "MargemDeLucro": 0.12, "PrecoUnitario": 350.00},
    {"Nome": "Processador", "QuantidadeVendida": 155, "MargemDeLucro": 0.21, "PrecoUnitario": 150.00},
    {"Nome": "Gabinete", "QuantidadeVendida": 323, "MargemDeLucro": 0.25, "PrecoUnitario": 40.00},
    {"Nome": "Fonte de Alimentação", "QuantidadeVendida": 165, "MargemDeLucro": 0.30, "PrecoUnitario": 30.00}
]

```

### Método Post para requisição no Swagger ou Postman:
- `POST /api/produtos/lucro-total`: Retorna o lucro total de uma lista de produtos fornecida.

```
[
  {
    "nome": "Memória",
    "quantidadeVendida": 954,
    "margemDeLucro": 0.05,
    "precoUnitario": 1.50
  },
  {
    "nome": "Placa Mãe",
    "quantidadeVendida": 336,
    "margemDeLucro": 0.08,
    "precoUnitario": 500.00
  },
  {
    "nome": "HD",
    "quantidadeVendida": 335,
    "margemDeLucro": 0.12,
    "precoUnitario": 350.00
  },
  {
    "nome": "Processador",
    "quantidadeVendida": 155,
    "margemDeLucro": 0.21,
    "precoUnitario": 150.00
  },
  {
    "nome": "Gabinete",
    "quantidadeVendida": 323,
    "margemDeLucro": 0.25,
    "precoUnitario": 40.00
  },
  {
    "nome": "Fonte de Alimentação",
    "quantidadeVendida": 165,
    "margemDeLucro": 0.30,
    "precoUnitario": 30.00
  }
]

```

## Estrutura do Projeto

### Controllers

- **ProdutoController**: Controlador principal que contém os endpoints para calcular e obter informações sobre o lucro dos produtos.

### Services

- **ProdutoService**: Serviço que contém a lógica de negócios para calcular o lucro dos produtos. Ele interage com o repositório para obter os dados dos produtos.

### Repositories

- **IProdutoRepository**: Interface que define os métodos que o repositório de produtos deve implementar.
- **ProdutoRepository**: Implementação concreta do repositório de produtos. Armazena os produtos em memória.

### DTOs (Data Transfer Objects)

- **ProdutoDTO**: Representa um produto com seu nome e lucro.
- **LucroTotalDTO**: Representa o lucro total de uma lista de produtos.

### Entities

- **Produto**: Entidade que representa um produto com suas propriedades e um método para calcular seu lucro.

### Como Usar

1. Clone o repositório.
2. Navegue até a pasta do projeto e execute `dotnet run`.
3. Acesse a API usando uma ferramenta como Swagger que já está imbutido na aplicação ou Postman.
4. Envie uma lista de produtos no corpo da requisição para os endpoints relevantes para obter os resultados desejados.



### Autor:
Emerson Amorim
