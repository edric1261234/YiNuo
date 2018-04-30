using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace yinuo365
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            INIClass ini_class = new INIClass("D:\\yinuo.ini");

            xmlOperator x = new xmlOperator();
            x.UpdateNode(ini_class.IniReadValue("KaiPiao", "HeJi"), ini_class.IniReadValue("KaiPiao", "ShuiEr"));
        }
    }
}