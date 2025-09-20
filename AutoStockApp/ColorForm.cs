using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities;
using System;
using System.Linq;
using System.Windows.Forms;

namespace AutoStockApp
{
    public partial class frm_ColorForm : Form
    {

        private readonly IColorService _colorService;

        public frm_ColorForm()
        {
            _colorService = new ColorManager(new EfColorDal());
            InitializeComponent();
        }

        public void ListColor()
        {
            dgw_Color.DataSource = _colorService.GetAll();
        }
        private void frm_ColorForm_Load(object sender, EventArgs e)
        {
            ListColor();
            dgw_Color.Columns[2].Visible = false;
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            Color color = new Color();
            color.ColorName = txt_AddColor.Text;
            _colorService.Add(color);
            MessageBox.Show("Renk Eklendi");
            ListColor();
            txt_AddColor.Clear();

        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            //todo : datagrid cellclick ile textboxları doldurmayı dene
            txt_ColorId.ReadOnly = true;
            int id = int.Parse(dgw_Color.CurrentRow.Cells[0].Value.ToString());
            var deletedEntity = _colorService.GetAll().Find(x => x.Id == id);
            _colorService.Remove(deletedEntity);
            MessageBox.Show("Silme işlemi başarılı");
            ListColor();
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            txt_ColorId.ReadOnly = true;
            int id = int.Parse(txt_ColorId.Text);
            var updatedEntity = _colorService.GetAll().Find(x => x.Id == id);
            updatedEntity.ColorName = txt_AddColor.Text;
            _colorService.Update(updatedEntity);
            MessageBox.Show("Renk güncellendi");
            ListColor();
            txt_ColorId.Clear();
            txt_AddColor.Clear();
        }

        private void dgw_Color_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_ColorId.ReadOnly = true;
            txt_ColorId.Text = dgw_Color.CurrentRow.Cells[0].Value.ToString();
            //txt_AddColor.Text = dgw_Color.CurrentRow.Cells[1].Value.ToString();
        }
    }
}
