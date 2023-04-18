namespace app;

public class UppercaseTextOutputStrategy : ITextOutputStrategy
{
    public void OutputText(string text)
    {
        Console.WriteLine(text.ToUpperInvariant());
    }
}