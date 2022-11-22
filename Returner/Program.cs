namespace Returner;

public class Program
{
    public static void Main(string[] args)
    {
        MyReturnTester tester = new();

        int val = 5;
        char c = 'd';
        
        Console.WriteLine($"Value: {val}, Pointer: {tester.ReturnIntAsterisk(val)}");
        Console.WriteLine($"Character {c}, Pointer: {tester.ReturnCharAsterisk(c)}");
    }
}

internal class MyReturnTester
{
    internal IntPtr ReturnIntAsterisk(int value)
    {
        unsafe
        {
            return new IntPtr(&value);
        }
    }

    internal IntPtr ReturnCharAsterisk(char character)
    {
        unsafe
        {
            return new IntPtr(&character);
        }
    }
}
