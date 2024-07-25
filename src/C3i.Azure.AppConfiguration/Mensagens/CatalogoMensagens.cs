using System.ComponentModel;

namespace C3i.Azure.AppConfiguration.Mensagens;

public enum CatalogoMensagens
{
    [Description("Falta configuração da chave: {0}")]
    ErroFaltaVariavelAmbiente,
    
    [Description("Informe o nome do projeto")]
    ErroFaltaNomeProjeto
}