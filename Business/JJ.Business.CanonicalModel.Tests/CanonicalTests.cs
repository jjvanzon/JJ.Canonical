// ReSharper disable UnusedVariable
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
        // In hindsight, just a string would have sufficed — newer versions will simplify this.
        var model = new ValidationMessage
        {
            PropertyKey = "MyProp",
            Text = "Hello"
        };
    }
}