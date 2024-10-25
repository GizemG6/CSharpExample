using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    // GenericStack<T> bir generic sınıftır ve T burada tür parametresidir. T tür parametresi sayesinde, stack içerisine farklı veri türleri eklenebilir.
    // Örneğin, bir GenericStack<int> oluşturup sadece int değerler ekleyebiliriz. Aynı şekilde GenericStack<string> oluşturup string değerler ekleyebiliriz.
    public class GenericStack<T>
    {
        // _elements, stack'te tutulacak elemanların listesidir.
        // Bu alan, List<T> türündedir ve T türünde elemanlar içerebilir.
        // List veri yapısı, dinamik bir dizidir ve elemanları ekleyip çıkarmak oldukça esnektir.
        private List<T> _elements = new List<T>();

        // Push işlemi, stack'e eleman ekler.
        // Push metoduna parametre olarak gelen item (hangi türdeyse) _elements listesine eklenir.
        // Bu işlem stack'in üzerine yeni bir eleman ekler.
        public void Push(T item)
        {
            _elements.Add(item);
        }

        // Pop işlemi, stack'in en üstündeki elemanı çıkarır ve geri döner. 
        public T Pop()
        {
            if (_elements.Count == 0) // Stack'te hiç eleman yoksa (yani _elements.Count == 0 ise), bir hata fırlatır: InvalidOperationException.
            {
                throw new InvalidOperationException("stack boş");
            }

            // T item = _elements[_elements.Count - 1];: Stack'in en üstündeki eleman, listenin son elemanıdır.
            // Bu yüzden, _elements[_elements.Count - 1] ifadesiyle son eleman alınır.
            T item = _elements[_elements.Count - 1];

            // _elements.RemoveAt(_elements.Count - 1);: Son eleman listeden çıkarılır.
            _elements.RemoveAt(_elements.Count - 1);

            return item;
        }
        public T Peek() // Peek işlemi, stack'ten elemanı çıkarmadan en üstteki (son eklenen) elemanı gösterir. 
        {
            if (_elements.Count == 0) // Eğer stack boşsa, yine InvalidOperationException hatası fırlatır.
            {
                throw new InvalidOperationException("stack boş"); 
            }

            // Stack'teki en üst eleman, listenin son elemanıdır, bu yüzden _elements[_elements.Count - 1] ifadesiyle son eleman geri döndürülür.
            return _elements[_elements.Count - 1]; 
        }

        // IsEmpty işlemi, stack'in boş olup olmadığını kontrol eder.
        // Eğer _elements.Count == 0 ise, true döner, yani stack boştur.
        // Aksi takdirde false döner, yani stack'te elemanlar vardır.
        public bool IsEmpty()
        {
            return _elements.Count == 0;
        }
    }
}
