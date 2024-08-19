using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DAL;

namespace PersonelTakipOto
{
    public partial class FrmPozisyonBilgileri : Form
    {
        public FrmPozisyonBilgileri()
        {
            InitializeComponent();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (TxtPozisyonAd.Text.Trim() == " ")
                MessageBox.Show("Pozisyon adını giriniz");
            else if (cmbDepartman.SelectedIndex == -1)
                MessageBox.Show("Departman seçiniz");
            else
            {
                POZISYON pz = new POZISYON();
                pz.PozisyonAd = TxtPozisyonAd.Text;
                pz.DepartmanID = Convert.ToInt32(cmbDepartman.SelectedValue);
                PozisyonBLL.PozisyonEkle(pz);
                MessageBox.Show("Pozisyon eklendi");
                TxtPozisyonAd.Clear();
                cmbDepartman.SelectedIndex = -1;



            }



        }
        List<DEPARTMAN> departmanlar = new List<DEPARTMAN>();
        private void FrmPozisyonBilgileri_Load(object sender, EventArgs e)
        {
            departmanlar=DAL.DAO.DepartmanDAO.DepartmanGetir();
            cmbDepartman.DataSource = departmanlar;
            cmbDepartman.DisplayMember = "DepartmanAd";
            cmbDepartman.ValueMember = "ID";
            cmbDepartman.SelectedIndex = -1;
        }
    }
}
