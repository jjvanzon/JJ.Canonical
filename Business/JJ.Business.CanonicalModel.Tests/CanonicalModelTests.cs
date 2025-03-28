// ReSharper disable UnusedVariable
namespace JJ.Business.CanonicalModel.Tests;

[TestClass]
public sealed class CanonicalModelTests
{
    [TestMethod]
    public void Test_CanonicalModel_IDAndName()
    {
        var idAndName = new IDAndName<string>
        {
            ID   = 1, // Flaw: Type argument <string> is unused used. ID is still integer here.
            Name = "My Name"
        };
    }
}