using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tdd_project.ViewModel;

namespace UnitTest
{
    /// <summary>
    /// 単純な単体テスト
    /// </summary>
    [TestClass]
    public class SimpleUnitTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            var vm = new MainWindowVM();
            int result = vm.AddFunc(4, 5);
            Assert.AreEqual(9, result);
        }

        [TestMethod]
        public void 掛け算()
        {
            var vm = new MainWindowVM();
            Assert.AreEqual(10, vm.Multiplication(2, 5));
        }
    }
}
