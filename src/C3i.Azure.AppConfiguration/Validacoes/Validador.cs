using C3i.Azure.AppConfiguration.Mensagens;
using C3i.Azure.AppConfiguration.Util;

namespace C3i.Azure.AppConfiguration.Validacoes;

public static class Validador
{
    public static void ValidarVariavelAmbiente(string nomeVariavel)
    {
        if (string.IsNullOrWhiteSpace(Environment.GetEnvironmentVariable(nomeVariavel)))
        {
            throw new ArgumentNullException(nomeVariavel, 
                string.Format(CatalogoMensagens.ErroFaltaVariavelAmbiente.LerDescricao(), nomeVariavel));
        }
    }

    public static void ValidarNomeProjeto(string nomeProjeto)
    {
        if (string.IsNullOrWhiteSpace(nomeProjeto))
        {
            throw new ArgumentNullException(nameof(nomeProjeto), 
                CatalogoMensagens.ErroFaltaVariavelAmbiente.LerDescricao());
        }
    }
}