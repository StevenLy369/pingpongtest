using Microsoft.VisualStudio.TestTools.UnitTesting;
using PingPong;

namespace PingPong.Tests
{
  [TestClass]
  public class PingPongTests
  {
    [TestMethod]
    public void isPing_NumDivBy5_Pong()
    {
        Pong testPingPong = new Pong();
        Assert.AreEqual("Ping", testPingPong.GetPong(3));
    }

    [TestMethod]
    public void isPong_NumDivBy5_Pong()
    {
        Pong testPingPong = new Pong();
        Assert.AreEqual("Pong", testPingPong.GetPong(5));
    }

    [TestMethod]
    public void isPingPong_NumDivBy15_Pong()
    {
        Pong testPingPong = new Pong();
        Assert.AreEqual("Ping Pong", testPingPong.GetPong(15));
    }
  }
}