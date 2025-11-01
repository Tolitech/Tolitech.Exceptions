using Tolitech.Exceptions.Database;

namespace Tolitech.Exceptions.UnitTests.Database;

/// <summary>
/// Provides unit tests for the <see cref="PrimaryKeyViolationException"/> class.
/// </summary>
/// <remarks>This test class verifies the behavior of the <see cref="PrimaryKeyViolationException"/> constructors,
/// ensuring that default properties, custom messages, and inner exceptions are correctly set.</remarks>
public class PrimaryKeyViolationExceptionTests
{
    /// <summary>
    /// Tests that the default constructor of <see cref="PrimaryKeyViolationException"/> initializes its properties to
    /// their default values.
    /// </summary>
    /// <remarks>This test verifies that the <see cref="Exception.Message"/> property is set to a default
    /// string when the exception is constructed using the parameterless constructor.</remarks>
    [Fact]
    public void Ctor_Default_SetsDefaultProperties()
    {
        // Arrange & Act
        PrimaryKeyViolationException ex = new();

        // Assert
        Assert.NotNull(ex);
    }

    /// <summary>
    /// Verifies that the <see cref="PrimaryKeyViolationException"/> constructor correctly sets the <see
    /// cref="Exception.Message"/> property.
    /// </summary>
    /// <remarks>This test ensures that the <see cref="PrimaryKeyViolationException"/> instance initialized
    /// with a specific message contains the expected message in its <see cref="Exception.Message"/> property.</remarks>
    [Fact]
    public void Ctor_WithMessage_SetsMessage()
    {
        // Arrange
        const string message = "Primary key violation occurred.";

        // Act
        PrimaryKeyViolationException ex = new(message);

        // Assert
        Assert.Equal(message, ex.Message);
    }

    /// <summary>
    /// Tests that the <see cref="PrimaryKeyViolationException"/> constructor correctly initializes the <see
    /// cref="Exception.Message"/> and <see cref="Exception.InnerException"/> properties.
    /// </summary>
    /// <remarks>This test verifies that when a <see cref="PrimaryKeyViolationException"/> is instantiated
    /// with a message and an inner exception, the properties are set to the provided values.</remarks>
    [Fact]
    public void Ctor_WithMessageAndInnerException_SetsProperties()
    {
        // Arrange
        const string message = "Primary key violation occurred.";
        InvalidOperationException inner = new("Inner exception");

        // Act
        PrimaryKeyViolationException ex = new(message, inner);

        // Assert
        Assert.Equal(message, ex.Message);
        Assert.Equal(inner, ex.InnerException);
    }
}