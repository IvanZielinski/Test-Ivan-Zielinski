using System;

namespace Ejercicio_EY
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter username:");


            string entrada = Console.ReadLine().Replace(" ", "");
            string salida = string.Empty;
            int row = int.Parse(Math.Floor(Math.Sqrt(entrada.Length)).ToString());
            int column = int.Parse(Math.Ceiling(Math.Sqrt(entrada.Length)).ToString());
            int pos = 0;

            if ((column * row) < entrada.Length) row += 1;

            char[,] entradaMatriz = new char[row, column];

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    if(pos < entrada.Length)
                    entradaMatriz[i, j] = entrada[pos];
                    pos++;
                }
            }

            for (int j = 0; j < column; j++)
            {
                for (int i = 0; i < row; i++)
                {
                    salida += entradaMatriz[i, j];
                }
                salida += ' ';
            }

            Console.WriteLine(salida);
        }
    }
}
