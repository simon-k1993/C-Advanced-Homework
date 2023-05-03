using Domain;
using Newtonsoft.Json;

string folderPath = @"..\..\..\DataBase";
string filePath = @"..\..\..\DataBase\jsonFile.json";

if (!Directory.Exists(folderPath))
{
    Directory.CreateDirectory(folderPath);
}

try { 
if (!File.Exists(filePath))
{
    File.Create(filePath).Close();
}

List<Dog> dogsList = new List<Dog>();

string jsonFileContent = File.ReadAllText(filePath);
if (!string.IsNullOrWhiteSpace(jsonFileContent))
{
    dogsList = JsonConvert.DeserializeObject<List<Dog>>(jsonFileContent);
}

Console.WriteLine("Enter the dog's name:\n");
string dogName = Console.ReadLine();
Console.WriteLine();

Console.WriteLine("Enter the dog's age:\n");
int dogAge = int.Parse(Console.ReadLine());
Console.WriteLine();

Console.WriteLine("Enter the dog's color:\n");
string dogColor = Console.ReadLine();
Console.WriteLine();

Dog newDog = new Dog()
{
    Name = dogName,
    Age = dogAge,
    Color = dogColor
};

dogsList.Add(newDog);

string jsonString = JsonConvert.SerializeObject(dogsList);
File.WriteAllText(filePath, jsonString);

PrintDogs(dogsList);
}
catch (Exception ex)
{   
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("ERROR: " + ex.Message);
    Console.ResetColor();
}

static void PrintDogs(List<Dog> dogsList)
{
    foreach (Dog dog in dogsList)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"{dog.Name} the dog is {dog.Age} years old and is {dog.Color}!\n");
        Console.ResetColor();
    }
}


