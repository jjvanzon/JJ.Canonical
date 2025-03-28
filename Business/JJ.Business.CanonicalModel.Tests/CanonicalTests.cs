// ReSharper disable UnusedVariable
// ReSharper disable UnusedAutoPropertyAccessor.Global
// ReSharper disable RedundantAssignment
// ReSharper disable ArrangeObjectCreationWhenTypeEvident
namespace JJ.Business.CanonicalModel.Tests;

[TestClass]
public sealed class CanonicalTests
{
    [TestMethod]
    public void Test_Canonical_IDAndName()
    {
        var model = new IDAndName<string>
        {
            ID   = 1, // Flaw: Type argument <string> is actually not used. ID is still integer here.
            Name = "My Name"
        };
    }

    [TestMethod]
    public void Test_Canonical_ValidationMessage()
    {
        // In hindsight, just a string would have sufficed; newer versions will simplify this.
        var model = new ValidationMessage
        {
            PropertyKey = "MyProp",
            Text        = "Hello"
        };
    }

    /// <summary>
    /// Demonstrates structure and flaws of the legacy Result class.
    /// </summary>
    [TestMethod]
    public void Test_Canonical_Result()
    {
        var result = new Result
        {
            Successful = true,
            // "Messages" for brevity and generalization would have been nice.
            // It's a List<T> not an IList<T> on purpose:
            // This makes it easier for serialization systems to
            // know what collection type to deserialize.
            ValidationMessages = new List<ValidationMessage>
            {
                // Again: Just strings would have sufficed.
                // Later versions do this.
                new ValidationMessage { PropertyKey = "MyProp",      Text = "Hello" },
                new ValidationMessage { PropertyKey = "AnotherProp", Text = "World" }
            }
        };
    }

    /// <summary>
    /// Demonstrates a Result&lt;T&gt; and the difference and relationship to a non-generic Result.
    /// </summary>
    [TestMethod]
    public void Test_Canonical_ResultOfT()
    {
        // Has a type argument (int here) that determines
        // the type of Result.Data (int in this case).
        var result = new Result<int>
        {
            Data = 10,
            Successful = true,
            ValidationMessages = new List<ValidationMessage>
            {
                new ValidationMessage { PropertyKey = "MyProp",      Text = "Hello" },
                new ValidationMessage { PropertyKey = "AnotherProp", Text = "World" }
            }
        };

        var result2 = new Result<Item>
        {
            Data               = new Item { MyProp1 = "Hi", MyProp2 = 5 },
            Successful         = true,
            ValidationMessages = new()
            
        };
        
        // Polymorphism: both Result<int> and Result<Item> are a Result.
        Result result3 = result;
        result3 = result2;
    }
}