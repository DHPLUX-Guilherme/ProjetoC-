using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PingPong
{
    public partial class FormLogin : Form
    {

        static public string user;
        static public string pass;

        public FormLogin()
        {
            InitializeComponent();
        }

        private void recordesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.recordesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.databaseRecordDataSet);

        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'databaseRecordDataSet.Recordes'. Você pode movê-la ou removê-la conforme necessário.
            this.recordesTableAdapter.Fill(this.databaseRecordDataSet.Recordes);

        }

        private void buttonLogar_Click(object sender, EventArgs e)
        {
            int result =  this.recordesTableAdapter.FillByLogin(this.databaseRecordDataSet.Recordes, textBoxUsername.Text, textBoxPassword.Text);

            if (result == 1)
            {
               
                user = textBoxUsername.Text;
                pass = textBoxPassword.Text;
                FormMenu form1 = new FormMenu();
                form1.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Wrong Username/Password!");
                Application.Exit();
            }
        }

        private void textBoxPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                buttonLogar_Click(sender, e);
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
