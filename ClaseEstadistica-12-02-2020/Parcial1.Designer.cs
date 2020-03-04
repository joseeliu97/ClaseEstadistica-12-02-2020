namespace ClaseEstadistica_12_02_2020
{
    partial class Parcial1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.cboDivisasDE = new System.Windows.Forms.ComboBox();
            this.cboDivisasA = new System.Windows.Forms.ComboBox();
            this.txtValorDivisas = new System.Windows.Forms.TextBox();
            this.lblDivisas = new System.Windows.Forms.Label();
            this.lblAlmacenamiento = new System.Windows.Forms.Label();
            this.txtValorAlmacenamiento = new System.Windows.Forms.TextBox();
            this.CboAlmacenamientoDE = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.CboAlmacenamientoA = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(168, 158);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Convertir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(501, 219);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.lblDivisas);
            this.tabPage1.Controls.Add(this.txtValorDivisas);
            this.tabPage1.Controls.Add(this.cboDivisasA);
            this.tabPage1.Controls.Add(this.cboDivisasDE);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(493, 193);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Divisas";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.CboAlmacenamientoA);
            this.tabPage2.Controls.Add(this.lblAlmacenamiento);
            this.tabPage2.Controls.Add(this.txtValorAlmacenamiento);
            this.tabPage2.Controls.Add(this.CboAlmacenamientoDE);
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(493, 193);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Almacenamiento";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // cboDivisasDE
            // 
            this.cboDivisasDE.FormattingEnabled = true;
            this.cboDivisasDE.Items.AddRange(new object[] {
            "Dolares",
            "Colones(SV)",
            "Yenes",
            "Rupia",
            "Peso (Chileno)",
            "Peso (MX)",
            "Peso (Argentino)",
            "Bitcoin"});
            this.cboDivisasDE.Location = new System.Drawing.Point(50, 74);
            this.cboDivisasDE.Name = "cboDivisasDE";
            this.cboDivisasDE.Size = new System.Drawing.Size(121, 21);
            this.cboDivisasDE.TabIndex = 3;
            // 
            // cboDivisasA
            // 
            this.cboDivisasA.FormattingEnabled = true;
            this.cboDivisasA.Items.AddRange(new object[] {
            "Dolares",
            "Colones(SV)",
            "Yenes",
            "Rupia",
            "Peso (Chileno)",
            "Peso (MX)",
            "Peso (Argentino)",
            "Bitcoin"});
            this.cboDivisasA.Location = new System.Drawing.Point(255, 74);
            this.cboDivisasA.Name = "cboDivisasA";
            this.cboDivisasA.Size = new System.Drawing.Size(121, 21);
            this.cboDivisasA.TabIndex = 4;
            // 
            // txtValorDivisas
            // 
            this.txtValorDivisas.Location = new System.Drawing.Point(132, 22);
            this.txtValorDivisas.Name = "txtValorDivisas";
            this.txtValorDivisas.Size = new System.Drawing.Size(100, 20);
            this.txtValorDivisas.TabIndex = 5;
            // 
            // lblDivisas
            // 
            this.lblDivisas.AutoSize = true;
            this.lblDivisas.Location = new System.Drawing.Point(184, 125);
            this.lblDivisas.Name = "lblDivisas";
            this.lblDivisas.Size = new System.Drawing.Size(0, 13);
            this.lblDivisas.TabIndex = 6;
            // 
            // lblAlmacenamiento
            // 
            this.lblAlmacenamiento.AutoSize = true;
            this.lblAlmacenamiento.Location = new System.Drawing.Point(225, 140);
            this.lblAlmacenamiento.Name = "lblAlmacenamiento";
            this.lblAlmacenamiento.Size = new System.Drawing.Size(0, 13);
            this.lblAlmacenamiento.TabIndex = 11;
            this.lblAlmacenamiento.Click += new System.EventHandler(this.lblAlmacenamiento_Click);
            // 
            // txtValorAlmacenamiento
            // 
            this.txtValorAlmacenamiento.Location = new System.Drawing.Point(181, 36);
            this.txtValorAlmacenamiento.Name = "txtValorAlmacenamiento";
            this.txtValorAlmacenamiento.Size = new System.Drawing.Size(100, 20);
            this.txtValorAlmacenamiento.TabIndex = 10;
            // 
            // CboAlmacenamientoDE
            // 
            this.CboAlmacenamientoDE.FormattingEnabled = true;
            this.CboAlmacenamientoDE.Items.AddRange(new object[] {
            "Megabyte",
            "bit",
            "Byte",
            "Kilobyte",
            "Gigabyte",
            "Terabyte"});
            this.CboAlmacenamientoDE.Location = new System.Drawing.Point(54, 83);
            this.CboAlmacenamientoDE.Name = "CboAlmacenamientoDE";
            this.CboAlmacenamientoDE.Size = new System.Drawing.Size(121, 21);
            this.CboAlmacenamientoDE.TabIndex = 8;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(181, 156);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Convertir";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // CboAlmacenamientoA
            // 
            this.CboAlmacenamientoA.FormattingEnabled = true;
            this.CboAlmacenamientoA.Items.AddRange(new object[] {
            "Megabyte",
            "bit",
            "Byte",
            "Kilobyte",
            "Gigabyte",
            "Terabyte"});
            this.CboAlmacenamientoA.Location = new System.Drawing.Point(287, 88);
            this.CboAlmacenamientoA.Name = "CboAlmacenamientoA";
            this.CboAlmacenamientoA.Size = new System.Drawing.Size(121, 21);
            this.CboAlmacenamientoA.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "DE:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(264, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "A:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(101, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Cantidad:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(58, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Cantidad:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "DE:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(215, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "A:";
            // 
            // Parcial1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 243);
            this.Controls.Add(this.tabControl1);
            this.Name = "Parcial1";
            this.Text = "Parcial1";
            this.Load += new System.EventHandler(this.Parcial1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ComboBox cboDivisasDE;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ComboBox cboDivisasA;
        private System.Windows.Forms.TextBox txtValorDivisas;
        private System.Windows.Forms.Label lblDivisas;
        private System.Windows.Forms.Label lblAlmacenamiento;
        private System.Windows.Forms.TextBox txtValorAlmacenamiento;
        private System.Windows.Forms.ComboBox CboAlmacenamientoDE;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox CboAlmacenamientoA;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}