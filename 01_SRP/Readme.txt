SINGLE RESPONSIBILITY PRINCIPLE

O SRP afirma que uma classe deve ter apenas uma responsabilidade e uma razão para mudar. Entre os benefícios podemos citar:
  - Manutenção facilitada: Classes com uma responsabilidade específica são mais fáceis de entender e modificar.
  - Reutilização e Testes: Classes focadas em uma única responsabilidade são mais reutilizáveis e fáceis de testar.

Exemplo de má prática: Uma classe que lida com lógica de negócios e também se encarrega de salvar dados no banco.

Sempre se pergunte: "Esta classe tem mais de uma razão para mudar? Se a resposta for sim, ela está ferindo o SRP"