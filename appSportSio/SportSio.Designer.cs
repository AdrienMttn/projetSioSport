namespace appSportSio
{
    partial class SportSio
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.filterSelect = new System.Windows.Forms.ComboBox();
            this.searchInput = new System.Windows.Forms.TextBox();
            this.listSportif = new System.Windows.Forms.ListView();
            this.editSportif = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.supprimerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.editSportif.SuspendLayout();
            this.SuspendLayout();
            // 
            // filterSelect
            // 
            this.filterSelect.DisplayMember = "jghja";
            this.filterSelect.FormattingEnabled = true;
            this.filterSelect.Items.AddRange(new object[] {
            "all"});
            this.filterSelect.Location = new System.Drawing.Point(88, 33);
            this.filterSelect.Name = "filterSelect";
            this.filterSelect.Size = new System.Drawing.Size(121, 21);
            this.filterSelect.TabIndex = 0;
            this.filterSelect.SelectedIndexChanged += new System.EventHandler(this.filterSelect_SelectedIndexChanged);
            // 
            // searchInput
            // 
            this.searchInput.Location = new System.Drawing.Point(306, 33);
            this.searchInput.Name = "searchInput";
            this.searchInput.Size = new System.Drawing.Size(364, 20);
            this.searchInput.TabIndex = 1;
            this.searchInput.TextChanged += new System.EventHandler(this.searchInput_TextChanged);
            // 
            // listSportif
            // 
            this.listSportif.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listSportif.HideSelection = false;
            this.listSportif.Location = new System.Drawing.Point(0, 70);
            this.listSportif.Name = "listSportif";
            this.listSportif.Size = new System.Drawing.Size(1048, 381);
            this.listSportif.TabIndex = 2;
            this.listSportif.UseCompatibleStateImageBehavior = false;
            this.listSportif.View = System.Windows.Forms.View.Details;
            this.listSportif.SelectedIndexChanged += new System.EventHandler(this.listSportif_SelectedIndexChanged_1);
            this.listSportif.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listSportif_MouseClick);
            // 
            // editSportif
            // 
            this.editSportif.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.supprimerToolStripMenuItem,
            this.modifierToolStripMenuItem});
            this.editSportif.Name = "editSportif";
            this.editSportif.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.editSportif.Size = new System.Drawing.Size(130, 48);
            this.editSportif.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // supprimerToolStripMenuItem
            // 
            this.supprimerToolStripMenuItem.Name = "supprimerToolStripMenuItem";
            this.supprimerToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.supprimerToolStripMenuItem.Text = "Supprimer";
            this.supprimerToolStripMenuItem.Click += new System.EventHandler(this.supprimerToolStripMenuItem_Click);
            // 
            // modifierToolStripMenuItem
            // 
            this.modifierToolStripMenuItem.Name = "modifierToolStripMenuItem";
            this.modifierToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.modifierToolStripMenuItem.Text = "Modifier";
            this.modifierToolStripMenuItem.Click += new System.EventHandler(this.modifierToolStripMenuItem_Click);
            // 
            // btnAjouter
            // 
            this.btnAjouter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAjouter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouter.ForeColor = System.Drawing.Color.Transparent;
            this.btnAjouter.Location = new System.Drawing.Point(931, 24);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(103, 36);
            this.btnAjouter.TabIndex = 3;
            this.btnAjouter.Text = "Ajouter +";
            this.btnAjouter.UseVisualStyleBackColor = false;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // SportSio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1046, 450);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.listSportif);
            this.Controls.Add(this.searchInput);
            this.Controls.Add(this.filterSelect);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SportSio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Affichage des sportifs";
            this.Load += new System.EventHandler(this.SportSio_Load);
            this.editSportif.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox filterSelect;
        private System.Windows.Forms.TextBox searchInput;
        private System.Windows.Forms.ListView listSportif;
        private System.Windows.Forms.ContextMenuStrip editSportif;
        private System.Windows.Forms.ToolStripMenuItem supprimerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifierToolStripMenuItem;
        private System.Windows.Forms.Button btnAjouter;
    }
}

