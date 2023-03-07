namespace Project.WinUI
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
            this.lstBooks = new System.Windows.Forms.ListBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnGetPures = new System.Windows.Forms.Button();
            this.btnGetDeleteds = new System.Windows.Forms.Button();
            this.btnGetModifieds = new System.Windows.Forms.Button();
            this.txtIsim = new System.Windows.Forms.TextBox();
            this.btnKitapVeKategoriler = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstBooks
            // 
            this.lstBooks.FormattingEnabled = true;
            this.lstBooks.ItemHeight = 16;
            this.lstBooks.Location = new System.Drawing.Point(446, 36);
            this.lstBooks.Name = "lstBooks";
            this.lstBooks.Size = new System.Drawing.Size(439, 468);
            this.lstBooks.TabIndex = 0;
            this.lstBooks.Click += new System.EventHandler(this.lstBooks_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(23, 187);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 23);
            this.btnEkle.TabIndex = 1;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(23, 243);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(75, 23);
            this.btnSil.TabIndex = 1;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(23, 308);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(75, 23);
            this.btnGuncelle.TabIndex = 1;
            this.btnGuncelle.Text = "Guncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnGetPures
            // 
            this.btnGetPures.Location = new System.Drawing.Point(33, 403);
            this.btnGetPures.Name = "btnGetPures";
            this.btnGetPures.Size = new System.Drawing.Size(103, 23);
            this.btnGetPures.TabIndex = 1;
            this.btnGetPures.Text = "Get Pures";
            this.btnGetPures.UseVisualStyleBackColor = true;
            this.btnGetPures.Click += new System.EventHandler(this.btnGetPures_Click);
            // 
            // btnGetDeleteds
            // 
            this.btnGetDeleteds.Location = new System.Drawing.Point(33, 443);
            this.btnGetDeleteds.Name = "btnGetDeleteds";
            this.btnGetDeleteds.Size = new System.Drawing.Size(103, 23);
            this.btnGetDeleteds.TabIndex = 1;
            this.btnGetDeleteds.Text = "Get Deleteds";
            this.btnGetDeleteds.UseVisualStyleBackColor = true;
            this.btnGetDeleteds.Click += new System.EventHandler(this.btnGetDeleteds_Click);
            // 
            // btnGetModifieds
            // 
            this.btnGetModifieds.Location = new System.Drawing.Point(33, 489);
            this.btnGetModifieds.Name = "btnGetModifieds";
            this.btnGetModifieds.Size = new System.Drawing.Size(103, 23);
            this.btnGetModifieds.TabIndex = 1;
            this.btnGetModifieds.Text = "Get ModiFieds";
            this.btnGetModifieds.UseVisualStyleBackColor = true;
            this.btnGetModifieds.Click += new System.EventHandler(this.btnGetModifieds_Click);
            // 
            // txtIsim
            // 
            this.txtIsim.Location = new System.Drawing.Point(33, 46);
            this.txtIsim.Name = "txtIsim";
            this.txtIsim.Size = new System.Drawing.Size(100, 22);
            this.txtIsim.TabIndex = 2;
            // 
            // btnKitapVeKategoriler
            // 
            this.btnKitapVeKategoriler.Location = new System.Drawing.Point(446, 532);
            this.btnKitapVeKategoriler.Name = "btnKitapVeKategoriler";
            this.btnKitapVeKategoriler.Size = new System.Drawing.Size(132, 23);
            this.btnKitapVeKategoriler.TabIndex = 3;
            this.btnKitapVeKategoriler.Text = "KitapVeKategoriler";
            this.btnKitapVeKategoriler.UseVisualStyleBackColor = true;
            this.btnKitapVeKategoriler.Click += new System.EventHandler(this.btnKitapVeKategoriler_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 603);
            this.Controls.Add(this.btnKitapVeKategoriler);
            this.Controls.Add(this.txtIsim);
            this.Controls.Add(this.btnGetModifieds);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnGetDeleteds);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnGetPures);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.lstBooks);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstBooks;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnGetPures;
        private System.Windows.Forms.Button btnGetDeleteds;
        private System.Windows.Forms.Button btnGetModifieds;
        private System.Windows.Forms.TextBox txtIsim;
        private System.Windows.Forms.Button btnKitapVeKategoriler;
    }
}

