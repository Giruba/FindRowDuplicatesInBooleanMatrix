using System;

namespace FindDuplicateRowsInAMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Find Duplicates In A Matrix!");
            Console.WriteLine("---------------------------");

            try
            {
                int[,] matrix = InputProcessor.GetMatrixFromInput();
                TrieNode resultantTrieNode = InputProcessor.TryInputMatrixInsertionInTrie(matrix);
            }
            catch (Exception exception) {
                Console.WriteLine("Thrown exception is "+exception.Message);
            }

            Console.ReadLine();
        }
    }
}
