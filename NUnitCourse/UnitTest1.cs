namespace NUnitCourse;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Test1()
    {
        Assert.Pass();
    }

    [Test]
    public void MyFirstTest()
    {
        Console.WriteLine("First test");

        string name = "Diego";

        Assert.AreEqual("Diego", name);
    }
}
