[![Review Assignment Due Date](https://classroom.github.com/assets/deadline-readme-button-22041afd0340ce965d47ae6ef1cefeee28c7c493a6346c4f15d667ab976d596c.svg)](https://classroom.github.com/a/q9-mdhgp)
# Revisão - Métodos 📎

## Orientações Gerais: 🚨

1. Utilize **apenas** tipos **wrapper** para criar variáveis.
2. Verifique se **não** há **erros de compilação** no projeto antes de enviar.

3. Respeite os nomes de atributos e métodos definidos no exercício.
4. Tome cuidado com os argumentos especificados no exercício. Não adicione argumentos não
   solicitados e mantenha a ordem definida no enunciado.

## Exercício 1

Dentro da classe GerenciadorDeNotas escreva os seguintes métodos:

- `List<Double> lerNotas()`:
    - Este método pede ao usuário para inserir o número de notas e, em seguida, lê cada nota do
      console, adicionando-a à lista de notas.
    - Retorna a lista de notas
    - Caso o usuário informe um valor inválido (menor que 1) para a quantidade de notas, retorne uma
      lista vazia.

- `Double calcularMedia(List<Double> notas)`:
    - Calcula a média das notas fornecidas, somando todas elas e dividindo pelo número total de
      notas.
    - Caso a lista esteja nula ou vazia deve retornar null

- `Boolean verificarResultado(Double media)`:
    - Retorna se o aluno está aprovado ou reprovado, considerando 7.0 como a nota mínima para
      aprovação.
    - Retorna null caso o valor da média seja nulo ou negativo

- `void calcularDiferenca(List<Double> notas, Double media)`:

    - Este método recebe uma lista de notas e calcula a diferença entre cada nota e a média.
    - Caso a nota seja igual a média, exiba a mensagem:
      ```
      A nota X está na média.
      ```
      Caso a nota esteja acima da média, exiba a mensagem:
      ```
      A nota X está Y ponto(s) acima da média.
      ```
      Caso a nota esteja abaixo da média, exiba a mensagem:
      ```
      A nota X está Y ponto(s) abaixo da média.
      ```


- `Double calcularMediaPonderada(List<Double> notas)`
    - Este método lê no console um peso para cada nota fornecida e adiciona em uma lista de pesos.
    - Calcula a média ponderada das notas, multiplicando cada nota pelo seu respectivo peso e
      dividindo pela soma dos pesos. Por exemplo:
        - notas: [5.0, 6.0, 7.0]
        - pesos: [1.0, 2.0, 3.0]
        - média ponderada = (5.0 * 1.0 + 6.0 * 2.0 + 7.0 * 3.0) / (1.0 + 2.0 + 3.0) = 6.33

Dentro do método `Main` chame os métodos.


