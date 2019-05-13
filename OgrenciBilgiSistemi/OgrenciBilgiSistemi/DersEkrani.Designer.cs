namespace OgrenciBilgiSistemi
{
    partial class DersEkrani
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
            this.DersName = new System.Windows.Forms.Label();
            this.DersListesi = new System.Windows.Forms.ListBox();
            this.DerslerLabel = new System.Windows.Forms.Label();
            this.OgrenciListesi = new System.Windows.Forms.ListBox();
            this.OgrencilerLabel = new System.Windows.Forms.Label();
            this.HocaListesi = new System.Windows.Forms.ListBox();
            this.HocalarLabel = new System.Windows.Forms.Label();
            this.JsonKaydetButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DersName
            // 
            this.DersName.AutoSize = true;
            this.DersName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DersName.Location = new System.Drawing.Point(21, 24);
            this.DersName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.DersName.Name = "DersName";
            this.DersName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.DersName.Size = new System.Drawing.Size(95, 26);
            this.DersName.TabIndex = 3;
            this.DersName.Text = "dersIsmi";
            // 
            // DersListesi
            // 
            this.DersListesi.FormattingEnabled = true;
            this.DersListesi.Location = new System.Drawing.Point(448, 100);
            this.DersListesi.Name = "DersListesi";
            this.DersListesi.Size = new System.Drawing.Size(188, 69);
            this.DersListesi.TabIndex = 17;
            // 
            // DerslerLabel
            // 
            this.DerslerLabel.AutoSize = true;
            this.DerslerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DerslerLabel.Location = new System.Drawing.Point(446, 76);
            this.DerslerLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.DerslerLabel.Name = "DerslerLabel";
            this.DerslerLabel.Size = new System.Drawing.Size(60, 20);
            this.DerslerLabel.TabIndex = 16;
            this.DerslerLabel.Text = "Dersler";
            // 
            // OgrenciListesi
            // 
            this.OgrenciListesi.FormattingEnabled = true;
            this.OgrenciListesi.Location = new System.Drawing.Point(235, 100);
            this.OgrenciListesi.Name = "OgrenciListesi";
            this.OgrenciListesi.Size = new System.Drawing.Size(188, 69);
            this.OgrenciListesi.TabIndex = 15;
            // 
            // OgrencilerLabel
            // 
            this.OgrencilerLabel.AutoSize = true;
            this.OgrencilerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.OgrencilerLabel.Location = new System.Drawing.Point(233, 76);
            this.OgrencilerLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.OgrencilerLabel.Name = "OgrencilerLabel";
            this.OgrencilerLabel.Size = new System.Drawing.Size(81, 20);
            this.OgrencilerLabel.TabIndex = 14;
            this.OgrencilerLabel.Text = "Ogrenciler";
            // 
            // HocaListesi
            // 
            this.HocaListesi.FormattingEnabled = true;
            this.HocaListesi.Location = new System.Drawing.Point(28, 100);
            this.HocaListesi.Name = "HocaListesi";
            this.HocaListesi.Size = new System.Drawing.Size(188, 69);
            this.HocaListesi.TabIndex = 13;
            // 
            // HocalarLabel
            // 
            this.HocalarLabel.AutoSize = true;
            this.HocalarLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.HocalarLabel.Location = new System.Drawing.Point(26, 76);
            this.HocalarLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.HocalarLabel.Name = "HocalarLabel";
            this.HocalarLabel.Size = new System.Drawing.Size(134, 20);
            this.HocalarLabel.TabIndex = 12;
            this.HocalarLabel.Text = "OgretimGorevlileri";
            // 
            // JsonKaydetButton
            // 
            this.JsonKaydetButton.Location = new System.Drawing.Point(21, 241);
            this.JsonKaydetButton.Name = "JsonKaydetButton";
            this.JsonKaydetButton.Size = new System.Drawing.Size(108, 54);
            this.JsonKaydetButton.TabIndex = 18;
            this.JsonKaydetButton.Text = "JSON\'a kaydet";
            this.JsonKaydetButton.UseVisualStyleBackColor = true;
            this.JsonKaydetButton.Click += new System.EventHandler(this.JsonKaydetButton_Click);
            // 
            // DersEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 361);
            this.Controls.Add(this.JsonKaydetButton);
            this.Controls.Add(this.DersListesi);
            this.Controls.Add(this.DerslerLabel);
            this.Controls.Add(this.OgrenciListesi);
            this.Controls.Add(this.OgrencilerLabel);
            this.Controls.Add(this.HocaListesi);
            this.Controls.Add(this.HocalarLabel);
            this.Controls.Add(this.DersName);
            this.Name = "DersEkrani";
            this.Text = "DersEkrani";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label DersName;
        private System.Windows.Forms.ListBox DersListesi;
        private System.Windows.Forms.Label DerslerLabel;
        private System.Windows.Forms.ListBox OgrenciListesi;
        private System.Windows.Forms.Label OgrencilerLabel;
        private System.Windows.Forms.ListBox HocaListesi;
        private System.Windows.Forms.Label HocalarLabel;
        private System.Windows.Forms.Button JsonKaydetButton;
    }
}