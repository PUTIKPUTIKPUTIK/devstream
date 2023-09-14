namespace Task4ProblemSolving.Services;

public static class MissingService
{
    public static int[] GetMissingElements(int[] source)
    {
        var result = new List<int>();
        int check;

        for (int i = 1; i < source.Length; i++)
        {
            check = source[i - 1];
            while (source[i] != check + 1)
            {
                result.Add(++check);
            }
        }
        
        return result.ToArray();
    }
}