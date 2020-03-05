using System;
using System.Drawing;
using System.Windows.Forms;
using WindowsFormsApplication.Elements.MenuElements;

namespace WindowsFormsApplication
{
    static class DragAndDropController
    {
        public static Control DraggedObject { get; private set; }
        private static Bitmap state;
        public static PictureBox StatePictureBox { get; private set; }
        public static FormMain FormMain { private get; set; }

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
            }
        }

        internal static void SaveCurrentState(Panel panelConnection, PictureBox currentPicture)
        {
            Bitmap bm = new Bitmap(panelConnection.Width, panelConnection.Height);
            panelConnection.DrawToBitmap(bm, new Rectangle(0, 0, panelConnection.Width, panelConnection.Height));

            state = bm;

            StatePictureBox = currentPicture;
        }

        internal static void ResetPanel()
        {
            StatePictureBox = null;
            state = null;
            DraggedObject = null;
        }

        public static Point ConvertPoint(int x, int y)
        {
            return StatePictureBox.PointToClient(new Point(x, y));
        }

        internal static void Repaint(int x, int y)
        {
            StatePictureBox.Image = state;

            StatePictureBox.CreateGraphics().DrawImage((DraggedObject as MenuComputerElement).ElementPictureBox.Image, ConvertPoint(x - DraggedObject.Width / 2, y - DraggedObject.Height / 2));
        }
    }
}
