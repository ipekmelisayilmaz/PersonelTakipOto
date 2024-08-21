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
using DAL.DTO;

namespace PersonelTakipOto
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void txtUserNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar)&& !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtUserNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            if (txtUserNo.Text.Trim() == "")
                MessageBox.Show("Kullanıcı No Boş");
            else if (txtPassword.Text.Trim() == "")
                MessageBox.Show("Şifre boş");
            else
            {
                List<PERSONEL> list = PersonelBLL.PersonelGetir(Convert.ToInt32(txtUserNo.Text), txtPassword.Text);
                if (list.Count <= 0)
                    MessageBox.Show("Kullanıcı adı veya şifre hatalı");
                else
                {
                    PERSONEL per = list.First();
                    UserStatic.PersonelID = per.ID;
                    UserStatic.isAdmin = per.isAdmin;
                    UserStatic.UserNo = per.UserNo;
                    FrmMain frm = new FrmMain();
                    this.Hide();
                    frm.ShowDialog();
                }
            }
            
            
            
            
          
        }
    }
}
