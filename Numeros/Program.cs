using System;

namespace Numeros {
    class Program {
        static void Main (string[] args) {
            int num;
            Console.WriteLine ("Ingrese Numero");
            num = Convert.ToInt32 (Console.ReadLine ());
            nombreNumero (num);
            Console.ReadKey();
        }
        // Recibira como parametros dos numeros y devolvera
        static void nombreNumero (int numero) {
            switch (numero) {
                case 1:
                    Console.WriteLine ("Uno");
                    break;
                case 2:
                    Console.WriteLine ("Dos");
                    break;
                case 3:
                    Console.WriteLine ("Tres");
                    break;
                case 4:
                    Console.WriteLine ("Cuatro");
                    break;
                case 5:
                    Console.WriteLine ("Cinco");
                    break;
                case 6:
                    Console.WriteLine ("Seis");
                    break;
                case 7:
                    Console.WriteLine ("Siete");
                    break;
                case 8:
                    Console.WriteLine ("Ocho");
                    break;
                case 9:
                    Console.WriteLine ("Nueve");
                    break;
                case 10:
                    Console.WriteLine ("Diez");
                    break;
                default:
                    Console.WriteLine ("Opcion incorrecta");
                    break;
            }
        }
    }
}