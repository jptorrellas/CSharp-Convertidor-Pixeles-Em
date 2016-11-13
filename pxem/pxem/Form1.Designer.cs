namespace pxem
{
    partial class frm1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm1));
            this.txtBase = new System.Windows.Forms.TextBox();
            this.txtPx = new System.Windows.Forms.TextBox();
            this.txtEm = new System.Windows.Forms.TextBox();
            this.lblBasePx = new System.Windows.Forms.Label();
            this.lblPx = new System.Windows.Forms.Label();
            this.lblEm = new System.Windows.Forms.Label();
            this.lblBase = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtBase
            // 
            this.txtBase.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBase.Location = new System.Drawing.Point(43, 5);
            this.txtBase.Name = "txtBase";
            this.txtBase.Size = new System.Drawing.Size(29, 20);
            this.txtBase.TabIndex = 0;
            this.txtBase.Text = "16";
            this.txtBase.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBase.Click += new System.EventHandler(this.txtBase_Click);
            // 
            // txtPx
            // 
            this.txtPx.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPx.Location = new System.Drawing.Point(27, 31);
            this.txtPx.Name = "txtPx";
            this.txtPx.Size = new System.Drawing.Size(75, 20);
            this.txtPx.TabIndex = 1;
            this.txtPx.Click += new System.EventHandler(this.txtPx_Click);
            this.txtPx.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPx_KeyPress);
            // 
            // txtEm
            // 
            this.txtEm.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEm.Location = new System.Drawing.Point(27, 58);
            this.txtEm.Name = "txtEm";
            this.txtEm.Size = new System.Drawing.Size(75, 20);
            this.txtEm.TabIndex = 2;
            this.txtEm.Click += new System.EventHandler(this.txtEm_Click);
            this.txtEm.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEm_KeyPress);
            // 
            // lblBasePx
            // 
            this.lblBasePx.AutoSize = true;
            this.lblBasePx.Location = new System.Drawing.Point(78, 8);
            this.lblBasePx.Name = "lblBasePx";
            this.lblBasePx.Size = new System.Drawing.Size(18, 13);
            this.lblBasePx.TabIndex = 3;
            this.lblBasePx.Text = "px";
            // 
            // lblPx
            // 
            this.lblPx.AutoSize = true;
            this.lblPx.Location = new System.Drawing.Point(6, 34);
            this.lblPx.Name = "lblPx";
            this.lblPx.Size = new System.Drawing.Size(21, 13);
            this.lblPx.TabIndex = 4;
            this.lblPx.Text = "px:";
            // 
            // lblEm
            // 
            this.lblEm.AutoSize = true;
            this.lblEm.Location = new System.Drawing.Point(3, 61);
            this.lblEm.Name = "lblEm";
            this.lblEm.Size = new System.Drawing.Size(24, 13);
            this.lblEm.TabIndex = 5;
            this.lblEm.Text = "em:";
            // 
            // lblBase
            // 
            this.lblBase.AutoSize = true;
            this.lblBase.Location = new System.Drawing.Point(3, 8);
            this.lblBase.Name = "lblBase";
            this.lblBase.Size = new System.Drawing.Size(34, 13);
            this.lblBase.TabIndex = 6;
            this.lblBase.Text = "Base:";
            // 
            // frm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(106, 81);
            this.Controls.Add(this.lblBase);
            this.Controls.Add(this.lblEm);
            this.Controls.Add(this.lblPx);
            this.Controls.Add(this.lblBasePx);
            this.Controls.Add(this.txtEm);
            this.Controls.Add(this.txtPx);
            this.Controls.Add(this.txtBase);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "empx";
            this.TopMost = true;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frm1_FormClosed);
            this.Load += new System.EventHandler(this.frm1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBase;
        private System.Windows.Forms.TextBox txtPx;
        private System.Windows.Forms.TextBox txtEm;
        private System.Windows.Forms.Label lblBasePx;
        private System.Windows.Forms.Label lblPx;
        private System.Windows.Forms.Label lblEm;
        private System.Windows.Forms.Label lblBase;
    }
}

