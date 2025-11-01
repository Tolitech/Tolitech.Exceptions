namespace Tolitech.Exceptions.Database;

/// <summary>
/// Exception thrown when a primary key constraint violation occurs.
/// This indicates that an attempt was made to insert a duplicate key value
/// in a column defined as a primary key.
/// </summary>
public class PrimaryKeyViolationException : DatabaseConstraintViolationException
{
    /// <summary>
    /// Initializes a new instance of the <see cref="PrimaryKeyViolationException"/> class.
    /// </summary>
    public PrimaryKeyViolationException()
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="PrimaryKeyViolationException"/> class
    /// with a specified error message.
    /// </summary>
    /// <param name="message">The message that describes the error.</param>
    public PrimaryKeyViolationException(string message)
        : base(message)
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="PrimaryKeyViolationException"/> class
    /// with a specified error message and a reference to the inner exception
    /// that is the cause of this exception.
    /// </summary>
    /// <param name="message">The message that describes the error.</param>
    /// <param name="innerException">The exception that is the cause of the current exception, or a null reference if no inner exception is specified.</param>
    public PrimaryKeyViolationException(string message, Exception innerException)
        : base(message, innerException)
    {
    }
}