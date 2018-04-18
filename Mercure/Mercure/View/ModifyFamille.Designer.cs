namespace Mercure.View
{
    partial class ModifyFamille
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBox_ReferenceF = new System.Windows.Forms.TextBox();
            this.txtBox_NameF = new System.Windows.Forms.TextBox();
            this.Btn_MF_Submit = new System.Windows.Forms.Button();
            this.Btn_MF_Cancel = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Reference";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name";
            // 
            // txtBox_ReferenceF
            // 
            this.txtBox_ReferenceF.Enabled = false;
            this.txtBox_ReferenceF.Location = new System.Drawing.Point(120, 48);
            this.txtBox_ReferenceF.Name = "txtBox_ReferenceF";
            this.txtBox_ReferenceF.Size = new System.Drawing.Size(342, 28);
            this.txtBox_ReferenceF.TabIndex = 3;
            this.txtBox_ReferenceF.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtBox_NameF
            // 
            this.txtBox_NameF.Location = new System.Drawing.Point(120, 92);
            this.txtBox_NameF.Name = "txtBox_NameF";
            this.txtBox_NameF.Size = new System.Drawing.Size(342, 28);
            this.txtBox_NameF.TabIndex = 4;
            this.txtBox_NameF.TextChanged += new System.EventHandler(this.txtBox_NameF_TextChanged);
            // 
            // Btn_MF_Submit
            // 
            this.Btn_MF_Submit.Location = new System.Drawing.Point(183, 170);
            this.Btn_MF_Submit.Name = "Btn_MF_Submit";
            this.Btn_MF_Submit.Size = new System.Drawing.Size(93, 36);
            this.Btn_MF_Submit.TabIndex = 5;
            this.Btn_MF_Submit.Text = "Submit";
            this.Btn_MF_Submit.UseVisualStyleBackColor = true;
            this.Btn_MF_Submit.Click += new System.EventHandler(this.Btn_MF_Submit_Click);
            // 
            // Btn_MF_Cancel
            // 
            this.Btn_MF_Cancel.Location = new System.Drawing.Point(356, 170);
            this.Btn_MF_Cancel.Name = "Btn_MF_Cancel";
            this.Btn_MF_Cancel.Size = new System.Drawing.Size(89, 36);
            this.Btn_MF_Cancel.TabIndex = 6;
            this.Btn_MF_Cancel.Text = "Cancel";
            this.Btn_MF_Cancel.UseVisualStyleBackColor = true;
            this.Btn_MF_Cancel.Click += new System.EventHandler(this.Btn_MF_Cancel_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtBox_ReferenceF);
            this.groupBox1.Controls.Add(this.txtBox_NameF);
            this.groupBox1.Location = new System.Drawing.Point(12, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(496, 151);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ModifyFamily";
            // 
            // ModifyFamille
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 224);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Btn_MF_Cancel);
            this.Controls.Add(this.Btn_MF_Submit);
            this.MaximumSize = new System.Drawing.Size(540, 280);
            this.MinimumSize = new System.Drawing.Size(540, 280);
            this.Name = "ModifyFamille";
            this.Text = "ModifyFamille";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBox_ReferenceF;
        private System.Windows.Forms.TextBox txtBox_NameF;
        private System.Windows.Forms.Button Btn_MF_Submit;
        private System.Windows.Forms.Button Btn_MF_Cancel;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}