using Project.BLL.GenericRepository.ConcRep;
using Project.ENTITIES.Models;
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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            _guestRep = new GuestRepository();
            _roomServiceRep = new RoomServiceRepository();
           
        }
        List<Guest> guests;
        GuestRepository _guestRep;
        RoomServiceRepository _roomServiceRep;
        List<RoomService> roomServices;
        
        private void Form3_Load(object sender, EventArgs e)
        {
            guests=_guestRep.GetActives();
            foreach (Guest item in guests)
            {
                lstMisafirler.Items.Add(item);
            }
            roomServices=_roomServiceRep.GetAll();
            foreach (RoomService item in roomServices)
            { 
             cmbMenu.Items.Add(item);
            }
            roomServices = _roomServiceRep.GetAll();
            foreach (RoomService item in roomServices)
            { 
            cmbIcecekler.Items.Add(item);
            }
            btnSiparis.Enabled = false;



        }

        private void btnMisafir_Click(object sender, EventArgs e)
        {
            if (txtMisafirAdi.Text != "" && txtMisafirSoyadi.Text != "" && txtMisafirAdresi.Text != "" && txtMisafirTck.Text != "" && txtMisafirTel.Text != "")
            {
                   Guest guests = new Guest
                   {
                    FirstName = txtMisafirAdi.Text,
                    LastName = txtMisafirSoyadi.Text,
                    ContactNumber = txtMisafirTel.Text,
                    TCKNo = txtMisafirTck.Text
                   };
                    _guestRep.Add(guests);
                    lstMisafirler.Items.Add(guests);
            }
            else
            {
                MessageBox.Show("Lütfen Misafir bilgilerini tamamının girildiğinden emin olunuz!");
            }
        }

        private void lstMisafirler_Click(object sender, EventArgs e)
        {

        }
    }
}
