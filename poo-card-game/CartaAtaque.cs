public class CartaAtaque : Carta
{
    public int Dano { get; }
    
    public CartaAtaque(string nome, string descricao, int energia, int dano) : base(nome, descricao, energia)
    {
        this.Dano = dano;
    }

    public override void Usar(Jogador jogador, Jogador oponente)
    {
        jogador.ConsumirEnergia(this);
        oponente.ReceberDano(this);
    }
}