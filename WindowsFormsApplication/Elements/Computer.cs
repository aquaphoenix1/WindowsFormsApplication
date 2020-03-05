using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication.Elements
{
    class Computer : BaseElement, IElement
    {
        public Computer(string name, int width, int height, Image picture, Action<object, MouseEventArgs> onMouseDown) : base(name, width, height, picture, onMouseDown)
        {
        }

        public Computer(int width, int height, Image picture, Action<object, MouseEventArgs> onMouseDown, int x, int y) : base("", width, height, picture, onMouseDown)
        {
            Location = new Point(x, y);
        }
    }
}
