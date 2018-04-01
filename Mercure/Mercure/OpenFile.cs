﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mercure
{
    public partial class OpenFile : Form
    {
        public OpenFile()
        {
            InitializeComponent();
        }

        private void Select_btn_Click(object sender, EventArgs e)
        {
            openFileDialog.Title = "Select File";
            openFileDialog.Filter = "XML File (*.xml) |*.xml";
            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK){
                string FileName = openFileDialog.FileName;
                Console.WriteLine(FileName);
            }
        }

        private void openFileDialog_FileOk(object sender, CancelEventArgs e)
        {

        }
    }
}
