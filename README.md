# Requisitos

Criação de Listas de Atividades:

Imagine diversas listas de atividades. Essas listas devem ser identificadas por um nome, como Trabalho, Estudo, Lazer, etc.
Cada lista deve ser representada por uma classe genérica ListaAtividades<T>, onde T é um tipo que deve implementar a interface 
IAtividade. Esta classe deve permitir o gerenciamento das atividades e deve ter métodos para adicionar, remover e listar atividades.
Definição da Interface e Classes de Atividades:
Crie uma interface genérica IAtividade que deve ser implementada por todas as atividades. 
A interface deve definir os atributos e métodos necessários, como Id, Nome e EstaConcluída.
As atividades específicas devem implementar a interface IAtividade e podem ter atributos adicionais específicos, se necessário.

Implementação do Serviço de Gerenciamento:
Crie um serviço genérico ServicoGerenciamentoAtividades<T>, 
onde T é um tipo que deve implementar a interface IAtividade. Este serviço deve ser implementado como um Singleton, 
utilizando a injeção de dependência do .NET para garantir que haja apenas uma instância compartilhada em toda a aplicação.
Utilize o contêiner de injeção de dependência do .NET para configurar o ciclo de vida Singleton.

Funcionalidade do Serviço:
O serviço deve permitir marcar que determinada atividade, de determinada lista, está concluída. 
Isso deve ser feito por meio de um método que recebe o identificador da atividade e o nome da lista.
Exibição das Listas e Atividades:
Implemente uma funcionalidade para exibir as listas e suas respectivas atividades, 
indicando se cada atividade está concluída ou não. 
O serviço deve ser capaz de retornar essas informações para visualização.

# Sobre a implementação
Para execução da funcionalide, fiz a implementação de uma WebApi (`Web.csproj`). 
Criei os endpoints necessários para criação da atividade, marcar a atividade como concluída e exibição de todas as atividades.

