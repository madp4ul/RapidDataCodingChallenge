using RapidDataCodingChallenge.MathLibrary.Implementation;

namespace RapidDataCodingChallenge.MathLibrary;

using RapidDataCodingChallenge.MathLibrary.Internal;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class MathLib : IMathLib
{
    private readonly IInternalMathLib _internalMathLib;

    public MathLib(MathLibOptions options)
    {
        _internalMathLib = options.AlgorithmPreference switch
        {
            MathAlgorithmPreference.RecursiveAlgorith => new RecursiveMathLib(),
            MathAlgorithmPreference.IterativeAlgoritm => new IterativeMathLib(),
            _ => throw new NotSupportedException($"{nameof(options.AlgorithmPreference)} '{options.AlgorithmPreference}' is not supported."),
        };
    }

    public long Factorial(uint n)
    {
        ThrowIfLargerThanMaximum(n, IMathLib.MaximumSupportedFactorial);

        return _internalMathLib.Factorial(n);
    }

    public long SquareFactorial(uint n)
    {
        ThrowIfLargerThanMaximum(n, IMathLib.MaximumSupportedSquareFactorial);

        long factorial = Factorial(n);

        return factorial * factorial;
    }

    public long UnevenFactorial(uint n)
    {
        ThrowIfLargerThanMaximum(n, IMathLib.MaximumSupportedUnevenFactorial);

        return _internalMathLib.UnevenFactorial(n);
    }

    private void ThrowIfLargerThanMaximum(uint n, uint maximumN)
    {
        if (n > maximumN)
        {
            throw new ArgumentOutOfRangeException(nameof(n), $"Resulting factorial is larger than maximum for long: {long.MaxValue}. Only inputs up to {maximumN} are supported.");
        }
    }
}
