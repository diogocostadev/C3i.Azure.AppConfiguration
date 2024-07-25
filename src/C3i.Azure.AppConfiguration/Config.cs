using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.AzureAppConfiguration;
using C3i.Azure.AppConfiguration.Mensagens;
using C3i.Azure.AppConfiguration.Util;
using C3i.Azure.AppConfiguration.Validacoes;

namespace C3i.Azure.AppConfiguration.Services;

public static class Config
{
    const string conexao_azure = "ConnectionStringAzure";
    
    public static void InicializarVariaveisAmbiente(this WebApplicationBuilder builder, string projectName)
    {
        Validador.ValidarNomeProjeto(projectName);
        Validador.ValidarVariavelAmbiente(conexao_azure);

        builder.Configuration.AddAzureAppConfiguration(op =>
        {
            op.Connect(Environment.GetEnvironmentVariable(conexao_azure))
                .Select($"{projectName}:*", builder.Environment.EnvironmentName);
        });

        builder.Services.AddAzureAppConfiguration();
    }
}
