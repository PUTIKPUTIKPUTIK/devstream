namespace Task4ProblemSolving.Services;

public static class PalindromeService
{
    public static void CheckNumber()
    {
        Console.Write("Enter the number to check: ");
        var input = int.Parse(Console.ReadLine());
        var source = input;
        var remainder = 0;
        var result = 0;
        
        while (input > 0)
        {
            remainder = input % 10;
            result = (result * 10) + remainder;
            input = input / 10;
        }

        if (source == result)
            Console.Write("Number is Palindrome.");
        else
            Console.Write("Number is not Palindrome");
    }
}