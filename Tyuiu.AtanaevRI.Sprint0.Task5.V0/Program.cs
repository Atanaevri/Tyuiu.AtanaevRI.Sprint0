using Tyuiu.AtanaevRI.Sprint0.Task5.V0.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("А + B =" + DataService.Addition(1, 5));
        Console.WriteLine("А - B =" + DataService.Subtraction(15, 5));
        Console.WriteLine("А * B =" + DataService.Multiplication(10, 10));
        Console.WriteLine("А / B =" + DataService.Division(5, 0));
        Console.ReadKey();
    }
}