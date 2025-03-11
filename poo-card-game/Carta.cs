public class Carta 
{
    // atributos (campos, fields):
    private string nome;
    public string Descricao { get; } // propriedade { get; private set;}
    public int Energia { get; private set; }

    // construtor:
    // é o primeiro método a ser executado quando cria-se um objeto da classe.
    public Carta(string nome, string descricao, int energia)
    {
        this.nome = nome;
        this.Descricao = descricao;
        this.Energia = energia;
    }

    // Métodos:
    public string GetNome()
    {
        return nome;
    }

    // public void SetNome(string nome)
    // {
    //     this.nome = nome;
    // }

    public void Usar() 
    {
        // Refatorar usando Herança e conceitos de classe e métodos abstratos.
    }
}