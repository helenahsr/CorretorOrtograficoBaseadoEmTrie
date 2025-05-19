#     Corretor Ortográfico Baseado Em Trie

Este é um projeto simples de autocompletar/corretor ortográfico implementado utilizando a estrutura de dados Trie (também conhecida como árvore de prefixos). O objetivo principal é demonstrar a eficiência da Trie na sugestão de palavras com base em um prefixo digitado pelo usuário.

Feito para apresentação no seminário de AED-II em 19/05/2025.

## Funcionalidades

* **Inserção de Palavras:** Permite adicionar novas palavras ao dicionário da Trie.
* **Busca por Prefixo:** Dado um prefixo, o sistema retorna todas as palavras armazenadas na Trie que começam com esse prefixo.
* **Sugestões em Tempo Real (Simulado):** Embora este exemplo seja conceitual, ele demonstra a lógica por trás da sugestão de palavras à medida que o usuário digita.

## Estrutura do Projeto

O projeto consiste nos seguintes arquivos principais:

* **`TrieNo.cs`:** Define a estrutura do nó da Trie. Cada nó representa um caractere (ou o final de uma palavra).
* **`Trie.cs`:** Implementa a classe Trie, contendo os métodos para inserir palavras e buscar sugestões por prefixo.
* **`Form1.cs`:** Contém um exemplo de uso da Trie, demonstrando a inserção de palavras e a busca por sugestões.
* **`README.md`:** Este arquivo, fornecendo informações sobre o projeto.

## Implementação da Trie

A Trie é implementada com as seguintes características:

* Cada nó representa um caractere.
* A raiz representa uma string vazia.
* Cada nó pode ter até um filho para cada letra do alfabeto (neste exemplo, assumindo letras minúsculas).
* Um flag em cada nó indica se aquele nó marca o final de uma palavra completa.
