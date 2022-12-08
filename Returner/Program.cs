using PointersPractice.MyTester;

namespace Returner;

public class Program
{
    public static void Main(string[] args)
    {

        // Pretty sure this is wrong. Do not understand pointers enough at this point in time.

        MyReturnTester tester = new();

        int val = 5;
        char c = 'd';
        
        Console.WriteLine($"Value: {val}, Pointer: {tester.ReturnIntAsterisk(ref val)}");
        Console.WriteLine($"Character {c}, Pointer: {tester.ReturnCharAsterisk(ref c)}");
    }
}
