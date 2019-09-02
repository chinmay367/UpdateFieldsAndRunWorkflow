using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Update : Form
    {
        private string accessToken;
        private string resource = @"https://sourcingpoc.crm.dynamics.com";
        public Update()
        {
            InitializeComponent();
            Token token = new Token();
            accessToken = token.getToken();
            List<string> mylist = new List<string>();
            Entity entity = new Entity();
            mylist = entity.getEntities(resource, accessToken);

            foreach(var name in mylist)
            {
                comboBox1.Items.Add(name.ToString());
            }
        }

        private void Label1_Click(object sender, EventArgs e)
        {
            
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void EntityTbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void RecordTbox_TextChanged(object sender, EventArgs e)
        {
            List<string> mylist = new List<string>();
            Field field = new Field();
            mylist = field.getFields(resource, accessToken, comboBox1.Text, RecordTbox.Text);

            foreach (var name in mylist)
            {
                comboBox2.Items.Add(name.ToString());
            }
        }

        private void UpdBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            UpdODataWebApi updOdataWebApi = new UpdODataWebApi(comboBox1.Text, RecordTbox.Text, comboBox2.Text, NValTbox.Text);
            string check = updOdataWebApi.update(resource, accessToken);
            if (check == null)
            {
                MessageBox.Show("Record updated successfully with '" +comboBox2.Text+ "'=" + NValTbox.Text );
            }
            else
            {
                MessageBox.Show("Error " + check);
            }
            Form1 form = new Form1();
            form.Show();
        }

        private void NValTbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
