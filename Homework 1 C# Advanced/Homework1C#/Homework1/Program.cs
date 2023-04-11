using Domain.Models;

PetStore<Dog> Dogs = new PetStore<Dog>();
PetStore<Cat> Cats = new PetStore<Cat>();
PetStore<Fish> Fish = new PetStore<Fish>();

Dogs.InsertPet(new Dog { Age = 5, Name = "Freddie", Type = "Dog", FavouriteFood = "Beef" });
Dogs.InsertPet(new Dog { Age = 2, Name = "Max", Type = "Dog", FavouriteFood = "Chicken" });

Console.WriteLine();
Console.ForegroundColor = ConsoleColor.Green;
Dogs.BuyPet("Freddie");
Console.WriteLine();
Console.ResetColor();
Dogs.PrintsPets();
Console.WriteLine();

Cats.InsertPet(new Cat { Age = 1, Lazy = true, LivesLeft = 9, Name = "Toso", Type = "Cat" });
Cats.InsertPet(new Cat { Age = 2, Lazy = false, LivesLeft = 7, Name = "Mile", Type = "Cat" });

Console.WriteLine();
Console.ForegroundColor = ConsoleColor.Green;
Cats.BuyPet("Toso");
Console.WriteLine();
Console.ResetColor();
Cats.PrintsPets();
Console.WriteLine();

Fish.InsertPet(new Fish { Age = 6, Type = "Fish", Name = "Nemo", Color = "Orange", Size = "Small" });
Fish.InsertPet(new Fish { Age = 6, Type = "Fish", Name = "Arowana", Color = "Platinum", Size = "Big" });

Console.WriteLine();
Fish.PrintsPets();