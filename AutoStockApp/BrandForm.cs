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
    public partial class frm_BrandForm : Form
    {
        private readonly IBrandService _brandService;
        public frm_BrandForm()
        {
            _brandService = new BrandManager(new EfBrandDal());
            InitializeComponent();
        }

        public void ListBrand()
        {
           dgw_Brand.DataSource= _brandService.GetAll();
        }
        private void frm_BrandForm_Load(object sender, EventArgs e)
        {
            ListBrand();
            dgw_Brand.Columns[2].Visible = false;
            dgw_Brand.Columns[3].Visible = false;
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            Brand brand = new Brand();
            brand.BrandName = txt_BrandName.Text;
            _brandService.Add(brand);
            MessageBox.Show("Marka eklendi");
            ListBrand();
            txt_BrandName.Clear();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(dgw_Brand.CurrentRow.Cells[0].Value.ToString());
            var deletedEntity = _brandService.GetAll().Find(x => x.Id == id);
            _brandService.Remove(deletedEntity);
            MessageBox.Show("Marka silindi!!");
            ListBrand();
            txt_BrandName.Clear();
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            string brandName= dgw_Brand.CurrentRow.Cells[1].Value.ToString();
            int id = (_brandService.GetAll().Single(x => x.BrandName == brandName)).Id;
            var updatedEntity = _brandService.GetAll().Find(a => a.Id == id);
            updatedEntity.BrandName = txt_BrandName.Text;
            _brandService.Update(updatedEntity);
            MessageBox.Show("Marka güncellendi!");
            ListBrand();
            txt_BrandName.Clear();
        }

        private void dgw_Brand_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //txt_BrandName.Text = dgw_Brand.Rows[e.RowIndex].Cells[1].Value.ToString();
            txt_BrandName.Text = dgw_Brand.CurrentRow.Cells[1].Value.ToString();
        }
    }
}
