using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Mercure.Model;
using Mercure.Controller;

namespace Mercure.View
{
    public partial class AddFamille : Form
    {
        public AddFamille()
        {
            InitializeComponent();
            FamillyController Familly_Controller = new FamillyController();
            Text_Box_Reference.Text = (Familly_Controller.GetMaxFamillyId() + 1).ToString();
        }

        private void Btn_Cancel_Famille_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_Add_Famille_Click(object sender, EventArgs e)
        {
            FamillyController Familly_Controller = new FamillyController();

            String Reference = Text_Box_Reference.Text;
            String Name = Text_Box_Name.Text;

            if(!Reference.Equals("") && !Name.Equals(""))
            {
                try
                {
                    int Reference_Int = int.Parse(Reference);
                    Familly Familly = Familly_Controller.GetFamillyByRef(Reference_Int);
                    if(Familly == null)
                    {
                        Familly_Controller.InsertFamilly(Reference_Int, Name);
                        MessageBox.Show("Familly added successfully ;) ", "Added Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("This reference already exists in DataBase", "Error Add Familly", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    this.DialogResult = DialogResult.OK;
                    this.Dispose();
                }
                catch(FormatException e2)
                {
                    MessageBox.Show(e2.Message, "Error add familly ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please fill in all fields", "Error Add Familly ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
