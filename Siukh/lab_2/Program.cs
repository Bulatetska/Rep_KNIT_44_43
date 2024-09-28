using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1 task:
            Console.WriteLine("Task 1: ");

            int[] A = { 1, 2, 5, 6, 5, 2, 1, 3, 3, 4, 5, 6 };

            Console.WriteLine(A.Max());

            int count = 0;

            foreach (int i in A)
            {
                if (i == A.Max())
                {
                    count++;
                }
            }

            int index = Array.IndexOf(A, 6);

            Console.WriteLine("Count of maximum number in array: " + count + "\nThe index of " + A.Max() + " is " + index);

            // task 2:
            Console.WriteLine("\nTask 2: ");

            Random rand = new Random();

            int n = 3;
            double[,] array2 = new double[n, n];


            Console.WriteLine("Current array: ");

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    array2[i, j] = rand.Next(0,10);
                    Console.Write(array2[i, j]);
                }
                Console.WriteLine();
            }

            Console.WriteLine("Maximum value of matrix: ");

            double max = 0;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if(array2[i, j] > max)
                    {
                        max = array2[i, j];
                    }
                }
            }

            Console.WriteLine(max);

            Console.WriteLine("Complete array: ");

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (array2[i, j] == max)
                    {
                        array2[i,j] = 0;
                    }
                    Console.Write(array2[i, j]);
                }
                Console.WriteLine();
            }

            // task 3:
            Console.WriteLine("\nTask 3: ");

            double[] a3 = { 1, 5, 0, 0, -7, -8, 10, 11 };

            for(int i = 0;i < a3.Length-1; i++)
            {
                if(a3[i] == 0 && a3[i+1] == 0)
                {
                    Console.WriteLine("On " + i + " and " + (i + 1) + " indexes elements = 0");
                }
                if (a3[i] > 0 && a3[i+1] > 0)
                {
                    Console.WriteLine("On " + i + " and " + (i + 1) + " indexes elements > 0");
                }
            }

            // task 4:
            Console.WriteLine("\nTask 4: ");

            int n4 = 3, m4 = 4;
            double[,] a4 = new double[n4, m4];
            double total = 0;

            Console.WriteLine("Start array: ");

            for (int i = 0; i < n4; i++)
            {
                for(int j = 0; j < m4; j++)
                {
                    a4[i, j] = rand.Next(0, 10);
                    Console.Write(a4[i, j]);
                }
                Console.WriteLine();
            }

            Console.WriteLine("Average of array's elements: ");

            for (int i = 0; i < n4; i++)
            {
                for (int j = 0; j < m4; j++)
                {
                    total+= a4[i,j];
                }
            }

            double avg = total / (n4 * m4);
            Console.WriteLine(avg);

            Console.WriteLine("Complete array: ");

            for (int i = 0; i < n4; i++)
            {
                for (int j = 0; j < m4; j++)
                {
                    if(a4[i, j] < avg)
                    {
                        a4[i, j] = -1;
                    }
                    if (a4[i, j] > avg)
                    {
                        a4[i, j] = 1;
                    }
                    Console.Write(a4[i, j]);
                }
                Console.WriteLine();
            }

            // task 5:
            Console.WriteLine("\nTask 5: ");

            int[,] matrix5 = { 
                {1,2,5,10,5,9,1,2,6},
                {2,5,6,15,23,5,6,9,1},
                {5,6,7,8,5,4,3,5,0},
                {1,0,2,3,9,8,5,4,6},
                {24,5,6,4,24,5,6,2,2},
                {32,1,2,5,0,1,5,5,2}
            };

            Console.WriteLine("Most element of array: ");

            int mostElement = matrix5[0, 0];

            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (matrix5[i,j] > mostElement)
                    {
                        mostElement = matrix5[i,j];
                    }
                }
            }

            Console.WriteLine(mostElement);

            int selectRow = 0;

            for (int i = 0;i < 6; i++)
            {
                for(int j = 0;j < 9; j++)
                {
                    if(matrix5[i,j] == mostElement)
                    {
                        selectRow = i;
                    }
                }
            }

            int sum5 = 0;

            for(int i = 0; i<9 ; i++)
            {
                sum5 += matrix5[selectRow,i];
            }

            Console.WriteLine($"Sum of selected row: {sum5}");

            //task 6:
            Console.WriteLine("\nTask 6: ");
            double[] a6 = { 1.5, 1.7, 5.4, 6.9 };

            double sum6 = 0;

            foreach (double i in a6)
            {
                sum6 += i;
            }

            Console.WriteLine($"Sum of array = {sum6}");
        }
    }
}
