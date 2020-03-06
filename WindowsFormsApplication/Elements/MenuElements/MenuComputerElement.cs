using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApplication.Elements.MenuElements
{
    class MenuComputerElement : BaseMenuElement
    {
        public MenuComputerElement(string name, int width, int height, Image picture, Action<object, MouseEventArgs> onMouseDown) : base(name, width, height, picture, onMouseDown)
        {
        }
    }
}
