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
            InitializeForm();
            dataGridView1.EditMode = DataGridViewEditMode.EditOnEnter;

        }

        private void InitializeForm()
        {
            SubFamillyController Sub_Familly_Controller = new SubFamillyController();
            List<SubFamilly> List_Sub_Familly = Sub_Familly_Controller.GetAllSubFamilly();
            foreach (SubFamilly SubFamilly in List_Sub_Familly)
            {
                this.comboBox_SubFamily.Items.Add(SubFamilly.Nom1);
                //Combo_Box_Sous_Famille.SelectedIndex = 0;
            }

            MarkController Mark_Controller = new MarkController();
            List<Mark> List_Mark = Mark_Controller.GetAllMark();
            foreach (Mark Mark in List_Mark)
            {
               this.comboBox_Brand.Items.Add(Mark.Nom1);
                //Combo_Box_Marque.SelectedIndex = 0;
            }
        }
        /// <summary>
        /// Show details of the article to modify
        /// </summary>
        /// <param name="SelectedArticle">ListViewItem selected in main window</param>
        /*
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

        }*/
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox_RefArticle_TextChanged(object sender, EventArgs e)
        {

        }

        public void GetArticleToModify3(ListViewItem SelectedArticle)
        {
            ArticleController ArtController = new ArticleController();
            Article ArticleToModify = new Article();
            //ArticleToModify = ArtController.GetArticleByRef(Article.RefArticle1);
            
            ArticleController ArticleController1 = new ArticleController();
            ArticleToModify = ArticleController1.GetArticleByRef(SelectedArticle.Text);

            this.textBox_RefArticle.Text = ArticleToModify.RefArticle1.ToString();
            this.textBox_Description.Text = ArticleToModify.Description1.ToString();
            this.comboBox_SubFamily.Text = ArticleToModify.RefSubFamilly1.ToString();
            this.comboBox_Brand.Text = ArticleToModify.RefMark1.ToString();
            this.textBox_PriceHT.Text = ArticleToModify.PriceHT1.ToString();
            this.textBox_Quantity.Text = ArticleToModify.Quantity1.ToString();

        }

        private void Btn_SubmitModifyArticle_Click(object sender, EventArgs e)
        {

            String Reference = textBox_RefArticle.Text;
            String Description = textBox_Description.Text;
            String Price = textBox_PriceHT.Text.Replace(",", ".");
            String Quantity = textBox_Quantity.Text;

            int Sub_Familly_Index = comboBox_SubFamily.SelectedIndex;
            int Mark_Index = comboBox_Brand.SelectedIndex;

            if (Mark_Index > -1 && Sub_Familly_Index > -1 && !Reference.Equals("") && !Description.Equals("") && !Price.Equals("") && !Quantity.Equals(""))
            {
                float Price_Float = float.Parse(Price);
                int Quantity_Int = int.Parse(Quantity);

                SubFamillyController Sub_Familly_Controller = new SubFamillyController();
                List<SubFamilly> List_Sub_Familly = Sub_Familly_Controller.GetAllSubFamilly();
                SubFamilly Sub_Familly = List_Sub_Familly[Sub_Familly_Index];

                MarkController Mark_Controller = new MarkController();
                List<Mark> List_Mark = Mark_Controller.GetAllMark();
                Mark Mark = List_Mark[Mark_Index];

                ArticleController Article_Controller = new ArticleController();
                Article Article = Article_Controller.GetArticleByRef(Reference);

                Article_Controller.UpdateArticle(Reference, Description, Sub_Familly.RefSousFamille1, Mark.RefMarque1, Price_Float, Quantity_Int);
                //Article_Controller.InsertArticle(Reference, Description, Sub_Familly.RefSousFamille1, Mark.RefMarque1, Price_Float, Quantity_Int);
                MessageBox.Show("Article modified successfully ;)", "Article modified", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.DialogResult = DialogResult.OK;
                // this.Dispose();
                this.Close();
            }
           // this.Close();


        }

    }
}
