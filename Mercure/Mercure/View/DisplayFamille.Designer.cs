﻿namespace Mercure.View
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
            this.familleListView = new System.Windows.Forms.ListView();
            this.Column_Reference_Famille = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Column_Nom_Famille = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
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
            this.familleListView.Location = new System.Drawing.Point(12, 12);
            this.familleListView.Name = "familleListView";
            this.familleListView.Size = new System.Drawing.Size(338, 433);
            this.familleListView.TabIndex = 1;
            this.familleListView.UseCompatibleStateImageBehavior = false;
            this.familleListView.View = System.Windows.Forms.View.Details;
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
            // DisplayFamille
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 454);
            this.Controls.Add(this.familleListView);
            this.Name = "DisplayFamille";
            this.Text = "DisplayFamille";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView familleListView;
        private System.Windows.Forms.ColumnHeader Column_Reference_Famille;
        private System.Windows.Forms.ColumnHeader Column_Nom_Famille;
    }
}