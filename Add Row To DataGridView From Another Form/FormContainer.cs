using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Add_Row_To_DataGridView_From_Another_Form
{
    public partial class FormContainer : Form
    {
        public FormContainer()
        {
            InitializeComponent();
        }

        private void btnOpenForm_Click(object sender, EventArgs e)
        {
            FormInfo formInfo = new FormInfo(this);
            formInfo.Show();

        }
    }
}
