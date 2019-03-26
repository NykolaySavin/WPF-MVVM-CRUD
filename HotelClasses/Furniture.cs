using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelClasses
{
    public class Furniture : Base
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public Room Room { get; set; }
        
    }
}
