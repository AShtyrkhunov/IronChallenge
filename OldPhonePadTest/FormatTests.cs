namespace Iron.CodeChallenge.Test;

[TestClass]
public class FormatTests
{
    [TestMethod]
    public void TestMethod_Null()
    {
        string input = null;

        Assert.ThrowsException<ArgumentNullException>(
              () => OldPhonePad.Convert(input));
    }

    [TestMethod]
    public void TestMethod_Empty()
    {
        string input = string.Empty;

        Assert.ThrowsException<ArgumentException>(
             () => OldPhonePad.Convert(input));
    }

    [TestMethod]
    public void TestMethod_DoubleSharp()
    {
        string input = "1#1#";

        Assert.ThrowsException<ArgumentException>(
             () => OldPhonePad.Convert(input));
    }

    [TestMethod]
    public void TestMethod_DoubleSharp2()
    {
        string input = "1##";

        Assert.ThrowsException<ArgumentException>(
             () => OldPhonePad.Convert(input));
    }

    [TestMethod]
    public void TestMethod_0char()
    {
        string input = "0#";

        Assert.ThrowsException<ArgumentException>(
             () => OldPhonePad.Convert(input));
    }

    [TestMethod]
    public void TestMethod_Achar()
    {
        string input = "A#";

        Assert.ThrowsException<ArgumentException>(
             () => OldPhonePad.Convert(input));
    }

    [TestMethod]
    public void TestMethod_ANYchar()
    {
        string input = "#";
        char[] allowed = {'1', '2', '3', '4', '5', '6', '7', '8', '9', ' ', '*'};

        for (char c = (char)0; c <= (char)128; c++)
        {
            if (char.IsControl(c) || allowed.Contains(c)) continue;
            Assert.ThrowsException<ArgumentException>(
                () => OldPhonePad.Convert(c+input), 
                $"char:{(int)c} input:'{c+input}'");
        }
    }
}