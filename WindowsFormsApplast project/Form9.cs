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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        double q = 0;
        double qw = 0;

        double er =0;
        double w = 0;
        int[] a = new int[33];
        int[] b = new int[33] { 33, 33, 33, 3, 33, 33, 3, 33, 3, 33, 33, 56, 34, 78, 23, 12, 3, 1, 34, 67, 23, 1, 4, 56, 67, 34, 23, 5, 23, 73, 6, 85, 67 };
        double score = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            
            // Console.WriteLine("array");
            for (int i = 0; i < 33; i++)
            {
                a[i] = (int.Parse(textBox1.Text));
                

            }
            for (int i = 0; i < 33; i++)
            {
                if (a[i] == b[i])
                {
                    score++;
                    // Console.WriteLine(score);
                }
                if (a[i] != b[i])
                {
                    break;
                }
            }

            
                 q = 32;
                 qw = 18;

                 er = ((score / 100) * q);
                 w = ((er / qw) * 100);
            //mentall age
            //Console.WriteLine(w);
            //Console.WriteLine("your iq age {0}", er);
            //Form10 _form10 = new Form10();
            //this.Hide();
            //_form10.tys(textBox1.Text);
            //_form10.Show();

          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("your Mental age is "+""+w.ToString());
            MessageBox.Show(er.ToString()+""+"your Iq Level  is " );
        }

        private void Form9_Load(object sender, EventArgs e)
        {

        }
    }
}
