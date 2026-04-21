# Strategy
O Strategy permite que você mude a maneira como um objeto faz alguma coisa em tempo de execução, sem precisar mudar o objeto em si.

Em vez de ter um método cheio de if/else, você extrai cada variação de comportamento para uma classe separada. O objeto principal (Contexto) delega a execução para a estratégia escolhida.