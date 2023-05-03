using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp20.Models
{
    public class Restorant
    {
        static int _id;
        public int Id { get; set; }
        public string Name { get; set; }
       

        public Restorant()
        {
            _id++;
            Id = _id;
        }
        public Restorant(string name) : this()
        {
            Name = name;
        }
        public Product[] Products { get; set; } = { };



    }
}
