using System.Reflection;

namespace C3i.Azure.AppConfiguration.Util;

public class ProjetoInfo
{
    public static string LerNomeProjeto()
    {
        var entryAssembly = Assembly.GetEntryAssembly();
        return entryAssembly != null ? entryAssembly.GetName().Name : "Nome de Projeto Desconhecido";
    }
}