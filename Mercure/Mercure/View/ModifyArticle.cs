using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mercure.View
{
    public partial class ModifyArticle : Form
    {
        public ModifyArticle()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Btn_CancelModifyArticle_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_SubmitModifyArticle_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
