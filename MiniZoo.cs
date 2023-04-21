public class MiniZoo
{
    private List<Animal> _animais;

    public MiniZoo()
    {
        _animais = new List<Animal>();
    }


    public void AddAnimal(Animal animal)
    {
        _animais.Add(animal);
    }

    public void EmitirSomDeTodosOsAnimais()
    {
        foreach (var t in _animais)
        {

            Console.WriteLine(t.EmitirSom() + "\n");
        }
    }

    public void ImprimirTodosOsAnimais()
    {
        foreach (var t in _animais)
        {
            t.GetInfo();
            Console.WriteLine("\n");
        }
    }
}
