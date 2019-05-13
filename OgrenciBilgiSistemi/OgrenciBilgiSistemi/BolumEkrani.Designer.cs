namespace OgrenciBilgiSistemi
{
    partial class BolumEkrani
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
            this.BolumName = new System.Windows.Forms.Label();
            this.HocaListesi = new System.Windows.Forms.ListBox();
            this.HocalarLabel = new System.Windows.Forms.Label();
            this.OgrenciListesi = new System.Windows.Forms.ListBox();
            this.OgrencilerLabel = new System.Windows.Forms.Label();
            this.DersListesi = new System.Windows.Forms.ListBox();
            this.DerslerLabel = new System.Windows.Forms.Label();
            this.OgrGorevliEkleButon = new System.Windows.Forms.Button();
            this.OgrGorevliSilButon = new System.Windows.Forms.Button();
            this.LOgrenciEkleButon = new System.Windows.Forms.Button();
            this.OgrenciSilButon = new System.Windows.Forms.Button();
            this.DersEkleButon = new System.Windows.Forms.Button();
            this.DersSilButon = new System.Windows.Forms.Button();
            this.OgrGorIsim = new System.Windows.Forms.TextBox();
            this.OgrGorSoyIsim = new System.Windows.Forms.TextBox();
            this.OgrGorBrans = new System.Windows.Forms.TextBox();
            this.OgrBolum = new System.Windows.Forms.TextBox();
            this.OgrSoyIsim = new System.Windows.Forms.TextBox();
            this.OgrIsim = new System.Windows.Forms.TextBox();
            this.OgrSube = new System.Windows.Forms.TextBox();
            this.OgrSinif = new System.Windows.Forms.TextBox();
            this.DersDonem = new System.Windows.Forms.TextBox();
            this.DersIsim = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.YLOgrenciEkleButon = new System.Windows.Forms.Button();
            this.DOgrenciEkleButon = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BolumName
            // 
            this.BolumName.AutoSize = true;
            this.BolumName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BolumName.Location = new System.Drawing.Point(21, 12);
            this.BolumName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.BolumName.Name = "BolumName";
            this.BolumName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BolumName.Size = new System.Drawing.Size(113, 26);
            this.BolumName.TabIndex = 2;
            this.BolumName.Text = "bolumIsmi";
            // 
            // HocaListesi
            // 
            this.HocaListesi.FormattingEnabled = true;
            this.HocaListesi.Location = new System.Drawing.Point(19, 72);
            this.HocaListesi.Name = "HocaListesi";
            this.HocaListesi.Size = new System.Drawing.Size(188, 69);
            this.HocaListesi.TabIndex = 7;
            // 
            // HocalarLabel
            // 
            this.HocalarLabel.AutoSize = true;
            this.HocalarLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.HocalarLabel.Location = new System.Drawing.Point(17, 48);
            this.HocalarLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.HocalarLabel.Name = "HocalarLabel";
            this.HocalarLabel.Size = new System.Drawing.Size(134, 20);
            this.HocalarLabel.TabIndex = 6;
            this.HocalarLabel.Text = "OgretimGorevlileri";
            // 
            // OgrenciListesi
            // 
            this.OgrenciListesi.FormattingEnabled = true;
            this.OgrenciListesi.Location = new System.Drawing.Point(226, 72);
            this.OgrenciListesi.Name = "OgrenciListesi";
            this.OgrenciListesi.Size = new System.Drawing.Size(188, 69);
            this.OgrenciListesi.TabIndex = 9;
            // 
            // OgrencilerLabel
            // 
            this.OgrencilerLabel.AutoSize = true;
            this.OgrencilerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.OgrencilerLabel.Location = new System.Drawing.Point(224, 48);
            this.OgrencilerLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.OgrencilerLabel.Name = "OgrencilerLabel";
            this.OgrencilerLabel.Size = new System.Drawing.Size(81, 20);
            this.OgrencilerLabel.TabIndex = 8;
            this.OgrencilerLabel.Text = "Ogrenciler";
            // 
            // DersListesi
            // 
            this.DersListesi.FormattingEnabled = true;
            this.DersListesi.Location = new System.Drawing.Point(439, 72);
            this.DersListesi.Name = "DersListesi";
            this.DersListesi.Size = new System.Drawing.Size(188, 69);
            this.DersListesi.TabIndex = 11;
            this.DersListesi.SelectedValueChanged += new System.EventHandler(DersListesi_SelectedValueChanged);
            // 
            // DerslerLabel
            // 
            this.DerslerLabel.AutoSize = true;
            this.DerslerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DerslerLabel.Location = new System.Drawing.Point(437, 48);
            this.DerslerLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.DerslerLabel.Name = "DerslerLabel";
            this.DerslerLabel.Size = new System.Drawing.Size(60, 20);
            this.DerslerLabel.TabIndex = 10;
            this.DerslerLabel.Text = "Dersler";
            // 
            // OgrGorevliEkleButon
            // 
            this.OgrGorevliEkleButon.Location = new System.Drawing.Point(125, 243);
            this.OgrGorevliEkleButon.Name = "OgrGorevliEkleButon";
            this.OgrGorevliEkleButon.Size = new System.Drawing.Size(75, 72);
            this.OgrGorevliEkleButon.TabIndex = 12;
            this.OgrGorevliEkleButon.Text = "OgrGor.Ekle";
            this.OgrGorevliEkleButon.UseVisualStyleBackColor = true;
            this.OgrGorevliEkleButon.Click += new System.EventHandler(this.OgrGorevliEkleButon_Click);
            // 
            // OgrGorevliSilButon
            // 
            this.OgrGorevliSilButon.Location = new System.Drawing.Point(21, 147);
            this.OgrGorevliSilButon.Name = "OgrGorevliSilButon";
            this.OgrGorevliSilButon.Size = new System.Drawing.Size(75, 23);
            this.OgrGorevliSilButon.TabIndex = 13;
            this.OgrGorevliSilButon.Text = "OgrGor.Sil";
            this.OgrGorevliSilButon.UseVisualStyleBackColor = true;
            this.OgrGorevliSilButon.Click += new System.EventHandler(this.OgrGorevliSilButon_Click);
            // 
            // LOgrenciEkleButon
            // 
            this.LOgrenciEkleButon.Location = new System.Drawing.Point(332, 200);
            this.LOgrenciEkleButon.Name = "LOgrenciEkleButon";
            this.LOgrenciEkleButon.Size = new System.Drawing.Size(79, 38);
            this.LOgrenciEkleButon.TabIndex = 14;
            this.LOgrenciEkleButon.Text = "LisansOgr Ekle";
            this.LOgrenciEkleButon.UseVisualStyleBackColor = true;
            this.LOgrenciEkleButon.Click += new System.EventHandler(this.LOgrenciEkleButon_Click);
            // 
            // OgrenciSilButon
            // 
            this.OgrenciSilButon.Location = new System.Drawing.Point(228, 147);
            this.OgrenciSilButon.Name = "OgrenciSilButon";
            this.OgrenciSilButon.Size = new System.Drawing.Size(75, 23);
            this.OgrenciSilButon.TabIndex = 15;
            this.OgrenciSilButon.Text = "Ogrenci Sil";
            this.OgrenciSilButon.UseVisualStyleBackColor = true;
            this.OgrenciSilButon.Click += new System.EventHandler(this.OgrenciSilButon_Click);
            // 
            // DersEkleButon
            // 
            this.DersEkleButon.Location = new System.Drawing.Point(547, 240);
            this.DersEkleButon.Name = "DersEkleButon";
            this.DersEkleButon.Size = new System.Drawing.Size(75, 50);
            this.DersEkleButon.TabIndex = 16;
            this.DersEkleButon.Text = "Ders Ekle";
            this.DersEkleButon.UseVisualStyleBackColor = true;
            this.DersEkleButon.Click += new System.EventHandler(this.DersEkleButon_Click);
            // 
            // DersSilButon
            // 
            this.DersSilButon.Location = new System.Drawing.Point(439, 147);
            this.DersSilButon.Name = "DersSilButon";
            this.DersSilButon.Size = new System.Drawing.Size(75, 20);
            this.DersSilButon.TabIndex = 17;
            this.DersSilButon.Text = "Ders Sil";
            this.DersSilButon.UseVisualStyleBackColor = true;
            this.DersSilButon.Click += new System.EventHandler(this.DersSilButon_Click);
            // 
            // OgrGorIsim
            // 
            this.OgrGorIsim.Location = new System.Drawing.Point(19, 244);
            this.OgrGorIsim.Name = "OgrGorIsim";
            this.OgrGorIsim.Size = new System.Drawing.Size(100, 20);
            this.OgrGorIsim.TabIndex = 18;
            // 
            // OgrGorSoyIsim
            // 
            this.OgrGorSoyIsim.Location = new System.Drawing.Point(19, 270);
            this.OgrGorSoyIsim.Name = "OgrGorSoyIsim";
            this.OgrGorSoyIsim.Size = new System.Drawing.Size(100, 20);
            this.OgrGorSoyIsim.TabIndex = 19;
            // 
            // OgrGorBrans
            // 
            this.OgrGorBrans.Location = new System.Drawing.Point(19, 296);
            this.OgrGorBrans.Name = "OgrGorBrans";
            this.OgrGorBrans.Size = new System.Drawing.Size(100, 20);
            this.OgrGorBrans.TabIndex = 20;
            // 
            // OgrBolum
            // 
            this.OgrBolum.Location = new System.Drawing.Point(226, 253);
            this.OgrBolum.Name = "OgrBolum";
            this.OgrBolum.Size = new System.Drawing.Size(100, 20);
            this.OgrBolum.TabIndex = 23;
            // 
            // OgrSoyIsim
            // 
            this.OgrSoyIsim.Location = new System.Drawing.Point(226, 227);
            this.OgrSoyIsim.Name = "OgrSoyIsim";
            this.OgrSoyIsim.Size = new System.Drawing.Size(100, 20);
            this.OgrSoyIsim.TabIndex = 22;
            // 
            // OgrIsim
            // 
            this.OgrIsim.Location = new System.Drawing.Point(226, 201);
            this.OgrIsim.Name = "OgrIsim";
            this.OgrIsim.Size = new System.Drawing.Size(100, 20);
            this.OgrIsim.TabIndex = 21;
            // 
            // OgrSube
            // 
            this.OgrSube.Location = new System.Drawing.Point(226, 305);
            this.OgrSube.Name = "OgrSube";
            this.OgrSube.Size = new System.Drawing.Size(100, 20);
            this.OgrSube.TabIndex = 25;
            // 
            // OgrSinif
            // 
            this.OgrSinif.Location = new System.Drawing.Point(226, 279);
            this.OgrSinif.Name = "OgrSinif";
            this.OgrSinif.Size = new System.Drawing.Size(100, 20);
            this.OgrSinif.TabIndex = 24;
            // 
            // DersDonem
            // 
            this.DersDonem.Location = new System.Drawing.Point(441, 269);
            this.DersDonem.Name = "DersDonem";
            this.DersDonem.Size = new System.Drawing.Size(100, 20);
            this.DersDonem.TabIndex = 27;
            // 
            // DersIsim
            // 
            this.DersIsim.Location = new System.Drawing.Point(441, 243);
            this.DersIsim.Name = "DersIsim";
            this.DersIsim.Size = new System.Drawing.Size(100, 20);
            this.DersIsim.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 208);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "Sirayla isim, soyisim, brans";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(225, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(211, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "Sirayla isim, soyisim, bolum, sinif, sube(char)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(436, 225);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 30;
            this.label3.Text = "Sirayla isim, donem";
            // 
            // YLOgrenciEkleButon
            // 
            this.YLOgrenciEkleButon.Location = new System.Drawing.Point(335, 241);
            this.YLOgrenciEkleButon.Name = "YLOgrenciEkleButon";
            this.YLOgrenciEkleButon.Size = new System.Drawing.Size(79, 38);
            this.YLOgrenciEkleButon.TabIndex = 32;
            this.YLOgrenciEkleButon.Text = "LYOgr Ekle";
            this.YLOgrenciEkleButon.UseVisualStyleBackColor = true;
            this.YLOgrenciEkleButon.Click += new System.EventHandler(this.YLOgrenciEkleButon_Click);
            // 
            // DOgrenciEkleButon
            // 
            this.DOgrenciEkleButon.Location = new System.Drawing.Point(335, 285);
            this.DOgrenciEkleButon.Name = "DOgrenciEkleButon";
            this.DOgrenciEkleButon.Size = new System.Drawing.Size(79, 38);
            this.DOgrenciEkleButon.TabIndex = 33;
            this.DOgrenciEkleButon.Text = "DoktoraOgr Ekle";
            this.DOgrenciEkleButon.UseVisualStyleBackColor = true;
            this.DOgrenciEkleButon.Click += new System.EventHandler(this.DOgrenciEkleButon_Click);
            // 
            // BolumEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 361);
            this.Controls.Add(this.DOgrenciEkleButon);
            this.Controls.Add(this.YLOgrenciEkleButon);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DersDonem);
            this.Controls.Add(this.DersIsim);
            this.Controls.Add(this.OgrSube);
            this.Controls.Add(this.OgrSinif);
            this.Controls.Add(this.OgrBolum);
            this.Controls.Add(this.OgrSoyIsim);
            this.Controls.Add(this.OgrIsim);
            this.Controls.Add(this.OgrGorBrans);
            this.Controls.Add(this.OgrGorSoyIsim);
            this.Controls.Add(this.OgrGorIsim);
            this.Controls.Add(this.DersSilButon);
            this.Controls.Add(this.DersEkleButon);
            this.Controls.Add(this.OgrenciSilButon);
            this.Controls.Add(this.LOgrenciEkleButon);
            this.Controls.Add(this.OgrGorevliSilButon);
            this.Controls.Add(this.OgrGorevliEkleButon);
            this.Controls.Add(this.DersListesi);
            this.Controls.Add(this.DerslerLabel);
            this.Controls.Add(this.OgrenciListesi);
            this.Controls.Add(this.OgrencilerLabel);
            this.Controls.Add(this.HocaListesi);
            this.Controls.Add(this.HocalarLabel);
            this.Controls.Add(this.BolumName);
            this.Name = "BolumEkrani";
            this.Text = "BolumEkrani";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label BolumName;
        private System.Windows.Forms.ListBox HocaListesi;
        private System.Windows.Forms.Label HocalarLabel;
        private System.Windows.Forms.ListBox OgrenciListesi;
        private System.Windows.Forms.Label OgrencilerLabel;
        private System.Windows.Forms.ListBox DersListesi;
        private System.Windows.Forms.Label DerslerLabel;
        private System.Windows.Forms.Button OgrGorevliEkleButon;
        private System.Windows.Forms.Button OgrGorevliSilButon;
        private System.Windows.Forms.Button LOgrenciEkleButon;
        private System.Windows.Forms.Button OgrenciSilButon;
        private System.Windows.Forms.Button DersEkleButon;
        private System.Windows.Forms.Button DersSilButon;
        private System.Windows.Forms.TextBox OgrGorIsim;
        private System.Windows.Forms.TextBox OgrGorSoyIsim;
        private System.Windows.Forms.TextBox OgrGorBrans;
        private System.Windows.Forms.TextBox OgrBolum;
        private System.Windows.Forms.TextBox OgrSoyIsim;
        private System.Windows.Forms.TextBox OgrIsim;
        private System.Windows.Forms.TextBox OgrSube;
        private System.Windows.Forms.TextBox OgrSinif;
        private System.Windows.Forms.TextBox DersDonem;
        private System.Windows.Forms.TextBox DersIsim;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button YLOgrenciEkleButon;
        private System.Windows.Forms.Button DOgrenciEkleButon;
    }
}