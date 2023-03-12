using Project.BLL.GenericRepository.ConcRep;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project.WinUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            _recRep= new ReceptionRepository();
        }
        ReceptionRepository _recRep; 
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            if (_recRep.Any(x => x.UserName == txtIsim.Text && x.Password == txtSifre.Text))
            {
                MessageBox.Show("Hoş Geldiniz!!");
                Form2 frm2 = new Form2();
                frm2.ShowDialog();
            }
            else 
            {
                MessageBox.Show("Kullanıcı Adı veya Şifre Yanlış!");
                return;
            }
        }
    }
}
