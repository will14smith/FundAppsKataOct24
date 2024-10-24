namespace Kata;

public class ChangeCalculator
{
    public static int[] GiveMeMoney(int amount, int[] values)
    {
        var indexOrder = values.Select((x, i) => (x, i)).OrderByDescending(x => x.x).Select(x => x.i);
        
        var result = new int[values.Length];
        foreach(var index in indexOrder)
        {
            result[index] = amount / values[index];
            amount %= values[index];
        }
        return result;
    }
}