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

namespace Mercure
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFile Openfile = new OpenFile();
            //Openfile.
            Openfile.ShowDialog();

            Console.WriteLine(Openfile.DialogResult);
            if (Openfile.DialogResult == DialogResult.OK)
            {
                Console.WriteLine("1111");
                listView_ShowBD_DataBinding();
            }

        }

        private void listView_ShowBD_DataBinding()
        {
            List<Article> ListArticle = new List<Article>();
            ArticleController ArticleController = new ArticleController();

            ListArticle = ArticleController.GetAllArticle();
            listView_ShowBD.Items.Clear();

            foreach (Article Article in ListArticle)
            {
                ListViewItem ArticleItem = new ListViewItem();
                ArticleItem.Text = Article.RefArticle1.ToString();

                ArticleItem.SubItems.Add(Article.Description1.ToString());
                ArticleItem.SubItems.Add(Article.RefSubFamilly1.RefSousFamille1.ToString());
                ArticleItem.SubItems.Add(Article.RefMark1.RefMarque1.ToString());
                ArticleItem.SubItems.Add(Article.PriceHT1.ToString());
                ArticleItem.SubItems.Add(Article.Quantity1.ToString());

                this.listView_ShowBD.Items.Add(ArticleItem);

            }
        }

        private void listView_ShowBD_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //just test
        private void Btn_UpdataListView_Click(object sender, EventArgs e)
        {
            this.listView_ShowBD.Update();

        }
    }
}
