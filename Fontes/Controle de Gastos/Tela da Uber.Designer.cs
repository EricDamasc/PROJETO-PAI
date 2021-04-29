
namespace Controle_de_Gastos
{
    partial class Tela_da_Uber
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tela_da_Uber));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_VOLTAR = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_Periodo = new System.Windows.Forms.ComboBox();
            this.GridUber = new System.Windows.Forms.DataGridView();
            this.txt_COMBUSTIVELUBER = new System.Windows.Forms.MaskedTextBox();
            this.txt_KMUBER = new System.Windows.Forms.MaskedTextBox();
            this.txt_GASTOSUBER = new System.Windows.Forms.MaskedTextBox();
            this.txt_GANHOSUBER = new System.Windows.Forms.MaskedTextBox();
            this.txt_CORRIDASUBER = new System.Windows.Forms.ComboBox();
            this.txt_HorasUber = new System.Windows.Forms.MaskedTextBox();
            this.txt_DATAUBER = new System.Windows.Forms.MaskedTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_TotalUber = new System.Windows.Forms.TextBox();
            this.btn_Buscar = new System.Windows.Forms.Button();
            this.BtnExportar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GridUber)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_VOLTAR
            // 
            this.btn_VOLTAR.BackColor = System.Drawing.Color.White;
            this.btn_VOLTAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_VOLTAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.btn_VOLTAR.Image = ((System.Drawing.Image)(resources.GetObject("btn_VOLTAR.Image")));
            this.btn_VOLTAR.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btn_VOLTAR.Location = new System.Drawing.Point(846, 566);
            this.btn_VOLTAR.Name = "btn_VOLTAR";
            this.btn_VOLTAR.Size = new System.Drawing.Size(185, 57);
            this.btn_VOLTAR.TabIndex = 79;
            this.btn_VOLTAR.Text = "VOLTAR";
            this.btn_VOLTAR.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_VOLTAR.UseVisualStyleBackColor = false;
            this.btn_VOLTAR.Click += new System.EventHandler(this.btn_VOLTAR_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(100, 520);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 33);
            this.label1.TabIndex = 80;
            this.label1.Text = "TOTAL";
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
            this.cmb_Periodo.Location = new System.Drawing.Point(99, 475);
            this.cmb_Periodo.Name = "cmb_Periodo";
            this.cmb_Periodo.Size = new System.Drawing.Size(141, 28);
            this.cmb_Periodo.TabIndex = 82;
            // 
            // GridUber
            // 
            this.GridUber.AllowUserToResizeColumns = false;
            this.GridUber.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.GridUber.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.GridUber.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.GridUber.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.GridUber.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.GridUber.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.GridUber.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.GridUber.Location = new System.Drawing.Point(99, 126);
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
            this.GridUber.TabIndex = 83;
            this.GridUber.SelectionChanged += new System.EventHandler(this.GridUber_SelectionChanged);
            // 
            // txt_COMBUSTIVELUBER
            // 
            this.txt_COMBUSTIVELUBER.Cursor = System.Windows.Forms.Cursors.No;
            this.txt_COMBUSTIVELUBER.Enabled = false;
            this.txt_COMBUSTIVELUBER.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_COMBUSTIVELUBER.Location = new System.Drawing.Point(520, 91);
            this.txt_COMBUSTIVELUBER.Mask = "$ 999,99 ";
            this.txt_COMBUSTIVELUBER.Name = "txt_COMBUSTIVELUBER";
            this.txt_COMBUSTIVELUBER.Size = new System.Drawing.Size(164, 29);
            this.txt_COMBUSTIVELUBER.TabIndex = 100;
            this.txt_COMBUSTIVELUBER.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_KMUBER
            // 
            this.txt_KMUBER.Cursor = System.Windows.Forms.Cursors.No;
            this.txt_KMUBER.Enabled = false;
            this.txt_KMUBER.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_KMUBER.Location = new System.Drawing.Point(222, 93);
            this.txt_KMUBER.Mask = "999 KM";
            this.txt_KMUBER.Name = "txt_KMUBER";
            this.txt_KMUBER.Size = new System.Drawing.Size(72, 26);
            this.txt_KMUBER.TabIndex = 99;
            // 
            // txt_GASTOSUBER
            // 
            this.txt_GASTOSUBER.Cursor = System.Windows.Forms.Cursors.No;
            this.txt_GASTOSUBER.Enabled = false;
            this.txt_GASTOSUBER.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_GASTOSUBER.Location = new System.Drawing.Point(821, 94);
            this.txt_GASTOSUBER.Name = "txt_GASTOSUBER";
            this.txt_GASTOSUBER.Size = new System.Drawing.Size(119, 26);
            this.txt_GASTOSUBER.TabIndex = 98;
            // 
            // txt_GANHOSUBER
            // 
            this.txt_GANHOSUBER.Cursor = System.Windows.Forms.Cursors.No;
            this.txt_GANHOSUBER.Enabled = false;
            this.txt_GANHOSUBER.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_GANHOSUBER.Location = new System.Drawing.Point(690, 94);
            this.txt_GANHOSUBER.Mask = "$ 999,99";
            this.txt_GANHOSUBER.Name = "txt_GANHOSUBER";
            this.txt_GANHOSUBER.Size = new System.Drawing.Size(125, 26);
            this.txt_GANHOSUBER.TabIndex = 97;
            // 
            // txt_CORRIDASUBER
            // 
            this.txt_CORRIDASUBER.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txt_CORRIDASUBER.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txt_CORRIDASUBER.Cursor = System.Windows.Forms.Cursors.No;
            this.txt_CORRIDASUBER.Enabled = false;
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
            this.txt_CORRIDASUBER.Location = new System.Drawing.Point(393, 91);
            this.txt_CORRIDASUBER.Name = "txt_CORRIDASUBER";
            this.txt_CORRIDASUBER.Size = new System.Drawing.Size(121, 28);
            this.txt_CORRIDASUBER.TabIndex = 96;
            // 
            // txt_HorasUber
            // 
            this.txt_HorasUber.Cursor = System.Windows.Forms.Cursors.No;
            this.txt_HorasUber.Enabled = false;
            this.txt_HorasUber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F);
            this.txt_HorasUber.Location = new System.Drawing.Point(299, 92);
            this.txt_HorasUber.Mask = "00:00";
            this.txt_HorasUber.Name = "txt_HorasUber";
            this.txt_HorasUber.Size = new System.Drawing.Size(88, 27);
            this.txt_HorasUber.TabIndex = 95;
            this.txt_HorasUber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_HorasUber.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            this.txt_HorasUber.ValidatingType = typeof(System.DateTime);
            // 
            // txt_DATAUBER
            // 
            this.txt_DATAUBER.Cursor = System.Windows.Forms.Cursors.No;
            this.txt_DATAUBER.Enabled = false;
            this.txt_DATAUBER.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_DATAUBER.Location = new System.Drawing.Point(100, 93);
            this.txt_DATAUBER.Mask = "00/00/0000";
            this.txt_DATAUBER.Name = "txt_DATAUBER";
            this.txt_DATAUBER.Size = new System.Drawing.Size(116, 26);
            this.txt_DATAUBER.TabIndex = 94;
            this.txt_DATAUBER.ValidatingType = typeof(System.DateTime);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.label10.Location = new System.Drawing.Point(100, 62);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 27);
            this.label10.TabIndex = 93;
            this.label10.Text = "DATA";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(222, 61);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 27);
            this.label9.TabIndex = 92;
            this.label9.Text = "KM";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(520, 61);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(164, 27);
            this.label8.TabIndex = 91;
            this.label8.Text = "COMBUSTÍVEL";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(821, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 27);
            this.label5.TabIndex = 89;
            this.label5.Text = "GASTOS";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(690, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 27);
            this.label4.TabIndex = 88;
            this.label4.Text = "GANHOS";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(393, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 27);
            this.label3.TabIndex = 87;
            this.label3.Text = "CORRIDAS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(299, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 27);
            this.label2.TabIndex = 86;
            this.label2.Text = "HORAS";
            // 
            // txt_TotalUber
            // 
            this.txt_TotalUber.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.txt_TotalUber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TotalUber.Location = new System.Drawing.Point(222, 528);
            this.txt_TotalUber.Name = "txt_TotalUber";
            this.txt_TotalUber.ReadOnly = true;
            this.txt_TotalUber.Size = new System.Drawing.Size(234, 26);
            this.txt_TotalUber.TabIndex = 101;
            // 
            // btn_Buscar
            // 
            this.btn_Buscar.BackColor = System.Drawing.Color.White;
            this.btn_Buscar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Buscar.BackgroundImage")));
            this.btn_Buscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Buscar.Location = new System.Drawing.Point(246, 471);
            this.btn_Buscar.Name = "btn_Buscar";
            this.btn_Buscar.Size = new System.Drawing.Size(48, 37);
            this.btn_Buscar.TabIndex = 102;
            this.btn_Buscar.UseVisualStyleBackColor = true;
            this.btn_Buscar.Click += new System.EventHandler(this.btn_Buscar_Click);
            // 
            // BtnExportar
            // 
            this.BtnExportar.BackColor = System.Drawing.Color.White;
            this.BtnExportar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnExportar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExportar.Image = ((System.Drawing.Image)(resources.GetObject("BtnExportar.Image")));
            this.BtnExportar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnExportar.Location = new System.Drawing.Point(866, 464);
            this.BtnExportar.Name = "BtnExportar";
            this.BtnExportar.Size = new System.Drawing.Size(165, 44);
            this.BtnExportar.TabIndex = 103;
            this.BtnExportar.Text = "EXPORTAR";
            this.BtnExportar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnExportar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnExportar.UseVisualStyleBackColor = false;
            this.BtnExportar.Click += new System.EventHandler(this.BtnExportar_Click);
            // 
            // Tela_da_Uber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1229, 682);
            this.Controls.Add(this.BtnExportar);
            this.Controls.Add(this.btn_Buscar);
            this.Controls.Add(this.txt_TotalUber);
            this.Controls.Add(this.txt_COMBUSTIVELUBER);
            this.Controls.Add(this.txt_KMUBER);
            this.Controls.Add(this.txt_GASTOSUBER);
            this.Controls.Add(this.txt_GANHOSUBER);
            this.Controls.Add(this.txt_CORRIDASUBER);
            this.Controls.Add(this.txt_HorasUber);
            this.Controls.Add(this.txt_DATAUBER);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.GridUber);
            this.Controls.Add(this.cmb_Periodo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_VOLTAR);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Tela_da_Uber";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tela da Uber";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Tela_da_Uber_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.GridUber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_VOLTAR;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_Periodo;
        private System.Windows.Forms.DataGridView GridUber;
        public System.Windows.Forms.MaskedTextBox txt_COMBUSTIVELUBER;
        public System.Windows.Forms.MaskedTextBox txt_KMUBER;
        public System.Windows.Forms.MaskedTextBox txt_GANHOSUBER;
        public System.Windows.Forms.ComboBox txt_CORRIDASUBER;
        private System.Windows.Forms.MaskedTextBox txt_HorasUber;
        private System.Windows.Forms.MaskedTextBox txt_DATAUBER;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox txt_GASTOSUBER;
        private System.Windows.Forms.TextBox txt_TotalUber;
        private System.Windows.Forms.Button btn_Buscar;
        private System.Windows.Forms.Button BtnExportar;
    }
}