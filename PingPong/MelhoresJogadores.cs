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
    public partial class MelhoresJogadores : Form
    {
       
        private void fillByPontosToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.recordesTableAdapter.FillByPontos(this.databaseRecordDataSet.Recordes);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }


        public MelhoresJogadores()
        {
            InitializeComponent();

            
        }

        private void recordesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.recordesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.databaseRecordDataSet);

        }

        private void MelhoresJogadores_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'databaseRecordDataSet.Recordes'. Você pode movê-la ou removê-la conforme necessário.
            this.recordesTableAdapter.Fill(this.databaseRecordDataSet.Recordes);
            this.recordesTableAdapter.FillByPontos(this.databaseRecordDataSet.Recordes);

        }


        private void buttonVoltar_Click(object sender, EventArgs e)
        {
            FormMenu formMenu = new FormMenu();
            formMenu.Show();
            this.Close();
        }

        private void recordesBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.recordesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.databaseRecordDataSet);

        }

        private void recordesBindingNavigatorSaveItem_Click_2(object sender, EventArgs e)
        {
            this.Validate();
            this.recordesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.databaseRecordDataSet);

        }

        private void button1_Click(object sender, EventArgs e)
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
    }
}
