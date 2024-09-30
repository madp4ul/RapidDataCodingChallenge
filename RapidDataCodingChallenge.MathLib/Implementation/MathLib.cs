namespace RapidDataCodingChallenge.MathLibrary.Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class MathLib : IMathLib
{
    private readonly IMathLib _internalMathLib;

    public MathLib(MathLibOptions options)
    {
        _internalMathLib = options.AlgorithmPreference switch
        {
            MathAlgorithmPreference.RecursiveAlgorith => new RecursiveMathLib(),
            MathAlgorithmPreference.IterativeAlgoritm => new IterativeMathLib(),
            _ => throw new NotSupportedException(),
        };
    }

    public long Factorial(int n) => _internalMathLib.Factorial(n);

    public long SquareFactorial(int n) => _internalMathLib.SquareFactorial(n);

    public long UnevenFactorial(int n) => _internalMathLib.UnevenFactorial(n);
}
