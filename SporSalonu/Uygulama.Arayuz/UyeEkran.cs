using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Uygulama.IsKatmani;
using Uygulama.Nesneler.Cagirma;
using Uygulama.Nesneler.Gonderme;

namespace Uygulama.Arayuz
{
    public partial class UyeEkran : Form
    {
        IKListelemeIslemleri IKListele;
        IKGondermeIslemleri IKGonderme;
        public UyeEkran()
        {
            InitializeComponent();
            IKListele = new IKListelemeIslemleri();
            IKGonderme = new IKGondermeIslemleri();
        }

        #region İşlemler
        private void UyeEkran_Load(object sender, EventArgs e)
        {

            EkranListele();

        }
        private void btnEkle_Click(object sender, EventArgs e)
        {

            SporlarListele spor = cmbSpor.SelectedItem as SporlarListele;
            AntrenorlerListele antrenor = cmbAntrenor.SelectedItem as AntrenorlerListele;
            UyelikTurleriListele uyelikTur = cmbUyelik.SelectedItem as UyelikTurleriListele;

            int sonuc = IKGonderme.UyelerEkle(txtAd.Text, txtSoyad.Text, txtEmail.Text, txtTelNo.Text, dtpDogumTarihi.Value, cmbCinsiyet.SelectedIndex, txtAdres.Text, antrenor, spor, uyelikTur);

            if (sonuc > 0)
            {
                MessageBox.Show("Üye Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                EkranListele();
                EkranTemizle();
            }
            else if (sonuc == -100)
            {
                MessageBox.Show("Lütfen Üye Bilgilerini Doldurunuz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Hata! İşlem Başarısız!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbSpor_SelectedIndexChanged(object sender, EventArgs e)
        {

            SporlarListele spor = (SporlarListele)cmbSpor.SelectedItem;
            List<AntrenorlerListele> antrenorler = IKListele.AntrenorlerTablosu();
            cmbAntrenor.Items.Clear();
            if (spor != null)
            {
                foreach (AntrenorlerListele item in antrenorler)
                {
                    if (item.Spor == spor.SporAdi)
                    {
                        cmbAntrenor.Items.Add(item);
                    }
                }
            }


        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            SporlarListele spor = cmbSpor.SelectedItem as SporlarListele;
            AntrenorlerListele antrenor = cmbAntrenor.SelectedItem as AntrenorlerListele;
            UyelikTurleriListele uyelikTurleri = cmbUyelik.SelectedItem as UyelikTurleriListele;
            int uyeID = Convert.ToInt32(txtAd.Tag);

            int sonuc = IKGonderme.UyelerGuncelle(uyeID, txtAd.Text, txtSoyad.Text, txtEmail.Text, txtTelNo.Text, dtpDogumTarihi.Value, cmbCinsiyet.SelectedIndex, txtAdres.Text, antrenor, spor, uyelikTurleri);
            if (sonuc > 0)
            {
                
                MessageBox.Show("Üye Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                EkranListele();
                EkranTemizle();
            }
            else if (sonuc == -100)
            {
                MessageBox.Show("Lütfen Üye Bilgilerini Doldurunuz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Hata! İşlem Başarısız!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult tercih = MessageBox.Show("Bu Üyeyi Silmek İstediğinize emin misiniz?", "Soru", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (tercih==DialogResult.Yes)
            {
                int id = Convert.ToInt32(dgvUyeler.CurrentRow.Cells["ID"].Value);
              int sonuc=  IKGonderme.UyelerSil(id);
                if (sonuc>0)
                {
                    MessageBox.Show("Üye Siliindi","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    EkranListele();
                }
                else
                {
                    MessageBox.Show("Hata! İşlem Başarısız", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
            
        }

        private void guncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
       
            btnKaydet.Enabled = true;

            string uyelikTurleriDeger = dgvUyeler.CurrentRow.Cells["UyelikTuru"].Value.ToString();
            int kontrolUyelikTuru = 0;
            foreach (var item in cmbUyelik.Items)
            {
                UyelikTurleriListele uyelikTur = (UyelikTurleriListele)item;
                if (uyelikTurleriDeger == uyelikTur.UyelikTuru)
                {
                    cmbUyelik.SelectedIndex = kontrolUyelikTuru;
                    break;
                }
                kontrolUyelikTuru++;
            }
     

            string degerSpor = dgvUyeler.CurrentRow.Cells["SporAdi"].Value.ToString();
            int kontrolSpor = 0;
            foreach (var item in cmbSpor.Items)
            {
                SporlarListele spor = (SporlarListele)item;
                if (degerSpor == spor.SporAdi)
                {
                    cmbSpor.SelectedIndex = kontrolSpor;
                    break;

                }
                kontrolSpor++;
            }


            string degerAntrenor = dgvUyeler.CurrentRow.Cells["AntrenorAdiSoyadi"].Value.ToString();
            int kontrolAntrenor = 0;
            foreach (var item in cmbAntrenor.Items)
            {
                AntrenorlerListele antrenor = (AntrenorlerListele)item;
                if (degerAntrenor == antrenor.Ad + " " + antrenor.Soyad)
                {
                    cmbAntrenor.SelectedIndex = kontrolAntrenor;
                    break;
                }
                kontrolAntrenor++;

            }

            txtAd.Text = dgvUyeler.CurrentRow.Cells["Ad"].Value.ToString();
            txtAd.Tag = dgvUyeler.CurrentRow.Cells["ID"].Value;
            txtSoyad.Text = dgvUyeler.CurrentRow.Cells["Soyad"].Value.ToString();
            txtEmail.Text = dgvUyeler.CurrentRow.Cells["Email"].Value.ToString();
            txtTelNo.Text = dgvUyeler.CurrentRow.Cells["TelNo"].Value.ToString();
            txtAdres.Text = dgvUyeler.CurrentRow.Cells["Adres"].Value.ToString();
            dtpDogumTarihi.Value = Convert.ToDateTime(dgvUyeler.CurrentRow.Cells["DogumTarihi"].Value);
            cmbCinsiyet.Text = dgvUyeler.CurrentRow.Cells["Cinsiyet"].Value.ToString();
        }
        #endregion

        #region Yardımcı İşlemler
        private void dgvUyeler_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {

            if (e.Button == MouseButtons.Right)
            {
                dgvUyeler.CurrentCell = dgvUyeler.Rows[e.RowIndex].Cells[e.ColumnIndex];

            }

        }

        private void lblTemizle_Click(object sender, EventArgs e)
        {
            EkranTemizle();
        }

        private void EkranTemizle()
        {
            int kontrol = 0;
        yavaslat:
            txtAd.Clear();
            txtSoyad.Clear();
            txtEmail.Clear();
            txtTelNo.Clear();
            txtAdres.Clear();
            cmbSpor.SelectedIndex = -1;
            cmbAntrenor.SelectedIndex = -1;
            btnKaydet.Enabled = false;

            cmbUyelik.SelectedIndex = -1;
            dtpDogumTarihi.Value = DateTime.Now;
            if (kontrol == 0)
            {
                kontrol++;
                goto yavaslat;

            }

        }

        private void EkranListele()
        {
            dgvUyeler.DataSource = IKListele.UyelerTablosu();
            dgvUyeler.Columns["ID"].Visible = false;
            dgvUyeler.Columns["AntrenorAdiSoyadi"].HeaderText = "Antrenor";


            cmbSpor.DataSource = IKListele.SporlarTablosu();
            cmbSpor.SelectedIndex = -1;

            cmbUyelik.DataSource = IKListele.UyelikTurleriTablosu();
            cmbUyelik.SelectedIndex = -1;

        }
        #endregion
    }
}
