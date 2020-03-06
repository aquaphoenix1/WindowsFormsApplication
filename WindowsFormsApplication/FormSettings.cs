using System;
using System.Windows.Forms;
using WindowsFormsApplication.Elements;

namespace WindowsFormsApplication
{
    partial class FormSettings : Form
    {
        private const string DEFAULT_NAME = "Безымянный";
        private IElement element;

        public FormSettings(IElement element)
        {
            InitializeComponent();

            this.element = element;

            textBox1.Text = (element.ElementName == "") ? DEFAULT_NAME : element.ElementName;

            var a = Convert.ChangeType(element, element.GetType());
        }

        private void CloseForm()
        {
            Close();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            CloseForm();
        }

        private void buttonAccept_Click(object sender, EventArgs e)
        {
            element.ChangeName(textBox1.Text != "" ? textBox1.Text : DEFAULT_NAME);

            CloseForm();
        }
    }
}
