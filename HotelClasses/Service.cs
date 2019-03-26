using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelClasses
{
    public class Service : Base
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public Service()
        {
        }
        public override string ToString()
        {
            return Name;
        }
    }
}
