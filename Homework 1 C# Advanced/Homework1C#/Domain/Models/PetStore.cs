using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class PetStore <T> where T : Pet
    {
        public List<T> PetsList { get; set;} = new List<T>();

        public void PrintsPets()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Pets left in the petshop:");
            Console.ResetColor();
            Console.WriteLine();
            foreach (T pet in PetsList)
            {
                Console.WriteLine(pet.PrintInfo());
            }
        }

        public void InsertPet(T pet)
        {
            PetsList.Add(pet);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"New member in our petshop is: {pet.Name} the {pet.GetType().Name}");
            Console.ResetColor();
        }

        public void BuyPet(string name)
        {
            T pet = PetsList.FirstOrDefault(x =>x.Name == name );
            if (pet == null)
            {   
                Console.ForegroundColor= ConsoleColor.DarkRed;
                Console.WriteLine("We don't have that type of pet in our petshop!");
                Console.ResetColor();
            }
            else
            {
                PetsList.Remove(pet);
                Console.WriteLine($"You have successfully bought your {pet.GetType().Name} called {pet.Name} from our petshop!");
            }
            
        }
    }
}
