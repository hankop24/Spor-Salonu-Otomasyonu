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

namespace Uygulama.Arayuz
{
    public partial class AntrenorEkran : Form
    {
        IKListelemeIslemleri IKListele;
        IKGondermeIslemleri IKGonder;
        public AntrenorEkran()
        {
            InitializeComponent();
            IKListele = new IKListelemeIslemleri();
            IKGonder = new IKGondermeIslemleri();
        }

        private void AntrenorEkran_Load(object sender, EventArgs e)
        {
            EkranListele();
        }

        #region İşlemler
        private void btnEkle_Click(object sender, EventArgs e)
        {
            SporlarListele spor = (SporlarListele)cmbAlani.SelectedItem;
           
            int sonuc = IKGonder.AntrenorlerEkle(txtAd.Text, txtSoyad.Text, txtEmail.Text, txtTelNo.Text, dtpDogumTarihi.Value, cmbCinsiyet.SelectedIndex, txtAdres.Text, spor.SporID, numMaas.Value);
            if (sonuc > 0)
            {
                MessageBox.Show("Antrenör Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                EkranListele();
                EkranTemizle();
            }
            else if (sonuc == -100)
            {
                MessageBox.Show("Lütfen Antrenör Bilgilerini Doldurunuz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Hata! İşlem Başarısız!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            SporlarListele sporlar = cmbAlani.SelectedItem as SporlarListele;
            int sonuc = IKGonder.AntrenorlerGuncelle(Convert.ToInt32(txtAd.Tag), txtAd.Text, txtSoyad.Text, txtEmail.Text, txtTelNo.Text, dtpDogumTarihi.Value, cmbCinsiyet.SelectedIndex, txtAdres.Text, sporlar, numMaas.Value);
            if (sonuc > 0)
            {
                MessageBox.Show("Antrenör Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                EkranListele();
                EkranTemizle();
            }
            else if (sonuc == -100)
            {
                MessageBox.Show("Lütfen Antrenör Bilgilerini Doldurunuz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Hata! İşlem Başarısız!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void güncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<SporlarListele> sporlar = IKListele.SporlarTablosu();
            string degerSpor = dgvAntrenorListesi.CurrentRow.Cells["Spor"].Value.ToString();
            btnKaydet.Enabled = true;
            for (int i = 0; i < sporlar.Count; i++)
            {
                if (sporlar[i].SporAdi == degerSpor)
                {
                    cmbAlani.SelectedIndex = sporlar[i].SporID - 1;
                    break;
                }
            }

            txtAd.Text = dgvAntrenorListesi.CurrentRow.Cells["Ad"].Value.ToString();
            txtAd.Tag = dgvAntrenorListesi.CurrentRow.Cells["AntrenorID"].Value;
            txtSoyad.Text = dgvAntrenorListesi.CurrentRow.Cells["Soyad"].Value.ToString();
            txtTelNo.Text = dgvAntrenorListesi.CurrentRow.Cells["TelNo"].Value.ToString();
            txtEmail.Text = dgvAntrenorListesi.CurrentRow.Cells["Email"].Value.ToString();
            txtAdres.Text = dgvAntrenorListesi.CurrentRow.Cells["Adres"].Value.ToString();
            dtpDogumTarihi.Value = Convert.ToDateTime(dgvAntrenorListesi.CurrentRow.Cells["DogumTarihi"].Value);
            cmbCinsiyet.Text = dgvAntrenorListesi.CurrentRow.Cells["Cinsiyet"].ToString();
            numMaas.Value = Convert.ToDecimal(dgvAntrenorListesi.CurrentRow.Cells["Maas"].Value);

        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult tercih = MessageBox.Show("Bu Antrenörü Silmek İstediğinize emin misiniz?", "Soru", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (tercih == DialogResult.Yes)
            {
                int id = Convert.ToInt32(dgvAntrenorListesi.CurrentRow.Cells["AntrenorID"].Value);
                int sonuc = IKGonder.AntrenorlerSil(id);
                if (sonuc > 0)
                {
                    MessageBox.Show("Antrenor Siliindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    EkranListele();
                }
                else
                {
                    MessageBox.Show("Hata! İşlem Başarısız", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }
        #endregion


        #region Yardımcı İşlemler
        private void lblTemizle_Click(object sender, EventArgs e)
        {
            EkranTemizle();
        }
        private void dgvAntrenorListesi_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                dgvAntrenorListesi.CurrentCell = dgvAntrenorListesi.Rows[e.RowIndex].Cells[e.ColumnIndex];

            }
        }

        private void EkranListele()
        {
            dgvAntrenorListesi.DataSource = IKListele.AntrenorlerTablosu();
            dgvAntrenorListesi.Columns["AntrenorID"].Visible = false;

            cmbAlani.DataSource = IKListele.SporlarTablosu();
            cmbAlani.SelectedIndex = -1;
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
            numMaas.ResetText();
            cmbAlani.SelectedIndex = -1;
            dtpDogumTarihi.Value = DateTime.Now;
            btnKaydet.Enabled = false;
            if (kontrol == 0)
            {
                kontrol++;
                goto yavaslat;

            }
        }
        #endregion


    }
}
