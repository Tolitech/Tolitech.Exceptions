using Tolitech.Application.Exceptions.Database;

namespace Tolitech.Application.Exceptions.UnitTests.Database;

/// <summary>
/// Provides unit tests for the <see cref="ForeignKeyViolationException"/> class.
/// </summary>
/// <remarks>This test class verifies the behavior of the <see cref="ForeignKeyViolationException"/> constructors,
/// including default property values, message assignment, and inner exception handling.</remarks>
public class ForeignKeyViolationExceptionTests
{
    /// <summary>
    /// Tests that the default constructor of <see cref="ForeignKeyViolationException"/> initializes the instance with
    /// default property values.
    /// </summary>
    /// <remarks>Specifically verifies that the <see cref="Exception.Message"/> property is set to <see
    /// langword="null"/> when the exception is created using the default constructor.</remarks>
    [Fact]
    public void Ctor_Default_SetsDefaultProperties()
    {
        // Arrange & Act
        ForeignKeyViolationException ex = new();

        // Assert
        Assert.NotNull(ex);
    }

    /// <summary>
    /// Verifies that the <see cref="ForeignKeyViolationException"/> constructor correctly sets the <see
    /// cref="Exception.Message"/> property.
    /// </summary>
    /// <remarks>This test ensures that the <see cref="ForeignKeyViolationException"/> instance initialized
    /// with a specific message contains the expected message in its <see cref="Exception.Message"/> property.</remarks>
    [Fact]
    public void Ctor_WithMessage_SetsMessage()
    {
        // Arrange
        const string message = "Foreign key violation occurred.";

        // Act
        ForeignKeyViolationException ex = new(message);

        // Assert
        Assert.Equal(message, ex.Message);
    }

    /// <summary>
    /// Tests that the <see cref="ForeignKeyViolationException"/> constructor correctly initializes      the <see
    /// cref="Exception.Message"/> and <see cref="Exception.InnerException"/> properties.
    /// </summary>
    /// <remarks>This test verifies that the <see cref="ForeignKeyViolationException"/> instance created with
    /// a specified message and inner exception properly sets its <see cref="Exception.Message"/> and
    /// <see cref="Exception.InnerException"/> values.</remarks>
    [Fact]
    public void Ctor_WithMessageAndInnerException_SetsProperties()
    {
        // Arrange
        const string message = "Foreign key violation occurred.";
        InvalidOperationException inner = new("Inner exception");

        // Act
        ForeignKeyViolationException ex = new(message, inner);

        // Assert
        Assert.Equal(message, ex.Message);
        Assert.Equal(inner, ex.InnerException);
    }
}