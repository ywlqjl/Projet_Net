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
        private string FileNameForLoadFile;
        private ArticleController Article_Controller = new ArticleController();
        private MarkController Mark_Controller = new MarkController();
        private SubFamillyController SubFamilly_Conreoller = new SubFamillyController();
        private FamillyController Familly_Controller = new FamillyController();

        ParseArticles Parse_Article = null;
        List<Article> L_Art = null;

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
                FileNameForLoadFile = openFileDialog.FileName;
                string FileName = System.IO.Path.GetFullPath(openFileDialog.FileName);
                Txt_FilePath.Text = FileName;
                Console.WriteLine(FileName);

                // read file
                ReadFile.LoadFile(FileNameForLoadFile);
                List<OriArticle> L_OriArt = ReadFile.GetInfoArticleList();

                // parse file
                Parse_Article = new ParseArticles(L_OriArt);
                L_Art = Parse_Article.ParseArticle();

            }
        }

        private void openFileDialog_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void Btn_addNew_Click(object sender, EventArgs e)
        {
            if (this.Parse_Article != null && this.L_Art != null)
            {
                Article_Controller.DeleteAllArticle();
                Mark_Controller.DeleteAllMark();
                SubFamilly_Conreoller.DeleteAllSubFamilly();
                Familly_Controller.DeleteAllFamilly();

                Response Response_Art = Article_Controller.InsertArticles(L_Art);
                Console.WriteLine("Article updated " + Response_Art.Message1);

                //insert mark
                Response Response_Mark = Mark_Controller.InsertMarks(Parse_Article.L_Mark1);

                //insert subfamilly
                Response Response_SubFamilly = SubFamilly_Conreoller.InsertSubFamillys(Parse_Article.L_SubFamilly1);

                //insert familly
                Response Response_Familly = Familly_Controller.InsertSubFamillys(Parse_Article.L_Familly1);
            }
            else {
                // error no file
            }
           
        }

        /*
         * close the window of Openfile after loading operations.
         * 
         */
        private void Btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_Update_Click(object sender, EventArgs e)
        {
            if (this.Parse_Article != null && this.L_Art != null)
            {
                // insert into data base
                Response Response_Art = Article_Controller.InsertArticles(L_Art);
                Console.WriteLine("Article updated " + Response_Art.Message1);

                //insert mark
                Response Response_Mark = Mark_Controller.InsertMarks(Parse_Article.L_Mark1);

                //insert subfamilly
                Response Response_SubFamilly = SubFamilly_Conreoller.InsertSubFamillys(Parse_Article.L_SubFamilly1);

                //insert familly
                Response Response_Familly = Familly_Controller.InsertSubFamillys(Parse_Article.L_Familly1);
            }
            else {
                // error
            }
        }
    }
}
