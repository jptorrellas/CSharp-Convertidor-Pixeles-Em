using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pxem
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm1 form = new frm1();
            form.Show();         
        }

        private void textBox6_Click(object sender, EventArgs e)
        {
            WebBrowser wb = new WebBrowser();
            wb.Show();
        }

        
    }
}
