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
    public partial class FormInfo : Form
    {
        FormContainer formContainer;
        public FormInfo(FormContainer formContainer)
        {
            InitializeComponent();
            this.formContainer = formContainer;

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            formContainer.dataGridView1.Rows.Add(tboID.Text,tboFirstName.Text,tboLastName.Text);
            clear();
        }

        private void clear()
        {
            tboID.Text = "";
            tboFirstName.Text = "";
            tboLastName.Text = "";
        }
    }
}
