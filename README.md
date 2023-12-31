# Screen Sound - Gerenciador de Bandas e Avaliações

Este projeto, intitulado "Screen Sound", é um simples gerenciador de bandas musicais que permite registrar, avaliar e consultar a média de avaliações de bandas. A seguir, são detalhados os principais conceitos, funcionalidades e estrutura do projeto.

## Conceitos Aplicados

### Dicionários
O projeto utiliza um dicionário em C# para armazenar as bandas e suas respectivas listas de avaliações. Um dicionário é uma estrutura de dados que associa chaves a valores, permitindo uma busca eficiente de informações.

### Switch-Case
A estrutura de controle `switch-case` é utilizada para oferecer opções ao usuário e direcioná-lo às funções correspondentes de acordo com a sua escolha.

### Entrada e Saída de Dados
O projeto interage com o usuário por meio da entrada e saída padrão (`Console.ReadLine()` e `Console.WriteLine()`), permitindo registrar informações e exibir mensagens na tela.

### Média de Avaliações
Para calcular a média das avaliações de uma banda, o projeto utiliza a função `Average()` da biblioteca padrão do C# para calcular a média dos elementos em uma lista.

## Funções Específicas do C#

### `Console.Clear()`
Esta função limpa o console, proporcionando uma interface limpa e amigável ao usuário.

### `Thread.Sleep(2000)`
A função `Thread.Sleep(2000)` pausa a execução do programa por um determinado período de tempo, neste caso, 2 segundos, antes de continuar.

### `Console.ReadKey()`
Permite ler a próxima tecla pressionada pelo usuário, sendo útil para pausar a execução até que o usuário tome uma ação.

## Estrutura do Código

O código está estruturado em diversas funções que facilitam a manutenção e a compreensão. A seguir, uma breve descrição das principais funções:

- **`ExibirLogo()`**: Exibe o logo e a mensagem de boas-vindas.
- **`ExibirOpcoesDoMenu()`**: Apresenta as opções do menu principal e direciona o usuário para as funções correspondentes.
- **`RegistrarBandas()`**: Permite registrar uma nova banda no dicionário.
- **`mostrarBandasRegistrada()`**: Mostra todas as bandas registradas e oferece a opção de registrar uma nova banda.
- **`AvaliarBandaRegistrada()`**: Permite avaliar uma banda existente ou registrar uma nova banda.
- **`ExibirMediaBanda()`**: Mostra a média das avaliações de uma banda específica.

Ao final, o programa inicializa apresentando o logo e as opções do menu principal, e permite ao usuário navegar pelas funcionalidades de forma interativa.

---

Esse Readme serve como uma breve introdução ao projeto "Screen Sound", destacando os principais conceitos, funcionalidades e estrutura do código em C#. A implementação oferece uma base sólida para expandir e adicionar novas funcionalidades no futuro.
