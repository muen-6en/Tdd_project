using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Calculation.ViewModel;

namespace Calculation_UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void パネル表示()
        {
            var vm = new MainWindowVM();
            string str = "test";
            vm.CalPanel = str;
            Assert.AreEqual("test", vm.CalPanel);
        }
    }
}
