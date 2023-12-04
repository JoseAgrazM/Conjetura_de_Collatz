namespace Conjetura_de_Collatz
{
    internal class Program
    {
        static int numMax = 0;
        static int numPasos = 0;

        static List<int> list = new List<int>();
        static void Main(string[] args)
        {
            int numero = Valor();

            int collatz = Conjetura_Collatz(numero, ref numMax, ref numPasos);

            Console.WriteLine($"Empezando en {numero} la sucesion tiene {numPasos} llegando hasta {numMax} antes de descender a 1");

            IterarList(list);

            Console.ReadKey();
        }
        static int Conjetura_Collatz(int n, ref int numMax, ref int numPasos)
        {
            list.Add(n);

            if (n == 1)
            {
                return n;
            }
            else if (n % 2 == 0)
            {
                numPasos++;

                if (n > numMax)
                {
                    numMax = n;
                }
                return Conjetura_Collatz(n / 2, ref numMax, ref numPasos) ;
            }
            else if (n % 2 == 1)
            {
                numPasos++;

                if (n > numMax)
                {
                    numMax = n;
                }
                return Conjetura_Collatz(3 * n + 1, ref numMax, ref numPasos);
            }

            return -1;
        }
        static int Valor()
        {
            while (true)
            {
                Console.WriteLine("Ingresa un numero para empezar la conjetura de Collatz");
                string numStr = Console.ReadLine();

                if (int.TryParse(numStr, out int numero) && numero > 0)
                {
                    return numero;
                }
                else
                {
                    Console.WriteLine("Ingresa un valor numerico.");
                }
            }

        }

        static void IterarList(List<int> list)
        {
            int numLinea = 0;
            foreach (int n in list)
            {
                if (numLinea == 20)
                {
                    Console.WriteLine();
                    numLinea = 0;
                }
                Console.Write(n + ", ");

                numLinea++;

            }
        }



        //static void Main(string[] args)
        //{

        //    double[,] matrix = Utils.Proc.MatrizCompleta();

        //    Console.WriteLine("Rellenada");
        //    Utils.Proc.ImprimirMatriz(matrix);

        //    Console.WriteLine("\n");

        //    Console.WriteLine("Impares potenciados");
        //    matrix = Utils.Proc.ValorImpar(matrix);
        //    Utils.Proc.ImprimirMatriz(matrix);



        //    //int numFila = ValorFila();
        //    //int numColumn = ValorColumn();

        //    //double[,] matriz = new double[numFila, numColumn];

        //    //Console.WriteLine("Matriz vacia.");

        //    //ImprimirMatriz(matriz);

        //    //Console.WriteLine('\n');

        //    //double[,] newMatriz = MatrizCompleta(matriz);

        //    //Console.WriteLine("Matrix con rellena.");

        //    //ImprimirMatriz(newMatriz);
        //    //Console.WriteLine('\n');


        //    //double[,] matrix = ValorImpar(newMatriz);

        //    //Console.WriteLine("Matriz con potentencias.");

        //    //ImprimirMatriz(matrix);
        //    //Console.WriteLine('\n');



        //    Console.ReadKey();
        //}

        ////static int Factorial(int n)
        ////{
        ////    if (n == 1)
        ////    {
        ////        return n;
        ////    }
        ////    else
        ////    {
        ////        return n * Factorial(n - 1);
        ////    }
        ////}


        ////static double[,] MatrizCompleta(double[,] matriz)
        ////{
        ////    Random random = new Random();

        ////    for (int i = 0; i < matriz.GetLength(0); i++)
        ////    {
        ////        for (int j = 0; j < matriz.GetLength(1); j++)
        ////        {
        ////            matriz[i, j] = random.Next(0, 11);
        ////        }
        ////    }
        ////    return matriz;
        ////}

        ////public static void ImprimirMatriz(double[,] matriz)
        ////{
        ////    foreach (int j in matriz)
        ////    {
        ////        Console.Write(j + ",");
        ////    }
        ////}

        ////public static int ValorColumn()
        ////{
        ////    Console.WriteLine("Ingresa el numero de columnas:");
        ////    string columna = Console.ReadLine();

        ////    if (int.TryParse(columna, out int numColumn))
        ////    {
        ////        return numColumn;
        ////    }
        ////    else
        ////    {
        ////        Console.WriteLine("Ingresa un numero valido");
        ////    }
        ////    return 0;
        ////}

        ////public static int ValorFila()
        ////{
        ////    Console.WriteLine("Ingresa el numero de filas:");
        ////    string fila = Console.ReadLine();

        ////    if (int.TryParse(fila, out int numFila))
        ////    {
        ////        return numFila;
        ////    }
        ////    else
        ////    {
        ////        Console.WriteLine("Ingresa un numero valido");
        ////    }
        ////    return 0;
        ////}




    }
}