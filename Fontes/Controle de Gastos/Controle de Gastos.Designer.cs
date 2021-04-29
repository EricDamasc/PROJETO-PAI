
namespace Controle_de_Gastos
{
    partial class Controle_de_Gastos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Controle_de_Gastos));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.CAT_Inicio = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_SAIR = new System.Windows.Forms.ToolStripMenuItem();
            this.CAT_ADD_Motoristas = new System.Windows.Forms.ToolStripMenuItem();
            this.CAT_Ferramentas = new System.Windows.Forms.ToolStripMenuItem();
            this.CAT_AlcoolGasolina = new System.Windows.Forms.ToolStripMenuItem();
            this.CAT_MetaDiaria = new System.Windows.Forms.ToolStripMenuItem();
            this.Cat_UBER = new System.Windows.Forms.ToolStripMenuItem();
            this.CAT_ADDRegistroUBER = new System.Windows.Forms.ToolStripMenuItem();
            this.CAT_ResultadosUBER = new System.Windows.Forms.ToolStripMenuItem();
            this.CAT_AlterarUBER = new System.Windows.Forms.ToolStripMenuItem();
            this.CAT_ExcluirUBER = new System.Windows.Forms.ToolStripMenuItem();
            this.controle99POPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CAT_ADDRegistro99 = new System.Windows.Forms.ToolStripMenuItem();
            this.CAT_EXIBIRRegistro99 = new System.Windows.Forms.ToolStripMenuItem();
            this.CAT_AlterarRegistro99 = new System.Windows.Forms.ToolStripMenuItem();
            this.CAT_ExcluirRegistro99 = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CAT_Informações = new System.Windows.Forms.ToolStripMenuItem();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.Barra_Progresso = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.menuStrip1.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CAT_Inicio,
            this.CAT_ADD_Motoristas,
            this.Cat_UBER,
            this.controle99POPToolStripMenuItem,
            this.CAT_Ferramentas,
            this.sobreToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(785, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // CAT_Inicio
            // 
            this.CAT_Inicio.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_SAIR});
            this.CAT_Inicio.Image = ((System.Drawing.Image)(resources.GetObject("CAT_Inicio.Image")));
            this.CAT_Inicio.Name = "CAT_Inicio";
            this.CAT_Inicio.Size = new System.Drawing.Size(73, 21);
            this.CAT_Inicio.Text = "Inicio";
            // 
            // btn_SAIR
            // 
            this.btn_SAIR.Image = ((System.Drawing.Image)(resources.GetObject("btn_SAIR.Image")));
            this.btn_SAIR.Name = "btn_SAIR";
            this.btn_SAIR.Size = new System.Drawing.Size(180, 22);
            this.btn_SAIR.Text = "Sair";
            this.btn_SAIR.Click += new System.EventHandler(this.btn_SAIR_Click);
            // 
            // CAT_ADD_Motoristas
            // 
            this.CAT_ADD_Motoristas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CAT_ADD_Motoristas.Image = ((System.Drawing.Image)(resources.GetObject("CAT_ADD_Motoristas.Image")));
            this.CAT_ADD_Motoristas.Name = "CAT_ADD_Motoristas";
            this.CAT_ADD_Motoristas.Size = new System.Drawing.Size(170, 21);
            this.CAT_ADD_Motoristas.Text = "Adicionar Motoristas";
            this.CAT_ADD_Motoristas.Click += new System.EventHandler(this.CAT_ADD_Motoristas_Click);
            // 
            // CAT_Ferramentas
            // 
            this.CAT_Ferramentas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CAT_AlcoolGasolina,
            this.CAT_MetaDiaria});
            this.CAT_Ferramentas.Image = ((System.Drawing.Image)(resources.GetObject("CAT_Ferramentas.Image")));
            this.CAT_Ferramentas.Name = "CAT_Ferramentas";
            this.CAT_Ferramentas.Size = new System.Drawing.Size(119, 21);
            this.CAT_Ferramentas.Text = "Ferramentas";
            // 
            // CAT_AlcoolGasolina
            // 
            this.CAT_AlcoolGasolina.Image = ((System.Drawing.Image)(resources.GetObject("CAT_AlcoolGasolina.Image")));
            this.CAT_AlcoolGasolina.Name = "CAT_AlcoolGasolina";
            this.CAT_AlcoolGasolina.Size = new System.Drawing.Size(205, 22);
            this.CAT_AlcoolGasolina.Text = "Álcool ou Gasolina?";
            this.CAT_AlcoolGasolina.Click += new System.EventHandler(this.CAT_AlcoolGasolina_Click);
            // 
            // CAT_MetaDiaria
            // 
            this.CAT_MetaDiaria.Image = ((System.Drawing.Image)(resources.GetObject("CAT_MetaDiaria.Image")));
            this.CAT_MetaDiaria.Name = "CAT_MetaDiaria";
            this.CAT_MetaDiaria.Size = new System.Drawing.Size(205, 22);
            this.CAT_MetaDiaria.Text = "Meta Diária";
            this.CAT_MetaDiaria.Click += new System.EventHandler(this.CAT_MetaDiaria_Click);
            // 
            // Cat_UBER
            // 
            this.Cat_UBER.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CAT_ADDRegistroUBER,
            this.CAT_ResultadosUBER,
            this.CAT_AlterarUBER,
            this.CAT_ExcluirUBER});
            this.Cat_UBER.Image = ((System.Drawing.Image)(resources.GetObject("Cat_UBER.Image")));
            this.Cat_UBER.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Cat_UBER.Name = "Cat_UBER";
            this.Cat_UBER.Size = new System.Drawing.Size(126, 21);
            this.Cat_UBER.Text = "Controle Uber";
            // 
            // CAT_ADDRegistroUBER
            // 
            this.CAT_ADDRegistroUBER.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.CAT_ADDRegistroUBER.Image = ((System.Drawing.Image)(resources.GetObject("CAT_ADDRegistroUBER.Image")));
            this.CAT_ADDRegistroUBER.Name = "CAT_ADDRegistroUBER";
            this.CAT_ADDRegistroUBER.Size = new System.Drawing.Size(203, 22);
            this.CAT_ADDRegistroUBER.Text = "Adicionar Registros";
            this.CAT_ADDRegistroUBER.Click += new System.EventHandler(this.CAT_ADDRegistroUBER_Click);
            // 
            // CAT_ResultadosUBER
            // 
            this.CAT_ResultadosUBER.Image = ((System.Drawing.Image)(resources.GetObject("CAT_ResultadosUBER.Image")));
            this.CAT_ResultadosUBER.Name = "CAT_ResultadosUBER";
            this.CAT_ResultadosUBER.Size = new System.Drawing.Size(203, 22);
            this.CAT_ResultadosUBER.Text = "Exibir Registros";
            this.CAT_ResultadosUBER.Click += new System.EventHandler(this.CAT_ResultadosUBER_Click);
            // 
            // CAT_AlterarUBER
            // 
            this.CAT_AlterarUBER.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.CAT_AlterarUBER.Image = ((System.Drawing.Image)(resources.GetObject("CAT_AlterarUBER.Image")));
            this.CAT_AlterarUBER.Name = "CAT_AlterarUBER";
            this.CAT_AlterarUBER.Size = new System.Drawing.Size(203, 22);
            this.CAT_AlterarUBER.Text = "Alterar Registros";
            this.CAT_AlterarUBER.Click += new System.EventHandler(this.CAT_AlterarUBER_Click);
            // 
            // CAT_ExcluirUBER
            // 
            this.CAT_ExcluirUBER.Image = ((System.Drawing.Image)(resources.GetObject("CAT_ExcluirUBER.Image")));
            this.CAT_ExcluirUBER.Name = "CAT_ExcluirUBER";
            this.CAT_ExcluirUBER.Size = new System.Drawing.Size(203, 22);
            this.CAT_ExcluirUBER.Text = "Excluir Registros";
            this.CAT_ExcluirUBER.Click += new System.EventHandler(this.CAT_ExcluirUBER_Click);
            // 
            // controle99POPToolStripMenuItem
            // 
            this.controle99POPToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CAT_ADDRegistro99,
            this.CAT_EXIBIRRegistro99,
            this.CAT_AlterarRegistro99,
            this.CAT_ExcluirRegistro99});
            this.controle99POPToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("controle99POPToolStripMenuItem.Image")));
            this.controle99POPToolStripMenuItem.Name = "controle99POPToolStripMenuItem";
            this.controle99POPToolStripMenuItem.Size = new System.Drawing.Size(143, 21);
            this.controle99POPToolStripMenuItem.Text = "Controle 99 POP";
            // 
            // CAT_ADDRegistro99
            // 
            this.CAT_ADDRegistro99.Image = ((System.Drawing.Image)(resources.GetObject("CAT_ADDRegistro99.Image")));
            this.CAT_ADDRegistro99.Name = "CAT_ADDRegistro99";
            this.CAT_ADDRegistro99.Size = new System.Drawing.Size(203, 22);
            this.CAT_ADDRegistro99.Text = "Adicionar Registros";
            this.CAT_ADDRegistro99.Click += new System.EventHandler(this.CAT_ADDRegistro99_Click);
            // 
            // CAT_EXIBIRRegistro99
            // 
            this.CAT_EXIBIRRegistro99.Image = ((System.Drawing.Image)(resources.GetObject("CAT_EXIBIRRegistro99.Image")));
            this.CAT_EXIBIRRegistro99.Name = "CAT_EXIBIRRegistro99";
            this.CAT_EXIBIRRegistro99.Size = new System.Drawing.Size(203, 22);
            this.CAT_EXIBIRRegistro99.Text = "Exibir Rgistros";
            this.CAT_EXIBIRRegistro99.Click += new System.EventHandler(this.CAT_EXIBIRRegistro99_Click);
            // 
            // CAT_AlterarRegistro99
            // 
            this.CAT_AlterarRegistro99.Image = ((System.Drawing.Image)(resources.GetObject("CAT_AlterarRegistro99.Image")));
            this.CAT_AlterarRegistro99.Name = "CAT_AlterarRegistro99";
            this.CAT_AlterarRegistro99.Size = new System.Drawing.Size(203, 22);
            this.CAT_AlterarRegistro99.Text = "Alterar Registros";
            this.CAT_AlterarRegistro99.Click += new System.EventHandler(this.CAT_AlterarRegistro99_Click);
            // 
            // CAT_ExcluirRegistro99
            // 
            this.CAT_ExcluirRegistro99.Image = ((System.Drawing.Image)(resources.GetObject("CAT_ExcluirRegistro99.Image")));
            this.CAT_ExcluirRegistro99.Name = "CAT_ExcluirRegistro99";
            this.CAT_ExcluirRegistro99.Size = new System.Drawing.Size(203, 22);
            this.CAT_ExcluirRegistro99.Text = "Excluir Registros";
            this.CAT_ExcluirRegistro99.Click += new System.EventHandler(this.CAT_ExcluirRegistro99_Click);
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CAT_Informações});
            this.sobreToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("sobreToolStripMenuItem.Image")));
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(74, 21);
            this.sobreToolStripMenuItem.Text = "Sobre";
            // 
            // CAT_Informações
            // 
            this.CAT_Informações.Image = ((System.Drawing.Image)(resources.GetObject("CAT_Informações.Image")));
            this.CAT_Informações.Name = "CAT_Informações";
            this.CAT_Informações.Size = new System.Drawing.Size(159, 22);
            this.CAT_Informações.Text = "Informações";
            this.CAT_Informações.Click += new System.EventHandler(this.CAT_Informações_Click);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(540, 178);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 2;
            this.monthCalendar1.TitleBackColor = System.Drawing.Color.Blue;
            this.monthCalendar1.TitleForeColor = System.Drawing.Color.Azure;
            this.monthCalendar1.TrailingForeColor = System.Drawing.Color.CornflowerBlue;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(37, 190);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(310, 159);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.Color.Green;
            this.progressBar1.Location = new System.Drawing.Point(112, 452);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(600, 33);
            this.progressBar1.TabIndex = 1;
            this.progressBar1.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // Barra_Progresso
            // 
            this.Barra_Progresso.Enabled = true;
            this.Barra_Progresso.Interval = 7;
            this.Barra_Progresso.Tick += new System.EventHandler(this.Barra_Progresso_Tick);
            // 
            // Controle_de_Gastos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(785, 529);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Controle_de_Gastos";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Controle de Gastos";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem CAT_Inicio;
        private System.Windows.Forms.ToolStripMenuItem Cat_UBER;
        private System.Windows.Forms.ToolStripMenuItem controle99POPToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem btn_SAIR;
        private System.Windows.Forms.ToolStripMenuItem CAT_Informações;
        private System.Windows.Forms.ProgressBar progressBar1;
        public System.Windows.Forms.Timer Barra_Progresso;
        private System.Windows.Forms.ToolStripMenuItem CAT_ResultadosUBER;
        private System.Windows.Forms.ToolStripMenuItem CAT_ADDRegistroUBER;
        private System.Windows.Forms.ToolStripMenuItem CAT_ADD_Motoristas;
        private System.Windows.Forms.ToolStripMenuItem CAT_AlterarUBER;
        private System.Windows.Forms.ToolStripMenuItem CAT_ExcluirUBER;
        private System.Windows.Forms.ToolStripMenuItem CAT_ADDRegistro99;
        private System.Windows.Forms.ToolStripMenuItem CAT_EXIBIRRegistro99;
        private System.Windows.Forms.ToolStripMenuItem CAT_AlterarRegistro99;
        private System.Windows.Forms.ToolStripMenuItem CAT_ExcluirRegistro99;
        private System.Windows.Forms.ToolStripMenuItem CAT_Ferramentas;
        private System.Windows.Forms.ToolStripMenuItem CAT_AlcoolGasolina;
        private System.Windows.Forms.ToolStripMenuItem CAT_MetaDiaria;
    }
}