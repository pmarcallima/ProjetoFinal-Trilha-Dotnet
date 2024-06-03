using Calculadora.Services;

namespace CalculadoraTestes;

public class CalculadoraTests
{
    private CalculadoraImp _calc = new CalculadoraImp();

    [Theory]
    [InlineData(1, 2, 3)]
    [InlineData(4, 8, 12)]
    public void TesteSoma(int num1, int num2, int resultadoEsperado)
    {
        int resultado = _calc.Somar(num1, num2);

        Assert.Equal(resultado, resultadoEsperado);
    }

    [Theory]
    [InlineData(1, 2, 2)]
    [InlineData(4, 8, 32)]
    public void TesteMultiplicar(int num1, int num2, int resultadoEsperado)
    {
        int resultado = _calc.Multiplicar(num1, num2);

        Assert.Equal(resultado, resultadoEsperado);
    }

    [Theory]
    [InlineData(6, 2, 3)]
    [InlineData(18, 9, 2)]
    public void TesteDividir(int num1, int num2, int resultadoEsperado)
    {
        int resultado = _calc.Dividir(num1, num2);

        Assert.Equal(resultado, resultadoEsperado);
    }

    [Theory]
    [InlineData(1, 2, -1)]
    [InlineData(4, 8, -4)]
    public void TesteSubtrair(int num1, int num2, int resultadoEsperado)
    {
        int resultado = _calc.Subtrair(num1, num2);

        Assert.Equal(resultado, resultadoEsperado);
    }

    [Fact]
    public void TesteDivizaoPorZero()
    {
        Assert.Throws<DivideByZeroException>(() => _calc.Dividir(5, 0));
    }

    [Fact]
    public void TestarHistorico()
    {
        _calc.Somar(1, 2);
        _calc.Somar(2, 8);
        _calc.Somar(5, 4);
        _calc.Somar(10, 15);

        var lista = _calc.historico();

        Assert.NotEmpty(lista);
        Assert.Equal(3, lista.Count);
        _calc.mostrarData();
    }
}
