using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label_account_Click(object sender, EventArgs e)
        {

        }

        private void textBox_account_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_login_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Owner = this;   /* this(自己）：form1 */
            this.Hide();        /* 或 this.close(); */
            f2.Show();

        }
    }
}
