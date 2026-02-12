using System.Runtime.InteropServices;
using Calc;

namespace CalcTest;

public class UnitTest1
{
    //[Fact]
    [Theory]
    [InlineData(5,2,7)]
    [InlineData(0,0,0)]
    [InlineData(-5,5,0)]
    public void Sum_a_and_b_gives_x(int a, int b, int x)
    {
        // setup
        var c = new Calculator();
        // esercitare SUT
        var result = c.Sum(a, b);
        // verificare risultato
        Assert.Equal(x, result);
    }
    [Theory]
    [InlineData(0,0,0)]
    [InlineData(1,1,1)]
    [InlineData(2,5,10)]
    public void Mul_a_and_b_gives_x(int a, int b, int x)
    {
        // setup
        var c = new Calculator();
        // esercitare SUT
        var result = c.Mul(a, b);
        // verificare risultato
        Assert.Equal(x, result);
    }

    [Fact]
    public void Div_by_Zero()
    {
        var c = new Calculator();
        Assert.Throws<DivideByZeroException>(() => c.Div(5, 0));
    }
}
