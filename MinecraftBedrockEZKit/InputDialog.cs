using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MinecraftBedrockEZKit
{
    public partial class InputDialog : MetroFramework.Forms.MetroForm
    {
        public string input;
        public InputDialog()
        {
            InitializeComponent();
        }

        private void InputDialog_Load(object sender, EventArgs e)
        {

        }

        public void setDisplayText(string Title, string inputText)
        {
            this.Text = Title;
            metroTextBox1.Text = inputText;
        }

        private void MetroButton1_Click(object sender, EventArgs e)
        {
            input = metroTextBox1.Text;
            this.Close();
        }

        private void MetroButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
