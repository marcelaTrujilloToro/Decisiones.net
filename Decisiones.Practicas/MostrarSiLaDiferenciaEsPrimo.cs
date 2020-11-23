using System;
using System.Collections.Generic;
using System.Text;

namespace Decisiones.Practicas
{
    public class MostrarSiLaDiferenciaEsPrimo
    {
        //Leer dos números enteros y determinar si la diferencia entre los dos es un número primo.


        public void DefinirYMostrarSiLaDiferenciaEsPrimo()
        {
            int num1 = PedirNumero();
            int num2 = PedirNumero();
            int resultado = Restar(num1, num2);
            DefinirSiUnNumeroEsprimo(resultado);

        }

        private int Restar(int num1, int num2)
        {
            int resta = num1 - num2;
            return resta;
        }

        private void DefinirSiUnNumeroEsprimo(int num)
        {
            int contador = 0;
            for (int i = 1; i < (num + 1); i++ )
            {
                if(num % i == 0)
                {
                    contador++;
                }
            }
            if(contador != 2)
            {
                Console.WriteLine(num + ": No es primo");
            }
            else
            {
                Console.WriteLine(num + ": Es primo");
            }
        }
       

        private int PedirNumero()
        {
            Console.WriteLine("Escriba un numero");
            int num = int.Parse(Console.ReadLine());
            return num;
        }
    }
}
