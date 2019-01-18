using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrueP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var x = Convert.ToDouble(textBox1.Text);
            var y = Convert.ToDouble(textBox2.Text);
            // True Position = 2 x SQRT(X VAR^2 + Y VAR ^ 2)
            var totalDeviation = 2 * Math.Sqrt(Math.Pow(x, 2) + (Math.Pow(x, 2)));
            var answer = Math.Round(totalDeviation, 4);
            label3.Text = Convert.ToString(answer);
        }
    }
}
