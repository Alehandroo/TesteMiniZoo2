class Program
{
    static void Main(string[] args)
    {
        MiniZoo miniZoo = new MiniZoo();
        Cobra c1 = new Cobra("Pedro", 10, 20);
        Leão l1 = new Leão("Simba", 10, 14);
        Cobra c2 = new Cobra("João", 10, 10);
        miniZoo.AddAnimal(c1);
        miniZoo.AddAnimal(l1);
        miniZoo.AddAnimal(c2);
        miniZoo.EmitirSomDeTodosOsAnimais();
        miniZoo.ImprimirTodosOsAnimais();

    }
}
