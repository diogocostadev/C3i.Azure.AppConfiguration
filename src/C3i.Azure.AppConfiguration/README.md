# C3i.Azure.AppConfiguration

C3i.Azure.AppConfiguration é uma biblioteca .NET que facilita a conexão e utilização do serviço Azure App Configuration em aplicações .NET 8.

## Visão Geral

O Azure App Configuration fornece uma maneira centralizada de gerenciar configurações e valores de recursos para suas aplicações. Esta biblioteca abstrai a complexidade de conectar-se ao Azure App Configuration e permite que você integre facilmente este serviço em suas aplicações .NET 8.

## Recursos

- Conexão simplificada ao Azure App Configuration.
- Suporte para múltiplos ambientes e projetos.
- Integração fácil com o `WebApplicationBuilder`.

## Instalação

Para instalar a biblioteca, adicione a referência ao pacote NuGet no seu projeto:

```sh
dotnet add package C3i.Azure.AppConfiguration
```

## Utilização

```sh
builder.InicializarVariaveisAmbiente();
```
No Serviço do Azure App Configuration, adicione as chaves de configuração no formato `NomeProjeto:Chave que deseja procurar` e `DB:Chave`.


## Contribuição

Contribuições são bem-vindas! Sinta-se à vontade para abrir uma issue ou enviar um pull request no GitHub.

## Licença

Este projeto está licenciado sob os termos da licença MIT. Veja o arquivo [LICENSE](LICENSE) para mais detalhes.

---

Feito com ❤️ por [Diogo](https://github.com/diogocostadev)
```

## Resumo

- **Visão Geral:** Introdução ao propósito da biblioteca.
- **Recursos:** Lista dos principais recursos da biblioteca.
- **Instalação:** Instruções para instalar a biblioteca via NuGet.
- **Contribuição:** Informações sobre como contribuir com o projeto.
- **Licença:** Informações sobre a licença do projeto.

Este README fornece uma visão clara e detalhada do projeto `C3i.Azure.AppConfiguration` e deve ajudar os usuários a entenderem como usar a biblioteca em suas aplicações .NET 8.