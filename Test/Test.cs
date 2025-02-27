using Main;

namespace Test;

public class Tests
{
    [Test]
    public void TestRandom()
    {
        Assert.That(Program.Random(), Is.EqualTo(4));
    }
}
