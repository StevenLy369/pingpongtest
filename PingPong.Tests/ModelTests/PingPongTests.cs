using Microsoft.VisualStudio.TestTools.UnitTesting;
using PingPong;

namespace PingPong.Tests
{
  [TestClass]
  public class PingPongTests
  {
    [TestMethod]
    public void isPingPong_NumDivBy5_Pong()
    {
        Program testPingPong = new Program();
        Assert.AreEqual("Pong", testPingPong.wow());
    }
  }
}