using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplast_project
{
    public partial class Form2 : Form
    {
        //private string txt;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
        public void ty(string text)
        {
            textBox1.Text = text;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 _form1 = new Form3();
            this.Hide();
            //_form.ty(textBox1.Text);
            _form1.Show();
        }
    }
}
