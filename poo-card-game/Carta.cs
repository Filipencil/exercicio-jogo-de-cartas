public abstract class Carta 
{
    // atributos (campos, fields):
    public string Nome { get; }
    public string Descricao { get; } // propriedade { get; private set;}
    public int Energia { get; private set; }

    // construtor:
    // é o primeiro método a ser executado quando cria-se um objeto da classe.
    public Carta(string nome, string descricao, int energia)
    {
        this.Nome = nome;
        this.Descricao = descricao;
        this.Energia = energia;
    }

    public abstract void Usar(Jogador jogador, Jogador oponente);
}