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
        public Computer(int width, int height, Image picture, Action<object, MouseEventArgs> onMouseDown, int x, int y, int pinCount, string name = "Безымянный") : base(name, width, height, picture, onMouseDown)
        {
            ElementName = name;

            SetLocation(x, y);

            Pins = new List<Pin>();

            for(var i = 0; i < pinCount; i++)
            {
                Pins.Add(new Pin(i));

                AddPin(i.ToString());
            }
        }

        public string ElementName { get; private set; }

        public List<Pin> Pins { get; private set; }

        public void ChangeName(string text)
        {
            ElementName = text;

            NameLabel.Text = text;
        }

        public void OpenSettings()
        {
            DragAndDropController.FormMain.CreateSettingsWindow(this);
        }

        public void SetLocation(int x, int y)
        {
            Location = new Point(x, y);
        }
    }
}
