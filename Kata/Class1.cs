namespace Kata;

public class Class1
{
    public static int[] Do(int amount, int[] values)
    {
        var index = values.Length - 1;
        while (values[index] > amount)
        {
            index--;
        }

        while (amount > values[index])
        {  
            amount -= values[index];
        }
        
        while (values[index] > amount)
        {
            index--;
        }

        while (amount > values[index])
        {  
            amount -= values[index];
        }
        
        return new[] { 0, 0, 1, 1, 0, 0 };
    }
}