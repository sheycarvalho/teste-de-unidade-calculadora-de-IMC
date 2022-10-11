using CalcIMC;

namespace TestXUnit;
public class TestCalcXUnit
{
    [Theory]
    [InlineData(77, 1.7, "Sobrepeso")]
    [InlineData(99, 1.75, "Obesidade Grau I")]
    [InlineData(65, 1.65, "Normal")]

    public void TesteCalcIMC(double kg, double altura, string resultadoTeste)
    {
        //Act
        var resultadoIMC = Calculadora.CalcularImc(kg, altura);

        //Assert
        Assert.Equal(resultadoTeste, resultadoIMC);
    }
}
