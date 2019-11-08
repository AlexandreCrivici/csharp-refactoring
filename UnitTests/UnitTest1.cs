using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using System.Text;

namespace UnitTests
{
    [TestClass]
    public class ProgramTests
    {
        [TestMethod]
        public void Program_MainMethod_RunSuccessFull()
        {
            StringBuilder fakeoutput = new StringBuilder();
            Console.SetOut(new StringWriter(fakeoutput));
            Console.SetIn(new StringReader("a\n"));

            var program = new Program()
            Program.Main(new string[] { });
            var output = fakeoutput.ToString();


        }

        [TestMethod]
        public void Program_MainMethod_RunUnSuccessFull()
        {
        }
    }
}
