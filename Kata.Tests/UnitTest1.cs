namespace Kata.Tests;

public class Tests
{
    [Test]
    public void Test1()
    {
        var amount = ChangeCalculator.GiveMeMoney(15, [1, 2, 5, 10, 20, 50]);
        
        Assert.That(amount, Is.EqualTo(new [] { 0, 0, 1, 1, 0, 0 }));
    }
    [Test]
    public void Test2()
    {
        var amount = ChangeCalculator.GiveMeMoney(45, [1, 2, 5, 10, 20, 50]);
        
        Assert.That(amount, Is.EqualTo(new [] { 0, 0, 1, 0, 2, 0 }));
    }

    [Test]
    public void Test3()
    {
        var amount = ChangeCalculator.GiveMeMoney(314159265, [1, 2, 5, 10, 20, 50]);
        
        var expected = new[] { 0, 0, 1, 0, 1, 0, 0 };
    }
}