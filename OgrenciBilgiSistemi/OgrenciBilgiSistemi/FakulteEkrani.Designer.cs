namespace OgrenciBilgiSistemi
{
    partial class FakulteEkrani
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
            this.FakulteName = new System.Windows.Forms.Label();
            this.bolumListesi = new System.Windows.Forms.ListBox();
            this.bolumlerLabel = new System.Windows.Forms.Label();
            this.bolumLabel = new System.Windows.Forms.Label();
            this.BolumToSave = new System.Windows.Forms.TextBox();
            this.BolumEkleButonu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FakulteName
            // 
            this.FakulteName.AutoSize = true;
            this.FakulteName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FakulteName.Location = new System.Drawing.Point(57, 29);
            this.FakulteName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.FakulteName.Name = "FakulteName";
            this.FakulteName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.FakulteName.Size = new System.Drawing.Size(117, 26);
            this.FakulteName.TabIndex = 1;
            this.FakulteName.Text = "fakulteIsmi";
            // 
            // bolumListesi
            // 
            this.bolumListesi.FormattingEnabled = true;
            this.bolumListesi.Location = new System.Drawing.Point(57, 127);
            this.bolumListesi.Name = "bolumListesi";
            this.bolumListesi.Size = new System.Drawing.Size(120, 95);
            this.bolumListesi.TabIndex = 5;
            this.bolumListesi.SelectedValueChanged += new System.EventHandler(bolumListesi_SelectedValueChanged);
            // 
            // bolumlerLabel
            // 
            this.bolumlerLabel.AutoSize = true;
            this.bolumlerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bolumlerLabel.Location = new System.Drawing.Point(55, 103);
            this.bolumlerLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.bolumlerLabel.Name = "bolumlerLabel";
            this.bolumlerLabel.Size = new System.Drawing.Size(71, 20);
            this.bolumlerLabel.TabIndex = 4;
            this.bolumlerLabel.Text = "Bolumler";
            // 
            // bolumLabel
            // 
            this.bolumLabel.AutoSize = true;
            this.bolumLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bolumLabel.Location = new System.Drawing.Point(241, 103);
            this.bolumLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.bolumLabel.Name = "bolumLabel";
            this.bolumLabel.Size = new System.Drawing.Size(87, 20);
            this.bolumLabel.TabIndex = 9;
            this.bolumLabel.Text = "Bolum İsim";
            // 
            // BolumToSave
            // 
            this.BolumToSave.Location = new System.Drawing.Point(245, 126);
            this.BolumToSave.Name = "BolumToSave";
            this.BolumToSave.Size = new System.Drawing.Size(100, 20);
            this.BolumToSave.TabIndex = 8;
            // 
            // BolumEkleButonu
            // 
            this.BolumEkleButonu.Location = new System.Drawing.Point(245, 152);
            this.BolumEkleButonu.Name = "BolumEkleButonu";
            this.BolumEkleButonu.Size = new System.Drawing.Size(75, 23);
            this.BolumEkleButonu.TabIndex = 7;
            this.BolumEkleButonu.Text = "Bolum Ekle";
            this.BolumEkleButonu.UseVisualStyleBackColor = true;
            this.BolumEkleButonu.Click += new System.EventHandler(this.BolumEkleButonu_Click);
            // 
            // FakulteEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 361);
            this.Controls.Add(this.bolumLabel);
            this.Controls.Add(this.BolumToSave);
            this.Controls.Add(this.BolumEkleButonu);
            this.Controls.Add(this.bolumListesi);
            this.Controls.Add(this.bolumlerLabel);
            this.Controls.Add(this.FakulteName);
            this.Name = "FakulteEkrani";
            this.Text = "FakulteEkrani";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label FakulteName;
        private System.Windows.Forms.ListBox bolumListesi;
        private System.Windows.Forms.Label bolumlerLabel;
        private System.Windows.Forms.Label bolumLabel;
        private System.Windows.Forms.TextBox BolumToSave;
        private System.Windows.Forms.Button BolumEkleButonu;
    }
}