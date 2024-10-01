namespace RapidDataCodingChallenge.MathLibrary.Internal;

using System.Linq;

internal class IterativeMathLib : IInternalMathLib
{
    public long Factorial(int n)
    {
        return Enumerable.Range(1, n)
            .Aggregate(1L, (product, next) => product * next);
    }

    public long UnevenFactorial(int n)
    {
        return Enumerable.Range(1, n)
            .Where(x => x % 2 is 1)
            .Aggregate(1L, (product, next) => product * next);
    }
}
