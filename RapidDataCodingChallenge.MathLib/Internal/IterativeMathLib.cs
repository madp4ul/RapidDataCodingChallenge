namespace RapidDataCodingChallenge.MathLibrary.Implementation;

using RapidDataCodingChallenge.MathLibrary.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class IterativeMathLib : IInternalMathLib
{
    public long Factorial(uint n)
    {
        return Enumerable.Range(1, (int)n)
            .Aggregate(1L, (product, next) => product * next);
    }

    public long UnevenFactorial(uint n)
    {
        return Enumerable.Range(1, (int)n)
            .Where(x => x % 2 is 1)
            .Aggregate(1L, (product, next) => product * next);
    }
}
