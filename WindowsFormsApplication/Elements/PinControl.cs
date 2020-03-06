using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication.Elements
{
    public partial class PinControl : UserControl
    {
        public PinControl(string name)
        {
            InitializeComponent();

            labelName.Text = name;
        }

        private void checkBoxConnected_MouseDown(object sender, MouseEventArgs e)
        {
            DoDragDrop(sender, DragDropEffects.Copy);
        }

        private void checkBoxConnected_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetData(typeof(PinControl)) is PinControl)
            {
                var point = DragAndDropController.ConvertPoint(e.X, e.Y);
            }
        }
    }
}
