namespace Mercure.View
{
    partial class ModifyArticle
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
            this.Btn_SubmitModifyArticle = new System.Windows.Forms.Button();
            this.Btn_CancelModifyArticle = new System.Windows.Forms.Button();
            this.label_RefArticle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_RefArticle = new System.Windows.Forms.TextBox();
            this.textBox_Description = new System.Windows.Forms.TextBox();
            this.textBox_PriceHT = new System.Windows.Forms.TextBox();
            this.textBox_Quantity = new System.Windows.Forms.TextBox();
            this.comboBox_SubFamily = new System.Windows.Forms.ComboBox();
            this.comboBox_Brand = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // Btn_SubmitModifyArticle
            // 
            this.Btn_SubmitModifyArticle.Location = new System.Drawing.Point(913, 141);
            this.Btn_SubmitModifyArticle.Name = "Btn_SubmitModifyArticle";
            this.Btn_SubmitModifyArticle.Size = new System.Drawing.Size(113, 46);
            this.Btn_SubmitModifyArticle.TabIndex = 1;
            this.Btn_SubmitModifyArticle.Text = "Submit";
            this.Btn_SubmitModifyArticle.UseVisualStyleBackColor = true;
            this.Btn_SubmitModifyArticle.Click += new System.EventHandler(this.Btn_SubmitModifyArticle_Click);
            // 
            // Btn_CancelModifyArticle
            // 
            this.Btn_CancelModifyArticle.Location = new System.Drawing.Point(1046, 141);
            this.Btn_CancelModifyArticle.Name = "Btn_CancelModifyArticle";
            this.Btn_CancelModifyArticle.Size = new System.Drawing.Size(113, 46);
            this.Btn_CancelModifyArticle.TabIndex = 2;
            this.Btn_CancelModifyArticle.Text = "Cancel";
            this.Btn_CancelModifyArticle.UseVisualStyleBackColor = true;
            this.Btn_CancelModifyArticle.Click += new System.EventHandler(this.Btn_CancelModifyArticle_Click);
            // 
            // label_RefArticle
            // 
            this.label_RefArticle.AutoSize = true;
            this.label_RefArticle.Location = new System.Drawing.Point(90, 41);
            this.label_RefArticle.Name = "label_RefArticle";
            this.label_RefArticle.Size = new System.Drawing.Size(98, 18);
            this.label_RefArticle.TabIndex = 5;
            this.label_RefArticle.Text = "RefArticle";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(241, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "Description";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(521, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 18);
            this.label2.TabIndex = 7;
            this.label2.Text = "SubFamily";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(780, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 18);
            this.label3.TabIndex = 8;
            this.label3.Text = "Brand";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(946, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 18);
            this.label4.TabIndex = 9;
            this.label4.Text = "PriceHT";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1065, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 18);
            this.label5.TabIndex = 10;
            this.label5.Text = "Quantity";
            // 
            // textBox_RefArticle
            // 
            this.textBox_RefArticle.Enabled = false;
            this.textBox_RefArticle.Font = new System.Drawing.Font("SimSun", 9F);
            this.textBox_RefArticle.Location = new System.Drawing.Point(62, 76);
            this.textBox_RefArticle.Name = "textBox_RefArticle";
            this.textBox_RefArticle.Size = new System.Drawing.Size(141, 28);
            this.textBox_RefArticle.TabIndex = 11;
            this.textBox_RefArticle.TextChanged += new System.EventHandler(this.textBox_RefArticle_TextChanged);
            // 
            // textBox_Description
            // 
            this.textBox_Description.Font = new System.Drawing.Font("SimSun", 9F);
            this.textBox_Description.Location = new System.Drawing.Point(209, 75);
            this.textBox_Description.Name = "textBox_Description";
            this.textBox_Description.Size = new System.Drawing.Size(187, 28);
            this.textBox_Description.TabIndex = 12;
            this.textBox_Description.TextChanged += new System.EventHandler(this.textBox_Description_TextChanged);
            // 
            // textBox_PriceHT
            // 
            this.textBox_PriceHT.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_PriceHT.Location = new System.Drawing.Point(922, 75);
            this.textBox_PriceHT.Name = "textBox_PriceHT";
            this.textBox_PriceHT.Size = new System.Drawing.Size(115, 28);
            this.textBox_PriceHT.TabIndex = 15;
            this.textBox_PriceHT.TextChanged += new System.EventHandler(this.textBox_PriceHT_TextChanged);
            // 
            // textBox_Quantity
            // 
            this.textBox_Quantity.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_Quantity.Location = new System.Drawing.Point(1043, 75);
            this.textBox_Quantity.Name = "textBox_Quantity";
            this.textBox_Quantity.Size = new System.Drawing.Size(115, 28);
            this.textBox_Quantity.TabIndex = 16;
            this.textBox_Quantity.TextChanged += new System.EventHandler(this.textBox_Quantity_TextChanged);
            // 
            // comboBox_SubFamily
            // 
            this.comboBox_SubFamily.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBox_SubFamily.FormattingEnabled = true;
            this.comboBox_SubFamily.Location = new System.Drawing.Point(402, 76);
            this.comboBox_SubFamily.Name = "comboBox_SubFamily";
            this.comboBox_SubFamily.Size = new System.Drawing.Size(338, 26);
            this.comboBox_SubFamily.TabIndex = 17;
            this.comboBox_SubFamily.SelectedIndexChanged += new System.EventHandler(this.comboBox_SubFamily_SelectedIndexChanged);
            // 
            // comboBox_Brand
            // 
            this.comboBox_Brand.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBox_Brand.FormattingEnabled = true;
            this.comboBox_Brand.Location = new System.Drawing.Point(746, 77);
            this.comboBox_Brand.Name = "comboBox_Brand";
            this.comboBox_Brand.Size = new System.Drawing.Size(170, 26);
            this.comboBox_Brand.TabIndex = 18;
            this.comboBox_Brand.SelectedIndexChanged += new System.EventHandler(this.comboBox_Brand_SelectedIndexChanged);
            // 
            // ModifyArticle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1278, 224);
            this.Controls.Add(this.comboBox_Brand);
            this.Controls.Add(this.comboBox_SubFamily);
            this.Controls.Add(this.textBox_Quantity);
            this.Controls.Add(this.textBox_PriceHT);
            this.Controls.Add(this.textBox_Description);
            this.Controls.Add(this.textBox_RefArticle);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_RefArticle);
            this.Controls.Add(this.Btn_CancelModifyArticle);
            this.Controls.Add(this.Btn_SubmitModifyArticle);
            this.MaximumSize = new System.Drawing.Size(1300, 280);
            this.MinimumSize = new System.Drawing.Size(1300, 280);
            this.Name = "ModifyArticle";
            this.Text = "ModifyArticle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Btn_SubmitModifyArticle;
        private System.Windows.Forms.Button Btn_CancelModifyArticle;
        private System.Windows.Forms.Label label_RefArticle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_RefArticle;
        private System.Windows.Forms.TextBox textBox_Description;
        private System.Windows.Forms.TextBox textBox_PriceHT;
        private System.Windows.Forms.TextBox textBox_Quantity;
        private System.Windows.Forms.ComboBox comboBox_SubFamily;
        private System.Windows.Forms.ComboBox comboBox_Brand;
    }
}