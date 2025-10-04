namespace appSportSio
{
    partial class FrmLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlLogin = new System.Windows.Forms.Panel();
            this.btnMdpLost = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCnx = new System.Windows.Forms.Button();
            this.errorLogin = new System.Windows.Forms.Label();
            this.inputPwd = new System.Windows.Forms.TextBox();
            this.inputName = new System.Windows.Forms.TextBox();
            this.txtConnexion = new System.Windows.Forms.Label();
            this.pnlCreate = new System.Windows.Forms.Panel();
            this.btnCreate = new System.Windows.Forms.Button();
            this.errorConfirmMdpCreate = new System.Windows.Forms.Label();
            this.errorMdpCreate = new System.Windows.Forms.Label();
            this.errorNameCreate = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.inputConfirmation = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCreate = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.inputNameInscription = new System.Windows.Forms.TextBox();
            this.inputPwdInscription = new System.Windows.Forms.TextBox();
            this.pnlSetLogin = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.btnSetLogin = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.pnlSetCreate = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.btnSetCreate = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.errorUserExist = new System.Windows.Forms.Label();
            this.pnlLogin.SuspendLayout();
            this.pnlCreate.SuspendLayout();
            this.pnlSetLogin.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnlSetCreate.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlLogin
            // 
            this.pnlLogin.Controls.Add(this.btnMdpLost);
            this.pnlLogin.Controls.Add(this.label2);
            this.pnlLogin.Controls.Add(this.label1);
            this.pnlLogin.Controls.Add(this.btnCnx);
            this.pnlLogin.Controls.Add(this.errorLogin);
            this.pnlLogin.Controls.Add(this.inputPwd);
            this.pnlLogin.Controls.Add(this.inputName);
            this.pnlLogin.Controls.Add(this.txtConnexion);
            this.pnlLogin.Location = new System.Drawing.Point(3, 1);
            this.pnlLogin.Name = "pnlLogin";
            this.pnlLogin.Size = new System.Drawing.Size(523, 448);
            this.pnlLogin.TabIndex = 0;
            // 
            // btnMdpLost
            // 
            this.btnMdpLost.AutoSize = true;
            this.btnMdpLost.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnMdpLost.Location = new System.Drawing.Point(201, 257);
            this.btnMdpLost.Name = "btnMdpLost";
            this.btnMdpLost.Size = new System.Drawing.Size(111, 13);
            this.btnMdpLost.TabIndex = 30;
            this.btnMdpLost.Text = "Mot de passe oublié ?";
            this.btnMdpLost.Click += new System.EventHandler(this.btnMdpLost_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(157, 216);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "Mot de passe :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(157, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "Nom d\'utilisateur :";
            // 
            // btnCnx
            // 
            this.btnCnx.ForeColor = System.Drawing.Color.Black;
            this.btnCnx.Location = new System.Drawing.Point(211, 273);
            this.btnCnx.Name = "btnCnx";
            this.btnCnx.Size = new System.Drawing.Size(92, 37);
            this.btnCnx.TabIndex = 27;
            this.btnCnx.Text = "Connexion";
            this.btnCnx.UseVisualStyleBackColor = true;
            this.btnCnx.Click += new System.EventHandler(this.btnCnx_Click);
            // 
            // errorLogin
            // 
            this.errorLogin.AutoSize = true;
            this.errorLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorLogin.ForeColor = System.Drawing.Color.Red;
            this.errorLogin.Location = new System.Drawing.Point(136, 333);
            this.errorLogin.Name = "errorLogin";
            this.errorLogin.Size = new System.Drawing.Size(252, 13);
            this.errorLogin.TabIndex = 26;
            this.errorLogin.Text = "Nom d\'utilisateur ou mot de passe incorrect";
            this.errorLogin.Visible = false;
            this.errorLogin.Click += new System.EventHandler(this.errorLogin_Click);
            // 
            // inputPwd
            // 
            this.inputPwd.Location = new System.Drawing.Point(160, 232);
            this.inputPwd.Name = "inputPwd";
            this.inputPwd.Size = new System.Drawing.Size(202, 20);
            this.inputPwd.TabIndex = 2;
            this.inputPwd.Tag = "";
            // 
            // inputName
            // 
            this.inputName.Location = new System.Drawing.Point(160, 182);
            this.inputName.Name = "inputName";
            this.inputName.Size = new System.Drawing.Size(202, 20);
            this.inputName.TabIndex = 1;
            this.inputName.TextChanged += new System.EventHandler(this.inputName_TextChanged);
            // 
            // txtConnexion
            // 
            this.txtConnexion.AutoSize = true;
            this.txtConnexion.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConnexion.Location = new System.Drawing.Point(193, 101);
            this.txtConnexion.Name = "txtConnexion";
            this.txtConnexion.Size = new System.Drawing.Size(137, 29);
            this.txtConnexion.TabIndex = 0;
            this.txtConnexion.Text = "Connexion";
            // 
            // pnlCreate
            // 
            this.pnlCreate.Controls.Add(this.errorUserExist);
            this.pnlCreate.Controls.Add(this.btnCreate);
            this.pnlCreate.Controls.Add(this.errorConfirmMdpCreate);
            this.pnlCreate.Controls.Add(this.errorMdpCreate);
            this.pnlCreate.Controls.Add(this.errorNameCreate);
            this.pnlCreate.Controls.Add(this.label5);
            this.pnlCreate.Controls.Add(this.inputConfirmation);
            this.pnlCreate.Controls.Add(this.label3);
            this.pnlCreate.Controls.Add(this.txtCreate);
            this.pnlCreate.Controls.Add(this.label4);
            this.pnlCreate.Controls.Add(this.inputNameInscription);
            this.pnlCreate.Controls.Add(this.inputPwdInscription);
            this.pnlCreate.Location = new System.Drawing.Point(528, 1);
            this.pnlCreate.Name = "pnlCreate";
            this.pnlCreate.Size = new System.Drawing.Size(523, 448);
            this.pnlCreate.TabIndex = 1;
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(210, 321);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(92, 37);
            this.btnCreate.TabIndex = 30;
            this.btnCreate.Text = "Créer";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // errorConfirmMdpCreate
            // 
            this.errorConfirmMdpCreate.AutoSize = true;
            this.errorConfirmMdpCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorConfirmMdpCreate.ForeColor = System.Drawing.Color.Red;
            this.errorConfirmMdpCreate.Location = new System.Drawing.Point(359, 293);
            this.errorConfirmMdpCreate.Name = "errorConfirmMdpCreate";
            this.errorConfirmMdpCreate.Size = new System.Drawing.Size(125, 12);
            this.errorConfirmMdpCreate.TabIndex = 37;
            this.errorConfirmMdpCreate.Text = "le MDP n\'est pas valide";
            this.errorConfirmMdpCreate.Visible = false;
            this.errorConfirmMdpCreate.Click += new System.EventHandler(this.errorConfirmMdpCreate_Click);
            // 
            // errorMdpCreate
            // 
            this.errorMdpCreate.AutoSize = true;
            this.errorMdpCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorMdpCreate.ForeColor = System.Drawing.Color.Red;
            this.errorMdpCreate.Location = new System.Drawing.Point(359, 236);
            this.errorMdpCreate.Name = "errorMdpCreate";
            this.errorMdpCreate.Size = new System.Drawing.Size(123, 12);
            this.errorMdpCreate.TabIndex = 36;
            this.errorMdpCreate.Text = "Entrer un Mot de Passe";
            this.errorMdpCreate.Visible = false;
            // 
            // errorNameCreate
            // 
            this.errorNameCreate.AutoSize = true;
            this.errorNameCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorNameCreate.ForeColor = System.Drawing.Color.Red;
            this.errorNameCreate.Location = new System.Drawing.Point(359, 186);
            this.errorNameCreate.Name = "errorNameCreate";
            this.errorNameCreate.Size = new System.Drawing.Size(75, 12);
            this.errorNameCreate.TabIndex = 30;
            this.errorNameCreate.Text = "Entrer un nom";
            this.errorNameCreate.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(148, 273);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(184, 13);
            this.label5.TabIndex = 35;
            this.label5.Text = "Confirmation du Mot de Passe :";
            // 
            // inputConfirmation
            // 
            this.inputConfirmation.Location = new System.Drawing.Point(151, 289);
            this.inputConfirmation.Name = "inputConfirmation";
            this.inputConfirmation.Size = new System.Drawing.Size(202, 20);
            this.inputConfirmation.TabIndex = 34;
            this.inputConfirmation.Tag = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(148, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 33;
            this.label3.Text = "Mot de passe :";
            // 
            // txtCreate
            // 
            this.txtCreate.AutoSize = true;
            this.txtCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCreate.Location = new System.Drawing.Point(190, 101);
            this.txtCreate.Name = "txtCreate";
            this.txtCreate.Size = new System.Drawing.Size(134, 29);
            this.txtCreate.TabIndex = 0;
            this.txtCreate.Text = "Inscription";
            this.txtCreate.Click += new System.EventHandler(this.label1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(148, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 13);
            this.label4.TabIndex = 32;
            this.label4.Text = "Nom d\'utilisateur :";
            // 
            // inputNameInscription
            // 
            this.inputNameInscription.Location = new System.Drawing.Point(151, 182);
            this.inputNameInscription.Name = "inputNameInscription";
            this.inputNameInscription.Size = new System.Drawing.Size(202, 20);
            this.inputNameInscription.TabIndex = 30;
            // 
            // inputPwdInscription
            // 
            this.inputPwdInscription.Location = new System.Drawing.Point(151, 232);
            this.inputPwdInscription.Name = "inputPwdInscription";
            this.inputPwdInscription.Size = new System.Drawing.Size(202, 20);
            this.inputPwdInscription.TabIndex = 31;
            this.inputPwdInscription.Tag = "";
            // 
            // pnlSetLogin
            // 
            this.pnlSetLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(152)))), ((int)(((byte)(0)))));
            this.pnlSetLogin.Controls.Add(this.panel2);
            this.pnlSetLogin.Controls.Add(this.btnSetLogin);
            this.pnlSetLogin.Controls.Add(this.label6);
            this.pnlSetLogin.Location = new System.Drawing.Point(3, 1);
            this.pnlSetLogin.Name = "pnlSetLogin";
            this.pnlSetLogin.Size = new System.Drawing.Size(523, 448);
            this.pnlSetLogin.TabIndex = 31;
            this.pnlSetLogin.Visible = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Location = new System.Drawing.Point(522, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(523, 445);
            this.panel2.TabIndex = 32;
            this.panel2.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(204, 232);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 32);
            this.button1.TabIndex = 1;
            this.button1.Text = "Se connecter";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(172, 192);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(174, 24);
            this.label7.TabIndex = 0;
            this.label7.Text = "Déjà un compte ?";
            // 
            // btnSetLogin
            // 
            this.btnSetLogin.Location = new System.Drawing.Point(204, 232);
            this.btnSetLogin.Name = "btnSetLogin";
            this.btnSetLogin.Size = new System.Drawing.Size(102, 32);
            this.btnSetLogin.TabIndex = 1;
            this.btnSetLogin.Text = "Se connecter";
            this.btnSetLogin.UseVisualStyleBackColor = true;
            this.btnSetLogin.Click += new System.EventHandler(this.btnSetLogin_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(172, 192);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(174, 24);
            this.label6.TabIndex = 0;
            this.label6.Text = "Déjà un compte ?";
            // 
            // pnlSetCreate
            // 
            this.pnlSetCreate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            this.pnlSetCreate.Controls.Add(this.panel4);
            this.pnlSetCreate.Controls.Add(this.btnSetCreate);
            this.pnlSetCreate.Controls.Add(this.label9);
            this.pnlSetCreate.Location = new System.Drawing.Point(528, 1);
            this.pnlSetCreate.Name = "pnlSetCreate";
            this.pnlSetCreate.Size = new System.Drawing.Size(517, 448);
            this.pnlSetCreate.TabIndex = 33;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.button2);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Location = new System.Drawing.Point(522, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(523, 445);
            this.panel4.TabIndex = 32;
            this.panel4.Visible = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(204, 232);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(102, 32);
            this.button2.TabIndex = 1;
            this.button2.Text = "Se connecter";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(172, 192);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(174, 24);
            this.label8.TabIndex = 0;
            this.label8.Text = "Déjà un compte ?";
            // 
            // btnSetCreate
            // 
            this.btnSetCreate.BackColor = System.Drawing.Color.White;
            this.btnSetCreate.Location = new System.Drawing.Point(204, 232);
            this.btnSetCreate.Name = "btnSetCreate";
            this.btnSetCreate.Size = new System.Drawing.Size(102, 32);
            this.btnSetCreate.TabIndex = 1;
            this.btnSetCreate.Text = "Créer un compte";
            this.btnSetCreate.UseVisualStyleBackColor = false;
            this.btnSetCreate.Click += new System.EventHandler(this.btnSetCreate_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(126, 192);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(265, 24);
            this.label9.TabIndex = 0;
            this.label9.Text = "Pas encore dans l\'équipe ?";
            // 
            // errorUserExist
            // 
            this.errorUserExist.AutoSize = true;
            this.errorUserExist.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorUserExist.ForeColor = System.Drawing.Color.Red;
            this.errorUserExist.Location = new System.Drawing.Point(159, 372);
            this.errorUserExist.Name = "errorUserExist";
            this.errorUserExist.Size = new System.Drawing.Size(210, 13);
            this.errorUserExist.TabIndex = 38;
            this.errorUserExist.Text = "Un compte avec ce nom existe déjà";
            this.errorUserExist.Visible = false;
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1046, 450);
            this.Controls.Add(this.pnlSetCreate);
            this.Controls.Add(this.pnlSetLogin);
            this.Controls.Add(this.pnlCreate);
            this.Controls.Add(this.pnlLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmLogin";
            this.Text = "FrmLogin";
            this.pnlLogin.ResumeLayout(false);
            this.pnlLogin.PerformLayout();
            this.pnlCreate.ResumeLayout(false);
            this.pnlCreate.PerformLayout();
            this.pnlSetLogin.ResumeLayout(false);
            this.pnlSetLogin.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pnlSetCreate.ResumeLayout(false);
            this.pnlSetCreate.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlLogin;
        private System.Windows.Forms.Label txtConnexion;
        private System.Windows.Forms.Panel pnlCreate;
        private System.Windows.Forms.Label txtCreate;
        private System.Windows.Forms.TextBox inputPwd;
        private System.Windows.Forms.TextBox inputName;
        private System.Windows.Forms.Label errorLogin;
        private System.Windows.Forms.Button btnCnx;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox inputConfirmation;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox inputNameInscription;
        private System.Windows.Forms.TextBox inputPwdInscription;
        private System.Windows.Forms.Label errorMdpCreate;
        private System.Windows.Forms.Label errorNameCreate;
        private System.Windows.Forms.Label errorConfirmMdpCreate;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Label btnMdpLost;
        private System.Windows.Forms.Panel pnlSetLogin;
        private System.Windows.Forms.Button btnSetLogin;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel pnlSetCreate;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnSetCreate;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label errorUserExist;
    }
}