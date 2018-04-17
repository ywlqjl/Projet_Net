using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Mercure.Controller;
using Mercure.Model;
using Mercure.View;

namespace Mercure.View
{
    public partial class ModifyArticle : Form
    {
        public ModifyArticle()
        {
            InitializeComponent();
            dataGridView1.EditMode = DataGridViewEditMode.EditOnEnter;

        }

        /// <summary>
        /// Show details of the article to modify
        /// </summary>
        /// <param name="SelectedArticle">ListViewItem selected in main window</param>
        public void GetArticleToModify(ListViewItem SelectedArticle)
        {
            ArticleController ArtController = new ArticleController();
            Article ArticleToModify = new Article();
            //ArticleToModify = ArtController.GetArticleByRef(Article.RefArticle1);
           
            listView_ModifyArticle.Items.Clear();
            ArticleController ArticleController1 = new ArticleController();
            ArticleToModify = ArticleController1.GetArticleByRef(SelectedArticle.Text);

            ListViewItem ArticleItem = new ListViewItem();
            ArticleItem.Text = ArticleToModify.RefArticle1.ToString();

            ArticleItem.SubItems.Add(ArticleToModify.Description1.ToString());
            ArticleItem.SubItems.Add(ArticleToModify.RefSubFamilly1.Nom1.ToString());
            ArticleItem.SubItems.Add(ArticleToModify.RefMark1.Nom1.ToString());
            ArticleItem.SubItems.Add(ArticleToModify.PriceHT1.ToString());
            ArticleItem.SubItems.Add(ArticleToModify.Quantity1.ToString());
            this.listView_ModifyArticle.Items.Add(ArticleItem);

        }
        /*
        private void ToModifyArticle(Article Article)
        {
            String Reference = Text_Box_Reference.Text;
            String Description = Text_Box_Description.Text;
            String Price = Text_Box_Price.Text.Replace(",", ".");
            String Quantity = Text_Box_Quantity.Text;

            int Sub_Familly_Index = Combo_Box_Sous_Famille.SelectedIndex;
            int Mark_Index = Combo_Box_Marque.SelectedIndex;
        }*/

        private void Btn_SubmitModifyArticle_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_CancelModifyArticle_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView_ModifyArticle_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        public void GetArticleToModify2(ListViewItem SelectedArticle)
        {
            ArticleController ArtController = new ArticleController();
            Article ArticleToModify = new Article();
            //ArticleToModify = ArtController.GetArticleByRef(Article.RefArticle1);

            
            ArticleController ArticleController1 = new ArticleController();
            ArticleToModify = ArticleController1.GetArticleByRef(SelectedArticle.Text);

            this.dataGridView1.Rows[0].Cells[0].Value = ArticleToModify.RefArticle1.ToString();
            this.dataGridView1.Rows[0].Cells[1].Value = ArticleToModify.Description1.ToString();
            this.dataGridView1.Rows[0].Cells[2].Value = ArticleToModify.RefSubFamilly1.ToString();
            this.dataGridView1.Rows[0].Cells[3].Value = ArticleToModify.RefMark1.ToString();
            this.dataGridView1.Rows[0].Cells[4].Value = ArticleToModify.PriceHT1.ToString();
            this.dataGridView1.Rows[0].Cells[5].Value = ArticleToModify.Quantity1.ToString();
            //TODO modify

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
