namespace Iron.CodeChallenge.Test;

[TestClass]
public class ChallengeTests
{
    [TestMethod]
    public void TestMethod_CAB()
    {
        var input = "222 2 22#";
        var expected = "CAB";

        var actual = OldPhonePad.Convert(input);

        Assert.IsTrue(
            actual.Equals(expected),
            $"Expected for '{input}' is: '{expected}'; Actual: {actual}");
    }

    [TestMethod]
    public void TestMethod_E()
    {
        var input = "33#";
        var expected = "E";

        var actual = OldPhonePad.Convert(input);

        Assert.IsTrue(
            actual.Equals(expected),
            $"Expected for '{input}' is: '{expected}'; Actual: {actual}");
    }

    [TestMethod]
    public void TestMethod_B()
    {
        var input = "227*#";
        var expected = "B";

        var actual = OldPhonePad.Convert(input);

        Assert.IsTrue(
            actual.Equals(expected),
            $"Expected for '{input}' is: '{expected}'; Actual: {actual}");
    }

    [TestMethod]
    public void TestMethod_HELLO()
    {
        var input = "4433555 555666#";
        var expected = "HELLO";

        var actual = OldPhonePad.Convert(input);

        Assert.IsTrue(
            actual.Equals(expected),
            $"Expected for '{input}' is: '{expected}'; Actual: {actual}");
    }

    [TestMethod]
    public void TestMethod_TURING()
    {
        var input = "8 88777444666*664#";
        var expected = "TURING";

        var actual = OldPhonePad.Convert(input);

        Assert.IsTrue(
            actual.Equals(expected),
            $"Expected for '{input}' is: '{expected}'; Actual: {actual}");
    }
}