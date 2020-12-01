
namespace Soru_3
{
    partial class Form1
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
            this.buttonKoordinat = new System.Windows.Forms.Button();
            this.buttonHesapla = new System.Windows.Forms.Button();
            this.textBoxX = new System.Windows.Forms.TextBox();
            this.textBoxY = new System.Windows.Forms.TextBox();
            this.labelX = new System.Windows.Forms.Label();
            this.labelY = new System.Windows.Forms.Label();
            this.listBoxDegerler = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // buttonKoordinat
            // 
            this.buttonKoordinat.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonKoordinat.Location = new System.Drawing.Point(124, 243);
            this.buttonKoordinat.Name = "buttonKoordinat";
            this.buttonKoordinat.Size = new System.Drawing.Size(152, 59);
            this.buttonKoordinat.TabIndex = 4;
            this.buttonKoordinat.Text = "KOORDİNAT GİR";
            this.buttonKoordinat.UseVisualStyleBackColor = true;
            this.buttonKoordinat.Click += new System.EventHandler(this.buttonKoordinat_Click);
            // 
            // buttonHesapla
            // 
            this.buttonHesapla.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonHesapla.Location = new System.Drawing.Point(140, 333);
            this.buttonHesapla.Name = "buttonHesapla";
            this.buttonHesapla.Size = new System.Drawing.Size(118, 34);
            this.buttonHesapla.TabIndex = 5;
            this.buttonHesapla.Text = "HESAPLA";
            this.buttonHesapla.UseVisualStyleBackColor = true;
            this.buttonHesapla.Click += new System.EventHandler(this.buttonHesapla_Click);
            // 
            // textBoxX
            // 
            this.textBoxX.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxX.Location = new System.Drawing.Point(207, 83);
            this.textBoxX.Name = "textBoxX";
            this.textBoxX.Size = new System.Drawing.Size(125, 28);
            this.textBoxX.TabIndex = 0;
            // 
            // textBoxY
            // 
            this.textBoxY.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxY.Location = new System.Drawing.Point(207, 170);
            this.textBoxY.Name = "textBoxY";
            this.textBoxY.Size = new System.Drawing.Size(125, 28);
            this.textBoxY.TabIndex = 1;
            // 
            // labelX
            // 
            this.labelX.AutoSize = true;
            this.labelX.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelX.Location = new System.Drawing.Point(45, 83);
            this.labelX.Name = "labelX";
            this.labelX.Size = new System.Drawing.Size(121, 22);
            this.labelX.TabIndex = 2;
            this.labelX.Text = "X Koordinatı:";
            // 
            // labelY
            // 
            this.labelY.AutoSize = true;
            this.labelY.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelY.Location = new System.Drawing.Point(46, 173);
            this.labelY.Name = "labelY";
            this.labelY.Size = new System.Drawing.Size(120, 22);
            this.labelY.TabIndex = 3;
            this.labelY.Text = "Y Koordinatı:";
            // 
            // listBoxDegerler
            // 
            this.listBoxDegerler.FormattingEnabled = true;
            this.listBoxDegerler.ItemHeight = 16;
            this.listBoxDegerler.Location = new System.Drawing.Point(388, 114);
            this.listBoxDegerler.Name = "listBoxDegerler";
            this.listBoxDegerler.Size = new System.Drawing.Size(120, 84);
            this.listBoxDegerler.TabIndex = 6;
            this.listBoxDegerler.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 453);
            this.Controls.Add(this.listBoxDegerler);
            this.Controls.Add(this.buttonHesapla);
            this.Controls.Add(this.buttonKoordinat);
            this.Controls.Add(this.labelY);
            this.Controls.Add(this.labelX);
            this.Controls.Add(this.textBoxY);
            this.Controls.Add(this.textBoxX);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonKoordinat;
        private System.Windows.Forms.Button buttonHesapla;
        private System.Windows.Forms.TextBox textBoxX;
        private System.Windows.Forms.TextBox textBoxY;
        private System.Windows.Forms.Label labelX;
        private System.Windows.Forms.Label labelY;
        private System.Windows.Forms.ListBox listBoxDegerler;
    }
}

