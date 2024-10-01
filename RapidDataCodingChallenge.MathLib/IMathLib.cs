namespace RapidDataCodingChallenge.MathLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public interface IMathLib
{
    public const uint MaximumSupportedFactorial = 20;
    public const uint MaximumSupportedUnevenFactorial = 33;
    public const uint MaximumSupportedSquareFactorial = 12;

    long Factorial(uint n);

    long UnevenFactorial(uint n);

    long SquareFactorial(uint n);
}
