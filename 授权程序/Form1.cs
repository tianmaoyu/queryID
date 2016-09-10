using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 授权程序
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cpu = this.textBox1.Text.Trim();
            var byKey = System.Text.ASCIIEncoding.ASCII.GetBytes(cpu).ToArray();
            string keys = null;
            foreach (var k in byKey)
            {
                keys += k.ToString();
            }
            this.textBox2.Text = keys;
        }
    }
}
