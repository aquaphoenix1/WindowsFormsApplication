using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApplication.Elements.MenuElements
{
    [Serializable]
    class MenuComputerElement : BaseMenuElement
    {
        public MenuComputerElement(MenuComputerElement elem) : base(elem.NameLabel.Text, elem.Width, elem.Height, elem.ElementPictureBox.Image, elem.OnMouseDownAction)
        {
        }

        public MenuComputerElement(string name, int width, int height, Image picture, Action<object, MouseEventArgs> onMouseDown) : base(name, width, height, picture, onMouseDown)
        {
        }
    }
}
