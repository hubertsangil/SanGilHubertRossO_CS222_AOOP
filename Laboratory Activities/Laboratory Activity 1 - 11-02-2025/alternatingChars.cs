using System;

public class alternatingChars
{
    public static void Main(string[] args)
    {
        Console.Write("First character: ");
        char firstCharacter = Console.ReadLine()[0];

        Console.WriteLine();

        Console.Write("Second character: ");
        char secondCharacter = Console.ReadLine()[0];

        Console.WriteLine();

        Console.Write("Enter size: ");
        int size = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i <= size; i++)
        {
            for (int j = 1; j<= i-1; j++)
            {
                Console.Write("-");
            }
            if (i % 2 != 0)
            {
                Console.Write(firstCharacter);
            }
            else
            {
                Console.Write(secondCharacter);
            }
            Console.WriteLine();
        }
    }
}