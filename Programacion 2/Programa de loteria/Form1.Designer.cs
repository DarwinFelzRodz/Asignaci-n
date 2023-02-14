namespace loteria02
{
    partial class Form1
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
            this.btnJugar = new System.Windows.Forms.Button();
            this.txtPrimera = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSegunda = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTercera = new System.Windows.Forms.TextBox();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.lblResultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnJugar
            // 
            this.btnJugar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnJugar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJugar.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnJugar.Location = new System.Drawing.Point(184, 163);
            this.btnJugar.Name = "btnJugar";
            this.btnJugar.Size = new System.Drawing.Size(126, 53);
            this.btnJugar.TabIndex = 0;
            this.btnJugar.Text = "JUGAR";
            this.btnJugar.UseVisualStyleBackColor = false;
            this.btnJugar.Click += new System.EventHandler(this.btnJugar_Click);
            // 
            // txtPrimera
            // 
            this.txtPrimera.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtPrimera.Location = new System.Drawing.Point(12, 100);
            this.txtPrimera.Name = "txtPrimera";
            this.txtPrimera.Size = new System.Drawing.Size(116, 20);
            this.txtPrimera.TabIndex = 1;
            this.txtPrimera.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "PRIMERA";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(191, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "SEGUNDA";
            // 
            // txtSegunda
            // 
            this.txtSegunda.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtSegunda.Location = new System.Drawing.Point(194, 100);
            this.txtSegunda.Name = "txtSegunda";
            this.txtSegunda.Size = new System.Drawing.Size(116, 20);
            this.txtSegunda.TabIndex = 3;
            this.txtSegunda.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(382, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "TERCERA";
            // 
            // txtTercera
            // 
            this.txtTercera.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtTercera.Location = new System.Drawing.Point(385, 100);
            this.txtTercera.Name = "txtTercera";
            this.txtTercera.Size = new System.Drawing.Size(116, 20);
            this.txtTercera.TabIndex = 5;
            // 
            // txtNumero
            // 
            this.txtNumero.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtNumero.Location = new System.Drawing.Point(224, 24);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(55, 20);
            this.txtNumero.TabIndex = 7;
            // 
            // lblResultado
            // 
            this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Location = new System.Drawing.Point(194, 249);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(213, 35);
            this.lblResultado.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTercera);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSegunda);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPrimera);
            this.Controls.Add(this.btnJugar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnJugar;
        private System.Windows.Forms.TextBox txtPrimera;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSegunda;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTercera;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label lblResultado;
    }
}

