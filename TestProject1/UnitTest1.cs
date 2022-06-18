using Microsoft.VisualStudio.TestTools.UnitTesting;
using OOP;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Person person = new Person("Tom Jankinse", 20,
                56.9, Pol.Мужской);
            person.Go(22);
            Assert.AreEqual(person.Age, 23);
        }
    }
}