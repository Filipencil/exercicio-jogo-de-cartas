Carta carta1 = new Carta("Golpe Rápido", "Um corte veloz que fere o oponente.", 1);
Carta cartaA = new CartaAtaque("Golpe Forte", "Um golpe forte que causa muito dano.", 3, 5);
Carta cartaD = new CartaDefesa("Escudo", "Um escudo que protege de ataques.", 3, 3);

Jogador jogador1 = new Jogador("Jogador 1");
Jogador jogador2 = new Jogador("Jogador 2");

cartaA.Usar(jogador1, jogador2);
cartaD.Usar(jogador2, jogador1);

console.WriteLine(jogador1.Vidas);
console.WriteLine(jogador2.Vidas);

Console.WriteLine(carta1.GetNome());
Console.WriteLine(carta1.Descricao);
Console.WriteLine(carta1.Energia);