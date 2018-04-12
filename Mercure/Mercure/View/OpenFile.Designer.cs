namespace Mercure
{
    partial class OpenFile
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
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.Btn_Select = new System.Windows.Forms.Button();
            this.FileProgress = new System.Windows.Forms.ProgressBar();
            this.Txt_FilePath = new System.Windows.Forms.TextBox();
            this.Btn_addNew = new System.Windows.Forms.Button();
            this.Btn_upgrade = new System.Windows.Forms.Button();
            this.textBox_showDetails = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(170, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Choose File";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            this.openFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog_FileOk);
            // 
            // Btn_Select
            // 
            this.Btn_Select.Location = new System.Drawing.Point(599, 174);
            this.Btn_Select.Name = "Btn_Select";
            this.Btn_Select.Size = new System.Drawing.Size(96, 31);
            this.Btn_Select.TabIndex = 1;
            this.Btn_Select.Text = "Select";
            this.Btn_Select.UseVisualStyleBackColor = true;
            this.Btn_Select.Click += new System.EventHandler(this.Select_btn_Click);
            // 
            // FileProgress
            // 
            this.FileProgress.Location = new System.Drawing.Point(173, 299);
            this.FileProgress.Name = "FileProgress";
            this.FileProgress.Size = new System.Drawing.Size(522, 32);
            this.FileProgress.TabIndex = 2;
            // 
            // Txt_FilePath
            // 
            this.Txt_FilePath.Location = new System.Drawing.Point(283, 177);
            this.Txt_FilePath.Name = "Txt_FilePath";
            this.Txt_FilePath.Size = new System.Drawing.Size(298, 28);
            this.Txt_FilePath.TabIndex = 3;
            // 
            // Btn_addNew
            // 
            this.Btn_addNew.Location = new System.Drawing.Point(230, 236);
            this.Btn_addNew.Name = "Btn_addNew";
            this.Btn_addNew.Size = new System.Drawing.Size(131, 29);
            this.Btn_addNew.TabIndex = 4;
            this.Btn_addNew.Text = "Add New";
            this.Btn_addNew.UseVisualStyleBackColor = true;
            this.Btn_addNew.Click += new System.EventHandler(this.Btn_addNew_Click);
            // 
            // Btn_upgrade
            // 
            this.Btn_upgrade.Location = new System.Drawing.Point(503, 236);
            this.Btn_upgrade.Name = "Btn_upgrade";
            this.Btn_upgrade.Size = new System.Drawing.Size(124, 29);
            this.Btn_upgrade.TabIndex = 5;
            this.Btn_upgrade.Text = "Upgrade";
            this.Btn_upgrade.UseVisualStyleBackColor = true;
            // 
            // textBox_showDetails
            // 
            this.textBox_showDetails.Location = new System.Drawing.Point(173, 350);
            this.textBox_showDetails.Multiline = true;
            this.textBox_showDetails.Name = "textBox_showDetails";
            this.textBox_showDetails.Size = new System.Drawing.Size(522, 123);
            this.textBox_showDetails.TabIndex = 6;
            // 
            // OpenFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 580);
            this.Controls.Add(this.textBox_showDetails);
            this.Controls.Add(this.Btn_upgrade);
            this.Controls.Add(this.Btn_addNew);
            this.Controls.Add(this.Txt_FilePath);
            this.Controls.Add(this.FileProgress);
            this.Controls.Add(this.Btn_Select);
            this.Controls.Add(this.label1);
            this.Name = "OpenFile";
            this.Text = "OpenFile";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button Btn_Select;
        private System.Windows.Forms.ProgressBar FileProgress;
        private System.Windows.Forms.TextBox Txt_FilePath;
        private System.Windows.Forms.Button Btn_addNew;
        private System.Windows.Forms.Button Btn_upgrade;
        private System.Windows.Forms.TextBox textBox_showDetails;
    }
}