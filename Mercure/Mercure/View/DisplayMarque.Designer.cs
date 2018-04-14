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
            this.List_View_Marque = new System.Windows.Forms.ListView();
            this.Column_Reference_Marque = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Column_Nom_Marque = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
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
            this.List_View_Marque.Location = new System.Drawing.Point(12, 12);
            this.List_View_Marque.Name = "List_View_Marque";
            this.List_View_Marque.Size = new System.Drawing.Size(343, 414);
            this.List_View_Marque.TabIndex = 1;
            this.List_View_Marque.UseCompatibleStateImageBehavior = false;
            this.List_View_Marque.View = System.Windows.Forms.View.Details;
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
            // DisplayMarque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 440);
            this.Controls.Add(this.List_View_Marque);
            this.Name = "DisplayMarque";
            this.Text = "DisplayMarque";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView List_View_Marque;
        private System.Windows.Forms.ColumnHeader Column_Reference_Marque;
        private System.Windows.Forms.ColumnHeader Column_Nom_Marque;
    }
}