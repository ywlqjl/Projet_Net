namespace Mercure
{
    partial class Main
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.articleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supprimerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.familleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.afficherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.sousFamilleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.afficherToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.marqueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.afficherToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.listView_ShowBD = new System.Windows.Forms.ListView();
            this.RefArticle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Description = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SubFamilly = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Brand = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PriceHT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Quantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Btn_UpdateListView = new System.Windows.Forms.Button();
            this.Label_TotalCount = new System.Windows.Forms.Label();
            this.Strip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.AddArticleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ModifyArticleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteArticleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.Strip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.articleToolStripMenuItem,
            this.familleToolStripMenuItem,
            this.sousFamilleToolStripMenuItem,
            this.marqueToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(7, 7);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(829, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(39, 22);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // articleToolStripMenuItem
            // 
            this.articleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterToolStripMenuItem,
            this.modifierToolStripMenuItem,
            this.supprimerToolStripMenuItem});
            this.articleToolStripMenuItem.Name = "articleToolStripMenuItem";
            this.articleToolStripMenuItem.Size = new System.Drawing.Size(56, 22);
            this.articleToolStripMenuItem.Text = "Article";
            // 
            // ajouterToolStripMenuItem
            // 
            this.ajouterToolStripMenuItem.Name = "ajouterToolStripMenuItem";
            this.ajouterToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.ajouterToolStripMenuItem.Text = "Add";
            this.ajouterToolStripMenuItem.Click += new System.EventHandler(this.ajouterToolStripMenuItem_Click);
            // 
            // modifierToolStripMenuItem
            // 
            this.modifierToolStripMenuItem.Name = "modifierToolStripMenuItem";
            this.modifierToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.modifierToolStripMenuItem.Text = "Modify";
            // 
            // supprimerToolStripMenuItem
            // 
            this.supprimerToolStripMenuItem.Name = "supprimerToolStripMenuItem";
            this.supprimerToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.supprimerToolStripMenuItem.Text = "Delete";
            // 
            // familleToolStripMenuItem
            // 
            this.familleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.afficherToolStripMenuItem,
            this.ajouterToolStripMenuItem1});
            this.familleToolStripMenuItem.Name = "familleToolStripMenuItem";
            this.familleToolStripMenuItem.Size = new System.Drawing.Size(59, 22);
            this.familleToolStripMenuItem.Text = "Familly";
            // 
            // afficherToolStripMenuItem
            // 
            this.afficherToolStripMenuItem.Name = "afficherToolStripMenuItem";
            this.afficherToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.afficherToolStripMenuItem.Text = "Show";
            this.afficherToolStripMenuItem.Click += new System.EventHandler(this.afficherToolStripMenuItem_Click);
            // 
            // ajouterToolStripMenuItem1
            // 
            this.ajouterToolStripMenuItem1.Name = "ajouterToolStripMenuItem1";
            this.ajouterToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.ajouterToolStripMenuItem1.Text = "Add";
            this.ajouterToolStripMenuItem1.Click += new System.EventHandler(this.ajouterToolStripMenuItem1_Click);
            // 
            // sousFamilleToolStripMenuItem
            // 
            this.sousFamilleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.afficherToolStripMenuItem1,
            this.ajouterToolStripMenuItem2});
            this.sousFamilleToolStripMenuItem.Name = "sousFamilleToolStripMenuItem";
            this.sousFamilleToolStripMenuItem.Size = new System.Drawing.Size(85, 22);
            this.sousFamilleToolStripMenuItem.Text = "Sub Familly";
            // 
            // afficherToolStripMenuItem1
            // 
            this.afficherToolStripMenuItem1.Name = "afficherToolStripMenuItem1";
            this.afficherToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.afficherToolStripMenuItem1.Text = "Show";
            this.afficherToolStripMenuItem1.Click += new System.EventHandler(this.afficherToolStripMenuItem1_Click);
            // 
            // ajouterToolStripMenuItem2
            // 
            this.ajouterToolStripMenuItem2.Name = "ajouterToolStripMenuItem2";
            this.ajouterToolStripMenuItem2.Size = new System.Drawing.Size(152, 22);
            this.ajouterToolStripMenuItem2.Text = "Add";
            this.ajouterToolStripMenuItem2.Click += new System.EventHandler(this.ajouterToolStripMenuItem2_Click);
            // 
            // marqueToolStripMenuItem
            // 
            this.marqueToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.afficherToolStripMenuItem3,
            this.ajouterToolStripMenuItem3});
            this.marqueToolStripMenuItem.Name = "marqueToolStripMenuItem";
            this.marqueToolStripMenuItem.Size = new System.Drawing.Size(55, 22);
            this.marqueToolStripMenuItem.Text = "Brand";
            // 
            // afficherToolStripMenuItem3
            // 
            this.afficherToolStripMenuItem3.Name = "afficherToolStripMenuItem3";
            this.afficherToolStripMenuItem3.Size = new System.Drawing.Size(152, 22);
            this.afficherToolStripMenuItem3.Text = "Show";
            this.afficherToolStripMenuItem3.Click += new System.EventHandler(this.afficherToolStripMenuItem3_Click);
            // 
            // ajouterToolStripMenuItem3
            // 
            this.ajouterToolStripMenuItem3.Name = "ajouterToolStripMenuItem3";
            this.ajouterToolStripMenuItem3.Size = new System.Drawing.Size(152, 22);
            this.ajouterToolStripMenuItem3.Text = "Add";
            this.ajouterToolStripMenuItem3.Click += new System.EventHandler(this.ajouterToolStripMenuItem3_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Location = new System.Drawing.Point(7, 425);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 9, 0);
            this.statusStrip1.Size = new System.Drawing.Size(829, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // listView_ShowBD
            // 
            this.listView_ShowBD.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView_ShowBD.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.RefArticle,
            this.Description,
            this.SubFamilly,
            this.Brand,
            this.PriceHT,
            this.Quantity});
            this.listView_ShowBD.FullRowSelect = true;
            this.listView_ShowBD.Location = new System.Drawing.Point(44, 52);
            this.listView_ShowBD.Margin = new System.Windows.Forms.Padding(2);
            this.listView_ShowBD.MultiSelect = false;
            this.listView_ShowBD.Name = "listView_ShowBD";
            this.listView_ShowBD.Size = new System.Drawing.Size(737, 268);
            this.listView_ShowBD.TabIndex = 2;
            this.listView_ShowBD.UseCompatibleStateImageBehavior = false;
            this.listView_ShowBD.View = System.Windows.Forms.View.Details;
            this.listView_ShowBD.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.ColumnClickFunction);
            this.listView_ShowBD.SelectedIndexChanged += new System.EventHandler(this.listView_ShowBD_SelectedIndexChanged);
            this.listView_ShowBD.MouseClick += new System.Windows.Forms.MouseEventHandler(this.OnRightClick);
            this.listView_ShowBD.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView_ShowBD_MouseDoubleClick);
            // 
            // RefArticle
            // 
            this.RefArticle.Text = "RefArticle";
            this.RefArticle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.RefArticle.Width = 100;
            // 
            // Description
            // 
            this.Description.Text = "Description";
            this.Description.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Description.Width = 100;
            // 
            // SubFamilly
            // 
            this.SubFamilly.Text = "SubFamilly";
            this.SubFamilly.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.SubFamilly.Width = 130;
            // 
            // Brand
            // 
            this.Brand.Text = "Brand";
            this.Brand.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Brand.Width = 158;
            // 
            // PriceHT
            // 
            this.PriceHT.Text = "Price";
            this.PriceHT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Quantity
            // 
            this.Quantity.Text = "Quantity";
            this.Quantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Quantity.Width = 125;
            // 
            // Btn_UpdateListView
            // 
            this.Btn_UpdateListView.AutoSize = true;
            this.Btn_UpdateListView.Location = new System.Drawing.Point(717, 337);
            this.Btn_UpdateListView.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_UpdateListView.Name = "Btn_UpdateListView";
            this.Btn_UpdateListView.Size = new System.Drawing.Size(63, 23);
            this.Btn_UpdateListView.TabIndex = 3;
            this.Btn_UpdateListView.Text = "Delete";
            this.Btn_UpdateListView.UseVisualStyleBackColor = true;
            this.Btn_UpdateListView.Click += new System.EventHandler(this.Btn_DeleteArticle_Click);
            // 
            // Label_TotalCount
            // 
            this.Label_TotalCount.AutoSize = true;
            this.Label_TotalCount.Location = new System.Drawing.Point(44, 326);
            this.Label_TotalCount.Name = "Label_TotalCount";
            this.Label_TotalCount.Size = new System.Drawing.Size(59, 12);
            this.Label_TotalCount.TabIndex = 4;
            this.Label_TotalCount.Text = "Lbl_Total";
            // 
            // Strip
            // 
            this.Strip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddArticleToolStripMenuItem,
            this.ModifyArticleToolStripMenuItem,
            this.DeleteArticleToolStripMenuItem});
            this.Strip.Name = "Strip";
            this.Strip.Size = new System.Drawing.Size(158, 70);
            // 
            // AddArticleToolStripMenuItem
            // 
            this.AddArticleToolStripMenuItem.Name = "AddArticleToolStripMenuItem";
            this.AddArticleToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.AddArticleToolStripMenuItem.Text = "Add Article";
            this.AddArticleToolStripMenuItem.Click += new System.EventHandler(this.AddArticleToolStripMenuItem_Click);
            // 
            // ModifyArticleToolStripMenuItem
            // 
            this.ModifyArticleToolStripMenuItem.Name = "ModifyArticleToolStripMenuItem";
            this.ModifyArticleToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.ModifyArticleToolStripMenuItem.Text = "Modify Article";
            this.ModifyArticleToolStripMenuItem.Click += new System.EventHandler(this.ModifyArticleToolStripMenuItem_Click);
            // 
            // DeleteArticleToolStripMenuItem
            // 
            this.DeleteArticleToolStripMenuItem.Name = "DeleteArticleToolStripMenuItem";
            this.DeleteArticleToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.DeleteArticleToolStripMenuItem.Text = "Delete Article";
            this.DeleteArticleToolStripMenuItem.Click += new System.EventHandler(this.DeleteArticleToolStripMenuItem_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 454);
            this.Controls.Add(this.Label_TotalCount);
            this.Controls.Add(this.Btn_UpdateListView);
            this.Controls.Add(this.listView_ShowBD);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(1043, 594);
            this.MinimumSize = new System.Drawing.Size(857, 489);
            this.Name = "Main";
            this.Padding = new System.Windows.Forms.Padding(7);
            this.Text = "Form1";
            this.DoubleClick += new System.EventHandler(this.listView_ShowBD_SelectedIndexChanged);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.Strip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ListView listView_ShowBD;
        private System.Windows.Forms.ColumnHeader RefArticle;
        private System.Windows.Forms.ColumnHeader Description;
        private System.Windows.Forms.ColumnHeader SubFamilly;
        private System.Windows.Forms.ColumnHeader Brand;
        private System.Windows.Forms.ColumnHeader PriceHT;
        private System.Windows.Forms.ColumnHeader Quantity;
        private System.Windows.Forms.Button Btn_UpdateListView;
        private System.Windows.Forms.Label Label_TotalCount;
        private System.Windows.Forms.ToolStripMenuItem articleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supprimerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem familleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem afficherToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem sousFamilleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem afficherToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ajouterToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem marqueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem afficherToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem ajouterToolStripMenuItem3;
        private System.Windows.Forms.ContextMenuStrip Strip;
        private System.Windows.Forms.ToolStripMenuItem AddArticleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ModifyArticleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DeleteArticleToolStripMenuItem;
    }
}

