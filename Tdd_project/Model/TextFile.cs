using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace Tdd_project.Model
{
    public class TextFile
    {
        private ITextFile _textFile;
 
        public TextFile(ITextFile textFile)
        {
            _textFile = textFile;
        }
 
        public bool NewLineExists()
        {
            var fileString =  _textFile.GetData();
            return fileString.Contains(System.Environment.NewLine);
        }
    }
}
