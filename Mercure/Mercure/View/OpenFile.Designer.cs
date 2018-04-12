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
            this.Btn_AddNew = new System.Windows.Forms.Button();
            this.Btn_Upgrade = new System.Windows.Forms.Button();
            this.textBox_ShowDetails = new System.Windows.Forms.TextBox();
            this.Btn_Close = new System.Windows.Forms.Button();
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
            // Btn_AddNew
            // 
            this.Btn_AddNew.Location = new System.Drawing.Point(230, 236);
            this.Btn_AddNew.Name = "Btn_AddNew";
            this.Btn_AddNew.Size = new System.Drawing.Size(131, 29);
            this.Btn_AddNew.TabIndex = 4;
            this.Btn_AddNew.Text = "Add New";
            this.Btn_AddNew.UseVisualStyleBackColor = true;
            this.Btn_AddNew.Click += new System.EventHandler(this.Btn_addNew_Click);
            // 
            // Btn_Upgrade
            // 
            this.Btn_Upgrade.Location = new System.Drawing.Point(503, 236);
            this.Btn_Upgrade.Name = "Btn_Upgrade";
            this.Btn_Upgrade.Size = new System.Drawing.Size(124, 29);
            this.Btn_Upgrade.TabIndex = 5;
            this.Btn_Upgrade.Text = "Upgrade";
            this.Btn_Upgrade.UseVisualStyleBackColor = true;
            // 
            // textBox_ShowDetails
            // 
            this.textBox_ShowDetails.Location = new System.Drawing.Point(173, 350);
            this.textBox_ShowDetails.Multiline = true;
            this.textBox_ShowDetails.Name = "textBox_ShowDetails";
            this.textBox_ShowDetails.Size = new System.Drawing.Size(522, 123);
            this.textBox_ShowDetails.TabIndex = 6;
            // 
            // Btn_Close
            // 
            this.Btn_Close.Location = new System.Drawing.Point(620, 488);
            this.Btn_Close.Name = "Btn_Close";
            this.Btn_Close.Size = new System.Drawing.Size(75, 23);
            this.Btn_Close.TabIndex = 7;
            this.Btn_Close.Text = "Close";
            this.Btn_Close.UseVisualStyleBackColor = true;
            this.Btn_Close.Click += new System.EventHandler(this.Btn_Close_Click);
            // 
            // OpenFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 580);
            this.Controls.Add(this.Btn_Close);
            this.Controls.Add(this.textBox_ShowDetails);
            this.Controls.Add(this.Btn_Upgrade);
            this.Controls.Add(this.Btn_AddNew);
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
        private System.Windows.Forms.Button Btn_AddNew;
        private System.Windows.Forms.Button Btn_Upgrade;
        private System.Windows.Forms.TextBox textBox_ShowDetails;
        private System.Windows.Forms.Button Btn_Close;
    }
}