using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;

namespace WindowsFormsApplication.Elements
{
    public class Pin : Panel
    {
        private string name;

        private Label NameLabel;

        public Pin(int number)
        {
            name = string.Format("Pin {0}", number);

            NameLabel = new Label()
            {
                Width = this.Width,
                Height = 40
            };

            NameLabel.Text = name;

            Controls.Add(NameLabel);
        }
    }
}
