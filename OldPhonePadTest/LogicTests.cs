namespace Iron.CodeChallenge.Test;

[TestClass]
public class LogicTests
{
    [TestMethod]
    public void TestMethod_CycleEntry()
    {
        var input = "33333#";
        var expected = "E";

        var actual = OldPhonePad.Convert(input);

        Assert.IsTrue(
            actual.Equals(expected),
            $"Expected for '{input}' is: '{expected}'; Actual: {actual}");
    }

    [TestMethod]
    public void TestMethod_Backspace()
    {
        var input = "3322*#";
        var expected = "E";

        var actual = OldPhonePad.Convert(input);

        Assert.IsTrue(
            actual.Equals(expected),
            $"Expected for '{input}' is: '{expected}'; Actual: {actual}");
    }

    [TestMethod]
    public void TestMethod_DoubleBackspace()
    {
        var input = "332233**#";
        var expected = "E";

        var actual = OldPhonePad.Convert(input);

        Assert.IsTrue(
            actual.Equals(expected),
            $"Expected for '{input}' is: '{expected}'; Actual: {actual}");
    }

    [TestMethod]
    public void TestMethod_OverBackspace()
    {
        var input = "332233*************#";
        var expected = "";

        var actual = OldPhonePad.Convert(input);

        Assert.IsTrue(
            actual.Equals(expected),
            $"Expected for '{input}' is: '{expected}'; Actual: {actual}");
    }

    [TestMethod]
    public void TestMethod_Space()
    {
        var input = "33 33#";
        var expected = "EE";

        var actual = OldPhonePad.Convert(input);

        Assert.IsTrue(
            actual.Equals(expected),
            $"Expected for '{input}' is: '{expected}'; Actual: {actual}");
    }
    [TestMethod]
    public void TestMethod_DoubleSpace()
    {
        var input = "33  33#";
        var expected = "EE";

        var actual = OldPhonePad.Convert(input);

        Assert.IsTrue(
            actual.Equals(expected),
            $"Expected for '{input}' is: '{expected}'; Actual: {actual}");
    }
}