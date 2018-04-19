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
    public partial class ModifySubFamily : Form
    {
        //Attributs
        private String RefSubFamily;
        private String NameSubFamily;
        private int RefFamily;


        public ModifySubFamily()
        {
            InitializeComponent();
            InitializeForm();
        }
        /// <summary>
        /// initialisation
        /// </summary>
        private void InitializeForm()
        {
            FamillyController Familly_Controller = new FamillyController();
            List<Familly> List_Familly = Familly_Controller.GetAllFamilly();
            foreach (Familly Familly in List_Familly)
            {
                this.comboBox_F.Items.Add(Familly.Nom1);
            }

           
        }

        /// <summary>
        /// close the window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// get the infomations of the selected item
        /// </summary>
        /// <param name="SelectedSubFamily"></param>
        public void GetSubFamilyToModify(ListViewItem SelectedSubFamily)
        {
            SubFamillyController SubFamController = new SubFamillyController();
            SubFamilly SubFamilyToModify = new SubFamilly();

            SubFamilyToModify = SubFamController.GetSubFamillyByRef(int.Parse(SelectedSubFamily.Text));
            //Console.WriteLine("列表中选中的sub id"+SelectedSubFamily.Text);

            this.textBox_RefSF.Text = SubFamilyToModify.RefSousFamille1.ToString();
            this.textBox_NameSF.Text = SubFamilyToModify.Nom1.ToString();
            this.comboBox_F.Text = SubFamilyToModify.RefFamille1.Nom1.ToString();

        }

        
        /// <summary>
        /// get the changes from the textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox_NameSF_TextChanged(object sender, EventArgs e)
        {
            NameSubFamily = textBox_NameSF.Text;
        }

        private void comboBox_F_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefFamily = comboBox_F.SelectedIndex+1;
            Console.WriteLine("refFamily-changed:" + RefFamily);
        }

        /// <summary>
        /// button: sava all the changes and close the window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_SF_Submit_Click(object sender, EventArgs e)
        {
            RefSubFamily = textBox_RefSF.Text;
           // NameSubFamily = textBox_NameSF.Text;
            //RefFamily = comboBox_F.SelectedIndex;
            //Console.WriteLine("refFamily-before:" + RefFamily);


            int RefSubFamily_Int = int.Parse(RefSubFamily);

            //FamillyController Familly_Controller = new FamillyController();
            //List<Familly> List_Familly = Familly_Controller.GetAllFamilly();
            //Familly Familly = List_Familly[RefFamily];
            //Console.WriteLine("family id:", Familly.Nom1);
            //Console.WriteLine("family nom:",Familly.Nom1);

            SubFamillyController SubFamily_Controller = new SubFamillyController();
            //SubFamilly SubFamilly = SubFamily_Controller.GetSubFamillyByRef(RefSubFamily_Int);

           
            SubFamily_Controller.UpdateSubFamilly(RefSubFamily_Int, RefFamily, NameSubFamily);
            MessageBox.Show("SubFamily modified successfully ;)", "SubFamily modified", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.DialogResult = DialogResult.OK;
            this.Dispose();
        }
    }
}
