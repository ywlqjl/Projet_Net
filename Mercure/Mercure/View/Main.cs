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
        private System.Collections.Specialized.StringCollection colstr = new System.Collections.Specialized.StringCollection();
        public static ListViewItem SelectedArticle;
        private ArticleController ArticleController = new ArticleController();


        //For Sorting List View
        private int sortColumn = -1;

        public Main()
        {
            InitializeComponent();
            listView_ShowBD_DataBinding();
            //this.listView_ShowBD.ItemActivate += new EventHandler(listView_ShowBD.item); 
        }
        /// <summary>
        /// OpenFile window to load files
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFile Openfile = new OpenFile();
            Openfile.ShowDialog();

            //Console.WriteLine(Openfile.DialogResult);
            if (Openfile.DialogResult == DialogResult.OK)
            {
               
                listView_ShowBD_DataBinding();
            }

        }
        /// <summary>
        /// Create ListViewItems
        /// </summary>
        /// <returns></returns>
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
        /// <summary>
        /// Bind listview of main window
        /// </summary>
        private void listView_ShowBD_DataBinding()
        {
           
           

            ListArticle = ArticleController.GetAllArticle();
            listView_ShowBD.Items.Clear();
            this.BindDataToView(this.MakeListItem());

        }

        private void listView_ShowBD_SelectedIndexChanged(object sender, EventArgs e)
        {
           // ListView.SelectedListViewItemCollection MultiArticles = this.listView_ShowBD.SelectedItems;

            //Article SelectedArticle = MultiArticles[0];
            //if (MultiArticles != null)
            //{
            //    ModifyArticle ModifyArticle = new ModifyArticle();
            //    ModifyArticle.ShowDialog(this);
                //SelectedRefArticle = int.Parse(MultiArticles[0].ToString());
                //this.listView_ShowBD.TopItem = MultiArticles[0];
                //listView_ShowBD.TopItem.ForeColor = Color.Red;
                //Console.WriteLine(SelectedRefArticle);
            //}

            // ModifyArticle ModifyArticle = new ModifyArticle();
            // ModifyArticle.ShowDialog(this);
            //ModifyArticle.GetArticleToModify(IndexOf(Article));

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

            /*ArticleController ArticleController = new ArticleController();
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
                
            }*/
            
            // Determine whether the column is the same as the last column clicked.
            if (e.Column != sortColumn)
            {
                // Set the sort column to the new column.
                sortColumn = e.Column;
                // Set the sort order to ascending by default.
                listView_ShowBD.Sorting = System.Windows.Forms.SortOrder.Ascending;
            }
            else
            {
                // Determine what the last sort order was and change it.
                if (listView_ShowBD.Sorting == System.Windows.Forms.SortOrder.Ascending)
                    listView_ShowBD.Sorting = System.Windows.Forms.SortOrder.Descending;
                else
                    listView_ShowBD.Sorting = System.Windows.Forms.SortOrder.Ascending;
            }

            // Call the sort method to manually sort.
            listView_ShowBD.Sort();
            // Set the ListViewItemSorter property to a new ListViewItemComparer
            // object.
            this.listView_ShowBD.ListViewItemSorter = new ListViewItemComparer(e.Column, listView_ShowBD.Sorting);
        }

        private void ajouterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddArticle Add_Article = new AddArticle();
            Add_Article.ShowDialog(this);

            if (Add_Article.DialogResult == DialogResult.OK)
            {
                listView_ShowBD_DataBinding();
            }

        }

        private void ajouterToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AddFamille Add_Famille = new AddFamille();
            Add_Famille.ShowDialog(this);

            if (Add_Famille.DialogResult == DialogResult.OK)
            {
                listView_ShowBD_DataBinding();
            }
        }

        private void ajouterToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            AddSousFamille Add_Sous_Famille = new AddSousFamille();
            Add_Sous_Famille.ShowDialog(this);

            if (Add_Sous_Famille.DialogResult == DialogResult.OK)
            {
                listView_ShowBD_DataBinding();
            }
        }

        private void ajouterToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            AddMarque Add_Marque = new AddMarque();
            Add_Marque.ShowDialog(this);

            if (Add_Marque.DialogResult == DialogResult.OK)
            {
                listView_ShowBD_DataBinding();
            }
        }

        private void afficherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DisplayFamille Display_Familles = new DisplayFamille();
            Display_Familles.ShowDialog(this);
        }

        private void afficherToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DisplaySousFamille Display_Sous_Familles = new DisplaySousFamille();
            Display_Sous_Familles.ShowDialog(this);
        }

        private void afficherToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            DisplayMarque Display_Marques = new DisplayMarque();
            Display_Marques.ShowDialog(this);
        }

        /// <summary>
        /// Double click to modify a selected article in listview of Main window.
        /// </summary>
        /// <param name="sender">action</param>
        /// <param name="e">mosue position</param>
        private void listView_ShowBD_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ListViewHitTestInfo info = listView_ShowBD.HitTest(e.X, e.Y);
            SelectedArticle = info.Item;
            Console.WriteLine(SelectedArticle.Text);
            if (info.Item != null)
            {
                ModifyArticle ModifyArticle = new ModifyArticle();
                ModifyArticle.GetArticleToModify(SelectedArticle);
                ModifyArticle.GetArticleToModify2(SelectedArticle);

                ModifyArticle.ShowDialog(this);
               
            }
        }

        private void OnRightClick(object sender, MouseEventArgs e)
        {
            ListViewHitTestInfo info = listView_ShowBD.HitTest(e.X, e.Y);
            SelectedArticle = info.Item;
            if (e.Button == MouseButtons.Right)
            {
                Strip.Show(this.listView_ShowBD, e.Location);
            }
            //Strip.Click
        }

        private void AddArticleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddArticle Add_Article = new AddArticle();
            Add_Article.ShowDialog(this);

            if (Add_Article.DialogResult == DialogResult.OK)
            {
                listView_ShowBD_DataBinding();
            }
        }

        private void ModifyArticleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (SelectedArticle!= null)
            {
                ModifyArticle ModifyArticle = new ModifyArticle();
                ModifyArticle.GetArticleToModify(SelectedArticle);
                ModifyArticle.GetArticleToModify2(SelectedArticle);

                ModifyArticle.ShowDialog(this);

            }
        }

        private void DeleteArticleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Console.WriteLine(SelectedArticle.Text);
            Response Response = ArticleController.DeleteArticle(SelectedArticle.Text);
            if (Response.State1)
            {
                listView_ShowBD_DataBinding();
            }
        }
    }
}
