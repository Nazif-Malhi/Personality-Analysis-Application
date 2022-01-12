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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string color = second.Text;
            if (color == "red" || color == "light red" || color == "dark red" || color == "maroon")
            {
                MessageBox.Show("The color you have choosen shows energy, passion, action, ambition and determination. On the negative side it shows anger and sexual passion", "RESULT");
            }
            else if (color == "orange" || color == "dark orange" || color == "light orange")
            {
                MessageBox.Show("The color you have choosen shows social communication and optimism. From a negative side it shows sign of pessimism and superficiality.", "RESULT");
            }
            else if (color == "yellow" || color == "light yellow" || color == "dark yellow" || color == "skin")
            {
                MessageBox.Show("The color you have choosen shows optimisticism and cheerfulness.it is also the color of mind , intellectual and purity. From negative side it shows impatience, criticism and cowardice.", "RESULT");
            }
            else if (color == "green" || color == "parrot" || color == "light green" || color == "dark green" || color == "sea green")
            {
                MessageBox.Show("The color you have choosen shows is the color of balance and growth. It can mean both self-reliance as a positive and possessiveness as a negative, among many other meanings. ", "RESULT");
            }
            else if (color == "blue" || color == "light blue" || color == "dark blue" || color == "sky blue" || color == "navy blue")
            {
                MessageBox.Show("The color you have choosen is the color of trust and peace. It can suggest loyalty and integrity as well as conservatism and frigidity. ", "RESULT");
            }
            else if (color == "indigo")
            {
                MessageBox.Show("The color you have choosen is the color of intuition. In the meaning of colors it can mean idealism and structure as well as ritualistic and addictive.", "RESULT");
            }
            else if (color == "purple" || color == "light purple" || color == "dark purple")
            {
                MessageBox.Show("The color you have choosen is the color of the imagination. It can be creative and individual or immature and impractical.", "RESULT");
            }
            else if (color == "pink" || color == "light pink" || color == "dark pink" || color == "baby pink")
            {
                MessageBox.Show("The color you have choosen shows unconditional love and nurturing.it can also shows immature, silly and girlish.", "RESULT");
            }
            else if (color == "magenta")
            {
                MessageBox.Show("The color you have choosen is a color of universal harmony and emotional balance. It also shows spiritual yet practical, encouraging common sense and a balanced outlook on life.", "RESULT");
            }
            else if (color == "brown" || color == "light brown" || color == "dark brown")
            {
                MessageBox.Show("The color you have choosen shows friendness yet seriousnous.It is also a down-to-earth color that relates to security, protection, comfort and material wealth.", "RESULT");
            }
            else if (color == "grey" || color == "dark grey" || color == "light grey")
            {
                MessageBox.Show("The color you have choosen is the color of compromise - being neither black nor white, it is the transition between two non-colors. It also shows unemotional and detached personality and can also be indecisive.", "RESULT");
            }
            else if (color == "silver")
            {
                MessageBox.Show("The color you have choosen shows feminine energy.This color is related to the moon and the ebb and flow of the tides - it is fluid, emotional, sensitive and mysterious", "RESULT");
            }
            else if (color == "gold" || color == "golden" || color == "light golden" || color == "dark golden")
            {
                MessageBox.Show("The color you have choosen is the color of success, achievement and triumph.It also shows association with abundance and prosperity, luxury and quality, prestige and sophistication, value and elegance, the color psychology of gold implies affluence, material wealth and extravagance.", "RESULT");
            }
            else if (color == "white" || color == "off white")
            {
                MessageBox.Show("The color you have choosen shows most completeness and pureness.It is the color of perfection. The color means purity, innocence, wholeness and completion.", "RESULT");
            }
            else if (color == "black")
            {
                MessageBox.Show("The color you have choosen is the color of the hidden, the secretive and the unknown, creating an air of mystery. It keeps things bottled up inside, hidden from the world.", "RESULT");
            }
            else
            {
                MessageBox.Show("Please enter correct spellings", "RESULT");
            }
        }

        private void NEXT_2_Click(object sender, EventArgs e)
        {

            this.Close();
            Form7 next = new Form7();
            next.Show();
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }
    }
}
