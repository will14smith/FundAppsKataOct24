namespace Kata;

public class ChangeCalculator
{
    public static int[] GiveMeMoney(int amount, int[] values)
    {
        var result = new int[values.Length];
        for (var index = values.Length - 1; index >= 0; index--)
        {
            result[index] = amount / values[index];
            amount %= values[index];
        }
        return result;
    }
}