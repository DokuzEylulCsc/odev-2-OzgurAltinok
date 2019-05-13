namespace OgrenciBilgiSistemi
{
    partial class UniversiteEkrani
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
            this.uniName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.fakulteListesi = new System.Windows.Forms.ListBox();
            this.FakulteEkleButonu = new System.Windows.Forms.Button();
            this.FakulteToSave = new System.Windows.Forms.TextBox();
            this.fakulteLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // uniName
            // 
            this.uniName.AutoSize = true;
            this.uniName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.uniName.Location = new System.Drawing.Point(11, 9);
            this.uniName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.uniName.Name = "uniName";
            this.uniName.Size = new System.Drawing.Size(247, 26);
            this.uniName.TabIndex = 1;
            this.uniName.Text = "Dokuz Eylul Universitesi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(11, 122);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Fakulteler";
            // 
            // fakulteListesi
            // 
            this.fakulteListesi.FormattingEnabled = true;
            this.fakulteListesi.Location = new System.Drawing.Point(13, 146);
            this.fakulteListesi.Name = "fakulteListesi";
            this.fakulteListesi.Size = new System.Drawing.Size(120, 95);
            this.fakulteListesi.TabIndex = 3;
            this.fakulteListesi.SelectedValueChanged += new System.EventHandler(this.fakulteListesi_SelectedValueChanged);
            // 
            // FakulteEkleButonu
            // 
            this.FakulteEkleButonu.Location = new System.Drawing.Point(203, 172);
            this.FakulteEkleButonu.Name = "FakulteEkleButonu";
            this.FakulteEkleButonu.Size = new System.Drawing.Size(75, 23);
            this.FakulteEkleButonu.TabIndex = 4;
            this.FakulteEkleButonu.Text = "Fakulte Ekle";
            this.FakulteEkleButonu.UseVisualStyleBackColor = true;
            this.FakulteEkleButonu.Click += new System.EventHandler(this.FakulteEkleButonu_Click);
            // 
            // FakulteToSave
            // 
            this.FakulteToSave.Location = new System.Drawing.Point(203, 146);
            this.FakulteToSave.Name = "FakulteToSave";
            this.FakulteToSave.Size = new System.Drawing.Size(100, 20);
            this.FakulteToSave.TabIndex = 5;
            // 
            // fakulteLabel
            // 
            this.fakulteLabel.AutoSize = true;
            this.fakulteLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.fakulteLabel.Location = new System.Drawing.Point(199, 123);
            this.fakulteLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.fakulteLabel.Name = "fakulteLabel";
            this.fakulteLabel.Size = new System.Drawing.Size(95, 20);
            this.fakulteLabel.TabIndex = 6;
            this.fakulteLabel.Text = "Fakulte İsim";
            // 
            // UniversiteEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 361);
            this.Controls.Add(this.fakulteLabel);
            this.Controls.Add(this.FakulteToSave);
            this.Controls.Add(this.FakulteEkleButonu);
            this.Controls.Add(this.fakulteListesi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.uniName);
            this.Name = "UniversiteEkrani";
            this.Text = "UniversiteEkrani";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label uniName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox fakulteListesi;
        private System.Windows.Forms.Button FakulteEkleButonu;
        private System.Windows.Forms.TextBox FakulteToSave;
        private System.Windows.Forms.Label fakulteLabel;
    }
}