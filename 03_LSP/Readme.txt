LISKOV SUBSTITUTION PRINCIPLE

O LSP afirma que objetos de uma classe derivada devem poder substituir objetos de sua classe base sem alterar a funcionalidade do programa. 
Entre os benefícios podemos citar:
	- Consistência e Confiabilidade: Classes derivadas devem manter o comportamento esperado da classe base.
	- Polimorfismo Seguro: Permite que substituições sejam feitas sem quebrar o código.
	
Exemplo de má prática: Classes derivadas que alteram ou invalidam funcionalidades da classe base.

Dica Final: Certifique-se de que as classes derivadas respeitam o comportamento esperado da classe base.

Sempre se pergunte: Essa classe derivada pode realmente substituir a classe base sem problemas?
