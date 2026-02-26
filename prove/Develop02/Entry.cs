public class Entry
{
    public string _date;
    public string _prompt;
    public string _response;

    public void Display()
    {
        System.Console.WriteLine($"Date: {_date} - Prompt: {_prompt}");
        System.Console.WriteLine(_response);
        System.Console.WriteLine();
    }
}
