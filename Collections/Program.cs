using System.Runtime.ConstrainedExecution;

namespace Collections
{
    public class Program
    {
        static void Main(string[] args)
        {
            #region Arrays
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
            #endregion

            #region Generic List
            /*List<int> numbers = new List<int>() { 8, 2, 9, 4, 7 };

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

            // küçükten büyüğe sıralar
            numbers.Sort(); // 2, 6, 8, 9, 10

            // listeyi tersine çevirir
            numbers.Reverse(); // 10, 9, 8, 6, 2

            foreach (int i in numbers)
            {
                Console.WriteLine(i); // output: 10, 9, 8, 6, 2
            }

            for (int i = 0; i < numbers.Count; i++)
            {
                Console.WriteLine(numbers[i]); // output: 10, 9, 8, 6, 2
            }*/
            #endregion

            #region Dictionary<int, string>
            /*Dictionary<int , string> students = new Dictionary<int , string>();

            students.Add(1, "Ali");
            students.Add(2, "Ayse");

            string student = students[1];

            Console.WriteLine(student); // output: Ali

            if (!students.ContainsKey(2))
            {
                students.Add(2, "Veli"); 
            }
            else
            {
                students.Add(3, "Veli");
            }

            Console.WriteLine(students[2]); // output: Ayse

            Console.WriteLine(students[3]); // output: Veli

            students.Remove(1);

            if (!students.ContainsKey(1))
            {
                students.Add(1, "Mehmet"); 
            }

            Console.WriteLine("---------");

            Console.WriteLine(students[1]); // output: Mehmet
            */
            #endregion

            #region Dictionary<string, string>
            /*Dictionary<string, string> capitals = new Dictionary<string, string>()
            {
                { "Türkiye", "Ankara" },
                { "Almanya", "Berlin" },
                { "Fransa", "Paris" }
            };

            capitals.Add("Italya", "Roma");

            string capitalOfGermany = capitals["Almanya"];

            Console.WriteLine($"Almanyanın Başkenti: {capitalOfGermany}"); // output: Almanyanın Başkenti: Berlin

            if (capitals.ContainsKey("Fransa")) // true
            {
                capitals.Remove("Fransa");
                Console.WriteLine("Fransa başkent bilgisi kaldırıldı"); // output : Fransa başkent bilgisi kaldırıldı
            }

            // Her bir KeyValuePair<string, string> nesnesinde kvp.Key ülke adını, kvp.Value başkenti temsil eder
            foreach (KeyValuePair<string, string> kvp in capitals)
            {
                Console.WriteLine($"Ülke {kvp.Key} başkent {kvp.Value}"); // output: Ülke Türkiye başkent Ankara, Ülke Almanya başkent Berlin, Ülke Italya başkent Roma
            }*/
            #endregion

            #region Stack Queue
            /*Queue<string> queue = new Queue<string>();

            queue.Enqueue("Ali");
            queue.Enqueue("Ayse");
            queue.Enqueue("Mehmet");

            // Dequeue metodu, sıradaki ilk kişiyi ("Ali") kuyruktan çıkarır ve firstPerson değişkenine atar.
            string firstPerson = queue.Dequeue();

            Console.WriteLine($"İlk bilet sahibi {firstPerson}"); // output: İlk bilet sahibi Ali

            // Peek metodu, kuyruktaki ilk elemanı çıkarılmadan gösterir. Şu an sırada "Ayse" olduğu için, nextPerson değişkenine "Ayse" atanır.
            string nextPerson = queue.Peek();

            Console.WriteLine($"Sıradaki kişi {nextPerson}"); // output: Sıradaki kisi Ayse

            Console.WriteLine("--------");

            foreach (string item in queue)
            {
                Console.WriteLine(item); // output: Ayse, Mehmet
            }

            Stack<string> menu = new Stack<string>();

            // Push metodu ile "adım gizem", "bugün cumartesi" ve "selam na ber" yığına eklenir.
            menu.Push("adım gizem");
            menu.Push("bugün cumartesi");
            menu.Push("selam na ber");

            // Pop metodu, yığındaki en son eklenen elemanı çıkarır. Bu durumda "selam na ber" çıkarılır ve yığından silinir.
            menu.Pop();

            // Peek metodu, yığındaki en üstte bulunan elemanı (son eklenen elemanı) gösterir ama çıkarmadan.
            // Bu durumda Peek, "bugün cumartesi" değerini döndürür.
            menu.Peek();

            foreach (string item in menu)
            {
                Console.WriteLine(item); // output: bugün cumartesi, adım gizem
            }*/
            #endregion

            #region LinkedList
            /*LinkedList<string> linkedList = new LinkedList<string>();

            linkedList.AddLast("Elma");
            linkedList.AddLast("Armut");
            linkedList.AddFirst("Muz"); // AddFirst("Muz") ile Muz, listenin başına eklenir. Şu an liste sırası: "Muz" -> "Elma" -> "Armut".

            foreach (string s in linkedList)
            {
                Console.WriteLine(s); // output: Muz, Elma, Armut
            }

            LinkedList<int> numbers = new LinkedList<int>();

            numbers.AddLast(1);
            numbers.AddLast(2);
            numbers.AddLast(3);

            // LinkedListNode<int> node = numbers.First; ifadesi ile liste başındaki ilk düğüm alınır (1).
            //while döngüsünde, her düğümün değeri node.Value ile ekrana yazdırılır, ardından node = node.Next; ifadesiyle bir sonraki düğüme geçilir.
            LinkedListNode<int> node = numbers.First;

            while (node != null)
            {
                Console.WriteLine(node.Value); // output: 1, 2, 3
                node = node.Next;
            }

            Console.WriteLine("sondan başa");

            // node = numbers.Last; ifadesi ile listenin sonundaki düğüm (3) alınır.
            node = numbers.Last;

            // while döngüsüyle listenin sonundan başa doğru (node.Previous) gezilir ve her düğümün değeri ekrana yazdırılır.
            while (node != null)
            {
                Console.WriteLine(node.Value); // output: 3, 2, 1
                node = node.Previous;
            }*/
            #endregion
        }
    }
}
