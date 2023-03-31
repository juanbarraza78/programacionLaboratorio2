namespace biblioteca
{
 
    public class Validador{  
        static void Main(string[] args)
        {
            bool Validar(int valor, int min, int max)
            {
                bool respuesta = false;
                if (valor >= min && valor >= max)
                {
                    respuesta = true;
                }
                return true;
            }
        }

    }
}