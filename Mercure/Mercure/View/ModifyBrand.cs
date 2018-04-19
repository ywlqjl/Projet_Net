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
    public partial class ModifyBrand : Form
    {
        //Attributs
        private String RefBrand;
        private String NameBrand;

        public ModifyBrand()
        {
            InitializeComponent();
        }

        /// <summary>
        /// button: close the window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// button : save all the changes and close the window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_MB_Submit_Click(object sender, EventArgs e)
        {
            RefBrand = textBox1.Text;
            NameBrand = textBox2.Text;

            int RefBrand_Int = int.Parse(RefBrand);

            MarkController Brand_Controller = new MarkController();
            Mark Mark = Brand_Controller.GetMarkByRef(RefBrand_Int);

            Brand_Controller.UpdateMark(RefBrand_Int, NameBrand);
            MessageBox.Show("Brand modified successfully ;)", "Brand modified", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.DialogResult = DialogResult.OK;
            this.Dispose();
        }

        /// <summary>
        /// get the changes from textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            NameBrand = textBox2.Text;
        }

        /// <summary>
        /// get all the informations of the selected item
        /// </summary>
        /// <param name="SelectedBrand"></param>
        public void GetBrandToModify(ListViewItem SelectedBrand)
        {
            MarkController BrandController = new MarkController();
            Mark BrandToModify = new Mark();

            BrandToModify = BrandController.GetMarkByRef(Convert.ToInt32(SelectedBrand.Text));
            this.textBox1.Text = BrandToModify.RefMarque1.ToString();
            this.textBox2.Text = BrandToModify.Nom1.ToString();

        }
    }
}
