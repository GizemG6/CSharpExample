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
