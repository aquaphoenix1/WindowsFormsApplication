using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using WindowsFormsApplication.Elements.MenuElements;

namespace WindowsFormsApplication.Elements
{
    abstract class BaseElement : Control
    {
        private FlowLayoutPanel parentPanel;
        public Label NameLabel { get; private set; }
        public PictureBox ElementPictureBox { get; private set; }
        public Action<object, MouseEventArgs> OnMouseDownAction { get; private set; }
        private PinPanel pinPanel;

        internal bool IsVisiblePinsPanel()
        {
            return pinPanel.Visible;
        }

        public void TogglePins()
        {
            if (IsVisiblePinsPanel())
            {
                HidePins();
            }
            else
            {
                ShowPins();
            }
        }

        internal void ShowPins()
        {
            Height += pinPanel.Height;
            pinPanel.Enabled = true;
            pinPanel.Visible = true;
        }

        internal void HidePins()
        {
            Height -= pinPanel.Height;
            pinPanel.Enabled = false;
            pinPanel.Visible = false;
        }

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
                Parent = this
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
                Image = picture,
                SizeMode = PictureBoxSizeMode.StretchImage
            };

            ElementPictureBox.MouseDown += ElementMouseDown;

            parentPanel.Controls.Add(ElementPictureBox);
            parentPanel.Controls.Add(NameLabel);

            this.OnMouseDownAction = onMouseDown;

            MouseDown += (o, mea) => OnMouseDownAction.Invoke(o, mea);

            pinPanel = new PinPanel()
            {
                Visible = false,
                Enabled = false,
                Location = new Point(0, NameLabel.Location.Y + NameLabel.Height)
            };

            Controls.Add(pinPanel);
        }

        private void ElementMouseDown(object sender, MouseEventArgs args)
        {
            OnMouseDownAction(this, args);
        }

        public void AddPin(string name)
        {
            pinPanel.AddPin(name);
        }
    }
}
