using app;

Console.WriteLine("Running Strategy Pattern Demo");

var inputText = "This is my test input text.";
var textOutputter = new TextOutputter(new LowercaseTextOutputStrategy());
textOutputter.Process(inputText);

textOutputter = new TextOutputter(new UppercaseTextOutputStrategy());
textOutputter.Process(inputText);

textOutputter = new TextOutputter(new NumericalTextOutputStrategy());
textOutputter.Process(inputText);
