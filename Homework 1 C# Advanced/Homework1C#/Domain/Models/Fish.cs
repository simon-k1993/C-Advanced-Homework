using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class Fish : Pet
    {
        public string Color { get; set; }

        public string Size { get; set; }

        public override string PrintInfo()
        {
            return $"{Type} with name: {Name} is {Age} years and it is {Color} and is very {Size}";
        }
    }
}
