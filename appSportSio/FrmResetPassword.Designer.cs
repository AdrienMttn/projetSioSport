namespace appSportSio
{
    partial class FrmResetPassword
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
            this.inputName = new System.Windows.Forms.TextBox();
            this.inputPwd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnChanger = new System.Windows.Forms.Button();
            this.errorChange = new System.Windows.Forms.Label();
            this.errorPwd = new System.Windows.Forms.Label();
            this.errorName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // inputName
            // 
            this.inputName.Location = new System.Drawing.Point(83, 79);
            this.inputName.Name = "inputName";
            this.inputName.Size = new System.Drawing.Size(196, 20);
            this.inputName.TabIndex = 0;
            // 
            // inputPwd
            // 
            this.inputPwd.Location = new System.Drawing.Point(83, 136);
            this.inputPwd.Name = "inputPwd";
            this.inputPwd.Size = new System.Drawing.Size(196, 20);
            this.inputPwd.TabIndex = 1;
            this.inputPwd.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(80, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 13);
            this.label2.TabIndex = 30;
            this.label2.Text = "Nouveau Mot de Passe :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(80, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 31;
            this.label1.Text = "Nom d\'utilisateur :";
            // 
            // btnChanger
            // 
            this.btnChanger.Location = new System.Drawing.Point(124, 180);
            this.btnChanger.Name = "btnChanger";
            this.btnChanger.Size = new System.Drawing.Size(102, 32);
            this.btnChanger.TabIndex = 32;
            this.btnChanger.Text = "Changer";
            this.btnChanger.UseVisualStyleBackColor = true;
            this.btnChanger.Click += new System.EventHandler(this.btnChanger_Click);
            // 
            // errorChange
            // 
            this.errorChange.AutoSize = true;
            this.errorChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorChange.ForeColor = System.Drawing.Color.Red;
            this.errorChange.Location = new System.Drawing.Point(70, 215);
            this.errorChange.Name = "errorChange";
            this.errorChange.Size = new System.Drawing.Size(223, 13);
            this.errorChange.TabIndex = 33;
            this.errorChange.Text = "Aucun utilisateur trouver avec ce nom";
            this.errorChange.Visible = false;
            // 
            // errorPwd
            // 
            this.errorPwd.AutoSize = true;
            this.errorPwd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorPwd.ForeColor = System.Drawing.Color.Red;
            this.errorPwd.Location = new System.Drawing.Point(80, 159);
            this.errorPwd.Name = "errorPwd";
            this.errorPwd.Size = new System.Drawing.Size(140, 13);
            this.errorPwd.TabIndex = 34;
            this.errorPwd.Text = "Entrer un Mot de Passe";
            this.errorPwd.Visible = false;
            // 
            // errorName
            // 
            this.errorName.AutoSize = true;
            this.errorName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorName.ForeColor = System.Drawing.Color.Red;
            this.errorName.Location = new System.Drawing.Point(80, 102);
            this.errorName.Name = "errorName";
            this.errorName.Size = new System.Drawing.Size(157, 13);
            this.errorName.TabIndex = 35;
            this.errorName.Text = "Entrer un Nom d\'utilisateur";
            this.errorName.Visible = false;
            // 
            // FrmResetPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 249);
            this.Controls.Add(this.errorName);
            this.Controls.Add(this.errorPwd);
            this.Controls.Add(this.errorChange);
            this.Controls.Add(this.btnChanger);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.inputPwd);
            this.Controls.Add(this.inputName);
            this.Name = "FrmResetPassword";
            this.Text = "Reset Password";
            this.Load += new System.EventHandler(this.FrmResetPassword_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputName;
        private System.Windows.Forms.TextBox inputPwd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnChanger;
        private System.Windows.Forms.Label errorChange;
        private System.Windows.Forms.Label errorPwd;
        private System.Windows.Forms.Label errorName;
    }
}