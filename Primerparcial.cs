using System;

namespace ROT13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el mensaje a codificar/decodificar en ROT13:");
            string ingresar = Console.ReadLine();

            Console.WriteLine("1. Codificar");
            Console.WriteLine("2. Decodificar");
            Console.WriteLine("Elija una opción:");
            int opcion = int.Parse(Console.ReadLine());

            string resultado = "";
            switch (opcion)
            {
                case 1:
                    resultado = CodificarROT13(ingresar);
                    Console.WriteLine("Mensaje codificado: " + resultado);
                    break;
                case 2:
                    resultado = CodificarROT13(ingresar);
                    Console.WriteLine("Mensaje decodificado: " + resultado);
                    break;
                default:
                    Console.WriteLine("Opción inválida");
                    break;
            }
        }

        static string CodificarROT13(string ingresar)
        {
            char[] ingresarm = ingresar.ToCharArray();
            for (int i = 0; i < ingresarm.Length; i++)
            {
                char letra = ingresarm[i];
                if (letra >= 'a' && letra <= 'z')
                {
                    ingresarm[i] = (char)((letra - 'a' + 13) % 26 + 'a');
                }
                else if (letra >= 'A' && letra <= 'Z')
                {
                    ingresarm[i] = (char)((letra - 'A' + 13) % 26 + 'A');
                }
            }
            return new string(ingresarm);
        }

        static string DecodificarROT13(string ingresar)
        {
            char[] ingresarm = ingresar.ToCharArray();
            for (int i = 0; i < ingresarm.Length; i++)
            {
                char letra = ingresarm[i];
                if (letra >= 'a' && letra <= 'z')
                {
                    ingresarm[i] = (char)((letra - 'a' - 13 + 26) % 26 + 'a');
                }
                else if (letra >= 'A' && letra <= 'Z')
                {
                    ingresarm[i] = (char)((letra - 'A' - 13 + 26) % 26 + 'A');
                }
            }
            return new string(ingresarm);
        }
    }
}
