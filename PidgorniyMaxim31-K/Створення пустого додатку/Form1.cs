using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("HI");
            this.BackColor = Color.Aquamarine;
            this.Width = 250;
            this.Height = 250;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = Color.Aquamarine;
            this.ForeColor = Color.Red;
            this.StartPosition = FormStartPosition.CenterScreen;


        }
    }
}
