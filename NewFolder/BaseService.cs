using ConsoleApp20.Models;
using ConsoleApp20.NewFolder.Ientiity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp20.NewFolder
{
    public class BaseService<T> where T: class,IEntitiy, new()
    {
        List<T> entities = new List<T>();
        public void Create(string name)
        {
            T entity = new ();
            entity.Name = name;
            entities.Add(entity);
        }

        public void Delete(string name)
        {
            foreach (var item in entities)
            {
                if (item.Name == name)
                {
                    entities.Remove(item);
                }
            }
        }

        public T GetById(int id)
        {
            T fEntitie = entities.Find(x => x.Id == id);
            return fEntitie;
        }

    }
}
