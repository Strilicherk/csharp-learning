[![Review Assignment Due Date](https://classroom.github.com/assets/deadline-readme-button-22041afd0340ce965d47ae6ef1cefeee28c7c493a6346c4f15d667ab976d596c.svg)](https://classroom.github.com/a/ebrxTKAc)
# Avaliação Continuada 01 - Prática 📎

## 📌 Orientações Gerais:
1. Utilize **apenas** tipos **wrapper** para criar variáveis.
2. Verifique se **não** há **erros de compilação** no projeto antes de enviar.
3. Respeite os nomes de atributos e métodos definidos no exercício.
4. Tome cuidado com os argumentos especificados no exercício. Não adicione argumentos não solicitados e mantenha a ordem definida no enunciado.

> Dica: copie e cole os nomes do enunciado para evitar erros de digitação

## 🚨 Orientações para a avaliação

1. **Não é permitido** utilizar o material de aula para consulta.
2. **Não é permitido** consultar a internet.
3. **Não é permitido** utilizar qualquer tipo de inteligência artificial.
4. **Não é permitido** o uso de celular.
5. **Não é permitido** a comunicação com colegas.
6. **Não é permitido** pedir ajuda ao professor.

## 🎬 Cinema

Você é o desenvolvedor de um sistema feito em Java da rede de cinemas CineTech e foi solicitado a você a 
implementação de alguns métodos para ajudar na operação do cinema.

Para isso foi entregue uma documentação detalhada a respeito do funcionamento dessa rede de cinemas:

### 💺 Sala

O preço das salas são calculados da seguinte forma:

O preço base da sala é de R\$ 30,00.\
A sala 3D adiciona R\$ 5,00 a mais ao preço do ingresso.\
A sala IMAX adiciona R\$ 10,00 a mais ao preço do ingresso.

O cinema CineTech possui 4 salas:

* **Sala 1:** 
  * Sala comum
  * Capacidade: 50 lugares
  * Preço: R\$ 30,00


* **Sala 2:**
  * Sala 3D
  * Capacidade: 37 lugares
  * Preço: R\$ 35,00


* **Sala 3:** 
  * Sala IMAX
  * Capacidade: 90 lugares
  * Preço: R\$ 40,00


* **Sala 4:** 
  * Sala 3D e IMAX
  * Capacidade: 80 lugares
  * Preço: R\$ 45,00

### Observações:
* Na compra do ingresso, estudantes podem solicitar meia entrada e pagar metade do
valor do ingresso.
* O cinema **sempre lucra 10%** do valor de cada ingresso vendido.

### 🛠️ Implementação

Com a documentação em mãos, você deve criar dentro da classe `Cinema` os seguintes métodos:

* `Boolean validarSala(Integer sala)`
  * Verifica se o número da sala é válido.
  * Retorna `true` se o número da sala for válido e `false` caso contrário.
  * Exemplo: se o número da sala for 3, o retorno é `true`.
  * Exemplo: se o número da sala for 5, o retorno é `false`.


* `Double calcularValorIngresso(Integer sala, Boolean meiaEntrada)`
  * Calcula o valor do ingresso conforme a sala e se é meia entrada ou não.
  * Exemplo: se a sala for 3D e o ingresso for meia entrada, o valor do ingresso é R$ 17,50.
  * Exemplo: se a sala for IMAX e o ingresso for inteira, o valor do ingresso é R$ 40,00.
  * Caso a sala seja inválida retorne 0,0.


* `Double calcularLucroTotal(Integer[] salas, Boolean[] estudantes)`
  * Calcula o lucro total do cinema conforme o vetor de salas e estudantes.
  * Cada posição do vetor representa um ingresso e o programa deve juntar as informações de ambos os vetores para obter a informação completa do ingresso.
  * Exemplo: 
    * salas[0] = 2
    * estudantes[0] = false 
    * **Resultado:** Ingresso comum na sala 2
  * Exemplo:
    * salas[1] = 4
    * estudantes[1] = true
    * **Resultado:** Ingresso de estudante na sala 4
  * Calcule o lucro conforme a documentação fornecida.


### 🍅 Tomatômetro:
O Rotten Tomatoes coleta críticas de críticos profissionais (geralmente de publicações respeitadas).
Cada crítica é classificada como "Fresh" (positiva) ou "Rotten" (negativa).
O score do Tomatômetro é a porcentagem de críticas que são Fresh.

Fórmula:

$$
\text{Tomatômetro} = \left( \frac{\text{número de críticas Fresh}}{\text{total de críticas}} \right) \times 100
$$

#### O que significam os selos?

| Selo                       | Condição                                           |
|----------------------------|----------------------------------------------------|
| Fresh 🍅   | Se o filme tem 60% ou mais de críticas positivas.  |
| Rotten 🤢 | Se o filme tem menos de 60% de críticas positivas. |

Para melhorar a qualidade dos filmes exibidos no CineTech foi solicitado a implementação de um sistema que calcula 
o selo tomatômetro dos filmes que entrarão em cartaz.

### 🛠️ Implementação

* `String calcularSeloTomatometro(Boolean[] reviews)`
  * Calcula o selo do Rotten Tomatoes de acordo com as reviews do filme
  * O vetor reviews armazena cada review como valor boolean
    * true: review positiva
    * false: review negativa
  * O método **deve retornar** apenas **"fresh"** ou **"rotten"** (em caixa baixa)
  * **Cuidado:** converta os valores para double, caso contrário o Java fará a divisão inteira.
  * Exemplo:
    * reviews = [true, true, false, true]
    * score = 3 / 4 * 100 = 75%
    * selo = fresh

## 📓 Orientações Finais:

### 🎯 Observações:

1. O projeto contém testes automatizados para verificar a implementação dos métodos.
2. A classe `Cinema` já está criada e os métodos devem ser implementados dentro dela.
3. O projeto possui uma classe `Main` caso queira testar manualmente o funcionamento dos métodos.

### 📦 Entrega:

1. Faça o `commit` do código e após isso o `push` para o repositório do GitHub.
2. Abra o **GitHub** e **verifique** se o último `push` foi realizado com sucesso.

### Boa sorte! 🍀
