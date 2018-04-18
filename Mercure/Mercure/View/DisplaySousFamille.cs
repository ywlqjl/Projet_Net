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
    public partial class DisplaySousFamille : Form
    {
        public static ListViewItem SelectedSubFamily;

        public DisplaySousFamille()
        {
            InitializeComponent();
            this.KeyPreview = true;
            LoadSubFamillies();
        }

        private void LoadSubFamillies()
        {
            this.List_View_Sous_Famille.Items.Clear();

            SubFamillyController Sub_Familly_Controller = new SubFamillyController();
            List<SubFamilly> List_Sub_Familly = Sub_Familly_Controller.GetAllSubFamilly();

            foreach (SubFamilly SubFamilly in List_Sub_Familly)
            {
                ListViewItem Item = new ListViewItem(Convert.ToString(SubFamilly.RefSousFamille1));

                ListViewItem.ListViewSubItem Name_Item = new ListViewItem.ListViewSubItem(Item, SubFamilly.Nom1);
                Item.SubItems.Add(Name_Item);

                FamillyController Familly_Controller = new FamillyController();
                Familly Familly = Familly_Controller.GetFamillyByRef(SubFamilly.RefFamille1.RefFamille1);

                ListViewItem.ListViewSubItem familly_Item = new ListViewItem.ListViewSubItem(Item, Familly != null ? Familly.Nom1 : "");
                Item.SubItems.Add(familly_Item);

                List_View_Sous_Famille.Items.Add(Item);
            }
        }

        private void List_View_Sous_Famille_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void List_View_Sous_Famille_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ListViewHitTestInfo info = List_View_Sous_Famille.HitTest(e.X, e.Y);
            SelectedSubFamily = info.Item;
            Console.WriteLine(SelectedSubFamily.Text);
            if (info.Item != null)
            {
                ModifySubFamily ModifySubFamily = new ModifySubFamily();
                ModifySubFamily.GetSubFamilyToModify(SelectedSubFamily);

                ModifySubFamily.ShowDialog(this);
                if(ModifySubFamily.DialogResult == DialogResult.OK)
                {
                    LoadSubFamillies();
                }

            }
        }

        private void List_View_Sous_Famille_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                LoadSubFamillies();
            }
        }

        private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SubFamillyController Sub_Familly_Controller = new SubFamillyController();
            if (SelectedSubFamily != null)
            {

                Response Response = Sub_Familly_Controller.DeleteSubFamilly(int.Parse(SelectedSubFamily.Text));
                if (Response.State1)
                {
                    LoadSubFamillies();
                }
                else
                {
                    MessageBox.Show(Response.Message1, "Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void AddToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddSousFamille Add_Sous_Famille = new AddSousFamille();
            Add_Sous_Famille.ShowDialog(this);

            if (Add_Sous_Famille.DialogResult == DialogResult.OK)
            {
                LoadSubFamillies();
            }
        }

        private void OnRightClick(object sender, MouseEventArgs e)
        {
            ListViewHitTestInfo info = this.List_View_Sous_Famille.HitTest(e.X, e.Y);
            SelectedSubFamily = info.Item;
            if (e.Button == MouseButtons.Right)
            {
                this.SubFamilyMenuStrip.Show(this.List_View_Sous_Famille, e.Location);
            }
        }
    }
}
