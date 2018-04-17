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
        public DisplaySousFamille()
        {
            InitializeComponent();
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
                Familly Familly = Familly_Controller.GetFamillyByRef(SubFamilly.RefSousFamille1);

                ListViewItem.ListViewSubItem familly_Item = new ListViewItem.ListViewSubItem(Item, Familly != null ? Familly.Nom1 : "");
                Item.SubItems.Add(familly_Item);

                List_View_Sous_Famille.Items.Add(Item);
            }
        }
    }
}
