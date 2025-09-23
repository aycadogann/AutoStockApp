using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoStockApp
{
    public partial class frm_AddLocationForm : Form
    {
        private readonly ILocationService _locationService;
        public frm_AddLocationForm()
        {
            _locationService = new LocationManager(new EfLocationDal());
            InitializeComponent();
        }

        private void btn_AddLocation_Click(object sender, EventArgs e)
        {
            Location location = new Location();
            if (!String.IsNullOrEmpty(txt_AddLocationName.Text))
            {
                try
                {
                    location.LocationName = txt_AddLocationName.Text;
                    location.LocationAddress = txt_AddLocationAddress.Text;
                    _locationService.Add(location);
                    MessageBox.Show("Ekleme işlemi başarıyla tamamlandı");
                }
                catch (Exception)
                {

                    //throw;
                    MessageBox.Show("Ekleme esnasında problem oluştu. Tekrar deneyiniz!!");
                }
            }
            else
            {
                MessageBox.Show("Lokasyon Adı boş bırakılamaz. Lütfen tekrar deneyiniz!!");
            }
        }
    }
}
