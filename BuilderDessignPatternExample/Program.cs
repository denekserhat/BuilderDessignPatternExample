using System;

namespace BuilderDessignPatternExample
{
    class Program
    {
        static void Main(string[] args)
        {
            ArabaBuilder araba = new RenaultConcreteBuilder();
            ArabaUret uret = new ArabaUret();
            uret.Uret(araba);
            Console.WriteLine(araba.Araba.ToString());

            araba = new MercedesConcreteBuilder();
            uret.Uret(araba);
            Console.WriteLine(araba.Araba.ToString());

            Console.Read();
        }
    }
}
