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
    public partial class frm_ModelForm : Form
    {
        private readonly IModelService _modelService;
        public frm_ModelForm()
        {
            _modelService = new ModelManager(new EfModelDal());
            InitializeComponent();

        }

        public void ListModel()
        {
            dgw_Model.DataSource = _modelService.GetAll().Select(m => new
            {
                Id = m.Id,
                Marka = m.Brand.BrandName,
                ModelAdı = m.ModelName
            }).ToList();
        }
        private void frm_ModelForm_Load(object sender, EventArgs e)
        {
            ListModel();

            var brand = from item in _modelService.GetAll()
                        select new { item.BrandId, item.Brand.BrandName };
            cmb_ModelBrand.DataSource = brand.Distinct().ToList();
            cmb_ModelBrand.DisplayMember = "BrandName";
            cmb_ModelBrand.ValueMember = "BrandId";
            
            
        }
    }
}
