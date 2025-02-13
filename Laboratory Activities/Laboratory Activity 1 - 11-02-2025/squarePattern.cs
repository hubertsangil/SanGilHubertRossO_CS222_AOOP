using System;
    class squarePattern
    {
        static void Main(string[] args)
        {
            Console.Write("Enter n: ");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();

            Console.Write("Enter y: ");
            int y = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= n; i++) 
            {
                if (i == y)
                {
                    Console.WriteLine();
                    continue;
                }
                for (int j = 0; j<= y+1; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }

