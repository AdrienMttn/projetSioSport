using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BiblioSportif;
using OutilsBDD;
using static Org.BouncyCastle.Crypto.Engines.SM2Engine;

namespace appSportSio
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void resetError()
        {
            errorConfirmMdpCreate.Visible = false;
            errorMdpCreate.Visible = false;
            errorNameCreate.Visible = false;
            errorLogin.Visible = false;
            errorUserExist.Visible = false;
        }
        private void loginOrCreate(int mode) {
            resetError();
            bool error = false;
            switch (mode)
            {
                case 0:
                    if (inputNameInscription.Text == "")
                    {
                        error = true;
                        errorNameCreate.Visible = true;
                    }
                    if (inputPwdInscription.Text == "")
                    {
                        error = true;
                        errorMdpCreate.Visible = true;
                    }
                    if (inputPwdInscription.Text != inputConfirmation.Text)
                    {
                        error = true;
                        errorConfirmMdpCreate.Visible = true;
                    }
                    if (error) { break; }
                    bool create = BDD.createAccount(inputNameInscription.Text, inputPwdInscription.Text);
                    if (!create)
                    {
                        error = true;
                        errorUserExist.Visible = true;
                    }
                    else
                    {
                        changePage();
                    }
                    break;
                case 1:
                    if (inputName.Text == "")
                    {
                        error = true;
                        errorLogin.Visible = true;
                    }
                    if (inputPwd.Text == "")
                    {
                        error = true;
                        errorLogin.Visible = true;
                    }
                    if (error) { break; }
                    bool login = BDD.login(inputName.Text, inputPwd.Text);
                    if (!login)
                    {
                        error = true;
                        errorLogin.Visible = true;
                    }
                    else 
                    {
                        ((FrmMain)this.MdiParent).SetCurrentUser(inputName.Text, inputPwd.Text);
                        changePage();
                    }
                    break;
            }
        }

        private void changePage()
        {
            FrmSportSio frmSportSio = new FrmSportSio();
            frmSportSio.MdiParent = this.MdiParent;
            frmSportSio.StartPosition = FormStartPosition.Manual;
            frmSportSio.Location = new Point(0, 0);
            frmSportSio.Dock = DockStyle.Fill;
            frmSportSio.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void inputName_TextChanged(object sender, EventArgs e)
        {

        }

        private void errorLogin_Click(object sender, EventArgs e)
        {

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            loginOrCreate(0);
        }

        private void btnCnx_Click(object sender, EventArgs e)
        {
            loginOrCreate(1);
        }

        private void btnMdpLost_Click(object sender, EventArgs e)
        {
            // mdp lost
            FrmResetPassword frmResetPassword = new FrmResetPassword();
            frmResetPassword.Show();
        }

        private void btnSetLogin_Click(object sender, EventArgs e)
        {
            // set login
            resetError();
            pnlSetCreate.Visible = true;
            pnlCreate.Visible = false;
            pnlLogin.Visible = true;
            pnlSetLogin.Visible = false;
        }

        private void btnSetCreate_Click(object sender, EventArgs e)
        {
            // set create
            resetError();
            pnlSetCreate.Visible = false;
            pnlCreate.Visible = true;
            pnlLogin.Visible = false;
            pnlSetLogin.Visible = true;
        }

        private void errorConfirmMdpCreate_Click(object sender, EventArgs e)
        {

        }
    }
}
