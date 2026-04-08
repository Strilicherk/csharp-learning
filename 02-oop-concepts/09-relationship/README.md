[![Review Assignment Due Date](https://classroom.github.com/assets/deadline-readme-button-22041afd0340ce965d47ae6ef1cefeee28c7c493a6346c4f15d667ab976d596c.svg)](https://classroom.github.com/a/8nMnoIo-)
# Exercício Relacionamento 📎

## Orientações Gerais: 🚨
1. Utilize **apenas** tipos **wrapper** para criar atributos e métodos.
2. **Respeite** os nomes de atributos e métodos definidos no exercício.
3. Tome **cuidado** com os **argumentos** especificados no exercício.
   **Não** adicione argumentos não solicitados e mantenha a ordem definida no enunciado.
4. Verifique se **não** há **erros de compilação** no projeto antes de enviar.
5. As classes devem seguir as regras de encapsulamento.

## Carrinho 

Implemente o seguinte diagrama de classes:

![Diagrama de Classes](carrinho.png)


### Métodos da classe `Produto`:

* Deve conter todos os getters e setters



### Métodos da classe `Carrinho`

- `Integer getQuantidade()`:

  * **Retorna** a quantidade de `Produtos` incluídos no `Carrinho`


- `void adicionar(Produto produto)`:
  * Adiciona o produto recebido na lista de produtos


- `Boolean existsPorNome(String nome)`:
  * **Retorna** se um produto existe dentro do `Carrinho` pelo nome
  * Deve ignorar letras maiúsculas e minúsculas (Case Insensitive)

  

- `Integer getQuantidadePorCategoria(String nome)`:
  * **Retorna** a quantidade produtos de uma determinada categoria

  

- `void limpar()`
  * Remove todos os produtos do carrinho

  
- `void removerPorNome(String nome)`
  * Remove um produto de dentro do carrinho a partir do nome
  * Deve ignorar letras maiúsculas e minúsculas (Case Insensitive)


- `Produto getPorNome(String nome)`
  * **Retorna** o produto do carrinho a partir do nome
  * Caso o produto não seja encontrado retorne null
  * Deve ignorar letras maiúsculas e minúsculas (Case Insensitive)


- `Double getValorTotal()`
  * **Retorna** a soma dos preços de todos os produtos
