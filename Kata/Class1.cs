namespace Kata;

public class Class1
{
    public static int[] Do(int amount, int[] values)
    {
        var index = values.Length - 1;

        var result = values.Select(_ => 0).ToArray();
        while (amount > 0)
        {
            while (values[index] > amount)
            {
                index--;
            }

            while (amount >= values[index])
            {
                amount -= values[index];
                result[index]++;
            }
        }

        return result;
    }
}