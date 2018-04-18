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
    public partial class AddMarque : Form
    {
        MarkController Mark_Controller = new MarkController();
        public AddMarque()
        {
            InitializeComponent();
            Text_Box_Reference.Text = (Mark_Controller.GetMaxMarkId() + 1).ToString() ;
        }

        private void Btn_Cancel_Marque_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_Add_Marque_Click(object sender, EventArgs e)
        {
           
            String Reference = Text_Box_Reference.Text;
            String Name = Text_Box_Name.Text;
            
            if (!Reference.Equals("") && !Name.Equals(""))
            {
                try
                {
                    int Reference_Int = int.Parse(Reference);
                    
                    Mark Mark = Mark_Controller.GetMarkByRef(Reference_Int);

                    if (Mark == null)
                    {
                        Mark_Controller.InsertMark(Reference_Int, Name);
                        MessageBox.Show("Mark added Successfully ;) ", "Mark Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        //Message de l'exception pour notifier l'utilisateur
                        MessageBox.Show("MArk exists already in DataBase", "Error Add Mark", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    this.DialogResult = DialogResult.OK;
                    this.Dispose();
                }
                catch (FormatException e1)
                {
                    MessageBox.Show(e1.Message, "Error Add Mark", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please fill in all fields", "Error Add Mark", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
    
}
