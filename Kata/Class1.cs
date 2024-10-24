namespace Kata;

public class Class1
{
    public static int[] Do(int amount, int[] values)
    {
        var result = new int[values.Length];
        for (var index = values.Length - 1; index >= 0; index--)
        {
            while (amount >= values[index])
            {
                amount -= values[index];
                result[index]++;
            }
        }
        
        return result;
    }
}