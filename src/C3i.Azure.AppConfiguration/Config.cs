using C3i.Azure.AppConfiguration.Util;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using C3i.Azure.AppConfiguration.Validacoes;

namespace C3i.Azure.AppConfiguration.Services;

public static class Config
{
    const string conexao_azure = "ConnectionStringAzure";
    
    public static void InicializarVariaveisAmbiente(this WebApplicationBuilder builder)
    {
        string nomeProjeto = ProjetoInfo.LerNomeProjeto();
        Validador.ValidarNomeProjeto(nomeProjeto);
        Validador.ValidarVariavelAmbiente(conexao_azure);

        builder.Configuration.AddAzureAppConfiguration(op =>
        {
            op.Connect(Environment.GetEnvironmentVariable(conexao_azure))
                .Select($"{nomeProjeto}:*", builder.Environment.EnvironmentName)
                .Select($"DB:*", builder.Environment.EnvironmentName);
        });

        builder.Services.AddAzureAppConfiguration();
    }
}
