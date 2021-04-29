
namespace Controle_de_Gastos
{
    partial class Metas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Metas));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txt_MetaDiaria = new System.Windows.Forms.MaskedTextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.cmb_Dias = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Semana = new System.Windows.Forms.MaskedTextBox();
            this.txt_MES = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_ANO = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Previsao = new System.Windows.Forms.Label();
            this.btn_CalcularMeta = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(282, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(303, 93);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(22, 183);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(206, 41);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // txt_MetaDiaria
            // 
            this.txt_MetaDiaria.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MetaDiaria.Location = new System.Drawing.Point(237, 189);
            this.txt_MetaDiaria.Mask = "$  000.00";
            this.txt_MetaDiaria.Name = "txt_MetaDiaria";
            this.txt_MetaDiaria.PromptChar = '0';
            this.txt_MetaDiaria.Size = new System.Drawing.Size(100, 29);
            this.txt_MetaDiaria.TabIndex = 2;
            this.txt_MetaDiaria.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox3.Location = new System.Drawing.Point(17, 119);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(259, 48);
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // cmb_Dias
            // 
            this.cmb_Dias.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmb_Dias.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_Dias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmb_Dias.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Dias.FormattingEnabled = true;
            this.cmb_Dias.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.cmb_Dias.Location = new System.Drawing.Point(282, 130);
            this.cmb_Dias.Name = "cmb_Dias";
            this.cmb_Dias.Size = new System.Drawing.Size(121, 26);
            this.cmb_Dias.TabIndex = 1;
            this.cmb_Dias.Text = "DIAS";
            // 
            // label1
            // 
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Airbus Special", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 266);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "SEMANA:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_Semana
            // 
            this.txt_Semana.BackColor = System.Drawing.Color.White;
            this.txt_Semana.Cursor = System.Windows.Forms.Cursors.No;
            this.txt_Semana.Enabled = false;
            this.txt_Semana.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Semana.Location = new System.Drawing.Point(162, 266);
            this.txt_Semana.Mask = "$  0,000.00";
            this.txt_Semana.Name = "txt_Semana";
            this.txt_Semana.PromptChar = '0';
            this.txt_Semana.Size = new System.Drawing.Size(114, 29);
            this.txt_Semana.TabIndex = 6;
            // 
            // txt_MES
            // 
            this.txt_MES.BackColor = System.Drawing.Color.White;
            this.txt_MES.Cursor = System.Windows.Forms.Cursors.No;
            this.txt_MES.Enabled = false;
            this.txt_MES.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MES.Location = new System.Drawing.Point(162, 318);
            this.txt_MES.Mask = "$  0,000.00";
            this.txt_MES.Name = "txt_MES";
            this.txt_MES.PromptChar = '0';
            this.txt_MES.Size = new System.Drawing.Size(114, 29);
            this.txt_MES.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Airbus Special", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 318);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 29);
            this.label2.TabIndex = 7;
            this.label2.Text = "MÊS:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_ANO
            // 
            this.txt_ANO.Cursor = System.Windows.Forms.Cursors.No;
            this.txt_ANO.Enabled = false;
            this.txt_ANO.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ANO.Location = new System.Drawing.Point(162, 370);
            this.txt_ANO.Mask = "$  00,000.00";
            this.txt_ANO.Name = "txt_ANO";
            this.txt_ANO.PromptChar = '0';
            this.txt_ANO.Size = new System.Drawing.Size(123, 29);
            this.txt_ANO.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Airbus Special", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 370);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 29);
            this.label3.TabIndex = 9;
            this.label3.Text = "ANO:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_Previsao
            // 
            this.btn_Previsao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btn_Previsao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Previsao.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Previsao.Image = ((System.Drawing.Image)(resources.GetObject("btn_Previsao.Image")));
            this.btn_Previsao.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Previsao.Location = new System.Drawing.Point(513, 401);
            this.btn_Previsao.Name = "btn_Previsao";
            this.btn_Previsao.Size = new System.Drawing.Size(275, 40);
            this.btn_Previsao.TabIndex = 11;
            this.btn_Previsao.Text = "PREVISÃO ULTILIZANDO SUA META";
            this.btn_Previsao.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_CalcularMeta
            // 
            this.btn_CalcularMeta.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_CalcularMeta.BackColor = System.Drawing.SystemColors.Desktop;
            this.btn_CalcularMeta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CalcularMeta.Font = new System.Drawing.Font("Airbus Special", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CalcularMeta.ForeColor = System.Drawing.Color.White;
            this.btn_CalcularMeta.Image = ((System.Drawing.Image)(resources.GetObject("btn_CalcularMeta.Image")));
            this.btn_CalcularMeta.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_CalcularMeta.Location = new System.Drawing.Point(406, 303);
            this.btn_CalcularMeta.Name = "btn_CalcularMeta";
            this.btn_CalcularMeta.Size = new System.Drawing.Size(226, 55);
            this.btn_CalcularMeta.TabIndex = 4;
            this.btn_CalcularMeta.Text = "Calcular";
            this.btn_CalcularMeta.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn_CalcularMeta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_CalcularMeta.UseVisualStyleBackColor = false;
            this.btn_CalcularMeta.Click += new System.EventHandler(this.btn_CalcularMeta_Click);
            // 
            // Metas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_CalcularMeta);
            this.Controls.Add(this.btn_Previsao);
            this.Controls.Add(this.txt_ANO);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_MES);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_Semana);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmb_Dias);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.txt_MetaDiaria);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Metas";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Metas";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.MaskedTextBox txt_MetaDiaria;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.ComboBox cmb_Dias;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox txt_Semana;
        private System.Windows.Forms.MaskedTextBox txt_MES;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox txt_ANO;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label btn_Previsao;
        private System.Windows.Forms.Button btn_CalcularMeta;
    }
}