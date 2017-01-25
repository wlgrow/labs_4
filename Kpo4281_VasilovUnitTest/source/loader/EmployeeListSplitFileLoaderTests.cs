using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kpo4281.Vasilov.Lib;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace Kpo4281.Vasilov.Lib.Tests
{
    [TestClass()]
    public class EmployeeListSplitFileLoaderTests
    {
        [TestMethod()]
        public void ExecuteTest()
        {
            var t = new EmployeeListSplitFileLoader("");
            Assert.IsFalse(t.Separator("Иванов|И.И.|1950;2000"));
        }
    }
}
