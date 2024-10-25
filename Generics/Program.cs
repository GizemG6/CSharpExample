namespace Generics
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3 };

            string[] array2 = { "A", "B", "C" };

            PrintArray(array2);

            DisplayClassType(array);

            DisplayStructType(1);

            Point p = new Point();

            DisplayStructType(p);

            Circle circle = new Circle();

            DisplayShapeType(circle);

            CreateInstance<Point>();

            DisplayComparableType("deneme");

            DisplayType(circle);



            GenericClass<int> genericClass = new GenericClass<int>(4);


            GenericStack<int> genericStack = new GenericStack<int>();

            Console.WriteLine(genericStack.IsEmpty());

            genericStack.Push(1);
            genericStack.Push(2);
            genericStack.Push(3);

            Console.WriteLine(genericStack.Pop());
            Console.WriteLine(genericStack.Peek());
            Console.WriteLine(genericStack.Pop());

            GenericStack<string> strStack = new GenericStack<string>();

            strStack.Push("A");
            strStack.Push("B");
            strStack.Push("C");

            Console.WriteLine(strStack.Pop());
            Console.WriteLine(strStack.Peek());
            Console.WriteLine(strStack.Pop());

            Repository<Student> student = new Repository<Student>();

        }

        // Shape soyut (abstract) bir sınıftır ve kendisinden türeyen sınıfların bir şekil olduğunu ifade eder.
        // Circle, bu sınıftan türemiş ve aynı zamanda IEntity arayüzünü implemente etmiştir.
        public abstract class Shape
        {

        }

        public class Circle : Shape , IEntity
        {

        }

        public struct Point
        {

        }

        // Bu generic metot, parametre olarak T türünden bir dizi alır ve dizinin elemanlarını ekrana yazdırır. T herhangi bir tür olabilir.
        public static void PrintArray<T>(T[] array)
        {
            foreach (T item in array)
            {
                Console.WriteLine(item);
            }
        }

        // 
        public void GenericMethod<T>(T i)
        {
            Console.WriteLine(i);
        }


        // Bu metot, yalnızca referans türü (class) olan türlerle çalışır (where T : class kısıtlaması).
        public static void DisplayClassType<T>(T item) where T : class
        {

        }


        // Bu metot, yalnızca değer türü (struct) olan türlerle çalışır (where T : struct kısıtlaması).
        public static void DisplayStructType<T>(T item) where T : struct
        {

        }

        // Bu metot, yalnızca Shape sınıfından türeyen türlerle çalışır(where T : Shape kısıtlaması).
        public static void DisplayShapeType<T>(T item) where T : Shape
        {

        }

        // Bu metot, new() kısıtlaması ile parametresiz bir kurucusu olan türlerden nesne oluşturur (where T : new()).
        public static T CreateInstance<T>() where T : new()
        {
            return new T();
        }

        // Bu metot, IComparable<T> arayüzünü implemente eden türlerle çalışır (where T : IComparable<T>).
        public static void DisplayComparableType<T>(T item) where T : IComparable<T>
        {

        }

        // Bu metot, hem class, hem IEntity arayüzünü implemente eden,
        // hem de parametresiz bir kurucusu olan türlerle çalışır (where T : class, IEntity, new()).
        public static void DisplayType<T>(T item) where T : class, IEntity, new()
        {

        }

        public interface IEntity { }
    }
}
