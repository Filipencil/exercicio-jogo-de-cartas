public class Jogador
{
    public string Nome { get; }
    public int Energia { get; private set; }
    public int Vidas { get; private set; }

    public Jogador(string nome) {
        Nome = nome;
        Energia = 10;
        Vidas = 30;
    }

    // exercícios:
    // método que consuma a energia do jogador.
    public void ConsumirEnergia(Carta carta) {
        Energia = Math.Max(0, this.Energia - carta.Energia);
    }

    // método que restaura a energia do jogador em 2 pontos, no máximo 10.
    public void RestaurarEnergia() {
        Energia = Math.Min(10, this.Energia + 2);
    }

    // exercícios:
    // restaurar a vida de acordo com uma carta.
    // receber um dano, de acordo com uma carta.
}