using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using WindowsFormsApplication.Elements;
using WindowsFormsApplication.Elements.MenuElements;

namespace WindowsFormsApplication
{
    public partial class FormMain : Form
    {
        private readonly List<IMenuElement> menuElements;

        public FormMain()
        {
            InitializeComponent();

            ImageController.Init();

            var parent = panelElements;
            var width = parent.Width;
            var height = 150;

            menuElements = (new IMenuElement[] {
                new MenuComputerElement("Компьютер", width, height, ImageController.Open("computer.svg") as Image, ButtonPK_MouseDown),
                new MenuRouterElement("Роутер", width, height, ImageController.Open("router.svg") as Image, ButtonPK_MouseDown),
            }).ToList();

            DragAndDropController.FormMain = this;
        }

        internal void CreateSettingsWindow(IElement element)
        {
            new FormSettings(element).ShowDialog();
        }

        private void QuerryContinueDrag(object sender, QueryContinueDragEventArgs e)
        {
            if(e.Action == DragAction.Cancel)
            {
                QueryContinueDrag -= QuerryContinueDrag;
                StopDragAndDrop();
            }
        }

        internal Control GetPanel()
        {
            return panelScrollMain;
        }

        private void StopDragAndDrop()
        {
            DragAndDropController.ResetPanel();
        }

        private void Element_MouseDown(object sender, MouseEventArgs args)
        {
            if(args.Button == MouseButtons.Right)
            {
                (sender as IElement).OpenSettings();
            }
            else if(args.Button == MouseButtons.Left && Form.ModifierKeys == Keys.Control)
            {
                (sender as IElement).TogglePins();
            }
            else
            {
                DragAndDropController.MouseDown(sender);
            }
        }

        private void ButtonPK_MouseDown(object sender, MouseEventArgs e)
        {
            DragAndDropController.MouseDown(sender);
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            menuElements.ForEach(x => panelElements.Controls.Add(x as Control));
        }

        private void panelConnection_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetData(typeof(MenuComputerElement)) is MenuComputerElement)
            {
                var point = DragAndDropController.ConvertPoint(e.X, e.Y);
                panelConnection.Controls.Add(new Computer(50, 50, ImageController.Open("computer.svg") as Image, Element_MouseDown, point.X - 25, point.Y - 25, 1));
            }
            else if (e.Data.GetData(typeof(MenuRouterElement)) is MenuRouterElement)
            {
                var point = DragAndDropController.ConvertPoint(e.X, e.Y);
                panelConnection.Controls.Add(new Router(50, 50, ImageController.Open("router.svg") as Image, Element_MouseDown, point.X - 25, point.Y - 25, 8));
            }
            else if (e.Data.GetData(typeof(Computer)) is Computer)
            {
                var point = DragAndDropController.ConvertPoint(e.X - DragAndDropController.DraggedObject.Width / 2, e.Y - DragAndDropController.DraggedObject.Height / 2);

                DragAndDropController.DraggedObject.Location = point;
            }

            StopDragAndDrop();
        }

        private void panelConnection_DragEnter(object sender, DragEventArgs e)
        {
            var elem = e.Data.GetData(typeof(MenuComputerElement)) as MenuComputerElement;
            if (elem != null)
            {
                e.Effect = DragDropEffects.Copy;
            }

            var elem1 = e.Data.GetData(typeof(MenuRouterElement)) as MenuRouterElement;
            if (elem1 != null)
            {
                e.Effect = DragDropEffects.Copy;
            }

            var element = e.Data.GetData(typeof(Computer)) as Computer;
            if (element != null)
            {
                e.Effect = DragDropEffects.Move;
            }
        }
    }
}
