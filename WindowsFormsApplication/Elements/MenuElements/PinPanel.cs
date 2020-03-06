using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication.Elements.MenuElements
{
    public partial class PinPanel : UserControl
    {
        public PinPanel()
        {
            InitializeComponent();

            BackColor = Color.Red;
        }

        internal void AddPin(string name)
        {
            Controls.Add(new PinControl(name));
        }
    }
}
