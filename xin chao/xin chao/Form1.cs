using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace xin_chao
{
    public partial class frmxinchao : Form
    {
        public frmxinchao()
        {
            InitializeComponent();
        }

        private void lblxinchao_Click(object sender, EventArgs e)
        {

        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            lblxinchao.Text = "xin chao!";
        }
    }
}
