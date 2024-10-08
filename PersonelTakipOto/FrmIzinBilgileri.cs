﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL.DTO;
using DAL;
using BLL;
namespace PersonelTakipOto
{
    public partial class FrmIzinBilgileri : Form
    {
        public FrmIzinBilgileri()
        {
            InitializeComponent();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        TimeSpan sure = new TimeSpan();
        public bool isUpdate = false;
        public IzinDetayDTO detay = new IzinDetayDTO();
        private void FrmIzinBilgileri_Load(object sender, EventArgs e)
        {


            txtUserNo.Text = UserStatic.UserNo.ToString();
            if(isUpdate)
            {
                dbBaslama.Value = detay.BaslamaTarihi;
                dbBitis.Value = detay.BitisTarihi;
                txtSure.Text = detay.Sure.ToString();
                txtAciklama.Text = detay.Aciklama;
            }
        }

        private void dbBaslama_ValueChanged(object sender, EventArgs e)
        {
            sure = dbBitis.Value.Date - dbBaslama.Value.Date;
            txtSure.Text = sure.TotalDays.ToString();
        }

        private void dbBitis_ValueChanged(object sender, EventArgs e)
        {
            sure = dbBitis.Value.Date - dbBaslama.Value.Date;
            txtSure.Text = sure.TotalDays.ToString();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (txtSure.Text.Trim() == "")
                MessageBox.Show("Süre Boş");
            else if (Convert.ToInt32(txtSure.Text) <= 0)
                MessageBox.Show("İzin süresi geçersiz");
            else if (txtAciklama.Text.Trim() == "")
            {

                MessageBox.Show("Lütfen açıklama giriniz");
            }
            else
            {


                if (isUpdate)
                {
                    DialogResult result = MessageBox.Show("Emin misiniz?", "DİKKAT", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        IzinDetayDTO detaydto = new IzinDetayDTO();
                        detaydto.IzinID = detay.IzinID;
                        detaydto.Aciklama = txtAciklama.Text;
                        detaydto.Sure = Convert.ToInt32(txtSure.Text);
                        detaydto.BaslamaTarihi = dbBaslama.Value;
                        detaydto.BitisTarihi = dbBitis.Value;
                        IzinBLL.IzinGuncelle(detaydto);
                        MessageBox.Show("Güncellendi");
                        this.Close();




                    }


                }
                else
                {
                    IZIN iz = new IZIN();
                    iz.PersonelID = UserStatic.PersonelID;
                    iz.IzinDurumID = 1;
                    iz.IzinBaslamaTarihi = dbBaslama.Value;
                    iz.IzinBitisTarihi = dbBitis.Value;
                    iz.Sure = Convert.ToInt32(sure.TotalDays);
                    iz.Acıklama = txtAciklama.Text;
                    IzinBLL.IzinEkle(iz);
                    MessageBox.Show("İzin eklendi");
                    dbBaslama.Value = DateTime.Today;
                    dbBitis.Value = DateTime.Today;
                    txtSure.Clear();
                    txtAciklama.Clear();

                }
            }
        }
    }
}
