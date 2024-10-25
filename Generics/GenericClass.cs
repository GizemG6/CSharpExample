using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{

    // GenericClass<T> burada bir generic sınıf tanımıdır. T adında bir tip parametresi kullanılıyor.
    // Bu, sınıfın farklı veri türleriyle çalışabilmesini sağlar.
    public class GenericClass<T>
    {
        // private T _field ifadesi, sınıf içinde tanımlanan bir özel alandır.
        // Bu alan, T türünden bir değer tutar. T her neyse (örneğin bir int, string ya da başka bir sınıf), _field o türde bir değeri tutacaktır.
        private T _field;


        // Bu constructor (yapıcı) metot, GenericClass nesnesi oluşturulduğunda çağrılır.
        // Kullanıcı bu sınıftan bir nesne oluştururken bir değer (parametre olarak) verecek ve o değer _field alanına atanacaktır.
        public GenericClass(T value)
        {
            _field = value;
        }

        // GetValue() metodu, _field alanında tutulan değeri döndüren bir metottur.
        // Geri dönüş tipi T olduğu için, bu metodun dönüş tipi, sınıfın hangi türde kullanıldığına göre değişir.
        // Örneğin, eğer sınıf int ile kullanılıyorsa, bu metodun geri dönüş değeri int olacaktır.
        public T GetValue()
        {
            return _field;
        }
    }
}
