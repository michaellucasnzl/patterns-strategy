namespace app;

public class LowercaseTextOutputStrategy : ITextOutputStrategy
{
    public void OutputText(string text)
    {
        Console.WriteLine(text.ToLowerInvariant());
    }
}