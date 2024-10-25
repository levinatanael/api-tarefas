# Tarefa API

## Descrição

Este projeto é uma API para gerenciamento de tarefas que permite aos usuários organizar, monitorar e colaborar em suas tarefas diárias.

## Funcionalidades

- Listar projetos do usuário
- Criar projetos e tarefas
- Atualizar tarefas com histórico de alterações
- Limite de 20 tarefas por projeto
- Relatórios de desempenho para usuários com função "Gerente"

## Requisitos

- .NET 6 SDK
- Docker

## Como rodar o projeto

1. Clone o repositório:
2. docker-compose up --build
3. A aplicação estará acessível em http://localhost:5000

##

## Melhorias Futuras
- Segurança: Implementar autenticação e autorização usando JWT ou OAuth2 para proteger as rotas da API.
- Escalabilidade: Migrar a aplicação para uma arquitetura de microsserviços e utilizar uma solução de mensageria como o RabbitMQ.
- Armazenamento: Utilizar um banco NoSQL para armazenar grandes volumes de dados relacionados ao histórico de alterações, garantindo performance em escala.
- Testes Adicionais: Podemos aumentar a cobertura dos testes unitários com foco nas regras de negócio, incluindo testes para: Limite de tarefas por projeto, histórico de atualizações e relatórios de desempenho.
