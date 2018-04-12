using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Mercure.Model;
using Mercure.Controller;

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
                // read file
                ReadFile.LoadFile(FileNameForLoadFile);
                List<OriArticle> L_OriArt = ReadFile.GetInfoArticleList();

                // parse file
                ParseArticles Parse_Article = new ParseArticles(L_OriArt);
                List<Article> L_Art = Parse_Article.ParseArticle();
                // insert into data base
                //ArticleController Article_Controller = new ArticleController();
                //Article_Controller.InsertArticles(L_Art);
                //MarkController Mark_Controller = new MarkController();
                //Mark_Controller.InsertMarks(Parse_Article.L_Mark1);
            }
        }

        private void openFileDialog_FileOk(object sender, CancelEventArgs e)
        {

        }
    }
}
