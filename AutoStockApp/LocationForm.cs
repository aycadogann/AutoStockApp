using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
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
    public partial class frm_LocationForm : Form
    {
        private readonly ILocationService _locationService;
        public frm_LocationForm()
        {
            _locationService = new LocationManager(new EfLocationDal());
            InitializeComponent();
        }

        public void ListLocation()
        {
            dgw_Location.DataSource = _locationService.GetAll();
            dgw_Location.Columns[3].Visible = false;
            dgw_Location.Columns[4].Visible = false;
        }
        private void frm_LocationForm_Load(object sender, EventArgs e)
        {
            ListLocation();
        }
    }
}
