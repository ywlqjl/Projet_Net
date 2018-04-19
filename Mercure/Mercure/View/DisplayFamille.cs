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
    public partial class DisplayFamille : Form
    {   //attribut
        public static ListViewItem SelectedFamily;

        /// <summary>
        /// initialisations of the family listview
        /// </summary>
        public DisplayFamille()
        {
            InitializeComponent();
            this.KeyPreview = true;
            LoadFamillies();

        }

        /// <summary>
        /// load all the families to the family listiew
        /// </summary>
        private void LoadFamillies()
        {
            this.familleListView.Items.Clear();

            FamillyController Familly_Controller = new FamillyController();
            List<Familly> List_Familly = Familly_Controller.GetAllFamilly();

            foreach(Familly Familly in List_Familly)
            {
                ListViewItem refItem = new ListViewItem(Convert.ToString(Familly.RefFamille1));
                ListViewItem.ListViewSubItem nomItem = new ListViewItem.ListViewSubItem(refItem, Familly.Nom1);

                refItem.SubItems.Add(nomItem);
                familleListView.Items.Add(refItem);
            }

        }


        private void familleListView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Mouse double click for opening the family-modify window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void familleListView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ListViewHitTestInfo info = familleListView.HitTest(e.X, e.Y);
            SelectedFamily = info.Item;
            Console.WriteLine(SelectedFamily.Text);
            if (info.Item != null)
            {
                ModifyFamille ModifyFamille = new ModifyFamille();
                ModifyFamille.GetFamilyToModify(SelectedFamily);

                ModifyFamille.ShowDialog(this);

                if (ModifyFamille.DialogResult == DialogResult.OK)
                {
                    LoadFamillies();
                }


            }
        }

        /// <summary>
        /// Get the quick presskey F5 to Update the listview
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void familleListView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                LoadFamillies();
            }
        }

        /// <summary>
        /// Menu click to open the add window and update it on time
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddArticle Add_Article = new AddArticle();
            Add_Article.ShowDialog(this);

            if (Add_Article.DialogResult == DialogResult.OK)
            {
                LoadFamillies();
            }
        }

        /// <summary>
        /// mouse right click to open the menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnRightClick(object sender, MouseEventArgs e)
        {
            ListViewHitTestInfo info = this.familleListView.HitTest(e.X, e.Y);
            SelectedFamily = info.Item;
            if (e.Button == MouseButtons.Right)
            {
                this.FamilyStrip.Show(this.familleListView, e.Location);
            }
        }

        /// <summary>
        /// delete a family and update it on time
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeleteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FamillyController Familly_Controller = new FamillyController();
            if (SelectedFamily != null)
            {
                
                Response Response = Familly_Controller.DeleteFamilly(int.Parse(SelectedFamily.Text));
                if (Response.State1)
                {
                    LoadFamillies();
                }
                else {
                    MessageBox.Show(Response.Message1, "Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
