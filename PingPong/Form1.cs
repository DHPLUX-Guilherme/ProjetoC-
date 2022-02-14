using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace PingPong
{
    public partial class Form1 : Form
    {
        System.Media.SoundPlayer Pd;


        int velocidade = 35;
        int resultado;
        bool topo, esquerda;
        int score;
        int PN;
        int pontos;
        

        public Form1(int valor)
        {
            InitializeComponent();
            if (valor == 0)
            {
                pontos = valor;
                valor = 100;
            }
            if(valor == 200)
            {
                pontos = valor;
                velocidade = 25;
            }
            if (valor == 150)
            {
                pontos = valor;
                velocidade = 30;
            }
            if (valor == 50)
            {
                pontos = valor;
                velocidade = 35;
            }
            else
            {
                pictureBoxRaquete.Height = valor; 
            }
        }

        

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pictureBoxBolo.Left > pictureBoxRaquete.Left)
            {
                System.IO.Stream ldl = Properties.Resources.Lose_sound_effect;
                Pd = new System.Media.SoundPlayer(ldl);
                Pd.Play();
                timer1.Enabled = false; MessageBox.Show("Você perdeu :  " + resultado.ToString());

                if (resultado > score)
                {
                    pontosTextBox.Text = resultado.ToString();

                    this.Validate();
                    this.recordesBindingSource.EndEdit();
                    this.tableAdapterManager.UpdateAll(this.databaseRecordDataSet);

                    this.Close();
                    MelhoresJogadores melhoresJogadores = new MelhoresJogadores();
                    melhoresJogadores.Show();
                }
                else
                {
                    this.Close();
                    MelhoresJogadores melhoresJogadores = new MelhoresJogadores();
                    melhoresJogadores.Show();
                }
            }

            if (pictureBoxBolo.Left + pictureBoxBolo.Width >= pictureBoxRaquete.Left && pictureBoxBolo.Left + pictureBoxBolo.Width
                <= pictureBoxRaquete.Left + pictureBoxRaquete.Width
                && pictureBoxBolo.Top + pictureBoxBolo.Height >= pictureBoxRaquete.Top && pictureBoxBolo.Top + pictureBoxBolo.Height
                <= pictureBoxRaquete.Top + pictureBoxRaquete.Height + pictureBoxBolo.Height)
            {

                esquerda = false;
                if(pontos == 200)
                {
                    resultado += 1;
                }
                else if (pontos == 150)
                {
                    resultado += 5;
                }
                else if (pontos == 50)
                {
                    resultado += 10;
                }

                textBox2.Text = resultado.ToString();
                if (score <= resultado || score < resultado)
                {

                    textBox1.Text = textBox2.Text;
                    
                }
            }

           

            if (esquerda)
            {
                pictureBoxBolo.Left += velocidade;
                
            }    
            else
            {
                
                pictureBoxBolo.Left -= velocidade;
            }
            if (topo)
            {
                
                pictureBoxBolo.Top += velocidade;
            }  
            else
            {
                
                pictureBoxBolo.Top -= velocidade;
            }     
            if (pictureBoxBolo.Top >= this.Height - 50)
            {
               
                topo = false;
            }
            if (pictureBoxBolo.Top <= 50)
            {
                
                topo = true;
            }
            if (pictureBoxBolo.Left <= 10)
            {
                
                esquerda = true;
            }
           


            
            
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBoxRaquete.Top = e.Y;
        }

        private void recordesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.recordesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.databaseRecordDataSet);

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {

            FormLogin formLogin = new FormLogin();
            formLogin.Show();
            this.Close();

        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {

            FormMenu formMenu = new FormMenu();
            formMenu.Show();
            this.Close();
        }

        private void administradorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAdm formAdm = new FormAdm();
            formAdm.Show();
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            resultado = 0;
            // TODO: esta linha de código carrega dados na tabela 'databaseRecordDataSet.Recordes'. Você pode movê-la ou removê-la conforme necessário.
            this.recordesTableAdapter.Fill(this.databaseRecordDataSet.Recordes);
            Random rand = new Random();
            pictureBoxBolo.Location = new Point(0, rand.Next(this.Height));
            topo = esquerda = true;
            timer1.Enabled = true;
            this.recordesTableAdapter.FillByLogin(this.databaseRecordDataSet.Recordes, 
                FormLogin.user, FormLogin.pass);
            userToolStripMenuItem.Text = "User: " + FormLogin.user;
            score = this.databaseRecordDataSet.Recordes[0].Pontos;
            PN = this.databaseRecordDataSet.Recordes[0].Telemovel;
            pNToolStripMenuItem.Text = PN.ToString();
            textBox1.Text = score.ToString();
            Label clickedLabel = sender as Label;
            if (FormLogin.user != "Admin")
            {
                administradorToolStripMenuItem.Enabled = false;
            }

            

        }
    }
}
