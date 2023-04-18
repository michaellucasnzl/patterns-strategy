namespace app;

public class NumericalTextOutputStrategy : ITextOutputStrategy
{
    public void OutputText(string text)
    {
        var sb = new StringBuilder();
        foreach (var c in text)
        {
            sb.Append(Convert.ToInt32(c)).Append('-');
        }
        Console.WriteLine(sb.ToString());
    }
}