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

namespace Mercure
{
    public partial class Main : Form
    {
        // arrtibuts
        List<Article> ListArticle = new List<Article>();

        public Main()
        {
            InitializeComponent();
            listView_ShowBD_DataBinding();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFile Openfile = new OpenFile();
            //Openfile.
            Openfile.ShowDialog();

            //Console.WriteLine(Openfile.DialogResult);
            if (Openfile.DialogResult == DialogResult.OK)
            {
               
                listView_ShowBD_DataBinding();
            }

        }

        private ListViewItem[] MakeListItem()
        {
            ListViewItem[] L_Item = new ListViewItem[ListArticle.Count];
            int i = 0;
            foreach (Article Article in ListArticle)
            {

                ListViewItem ArticleItem = new ListViewItem();
                ArticleItem.Text = Article.RefArticle1.ToString();

                ArticleItem.SubItems.Add(Article.Description1.ToString());
                ArticleItem.SubItems.Add(Article.RefSubFamilly1.Nom1.ToString());
                ArticleItem.SubItems.Add(Article.RefMark1.Nom1.ToString());
                ArticleItem.SubItems.Add(Article.PriceHT1.ToString());
                ArticleItem.SubItems.Add(Article.Quantity1.ToString());
                L_Item[i++] = ArticleItem;
            }
            return L_Item;
        }

        private void listView_ShowBD_DataBinding()
        {
           
            ArticleController ArticleController = new ArticleController();

            ListArticle = ArticleController.GetAllArticle();
            listView_ShowBD.Items.Clear();
            this.BindDataToView(this.MakeListItem());

        }

        private void listView_ShowBD_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //just test
        private void Btn_UpdataListView_Click(object sender, EventArgs e)
        {
            this.listView_ShowBD.Update();
        }

        private void BindDataToView(ListViewItem[] L_Item)
        {
            this.listView_ShowBD.Items.AddRange(L_Item);
            this.Label_TotalCount.Text = "Total: "+L_Item.Count();
        }


        private void ColumnClickFunction(object sender, ColumnClickEventArgs e)
        {
            
            ArticleController ArticleController = new ArticleController();
            ListArticle = ArticleController.GetAllArticle();

            int Column = e.Column;
            if (Column == 2 || Column==3)
            {
                this.listView_ShowBD.Items.Clear();
                // sub familly
                List<string> GroupString = new List<string>();
                List<ListViewGroup> GroupList = new List<ListViewGroup>();
                ListViewItem[] L_Item = this.MakeListItem();
                foreach(ListViewItem Item in L_Item)
                {
                    // create group list
                    if (!GroupString.Contains(Item.SubItems[Column].Text))
                    {
                        ListViewGroup Group = new ListViewGroup(Item.SubItems[2].Text, HorizontalAlignment.Left);
                        GroupList.Add(Group);
                        Item.Group = Group;
                        GroupString.Add(Item.SubItems[Column].Text);
                    }
                    else
                    {
                        int Index = GroupString.IndexOf(Item.SubItems[Column].Text);
                        Item.Group = GroupList.ElementAt(Index);
                    }
                }

                foreach (ListViewGroup Group in GroupList)
                {
                    this.listView_ShowBD.Groups.Add(Group);
                }
                this.BindDataToView(L_Item);
                
            }
        }

        private void ajouterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddArticle Add_Article = new AddArticle();
            Add_Article.ShowDialog(this);
            //TODO : update list view
        }

        private void ajouterToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AddFamille Add_Famille = new AddFamille();
            Add_Famille.ShowDialog(this);
            //TODO : update list view
        }

        private void ajouterToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            AddSousFamille Add_Sous_Famille = new AddSousFamille();
            Add_Sous_Famille.ShowDialog(this);
            //TODO : update list view
        }

        private void ajouterToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            AddMarque Add_Marque = new AddMarque();
            Add_Marque.ShowDialog(this);
            //TODO : update list view
        }
    }
}
