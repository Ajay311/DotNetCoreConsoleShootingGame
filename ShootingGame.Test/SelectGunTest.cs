using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;

namespace ShootingGame.Test
{
    [TestClass]
    public class SelectGunTest
    {
        [TestMethod]
        public void SelectGun_Pistol()
        {
            string userInput = "1";
            using (StringReader sr = new StringReader(userInput))
            {
                Console.SetIn(sr);
                Gun currgun = Program.SelectGun();
                Console.Write(currgun.Name);
                Assert.AreEqual<string>(Constant.Pistol, currgun.Name);
            }
        }

        [TestMethod]
        public void SelectGun_Rifle()
        {
            string userInput = "2";
            using (StringReader sr = new StringReader(userInput))
            {
                Console.SetIn(sr);
                Gun currgun = Program.SelectGun();
                Assert.AreEqual<string>(Constant.Rifle, currgun.Name);
            }
        }

        [TestMethod]
        public void SelectGun_Invalid_Number()
        {
            string userInput = "4";
            using (StringReader sr = new StringReader(userInput))
            {
                Console.SetIn(sr);
                Gun currgun = Program.SelectGun();
                Assert.IsNull(currgun);
            }
        }

        [TestMethod]
        public void SelectGun_Invalid_Char()
        {
            string userInput = "abc";
            using (StringReader sr = new StringReader(userInput))
            {
                Console.SetIn(sr);
                Gun currgun = Program.SelectGun();
                Assert.IsNull(currgun);
            }
        }
    }
}
