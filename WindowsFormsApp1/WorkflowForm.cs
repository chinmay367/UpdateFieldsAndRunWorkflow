using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class WorkflowForm : Form
    {
        private string accessToken;
        public WorkflowForm()
        {
            InitializeComponent();
            Token token = new Token();
            accessToken = token.getToken();
        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void RunWfl_Click(object sender, EventArgs e)
        {
            this.Hide();
            WorkflwODataWebApi workflwODataWebApi = new WorkflwODataWebApi(WorkflwTbox.Text, RecordTbox.Text);
            string resource = @"https://sourcingpoc.crm.dynamics.com";
            string check = workflwODataWebApi.run_Workflow(resource, accessToken);
            if (check == null)
            {
                MessageBox.Show("Workflow id = " + WorkflwTbox.Text + " ran successfully on record id = " + RecordTbox.Text);
            }
            else
            {
                MessageBox.Show("Error " + check);
            }
            Form1 form = new Form1();
            form.Show();
        }

        private void WorkflwTbox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
