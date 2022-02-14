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
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'databaseRecordDataSet.Recordes'. Você pode movê-la ou removê-la conforme necessário.
            this.recordesTableAdapter.Fill(this.databaseRecordDataSet.Recordes);
            this.recordesTableAdapter.FillByLogin(this.databaseRecordDataSet.Recordes, FormLogin.user, FormLogin.user);
            userToolStripMenuItem.Text = "User: " + FormLogin.user;
            if (FormLogin.user != "Admin")
            {
                administradorToolStripMenuItem.Enabled = false;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 frm1 = new Form1(200);
            frm1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 frm1 = new Form1(150);
            frm1.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 frm1 = new Form1(50);
            frm1.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
                
                string message = "Deseja realmente sair?";
                string caption = "Sair";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result;

               
                result = MessageBox.Show(message, caption, buttons);
                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    Application.Exit();
                }
            

        }

        private void recordesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.recordesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.databaseRecordDataSet);

        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            recordesBindingNavigatorSaveItem_Click(sender, e);
            FormLogin formLogin = new FormLogin();
            formLogin.Show();
            this.Close();
        }

        private void administradorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAdm formAdm = new FormAdm();
            formAdm.Show();
            this.Close();
        }
    }
}
