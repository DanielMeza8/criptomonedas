namespace criptomonedas
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtcantidad = new System.Windows.Forms.TextBox();
            this.txttotal = new System.Windows.Forms.TextBox();
            this.txttipoMoneda = new System.Windows.Forms.ComboBox();
            this.btnproceso = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(170, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "CRIPTOMONEDAS";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(161, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Moneda";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(98, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cantidad a cambiar";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(170, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Total ";
            // 
            // txtcantidad
            // 
            this.txtcantidad.Location = new System.Drawing.Point(218, 146);
            this.txtcantidad.Name = "txtcantidad";
            this.txtcantidad.Size = new System.Drawing.Size(100, 23);
            this.txtcantidad.TabIndex = 5;
            // 
            // txttotal
            // 
            this.txttotal.Location = new System.Drawing.Point(219, 183);
            this.txttotal.Name = "txttotal";
            this.txttotal.ReadOnly = true;
            this.txttotal.Size = new System.Drawing.Size(100, 23);
            this.txttotal.TabIndex = 6;
            // 
            // txttipoMoneda
            // 
            this.txttipoMoneda.FormattingEnabled = true;
            this.txttipoMoneda.Items.AddRange(new object[] {
            "Doge",
            "XRP",
            "Bitcoin",
            "BAT"});
            this.txttipoMoneda.Location = new System.Drawing.Point(218, 108);
            this.txttipoMoneda.Name = "txttipoMoneda";
            this.txttipoMoneda.Size = new System.Drawing.Size(121, 23);
            this.txttipoMoneda.TabIndex = 7;
            // 
            // btnproceso
            // 
            this.btnproceso.Location = new System.Drawing.Point(218, 237);
            this.btnproceso.Name = "btnproceso";
            this.btnproceso.Size = new System.Drawing.Size(75, 23);
            this.btnproceso.TabIndex = 8;
            this.btnproceso.Text = "Cambiar";
            this.btnproceso.UseVisualStyleBackColor = true;
            this.btnproceso.Click += new System.EventHandler(this.btnproceso_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 349);
            this.Controls.Add(this.btnproceso);
            this.Controls.Add(this.txttipoMoneda);
            this.Controls.Add(this.txttotal);
            this.Controls.Add(this.txtcantidad);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtcantidad;
        private TextBox txttotal;
        private ComboBox txttipoMoneda;
        private Button btnproceso;
    }
}