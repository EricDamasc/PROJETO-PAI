
namespace Controle_de_Gastos
{
    partial class Alterar_Registro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Alterar_Registro));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_Buscar = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.GridUber = new System.Windows.Forms.DataGridView();
            this.cmb_Periodo = new System.Windows.Forms.ComboBox();
            this.btn_VOLTAR = new System.Windows.Forms.Button();
            this.txt_ID = new System.Windows.Forms.TextBox();
            this.btn_AlterarRegistro = new System.Windows.Forms.Button();
            this.txt_COMBUSTIVELUBER = new System.Windows.Forms.MaskedTextBox();
            this.txt_KMUBER = new System.Windows.Forms.MaskedTextBox();
            this.txt_GASTOSUBER = new System.Windows.Forms.MaskedTextBox();
            this.txt_GANHOSUBER = new System.Windows.Forms.MaskedTextBox();
            this.txt_CORRIDASUBER = new System.Windows.Forms.ComboBox();
            this.txt_HorasUber = new System.Windows.Forms.MaskedTextBox();
            this.txt_DATAUBER = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_OBSUBER = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.GridUber)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Buscar
            // 
            this.btn_Buscar.BackColor = System.Drawing.Color.White;
            this.btn_Buscar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Buscar.BackgroundImage")));
            this.btn_Buscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Buscar.Location = new System.Drawing.Point(190, 430);
            this.btn_Buscar.Name = "btn_Buscar";
            this.btn_Buscar.Size = new System.Drawing.Size(48, 37);
            this.btn_Buscar.TabIndex = 123;
            this.btn_Buscar.UseVisualStyleBackColor = true;
            this.btn_Buscar.Click += new System.EventHandler(this.btn_Buscar_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.label10.Location = new System.Drawing.Point(27, 15);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 27);
            this.label10.TabIndex = 114;
            this.label10.Text = "ID ";
            // 
            // GridUber
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.GridUber.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.GridUber.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.GridUber.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.GridUber.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.GridUber.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.GridUber.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridUber.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GridUber.DefaultCellStyle = dataGridViewCellStyle3;
            this.GridUber.Location = new System.Drawing.Point(51, 85);
            this.GridUber.MultiSelect = false;
            this.GridUber.Name = "GridUber";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridUber.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.GridUber.RowHeadersVisible = false;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            this.GridUber.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.GridUber.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.GridUber.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridUber.Size = new System.Drawing.Size(932, 325);
            this.GridUber.TabIndex = 107;
            this.GridUber.SelectionChanged += new System.EventHandler(this.GridUber_SelectionChanged);
            // 
            // cmb_Periodo
            // 
            this.cmb_Periodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Periodo.FormattingEnabled = true;
            this.cmb_Periodo.Items.AddRange(new object[] {
            "DATA",
            "CORRIDAS",
            "COMBUSTIVEL",
            "GASTOS"});
            this.cmb_Periodo.Location = new System.Drawing.Point(43, 434);
            this.cmb_Periodo.Name = "cmb_Periodo";
            this.cmb_Periodo.Size = new System.Drawing.Size(141, 28);
            this.cmb_Periodo.TabIndex = 106;
            // 
            // btn_VOLTAR
            // 
            this.btn_VOLTAR.BackColor = System.Drawing.Color.White;
            this.btn_VOLTAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_VOLTAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.btn_VOLTAR.Image = ((System.Drawing.Image)(resources.GetObject("btn_VOLTAR.Image")));
            this.btn_VOLTAR.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btn_VOLTAR.Location = new System.Drawing.Point(673, 430);
            this.btn_VOLTAR.Name = "btn_VOLTAR";
            this.btn_VOLTAR.Size = new System.Drawing.Size(185, 57);
            this.btn_VOLTAR.TabIndex = 104;
            this.btn_VOLTAR.Text = "VOLTAR";
            this.btn_VOLTAR.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_VOLTAR.UseVisualStyleBackColor = false;
            this.btn_VOLTAR.Click += new System.EventHandler(this.btn_VOLTAR_Click);
            // 
            // txt_ID
            // 
            this.txt_ID.Enabled = false;
            this.txt_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ID.Location = new System.Drawing.Point(27, 47);
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.Size = new System.Drawing.Size(40, 26);
            this.txt_ID.TabIndex = 125;
            // 
            // btn_AlterarRegistro
            // 
            this.btn_AlterarRegistro.BackColor = System.Drawing.Color.White;
            this.btn_AlterarRegistro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AlterarRegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.btn_AlterarRegistro.Image = ((System.Drawing.Image)(resources.GetObject("btn_AlterarRegistro.Image")));
            this.btn_AlterarRegistro.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btn_AlterarRegistro.Location = new System.Drawing.Point(322, 430);
            this.btn_AlterarRegistro.Name = "btn_AlterarRegistro";
            this.btn_AlterarRegistro.Size = new System.Drawing.Size(185, 57);
            this.btn_AlterarRegistro.TabIndex = 126;
            this.btn_AlterarRegistro.Text = "ALTERAR";
            this.btn_AlterarRegistro.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_AlterarRegistro.UseVisualStyleBackColor = false;
            this.btn_AlterarRegistro.Click += new System.EventHandler(this.btn_AlterarRegistro_Click_1);
            // 
            // txt_COMBUSTIVELUBER
            // 
            this.txt_COMBUSTIVELUBER.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_COMBUSTIVELUBER.Location = new System.Drawing.Point(455, 45);
            this.txt_COMBUSTIVELUBER.Mask = "$ 999,99 ";
            this.txt_COMBUSTIVELUBER.Name = "txt_COMBUSTIVELUBER";
            this.txt_COMBUSTIVELUBER.Size = new System.Drawing.Size(127, 29);
            this.txt_COMBUSTIVELUBER.TabIndex = 140;
            this.txt_COMBUSTIVELUBER.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_KMUBER
            // 
            this.txt_KMUBER.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_KMUBER.Location = new System.Drawing.Point(165, 46);
            this.txt_KMUBER.Mask = "999 KM";
            this.txt_KMUBER.Name = "txt_KMUBER";
            this.txt_KMUBER.Size = new System.Drawing.Size(60, 26);
            this.txt_KMUBER.TabIndex = 139;
            // 
            // txt_GASTOSUBER
            // 
            this.txt_GASTOSUBER.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_GASTOSUBER.Location = new System.Drawing.Point(735, 48);
            this.txt_GASTOSUBER.Name = "txt_GASTOSUBER";
            this.txt_GASTOSUBER.Size = new System.Drawing.Size(119, 26);
            this.txt_GASTOSUBER.TabIndex = 138;
            // 
            // txt_GANHOSUBER
            // 
            this.txt_GANHOSUBER.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_GANHOSUBER.Location = new System.Drawing.Point(625, 48);
            this.txt_GANHOSUBER.Mask = "$ 999,99";
            this.txt_GANHOSUBER.Name = "txt_GANHOSUBER";
            this.txt_GANHOSUBER.Size = new System.Drawing.Size(104, 26);
            this.txt_GANHOSUBER.TabIndex = 137;
            // 
            // txt_CORRIDASUBER
            // 
            this.txt_CORRIDASUBER.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txt_CORRIDASUBER.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txt_CORRIDASUBER.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_CORRIDASUBER.FormattingEnabled = true;
            this.txt_CORRIDASUBER.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40"});
            this.txt_CORRIDASUBER.Location = new System.Drawing.Point(328, 45);
            this.txt_CORRIDASUBER.Name = "txt_CORRIDASUBER";
            this.txt_CORRIDASUBER.Size = new System.Drawing.Size(121, 28);
            this.txt_CORRIDASUBER.TabIndex = 136;
            // 
            // txt_HorasUber
            // 
            this.txt_HorasUber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F);
            this.txt_HorasUber.Location = new System.Drawing.Point(234, 46);
            this.txt_HorasUber.Mask = "00:00";
            this.txt_HorasUber.Name = "txt_HorasUber";
            this.txt_HorasUber.Size = new System.Drawing.Size(88, 27);
            this.txt_HorasUber.TabIndex = 135;
            this.txt_HorasUber.ValidatingType = typeof(System.DateTime);
            // 
            // txt_DATAUBER
            // 
            this.txt_DATAUBER.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_DATAUBER.Location = new System.Drawing.Point(76, 46);
            this.txt_DATAUBER.Mask = "00/00/0000";
            this.txt_DATAUBER.Name = "txt_DATAUBER";
            this.txt_DATAUBER.Size = new System.Drawing.Size(85, 26);
            this.txt_DATAUBER.TabIndex = 134;
            this.txt_DATAUBER.ValidatingType = typeof(System.DateTime);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.label1.Location = new System.Drawing.Point(76, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 27);
            this.label1.TabIndex = 133;
            this.label1.Text = "DATA";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(165, 14);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 27);
            this.label9.TabIndex = 132;
            this.label9.Text = "KM";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(455, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(164, 27);
            this.label8.TabIndex = 131;
            this.label8.Text = "COMBUSTÍVEL";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(735, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 27);
            this.label5.TabIndex = 130;
            this.label5.Text = "GASTOS";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(625, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 27);
            this.label4.TabIndex = 129;
            this.label4.Text = "GANHOS";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(328, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 27);
            this.label3.TabIndex = 128;
            this.label3.Text = "CORRIDAS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(234, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 27);
            this.label2.TabIndex = 127;
            this.label2.Text = "HORAS";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(860, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(174, 27);
            this.label6.TabIndex = 142;
            this.label6.Text = "OBSERVAÇÕES";
            // 
            // txt_OBSUBER
            // 
            this.txt_OBSUBER.Location = new System.Drawing.Point(860, 45);
            this.txt_OBSUBER.Name = "txt_OBSUBER";
            this.txt_OBSUBER.Size = new System.Drawing.Size(260, 34);
            this.txt_OBSUBER.TabIndex = 141;
            this.txt_OBSUBER.Text = "";
            // 
            // Alterar_Registro
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1165, 515);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_OBSUBER);
            this.Controls.Add(this.txt_COMBUSTIVELUBER);
            this.Controls.Add(this.txt_KMUBER);
            this.Controls.Add(this.txt_GASTOSUBER);
            this.Controls.Add(this.txt_GANHOSUBER);
            this.Controls.Add(this.txt_CORRIDASUBER);
            this.Controls.Add(this.txt_HorasUber);
            this.Controls.Add(this.txt_DATAUBER);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_AlterarRegistro);
            this.Controls.Add(this.txt_ID);
            this.Controls.Add(this.btn_Buscar);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.GridUber);
            this.Controls.Add(this.cmb_Periodo);
            this.Controls.Add(this.btn_VOLTAR);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Alterar_Registro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alterar Registro";
            ((System.ComponentModel.ISupportInitialize)(this.GridUber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_Buscar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView GridUber;
        private System.Windows.Forms.ComboBox cmb_Periodo;
        private System.Windows.Forms.Button btn_VOLTAR;
        private System.Windows.Forms.TextBox txt_ID;
        private System.Windows.Forms.Button btn_AlterarRegistro;
        public System.Windows.Forms.MaskedTextBox txt_COMBUSTIVELUBER;
        public System.Windows.Forms.MaskedTextBox txt_KMUBER;
        private System.Windows.Forms.MaskedTextBox txt_GASTOSUBER;
        public System.Windows.Forms.MaskedTextBox txt_GANHOSUBER;
        public System.Windows.Forms.ComboBox txt_CORRIDASUBER;
        private System.Windows.Forms.MaskedTextBox txt_HorasUber;
        private System.Windows.Forms.MaskedTextBox txt_DATAUBER;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox txt_OBSUBER;
    }
}