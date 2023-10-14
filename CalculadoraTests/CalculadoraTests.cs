using Calculadora.Services;

namespace CalculadoraTests;

public class CalculadoraTests
{

    private CalculadoraImp _calc;
    public CalculadoraTests()
    {
        _calc = new CalculadoraImp();
    }

    [Fact]
    public void DeveSomar5Com10ERetornar15()
    {
        //Arange
        int nu1 = 5;
        int nu2 = 10;
        //Act
        int resultado = _calc.Somar(nu1, nu2);
        //Assert
        Assert.Equal(15, resultado);
    }
     [Fact]
    public void DeveSomar10Com10ERetornar20()
    {
        //Arange
        int nu1 = 10;
        int nu2 = 10;
        //Act
        int resultado = _calc.Somar(nu1, nu2);
        //Assert
        Assert.Equal(20, resultado);
    }
    [Theory]
    [InlineData(1,4,5)]
    [InlineData(6,4,10)]
    public void TesteSomar(int val1, int val2,int resultado)
    {
        int resultadoCalculo = _calc.Somar(val1,val2);

        Assert.Equal(resultado,resultadoCalculo);
    }
     [Theory]
    [InlineData(1,4,-3)]
    public void TesteSubtrair(int val1, int val2,int resultado)
    {
        int resultadoCalculo = _calc.Subtrair(val1,val2);

        Assert.Equal(resultado,resultadoCalculo);
    }
    [Theory]
    [InlineData(4,1,4)]
    public void TesteDividir(int val1, int val2,int resultado)
    {
        int resultadoCalculo = _calc.Dividir(val1,val2);

        Assert.Equal(resultado,resultadoCalculo);
    }
    [Theory]
    [InlineData(4,1,4)]
    public void TesteMultiplicar(int val1, int val2,int resultado)
    {
        int resultadoCalculo = _calc.Multiplicar(val1,val2);

        Assert.Equal(resultado,resultadoCalculo);
    }

    [Fact]
    public void TestName()
    {
        _calc.Somar(1,2);
        _calc.Somar(1,5);
        _calc.Somar(1,7);
        _calc.Somar(1,8);

        var lista = _calc.Historico();

        Assert.NotEmpty(lista);
        Assert.Equal(3, lista.Count);

    }
    
}
    