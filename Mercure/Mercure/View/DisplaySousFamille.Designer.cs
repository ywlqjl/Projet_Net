namespace Mercure.View
{
    partial class DisplaySousFamille
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
            this.components = new System.ComponentModel.Container();
            this.List_View_Sous_Famille = new System.Windows.Forms.ListView();
            this.Column_Reference_Sous_Famille = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Column_Nom_Sous_Famille = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Column_Famille = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SubFamilyMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SubFamilyMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // List_View_Sous_Famille
            // 
            this.List_View_Sous_Famille.BackColor = System.Drawing.SystemColors.Window;
            this.List_View_Sous_Famille.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Column_Reference_Sous_Famille,
            this.Column_Nom_Sous_Famille,
            this.Column_Famille});
            this.List_View_Sous_Famille.FullRowSelect = true;
            this.List_View_Sous_Famille.GridLines = true;
            this.List_View_Sous_Famille.Location = new System.Drawing.Point(12, 11);
            this.List_View_Sous_Famille.Name = "List_View_Sous_Famille";
            this.List_View_Sous_Famille.Size = new System.Drawing.Size(414, 384);
            this.List_View_Sous_Famille.TabIndex = 1;
            this.List_View_Sous_Famille.UseCompatibleStateImageBehavior = false;
            this.List_View_Sous_Famille.View = System.Windows.Forms.View.Details;
            this.List_View_Sous_Famille.SelectedIndexChanged += new System.EventHandler(this.List_View_Sous_Famille_SelectedIndexChanged);
            this.List_View_Sous_Famille.KeyDown += new System.Windows.Forms.KeyEventHandler(this.List_View_Sous_Famille_KeyDown);
            this.List_View_Sous_Famille.MouseClick += new System.Windows.Forms.MouseEventHandler(this.OnRightClick);
            this.List_View_Sous_Famille.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.List_View_Sous_Famille_MouseDoubleClick);
            // 
            // Column_Reference_Sous_Famille
            // 
            this.Column_Reference_Sous_Famille.Text = "Reference";
            this.Column_Reference_Sous_Famille.Width = 128;
            // 
            // Column_Nom_Sous_Famille
            // 
            this.Column_Nom_Sous_Famille.Text = "Sous-famille";
            this.Column_Nom_Sous_Famille.Width = 135;
            // 
            // Column_Famille
            // 
            this.Column_Famille.Text = "Famille";
            this.Column_Famille.Width = 147;
            // 
            // SubFamilyMenuStrip
            // 
            this.SubFamilyMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.SubFamilyMenuStrip.Name = "SubFamilyMenuStrip";
            this.SubFamilyMenuStrip.Size = new System.Drawing.Size(114, 48);
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.addToolStripMenuItem.Text = "Add";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.AddToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.DeleteToolStripMenuItem_Click);
            // 
            // DisplaySousFamille
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 401);
            this.Controls.Add(this.List_View_Sous_Famille);
            this.Name = "DisplaySousFamille";
            this.Text = "DisplaySousFamille";
            this.SubFamilyMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView List_View_Sous_Famille;
        private System.Windows.Forms.ColumnHeader Column_Reference_Sous_Famille;
        private System.Windows.Forms.ColumnHeader Column_Nom_Sous_Famille;
        private System.Windows.Forms.ColumnHeader Column_Famille;
        private System.Windows.Forms.ContextMenuStrip SubFamilyMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
    }
}