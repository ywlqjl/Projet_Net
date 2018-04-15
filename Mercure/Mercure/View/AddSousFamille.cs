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
    public partial class AddSousFamille : Form
    {
        public AddSousFamille()
        {
            InitializeComponent();
            InitializeForm();
        }

        private void InitializeForm()
        {
            FamillyController Familly_Controller = new FamillyController();
            List<Familly> List_Familly = Familly_Controller.GetAllFamilly();

            foreach (Familly Familly in List_Familly)
            {
                Combo_Box_Famille.Items.Add(Familly.Nom1);
                //Combo_Box_Famille.SelectedIndex = 0;
            }
        }

        private void AddSousFamille_Load(object sender, EventArgs e)
        {

        }

        private void Btn_Cancel_Sous_Famille_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_Add_Sous_Famille_Click(object sender, EventArgs e)
        {
            
            String Reference = Text_Box_Reference.Text;
            String Name = Text_Box_Name.Text;
            
            int Familly_Index = Combo_Box_Famille.SelectedIndex;

            if (Familly_Index > -1 && !Reference.Equals("") && !Name.Equals(""))
            {
                try
                {
                    int Reference_Int = int.Parse(Reference);
                    
                    SubFamillyController Sub_Familly_Controller = new SubFamillyController();
                    SubFamilly Sub_Familly = Sub_Familly_Controller.GetSubFamillyByRef(Reference_Int);

                    List<Familly> List_Familly = new FamillyController().GetAllFamilly();
                    int Reference_Familly = List_Familly[Familly_Index].RefFamille1;


                    if (Sub_Familly == null)
                    {
                        Sub_Familly_Controller.InsertSubFamilly(Reference_Int, Reference_Familly, Name);
                        MessageBox.Show("Sub Familly added successfully ;)", "Sub Familly Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Sub Familly exists already in database", "Error Add Sub Familly", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    
                    this.Dispose();
                }
                catch (FormatException e1)
                {
                    //Message de l'exception pour notifier l'utilisateur
                    MessageBox.Show(e1.Message, "Error Add Sub Familly", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                //Message de remplir pour l'utilisateur
                MessageBox.Show("Please fill in all the fields", "Error Add Sub Familly", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
