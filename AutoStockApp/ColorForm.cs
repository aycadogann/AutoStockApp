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
    public partial class frm_ColorForm : Form
    {
        public frm_ColorForm()
        {
            InitializeComponent();
        }

        private void txt_AddColor_MouseClick(object sender, MouseEventArgs e)
        {
            txt_AddColor.Clear();
            Font font = new Font("Microsoft Sans Serif", 12.0f);
            txt_AddColor.Font = font;
        }
    }
}
