using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp20.Models
{
    public class Product
    {
        static int _id;
        public int Id { get; set; }


        public string Name { get; set; }
        public string Description { get; set; }

        public Product ()
         {
            _id++;
            Id = _id;
         }
        public Product(string name):this()
        {
            Name = name;
        }
    }
}
