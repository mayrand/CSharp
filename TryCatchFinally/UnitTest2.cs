namespace TryCatchFinally;

public class UnitTest2
{
    static string x;
    [Fact]
    public void Test1()
    {
        Assert.Null(x);
        Assert.Equal("try",Method());
        Assert.Equal("finally",x);
    }
    
    static string Method()
    {
        try
        {
            x = "try";
            return x;
        }
        finally
        {
            x = "finally";
        }
    }
}


