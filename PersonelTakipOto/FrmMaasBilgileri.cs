﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL.DTO;
using BLL;
using DAL;
using System.Diagnostics.Eventing.Reader;

namespace PersonelTakipOto
{
    public partial class FrmMaasBilgileri : Form
    {
        public FrmMaasBilgileri()
        {
            InitializeComponent();
        }
        MaasDTO dto = new MaasDTO();
        private bool combofull;
        public bool isUpdate = false;
        public MaasDetayDTO detay = new MaasDetayDTO();

        private void FrmMaasBilgileri_Load(object sender, EventArgs e)
        {
            dto = MaasBLL.GetAll();
            dataGridView1.DataSource = dto.Personeller;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].HeaderText = "User No";
            dataGridView1.Columns[2].HeaderText = "Ad";
            dataGridView1.Columns[3].HeaderText = "Soyad";
            dataGridView1.Columns[4].Visible = false;
            dataGridView1.Columns[5].Visible = false;
            dataGridView1.Columns[6].Visible = false;
            dataGridView1.Columns[7].Visible = false;
            dataGridView1.Columns[8].Visible = false;
            dataGridView1.Columns[9].Visible = false;
            dataGridView1.Columns[10].Visible = false;
            dataGridView1.Columns[11].Visible = false;
            dataGridView1.Columns[12].Visible = false;
            dataGridView1.Columns[13].Visible = false;


            cmbDepartman.DataSource = dto.Departmanlar;
            cmbDepartman.DisplayMember = "DepartmanAd";
            cmbDepartman.ValueMember = "ID";
            cmbDepartman.SelectedIndex = -1;
            if (dto.Departmanlar.Count > 0)
                combofull = true;
            cmbPozisyon.DataSource = dto.Pozisyonlar;
            cmbPozisyon.DisplayMember = "PozisyonAd";
            cmbPozisyon.ValueMember = "ID";
            cmbPozisyon.SelectedIndex = -1;
            cmbAylar.DataSource = dto.Aylar;
            cmbAylar.DisplayMember = "Ay";
            cmbAylar.ValueMember = "ID";
            cmbAylar.SelectedIndex = -1;
            txtYil.Text = DateTime.Today.Year.ToString();
            if (isUpdate)
            {
              maas.PersonelID = detay.PersoneID;
                txtAd.Text = detay.Ad;
                txtSoyad.Text = detay.Soyad;
                txtMaas.Text = detay.MaasMiktar.ToString();
                txtYil.Text = detay.MaasYil.ToString();
                txtUserNo.Text = detay.UserNo.ToString();
                cmbAylar.SelectedValue = detay.MaasAyID;

            }

        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbDepartman_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (combofull)
            {
                int departmanID = Convert.ToInt32(cmbDepartman.SelectedValue);
                cmbPozisyon.DataSource = dto.Pozisyonlar.Where(x => x.DepartmanID == departmanID).ToList();

            }
        }
        MAA maas = new MAA();
        int maasmiktar = 0;
        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (combofull)
            {

                maas.PersonelID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
                txtUserNo.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtAd.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtSoyad.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtMaas.Text = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
                maasmiktar = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[8].Value);

            }
        }
       
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (maas.PersonelID == 0)
                MessageBox.Show("PersonelSeç");
            else if (txtMaas.Text.Trim() == "")
                MessageBox.Show("Maas giriniz");
            else if (txtYil.Text.Trim() == "")
                MessageBox.Show("Yıl");
            else if (cmbAylar.SelectedIndex == -1)
                MessageBox.Show("Ay seçiniz");
            else
            {
                bool control = false;
                if (isUpdate)
                {
                    DialogResult result = MessageBox.Show("Emin misiniz ?", "DİKKAT", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        MaasDetayDTO maas = new MaasDetayDTO();
                        maas.MaasID = detay.MaasID;
                        maas.MaasAyID = Convert.ToInt32(cmbAylar.SelectedValue);
                        maas.MaasYil = Convert.ToInt32(txtYil.Text);
                        maas.EskiMaas = detay.MaasMiktar;
                        maas.PersoneID = detay.PersoneID;
                        maas.MaasMiktar = Convert.ToInt32(txtMaas.Text);

                        if (maas.MaasMiktar > maas.EskiMaas)
                            control = true;
                        MaasBLL.MaasGuncelle(maas, control);
                        MessageBox.Show("Maaş Güncellendi");
                        this.Close();
                    }

                }
                else
                {
                    if (Convert.ToInt32(txtMaas.Text) > maasmiktar)
                        control = true;


                    maas.Ay_ID = Convert.ToInt32(cmbAylar.SelectedValue);
                    maas.Miktar = Convert.ToInt32(txtMaas.Text);
                    maas.YIL = Convert.ToInt32(txtYil.Text);
                    MaasBLL.MaasEkle(maas, control);
                    MessageBox.Show("Maaş Eklendi");
                    txtMaas.Clear();
                    maas = new MAA();
                }
            }

        }
    }
}
