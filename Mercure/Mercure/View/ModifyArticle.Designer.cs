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
            this.listView_ModifyArticle = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.Btn_CancelModifyArticle = new System.Windows.Forms.Button();
            this.Btn_SubmitModifyArticle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView_ModifyArticle
            // 
            this.listView_ModifyArticle.Location = new System.Drawing.Point(45, 86);
            this.listView_ModifyArticle.Name = "listView_ModifyArticle";
            this.listView_ModifyArticle.Size = new System.Drawing.Size(822, 128);
            this.listView_ModifyArticle.TabIndex = 0;
            this.listView_ModifyArticle.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Modify Acticle";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Btn_CancelModifyArticle
            // 
            this.Btn_CancelModifyArticle.Location = new System.Drawing.Point(740, 255);
            this.Btn_CancelModifyArticle.Name = "Btn_CancelModifyArticle";
            this.Btn_CancelModifyArticle.Size = new System.Drawing.Size(127, 42);
            this.Btn_CancelModifyArticle.TabIndex = 2;
            this.Btn_CancelModifyArticle.Text = "Cancel";
            this.Btn_CancelModifyArticle.UseVisualStyleBackColor = true;
            this.Btn_CancelModifyArticle.Click += new System.EventHandler(this.Btn_CancelModifyArticle_Click);
            // 
            // Btn_SubmitModifyArticle
            // 
            this.Btn_SubmitModifyArticle.Location = new System.Drawing.Point(591, 255);
            this.Btn_SubmitModifyArticle.Name = "Btn_SubmitModifyArticle";
            this.Btn_SubmitModifyArticle.Size = new System.Drawing.Size(127, 42);
            this.Btn_SubmitModifyArticle.TabIndex = 3;
            this.Btn_SubmitModifyArticle.Text = "Submit";
            this.Btn_SubmitModifyArticle.UseVisualStyleBackColor = true;
            this.Btn_SubmitModifyArticle.Click += new System.EventHandler(this.Btn_SubmitModifyArticle_Click);
            // 
            // ModifyArticle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 346);
            this.Controls.Add(this.Btn_SubmitModifyArticle);
            this.Controls.Add(this.Btn_CancelModifyArticle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView_ModifyArticle);
            this.Name = "ModifyArticle";
            this.RightToLeftLayout = true;
            this.Text = "Modify Article Information";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView_ModifyArticle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btn_CancelModifyArticle;
        private System.Windows.Forms.Button Btn_SubmitModifyArticle;
    }
}