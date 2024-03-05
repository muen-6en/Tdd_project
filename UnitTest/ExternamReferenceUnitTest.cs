using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tdd_project.Model;

namespace UnitTest
{
    /// <summary>
    /// 外部参照系の単体テスト
    /// </summary>
    [TestClass]
    public class ExternamReferenceUnitTest
    {
        [TestMethod]
        public void 改行チェックtrue()
        {
            var textFile = new TextFile(new TextFileMock());
            Assert.AreEqual(true, textFile.NewLineExists());
        }

        [TestMethod]
        public void 改行チェックFalse()
        {
            var textFile = new TextFile(new TextFileMock());
            Assert.AreEqual(false, textFile.NewLineExists());
        }
    }
}
