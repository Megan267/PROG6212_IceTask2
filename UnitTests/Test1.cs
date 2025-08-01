using PROG6212_IceTask2;

namespace UnitTests
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestName()
        {
            Event e = new Event("Michele and Darryl Wedding", "Michele and Darryl Wedding filled with music and laughter", "2025-01-01", "2025-01-01");
            Assert.AreEqual(e[0], "Michele and Darryl Wedding");
        }

        [TestMethod]
        public void updateDescription()
        {
            Event e = new Event("Michele and Darryl Wedding", "Michele and Darryl Wedding filled with music and laughter", "2025-01-01", "2025-01-01");
            e[1] = "Michele and Darryl Wedding filled with music, laughter and people"; //int index
            Assert.AreEqual(e[1], "Michele and Darryl Wedding filled with music, laughter and people");
        }

        [TestMethod]
        public void testStartDate()
        {
            Event e = new Event("Michele and Darryl Wedding", "Michele and Darryl Wedding filled with music and laughter", "2025-01-01", "2025-01-01");
            Assert.AreEqual(e["start"], "2025-01-01"); //string index
        }

        [TestMethod]
        public void updateEndDate()
        {
            Event e = new Event("Michele and Darryl Wedding", "Michele and Darryl Wedding filled with music and laughter", "2025-01-01", "2025-01-01");
            e["end"] = "2025-02-01"; // string index
            Assert.AreEqual(e["end"], "2025-02-01");
        }

        [TestMethod]
        public void TestUpdatedNameNotEqual()
        {
            Event e = new Event("Michele and Darryl Wedding", "Michele and Darryl Wedding filled with music and laughter", "2025-01-01", "2025-01-01");
            e["name"] = "Michele Wedding";
            Assert.AreNotEqual(e["name"], "Michele and Darryl Wedding");
        }
    }
}
