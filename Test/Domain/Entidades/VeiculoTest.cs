using MinimalApi.Dominio.Entidades;

namespace Test.Domain.Entidades;

[TestClass]

public class VeiculoTest
{
    [TestMethod]
    public void TestandoGetSetPropriedades()
    {
        //Arrange
        var veiculo = new Veiculo();

        //Act
        veiculo.Id = 1;
        veiculo.Nome = "Focus";
        veiculo.Marca = "Ford";
        veiculo.Ano = 2020;

        //Assert
        Assert.AreEqual(1, veiculo.Id);
        Assert.AreEqual("Focus", veiculo.Nome);
        Assert.AreEqual("Ford", veiculo.Marca);
        Assert.AreEqual(2020, veiculo.Ano);
    }
}