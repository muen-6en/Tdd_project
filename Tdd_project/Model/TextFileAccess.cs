using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Tdd_project.Model
{
    public class TextFileAccess: ITextFile
    {
        public string GetData()
        {
            return File.ReadAllText(@"C:\work\Test.txt");
        }
    }
}
