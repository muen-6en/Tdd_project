using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculation.ViewModel
{
    public class MainWindowVM
    {
        private string calPanel = string.Empty;

        /// <summary>
        /// 電卓パネル
        /// </summary>
        public string CalPanel 
        { 
            get 
            { 
                return this.calPanel; 
            } 
            set 
            { 
                this.calPanel = value; 
            } 
        }
    }
}
