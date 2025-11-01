namespace Tolitech.Exceptions.Database;

/// <summary>
/// Exception thrown when a foreign key constraint violation occurs.
/// This indicates that an attempt was made to insert or update a value
/// that does not have a corresponding value in the referenced table.
/// </summary>
public class ForeignKeyViolationException : DatabaseConstraintViolationException
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ForeignKeyViolationException"/> class.
    /// </summary>
    public ForeignKeyViolationException()
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="ForeignKeyViolationException"/> class
    /// with a specified error message.
    /// </summary>
    /// <param name="message">The message that describes the error.</param>
    public ForeignKeyViolationException(string message)
        : base(message)
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="ForeignKeyViolationException"/> class
    /// with a specified error message and a reference to the inner exception
    /// that is the cause of this exception.
    /// </summary>
    /// <param name="message">The message that describes the error.</param>
    /// <param name="innerException">The exception that is the cause of the current exception, or a null reference if no inner exception is specified.</param>
    public ForeignKeyViolationException(string message, Exception innerException)
        : base(message, innerException)
    {
    }
}