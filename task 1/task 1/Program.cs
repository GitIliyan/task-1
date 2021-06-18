using System;

namespace task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the amount of goats: ");
            int N = int.Parse(Console.ReadLine());
            while(N<=1 || N>=1000)
            {
                Console.WriteLine("Input must be between 1 and 1000");
                N = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Enter the amount of trips: ");
            int K = int.Parse(Console.ReadLine());
            while (K <= 1 || K >= 1000)
            {
                Console.WriteLine("Input must be between 1 and 1000");
                K = int.Parse(Console.ReadLine());
            }
            int[] A = new int[N];
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine("Goat's weight");
                A[i] = int.Parse(Console.ReadLine());
                while (A[i] <= 1 || A[i] >= 100000)
                {
                    Console.WriteLine("Input must be between 1 and 1000");
                    K = int.Parse(Console.ReadLine());
                }
            }
            int sum = 0;

            Array.Sort(A);



            for(int i=0;i<N;i++)
            {
                 sum += A[i];
            }

            Console.WriteLine("The Wieght capacity of the boat should be {0} to satisfy the man's condiitons", sum / K);
        }
    }
}
