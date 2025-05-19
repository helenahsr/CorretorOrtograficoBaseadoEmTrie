#     Corretor Ortográfico Baseado Em Trie

Este é um projeto simples de autocompletar/corretor ortográfico implementado utilizando a estrutura de dados Trie (também conhecida como árvore de prefixos). O objetivo principal é demonstrar a eficiência da Trie na sugestão de palavras com base em um prefixo digitado pelo usuário.

Feito para apresentação no seminário de AED-II em 19/05/2025.

## Funcionalidades

* **Inserção de Palavras:** Permite adicionar novas palavras ao dicionário da Trie.
* **Busca por Prefixo:** Dado um prefixo, o sistema retorna todas as palavras armazenadas na Trie que começam com esse prefixo.
* **Sugestões em Tempo Real (Simulado):** Embora este exemplo seja conceitual, ele demonstra a lógica por trás da sugestão de palavras à medida que o usuário digita.

## Estrutura do Projeto

O projeto consiste nos seguintes arquivos principais:

* **`TrieNode.cs`:** Define a estrutura do nó da Trie. Cada nó representa um caractere (ou o final de uma palavra).
* **`Trie.cs`:** Implementa a classe Trie, contendo os métodos para inserir palavras e buscar sugestões por prefixo.
* **`Program.cs` (ou um arquivo de exemplo):** Contém um exemplo de uso da Trie, demonstrando a inserção de palavras e a busca por sugestões.
* **`README.md`:** Este arquivo, fornecendo informações sobre o projeto.

## Como Usar

1.  **Clone o repositório (se aplicável):**
    ```bash
    git clone [https://github.com/dolthub/dolt](https://github.com/dolthub/dolt)
    ```

2.  **Abra o projeto em sua IDE C# preferida (Visual Studio, VS Code, etc.).**

3.  **Execute o projeto `Program.cs` (ou o arquivo de exemplo).** O código de exemplo demonstrará como inserir palavras na Trie e como obter sugestões com base em um prefixo.

    ```csharp
    // Exemplo de uso (pode estar no Program.cs)
    Trie autocomplete = new Trie();

    autocomplete.Insert("apple");
    autocomplete.Insert("apricot");
    autocomplete.Insert("banana");
    autocomplete.Insert("band");
    autocomplete.Insert("orange");

    string prefixo = "ap";
    List<string> sugestoes = autocomplete.GetSuggestions(prefixo);

    Console.WriteLine($"Sugestões para o prefixo '{prefixo}':");
    foreach (string palavra in sugestoes)
    {
        Console.WriteLine($"- {palavra}");
    }
    // Saída esperada:
    // Sugestões para o prefixo 'ap':
    // - apple
    // - apricot
    ```

## Implementação da Trie

A Trie é implementada com as seguintes características:

* Cada nó representa um caractere.
* A raiz representa uma string vazia.
* Cada nó pode ter até um filho para cada letra do alfabeto (neste exemplo, assumindo letras minúsculas).
* Um flag em cada nó indica se aquele nó marca o final de uma palavra completa.

## Contribuições

Contribuições são bem-vindas\! Sinta-se à vontade para abrir issues para relatar bugs ou propor novas funcionalidades. Pull requests também são encorajados.

## Licença

[Adicione aqui a licença sob a qual o projeto está distribuído (por exemplo, MIT License).]

## Autor

[Seu Nome/Nome da Organização]
[Seu Email (opcional)]
[Seu GitHub (opcional)]

---

**Observações:**

* Este README é um modelo básico. Você pode expandi-lo com mais detalhes sobre a implementação, otimizações, testes, etc.
* Certifique-se de substituir os placeholders (como URL do Repositório, Licença, Autor) com as informações reais do seu projeto.
* Se o seu projeto tiver dependências, adicione uma seção sobre como instalá-las.
* Considere adicionar exemplos de uso mais complexos ou casos de borda.
* Se você planeja adicionar testes unitários, mencione isso e como executá-los.
