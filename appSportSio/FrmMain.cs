using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appSportSio
{
    public partial class FrmMain : Form
    {

        public FrmMain()
        {
            InitializeComponent();
            SportSio frmSportSio = new SportSio();
            frmSportSio.MdiParent = this;
            frmSportSio.Dock = DockStyle.Fill;
            frmSportSio.Show();
        }


        private void MDIParent1_Load(object sender, EventArgs e)
        {

        }
    }
}
