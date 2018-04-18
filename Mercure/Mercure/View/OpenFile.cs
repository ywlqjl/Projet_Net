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
        // basic var
        private string FileNameForLoadFile;
        private ArticleController Article_Controller = new ArticleController();
        private MarkController Mark_Controller = new MarkController();
        private SubFamillyController SubFamilly_Conreoller = new SubFamillyController();
        private FamillyController Familly_Controller = new FamillyController();

        ParseArticles Parse_Article = null;
        List<Article> L_Art = null;

        private int Statistic = 0;
        private string Message;
        private int TotalData = 0;

        private bool StopLoading = false;

        // delegate for progress bar
        private delegate void UpdateProgressBar(int Count, string Msg);


        public OpenFile()
        {
            InitializeComponent();
        }

        private void UpdateStatic(int Count, string Msg)
        {
            this.Statistic += Count;
            this.Message = Msg;

            if (StopLoading)
            {
                this.Dispose();
            }
            else
            {
                Console.WriteLine(this.Statistic);
                this.Statistic = Convert.ToInt32((this.Statistic / (float)TotalData) *100);
               
                if (this.Statistic > 100)
                {
                    this.Statistic = 100;
                }

                if (this.InvokeRequired)
                {
                    UpdateProgressBar UpdateBar = new UpdateProgressBar(UpdateStatic);

                    this.Invoke(UpdateBar, this.Statistic, Msg);

                }
                else
                {
                    this.FileProgress.Value = this.Statistic;
                    this.textBox_ShowDetails.AppendText(Msg + "\n");
                }

                this.label_ShowProgressState.Text = "Loading...";
                Application.DoEvents();
            }
          
        }

        /// <summary>
        /// Select file btn, load file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Select_btn_Click(object sender, EventArgs e)
        {
            openFileDialog.Title = "Select File";
            openFileDialog.Filter = "XML File (*.xml) |*.xml";
            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                FileNameForLoadFile = openFileDialog.FileName;
                string FileName = System.IO.Path.GetFullPath(openFileDialog.FileName);
                Txt_FilePath.Text = FileName;
              

                // read file
                ReadFile.LoadFile(FileNameForLoadFile);
                try
                {
                    List<OriArticle> L_OriArt = ReadFile.GetInfoArticleList();
                    // parse file
                    Parse_Article = new ParseArticles(L_OriArt);
                    L_Art = Parse_Article.ParseArticle();

                    TotalData = Parse_Article.L_Familly1.Count + Parse_Article.L_Mark1.Count + Parse_Article.L_SubFamilly1.Count;
                    Console.WriteLine(TotalData);
                }
                catch (Exception E)
                {
                    this.textBox_ShowDetails.Clear();
                    this.textBox_ShowDetails.AppendText(E.Message);
                }
               
            }
        }

        /// <summary>
        /// Add new file to database
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_addNew_Click(object sender, EventArgs e)
        {
            this.textBox_ShowDetails.Clear();
            this.FileProgress.Value = 0;
            if (this.Parse_Article != null && this.L_Art != null)
            {
                // delegate
                Article_Controller.Operated += new ArticleController.OperationHandler(this.UpdateStatic);
                Mark_Controller.Operated += new MarkController.OperationHandler(this.UpdateStatic);
                SubFamilly_Conreoller.Operated += new SubFamillyController.OperationHandler(this.UpdateStatic);
                Familly_Controller.Operated += new FamillyController.OperationHandler(this.UpdateStatic);

                // delete
                Article_Controller.DeleteAllArticle();
                Mark_Controller.DeleteAllMark();
                SubFamilly_Conreoller.DeleteAllSubFamilly();
                Familly_Controller.DeleteAllFamilly();

                // insert into data base
                
                Response Response_Art = Article_Controller.InsertArticles(L_Art);

                //insert mark
                
                Response Response_Mark = Mark_Controller.InsertMarks(Parse_Article.L_Mark1);

                //insert subfamilly
               
                Response Response_SubFamilly = SubFamilly_Conreoller.InsertSubFamillys(Parse_Article.L_SubFamilly1);

                //insert familly
                
                Response Response_Familly = Familly_Controller.InsertFamillys(Parse_Article.L_Familly1);

                //this.textBox_ShowDetails.AppendText("Finished!\n");

                this.label_ShowProgressState.Text = "Finished!";
            }
            else {
                // error no file
                //this.textBox_ShowDetails.AppendText("No file to import!\n");
                this.label_ShowProgressState.Text = "No file to import!";
            }
           
        }

        /// <summary>
        /// Close
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_Close_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        /// <summary>
        /// update data
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_Update_Click(object sender, EventArgs e)
        {
            this.textBox_ShowDetails.Clear();
            this.FileProgress.Value = 0;
            if (this.Parse_Article != null && this.L_Art != null)
            {
                // delegate
                Article_Controller.Operated += new ArticleController.OperationHandler(this.UpdateStatic);
                Mark_Controller.Operated += new MarkController.OperationHandler(this.UpdateStatic);
                SubFamilly_Conreoller.Operated += new SubFamillyController.OperationHandler(this.UpdateStatic);
                Familly_Controller.Operated += new FamillyController.OperationHandler(this.UpdateStatic);

                // insert into data base
                
                Response Response_Art = Article_Controller.InsertArticles(L_Art);

                //insert mark
                
                Response Response_Mark = Mark_Controller.InsertMarks(Parse_Article.L_Mark1);

                //insert subfamilly
                
                Response Response_SubFamilly = SubFamilly_Conreoller.InsertSubFamillys(Parse_Article.L_SubFamilly1);

                //insert familly
                
                Response Response_Familly = Familly_Controller.InsertFamillys(Parse_Article.L_Familly1);

                this.textBox_ShowDetails.AppendText("Finished!\n");
            }
            else {
                // error
                this.textBox_ShowDetails.AppendText("No file to import!\n");
            }
        }

        /// <summary>
        /// cancel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_CancelLoad_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to cancel?", "Stop", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes)
                StopLoading = false;
            else
                StopLoading = true;
        }
    }
}
