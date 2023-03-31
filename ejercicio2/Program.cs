namespace ejercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numeroIngresado;
            bool respuesta;
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Ingrese edad de la mascota (0-12)");
                respuesta = int.TryParse(Console.ReadLine(), out numeroIngresado);
            }
        }
    }
}