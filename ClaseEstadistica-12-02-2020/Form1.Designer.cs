namespace ClaseEstadistica_12_02_2020
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
            this.lblSerie = new System.Windows.Forms.Label();
            this.txtSerie = new System.Windows.Forms.TextBox();
            this.lblRespuestaSerie = new System.Windows.Forms.Label();
            this.btnMediaAritmetica = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSerie
            // 
            this.lblSerie.AutoSize = true;
            this.lblSerie.Location = new System.Drawing.Point(12, 33);
            this.lblSerie.Name = "lblSerie";
            this.lblSerie.Size = new System.Drawing.Size(34, 13);
            this.lblSerie.TabIndex = 0;
            this.lblSerie.Text = "Serie:";
            // 
            // txtSerie
            // 
            this.txtSerie.Location = new System.Drawing.Point(63, 30);
            this.txtSerie.Name = "txtSerie";
            this.txtSerie.Size = new System.Drawing.Size(257, 20);
            this.txtSerie.TabIndex = 1;
            // 
            // lblRespuestaSerie
            // 
            this.lblRespuestaSerie.AutoSize = true;
            this.lblRespuestaSerie.Location = new System.Drawing.Point(348, 36);
            this.lblRespuestaSerie.Name = "lblRespuestaSerie";
            this.lblRespuestaSerie.Size = new System.Drawing.Size(14, 13);
            this.lblRespuestaSerie.TabIndex = 2;
            this.lblRespuestaSerie.Text = "X";
            // 
            // btnMediaAritmetica
            // 
            this.btnMediaAritmetica.BackColor = System.Drawing.Color.Transparent;
            this.btnMediaAritmetica.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMediaAritmetica.ForeColor = System.Drawing.Color.Teal;
            this.btnMediaAritmetica.Location = new System.Drawing.Point(149, 56);
            this.btnMediaAritmetica.Name = "btnMediaAritmetica";
            this.btnMediaAritmetica.Size = new System.Drawing.Size(75, 23);
            this.btnMediaAritmetica.TabIndex = 3;
            this.btnMediaAritmetica.Text = "Calcular X";
            this.btnMediaAritmetica.UseVisualStyleBackColor = false;
            this.btnMediaAritmetica.Click += new System.EventHandler(this.btnMediaAritmetica_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(465, 324);
            this.Controls.Add(this.btnMediaAritmetica);
            this.Controls.Add(this.lblRespuestaSerie);
            this.Controls.Add(this.txtSerie);
            this.Controls.Add(this.lblSerie);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSerie;
        private System.Windows.Forms.TextBox txtSerie;
        private System.Windows.Forms.Label lblRespuestaSerie;
        private System.Windows.Forms.Button btnMediaAritmetica;
    }
}

