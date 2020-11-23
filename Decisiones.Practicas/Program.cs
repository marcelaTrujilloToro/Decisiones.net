using System;

namespace Decisiones.Practicas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("MENU:");
            Console.WriteLine("");
            Console.WriteLine("1. Leer dos números, si la diferencia entre los dos es menor o igual a 10 entonces mostrar en pantalla todos los enteros comprendidos entre el menor y el mayor de los números leídos.");
            Console.WriteLine("2. Leer dos números enteros y determinar si la diferencia entre los dos es un número primo");
            Console.WriteLine("3. Leer dos números enteros y determinar si la diferencia entre los dos es un número par.");
            Console.WriteLine("4. Leer dos números enteros y si la diferencia entre los dos es un número divisor exacto de alguno.");
            Console.WriteLine("5. Leer un número entero de 4 dígitos y si el primer dígito es múltiplo de alguno de los otros dígitos.");
            Console.WriteLine("");
            int opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    MostrarNumerosEntreMenorYMayor();
                    break;
                case 2:
                    MostrarSiDiferenciaEntreDosNumsEsPrimo();
                    break;
                case 3:
                    MostrarSiLaRestaEsPar();
                    break;
                case 4:
                    MostrarSiElResultadoEsDivisor();
                    break;
                default:
                    MostrarSiElPrimerDigitoEsMultiploDeOtro();
                    break;

            }

        }

        public static void MostrarSiElPrimerDigitoEsMultiploDeOtro()
        {
            MostrarSiElPrimerDigitoEsMultiploDeOtro operacion = new MostrarSiElPrimerDigitoEsMultiploDeOtro();
            operacion.MostrarSiUnDigEsMultiploDeOtro();
        }

        public static void MostrarSiElResultadoEsDivisor()
        {
            MostrarSiLaDiferenciaEsDivisorDeAlguno operacion = new MostrarSiLaDiferenciaEsDivisorDeAlguno();
            operacion.MostrarSiLaDiferenciaEsDivisor();
        }

        public static void MostrarSiLaRestaEsPar()
        {
            MostrarSiLaDiferenciaEsPar operacion = new MostrarSiLaDiferenciaEsPar();
            operacion.MostrarSiLaDiferenciaDeDosNumsEsPar();
        }

         public static void MostrarSiDiferenciaEntreDosNumsEsPrimo()
        {
            MostrarSiLaDiferenciaEsPrimo operacion = new MostrarSiLaDiferenciaEsPrimo();
            operacion.DefinirYMostrarSiLaDiferenciaEsPrimo();
        }
        public static void MostrarNumerosEntreMenorYMayor()
        {
            MostrarNumsEntreMayorYMenor operacion = new MostrarNumsEntreMayorYMenor();
            operacion.MostrarNumsDelMenorAlMayor();
        }
    }
}
