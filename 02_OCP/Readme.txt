  OPEN-CLOSED PRINCIPLE

  O OCP afirma que as classes devem estar "abertas para extensão, mas fechadas para modificação". Entre os benefícios podemos citar:
    - Facilidade de Extensão: Novas funcionalidades podem ser adicionadas sem alterar o código existente
    - Redução de bugs: Minimiza o risco de introduzir erros em funcionalidades já implementadas.
    - Extensibilidade: Novos comportamentos são adicionados por meio de novas classes.

  Exemplo de má prática: Modificar uma classe diretamente para adicionar um novo comportamento

  Sempre se pergunte: "Como tornar o código extensível, onde a adição de novas funcionalidades não deve significar modificar o código existente";
