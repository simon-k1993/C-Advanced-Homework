using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class Cat : Pet
    {
        public bool Lazy { get; set; }

        public int LivesLeft { get; set; }

        public override string PrintInfo()
        {
            return $"{Type} with name: {Name} is {Age} years and it is {Lazy} that it's lazy, and has {LivesLeft} lives left";
        }
    }
}
