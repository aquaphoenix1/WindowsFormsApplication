using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApplication.Elements
{
    abstract class BaseElement : Control
    {
        private FlowLayoutPanel parentPanel;
        public Label NameLabel { get; private set; }
        public PictureBox ElementPictureBox { get; private set; }
        public Action<object, MouseEventArgs> OnMouseDownAction { get; private set; }

        protected BaseElement(string name, int width, int height, Image picture, Action<object, MouseEventArgs> onMouseDown)
        {
            Width = width;
            Height = height;

            parentPanel = new FlowLayoutPanel
            {
                BackColor = Color.Red,
                Width = this.Width,
                Height = this.Height,
                BorderStyle = BorderStyle.FixedSingle,
                Parent = this,
            };

            Controls.Add(parentPanel);

            NameLabel = new Label
            {
                Text = name,
                Width = parentPanel.Width,
                Height = 20
            };
            NameLabel.Location = new Point(0, parentPanel.Height - NameLabel.Height);

            NameLabel.MouseDown += ElementMouseDown;

            ElementPictureBox = new PictureBox()
            {
                Width = this.Width,
                Height = this.Height - NameLabel.Height,
                Image = picture
            };

            ElementPictureBox.MouseDown += ElementMouseDown;

            parentPanel.Controls.Add(ElementPictureBox);
            parentPanel.Controls.Add(NameLabel);

            this.OnMouseDownAction = onMouseDown;

            MouseDown += (o, mea) => OnMouseDownAction.Invoke(o, mea);
        }

        private void ElementMouseDown(object sender, MouseEventArgs args)
        {
            OnMouseDownAction(this, args);
        }
    }
}
