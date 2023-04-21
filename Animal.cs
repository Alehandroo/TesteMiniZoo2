using System.Xml.Linq;

public abstract class Animal
{
    private string Nome { get; set; }
    private int Idade { get; set; }

    public Animal(string nome, int idade)
    {
        Nome = nome;
        Idade = idade;
    }

    public virtual void GetInfo()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Idade: {Idade}");
    }

    abstract public string EmitirSom();
}
