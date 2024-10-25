namespace Collections
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>() { 8, 2, 9, 4, 7 };

            List<string> fruits = new List<string>() { "Elma", "Armut", "Muz" };

            // listenin sonun 6 ekler
            numbers.Add(6); // 8, 2, 9, 4, 7, 6

            // indeks 2'ye 10 ekler
            numbers.Insert(2, 10); // 8, 2, 10, 4, 7, 6

            // 4'ü siler
            numbers.Remove(4); // 8, 2, 10, 9, 7, 6

            // 4. indekstekini siler
            numbers.RemoveAt(4); // 8, 2, 10, 9, 6

            // numbers listesi 3 elemanını içerip içermediğini kontrol eder(true/false döner)
            numbers.Contains(3);

            //numbers.Clear(); tüm elemanları siler

            numbers.Sort(); // 2, 6, 8, 9, 10

            numbers.Reverse(); // 10, 9, 8, 6, 2

            foreach (int i in numbers)
            {
                Console.WriteLine(i); // output: 10, 9, 8, 6, 2
            }

            for (int i = 0; i < numbers.Count; i++)
            {
                Console.WriteLine(numbers[i]); // output: 10, 9, 8, 6, 2
            }

            //-----arrays--------
            /*int[] numbers = new int[5];

            int[] numbers2 = { 1, 2, 3 };

            string[] fruits = new string[] { "Apple", "Banana" };

            for (int i = 0; i < fruits.Length; i++)
            {
                Console.WriteLine(fruits[i]);
            }

            int[,] matrix = new int[2, 3];

            int[,] grid = { { 1, 2, 3 }, { 4, 5, 6 } };

            int value = grid[0, 1];
            Console.WriteLine(value);  // output: 2

            Console.WriteLine(grid[1, 2]); // output: 6

            int[][] jaggedArray = new int[3][];
            jaggedArray[0] = new int[2] { 1, 2 };
            jaggedArray[1] = new int[3] { 3, 4, 5 };
            jaggedArray[2] = new int[1] { 6 };

            Console.WriteLine(jaggedArray[1][2]); // output: 5

            Console.WriteLine("--------");
            Console.WriteLine(jaggedArray[0][1]); // output: 2
            jaggedArray[0][1] = 10;

            Console.WriteLine(jaggedArray[0][1]); // output: 10 */
        }
    }
}
