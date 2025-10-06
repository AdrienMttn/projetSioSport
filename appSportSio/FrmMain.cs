using BiblioSportif;
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


        private User currentUser;


        public void SetCurrentUser(string name, string password)
        {
            this.currentUser = new User(name, password);
        }
        public User GetCurrentUser()
        {
            return this.currentUser;
        }
        public FrmMain()
        {
            InitializeComponent();
            FrmLogin frmLogin = new FrmLogin();
            frmLogin.MdiParent = this;
            frmLogin.Dock = DockStyle.Fill;
            frmLogin.Show();
        }


        private void MDIParent1_Load(object sender, EventArgs e)
        {

        }
    }
}
