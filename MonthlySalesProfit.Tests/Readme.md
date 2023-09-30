## MonthlySalesProfit.Tests - Testes Unitários XUnit

Implementado o uso de  testes unitários XUnit é um conjunto de testes para o serviço ProdutoService. Os testes são criados para verificar a lógica de negócios 
do serviço, assegurando que esteja funcionando conforme o esperado. 

### Pacotes Utilizados
- Xunit: É um framework de testes para a linguagem de programação C#. É usado para escrever testes unitários para o código .NET.

- Moq: É uma biblioteca popular para criar mocks em testes .NET. Os mocks são objetos que simulam o comportamento de objetos reais de forma controlada. 
Eles são usados para isolar o código sob teste, eliminando dependências externas.

### Classe de Teste ProdutoServiceTests
Esta classe contém métodos de teste para verificar o comportamento do ProdutoService.

### Construtor ProdutoServiceTests()
No construtor da classe de teste, um mock do IProdutoRepository está sendo criado e passado para o construtor do ProdutoService. Isso ajuda a isolar o serviço 
de qualquer implementação real do repositório durante o teste.

### Teste GetProdutoMaisLucrativo_ShouldReturnProdutoWithHighestLucro()
- Arrange: Cria dois produtos e uma lista contendo esses produtos. O método GetProdutos() do mock do repositório é configurado para retornar essa lista de produtos.
Act: Chama o método GetProdutoMaisLucrativo() no serviço.

- Assert: Verifica se o resultado não é nulo. No entanto, vale ressaltar que esse teste pode ser melhorado verificando se o produto retornado é realmente
- o produto mais lucrativo.
Teste GetProdutoMenosLucrativo_ShouldReturnProdutoWithLowestLucro()
Arrange: Cria uma lista de produtos.

- Act: Chama o método GetLucrosDeTodosProdutos().
Assert: Verifica se o resultado não é nulo e se a contagem de lucros retornados é 2 (considerando que temos dois produtos na lista). Parece haver um equívoco
aqui - o teste deveria provavelmente chamar um método para obter o produto menos lucrativo e não os lucros de todos os produtos.
Teste GetLucrosDeTodosProdutos_ShouldReturnLucrosDeTodosProdutos()
Arrange: Cria uma lista de produtos.

- Act: Chama o método GetLucrosDeTodosProdutos().
Assert: Verifica se o resultado não é nulo e se os lucros de todos os produtos foram retornados (assumindo que temos 2 produtos para testar).
Teste GetLucroTotal_ShouldReturnTotalLucro()
Arrange: Cria uma lista de produtos.
Act: Chama o método GetLucroTotal() para calcular o lucro total de todos os produtos na lista.
Assert: Verifica se o resultado não é nulo e se o lucro total é maior ou igual a zero.

### Considerações
Certifique-se de que os pacotes Xunit e Moq estão instalados via NuGet para que os testes possam ser executados.
Pode ser útil melhorar a assertividade dos testes verificando valores específicos ou comportamentos além da não nulidade dos resultados.


### Como Melhorar os Testes
Verificar se o produto retornado no teste GetProdutoMaisLucrativo_ShouldReturnProdutoWithHighestLucro() é realmente o mais lucrativo.
Corrigir o método chamado no teste GetProdutoMenosLucrativo_ShouldReturnProdutoWithLowestLucro() para se alinhar com o nome do teste.
Verificar valores específicos nos testes, em vez de apenas verificar se o resultado não é nulo, para tornar os testes mais rigorosos e informativos.


### Autor:
Emerson Amorim



