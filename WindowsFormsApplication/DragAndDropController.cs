using System;
using System.Drawing;
using System.Windows.Forms;
using WindowsFormsApplication.Elements;
using WindowsFormsApplication.Elements.MenuElements;

namespace WindowsFormsApplication
{
    static class DragAndDropController
    {
        public static Control DraggedObject { get; private set; }
        public static FormMain FormMain { get; set; }

        public static void MouseDown(object elem)
        {
            var sender = elem as Control;
            DraggedObject = sender;

            if (elem is IMenuElement)
            {
                if (elem is MenuComputerElement)
                {
                    FormMain.DoDragDrop(elem as MenuComputerElement, DragDropEffects.Copy);
                }
                else if (elem is MenuRouterElement)
                {
                    FormMain.DoDragDrop(elem as MenuRouterElement, DragDropEffects.Copy);
                }
            }
            else if(elem is IElement)
            {
                if (elem is Computer)
                {
                    FormMain.DoDragDrop(elem as Computer, DragDropEffects.Move);
                }
            }
        }

        internal static void ResetPanel()
        {
            DraggedObject = null;
        }

        public static Point ConvertPoint(int x, int y)
        {
            return FormMain.GetPanel().PointToClient(new Point(x, y));
        }
    }
}
