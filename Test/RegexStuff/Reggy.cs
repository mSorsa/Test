using System.Text.RegularExpressions;

namespace Test.RegexStuff;
internal class Reggy
{
    /// <summary>
    /// Return the string without the last 4 characters.
    /// </summary>
    /// <param name="s"></param>
    /// <returns></returns>
    private string getStringExcludingLast4CharactersUsingRegularExpression(string s)
        => Regex.Replace(s, ".{4}$", "");
}
