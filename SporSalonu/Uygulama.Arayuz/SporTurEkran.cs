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
    public partial class SporTurEkran : Form
    {
        IKListelemeIslemleri IKListele;
        IKGondermeIslemleri IKGonder;
        public SporTurEkran()
        {
            InitializeComponent();
            IKListele = new IKListelemeIslemleri();
            IKGonder = new IKGondermeIslemleri();
        }

        private void SporTurEkran_Load(object sender, EventArgs e)
        {
            EkranListele();
        }


        #region Spor Işlemleri
        private void btnEkle_Click(object sender, EventArgs e)
        {

            int sonuc = IKGonder.SporlarEkle(txtSporAdi.Text, txtSporTuru.Text, numAylikFiyat.Value);
            if (sonuc > 0)
            {
                MessageBox.Show("Spor Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                EkranListele();
            }
            else if (sonuc == -100)
            {
                MessageBox.Show("Lütfen Spor Bilgilerini Doldurunuz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Hata! İşlem Başarısız!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult tercih = MessageBox.Show("Bu Sporu Silmek İstediğinize emin misiniz?", "Soru", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (tercih == DialogResult.Yes)
            {
                int id = Convert.ToInt32(dgvSporListesi.CurrentRow.Cells["SporID"].Value);
                int sonuc = IKGonder.SporlarSil(id);
                if (sonuc > 0)
                {
                    MessageBox.Show("Spor Siliindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    EkranListele();
                }
                else
                {
                    MessageBox.Show("Hata! İşlem Başarısız", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void lblSporTemizle_Click(object sender, EventArgs e)
        {
            SporEkranTemizle();
        }

        private void güncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnKaydet.Enabled = true;
            txtSporAdi.Text = dgvSporListesi.CurrentRow.Cells["SporAdi"].Value.ToString();
            txtSporAdi.Tag = dgvSporListesi.CurrentRow.Cells["SporID"].Value;
            txtSporTuru.Text = dgvSporListesi.CurrentRow.Cells["SporTuru"].Value.ToString();
            numAylikFiyat.Value = Convert.ToDecimal(dgvSporListesi.CurrentRow.Cells["AylikFiyat"].Value);
        }

        private void dgvSporListesi_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                dgvSporListesi.CurrentCell = dgvSporListesi.Rows[e.RowIndex].Cells[e.ColumnIndex];

            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            int sonuc = IKGonder.SporlarGuncelle(Convert.ToInt32(txtSporAdi.Tag), txtSporAdi.Text, txtSporTuru.Text, numAylikFiyat.Value);
            if (sonuc > 0)
            {
                MessageBox.Show("Spor Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                EkranListele();
                SporEkranTemizle();
            }
            else if (sonuc == -100)
            {
                MessageBox.Show("Lütfen Spor Bilgilerini Doldurunuz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Hata! İşlem Başarısız!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region UyelikTur İşlemleri
        private void btnUyelikTuruEkle_Click(object sender, EventArgs e)
        {

            int sonuc = IKGonder.UyelikTurleriEkle(txtUyelikTuru.Text, Convert.ToInt32(numIndirimMiktari.Value));

            if (sonuc > 0)
            {
                MessageBox.Show("Üyelik Türü Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                EkranListele();
                UyelikTurEkranTemizle();
            }
            else if (sonuc == -100)
            {
                MessageBox.Show("Lütfen Üyelik Türü Bilgilerini Doldurunuz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Hata! İşlem Başarısız!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUyelikTuruKaydet_Click(object sender, EventArgs e)
        {

           int sonuc = IKGonder.UyelikTurleriGuncelle(Convert.ToInt32(txtUyelikTuru.Tag), txtUyelikTuru.Text, Convert.ToInt32(numIndirimMiktari.Value));
            if (sonuc > 0)
            {
                MessageBox.Show("Üyelik Türü Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                EkranListele();
                UyelikTurEkranTemizle();
            }
            else if (sonuc == -100)
            {
                MessageBox.Show("Lütfen Üyelik Tür Bilgilerini Doldurunuz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Hata! İşlem Başarısız!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void btnUyelikTuruSil_Click(object sender, EventArgs e)
        {
            DialogResult tercih = MessageBox.Show("Bu Üyelik Türünü Silmek İstediğinize Emin Misiniz?", "Soru", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (tercih == DialogResult.Yes)
            {
                int id = Convert.ToInt32(txtUyelikTuru.Tag);
                int sonuc = IKGonder.UyelikTurleriSil(id);
                if (sonuc > 0)
                {
                    MessageBox.Show("Üyelik Türü Siliindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    EkranListele();
                }
                else
                {
                    MessageBox.Show("Hata! İşlem Başarısız", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void cmbUyelikTuru_SelectedIndexChanged(object sender, EventArgs e)
        {
            UyelikTurleriListele uyelikturu = (UyelikTurleriListele)cmbUyelikTuru.SelectedItem;
            if (uyelikturu != null)
            {
                txtUyelikTuru.Text = uyelikturu.UyelikTuru;
                txtUyelikTuru.Tag = uyelikturu.UyelikID;
                numIndirimMiktari.Value = uyelikturu.IndirimMiktari;
                btnUyelikTuruKaydet.Enabled = true;
                btnUyelikTuruSil.Enabled = true;
            }

        }

        private void lblUyelikTurTemizle_Click(object sender, EventArgs e)
        {
            UyelikTurEkranTemizle();
        }

        #endregion

        #region Yardımcı İşlemler
        private void EkranListele()
        {
            dgvSporListesi.DataSource = IKListele.SporlarTablosu();
            cmbUyelikTuru.DataSource = IKListele.UyelikTurleriTablosu();
            cmbUyelikTuru.SelectedIndex = -1;

        }

        private void SporEkranTemizle()
        {

            txtSporAdi.Clear();
            txtSporTuru.Clear();
            numAylikFiyat.Value = 0;
            btnKaydet.Enabled = false;
        }

        private void UyelikTurEkranTemizle()
        {
            txtUyelikTuru.Clear();
            numIndirimMiktari.Value = 0;
            btnUyelikTuruKaydet.Enabled = false;
            btnUyelikTuruSil.Enabled = false;
        }
        #endregion 

    }
}
