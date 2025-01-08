using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotepadPro
{
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();
        }

        //This will load the information about developer who created the Notepad Pro Application into label
        private void AboutForm_Load(object sender, EventArgs e)
        {
            label1.Text= "Designed & Developed by Gaurav Kumar\nVersion 1.0.0.0(OS Build 19045.5247)\n©Gaurav Kumar. All rights reserved.\n\nThe Windows 10 Pro operating system and its user interface are protected\nby trademark and other pending or existing intellectual property rights\nin the India.\n\n\nThe product is licensed the Microsoft Software Licence Terms to:\n Mr Gaurav\n org name";
        }

        //This will close the about form
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
