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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
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
            this.listView_ShowBD.Location = new System.Drawing.Point(44, 52);
            this.listView_ShowBD.Margin = new System.Windows.Forms.Padding(2);
            this.listView_ShowBD.Name = "listView_ShowBD";
            this.listView_ShowBD.Size = new System.Drawing.Size(737, 268);
            this.listView_ShowBD.TabIndex = 2;
            this.listView_ShowBD.UseCompatibleStateImageBehavior = false;
            this.listView_ShowBD.View = System.Windows.Forms.View.Details;
            this.listView_ShowBD.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.ColumnClickFunction);
            this.listView_ShowBD.SelectedIndexChanged += new System.EventHandler(this.listView_ShowBD_SelectedIndexChanged);
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
            this.Btn_UpdateListView.Text = "Update";
            this.Btn_UpdateListView.UseVisualStyleBackColor = true;
            this.Btn_UpdateListView.Click += new System.EventHandler(this.Btn_UpdataListView_Click);
            // 
            // Label_TotalCount
            // 
            this.Label_TotalCount.AutoSize = true;
            this.Label_TotalCount.Location = new System.Drawing.Point(44, 326);
            this.Label_TotalCount.Name = "Label_TotalCount";
            this.Label_TotalCount.Size = new System.Drawing.Size(41, 12);
            this.Label_TotalCount.TabIndex = 4;
            this.Label_TotalCount.Text = "label1";
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
            this.MaximumSize = new System.Drawing.Size(1045, 598);
            this.MinimumSize = new System.Drawing.Size(859, 493);
            this.Name = "Main";
            this.Padding = new System.Windows.Forms.Padding(7);
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
    }
}

