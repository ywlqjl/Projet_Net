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
    public partial class DisplayMarque : Form
    {
        public static ListViewItem SelectedBrand;

        public DisplayMarque()
        {
            InitializeComponent();
            this.KeyPreview = true;
            LoadBrands();
        }

        /// <summary>
        /// load all the brands
        /// </summary>
        private void LoadBrands()
        {
            this.List_View_Marque.Items.Clear();

            MarkController Mark_Controller = new MarkController();
            List<Mark> List_Mark = Mark_Controller.GetAllMark();

            foreach (Mark Mark in List_Mark)
            {
                ListViewItem refItem = new ListViewItem(Convert.ToString(Mark.RefMarque1));
                ListViewItem.ListViewSubItem nomItem = new ListViewItem.ListViewSubItem(refItem, Mark.Nom1);

                refItem.SubItems.Add(nomItem);
                List_View_Marque.Items.Add(refItem);
            }

        }
        /// <summary>
        /// double click to open the modify window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void List_View_Marque_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ListViewHitTestInfo info = List_View_Marque.HitTest(e.X, e.Y);
            SelectedBrand = info.Item;
            Console.WriteLine(SelectedBrand.Text);
            if (info.Item != null)
            {
                ModifyBrand ModifyBrand = new ModifyBrand();
                ModifyBrand.GetBrandToModify(SelectedBrand);

                ModifyBrand.ShowDialog(this);
                if(ModifyBrand.DialogResult == DialogResult.OK)
                {
                    LoadBrands();
                }

            }
        }

        /// <summary>
        ///  Get the quick presskey F5 to Update the listview
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void List_View_Marque_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                LoadBrands();
            }
        }

        private void List_View_Marque_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// item in a menu: delete a brand
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MarkController Mark_Controller = new MarkController();
            if (SelectedBrand != null)
            {

                Response Response = Mark_Controller.DeleteMark(int.Parse(SelectedBrand.Text));
                if (Response.State1)
                {
                    LoadBrands();
                }
                else
                {
                    MessageBox.Show(Response.Message1, "Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        /// <summary>
        /// item in a menu: add a brand
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddMarque Add_Marque = new AddMarque();
            Add_Marque.ShowDialog(this);

            if (Add_Marque.DialogResult == DialogResult.OK)
            {
                LoadBrands();
            }
        }

        /// <summary>
        /// mouse right click to open the menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnRightClick(object sender, MouseEventArgs e)
        {
            ListViewHitTestInfo info = this.List_View_Marque.HitTest(e.X, e.Y);
            SelectedBrand = info.Item;
            if (e.Button == MouseButtons.Right)
            {
                this.MarkMenuStrip.Show(this.List_View_Marque, e.Location);
            }
        }
    }
}
