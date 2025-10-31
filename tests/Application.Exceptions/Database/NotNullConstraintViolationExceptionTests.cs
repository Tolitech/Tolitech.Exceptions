using Tolitech.Application.Exceptions.Database;

namespace Tolitech.Application.Exceptions.UnitTests.Database;

/// <summary>
/// Contains unit tests for the <see cref="NotNullConstraintViolationException"/> class, verifying its constructors and
/// property behaviors.
/// </summary>
/// <remarks>This test class ensures that the <see cref="NotNullConstraintViolationException"/> behaves as
/// expected when instantiated with different constructor parameters. It validates the initialization of properties such
/// as <see cref="Exception.Message"/> and <see cref="Exception.InnerException"/>.</remarks>
public class NotNullConstraintViolationExceptionTests
{
    /// <summary>
    /// Tests that the default constructor of <see cref="NotNullConstraintViolationException"/> initializes its
    /// properties to their default values.
    /// </summary>
    [Fact]
    public void Ctor_Default_SetsDefaultProperties()
    {
        // Arrange & Act
        NotNullConstraintViolationException ex = new();

        // Assert
        Assert.NotNull(ex);
    }

    /// <summary>
    /// Verifies that the <see cref="NotNullConstraintViolationException"/> constructor correctly sets the <see
    /// cref="Exception.Message"/> property.
    /// </summary>
    /// <remarks>This test ensures that the exception message provided during construction is accurately
    /// assigned to the <see cref="Exception.Message"/> property.</remarks>
    [Fact]
    public void Ctor_WithMessage_SetsMessage()
    {
        // Arrange
        const string message = "Not null constraint violation occurred.";

        // Act
        NotNullConstraintViolationException ex = new(message);

        // Assert
        Assert.Equal(message, ex.Message);
    }

    /// <summary>
    /// Verifies that the <see cref="NotNullConstraintViolationException"/> constructor correctly sets  the <see
    /// cref="Exception.Message"/> and <see cref="Exception.InnerException"/> properties.
    /// </summary>
    /// <remarks>This test ensures that when a <see cref="NotNullConstraintViolationException"/> is
    /// instantiated  with a message and an inner exception, the provided values are properly assigned to the
    /// corresponding properties.</remarks>
    [Fact]
    public void Ctor_WithMessageAndInnerException_SetsProperties()
    {
        // Arrange
        const string message = "Not null constraint violation occurred.";
        InvalidOperationException inner = new("Inner exception");

        // Act
        NotNullConstraintViolationException ex = new(message, inner);

        // Assert
        Assert.Equal(message, ex.Message);
        Assert.Equal(inner, ex.InnerException);
    }
}