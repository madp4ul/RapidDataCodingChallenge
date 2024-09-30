namespace RapidDataCodingChallenge.MathLibrary.Implementation;

using RapidDataCodingChallenge.MathLibrary.Internal;

internal class RecursiveMathLib : IInternalMathLib
{
    public long Factorial(int n)
    {
        return n switch
        {
            0 => 1,
            _ => n * Factorial(n - 1)
        };
    }

    public long UnevenFactorial(int n)
    {
        if (n is 0 or 1)
        {
            return 1;
        }

        if (n % 2 is 0)
        {
            return UnevenFactorial(n - 1);
        }

        return n * UnevenFactorial(n - 2);
    }

}
