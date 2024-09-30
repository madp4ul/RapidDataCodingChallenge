namespace RapidDataCodingChallenge.UnitTests;

using RapidDataCodingChallenge.MathLibrary;
using RapidDataCodingChallenge.MathLibrary.Implementation;

[TestFixture(MathAlgorithmPreference.IterativeAlgoritm)]
[TestFixture(MathAlgorithmPreference.RecursiveAlgorith)]
public class MathLibTest(MathAlgorithmPreference algorithmPreference)
{
    private readonly MathAlgorithmPreference _algorithmPreference = algorithmPreference;

    private MathLib _systemUnderTest = null!;

    [SetUp]
    public void Setup()
    {
        _systemUnderTest = new MathLib(new MathLibOptions
        {
            AlgorithmPreference = _algorithmPreference
        });
    }

    /// <summary>
    /// <see cref="MathLib.Factorial(int)"/> returns product of all integers from 1 to n.
    /// </summary>
    [Test]
    [TestCase(0, 1)]
    [TestCase(1, 1)]
    [TestCase(3, 1 * 2 * 3)]
    [TestCase(7, 1 * 2 * 3 * 4 * 5 * 6 * 7)]
    [TestCase(20, 2_432_902_008_176_640_000)] // pre-calculated
    public void Factorial_ReturnsProductOfAllIntegersFrom1ToN(int n, long expectedResult)
    {
        // Act
        long result = _systemUnderTest.Factorial(n);

        // Assert
        Assert.That(result, Is.EqualTo(expectedResult));
    }

    /// <summary>
    /// <see cref="MathLib.Factorial(int)"/> throws <see cref="ArgumentOutOfRangeException"/> if result would be too large for long number.
    /// </summary>
    [Test]
    public void Factorial_ThrowsArgumentOutOfRangeException_IfResultWouldBeTooLargeForLongNumber(
        [Values(21, 22, 30, int.MaxValue)] int n)
    {
        Assert.Throws<ArgumentOutOfRangeException>(() => _systemUnderTest.Factorial(n));
    }


    /// <summary>
    /// <see cref="MathLib.UnevenFactorial(int)"/> returns product of all uneven integers from 1 to n.
    /// </summary>
    [Test]
    [TestCase(1, 1)]
    [TestCase(3, 1 * 3)]
    [TestCase(7, 1 * 3 * 5 * 7)]
    [TestCase(33, 6_332_659_870_762_850_625)] // pre-calculated
    public void UnevenFactorial_ReturnsProductOfAllUnevenIntegersFrom1ToN(int n, long expectedResult)
    {
        // Act
        long result = _systemUnderTest.UnevenFactorial(n);

        // Assert
        Assert.That(result, Is.EqualTo(expectedResult));
    }

    /// <summary>
    /// <see cref="MathLib.UnevenFactorial(int)"/> throws <see cref="ArgumentOutOfRangeException"/> if result would be too large for long number.
    /// </summary>
    [Test]
    public void UnevenFactorial_ThrowsArgumentOutOfRangeException_IfResultWouldBeTooLargeForLongNumber(
        [Values(34, 35, 40, int.MaxValue)] int n)
    {
        Assert.Throws<ArgumentOutOfRangeException>(() => _systemUnderTest.UnevenFactorial(n));
    }

    /// <summary>
    /// <see cref="MathLib.SquareFactorial(int)"/> returns squared product of all integers from 1 to n.
    /// </summary>
    [Test]
    [TestCase(1, 1 * 1)]
    [TestCase(3, 1 * 1 * 2 * 2 * 3 * 3)]
    [TestCase(7, 1 * 1 * 2 * 2 * 3 * 3 * 4 * 4 * 5 * 5 * 6 * 6 * 7 * 7)]
    [TestCase(12, 229_442_532_802_560_000)] // pre-calculated
    public void SquareFactorial_ReturnsProductOfAllUnevenIntegersFrom1ToN(int n, long expectedResult)
    {
        // Act
        long result = _systemUnderTest.SquareFactorial(n);

        // Assert
        Assert.That(result, Is.EqualTo(expectedResult));
    }

    /// <summary>
    /// <see cref="MathLib.SquareFactorial(int)"/> throws <see cref="ArgumentOutOfRangeException"/> if result would be too large for long number.
    /// </summary>
    [Test]
    public void SquareFactorial_ThrowsArgumentOutOfRangeException_IfResultWouldBeTooLargeForLongNumber(
        [Values(13, 14, 40, int.MaxValue)] int n)
    {
        Assert.Throws<ArgumentOutOfRangeException>(() => _systemUnderTest.SquareFactorial(n));
    }
}