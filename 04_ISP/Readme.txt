INTERFACE SEGREGATION PRINCIPLE

O ISP afirma que uma interface não deve forçar classes a implementar métodos que elas não utilizam. Entre os benefícios podemos citar:
	- Flexibilidade e Clareza: Interfaces específicas evitam que classes implementem métodos desnecessários.
	- Manutenção e Testes Fáceis: Classes ficam mais fáceis de manter e testar, pois tem interfaces enxutas e focadas.
	
Exemplo de má prática: Interfaces grandes que obrigam classes a implementar métodos irrelevantes para elas.

Dica Final: Quando for projetar as interfaces, pergunte-se se todas as classes realmente precisarão de todos os métodos. Se a resposta for "Não", 
é hora de aplicar o ISP

Sempre se pergunte: Todas as classes que implementarem esta interface precisam NECESSARIAMENTE de todos esses métodos?