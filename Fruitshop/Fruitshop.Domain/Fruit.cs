using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fruitshop.Domain
{
    internal class Fruit
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }
        public string Season { get; set; }

        public override string ToString()
        {
            return $"{Name} - '{Color}' - ({Season})";
        }
    }
}
