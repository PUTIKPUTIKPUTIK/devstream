namespace Task4ProblemSolving.Services;

public static class ReverseService
{
    public static string Reverse(string source)
    {
        var result = "";  
        var length = source.Length - 1;  
  
        while (length >= 0)  
        {  
            result = result + source[length];  
            length--;  
        }

        return result;
    }
}