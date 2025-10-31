namespace Tolitech.Application.Exceptions.Database;

/// <summary>
/// Exception thrown when a database constraint violation occurs.
/// This can be due to primary key, foreign key, unique index,
/// or check constraint violations during database operations.
/// </summary>
public class DatabaseConstraintViolationException : Exception
{
    /// <summary>
    /// Initializes a new instance of the <see cref="DatabaseConstraintViolationException"/> class.
    /// </summary>
    public DatabaseConstraintViolationException()
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="DatabaseConstraintViolationException"/> class
    /// with a specified error message.
    /// </summary>
    /// <param name="message">The message that describes the error.</param>
    public DatabaseConstraintViolationException(string message)
        : base(message)
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="DatabaseConstraintViolationException"/> class
    /// with a specified error message and a reference to the inner exception
    /// that is the cause of this exception.
    /// </summary>
    /// <param name="message">The message that describes the error.</param>
    /// <param name="innerException">The exception that is the cause of the current exception, or a null reference if no inner exception is specified.</param>
    public DatabaseConstraintViolationException(string message, Exception innerException)
        : base(message, innerException)
    {
    }
}