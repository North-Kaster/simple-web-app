namespace MathService.Tests;

public class FactorialTests
{
    [Fact]
    public void Fact_5()
    {
        Assert.Equal(120,FactorialService.getFactorialOf(5));
    }

    [Fact]
    public void Fact_8()
    {
        Assert.Equal(40320,FactorialService.getFactorialOf(8));
    }

    [Fact]
    public void Fact_NegativeInput()
    {
        Assert.Throws<Exception>(()=>{
        FactorialService.getFactorialOf(-5);
        });
    }
}