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
    public partial class frm1 : Form
    {
        private float basePx = 16; 
        public frm1()
        {
            InitializeComponent();
            this.basePx = float.Parse(this.txtBase.Text);
        }

        private void frm1_Load(object sender, EventArgs e)
        {

        }

        private void txtPx_Click(object sender, EventArgs e)
        {
            this.txtPx.Clear();
            this.txtEm.Clear();
            this.txtPx.BackColor = Color.White;
            this.txtEm.BackColor = Color.White;
        }

        private void txtEm_Click(object sender, EventArgs e)
        {
            this.txtPx.Clear();
            this.txtEm.Clear();
            this.txtPx.BackColor = Color.White;
            this.txtEm.BackColor = Color.White;
        }

        private void txtBase_Click(object sender, EventArgs e)
        {
            this.txtPx.Clear();
            this.txtEm.Clear();
            this.txtPx.BackColor = Color.White;
            this.txtEm.BackColor = Color.White;
        }       
        
        private void txtPx_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Para obligar a que sólo se introduzcan números
            if (Char.IsDigit(e.KeyChar) || Char.IsControl(e.KeyChar) || e.KeyChar == '.')
            {
                if (e.KeyChar == '.')
                {
                    if (this.txtPx.Text.Contains("."))
                    {
                        e.Handled = true;
                    }
                    else
                    {
                        e.Handled = false;
                        this.txtEm.Clear();
                    }
                }
                else
                {
                    e.Handled = false;
                    this.txtEm.Clear();
                }
            }
            else
            {
                //el resto de teclas pulsadas se desactivan
                e.Handled = true;
            }

            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                this.PxToEm();
            }           
        }

        private void txtEm_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Para obligar a que sólo se introduzcan números
            if (Char.IsDigit(e.KeyChar) || Char.IsControl(e.KeyChar) || e.KeyChar == '.')
            {
                if (e.KeyChar == '.')
	            {
		            if (this.txtEm.Text.Contains("."))
                    {
                        e.Handled = true;
                    }
                    else
                    {
                        e.Handled = false;
                        this.txtPx.Clear();
                    }
	            }
                else
	            {
                    e.Handled = false;
                    this.txtPx.Clear();
	            }                              
            }
            else
            {
                //el resto de teclas pulsadas se desactivan
                e.Handled = true;
            }

            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                this.EmToPx();
            }           
        }

        //Funciones
        
        private void EmToPx()
        {
            if (this.txtBase.Text != "" && this.txtEm.Text != "")
            {
                this.basePx = float.Parse(this.txtBase.Text);
                float em = float.Parse((this.txtEm.Text).Replace(".", ","));
                this.txtPx.Text = ((em * basePx).ToString() + "px").Replace(",", ".");
                this.txtPx.BackColor = Color.CornflowerBlue;
                Clipboard.SetText(this.txtPx.Text);

            } 
        }

        private void PxToEm()
        {
            if (this.txtBase.Text != "" && this.txtPx.Text != "")
            {
                this.basePx = float.Parse(this.txtBase.Text);
                float px = float.Parse((this.txtPx.Text).Replace(".", ","));
                this.txtEm.Text = ((px / basePx).ToString() + "em").Replace(",", ".");
                this.txtEm.BackColor = Color.CornflowerBlue;
                Clipboard.SetText(this.txtEm.Text);
            }  
        }

        private void frm1_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        
    }
}
