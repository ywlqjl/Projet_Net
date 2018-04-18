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
            this.Btn_Update = new System.Windows.Forms.Button();
            this.textBox_ShowDetails = new System.Windows.Forms.TextBox();
            this.Btn_Close = new System.Windows.Forms.Button();
            this.Btn_CancelLoad = new System.Windows.Forms.Button();
            this.label_ShowProgressState = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 51);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Choose File";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // Btn_Select
            // 
            this.Btn_Select.Location = new System.Drawing.Point(130, 51);
            this.Btn_Select.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Btn_Select.Name = "Btn_Select";
            this.Btn_Select.Size = new System.Drawing.Size(64, 19);
            this.Btn_Select.TabIndex = 1;
            this.Btn_Select.Text = "Select";
            this.Btn_Select.UseVisualStyleBackColor = true;
            this.Btn_Select.Click += new System.EventHandler(this.Select_btn_Click);
            // 
            // FileProgress
            // 
            this.FileProgress.Location = new System.Drawing.Point(46, 125);
            this.FileProgress.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.FileProgress.Name = "FileProgress";
            this.FileProgress.Size = new System.Drawing.Size(460, 21);
            this.FileProgress.TabIndex = 2;
            // 
            // Txt_FilePath
            // 
            this.Txt_FilePath.Location = new System.Drawing.Point(46, 75);
            this.Txt_FilePath.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Txt_FilePath.Name = "Txt_FilePath";
            this.Txt_FilePath.Size = new System.Drawing.Size(461, 21);
            this.Txt_FilePath.TabIndex = 3;
            // 
            // Btn_AddNew
            // 
            this.Btn_AddNew.Location = new System.Drawing.Point(338, 51);
            this.Btn_AddNew.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Btn_AddNew.Name = "Btn_AddNew";
            this.Btn_AddNew.Size = new System.Drawing.Size(78, 19);
            this.Btn_AddNew.TabIndex = 4;
            this.Btn_AddNew.Text = "Add New";
            this.Btn_AddNew.UseVisualStyleBackColor = true;
            this.Btn_AddNew.Click += new System.EventHandler(this.Btn_addNew_Click);
            // 
            // Btn_Update
            // 
            this.Btn_Update.Location = new System.Drawing.Point(428, 50);
            this.Btn_Update.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Btn_Update.Name = "Btn_Update";
            this.Btn_Update.Size = new System.Drawing.Size(78, 19);
            this.Btn_Update.TabIndex = 5;
            this.Btn_Update.Text = "Update";
            this.Btn_Update.UseVisualStyleBackColor = true;
            this.Btn_Update.Click += new System.EventHandler(this.Btn_Update_Click);
            // 
            // textBox_ShowDetails
            // 
            this.textBox_ShowDetails.Location = new System.Drawing.Point(46, 151);
            this.textBox_ShowDetails.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox_ShowDetails.Multiline = true;
            this.textBox_ShowDetails.Name = "textBox_ShowDetails";
            this.textBox_ShowDetails.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_ShowDetails.Size = new System.Drawing.Size(461, 172);
            this.textBox_ShowDetails.TabIndex = 6;
            // 
            // Btn_Close
            // 
            this.Btn_Close.Location = new System.Drawing.Point(453, 325);
            this.Btn_Close.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Btn_Close.Name = "Btn_Close";
            this.Btn_Close.Size = new System.Drawing.Size(53, 25);
            this.Btn_Close.TabIndex = 7;
            this.Btn_Close.Text = "Close";
            this.Btn_Close.UseVisualStyleBackColor = true;
            this.Btn_Close.Click += new System.EventHandler(this.Btn_Close_Click);
            // 
            // Btn_CancelLoad
            // 
            this.Btn_CancelLoad.Location = new System.Drawing.Point(387, 325);
            this.Btn_CancelLoad.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Btn_CancelLoad.Name = "Btn_CancelLoad";
            this.Btn_CancelLoad.Size = new System.Drawing.Size(55, 25);
            this.Btn_CancelLoad.TabIndex = 8;
            this.Btn_CancelLoad.Text = "Cancel";
            this.Btn_CancelLoad.UseVisualStyleBackColor = true;
            this.Btn_CancelLoad.Click += new System.EventHandler(this.Btn_CancelLoad_Click);
            // 
            // label_ShowProgressState
            // 
            this.label_ShowProgressState.AutoSize = true;
            this.label_ShowProgressState.Location = new System.Drawing.Point(44, 111);
            this.label_ShowProgressState.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_ShowProgressState.Name = "label_ShowProgressState";
            this.label_ShowProgressState.Size = new System.Drawing.Size(83, 12);
            this.label_ShowProgressState.TabIndex = 9;
            this.label_ShowProgressState.Text = "ProgressState";
            // 
            // OpenFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 381);
            this.Controls.Add(this.label_ShowProgressState);
            this.Controls.Add(this.Btn_CancelLoad);
            this.Controls.Add(this.Btn_Close);
            this.Controls.Add(this.textBox_ShowDetails);
            this.Controls.Add(this.Btn_Update);
            this.Controls.Add(this.Btn_AddNew);
            this.Controls.Add(this.Txt_FilePath);
            this.Controls.Add(this.FileProgress);
            this.Controls.Add(this.Btn_Select);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(570, 420);
            this.MinimumSize = new System.Drawing.Size(570, 420);
            this.Name = "OpenFile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private System.Windows.Forms.Button Btn_Update;
        private System.Windows.Forms.TextBox textBox_ShowDetails;
        private System.Windows.Forms.Button Btn_Close;
        private System.Windows.Forms.Button Btn_CancelLoad;
        private System.Windows.Forms.Label label_ShowProgressState;
    }
}