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

    {    //Attributs
        private String Reference;
        private String Description;
        private String Price;
        private String Quantity;

        private int Sub_Familly_Index;
        private int Mark_Index;

        public ModifyArticle()
        {
            InitializeComponent();
            InitializeForm();
            //dataGridView1.EditMode = DataGridViewEditMode.EditOnEnter;

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





        private void textBox_RefArticle_TextChanged(object sender, EventArgs e)
        {
            Reference = textBox_RefArticle.Text;
        }


        /// <summary>
        /// show the details of the selected item in modify window
        /// </summary>
        /// <param name="SelectedArticle">selected item</param>
        public void GetArticleToModify(ListViewItem SelectedArticle)
        {
            ArticleController ArtController = new ArticleController();
            Article ArticleToModify = new Article();
            //ArticleToModify = ArtController.GetArticleByRef(Article.RefArticle1);
            
            ArticleController ArticleController1 = new ArticleController();
            ArticleToModify = ArticleController1.GetArticleByRef(SelectedArticle.Text);

            this.textBox_RefArticle.Text = ArticleToModify.RefArticle1.ToString();
            this.textBox_Description.Text = ArticleToModify.Description1.ToString();
            this.comboBox_SubFamily.Text = ArticleToModify.RefSubFamilly1.Nom1.ToString();
            this.comboBox_Brand.Text = ArticleToModify.RefMark1.Nom1.ToString();
            this.textBox_PriceHT.Text = ArticleToModify.PriceHT1.ToString();
            this.textBox_Quantity.Text = ArticleToModify.Quantity1.ToString();

        }


        /// <summary>
        /// Modify the selected article and save it.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_SubmitModifyArticle_Click(object sender, EventArgs e)
        {

            Reference = textBox_RefArticle.Text;
            Description = textBox_Description.Text;
            Price = textBox_PriceHT.Text.Replace(",", ".");
            Quantity = textBox_Quantity.Text;

            Sub_Familly_Index = comboBox_SubFamily.SelectedIndex;
            Mark_Index = comboBox_Brand.SelectedIndex;


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
            Article_Controller.InsertArticle(Reference, Description, Sub_Familly.RefSousFamille1, Mark.RefMarque1, Price_Float, Quantity_Int);
            MessageBox.Show("Article modified successfully ;)", "Article modified", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.DialogResult = DialogResult.OK;
            this.Dispose();
            //this.Close();



        }

        private void textBox_Description_TextChanged(object sender, EventArgs e)
        {
            Description = textBox_Description.Text;
        }

        private void comboBox_SubFamily_SelectedIndexChanged(object sender, EventArgs e)
        {
            Sub_Familly_Index = comboBox_SubFamily.SelectedIndex;
        }

        private void comboBox_Brand_SelectedIndexChanged(object sender, EventArgs e)
        {
            Mark_Index = comboBox_Brand.SelectedIndex;
        }

        private void textBox_PriceHT_TextChanged(object sender, EventArgs e)
        {
            Price = textBox_PriceHT.Text;
        }

        private void textBox_Quantity_TextChanged(object sender, EventArgs e)
        {
            Quantity = textBox_Quantity.Text;
        }
    }
}
