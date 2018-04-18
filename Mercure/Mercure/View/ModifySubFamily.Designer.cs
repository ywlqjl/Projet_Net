namespace Mercure.View
{
    partial class ModifySubFamily
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
            this.comboBox_F = new System.Windows.Forms.ComboBox();
            this.textBox_NameSF = new System.Windows.Forms.TextBox();
            this.textBox_RefSF = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Btn_SF_Cancel = new System.Windows.Forms.Button();
            this.Btn_SF_Submit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox_F);
            this.groupBox1.Controls.Add(this.textBox_NameSF);
            this.groupBox1.Controls.Add(this.textBox_RefSF);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(22, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(487, 182);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ModifySubFamily";
            // 
            // comboBox_F
            // 
            this.comboBox_F.FormattingEnabled = true;
            this.comboBox_F.Location = new System.Drawing.Point(145, 136);
            this.comboBox_F.Name = "comboBox_F";
            this.comboBox_F.Size = new System.Drawing.Size(320, 26);
            this.comboBox_F.TabIndex = 5;
            this.comboBox_F.SelectedIndexChanged += new System.EventHandler(this.comboBox_F_SelectedIndexChanged);
            // 
            // textBox_NameSF
            // 
            this.textBox_NameSF.Location = new System.Drawing.Point(145, 88);
            this.textBox_NameSF.Name = "textBox_NameSF";
            this.textBox_NameSF.Size = new System.Drawing.Size(320, 28);
            this.textBox_NameSF.TabIndex = 4;
            this.textBox_NameSF.TextChanged += new System.EventHandler(this.textBox_NameSF_TextChanged);
            // 
            // textBox_RefSF
            // 
            this.textBox_RefSF.Enabled = false;
            this.textBox_RefSF.Location = new System.Drawing.Point(145, 46);
            this.textBox_RefSF.Name = "textBox_RefSF";
            this.textBox_RefSF.Size = new System.Drawing.Size(320, 28);
            this.textBox_RefSF.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Family";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Reference";
            // 
            // Btn_SF_Cancel
            // 
            this.Btn_SF_Cancel.Location = new System.Drawing.Point(338, 238);
            this.Btn_SF_Cancel.Name = "Btn_SF_Cancel";
            this.Btn_SF_Cancel.Size = new System.Drawing.Size(94, 37);
            this.Btn_SF_Cancel.TabIndex = 2;
            this.Btn_SF_Cancel.Text = "Cancel";
            this.Btn_SF_Cancel.UseVisualStyleBackColor = true;
            this.Btn_SF_Cancel.Click += new System.EventHandler(this.button2_Click);
            // 
            // Btn_SF_Submit
            // 
            this.Btn_SF_Submit.Location = new System.Drawing.Point(193, 238);
            this.Btn_SF_Submit.Name = "Btn_SF_Submit";
            this.Btn_SF_Submit.Size = new System.Drawing.Size(91, 37);
            this.Btn_SF_Submit.TabIndex = 3;
            this.Btn_SF_Submit.Text = "Submit";
            this.Btn_SF_Submit.UseVisualStyleBackColor = true;
            this.Btn_SF_Submit.Click += new System.EventHandler(this.Btn_SF_Submit_Click);
            // 
            // ModifySubFamily
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 310);
            this.Controls.Add(this.Btn_SF_Submit);
            this.Controls.Add(this.Btn_SF_Cancel);
            this.Controls.Add(this.groupBox1);
            this.Name = "ModifySubFamily";
            this.Text = "ModifySubFamily";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBox_F;
        private System.Windows.Forms.TextBox textBox_NameSF;
        private System.Windows.Forms.TextBox textBox_RefSF;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btn_SF_Cancel;
        private System.Windows.Forms.Button Btn_SF_Submit;
    }
}