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
    {
        public static ListViewItem SelectedFamily;
        public DisplayFamille()
        {
            InitializeComponent();
            this.KeyPreview = true;
            LoadFamillies();

        }

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

        private void familleListView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                LoadFamillies();
            }
        }
    }
}
