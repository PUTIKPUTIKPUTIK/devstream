using Task4ProblemSolving.Services;

namespace Task4ProblemSolving
{
    class Program
    {
        static void Main(string[] args)
        {
            var testString = "123456";
            
            //Reverse:
            Console.WriteLine(ReverseService.Reverse(testString));
            
            //Palindrome:
            PalindromeService.CheckNumber();
            
            //Missing numbers:
            var sourceWithoutMissingElements = new int[] { 3, 4, 5, 6, 7 };
            Console.WriteLine("Array without missing elements: ");
            WriteArray(sourceWithoutMissingElements);
            
            var emptyResult = MissingService.GetMissingElements(sourceWithoutMissingElements);
            Console.WriteLine("Result: ");
            WriteArray(emptyResult);

            var sourceWithMissingElements = new int[] { 1, 3, 4, 5, 9 };
            Console.WriteLine("Array with missing elements: ");
            WriteArray(sourceWithMissingElements);

            var result = MissingService.GetMissingElements(sourceWithMissingElements);
            Console.WriteLine("Result: ");
            WriteArray(result);
        }

        private static void WriteArray(int[] source)
        {
            Console.Write("[ ");
            foreach (var number in source)
            {
                Console.Write($"{number} ");
            }
            Console.WriteLine("]");
        }
    }
}