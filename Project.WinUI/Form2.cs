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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            _cRep= new CustomerRepository();
            _reservationRep= new ReservationRepository();
            _houseKeeperRep= new HouseKeeperRepository();
            _receptionRep= new ReceptionRepository();
            _roomRep= new RoomRepository();
            _roomTypeRep= new RoomTypeRepository();
            _roomDetailRep = new RoomDetailRepository();
        }
        CustomerRepository _cRep;
        ReservationRepository _reservationRep;
        HouseKeeperRepository _houseKeeperRep;
        ReceptionRepository _receptionRep;
        RoomRepository _roomRep;
        RoomTypeRepository _roomTypeRep;
        List<Customer> customers;
        List<Room> rooms;
        List<RoomDetail> roomDetails;
        RoomDetailRepository _roomDetailRep;



        private void btnMusteriEkle_Click(object sender, EventArgs e)
        {
            
            if (txtMusteriAdi.Text!="" && txtMusteriSoyadi.Text!="" && txtMusteriAdresi.Text!=""&& txtTCNo.Text!=""&& txtMusTelNo.Text!="" )
            {
                 Customer c= new Customer();
                  c.FirstName=txtMusteriAdi.Text;
                  c.LastName=txtMusteriSoyadi.Text;
                 c.ContactNumber=txtMusTelNo.Text;
                 c.Adress=txtMusteriAdresi.Text;
                 c.TCKNo=txtTCNo.Text;
                _cRep.Add(c);
            }
            else
            {
                MessageBox.Show("Lütfen müşteri bilgilerinin doğru girildiğinden emin olun.");
                return;
            }
           

        }

       

        private void Form2_Load(object sender, EventArgs e)
        {
            customers = _cRep.GetActives();
            foreach (Customer item in customers)
            {
                lstMusteriler.Items.Add(item);  
            }
           
           

            btnMusteriEkle.Enabled = false;
            btnRezervasyonEkle.Enabled = false;

        }

        private void btnOdaAra_Click(object sender, EventArgs e)
        {
            Reservation res = new Reservation();
            res.CheckIn = dtp1.Value;
            res.CheckOut = dtp2.Value;
            _reservationRep.Add(res);
            
            if (rdoStandart.Checked == true)
            {
                btn301.Enabled = btn302.Enabled = btn303.Enabled = false;
                btn201.Enabled = btn202.Enabled = btn203.Enabled = false;

            }
        }

        private void btnZiyaretciListesi_Click(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3();
            frm3.ShowDialog();
        }
    }
}
