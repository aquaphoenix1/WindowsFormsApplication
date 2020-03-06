using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication.Elements
{
    interface IElement
    {
        string ElementName { get; }
        void OpenSettings();

        void SetLocation(int x, int y);
        void ChangeName(string text);
    }
}
