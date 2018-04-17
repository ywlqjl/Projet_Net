namespace Mercure.View
{
    partial class AddFamille
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Text_Box_Name = new System.Windows.Forms.TextBox();
            this.Text_Box_Reference = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Btn_Cancel_Famille = new System.Windows.Forms.Button();
            this.Btn_Add_Famille = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Text_Box_Name);
            this.groupBox2.Controls.Add(this.Text_Box_Reference);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(306, 88);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Add Familly";
            // 
            // Text_Box_Name
            // 
            this.Text_Box_Name.Location = new System.Drawing.Point(94, 56);
            this.Text_Box_Name.Name = "Text_Box_Name";
            this.Text_Box_Name.Size = new System.Drawing.Size(199, 20);
            this.Text_Box_Name.TabIndex = 3;
            // 
            // Text_Box_Reference
            // 
            this.Text_Box_Reference.Location = new System.Drawing.Point(94, 30);
            this.Text_Box_Reference.Name = "Text_Box_Reference";
            this.Text_Box_Reference.Size = new System.Drawing.Size(199, 20);
            this.Text_Box_Reference.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Name  :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Reference  :";
            // 
            // Btn_Cancel_Famille
            // 
            this.Btn_Cancel_Famille.Location = new System.Drawing.Point(243, 106);
            this.Btn_Cancel_Famille.Name = "Btn_Cancel_Famille";
            this.Btn_Cancel_Famille.Size = new System.Drawing.Size(75, 23);
            this.Btn_Cancel_Famille.TabIndex = 5;
            this.Btn_Cancel_Famille.Text = "Cancel";
            this.Btn_Cancel_Famille.UseVisualStyleBackColor = true;
            this.Btn_Cancel_Famille.Click += new System.EventHandler(this.Btn_Cancel_Famille_Click);
            // 
            // Btn_Add_Famille
            // 
            this.Btn_Add_Famille.Location = new System.Drawing.Point(162, 106);
            this.Btn_Add_Famille.Name = "Btn_Add_Famille";
            this.Btn_Add_Famille.Size = new System.Drawing.Size(75, 23);
            this.Btn_Add_Famille.TabIndex = 4;
            this.Btn_Add_Famille.Text = "Add";
            this.Btn_Add_Famille.UseVisualStyleBackColor = true;
            this.Btn_Add_Famille.Click += new System.EventHandler(this.Btn_Add_Famille_Click);
            // 
            // AddFamille
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 137);
            this.Controls.Add(this.Btn_Cancel_Famille);
            this.Controls.Add(this.Btn_Add_Famille);
            this.Controls.Add(this.groupBox2);
            this.Name = "AddFamille";
            this.Text = "AddFamille";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox Text_Box_Name;
        private System.Windows.Forms.TextBox Text_Box_Reference;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Btn_Cancel_Famille;
        private System.Windows.Forms.Button Btn_Add_Famille;
    }
}