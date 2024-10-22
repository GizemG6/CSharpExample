namespace Generics
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3 };

            string[] array2 = { "A", "B", "C"};

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
        }

        public abstract class Shape
        {

        }

        public class Circle : Shape , IEntity
        {

        }

        public struct Point
        {

        }

        public static void PrintArray<T>(T[] array)
        {
            foreach (T item in array)
            {
                Console.WriteLine(item);
            }
        }
        public void GenericMethod<T>(T i)
        {
            Console.WriteLine(i);
        }

        public static void DisplayClassType<T>(T item) where T : class
        {

        }

        public static void DisplayStructType<T>(T item) where T : struct
        {

        }
        public static void DisplayShapeType<T>(T item) where T : Shape
        {

        }

        public static T CreateInstance<T>() where T : new()
        {
            return new T();
        }

        public static void DisplayComparableType<T>(T item) where T : IComparable<T>
        {

        }

        public static void DisplayType<T>(T item) where T : class, IEntity, new()
        {

        }

        public interface IEntity { }
    }
}
