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
    public partial class ModifyFamille : Form
    {
        //Attributs
        private String RefFamily;
        private String NameFamily;

        public ModifyFamille()
        {
            InitializeComponent();
        }

        /// <summary>
        /// button： close the window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_MF_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Subimit the modification of Family
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_MF_Submit_Click(object sender, EventArgs e)
        {
            RefFamily = txtBox_ReferenceF.Text;
            NameFamily = txtBox_NameF.Text;

            int RefFamily_Int = int.Parse(RefFamily);

            FamillyController Family_Controller = new FamillyController();
            Familly Family = Family_Controller.GetFamillyByRef(RefFamily_Int);

            Family_Controller.UpdateFamilly(RefFamily_Int, NameFamily);
            MessageBox.Show("Family modified successfully ;)", "Family modified", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.DialogResult = DialogResult.OK;
            this.Dispose();
        }


        /// <summary>
        /// Get the informations of the selected item
        /// </summary>
        /// <param name="SelectedFamily"></param>
        public void GetFamilyToModify(ListViewItem SelectedFamily)
        {
            FamillyController FamController = new FamillyController();
            Familly FamilyToModify = new Familly();

            FamilyToModify = FamController.GetFamillyByRef(Convert.ToInt32(SelectedFamily.Text));
            this.txtBox_ReferenceF.Text = FamilyToModify.RefFamille1.ToString();
            this.txtBox_NameF.Text = FamilyToModify.Nom1.ToString();
     
        }


        /// <summary>
        /// Get the changes of the nameFamily textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtBox_NameF_TextChanged(object sender, EventArgs e)
        {
            NameFamily = txtBox_NameF.Text;
        }
    }
}
