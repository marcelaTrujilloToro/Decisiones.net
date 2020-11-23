using System;
using System.Collections.Generic;
using System.Text;

namespace Decisiones.Practicas
{
    public class MostrarNumsEntreMayorYMenor
    {

        //Leer dos números enteros y si la diferencia entre los dos es menor o igual a 10 entonces
        // mostrar en pantalla todos los enteros comprendidos entre el menor y el mayor de los números
        // leídos.

        public void MostrarNumsDelMenorAlMayor ()
        {
            int num1 = PedirNumero();
            int num2 = PedirNumero();
            int resultado = Restar(num1, num2);
            MostrarNumeros(resultado, num1, num2);
            Console.WriteLine("");
            

        }

        private void MostrarNumeros(int resultado, int num1, int num2)
        {
            if (resultado <= 10)
            {
                if (num1 < num2)
                {
                    while (num1 <= num2)
                    {
                        Console.WriteLine( num1);
                        num1++;
                    }



                }
                else
                {
                    while (num2 <= num1)
                    {
                        Console.WriteLine( num2);
                        num2++;
                    }
                }
               
            }
        }

        public int Restar(int num1, int num2)
        {
           int resultado = num1 - num2;

            return resultado;
        }
      

        public int PedirNumero()
        {
            Console.WriteLine("Escriba un numero");
            int num = int.Parse(Console.ReadLine());
            return  num;
        } 


      

    }
}
