using System;
using System.Collections.Generic;
using System.Text;

namespace Decisiones.Practicas
{
    public class MostrarSiElPrimerDigitoEsMultiploDeOtro
    {
        //Leer un número entero de 4 dígitos y determinar si el primer dígito es múltiplo de alguno de los
        // otros dígitos.
        public void MostrarSiUnDigEsMultiploDeOtro()
        {
            int num = PedirNumero();
            DividirEnDigitos(num);

        }

        private void DividirEnDigitos(int num)
        {
           if (num > 999 && num < 10000)
            {
                int dig1 = num / 1000;
                int residuo = num % 1000;
                int dig2 = residuo / 100;
                int residuo2 = residuo % 100;
                int dig3 = residuo2 / 10;
                int dig4 = residuo2 % 10;

                Console.WriteLine(dig1 + " " + dig2 + " " + dig3 + " " + dig4);

                DefinirSiEsMultiplo(dig1, dig2, dig3, dig4);
            }
            else
            {
                Console.WriteLine("El numero ingresado debe ser de 4 cifras");
            }
        }

        private void DefinirSiEsMultiplo(int dig1, int dig2, int dig3, int dig4)
        {
            if (dig2 % dig1 == 0 || dig3 % dig1 == 0 || dig4 % dig1 == 0)
            {
                Console.WriteLine(dig1 + " Es multiplo de alguno de los otros digitos");
            }
            else
            {
                Console.WriteLine(dig1 + " No es multiplo de alguno de los otros digitos");
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
