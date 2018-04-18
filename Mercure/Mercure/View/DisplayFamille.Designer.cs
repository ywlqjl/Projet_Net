namespace Mercure.View
{
    partial class DisplayFamille
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
            this.familleListView = new System.Windows.Forms.ListView();
            this.Column_Reference_Famille = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Column_Nom_Famille = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FamilyStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.FamilyStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // familleListView
            // 
            this.familleListView.BackColor = System.Drawing.SystemColors.Window;
            this.familleListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Column_Reference_Famille,
            this.Column_Nom_Famille});
            this.familleListView.FullRowSelect = true;
            this.familleListView.GridLines = true;
            this.familleListView.Location = new System.Drawing.Point(12, 11);
            this.familleListView.Name = "familleListView";
            this.familleListView.Size = new System.Drawing.Size(338, 400);
            this.familleListView.TabIndex = 1;
            this.familleListView.UseCompatibleStateImageBehavior = false;
            this.familleListView.View = System.Windows.Forms.View.Details;
            this.familleListView.SelectedIndexChanged += new System.EventHandler(this.familleListView_SelectedIndexChanged);
            this.familleListView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.familleListView_KeyDown);
            this.familleListView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.OnRightClick);
            this.familleListView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.familleListView_MouseDoubleClick);
            // 
            // Column_Reference_Famille
            // 
            this.Column_Reference_Famille.Text = "Reference";
            this.Column_Reference_Famille.Width = 155;
            // 
            // Column_Nom_Famille
            // 
            this.Column_Nom_Famille.Text = "Famille";
            this.Column_Nom_Famille.Width = 179;
            // 
            // FamilyStrip
            // 
            this.FamilyStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteToolStripMenuItem,
            this.deleteToolStripMenuItem1});
            this.FamilyStrip.Name = "FamilyStrip";
            this.FamilyStrip.Size = new System.Drawing.Size(153, 70);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.deleteToolStripMenuItem.Text = "Add";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.AddToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem1
            // 
            this.deleteToolStripMenuItem1.Name = "deleteToolStripMenuItem1";
            this.deleteToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.deleteToolStripMenuItem1.Text = "Delete";
            this.deleteToolStripMenuItem1.Click += new System.EventHandler(this.DeleteToolStripMenuItem1_Click);
            // 
            // DisplayFamille
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 419);
            this.Controls.Add(this.familleListView);
            this.Name = "DisplayFamille";
            this.Text = "DisplayFamille";
            this.FamilyStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView familleListView;
        private System.Windows.Forms.ColumnHeader Column_Reference_Famille;
        private System.Windows.Forms.ColumnHeader Column_Nom_Famille;
        private System.Windows.Forms.ContextMenuStrip FamilyStrip;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem1;
    }
}