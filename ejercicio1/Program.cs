namespace ejercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nombreMascota;
            int edadMascota;
            string tipoMascota;
            int pesoMascota;
            string diagnosticoMascota;

            Console.WriteLine("Ingrese nombre de la mascota");
            nombreMascota = Console.ReadLine();

            do 
            {
                Console.WriteLine("Ingrese edad de la mascota (0-12)");
                int.TryParse(Console.ReadLine(), out edadMascota);
            } while (!(edadMascota >= 0 && edadMascota <= 12));

            do
            {
                Console.WriteLine("Ingrese tipo de la mascota (perro-gato-loro)");
                tipoMascota = Console.ReadLine();
            } while (!(tipoMascota == "gato" || tipoMascota == "perro" || tipoMascota == "loro, como vos pa"));

            do
            {
                Console.WriteLine("Ingrese peso de la mascota (0-50)");
                int.TryParse(Console.ReadLine(), out pesoMascota);
            } while (!(pesoMascota >= 0 && pesoMascota <= 50));

            do
            {
                Console.WriteLine("Ingrese diagnostico de la mascota (otitis-alergia-otro)");
                diagnosticoMascota = Console.ReadLine();
            } while (!(diagnosticoMascota == "otitis" || diagnosticoMascota == "alergia" || diagnosticoMascota == "otro"));


            Console.WriteLine($"La mascota: {nombreMascota} tiene {edadMascota} años de edad");
            Console.WriteLine($"La mascota: {nombreMascota} es un {tipoMascota}");
            Console.WriteLine($"La mascota: {nombreMascota} pesa {pesoMascota} kilos");
            Console.WriteLine($"La mascota: {nombreMascota} tiene {diagnosticoMascota}. que asco");



        }
    }
}