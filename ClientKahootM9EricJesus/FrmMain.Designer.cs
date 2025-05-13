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
            this.lbEstatConexio = new System.Windows.Forms.Label();
            this.tbIp = new System.Windows.Forms.TextBox();
            this.lbIp = new System.Windows.Forms.Label();
            this.lbEsperant = new System.Windows.Forms.Label();
            this.lbNick = new System.Windows.Forms.Label();
            this.tbNick = new System.Windows.Forms.TextBox();
            this.btResposta1 = new System.Windows.Forms.Button();
            this.btResposta3 = new System.Windows.Forms.Button();
            this.btResposta2 = new System.Windows.Forms.Button();
            this.btResposta4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btEscoltar
            // 
            this.btEscoltar.Location = new System.Drawing.Point(459, 303);
            this.btEscoltar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btEscoltar.Name = "btEscoltar";
            this.btEscoltar.Size = new System.Drawing.Size(109, 46);
            this.btEscoltar.TabIndex = 0;
            this.btEscoltar.Text = "CONNECTAR";
            this.btEscoltar.UseVisualStyleBackColor = true;
            this.btEscoltar.Click += new System.EventHandler(this.btEscoltar_Click);
            // 
            // lbEstatConexio
            // 
            this.lbEstatConexio.AutoSize = true;
            this.lbEstatConexio.Location = new System.Drawing.Point(826, 48);
            this.lbEstatConexio.Name = "lbEstatConexio";
            this.lbEstatConexio.Size = new System.Drawing.Size(10, 16);
            this.lbEstatConexio.TabIndex = 1;
            this.lbEstatConexio.Text = ".";
            // 
            // tbIp
            // 
            this.tbIp.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbIp.Location = new System.Drawing.Point(420, 172);
            this.tbIp.Name = "tbIp";
            this.tbIp.Size = new System.Drawing.Size(202, 41);
            this.tbIp.TabIndex = 2;
            // 
            // lbIp
            // 
            this.lbIp.AutoSize = true;
            this.lbIp.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIp.Location = new System.Drawing.Point(363, 175);
            this.lbIp.Name = "lbIp";
            this.lbIp.Size = new System.Drawing.Size(51, 36);
            this.lbIp.TabIndex = 3;
            this.lbIp.Text = "IP:";
            // 
            // lbEsperant
            // 
            this.lbEsperant.AutoSize = true;
            this.lbEsperant.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEsperant.Location = new System.Drawing.Point(407, 239);
            this.lbEsperant.Name = "lbEsperant";
            this.lbEsperant.Size = new System.Drawing.Size(215, 32);
            this.lbEsperant.TabIndex = 4;
            this.lbEsperant.Text = "ESPERANDO...";
            this.lbEsperant.Visible = false;
            // 
            // lbNick
            // 
            this.lbNick.AutoSize = true;
            this.lbNick.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNick.Location = new System.Drawing.Point(320, 229);
            this.lbNick.Name = "lbNick";
            this.lbNick.Size = new System.Drawing.Size(94, 36);
            this.lbNick.TabIndex = 6;
            this.lbNick.Text = "NICK:";
            // 
            // tbNick
            // 
            this.tbNick.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNick.Location = new System.Drawing.Point(420, 224);
            this.tbNick.Name = "tbNick";
            this.tbNick.Size = new System.Drawing.Size(202, 41);
            this.tbNick.TabIndex = 5;
            // 
            // btResposta1
            // 
            this.btResposta1.BackColor = System.Drawing.Color.LightGreen;
            this.btResposta1.Location = new System.Drawing.Point(173, 135);
            this.btResposta1.Name = "btResposta1";
            this.btResposta1.Size = new System.Drawing.Size(306, 162);
            this.btResposta1.TabIndex = 7;
            this.btResposta1.Text = "1";
            this.btResposta1.UseVisualStyleBackColor = false;
            // 
            // btResposta3
            // 
            this.btResposta3.BackColor = System.Drawing.Color.Thistle;
            this.btResposta3.Location = new System.Drawing.Point(173, 303);
            this.btResposta3.Name = "btResposta3";
            this.btResposta3.Size = new System.Drawing.Size(306, 162);
            this.btResposta3.TabIndex = 8;
            this.btResposta3.Text = "3";
            this.btResposta3.UseVisualStyleBackColor = false;
            // 
            // btResposta2
            // 
            this.btResposta2.BackColor = System.Drawing.Color.Turquoise;
            this.btResposta2.Location = new System.Drawing.Point(485, 135);
            this.btResposta2.Name = "btResposta2";
            this.btResposta2.Size = new System.Drawing.Size(306, 162);
            this.btResposta2.TabIndex = 9;
            this.btResposta2.Text = "2";
            this.btResposta2.UseVisualStyleBackColor = false;
            // 
            // btResposta4
            // 
            this.btResposta4.BackColor = System.Drawing.Color.LightCoral;
            this.btResposta4.Location = new System.Drawing.Point(485, 303);
            this.btResposta4.Name = "btResposta4";
            this.btResposta4.Size = new System.Drawing.Size(306, 162);
            this.btResposta4.TabIndex = 10;
            this.btResposta4.Text = "4";
            this.btResposta4.UseVisualStyleBackColor = false;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 493);
            this.Controls.Add(this.btResposta4);
            this.Controls.Add(this.btResposta2);
            this.Controls.Add(this.btResposta3);
            this.Controls.Add(this.btResposta1);
            this.Controls.Add(this.lbNick);
            this.Controls.Add(this.tbNick);
            this.Controls.Add(this.lbEsperant);
            this.Controls.Add(this.lbIp);
            this.Controls.Add(this.tbIp);
            this.Controls.Add(this.lbEstatConexio);
            this.Controls.Add(this.btEscoltar);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btEscoltar;
        private System.Windows.Forms.Label lbEstatConexio;
        private System.Windows.Forms.TextBox tbIp;
        private System.Windows.Forms.Label lbIp;
        private System.Windows.Forms.Label lbEsperant;
        private System.Windows.Forms.Label lbNick;
        private System.Windows.Forms.TextBox tbNick;
        private System.Windows.Forms.Button btResposta1;
        private System.Windows.Forms.Button btResposta3;
        private System.Windows.Forms.Button btResposta2;
        private System.Windows.Forms.Button btResposta4;
    }
}

