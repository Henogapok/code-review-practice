namespace CodeReviewApp;

public class Greeter
{
    public static string GetGreeting(string name)
    {
        if (string.IsNullOrEmpty(name))
            return "Hello, stranger!";
            
        return $"Hello, {name}!";
    }
}