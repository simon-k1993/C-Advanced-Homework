using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class Dog : Pet
    {
        public string FavouriteFood {  get; set; }

        public override string PrintInfo()
        {
            return $"{Type} with name: {Name} is {Age} years old and has favourite food: {FavouriteFood}";
        }
    }
}
