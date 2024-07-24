using EntityFramework_1.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityFramework_1
{
	public partial class Form1 : Form
	{

		NorthwindEntities _db; //Veritabanını instance almak için

		public Form1()
		{
			_db = new NorthwindEntities(); //instance alındı.
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			lstKategoriler.DataSource = _db.Categories.ToList();// listbox ın kaynağına kategorileri listeledi
			lstKategoriler.DisplayMember = "CategoryName"; //listbox ın displaymember diyerek istediğimiz sütun adını yazdık
			lstKategoriler.SelectedIndex = -1; //listelediğimizde seçili gelmesin
		}

		private void btnEkle_Click(object sender, EventArgs e)
		{
			Category c = new Category(); //Kategori classının instancını aldık.
			c.CategoryName = txtKategori.Text; //Kategori ismini textbox a atadık.
			c.Description = txtAciklama.Text; //Kategori açıklamasını TextBox a atadık.
			_db.Categories.Add(c); //Kategoriler classına ekleme yaptık
			_db.SaveChanges();  // Verileri kaydettik.
			_db.Categories.ToList(); //Verileri listeledik
		}
		Category secilen;
		private void lstKategoriler_Click(object sender, EventArgs e)
		{
			if (lstKategoriler.SelectedIndex > -1) { // Herhangi bir kategori  seçili ise

				secilen = lstKategoriler.SelectedItem as Category; //listbox tan seçili kategoriyi cast edip secilene atadık.
				txtKategori.Text = secilen.CategoryName; //Seçili kategori ismini TextBox ta gösterir.
				txtAciklama.Text = secilen.Description; //Seçili kategorinin açıklama kısmını TextBox ta gösterir.



			}
		}

		private void btnSil_Click(object sender, EventArgs e)
		{
			if (secilen != null) //secilen null değilse
			{

				_db.Categories.Remove(secilen); //seçilen kategori silindi.
				_db.SaveChanges(); //veritabanına kaydedildi.
				_db.Categories.ToList();//veriler listelendi.
				secilen = null; // seçilen null yapıldı..yoksa ram de kalır tekrar silmeye kalkarsak hata verir.
			}
			else {
				MessageBox.Show("Lütfen önce silmek istediğiniz kategoriyi seçiniz.");
			
			}
		}

		private void btnGuncelle_Click(object sender, EventArgs e)
		{
			if (secilen != null)
			{
				secilen.CategoryName = txtKategori.Text;//Kategori ismini yaz
				secilen.Description = txtAciklama.Text;//aciklama kısmını yaz
				_db.SaveChanges();//veriyi kaydet
				_db.Categories.ToList();//veriyi listele
			}
			else
			{
				MessageBox.Show("Lütfen güncellenecek veriyi seçiniz.");
			}
		}
	}
}
