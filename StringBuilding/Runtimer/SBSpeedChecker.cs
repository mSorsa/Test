namespace StringBuilding.Runtimer;

public class SBSpeedChecker
{
    /// <summary>
    /// Appends a number every iteration using StringBuilder().
    /// </summary>
    /// <param name="iterations">The number of iterations to append numbers to a string.</param>
    /// <returns>Returns the time it took to complete "iterations" appends.</returns>
    public double SBAppendSpeed(int iterations)
    {
        // Instantiate the stringbuilder as buffer
        StringBuilder buf = new();
        // Start the stopwatch
        var sw = new Stopwatch();
        sw.Start();
        
        for (int i = 0; i < iterations; i++)
            buf.Append(i);  // Append the number to the stringbuilder

        // Stop the stopwatch
        sw.Stop();
        return sw.Elapsed.TotalMilliseconds;
    }
    
    /// <summary>
    /// Appends a number every iteration using string += number.
    /// </summary>
    /// <param name="iterations">The number of iterations to append numbers to a string.</param>
    /// <returns>Returns the time it took to complete "iterations" string += number.</returns>
    public double NormalStringAppendSpeed(int iterations)
    {
        // Instantiate the string as empty.
        string buf = "";
        // Start the stopwatch
        var sw = new Stopwatch();
        sw.Start();
        
        for (int i = 0; i < iterations; i++)
            buf += i;    // Append i to the string

        // Stop stopwatch
        sw.Stop();
        return sw.Elapsed.TotalMilliseconds;
    }
}
