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

namespace Mercure.View
{
    public partial class AddArticle : Form
    {
        public AddArticle()
        {
            InitializeComponent();
            InitializeForm();
        }

        /// <summary>
        /// initialisation of the add form
        /// </summary>
        private void InitializeForm()
        {
            SubFamillyController Sub_Familly_Controller = new SubFamillyController();
            List<SubFamilly> List_Sub_Familly = Sub_Familly_Controller.GetAllSubFamilly();
            foreach (SubFamilly SubFamilly in List_Sub_Familly)
            {
                Combo_Box_Sous_Famille.Items.Add(SubFamilly.Nom1);
                //Combo_Box_Sous_Famille.SelectedIndex = 0;
            }

            MarkController Mark_Controller = new MarkController();
            List<Mark> List_Mark = Mark_Controller.GetAllMark();
            foreach (Mark Mark in List_Mark)
            {
                Combo_Box_Marque.Items.Add(Mark.Nom1);
                //Combo_Box_Marque.SelectedIndex = 0;
            }
        }


        /// <summary>
        /// cancel to add an article
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_Cancel_Article_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        /// <summary>
        /// Add article listner
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_Add_Article_Click(object sender, EventArgs e)
        {
            
            String Reference = Text_Box_Reference.Text;
            String Description = Text_Box_Description.Text;
            String Price = Text_Box_Price.Text;
            String Quantity = Text_Box_Quantity.Text;

            int Sub_Familly_Index = Combo_Box_Sous_Famille.SelectedIndex;
            int Mark_Index = Combo_Box_Marque.SelectedIndex;

            if (Mark_Index > -1 && Sub_Familly_Index > -1 && !Reference.Equals("") && !Description.Equals("") && !Price.Equals("") && !Quantity.Equals(""))
            {
                try
                {
                    float Price_Float = float.Parse(Price);
                    int Quantity_Int = int.Parse(Quantity);

                    SubFamillyController Sub_Familly_Controller = new SubFamillyController();
                    List<SubFamilly> List_Sub_Familly = Sub_Familly_Controller.GetAllSubFamilly();
                    SubFamilly Sub_Familly = List_Sub_Familly[Sub_Familly_Index];

                    MarkController Mark_Controller = new MarkController();
                    List<Mark> List_Mark = Mark_Controller.GetAllMark();
                    Mark Mark = List_Mark[Mark_Index];


                    //Article article = new Article(Reference, Description, Price, Quantity, sousFamille.Ref_Sous_Famille, marque.Ref_Marque);
                    ArticleController Article_Controller = new ArticleController();
                    Article Article = Article_Controller.GetArticleByRef(Reference);

                    if (Article == null)
                    {
                        Article_Controller.InsertArticle(Reference, Description, Sub_Familly.RefSousFamille1 , Mark.RefMarque1, Price_Float, Quantity_Int);
                        MessageBox.Show("Article added successfully ;)", "Article added", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Article exists already in DataBase", "Error Add Article", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    this.DialogResult = DialogResult.OK;
                    this.Dispose();

                }
                catch (FormatException e1)
                {
                    //Message de l'exception pour notifier l'utilisateur
                    MessageBox.Show(e1.Message, "Error Add Article", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                MessageBox.Show("Please fill in all the fields", "Error Add Article", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
