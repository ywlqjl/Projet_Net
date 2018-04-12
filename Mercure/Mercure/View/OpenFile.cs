using System;
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
            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string FileNameForLoadFile = openFileDialog.FileName;
                string FileName = System.IO.Path.GetFileNameWithoutExtension(openFileDialog.FileName);
                Txt_FilePath.Text = FileName;
                Console.WriteLine(FileName);

                ReadFile rf = new ReadFile();
                rf.LoadFile(FileNameForLoadFile);
                rf.GetInfoArticleList();
                Console.Read();
            }
        }

        private void openFileDialog_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void Btn_addNew_Click(object sender, EventArgs e)
        {

        }

        /*
         * close the window of Openfile after loading operations.
         * 
         */
        private void Btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
