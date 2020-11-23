using System;
using System.Collections.Generic;
using System.Text;

namespace Decisiones.Practicas
{
    public class MostrarSiLaDiferenciaEsPar
    {
        //Leer dos números enteros y determinar si la diferencia entre los dos es un número par.

        public void MostrarSiLaDiferenciaDeDosNumsEsPar()
        {
            int num1 = PedirNumero();
            int num2 = PedirNumero();
            int resultado = Restar(num1, num2);
            DefinirYMostrarSiUnNumEsPar(resultado);


        }
        private void DefinirYMostrarSiUnNumEsPar(int num)
        {
            if(num %2 == 0)
            {
                Console.WriteLine(num + ": Es un numero par");
            }
            else
            {
                Console.WriteLine(num + ": Es un numero impar");
            }
        }

        private int Restar(int num1, int num2)
        {
            int resta = num1 - num2;
            return resta;
        }

        public int PedirNumero()
        {
            Console.WriteLine("Escriba un numero");
            int num = int.Parse(Console.ReadLine());
            return num;
        }

    }
}
