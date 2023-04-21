using System;
using static System.Net.Mime.MediaTypeNames;

public class Leão : Mamifero
{
    private int TamanhoDoGrupo { get; set; }


    public Leão(string nome, int idade, int TamanhoDoGrupo) : base(nome, idade) 
	{
		this.TamanhoDoGrupo = TamanhoDoGrupo;
	}

    public override string EmitirSom()
    {
       return "Rrrrrrawrrr";
    }

    public override void GetInfo()
    {
        base.GetInfo();
        Console.WriteLine($"TamanhoDoGrupo: {TamanhoDoGrupo}");
    }
}
