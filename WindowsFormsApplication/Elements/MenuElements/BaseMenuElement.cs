using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApplication.Elements.MenuElements
{
    abstract class BaseMenuElement : BaseElement, IMenuElement
    {
        protected BaseMenuElement(string name, int width, int height, Image picture, Action<object, MouseEventArgs> onMouseDown) : base(name, width, height, picture, onMouseDown, 0)
        {
        }
    }
}
