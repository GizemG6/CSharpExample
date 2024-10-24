using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class Repository<T> where T : Entity
    {
        private List<T> _entities = new List<T>();

        public void Add(T entity)
        {
            _entities.Add(entity);
        }

        public T GetById(int id)
        {
            return _entities.Find(item => item.Id == id);
        }
    }

    public class Entity()
    {
        public int Id { get; set; }
    }
}
