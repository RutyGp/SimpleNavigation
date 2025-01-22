using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleNavigation
{
    public class Animal
    {
        public string Name { get; set; }
        public int Weight { get; set; }
        public DateTime Birth { get; set; }
        public override string ToString()
        {
            return $"{Name} its weight is : {Weight}. Was born in {Birth}";
        }
    }
}
