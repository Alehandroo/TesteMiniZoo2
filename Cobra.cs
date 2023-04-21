using System;

public class Cobra : Reptil
{
    private double Comprimento { get; set; }

    public Cobra(string nome, int idade, double Comprimento) : base(nome, idade)
	{
		this.Comprimento = Comprimento;
	}

	public override string EmitirSom()
	{
		return "shhhhhhh";
	}

    public override void GetInfo()
    {
        base.GetInfo();
        Console.WriteLine($"Comprimento: {Comprimento}");
    }
}
