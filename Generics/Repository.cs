using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{

    // Repository<T> bir generic sınıftır ve T tip parametresi ile çalışır.
    // Bu sınıf, belirli bir veri türü ile genel (genel amaçlı) veri saklama ve alma işlemlerini gerçekleştirir.
    // where T : Entity kısmı, T'nin Entity sınıfından türemiş bir sınıf olması gerektiğini belirtir. 
    // Bu, Repository<T> sınıfının sadece Entity sınıfından türetilmiş sınıflarla çalışabileceği anlamına gelir.
    public class Repository<T> where T : Entity
    {
        private List<T> _entities = new List<T>();


        // Add metodu, T türünden bir nesneyi (örneğin, Student nesnesi) _entities listesine ekler.
        // Bu metodun parametresi olan entity, generic türde bir nesnedir ve listeye eklenir.
        // Örneğin: repository.Add(new Student()); ifadesi, Student nesnesini listeye ekler.
        public void Add(T entity)
        {
            _entities.Add(entity);
        }

        // GetById metodu, verilen id değerine sahip nesneyi _entities listesinden bulup döndürür.
        // Find(item => item.Id == id) ifadesi, listede Id değeri id olan ilk nesneyi bulur ve döner.
        // Bu metod, T türünden (örneğin Student) bir nesne döndürür.
        public T GetById(int id)
        {
            return _entities.Find(item => item.Id == id);
        }
    }

    public abstract class Entity()
    {
        public int Id { get; set; }
    }

    public class Student : Entity
    {

    }
}
