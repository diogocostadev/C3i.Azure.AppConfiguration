using C3i.Azure.AppConfiguration.Validacoes;

namespace C3i.Azure.AppConfiguration.Services.Tests.Validacoes;

public class ValidadorTests
{
    [Fact]
    public void ValidarVariavelDeAmbiente_DeveLancarArgumentNullException_QuandoVariavelEstaFaltando()
    {
        // Arrange
        string nomeDaVariavel = "VariavelFaltando";

        // Act & Assert
        var excecao = Assert.Throws<ArgumentNullException>(() => Validador.ValidarVariavelAmbiente(nomeDaVariavel));
        Assert.Equal(nomeDaVariavel, excecao.ParamName);
    }

    [Fact]
    public void ValidarVariavelDeAmbiente_NaoDeveLancarExcecao_QuandoVariavelExiste()
    {
        // Arrange
        string nomeDaVariavel = "VariavelExistente";
        Environment.SetEnvironmentVariable(nomeDaVariavel, "ValorQualquer");

        // Act & Assert
        Validador.ValidarVariavelAmbiente(nomeDaVariavel);

        // Cleanup
        Environment.SetEnvironmentVariable(nomeDaVariavel, null);
    }

    [Fact]
    public void ValidarNomeDoProjeto_DeveLancarArgumentNullException_QuandoNomeDoProjetoEstaFaltando()
    {
        // Arrange
        string nomeDoProjeto = null;

        // Act & Assert
        var excecao = Assert.Throws<ArgumentNullException>(() => Validador.ValidarNomeProjeto(nomeDoProjeto));
        Assert.Equal("nomeProjeto", excecao.ParamName);
    }

    [Fact]
    public void ValidarNomeDoProjeto_NaoDeveLancarExcecao_QuandoNomeDoProjetoExiste()
    {
        // Arrange
        string nomeDoProjeto = "NomeDoProjetoValido";

        // Act & Assert
        Validador.ValidarNomeProjeto(nomeDoProjeto);
    }
}