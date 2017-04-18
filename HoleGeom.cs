using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DDIS
{
    public partial class HoleGeom : Form
    {
        public HoleGeom()
        {
            InitializeComponent();
        }

        private void textBox37_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainWin MainWin = new MainWin();
            MainWin.Show(this);
        }
    }
}
