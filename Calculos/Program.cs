using System;

namespace Calculos {
    class Program {
        static void Main (string[] args) {
            int[] numeros;
            int cantidad;
            string operacion;
            Console.WriteLine ("Ingrese operacion");
            operacion = Console.ReadLine ();
            Console.WriteLine ("Ingrese cantidad de numeros: ");
            cantidad = Convert.ToInt32 (Console.ReadLine ());
            numeros = new int[cantidad];
            for (int i = 0; i < cantidad; ++i) {
                Console.WriteLine ("ingrese numero " + (i + 1));
                numeros[i] = Convert.ToInt32 (Console.ReadLine ());
            }

            Console.WriteLine ("El resultado de " + operacion + " Es : " + Operacion (operacion, numeros));
            Console.ReadKey ();

        }

        static int Operacion (string operacion, int[] lista) {
            int producto = 1, suma = 0;
            if (operacion == "suma" || operacion == "Suma") {
                for (int i = 0; i < lista.Length; ++i) {
                    suma += lista[i];
                }
                return suma;
            }
            if (operacion == "producto" || operacion == "Producto") {
                for (int i = 0; i < lista.Length; ++i) {
                    producto = producto * lista[i];
                }
                return producto;
            }
            return 0;

        }
    }
}