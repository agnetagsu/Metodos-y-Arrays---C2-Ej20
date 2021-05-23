using System;

namespace Metodos_y_Arrays___C2_Ej20
{
    class ArraysAleatoriosMultiplicacion
    {
        public void Rellenarvalores(int[] argarray, int min, int max)
        {
            ArraysAleatoriosMultiplicacion aleato = new ArraysAleatoriosMultiplicacion();

            for (int i = 0; i < argarray.Length; i++)
            {
                argarray[i] = aleato.aleatorio(min, max);
                
            }
        }

        public int[] Multiplicaarrays (int[] array1,int[] array2)
        {
            int[] resultadoarray = new int[array1.Length];

            for (int i = 0; i < array1.Length; i++)
            {
                resultadoarray[i] = array1[i]*array2[i];
            }

            return resultadoarray;
        }

        
        private int aleatorio(int min, int max)
        {
            Random numeroaleatorio = new Random();
            return numeroaleatorio.Next(min, max);
        }
        static void Main(string[] args)
        {
            int[] primerarray, segundoarray, tercerarray, cuartoarray;
            int max, min;
            int longitud;
            ArraysAleatoriosMultiplicacion miarray = new ArraysAleatoriosMultiplicacion();
            Console.WriteLine("Introduce la longitud del array:");
            longitud = Convert.ToInt32(Console.ReadLine());

            primerarray = new int[longitud];
            segundoarray = primerarray;
            tercerarray = new int[longitud];

            Console.WriteLine("Introduce el valor mínimo:");
            min = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduce el valor máximo:");
            max = Convert.ToInt32(Console.ReadLine());

            miarray.Rellenarvalores(primerarray, min, max);
            miarray.Rellenarvalores(tercerarray, min, max);

            cuartoarray = miarray.Multiplicaarrays(primerarray, tercerarray);
            for (int i = 0; i < primerarray.Length; i++)
            {
                Console.WriteLine("{0}  {1}  {2}",primerarray[i],tercerarray[i],cuartoarray[i]);
            }

        }
    }
}
