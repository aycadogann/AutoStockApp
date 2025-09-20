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
    public partial class frm_ModelForm : Form
    {
        AutoStockAppEntities db = new AutoStockAppEntities();
        public frm_ModelForm()
        {
            InitializeComponent();
        }

        private void frm_ModelForm_Load(object sender, EventArgs e)
        {
            //dgw_Model.DataSource = db.Models.ToList();

            var data = db.Models.Select(m => new
            {
                Id=m.Id,
                Marka=m.Brand.BrandName,
                ModelAdı=m.ModelName
            }).ToList();
            dgw_Model.DataSource = data;
        }
    }
}
