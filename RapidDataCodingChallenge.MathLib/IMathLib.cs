namespace RapidDataCodingChallenge.MathLibrary;

public interface IMathLib
{
    public const int MaximumSupportedFactorial = 20;
    public const int MaximumSupportedUnevenFactorial = 33;
    public const int MaximumSupportedSquareFactorial = 12;

    long Factorial(int n);

    long UnevenFactorial(int n);

    long SquareFactorial(int n);
}
