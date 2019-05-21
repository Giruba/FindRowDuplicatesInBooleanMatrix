using System;
using System.Collections.Generic;
using System.Text;

namespace FindDuplicateRowsInAMatrix
{
    class InputProcessor
    {
        public static int[,] GetMatrixFromInput() {
            int[,] matrix = null;
            Console.WriteLine("Enter the number of rows in the matrix");
            try
            {
                int rows = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the number of columns in the matrix");
                int columns = int.Parse(Console.ReadLine());
                matrix = new int[rows, columns];
                for (int rowIndex = 0; rowIndex < rows; rowIndex++) {
                    Console.WriteLine("Enter the elements of row "+rowIndex
                        +" separated by space, comma or semi-colon");
                    String[] elements = Console.ReadLine().Split(' ', ',', ';');
                    for (int colIndex = 0; colIndex < columns; colIndex++) {
                        matrix[rowIndex, colIndex] = int.Parse(elements[colIndex]);
                    }
                }
            }
            catch (Exception exception) {
                Console.WriteLine("InputProcessor:GetMatrixFromInput: Thrown exception is "+exception.Message);
            }
            return matrix;
        }

        public static TrieNode TryInputMatrixInsertionInTrie(int[,] matrix) {
            TrieNode root = new TrieNode();
            root.SetTrieNodeChildren(new TrieNode[26]);
            for (int index = 0; index < matrix.GetLength(0); index++) {
                String result = "";
                for (int secIndex = 0; secIndex < matrix.GetLength(1); secIndex++) {
                    result += matrix[index, secIndex]; 
                }
                if (index!= 0 && root.isFound(root, result.ToCharArray()))
                {
                    Console.WriteLine("This row is a duplicate "+result+"." +
                        "This row index is "+index);
                }
                else
                {
                    root.Insert(root, result.ToCharArray());
                }
            }
            return root;
        }
    }
}
