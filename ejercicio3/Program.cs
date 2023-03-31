// using biblioteca.CalculoDeArea

namespace ejercicio3
{
    public class Program
    {
        static void Main(string[] args)
        {
            double resultado1;
            double resultado2;
            double resultado3;
            resultado1 = biblioteca.CalculoDeArea.CalcularCuadrado(2);
            resultado2 = biblioteca.CalculoDeArea.CalcularTriangulo(3,2);
            resultado3 = biblioteca.CalculoDeArea.CalcularCirculo(4);
            Console.WriteLine(resultado1);
            Console.WriteLine(resultado2);
            Console.WriteLine(resultado3);
        }
    }
} 