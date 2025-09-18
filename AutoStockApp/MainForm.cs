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
    public partial class frm_MainForm : Form
    {
        public frm_MainForm()
        {
            InitializeComponent();
        }

        private void ekleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_AddCustomerForm customerForm = new frm_AddCustomerForm();
            customerForm.MdiParent = this;
            customerForm.Show();
        }

        private void renkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_ColorForm colorForm = new frm_ColorForm();
            colorForm.MdiParent = this;
            colorForm.Show();
        }

        private void modelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_ModelForm modelForm = new frm_ModelForm();
            modelForm.MdiParent = this;
            modelForm.Show();
        }

        private void markaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frm_BrandForm brandForm = new frm_BrandForm();
            brandForm.MdiParent = this;
            brandForm.Show();
        }

        private void güncelleSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_UpdateCustomerForm updateCustomerForm = new frm_UpdateCustomerForm();
            updateCustomerForm.MdiParent = this;
            updateCustomerForm.Show();
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_RemoveCustomerForm deleteCustomerForm = new frm_RemoveCustomerForm();
            deleteCustomerForm.MdiParent = this;
            deleteCustomerForm.Show();
        }

        private void ekleToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frm_AddEmployeeForm addEmployeeForm = new frm_AddEmployeeForm();
            addEmployeeForm.MdiParent = this;
            addEmployeeForm.Show();
        }

        private void güncelleSilToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frm_UpdateEmployeeForm updateEmployeeForm = new frm_UpdateEmployeeForm();
            updateEmployeeForm.MdiParent = this;
            updateEmployeeForm.Show();
        }

        private void silToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frm_RemoveEmployeeForm removeEmployeeForm = new frm_RemoveEmployeeForm();
            removeEmployeeForm.MdiParent = this;
            removeEmployeeForm.Show();
        }

        private void lokasyonGörüntüleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_LocationForm locationForm = new frm_LocationForm();
            locationForm.MdiParent = this;
            locationForm.Show();
        }

        private void lokasyonEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_AddLocationForm locationForm = new frm_AddLocationForm();
            locationForm.MdiParent = this;
            locationForm.Show();
        }
    }
}
