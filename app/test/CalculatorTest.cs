namespace activity_2;

using Xunit;
public class CalculatorTest
{
   [Fact]
    public void Add_TwoIntegers_ReturnsCorrectSum()
    {
        double? result = Calculator.Calculate(10, 5, "+");
        Assert.Equal(15, result);
    }

    [Fact]
    public void Subtract_TwoIntegers_ReturnsCorrectDifference()
    {
        double? result = Calculator.Calculate(10, 5, "-");
        Assert.Equal(5, result);
    }

    [Fact]
    public void Multiply_TwoIntegers_ReturnsCorrectProduct()
    {
        double? result = Calculator.Calculate(10, 5, "*");
        Assert.Equal(50, result);
    }

    [Fact]
    public void Divide_TwoIntegers_ReturnsCorrectDouble()
    {
        double? result = Calculator.Calculate(10, 4, "/");
        Assert.Equal(2.5, result);
    }

    [Fact]
    public void Divide_ByZero_ReturnsNull()
    {
        double? result = Calculator.Calculate(10, 0, "/");
        Assert.Null(result);
    }

    [Fact]
    public void Modulo_TwoIntegers_ReturnsRemainder()
    {
        double? result = Calculator.Calculate(10, 3, "%");
        Assert.Equal(1, result);
    }

    [Fact]
    public void Modulo_ByZero_ReturnsNull()
    {
        double? result = Calculator.Calculate(10, 0, "%");
        Assert.Null(result);
    }

    [Fact]
    public void InvalidOperation_ReturnsNull()
    {
        double? result = Calculator.Calculate(10, 5, ";");
        Assert.Null(result);
    }
}
