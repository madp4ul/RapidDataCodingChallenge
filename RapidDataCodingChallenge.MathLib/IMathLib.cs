namespace RapidDataCodingChallenge.MathLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public interface IMathLib
{
    public const int MaximumSupportedFactorial = 20;
    public const int MaximumSupportedUnevenFactorial = 33;
    public const int MaximumSupportedSquareFactorial = 12;

    long Factorial(int n);

    long UnevenFactorial(int n);

    long SquareFactorial(int n);
}
