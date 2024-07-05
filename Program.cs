namespace final
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("PROGRAMA PARA MULTIPLICAR MATRICES NxN");
            Console.WriteLine("Ingrese el numero de Filas y Columnas de la Matriz");
            int n = int.Parse(Console.ReadLine());

            int[][] matrizA = new int [n][];
            int[][] matrizB = new int [n][];
            int[][] matrizR = new int [n][];

            Console.WriteLine("Ingrese los datos de la matriz A:");
            Rellenar_matriz(matrizA, n);
            Console.WriteLine("Ingrese los datos de la matriz B:");
            Rellenar_matriz(matrizB, n);

            MultiplicarMatrizes(matrizA, matrizB, matrizR, n);

            Console.WriteLine("La multiplicacion de ambas matrices es:");
            MostrarMatriz(matrizR, n);
        }
        static void Rellenar_matriz(int[][] matriz, int n)
        {
            for (int i = 0; i < n; i++)
            {
                matriz[i] = new int[n];
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"Posicion [{i},{j}]:");
                    matriz[i][j] = int.Parse(Console.ReadLine());
                }
            }
        }
        static void MultiplicarMatrizes(int[][] matrizA, int[][] matrizB, int[][] matrizR, int n)
        {
            for (int i = 0; i < n; i++)
            {
                matrizR[i] = new int[n];
                for (int j = 0; j < n; j++)
                {
                    matrizR[i][j] = 0;
                    for (int k = 0; k < n; k++)
                    {
                        matrizR[i][j] += matrizA[i][k] * matrizB[k][j];
                    }
                }
            }
            
        }
        static void MostrarMatriz(int[][] matriz, int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(matriz[i][j] + " ");
                }
                Console.WriteLine();
            }
        }


    }
}
