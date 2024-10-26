# CSharpExample

Generic Sınıflar
----------------
C#'ta Generic Sınıflar, bir sınıfın yalnızca belirli türlere bağımlı olmadan, farklı türler için yeniden kullanılabilir şekilde tanımlanmasını sağlar. Generic sınıflar, yazılım geliştirme sürecinde tekrar kullanılabilirliği artırır, veri tiplerine özgü işlemlerin aynı kod bloğu ile yapılabilmesini sağlar ve tip güvenliğini artırır.

Neden Generic Sınıflar Kullanılır?

1-Tekrar Kullanılabilirlik: Aynı sınıfı farklı türler ile kullanmamızı sağlar. Örneğin, List<T> sınıfı int, string gibi farklı türlerle kullanılabilir.

2-Tip Güvenliği: Veri tipini önceden belirlediğimiz için, runtime (çalışma anı) hatalarını önceden engeller ve daha güvenli bir kod yazmamızı sağlar.

3-Performans: Casting (dönüştürme) işlemi gerektirmediği için daha hızlı çalışır.

Generic Kısıtlamalar (Constraints)
----------------
Bazı durumlarda, generic sınıflarda belirli tür kısıtlamaları eklemek gerekebilir. C# bunun için where anahtar kelimesini kullanır.

Örnek : where T : class, new() kısıtlaması ile T türünün bir referans türü (class) ve parametresiz bir kurucusu (new()) olması gerektiğini belirtiyoruz.

Özet : Generic sınıflar, C#'ta tip güvenliğini artırır ve kodun daha esnek ve yeniden kullanılabilir olmasını sağlar. T gibi tip parametreleri ile, sınıfın birden fazla türde çalışmasını mümkün kılar. Bu sayede aynı sınıf, kod tekrarını önleyerek farklı veri türleri için kullanılabilir.

Collection
----------------
C#'ta Collection (Koleksiyon), birden fazla öğeyi belirli bir sırada veya yapıda saklamamıza ve yönetmemize olanak tanıyan sınıflardır. Koleksiyonlar, veri yapılarını daha esnek hale getirir ve farklı veri türlerini saklamak için geniş bir yelpaze sunar. Koleksiyonlar, aynı veri türünden birçok nesneyi bir arada tutmayı sağladığı gibi, nesneler üzerinde ekleme, silme, arama, sıralama gibi işlemleri de kolaylaştırır.

C#'taki Koleksiyon Türleri
----------------
C#’ta koleksiyonlar, System.Collections, System.Collections.Generic, System.Collections.Concurrent ve System.Collections.Specialized isim alanları altında yer alır ve iki temel kategoriye ayrılır:

1-Generic Koleksiyonlar (System.Collections.Generic): Tip güvenliğini sağlar ve yalnızca belirli türdeki verileri kabul eder.

Örneğin: List<T>, Dictionary<TKey, TValue>, Queue<T>, Stack<T>

2-Non-Generic Koleksiyonlar (System.Collections): Farklı türlerde veri kabul edebilir, ancak tip güvenliği yoktur ve dönüştürme işlemleri gerektirebilir.

Örneğin: ArrayList, Hashtable, Queue, Stack

Generic Koleksiyonlar
----------------
Generic koleksiyonlar, belirli bir türle çalışacak şekilde tanımlandığından, tip güvenliği sağlar. Bu, derleme (compile) anında tür uyumsuzluğu hatalarını yakalamamıza olanak tanır ve runtime hatalarını azaltır.

Örnekler

1-List<T>

Dinamik bir dizi gibi çalışır, boyutu otomatik olarak ayarlanır.
```csharp
List<int> numbers = new List<int> { 1, 2, 3 };
numbers.Add(4); // Yeni öğe ekler
```

2-Dictionary<TKey, TValue>

Anahtar-değer (key-value) çiftleri şeklinde veri saklar.

```csharp
Dictionary<int, string> students = new Dictionary<int, string>();
students.Add(1, "John");
students.Add(2, "Jane");
```

3-Queue<T>

FIFO (First-In-First-Out) yapısında çalışır, ilk eklenen öğe ilk çıkar.

```csharp
Queue<string> tasks = new Queue<string>();
tasks.Enqueue("Task 1");
tasks.Enqueue("Task 2");
```

4-Stack<T>

LIFO (Last-In-First-Out) yapısında çalışır, son eklenen öğe ilk çıkar.

```csharp
Stack<string> books = new Stack<string>();
books.Push("Book 1");
books.Push("Book 2");
```

Non-Generic Koleksiyonlar
----------------
Non-generic koleksiyonlar, herhangi bir veri türünü saklayabilir ancak bu durum, tip güvenliğinin olmamasına neden olur. Bu yüzden tip uyumsuzluğu riskini azaltmak için tür dönüştürme işlemleri gerekebilir.

Örnekler

1-ArrayList

Dinamik bir dizi gibidir, farklı veri türlerini saklayabilir.

```csharp
ArrayList list = new ArrayList();
list.Add(1);
list.Add("Hello");
```

2-Hashtable

Anahtar-değer (key-value) çiftleri saklar. Farklı türde anahtarlar ve değerler saklayabilir.

```csharp
Hashtable table = new Hashtable();
table.Add(1, "John");
table.Add("key", 100);
```

3-Queue ve Stack

Non-generic Queue ve Stack koleksiyonları da vardır. Genel yapı aynı olmakla birlikte, tür belirtmeden kullanılabilirler.

Koleksiyon Kullanmanın Avantajları

•Esneklik: Koleksiyonlar, belirli bir boyut sınırlaması olmaksızın dinamik olarak büyüyebilir veya küçülebilir.

•Tip Güvenliği (Generic Koleksiyonlar): List<int>, Dictionary<string, string> gibi generic koleksiyonlar belirli bir türde veri kabul eder ve bu sayede veri doğruluğu artar.

•Hazır Metotlar: Ekleme, çıkarma, arama ve sıralama işlemleri için zengin metot desteği sağlarlar.

•Verimlilik: Bazı koleksiyon türleri, veri yapısını ve erişimi optimize eder (örneğin, Dictionary<TKey, TValue> hızlı arama yapabilir).
