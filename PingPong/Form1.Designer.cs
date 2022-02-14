
namespace PingPong
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label pontosLabel;
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.userToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pNToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.tabelaDeRecordesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.pontosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
            this.administradorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBoxRaquete = new System.Windows.Forms.PictureBox();
            this.pictureBoxBolo = new System.Windows.Forms.PictureBox();
            this.databaseRecordDataSet = new PingPong.DatabaseRecordDataSet();
            this.recordesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.recordesTableAdapter = new PingPong.DatabaseRecordDataSetTableAdapters.RecordesTableAdapter();
            this.tableAdapterManager = new PingPong.DatabaseRecordDataSetTableAdapters.TableAdapterManager();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.pontosTextBox = new System.Windows.Forms.TextBox();
            pontosLabel = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRaquete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBolo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseRecordDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recordesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pontosLabel
            // 
            pontosLabel.AutoSize = true;
            pontosLabel.Location = new System.Drawing.Point(843, 50);
            pontosLabel.Name = "pontosLabel";
            pontosLabel.Size = new System.Drawing.Size(43, 13);
            pontosLabel.TabIndex = 5;
            pontosLabel.Text = "Pontos:";
            pontosLabel.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userToolStripMenuItem,
            this.toolStripMenuItem1,
            this.pNToolStripMenuItem,
            this.toolStripMenuItem2,
            this.tabelaDeRecordesToolStripMenuItem,
            this.toolStripMenuItem5,
            this.toolStripMenuItem4,
            this.pontosToolStripMenuItem,
            this.toolStripMenuItem3,
            this.toolStripMenuItem6,
            this.toolStripMenuItem7,
            this.administradorToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(841, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // userToolStripMenuItem
            // 
            this.userToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.loginToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.userToolStripMenuItem.Name = "userToolStripMenuItem";
            this.userToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.userToolStripMenuItem.Text = "User:";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.menuToolStripMenuItem.Text = "Menu";
            this.menuToolStripMenuItem.Click += new System.EventHandler(this.menuToolStripMenuItem_Click);
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.loginToolStripMenuItem.Text = "Log Out";
            this.loginToolStripMenuItem.Click += new System.EventHandler(this.loginToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(25, 20);
            this.toolStripMenuItem1.Text = "||";
            // 
            // pNToolStripMenuItem
            // 
            this.pNToolStripMenuItem.Name = "pNToolStripMenuItem";
            this.pNToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.pNToolStripMenuItem.Text = "PN:";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(28, 20);
            this.toolStripMenuItem2.Text = " ||";
            // 
            // tabelaDeRecordesToolStripMenuItem
            // 
            this.tabelaDeRecordesToolStripMenuItem.Name = "tabelaDeRecordesToolStripMenuItem";
            this.tabelaDeRecordesToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.tabelaDeRecordesToolStripMenuItem.Text = "Recorde:";
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Enabled = false;
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(64, 20);
            this.toolStripMenuItem5.Text = "---------";
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(25, 20);
            this.toolStripMenuItem4.Text = "||";
            // 
            // pontosToolStripMenuItem
            // 
            this.pontosToolStripMenuItem.Name = "pontosToolStripMenuItem";
            this.pontosToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.pontosToolStripMenuItem.Text = "Pontos:";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(25, 20);
            this.toolStripMenuItem3.Text = "||";
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(25, 20);
            this.toolStripMenuItem6.Text = "||";
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.Size = new System.Drawing.Size(25, 20);
            this.toolStripMenuItem7.Text = "||";
            // 
            // administradorToolStripMenuItem
            // 
            this.administradorToolStripMenuItem.Name = "administradorToolStripMenuItem";
            this.administradorToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.administradorToolStripMenuItem.Text = "Administrador";
            this.administradorToolStripMenuItem.Click += new System.EventHandler(this.administradorToolStripMenuItem_Click);
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(280, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(73, 20);
            this.textBox1.TabIndex = 3;
            // 
            // pictureBoxRaquete
            // 
            this.pictureBoxRaquete.Image = global::PingPong.Properties.Resources.vertical_line;
            this.pictureBoxRaquete.Location = new System.Drawing.Point(799, 156);
            this.pictureBoxRaquete.Name = "pictureBoxRaquete";
            this.pictureBoxRaquete.Size = new System.Drawing.Size(22, 133);
            this.pictureBoxRaquete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxRaquete.TabIndex = 1;
            this.pictureBoxRaquete.TabStop = false;
            // 
            // pictureBoxBolo
            // 
            this.pictureBoxBolo.Image = global::PingPong.Properties.Resources.png_transparent_bitter_orange_peel_town_information_ping_pong_ball_sport_orange_sphere;
            this.pictureBoxBolo.Location = new System.Drawing.Point(676, 195);
            this.pictureBoxBolo.Name = "pictureBoxBolo";
            this.pictureBoxBolo.Size = new System.Drawing.Size(31, 31);
            this.pictureBoxBolo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxBolo.TabIndex = 0;
            this.pictureBoxBolo.TabStop = false;
            // 
            // databaseRecordDataSet
            // 
            this.databaseRecordDataSet.DataSetName = "DatabaseRecordDataSet";
            this.databaseRecordDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // recordesBindingSource
            // 
            this.recordesBindingSource.DataMember = "Recordes";
            this.recordesBindingSource.DataSource = this.databaseRecordDataSet;
            // 
            // recordesTableAdapter
            // 
            this.recordesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.RecordesTableAdapter = this.recordesTableAdapter;
            this.tableAdapterManager.UpdateOrder = PingPong.DatabaseRecordDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(426, 3);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(73, 20);
            this.textBox2.TabIndex = 4;
            // 
            // pontosTextBox
            // 
            this.pontosTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.recordesBindingSource, "Pontos", true));
            this.pontosTextBox.Location = new System.Drawing.Point(847, 79);
            this.pontosTextBox.Name = "pontosTextBox";
            this.pontosTextBox.Size = new System.Drawing.Size(100, 20);
            this.pontosTextBox.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 495);
            this.Controls.Add(pontosLabel);
            this.Controls.Add(this.pontosTextBox);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pictureBoxRaquete);
            this.Controls.Add(this.pictureBoxBolo);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ping Pong";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRaquete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBolo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseRecordDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recordesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxBolo;
        private System.Windows.Forms.PictureBox pictureBoxRaquete;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem userToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem pNToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem tabelaDeRecordesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pontosToolStripMenuItem;
        private DatabaseRecordDataSet databaseRecordDataSet;
        private System.Windows.Forms.BindingSource recordesBindingSource;
        private DatabaseRecordDataSetTableAdapters.RecordesTableAdapter recordesTableAdapter;
        private DatabaseRecordDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox pontosTextBox;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem administradorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem7;
    }
}

