## Calculadora

No desenvolvimento deste projeto, foram aplicados os princípios SOLID para garantir um código mais organizado, flexível e de fácil manutenção.

### Saída Esperada no Console
- 14 - 8 = 6
- 5 * 6 = 30
- 2147483647 + 2 = 2147483649
- 18 / 3 = 6

### Funcionalidades Implementadas
1. Implementada a funcionalidade para imprimir toda a lista de operações a ser processada após cada cálculo realizado.
2. Criada uma nova pilha (Stack) para guardar o resultado de cada cálculo efetuado e imprimir a pilha ao final.

### Extensibilidade do Projeto
Para assegurar a extensibilidade da calculadora, foram empregados os princípios de interfaces e injeção de dependência. Uma interface denominada `CalculatorEngine` foi criada, possibilitando a implementação de diversos tipos de calculadoras. Por exemplo, é viável desenvolver uma classe `SimpleCalculator` para operações aritméticas básicas ou, posteriormente, uma classe destinada a uma calculadora científica. Outro exemplo é a interface `OperationStrategy`, empregada para abstrair e definir as operações necessárias a serem realizadas ao implementá-la.

### Testes da Aplicação
Os testes da aplicação foram realizados utilizando o framework NUnit. Os testes garantem que todas as funcionalidades da calculadora estão funcionando corretamente e ajudam a manter a integridade do código durante o desenvolvimento e refatoração.

### Uso do Docker
Este projeto pode ser facilmente executado em containers Docker. Basta executar o comando a seguir na raiz do projeto:

> docker compose up --build

Isso criará e executará o contêiner Docker com a aplicação.

### Execução Local
Se preferir executar localmente, acesse a pasta Calculadora e utilize o comando:

> dotnet run