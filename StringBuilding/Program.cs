
bool bt = true;
while (bt)
{ 
    Console.Write("Number of iterations to try: ");
    string input = Console.ReadLine();
    Console.WriteLine();

    int iterations = 0;
    if (int.TryParse(input, out iterations))
    {
        // String builder speed (str.Append())
        var sbSpeedChecker = new SBSpeedChecker();
        double sbSpeed = sbSpeedChecker.SBAppendSpeed(iterations);
        Console.WriteLine($"StringBuilder took: {sbSpeed} ms to append {iterations} things.");
        // Normal string speed
        double normalSpeed = sbSpeedChecker.NormalStringAppendSpeed(iterations);
        Console.WriteLine($"Normal string took: {normalSpeed} ms to append {iterations} things.");
        Console.WriteLine("----------------------------------------------------------");
        Console.WriteLine();
    }
    else
    {
        Console.WriteLine("Exiting program...");
        bt = false;
    }
}
