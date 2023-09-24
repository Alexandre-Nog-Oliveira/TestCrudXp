Crud de tarefas
Este é um exemplo de uma API de gerenciamento de tarefas construída em C# usando .NET  com uma arquitetura baseada em Domain-Driven Design (DDD), boas práticas e um teste unitário.

Estrutura do Projeto
A estrutura do projeto segue as melhores práticas e a arquitetura DDD:

CrudWebApi: A camada de aplicação que contém o controlador da API.
Domain: A camada de domínio que define os modelos de domínio e serviços.
Infrastructure: A camada de infraestrutura que lida com o armazenamento e acesso aos dados (simulado neste exemplo).

Endpoints da API

GET /api/tarefas: Retorna todas as tarefas.
GET /api/tarefas/{id}: Retorna uma tarefa por ID.
POST /api/tarefas: Cria uma nova tarefa.
PUT /api/tarefas/{id}: Atualiza uma tarefa existente.
DELETE /api/tarefas/{id}: Exclui uma tarefa por ID.

Contribuição
Sinta-se à vontade para contribuir com este projeto, enviando issues, sugestões ou pull requests.
