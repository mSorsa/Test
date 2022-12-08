namespace PointersPractice.MyTester;

internal class MyReturnTester
{
    internal IntPtr ReturnIntAsterisk(ref int value)
    {
        return new IntPtr(value);
    }

    internal IntPtr ReturnCharAsterisk(ref char character)
    {
        return new IntPtr(character);
    }


    /* ********************* Returns the same address for any input ********************* */
    unsafe internal IntPtr ReturnIntAsterisk(int value)
    {
        return new IntPtr(&value);
    }

    unsafe internal IntPtr ReturnCharAsterisk(char character)
    {
        return new IntPtr(&character);
    }
    /* ********************************************************************************** */
}
