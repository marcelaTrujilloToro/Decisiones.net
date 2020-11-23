using System;
using System.Collections.Generic;
using System.Text;

namespace Decisiones.Practicas
{
    public class MostrarSiLaDiferenciaEsDivisorDeAlguno
    {
        //Leer dos números enteros y determinar si la diferencia entre los dos es un número divisor
        // exacto de alguno de los dos números.

        public void MostrarSiLaDiferenciaEsDivisor()
        {
            int num1 = PedirNumero();
            int num2 = PedirNumero();
            int resultado = Restar(num1, num2);
            DefinirSiLaDiferenciaEsDivisor(resultado, num1, num2);
        }


        private void DefinirSiLaDiferenciaEsDivisor(int resultado, int num1, int num2)
        {
            if (num1 % resultado == 0 || num2 % resultado ==0)
            {
                Console.WriteLine(resultado + " Es divisor de al menos uno de los otros numeros");
            }
            else
            {
                Console.WriteLine(resultado + " No es divisor de ninguno de los dos numeros");
            }
        }

        private int Restar(int num1, int num2)
        {
            int resta = num1 - num2;
            return resta;
        }

        private int PedirNumero()
        {
            Console.WriteLine("Escriba un numero");
            int num = int.Parse(Console.ReadLine());
            return num;
        }
    }
}
