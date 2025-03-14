public class CartaDefesa : Carta
{
    public int Vida { get; }

    public CartaDefesa(string nome, string descricao, int energia, int vida) : base(nome, descricao, energia)
    {
        this.Vida = vida;
    }

    public override void Usar(Jogador jogador, Jogador oponente)
    {
        jogador.ConsumirEnergia(this);
        jogador.RestaurarVida(this);
    }
}