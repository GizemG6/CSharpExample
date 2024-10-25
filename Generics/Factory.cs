using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    // Factory<T> burada bir generic sınıftır ve T bir tip parametresidir. T, bu sınıfın çalıştığı türü temsil eder.
    // where T : new() kısmı, kısıtlayıcı (constraint) bir ifadedir ve
    // T türünün mutlaka parametresiz bir kurucuya (constructor) sahip olması gerektiğini belirtir.
    // Bu, T türünden bir nesnenin new T() ile oluşturulabilmesini sağlar.
    // Eğer T'nin parametreli bir kurucusu olsaydı veya hiç kurucusu olmasaydı, bu sınıfı kullanmak mümkün olmazdı.
    // Bu kısıtlama, tür güvenliğini sağlar ve derleyiciye, T türünün new ile örneklenebilir olduğunu garanti eder.
    public class Factory<T> where T : new()
    {
        // CreateInstance metodu, T türünden bir nesne oluşturur ve geri döner.
        // new T(); ifadesi, T türünden bir nesne oluşturmak için kullanılır.T'nin hangi tür olduğuna bağlı olarak, bu nesne o türe ait bir örnek olur.
        // Bu metot sayesinde, Factory<T> sınıfını kullanarak herhangi bir sınıfın nesnesini dinamik olarak oluşturabilirsiniz.
        // Ancak T türünün parametresiz bir kurucuya sahip olması zorunludur
        public T CreateInstance()
        {
            return new T();
        }
    }
}
