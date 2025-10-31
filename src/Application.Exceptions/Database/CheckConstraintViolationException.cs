namespace Tolitech.Application.Exceptions.Database;

/// <summary>
/// Exception thrown when a check constraint violation occurs.
/// This indicates that an attempt was made to insert or update a value
/// that violates the check constraint defined on a column.
/// </summary>
public class CheckConstraintViolationException : DatabaseConstraintViolationException
{
    /// <summary>
    /// Initializes a new instance of the <see cref="CheckConstraintViolationException"/> class.
    /// </summary>
    public CheckConstraintViolationException()
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="CheckConstraintViolationException"/> class
    /// with a specified error message.
    /// </summary>
    /// <param name="message">The message that describes the error.</param>
    public CheckConstraintViolationException(string message)
        : base(message)
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="CheckConstraintViolationException"/> class
    /// with a specified error message and a reference to the inner exception
    /// that is the cause of this exception.
    /// </summary>
    /// <param name="message">The message that describes the error.</param>
    /// <param name="innerException">The exception that is the cause of the current exception, or a null reference if no inner exception is specified.</param>
    public CheckConstraintViolationException(string message, Exception innerException)
        : base(message, innerException)
    {
    }
}