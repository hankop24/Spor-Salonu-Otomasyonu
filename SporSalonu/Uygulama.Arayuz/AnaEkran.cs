using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uygulama.Arayuz
{
    public partial class AnaEkran : Form
    {
        public AnaEkran()
        {
            InitializeComponent();
        }

        #region Sayfa Açma İşlemleri
        private void btnAntrenor_Click(object sender, EventArgs e)
        {
            flpEkran.Controls.Clear();
            AntrenorEkran antrenorEkran = new AntrenorEkran();
            antrenorEkran.TopLevel = false;
            flpEkran.Controls.Add(antrenorEkran);
            antrenorEkran.Show();
        }

        private void btnUye_Click(object sender, EventArgs e)
        {
            flpEkran.Controls.Clear();
            UyeEkran uyeEkran = new UyeEkran();
            uyeEkran.TopLevel = false;
            flpEkran.Controls.Add(uyeEkran);
            uyeEkran.Show();
        }

        private void btnSpor_Click(object sender, EventArgs e)
        {
            flpEkran.Controls.Clear();
            SporTurEkran sporTurEkran = new SporTurEkran();
            sporTurEkran.TopLevel = false;
            flpEkran.Controls.Add(sporTurEkran); 
            sporTurEkran.Show();
        }

        private void lblKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region Buton hover işlemleri
        //Fare Giriş
        private void btnAntrenor_MouseEnter(object sender, EventArgs e)
        {
            FareGiris(btnAntrenor);
        }
        private void btnUye_MouseEnter(object sender, EventArgs e)
        {
            FareGiris(btnUye);
        }
        private void btnSpor_MouseEnter(object sender, EventArgs e)
        {
            FareGiris(btnSpor);
        }
       

        //Fare Çıkış
        private void btnAntrenor_MouseLeave(object sender, EventArgs e)
        {
            FareCikis(btnAntrenor);
        }
        private void btnUye_MouseLeave(object sender, EventArgs e)
        {
            FareCikis(btnUye);
        }
        private void btnSpor_MouseLeave(object sender, EventArgs e)
        {
            FareCikis(btnSpor);
        }
       

        private void FareGiris(Button btn)
        {
            btn.BackColor = Color.DarkRed;
            btn.ForeColor = Color.White;
        }
        private void FareCikis(Button btn)
        {
            btn.BackColor = Color.White;
            btn.ForeColor = Color.Black;
        }
        #endregion

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
