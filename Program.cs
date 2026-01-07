namespace gitövning;

class Program
{
    static void Main(string[] args)
    {
        int result = Plus(2, 8);
        Console.WriteLine($"The result is: {result}");
        int result2 = Minus(10, 4);
        Console.WriteLine($"The result is: {result2}");
        int result3 = divide(20, 5);
        Console.WriteLine($"The result is: {result3}");
    }
    static int Plus(int a, int b)
    {
        return a + b;
    }
    static int Minus(int a, int b)
    {
        return a - b;
    }

    static int divide(int a, int b)
    {
        return a / b;
    }
}
