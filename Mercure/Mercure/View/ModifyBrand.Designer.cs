namespace Mercure.View
{
    partial class ModifyBrand
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
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Btn_MB_Submit = new System.Windows.Forms.Button();
            this.Btn_MB_Cancel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(35, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(496, 142);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Modify Brand ";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(154, 89);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(321, 28);
            this.textBox2.TabIndex = 3;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(154, 46);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(321, 28);
            this.textBox1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Reference";
            // 
            // Btn_MB_Submit
            // 
            this.Btn_MB_Submit.Location = new System.Drawing.Point(158, 192);
            this.Btn_MB_Submit.Name = "Btn_MB_Submit";
            this.Btn_MB_Submit.Size = new System.Drawing.Size(85, 30);
            this.Btn_MB_Submit.TabIndex = 1;
            this.Btn_MB_Submit.Text = "Submit";
            this.Btn_MB_Submit.UseVisualStyleBackColor = true;
            this.Btn_MB_Submit.Click += new System.EventHandler(this.Btn_MB_Submit_Click);
            // 
            // Btn_MB_Cancel
            // 
            this.Btn_MB_Cancel.Location = new System.Drawing.Point(324, 192);
            this.Btn_MB_Cancel.Name = "Btn_MB_Cancel";
            this.Btn_MB_Cancel.Size = new System.Drawing.Size(92, 30);
            this.Btn_MB_Cancel.TabIndex = 2;
            this.Btn_MB_Cancel.Text = "Cancel";
            this.Btn_MB_Cancel.UseVisualStyleBackColor = true;
            this.Btn_MB_Cancel.Click += new System.EventHandler(this.button2_Click);
            // 
            // ModifyBrand
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 247);
            this.Controls.Add(this.Btn_MB_Cancel);
            this.Controls.Add(this.Btn_MB_Submit);
            this.Controls.Add(this.groupBox1);
            this.Name = "ModifyBrand";
            this.Text = "ModifyBrand";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btn_MB_Submit;
        private System.Windows.Forms.Button Btn_MB_Cancel;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
    }
}