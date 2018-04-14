namespace Mercure.View
{
    partial class AddMarque
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
            this.Text_Box_Name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Text_Box_Reference = new System.Windows.Forms.TextBox();
            this.Btn_Cancel_Marque = new System.Windows.Forms.Button();
            this.Btn_Add_Marque = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Text_Box_Name);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Text_Box_Reference);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(287, 82);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Marque";
            // 
            // Text_Box_Name
            // 
            this.Text_Box_Name.Location = new System.Drawing.Point(88, 48);
            this.Text_Box_Name.Name = "Text_Box_Name";
            this.Text_Box_Name.Size = new System.Drawing.Size(188, 20);
            this.Text_Box_Name.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nom :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Reference :";
            // 
            // Text_Box_Reference
            // 
            this.Text_Box_Reference.Location = new System.Drawing.Point(88, 22);
            this.Text_Box_Reference.Name = "Text_Box_Reference";
            this.Text_Box_Reference.Size = new System.Drawing.Size(188, 20);
            this.Text_Box_Reference.TabIndex = 0;
            // 
            // Btn_Cancel_Marque
            // 
            this.Btn_Cancel_Marque.Location = new System.Drawing.Point(224, 100);
            this.Btn_Cancel_Marque.Name = "Btn_Cancel_Marque";
            this.Btn_Cancel_Marque.Size = new System.Drawing.Size(75, 23);
            this.Btn_Cancel_Marque.TabIndex = 5;
            this.Btn_Cancel_Marque.Text = "Cancel";
            this.Btn_Cancel_Marque.UseVisualStyleBackColor = true;
            // 
            // Btn_Add_Marque
            // 
            this.Btn_Add_Marque.Location = new System.Drawing.Point(143, 100);
            this.Btn_Add_Marque.Name = "Btn_Add_Marque";
            this.Btn_Add_Marque.Size = new System.Drawing.Size(75, 23);
            this.Btn_Add_Marque.TabIndex = 4;
            this.Btn_Add_Marque.Text = "Add";
            this.Btn_Add_Marque.UseVisualStyleBackColor = true;
            // 
            // AddMarque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 131);
            this.Controls.Add(this.Btn_Cancel_Marque);
            this.Controls.Add(this.Btn_Add_Marque);
            this.Controls.Add(this.groupBox1);
            this.Name = "AddMarque";
            this.Text = "AddMarque";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox Text_Box_Name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Text_Box_Reference;
        private System.Windows.Forms.Button Btn_Cancel_Marque;
        private System.Windows.Forms.Button Btn_Add_Marque;
    }
}