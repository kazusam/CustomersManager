# CustomersManager

Este projeto tem o objetivo de fazer o controle de clientes através de uma API. Dividindo-se em 3 partes (Models, Business e API).

Os dados estão sendo armazenados dentro de uma pasta em "C:\Data", no formato JSON, nomeados através da chave PK dos clientes cadastrados. Ou seja, é necessário que exista esta pasta, contudo ela pode ser modificada através do projeto Business, na classe "Customer.cs".

Como a API não tem interface, foi utilizado uma interface (UI Swagger) para que seja possível testar os end-points:
  - https://localhost:44392/swagger/index.html

Para ter acesso ao Health Check, da mesma maneira, foi utilizado uma interface (UI HealthCheck) para verificar a saúde da API:
  - https://localhost:44392/healthchecks-ui
