namespace Collections
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[5];

            int[] numbers2 = { 1, 2, 3 };

            string[] fruits = new string[] { "Apple", "Banana" };

            for (int i = 0; i < fruits.Length; i++)
            {
                Console.WriteLine(fruits[i]);
            }

            int[,] matrix = new int[2, 3];

            int[,] grid = { { 1, 2, 3 }, { 4, 5, 6 } };

            int value = grid[0, 1];
            Console.WriteLine(value);

            Console.WriteLine(grid[1, 2]);

            int[][] jaggedArray = new int[3][];
            jaggedArray[0] = new int[2] { 1, 2 };
            jaggedArray[1] = new int[3] { 3, 4, 5 };
            jaggedArray[2] = new int[1] { 6 };

            Console.WriteLine(jaggedArray[1][2]);

            Console.WriteLine("--------");
            Console.WriteLine(jaggedArray[0][1]);
            jaggedArray[0][1] = 10;

            Console.WriteLine(jaggedArray[0][1]);
        }
    }
}
