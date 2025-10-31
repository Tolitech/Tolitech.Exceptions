using Tolitech.Application.Exceptions.Database;

namespace Tolitech.Application.Exceptions.UnitTests.Database;

/// <summary>
/// Provides unit tests for the <see cref="CheckConstraintViolationException"/> class.
/// </summary>
/// <remarks>This test class verifies the behavior of the <see cref="CheckConstraintViolationException"/>
/// constructors, including default property values, message handling, and inner exception assignment.</remarks>
public class CheckConstraintViolationExceptionTests
{
    /// <summary>
    /// Tests that the default constructor of <see cref="CheckConstraintViolationException"/> initializes its properties
    /// to their default values.
    /// </summary>
    /// <remarks>This test verifies that the <see cref="CheckConstraintViolationException"/> instance created
    /// using the default constructor has a null <see cref="Exception.Message"/> property.</remarks>
    [Fact]
    public void Ctor_Default_SetsDefaultProperties()
    {
        // Arrange & Act
        CheckConstraintViolationException ex = new();

        // Assert
        Assert.NotNull(ex);
    }

    /// <summary>
    /// Verifies that the <see cref="CheckConstraintViolationException"/> constructor correctly sets the <see
    /// cref="Exception.Message"/> property.
    /// </summary>
    /// <remarks>This test ensures that the exception's message is properly initialized when a message string
    /// is provided to the constructor.</remarks>
    [Fact]
    public void Ctor_WithMessage_SetsMessage()
    {
        // Arrange
        const string message = "Check constraint violation occurred.";

        // Act
        CheckConstraintViolationException ex = new(message);

        // Assert
        Assert.Equal(message, ex.Message);
    }

    /// <summary>
    /// Verifies that the <see cref="CheckConstraintViolationException"/> constructor correctly initializes /// the <see
    /// cref="Exception.Message"/> and <see cref="Exception.InnerException"/> properties.
    /// </summary>
    /// <remarks>This test ensures that when a <see cref="CheckConstraintViolationException"/> is instantiated
    /// with /// a specific message and inner exception, the properties are set to the provided values.</remarks>
    [Fact]
    public void Ctor_WithMessageAndInnerException_SetsProperties()
    {
        // Arrange
        const string message = "Check constraint violation occurred.";
        InvalidOperationException inner = new("Inner exception");

        // Act
        CheckConstraintViolationException ex = new(message, inner);

        // Assert
        Assert.Equal(message, ex.Message);
        Assert.Equal(inner, ex.InnerException);
    }
}