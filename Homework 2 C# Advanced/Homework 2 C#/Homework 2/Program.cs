string appPath = @"../../../Exercise";
string filesPath = appPath + "calculations.txt";

void CreateDirectory(string path)
{
    if (!Directory.Exists(path))
    {
        Directory.CreateDirectory(path);
    }
}

void CreateFile(string path)
{
    if (!File.Exists(path))
    {
        File.Create(path).Close();
    }
}

string Calculate(int num1, int num2)
{
    int result = num1 + num2;
    return num1 + " + " + num2 + " = " + result;
}

CreateDirectory(appPath);
CreateFile(filesPath);


for (int i = 0; i < 3; i++) {
    void Calculation()
    {
        try
        {
            Console.Write("Enter the first number: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Enter the second number: ");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine();
            string result = Calculate(num1, num2);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(result);
            Console.ResetColor();

            using (StreamWriter sw = File.AppendText(filesPath))
            {
                Console.WriteLine();
                sw.WriteLine($"Result of the calculated numbers is: {result}  {DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}");
               
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine();
            Console.ForegroundColor= ConsoleColor.Red;
            Console.WriteLine(ex.Message);
            Console.ResetColor();
            Console.WriteLine();
        }
    }
    Calculation();
}
