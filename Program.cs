namespace gitövning;

class Program
{
    static void Main(string[] args)
    {
        int result = Plus(2, 8);
        Console.WriteLine($"The result is: {result}");
    }
    static int Plus(int a, int b)
    {
        return a + b;
    }
}
