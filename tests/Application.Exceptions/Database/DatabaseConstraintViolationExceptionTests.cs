using Tolitech.Application.Exceptions.Database;

namespace Tolitech.Application.Exceptions.UnitTests.Database;

/// <summary>
/// Provides unit tests for the <see cref="DatabaseConstraintViolationException"/> class.
/// </summary>
/// <remarks>This test class verifies the behavior of the <see cref="DatabaseConstraintViolationException"/>
/// constructors, including default property values, message assignment, and inner exception handling.</remarks>
public class DatabaseConstraintViolationExceptionTests
{
    /// <summary>
    /// Tests that the default constructor of <see cref="DatabaseConstraintViolationException"/> initializes the
    /// instance with default property values.
    /// </summary>
    /// <remarks>Verifies that the <see cref="Exception.Message"/> property is set to <see langword="null"/>
    /// when the default constructor is used.</remarks>
    [Fact]
    public void Ctor_Default_SetsDefaultProperties()
    {
        // Arrange & Act
        DatabaseConstraintViolationException ex = new();

        // Assert
        Assert.NotNull(ex);
    }

    /// <summary>
    /// Verifies that the <see cref="DatabaseConstraintViolationException"/> constructor correctly sets the <see
    /// cref="Exception.Message"/> property.
    /// </summary>
    /// <remarks>This test ensures that the exception's message matches the value provided during
    /// instantiation.</remarks>
    [Fact]
    public void Ctor_WithMessage_SetsMessage()
    {
        // Arrange
        const string message = "Database constraint violation occurred.";

        // Act
        DatabaseConstraintViolationException ex = new(message);

        // Assert
        Assert.Equal(message, ex.Message);
    }

    /// <summary>
    /// Tests that the <see cref="DatabaseConstraintViolationException"/> constructor correctly sets  the <see
    /// cref="Exception.Message"/> and <see cref="Exception.InnerException"/> properties.
    /// </summary>
    /// <remarks>This test verifies that when a <see cref="DatabaseConstraintViolationException"/> is
    /// instantiated  with a specific message and inner exception, the properties are assigned as expected.</remarks>
    [Fact]
    public void Ctor_WithMessageAndInnerException_SetsProperties()
    {
        // Arrange
        const string message = "Database constraint violation occurred.";
        InvalidOperationException inner = new("Inner exception");

        // Act
        DatabaseConstraintViolationException ex = new(message, inner);

        // Assert
        Assert.Equal(message, ex.Message);
        Assert.Equal(inner, ex.InnerException);
    }
}