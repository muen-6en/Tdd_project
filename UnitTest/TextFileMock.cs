using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tdd_project.Model;

namespace UnitTest
{
    internal class TextFileMock : ITextFile
    {
        public string GetData()
        {
            return "AAA" + System.Environment.NewLine;
        }
    }
}
