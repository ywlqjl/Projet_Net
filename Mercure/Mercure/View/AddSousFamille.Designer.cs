﻿namespace Mercure.View
{
    partial class AddSousFamille
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Combo_Box_Famille = new System.Windows.Forms.ComboBox();
            this.Text_Box_Name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Text_Box_Reference = new System.Windows.Forms.TextBox();
            this.Btn_Cancel_Sous_Famille = new System.Windows.Forms.Button();
            this.Btn_Add_Sous_Famille = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Combo_Box_Famille);
            this.groupBox1.Controls.Add(this.Text_Box_Name);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Text_Box_Reference);
            this.groupBox1.Location = new System.Drawing.Point(22, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(325, 102);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Sub Familly";
            // 
            // Combo_Box_Famille
            // 
            this.Combo_Box_Famille.FormattingEnabled = true;
            this.Combo_Box_Famille.Location = new System.Drawing.Point(117, 71);
            this.Combo_Box_Famille.Name = "Combo_Box_Famille";
            this.Combo_Box_Famille.Size = new System.Drawing.Size(200, 20);
            this.Combo_Box_Famille.TabIndex = 6;
            // 
            // Text_Box_Name
            // 
            this.Text_Box_Name.Location = new System.Drawing.Point(117, 47);
            this.Text_Box_Name.Name = "Text_Box_Name";
            this.Text_Box_Name.Size = new System.Drawing.Size(200, 21);
            this.Text_Box_Name.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "Familly : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "Name : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "Reference : ";
            // 
            // Text_Box_Reference
            // 
            this.Text_Box_Reference.Enabled = false;
            this.Text_Box_Reference.Location = new System.Drawing.Point(117, 23);
            this.Text_Box_Reference.Name = "Text_Box_Reference";
            this.Text_Box_Reference.Size = new System.Drawing.Size(200, 21);
            this.Text_Box_Reference.TabIndex = 0;
            // 
            // Btn_Cancel_Sous_Famille
            // 
            this.Btn_Cancel_Sous_Famille.Location = new System.Drawing.Point(272, 128);
            this.Btn_Cancel_Sous_Famille.Name = "Btn_Cancel_Sous_Famille";
            this.Btn_Cancel_Sous_Famille.Size = new System.Drawing.Size(75, 21);
            this.Btn_Cancel_Sous_Famille.TabIndex = 5;
            this.Btn_Cancel_Sous_Famille.Text = "Cancel";
            this.Btn_Cancel_Sous_Famille.UseVisualStyleBackColor = true;
            this.Btn_Cancel_Sous_Famille.Click += new System.EventHandler(this.Btn_Cancel_Sous_Famille_Click);
            // 
            // Btn_Add_Sous_Famille
            // 
            this.Btn_Add_Sous_Famille.Location = new System.Drawing.Point(191, 128);
            this.Btn_Add_Sous_Famille.Name = "Btn_Add_Sous_Famille";
            this.Btn_Add_Sous_Famille.Size = new System.Drawing.Size(75, 21);
            this.Btn_Add_Sous_Famille.TabIndex = 4;
            this.Btn_Add_Sous_Famille.Text = "Add";
            this.Btn_Add_Sous_Famille.UseVisualStyleBackColor = true;
            this.Btn_Add_Sous_Famille.Click += new System.EventHandler(this.Btn_Add_Sous_Famille_Click);
            // 
            // AddSousFamille
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 155);
            this.Controls.Add(this.Btn_Cancel_Sous_Famille);
            this.Controls.Add(this.Btn_Add_Sous_Famille);
            this.Controls.Add(this.groupBox1);
            this.Name = "AddSousFamille";
            this.Text = "AddSousFamille";
            this.Load += new System.EventHandler(this.AddSousFamille_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox Combo_Box_Famille;
        private System.Windows.Forms.TextBox Text_Box_Name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Text_Box_Reference;
        private System.Windows.Forms.Button Btn_Cancel_Sous_Famille;
        private System.Windows.Forms.Button Btn_Add_Sous_Famille;
    }
}