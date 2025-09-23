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
                //Marka = m.Brand.BrandName,
                ModelAdı = m.ModelName
            }).ToList();
        }

        public void FillComboBox()
        {
            //todo : markaların hepsi gelmiyor sadece model tanımlı markalar geliyor.

            //cmb_ModelBrand.DataSource = _brandService.GetAll();
            //cmb_ModelBrand.DisplayMember = "BrandName";
            //cmb_ModelBrand.ValueMember = "Id";          
        }
        private void frm_ModelForm_Load(object sender, EventArgs e)
        {
            ListModel();
            FillComboBox();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            Model model = new Model();
            model.ModelName = txt_ModelName.Text;
            //model.BrandId= (int)cmb_ModelBrand.SelectedValue;
            _modelService.Add(model);
            MessageBox.Show("Model eklendi!!");
            ListModel();
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            int id = (int)dgw_Model.CurrentRow.Cells[0].Value;
            var updatedEntity = _modelService.GetAll().Find(a => a.Id == id);
            updatedEntity.ModelName = txt_ModelName.Text;
            _modelService.Update(updatedEntity);
            MessageBox.Show("Model güncellendi!!!");
            ListModel();
            txt_ModelId.Clear();
            txt_ModelName.Clear();
        }

        private void dgw_Model_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_ModelId.Text = dgw_Model.CurrentRow.Cells[0].Value.ToString();
            txt_ModelName.Text = dgw_Model.CurrentRow.Cells[1].Value.ToString();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            int id = (int)dgw_Model.CurrentRow.Cells[0].Value;
            var deletedEntity = _modelService.GetAll().Find(a => a.Id == id);
            _modelService.Remove(deletedEntity);
            MessageBox.Show("Model silindi!!");
            ListModel();
        }
    }
}
