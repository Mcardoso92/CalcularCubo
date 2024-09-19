using System;

namespace EJERCICIO_2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            //SE AGREGO COMENTARIO
            //CALCULAR EL CUBO DE UN NUMERO
            //PASO 0: DECLARACION DE VARIABLES
            int N1, RESULTADO;

            //PASO 1: SOLICITAR UN NUMERO
            Console.WriteLine("INGRESE UN NUMERO: ");
            N1 = int.Parse(Console.ReadLine());

            //PASO 2: CALCULAR EL CUBO
            RESULTADO = N1*N1*N1;

            //PASO 3: MOSTRAR RESULTADO
            Console.WriteLine("EL CUBO DEL NRO INGRESADO ES: " + RESULTADO);

        }
    }
}
