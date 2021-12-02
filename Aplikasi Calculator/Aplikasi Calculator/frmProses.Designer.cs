
namespace Aplikasi_Calculator
{
    partial class frmProses
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNilaia = new System.Windows.Forms.TextBox();
            this.txtNilaib = new System.Windows.Forms.TextBox();
            this.cmbProses = new System.Windows.Forms.ComboBox();
            this.btnProses = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Operasi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nilai A";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nilai B";
            // 
            // txtNilaia
            // 
            this.txtNilaia.Location = new System.Drawing.Point(77, 60);
            this.txtNilaia.Name = "txtNilaia";
            this.txtNilaia.Size = new System.Drawing.Size(156, 20);
            this.txtNilaia.TabIndex = 3;
            // 
            // txtNilaib
            // 
            this.txtNilaib.Location = new System.Drawing.Point(78, 94);
            this.txtNilaib.Name = "txtNilaib";
            this.txtNilaib.Size = new System.Drawing.Size(155, 20);
            this.txtNilaib.TabIndex = 4;
            // 
            // cmbProses
            // 
            this.cmbProses.FormattingEnabled = true;
            this.cmbProses.Items.AddRange(new object[] {
            "Penjumlahan",
            "Pengurangan",
            "Perkalian",
            "Pembagian"});
            this.cmbProses.Location = new System.Drawing.Point(75, 28);
            this.cmbProses.Name = "cmbProses";
            this.cmbProses.Size = new System.Drawing.Size(158, 21);
            this.cmbProses.TabIndex = 5;
            // 
            // btnProses
            // 
            this.btnProses.Location = new System.Drawing.Point(218, 153);
            this.btnProses.Name = "btnProses";
            this.btnProses.Size = new System.Drawing.Size(92, 22);
            this.btnProses.TabIndex = 6;
            this.btnProses.Text = "Proses";
            this.btnProses.UseVisualStyleBackColor = true;
            this.btnProses.Click += new System.EventHandler(this.btnProses_Click);
            // 
            // FrmProses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 207);
            this.Controls.Add(this.btnProses);
            this.Controls.Add(this.cmbProses);
            this.Controls.Add(this.txtNilaib);
            this.Controls.Add(this.txtNilaia);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmProses";
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNilaia;
        private System.Windows.Forms.TextBox txtNilaib;
        private System.Windows.Forms.ComboBox cmbProses;
        private System.Windows.Forms.Button btnProses;
    }
}