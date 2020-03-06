using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;

namespace WindowsFormsApplication.Elements
{
    public class Pin
    {
        private string name;
        private Pin connectedPin;

        public Pin(int number)
        {
            name = string.Format("Pin {0}", number);
        }
    }
}
