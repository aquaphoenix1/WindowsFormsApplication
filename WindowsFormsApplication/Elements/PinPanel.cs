using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication.Elements
{
    class PinPanel : FlowLayoutPanel
    {
        public PinPanel(int count)
        {
                Controls.Add((Control)pin);
        }
    }
}
