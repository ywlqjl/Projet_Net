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
            this.listView1 = new System.Windows.Forms.ListView();
            this.Btn_SubmitModifyArticle = new System.Windows.Forms.Button();
            this.Btn_CancelModifyArticle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(23, 43);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1005, 164);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // Btn_SubmitModifyArticle
            // 
            this.Btn_SubmitModifyArticle.Location = new System.Drawing.Point(782, 224);
            this.Btn_SubmitModifyArticle.Name = "Btn_SubmitModifyArticle";
            this.Btn_SubmitModifyArticle.Size = new System.Drawing.Size(113, 46);
            this.Btn_SubmitModifyArticle.TabIndex = 1;
            this.Btn_SubmitModifyArticle.Text = "Submit";
            this.Btn_SubmitModifyArticle.UseVisualStyleBackColor = true;
            this.Btn_SubmitModifyArticle.Click += new System.EventHandler(this.Btn_SubmitModifyArticle_Click);
            // 
            // Btn_CancelModifyArticle
            // 
            this.Btn_CancelModifyArticle.Location = new System.Drawing.Point(915, 224);
            this.Btn_CancelModifyArticle.Name = "Btn_CancelModifyArticle";
            this.Btn_CancelModifyArticle.Size = new System.Drawing.Size(113, 46);
            this.Btn_CancelModifyArticle.TabIndex = 2;
            this.Btn_CancelModifyArticle.Text = "Cancel";
            this.Btn_CancelModifyArticle.UseVisualStyleBackColor = true;
            this.Btn_CancelModifyArticle.Click += new System.EventHandler(this.Btn_CancelModifyArticle_Click);
            // 
            // ModifyArticle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1057, 295);
            this.Controls.Add(this.Btn_CancelModifyArticle);
            this.Controls.Add(this.Btn_SubmitModifyArticle);
            this.Controls.Add(this.listView1);
            this.Name = "ModifyArticle";
            this.Text = "ModifyArticle";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button Btn_SubmitModifyArticle;
        private System.Windows.Forms.Button Btn_CancelModifyArticle;
    }
}