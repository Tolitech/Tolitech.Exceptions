namespace Tolitech.Exceptions.Database;

/// <summary>
/// Exception thrown when a NOT NULL constraint violation occurs.
/// This indicates that an attempt was made to insert or update a column
/// with a NULL value in a column defined as NOT NULL.
/// </summary>
public class NotNullConstraintViolationException : DatabaseConstraintViolationException
{
    /// <summary>
    /// Initializes a new instance of the <see cref="NotNullConstraintViolationException"/> class.
    /// </summary>
    public NotNullConstraintViolationException()
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="NotNullConstraintViolationException"/> class
    /// with a specified error message.
    /// </summary>
    /// <param name="message">The message that describes the error.</param>
    public NotNullConstraintViolationException(string message)
        : base(message)
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="NotNullConstraintViolationException"/> class
    /// with a specified error message and a reference to the inner exception
    /// that is the cause of this exception.
    /// </summary>
    /// <param name="message">The message that describes the error.</param>
    /// <param name="innerException">The exception that is the cause of the current exception, or a null reference if no inner exception is specified.</param>
    public NotNullConstraintViolationException(string message, Exception innerException)
        : base(message, innerException)
    {
    }
}