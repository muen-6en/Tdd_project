using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tdd_project.ViewModel
{
    public class MainWindowVM
    {
        private string TextMessage = "Hello, World!";

        public string textMessage
        {
            get
            {
                return this.TextMessage;
            }
            set
            {
                this.TextMessage = value;
            }
        }

        public int AddFunc(int a, int b)
        {
            return a + b;
        }

        public int Multiplication(int v1, int v2)
        {
            return v1 * v2;
        }
    }
}
