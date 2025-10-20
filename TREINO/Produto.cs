public class Produto
{
    private double preco;
    private int estoque;
    public string Nome { get; set; }
    public string Marca { get; set; }
    public double Preco
    {
        get => preco;
        set
        {
            if (value > 0)
                preco = value;
            else preco = 10;
        }
    }
    public int Estoque
    {
        get => estoque;
        set
        {
            if (value > 0)
                estoque = value;
            else estoque = 0;
        }
    }
    public void Info()
    {
        Console.WriteLine($"Produto {this.Nome} da marca {this.Marca} está custando {this.Preco} temos {this.Estoque} em estoque");
    }



}