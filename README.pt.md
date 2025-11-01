# Tolitech.Exceptions

## Visão Geral

Tolitech.Exceptions é uma biblioteca moderna para .NET, projetada para fornecer um conjunto robusto de tipos de exceções personalizadas para tratamento de violações de restrições de banco de dados e outros erros específicos da aplicação. Utilizando classes de exceção claras e orientadas ao propósito, esta biblioteca permite que desenvolvedores escrevam código de tratamento de erros mais expressivo, confiável e fácil de manter em aplicações .NET.

## Funcionalidades

- **Tipos de Exceção Especializados**: Inclui exceções personalizadas para violações de chave primária, chave estrangeira, índice único e restrições de verificação, além de uma exceção base para erros gerais de restrição de banco de dados.
- **Tratamento de Erros Consistente**: Promove boas práticas ao incentivar o uso de tipos de exceção específicos, tornando o código de tratamento de erros mais legível e organizado.
- **Design Extensível**: Permite a extensão da biblioteca com suas próprias exceções personalizadas, adaptando-se às necessidades do seu domínio.
- **Testes Unitários**: Testes abrangentes garantem a confiabilidade e correção do comportamento das exceções.

## Tipos de Exceção

- `DatabaseConstraintViolationException`: Classe base para todas as exceções de violação de restrição de banco de dados.
- `PrimaryKeyViolationException`: Lançada quando ocorre violação de chave primária.
- `ForeignKeyViolationException`: Lançada quando ocorre violação de chave estrangeira.
- `UniqueIndexViolationException`: Lançada quando ocorre violação de índice único.
- `CheckConstraintViolationException`: Lançada quando ocorre violação de restrição de verificação.

## Exemplo de Uso

```csharp
try
{
    // Operação de banco de dados que pode violar restrições
}
catch (PrimaryKeyViolationException ex)
{
    // Tratamento para violação de chave primária
    Console.WriteLine($"Erro de chave primária: {ex.Message}");
}
catch (DatabaseConstraintViolationException ex)
{
    // Tratamento para outras violações de restrição de banco de dados
    Console.WriteLine($"Erro de restrição de banco: {ex.Message}");
}
```

## Estendendo a Biblioteca

Você pode criar suas próprias exceções personalizadas herdando de `DatabaseConstraintViolationException` ou de qualquer outra classe base fornecida. Isso permite adaptar o tratamento de erros ao domínio da sua aplicação.

```csharp
public class RegraDeNegocioException : DatabaseConstraintViolationException
{
    public RegraDeNegocioException(string message) : base(message) { }
}
```

## Testes

Testes unitários garantem o comportamento correto de todos os tipos de exceção, incluindo lógica dos construtores e atribuição de propriedades. Isso assegura que seu código de tratamento de erros permaneça robusto conforme sua aplicação evolui.

## Resumo

Tolitech.Exceptions capacita desenvolvedores .NET a implementar estratégias de tratamento de erros claras, organizadas e confiáveis para operações de banco de dados e além. Seu design extensível e testado faz dela uma adição valiosa para qualquer aplicação moderna em .NET.
