namespace ClientKahootM9EricJesus
{
    partial class FrmMain
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
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
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btEscoltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btEscoltar
            // 
            this.btEscoltar.Location = new System.Drawing.Point(344, 342);
            this.btEscoltar.Name = "btEscoltar";
            this.btEscoltar.Size = new System.Drawing.Size(82, 37);
            this.btEscoltar.TabIndex = 0;
            this.btEscoltar.Text = "CONNECTAR";
            this.btEscoltar.UseVisualStyleBackColor = true;
            this.btEscoltar.Click += new System.EventHandler(this.btEscoltar_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btEscoltar);
            this.Name = "FrmMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btEscoltar;
    }
}

