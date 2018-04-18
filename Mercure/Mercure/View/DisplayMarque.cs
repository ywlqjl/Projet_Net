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
    }
}
