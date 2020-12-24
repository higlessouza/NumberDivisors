# Desafio - Localiza
Desafio do processo seletivo da localiza.

  - Desenvolvido por: Higles Souza
  - Email: higlessouza@gmail.com
  - Telefone: (31) 98257-7800

# Organização do projeto

### Model 
  - NumberModel

Responsável por gerenciar o modelo de dados. Um "NumberModel" contém um divisor e uma variavel que informa se o numero é primo.

### Service 
  - NumberDecompositionService

Responsável pelas regras do negócio, onde é realizado o cálculo dos divisores. Seu principal método retorna uma lista de "NumberModel".

### Controller 
  - NumberDecompositionServiceTest
Responsável por receber as chamadas REST da API. 

### Test
  - NumberDecompositionServiceTest

Responsável por realizar os testes unitários da aplicação

![N|Solid](https://i.ibb.co/vcY1V4r/testes.png)