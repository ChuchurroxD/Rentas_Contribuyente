using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SGR.WinApp.Layout._4_Procesos.Predio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int index= this.tabControl1.SelectedIndex;
            int total = this.tabControl1.TabCount;
            int selec = index + 1;
            if(selec<total)
            this.tabControl1.SelectedIndex = selec;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int index = this.tabControl1.SelectedIndex;
            int selec = index - 1;
            if (selec >-1)
                this.tabControl1.SelectedIndex = selec;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string path = System.IO.Directory.GetCurrentDirectory();
            string destino = System.IO.Directory.GetCurrentDirectory() + "\\casamapa";
            if (!System.IO.Directory.Exists(destino))
            {
                // This path is a directory
                System.IO.Directory.CreateDirectory(destino);
            }
            //string target = System.IO.Path.GetFullPath();
        }
    }
}
