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
    public partial class FormAdm : Form
    {
        public FormAdm()
        {
            InitializeComponent();
        }

        private void recordesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.recordesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.databaseRecordDataSet);

        }

        private void FormAdm_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'databaseRecordDataSet.Recordes'. Você pode movê-la ou removê-la conforme necessário.
            this.recordesTableAdapter.Fill(this.databaseRecordDataSet.Recordes);
            timer1.Enabled = true;

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            FormMenu form = new FormMenu();
            form.Show();
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            
            if (tabControl1.SelectedTab.Text == tabPage2.Text)
            {
                labelNome.Visible = true;
                textBox1.Visible = true;
                this.recordesTableAdapter.FillByProcura(this.databaseRecordDataSet.Recordes, textBox1.Text);
            }
            else
            {
                labelNome.Visible = false;
                textBox1.Visible = false;
            }


        }
    }
}
