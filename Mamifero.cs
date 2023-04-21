public class Mamifero : Animal
{
    public Mamifero(string nome, int idade) : base(nome, idade) { }


    public override string EmitirSom()
    { 
        return "";
    }
}
