
namespace Greeting.Test
{
    [TestClass]
    public class GreetUnitTest
    {
        [TestMethod]
        public void TestGetText()
        {
            Greet greet = new Greet();
            Assert.AreEqual("Hello World From Lib!", greet.GetText());
        }
    }
}