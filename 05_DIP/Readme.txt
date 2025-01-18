Dependency Inverse Principle

O DIP afirma que módulos de alto nível não devem depender de módulos de baixo nível, mas sim de abstrações. Abstrações não devem depender de detalhes; 
os detalhes é que devem depender das abstrações. Entre os benefícios podemos citar:
	- Desacoplamento: Facilita a troca de implementações sem impactar o código de alto nível..
	- Facilidade de Teste: Módulos podem ser testados isoladamente usando abstrações..
	
Exemplo de má prática: Um módulo de alto nível que depende diretamente de uma classe concreta de baixo nível..

Dica Final: Verifique se as classes de alto nível estão acopladas a classes de baixo nível. Se sim, considere introduzir abstrações
para facilitar a manutenção, evolução e testes do seu código.

Sempre se pergunte: Esta classe está dependendo de classes concretas? Se sim considere torenar ela dependente de abstrações (interfaces ou classes abstratas).