using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OutilsBDD;

namespace appSportSio
{
    public partial class FrmResetPassword : Form
    {
        public FrmResetPassword()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmResetPassword_Load(object sender, EventArgs e)
        {

        }

        private void errorClear()
        {
            errorChange.Visible = false;
            errorName.Visible = false;
            errorPwd.Visible = false;
        }

        private void btnChanger_Click(object sender, EventArgs e)
        {
            errorClear();
            bool error = false;
            if (inputName.Text == "")
            {
                error = true;
                errorName.Visible = true;
            }
            if (inputPwd.Text == "")
            {
                error = true;
                errorPwd.Visible = true;
            }
            if (error) { return; }
            bool change = BDD.changePassword(inputName.Text, inputPwd.Text);
            if (change)
            {
                MessageBox.Show("Mot de passe changé avec succès !");
                this.Close();
            }
            else 
            {
                errorChange.Visible = true;
            }
        }
    }
}
