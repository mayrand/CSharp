namespace TryCatchFinally;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        var stringWriter = new StringWriter();
        Console.SetOut(stringWriter);

        Console.Write(FooBar());
        var actual = stringWriter.ToString().Trim();
        Assert.Equal("try-finally-foo",actual);
    }
    
    private static string FooBar(){
        var outputString = "";
        try
        {
            Console.Write("try");
            outputString = "-foo";
            return outputString;
        }
        finally
        {
            outputString = "-bar";
            Console.Write("-finally");
        }
        return outputString;
    }
}


