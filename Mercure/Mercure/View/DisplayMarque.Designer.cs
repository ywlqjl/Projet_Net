namespace Mercure.View
{
    partial class DisplayMarque
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
            this.List_View_Marque = new System.Windows.Forms.ListView();
            this.Column_Reference_Marque = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Column_Nom_Marque = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MarkMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MarkMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // List_View_Marque
            // 
            this.List_View_Marque.BackColor = System.Drawing.SystemColors.Window;
            this.List_View_Marque.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Column_Reference_Marque,
            this.Column_Nom_Marque});
            this.List_View_Marque.FullRowSelect = true;
            this.List_View_Marque.GridLines = true;
            this.List_View_Marque.Location = new System.Drawing.Point(12, 11);
            this.List_View_Marque.Name = "List_View_Marque";
            this.List_View_Marque.Size = new System.Drawing.Size(343, 383);
            this.List_View_Marque.TabIndex = 1;
            this.List_View_Marque.UseCompatibleStateImageBehavior = false;
            this.List_View_Marque.View = System.Windows.Forms.View.Details;
            this.List_View_Marque.SelectedIndexChanged += new System.EventHandler(this.List_View_Marque_SelectedIndexChanged);
            this.List_View_Marque.KeyDown += new System.Windows.Forms.KeyEventHandler(this.List_View_Marque_KeyDown);
            this.List_View_Marque.MouseClick += new System.Windows.Forms.MouseEventHandler(this.OnRightClick);
            this.List_View_Marque.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.List_View_Marque_MouseDoubleClick);
            // 
            // Column_Reference_Marque
            // 
            this.Column_Reference_Marque.Text = "Reference";
            this.Column_Reference_Marque.Width = 150;
            // 
            // Column_Nom_Marque
            // 
            this.Column_Nom_Marque.Text = "Marque";
            this.Column_Nom_Marque.Width = 189;
            // 
            // MarkMenuStrip
            // 
            this.MarkMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.MarkMenuStrip.Name = "MarkMenuStrip";
            this.MarkMenuStrip.Size = new System.Drawing.Size(114, 48);
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
            // DisplayMarque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 406);
            this.Controls.Add(this.List_View_Marque);
            this.Name = "DisplayMarque";
            this.Text = "DisplayMarque";
            this.MarkMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView List_View_Marque;
        private System.Windows.Forms.ColumnHeader Column_Reference_Marque;
        private System.Windows.Forms.ColumnHeader Column_Nom_Marque;
        private System.Windows.Forms.ContextMenuStrip MarkMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
    }
}