namespace app;

public class TextOutputter
{
    private readonly ITextOutputStrategy _strategy;

    public TextOutputter(ITextOutputStrategy strategy)
    {
        Console.WriteLine($"Using strategy: {strategy.GetType().Name}");
        _strategy = strategy;
    }

    public void Process(string text)
    {
        _strategy.OutputText(text);
    }
}