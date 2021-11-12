using System;

namespace KnightTraversal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Knights Traversal - Mininum Number of moves");
            Console.Write("Enter the Dimension of the board - N : ");

            int dimension = Int32.Parse(Console.ReadLine());
            
            int[] start = new int[2];
            int[] dest = new int[2];

            Console.WriteLine("\nEnter starting poistion of the Knight:");
            Console.Write("X cordinate: ");
            start[0] = Int32.Parse(Console.ReadLine());
            Console.Write("Y cordinate: ");
            start[1] = Int32.Parse(Console.ReadLine());
            Console.WriteLine("\nEnter destination poistion of the Knight:");
            Console.Write("X cordinate: ");
            dest[0] = Int32.Parse(Console.ReadLine());
            Console.Write("Y cordinate: ");
            dest[1] = Int32.Parse(Console.ReadLine()); 

            try
            {
                var knightTraversal = new KnightTraversal(start, dest, dimension);

                var path = knightTraversal.BuildPath();

                Console.WriteLine("\nThe shortest path list consititute of: \n");

                foreach (var p in path)
                {
                    Console.WriteLine($"Move - {p[0]}, {p[1]}");
                }
            }
            catch(ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
            
            
            
            
        }



        
    }
}
