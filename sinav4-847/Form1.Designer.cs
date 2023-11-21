namespace sinav4_847
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
            this.btnOlustur = new System.Windows.Forms.Button();
            this.lbSayilar1 = new System.Windows.Forms.ListBox();
            this.btnAktar = new System.Windows.Forms.Button();
            this.lbSayilar2 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnOlustur
            // 
            this.btnOlustur.Location = new System.Drawing.Point(34, 42);
            this.btnOlustur.Name = "btnOlustur";
            this.btnOlustur.Size = new System.Drawing.Size(128, 25);
            this.btnOlustur.TabIndex = 0;
            this.btnOlustur.Text = "20 adet sayı oluştur";
            this.btnOlustur.UseVisualStyleBackColor = true;
            this.btnOlustur.Click += new System.EventHandler(this.btnOlustur_Click);
            // 
            // lbSayilar1
            // 
            this.lbSayilar1.FormattingEnabled = true;
            this.lbSayilar1.Location = new System.Drawing.Point(34, 89);
            this.lbSayilar1.Name = "lbSayilar1";
            this.lbSayilar1.Size = new System.Drawing.Size(128, 238);
            this.lbSayilar1.TabIndex = 1;
            // 
            // btnAktar
            // 
            this.btnAktar.Location = new System.Drawing.Point(190, 181);
            this.btnAktar.Name = "btnAktar";
            this.btnAktar.Size = new System.Drawing.Size(123, 24);
            this.btnAktar.TabIndex = 2;
            this.btnAktar.Text = "50 - 70 arasını aktar";
            this.btnAktar.UseVisualStyleBackColor = true;
            this.btnAktar.Click += new System.EventHandler(this.btnAktar_Click);
            // 
            // lbSayilar2
            // 
            this.lbSayilar2.FormattingEnabled = true;
            this.lbSayilar2.Location = new System.Drawing.Point(347, 89);
            this.lbSayilar2.Name = "lbSayilar2";
            this.lbSayilar2.Size = new System.Drawing.Size(128, 238);
            this.lbSayilar2.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbSayilar2);
            this.Controls.Add(this.btnAktar);
            this.Controls.Add(this.lbSayilar1);
            this.Controls.Add(this.btnOlustur);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOlustur;
        private System.Windows.Forms.ListBox lbSayilar1;
        private System.Windows.Forms.Button btnAktar;
        private System.Windows.Forms.ListBox lbSayilar2;
    }
}

