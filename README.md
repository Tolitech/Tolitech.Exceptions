# Tolitech.Application.Exceptions

## Overview

Tolitech.Application.Exceptions is a modern .NET library designed to provide a robust set of custom exception types for handling database constraint violations and other application-specific errors. By leveraging clear, purpose-driven exception classes, this library enables developers to write more maintainable, expressive, and reliable error handling code in .NET applications.

## Features

- **Specialized Exception Types**: Includes custom exceptions for primary key, foreign key, unique index, and check constraint violations, as well as a base exception for general database constraint errors.
- **Consistent Error Handling**: Promotes best practices by encouraging the use of specific exception types, making error handling code more readable and maintainable.
- **Extensible Design**: Easily extend the library with your own custom exceptions to suit your application's needs.
- **Unit-Tested**: Comprehensive unit tests ensure reliability and correctness of exception behavior.

## Exception Types

- `DatabaseConstraintViolationException`: Base class for all database constraint violation exceptions.
- `PrimaryKeyViolationException`: Thrown when a primary key constraint is violated.
- `ForeignKeyViolationException`: Thrown when a foreign key constraint is violated.
- `UniqueIndexViolationException`: Thrown when a unique index constraint is violated.
- `CheckConstraintViolationException`: Thrown when a check constraint is violated.

## Usage Example

```csharp
try
{
    // Database operation that may violate constraints
}
catch (PrimaryKeyViolationException ex)
{
    // Handle primary key violation
    Console.WriteLine($"Primary key error: {ex.Message}");
}
catch (DatabaseConstraintViolationException ex)
{
    // Handle other database constraint violations
    Console.WriteLine($"Database constraint error: {ex.Message}");
}
```

## Extending the Library

You can create your own custom exceptions by inheriting from `DatabaseConstraintViolationException` or any other provided base class. This allows you to tailor error handling to your application's domain.

```csharp
public class CustomBusinessRuleException : DatabaseConstraintViolationException
{
    public CustomBusinessRuleException(string message) : base(message) { }
}
```

## Testing

Unit tests are provided to verify the correct behavior of all exception types, including constructor logic and property assignments. This ensures that your error handling code remains robust as your application evolves.

## Summary

Tolitech.Application.Exceptions empowers .NET developers to implement clear, maintainable, and reliable error handling strategies for database operations and beyond. Its extensible and well-tested design makes it a valuable addition to any modern .NET application.
