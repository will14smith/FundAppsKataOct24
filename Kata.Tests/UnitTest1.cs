namespace Kata.Tests;

public class Tests
{
    [Test]
    public void Test1()
    {
        var amount = Class1.Do(15, [1, 2, 5, 10, 20, 50]);
        
        Assert.That(amount, Is.EqualTo(new [] { 0, 0, 1, 1, 0, 0 }));
    }
}