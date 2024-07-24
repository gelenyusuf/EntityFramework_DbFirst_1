
namespace EntityFramework_1
{
	partial class Form1
	{
		/// <summary>
		///Gerekli tasarımcı değişkeni.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///Kullanılan tüm kaynakları temizleyin.
		/// </summary>
		///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer üretilen kod

		/// <summary>
		/// Tasarımcı desteği için gerekli metot - bu metodun 
		///içeriğini kod düzenleyici ile değiştirmeyin.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtKategori = new System.Windows.Forms.TextBox();
			this.txtAciklama = new System.Windows.Forms.TextBox();
			this.lstKategoriler = new System.Windows.Forms.ListBox();
			this.btnEkle = new System.Windows.Forms.Button();
			this.btnSil = new System.Windows.Forms.Button();
			this.btnGuncelle = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(76, 61);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(85, 17);
			this.label1.TabIndex = 0;
			this.label1.Text = "Kategori Adı";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(97, 98);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(64, 17);
			this.label2.TabIndex = 1;
			this.label2.Text = "Açıklama";
			// 
			// txtKategori
			// 
			this.txtKategori.Location = new System.Drawing.Point(179, 61);
			this.txtKategori.Name = "txtKategori";
			this.txtKategori.Size = new System.Drawing.Size(100, 22);
			this.txtKategori.TabIndex = 2;
			// 
			// txtAciklama
			// 
			this.txtAciklama.Location = new System.Drawing.Point(179, 98);
			this.txtAciklama.Name = "txtAciklama";
			this.txtAciklama.Size = new System.Drawing.Size(100, 22);
			this.txtAciklama.TabIndex = 3;
			// 
			// lstKategoriler
			// 
			this.lstKategoriler.FormattingEnabled = true;
			this.lstKategoriler.ItemHeight = 16;
			this.lstKategoriler.Location = new System.Drawing.Point(313, 63);
			this.lstKategoriler.Name = "lstKategoriler";
			this.lstKategoriler.Size = new System.Drawing.Size(315, 292);
			this.lstKategoriler.TabIndex = 4;
			this.lstKategoriler.Click += new System.EventHandler(this.lstKategoriler_Click);
			// 
			// btnEkle
			// 
			this.btnEkle.Location = new System.Drawing.Point(179, 151);
			this.btnEkle.Name = "btnEkle";
			this.btnEkle.Size = new System.Drawing.Size(100, 42);
			this.btnEkle.TabIndex = 5;
			this.btnEkle.Text = "Ekle";
			this.btnEkle.UseVisualStyleBackColor = true;
			this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
			// 
			// btnSil
			// 
			this.btnSil.Location = new System.Drawing.Point(179, 219);
			this.btnSil.Name = "btnSil";
			this.btnSil.Size = new System.Drawing.Size(100, 42);
			this.btnSil.TabIndex = 6;
			this.btnSil.Text = "Sil";
			this.btnSil.UseVisualStyleBackColor = true;
			this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
			// 
			// btnGuncelle
			// 
			this.btnGuncelle.Location = new System.Drawing.Point(179, 290);
			this.btnGuncelle.Name = "btnGuncelle";
			this.btnGuncelle.Size = new System.Drawing.Size(100, 42);
			this.btnGuncelle.TabIndex = 7;
			this.btnGuncelle.Text = "Güncelle";
			this.btnGuncelle.UseVisualStyleBackColor = true;
			this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.btnGuncelle);
			this.Controls.Add(this.btnSil);
			this.Controls.Add(this.btnEkle);
			this.Controls.Add(this.lstKategoriler);
			this.Controls.Add(this.txtAciklama);
			this.Controls.Add(this.txtKategori);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtKategori;
		private System.Windows.Forms.TextBox txtAciklama;
		private System.Windows.Forms.ListBox lstKategoriler;
		private System.Windows.Forms.Button btnEkle;
		private System.Windows.Forms.Button btnSil;
		private System.Windows.Forms.Button btnGuncelle;
	}
}

