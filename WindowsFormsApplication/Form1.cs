using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using WindowsFormsApplication.Elements;
using WindowsFormsApplication.Elements.MenuElements;
using Svg;

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

            menuElements = (new IMenuElement[] { new MenuComputerElement("Компьютер", width, height, ImageController.Open("computer.svg") as Image, ButtonPK_MouseDown) }).ToList();

            DragAndDropController.FormMain = this;
        }

        private void PanelConnection_DragEnter(object sender, DragEventArgs e)
        {
            var elem = e.Data.GetData(typeof(MenuComputerElement)) as MenuComputerElement;
            if (elem != null)
            {
                e.Effect = DragDropEffects.Move;

                PictureBox currentPicture = new PictureBox()
                {
                    Width = panelConnection.Width,
                    Height = panelConnection.Height,
                    Location = panelConnection.Location
                };

                currentPicture.AllowDrop = true;
                currentPicture.DragDrop += CurrentPB_DragDrop;
                currentPicture.DragOver += CurrentPB_DragOver;
                currentPicture.DragLeave += CurrentPB_DragLeave;
                currentPicture.QueryContinueDrag += CurrentPB_QuerryContinueDrag;

                DragAndDropController.SaveCurrentState(panelConnection, currentPicture);

                Controls.Add(currentPicture);

                panelConnection.Visible = false;
                panelConnection.Enabled = false;
            }
        }

        private void CurrentPB_QuerryContinueDrag(object sender, QueryContinueDragEventArgs e)
        {
            if(e.Action == DragAction.Cancel)
            {
                var a = 0;
            }
        }

        private void CurrentPB_DragLeave(object sender, EventArgs e)
        {
        }

        private void CurrentPB_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
            
            DragAndDropController.Repaint(e.X, e.Y);
        }

        private void CurrentPB_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetData(typeof(MenuComputerElement)) is MenuComputerElement elem)
            {
                var point = DragAndDropController.ConvertPoint(e.X, e.Y);
                panelConnection.Controls.Add(new Computer(50, 50, ImageController.Open("computer.svg") as Image, Element_MouseDown, point.X - 25, point.Y - 25));
            }

            Controls.Remove(DragAndDropController.StatePictureBox);

            panelConnection.Visible = true;
            panelConnection.Enabled = true;

            DragAndDropController.ResetPanel();
        }

        private void Element_MouseDown(object sender, MouseEventArgs args)
        {
            var a = 0;
        }

        private void ButtonPK_MouseDown(object sender, MouseEventArgs e)
        {
            DragAndDropController.MouseDown(sender);
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            menuElements.ForEach(x => panelElements.Controls.Add(x as Control));
        }
    }
}
