﻿
namespace Controle_de_Gastos
{
    partial class Tela_da_99
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tela_da_99));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.BtnExportar = new System.Windows.Forms.Button();
            this.btn_Buscar = new System.Windows.Forms.Button();
            this.txt_Total99 = new System.Windows.Forms.TextBox();
            this.txt_COMBUSTIVEL99 = new System.Windows.Forms.MaskedTextBox();
            this.txt_KM99 = new System.Windows.Forms.MaskedTextBox();
            this.txt_GASTOS99 = new System.Windows.Forms.MaskedTextBox();
            this.txt_GANHOS99 = new System.Windows.Forms.MaskedTextBox();
            this.txt_CORRIDAS99 = new System.Windows.Forms.ComboBox();
            this.txt_Horas99 = new System.Windows.Forms.MaskedTextBox();
            this.txt_DATA99 = new System.Windows.Forms.MaskedTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Grid99 = new System.Windows.Forms.DataGridView();
            this.cmb_Periodo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_VOLTAR = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Grid99)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnExportar
            // 
            this.BtnExportar.BackColor = System.Drawing.Color.White;
            this.BtnExportar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnExportar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExportar.Image = ((System.Drawing.Image)(resources.GetObject("BtnExportar.Image")));
            this.BtnExportar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnExportar.Location = new System.Drawing.Point(825, 445);
            this.BtnExportar.Name = "BtnExportar";
            this.BtnExportar.Size = new System.Drawing.Size(165, 44);
            this.BtnExportar.TabIndex = 124;
            this.BtnExportar.Text = "EXPORTAR";
            this.BtnExportar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnExportar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnExportar.UseVisualStyleBackColor = false;
            this.BtnExportar.Click += new System.EventHandler(this.BtnExportar_Click);
            // 
            // btn_Buscar
            // 
            this.btn_Buscar.BackColor = System.Drawing.Color.White;
            this.btn_Buscar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Buscar.BackgroundImage")));
            this.btn_Buscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Buscar.Location = new System.Drawing.Point(205, 452);
            this.btn_Buscar.Name = "btn_Buscar";
            this.btn_Buscar.Size = new System.Drawing.Size(48, 37);
            this.btn_Buscar.TabIndex = 123;
            this.btn_Buscar.UseVisualStyleBackColor = true;
            this.btn_Buscar.Click += new System.EventHandler(this.btn_Buscar_Click);
            // 
            // txt_Total99
            // 
            this.txt_Total99.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.txt_Total99.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Total99.Location = new System.Drawing.Point(181, 509);
            this.txt_Total99.Name = "txt_Total99";
            this.txt_Total99.ReadOnly = true;
            this.txt_Total99.Size = new System.Drawing.Size(234, 26);
            this.txt_Total99.TabIndex = 122;
            // 
            // txt_COMBUSTIVEL99
            // 
            this.txt_COMBUSTIVEL99.Cursor = System.Windows.Forms.Cursors.No;
            this.txt_COMBUSTIVEL99.Enabled = false;
            this.txt_COMBUSTIVEL99.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_COMBUSTIVEL99.Location = new System.Drawing.Point(479, 72);
            this.txt_COMBUSTIVEL99.Mask = "$ 999,99 ";
            this.txt_COMBUSTIVEL99.Name = "txt_COMBUSTIVEL99";
            this.txt_COMBUSTIVEL99.Size = new System.Drawing.Size(164, 29);
            this.txt_COMBUSTIVEL99.TabIndex = 121;
            this.txt_COMBUSTIVEL99.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_KM99
            // 
            this.txt_KM99.Cursor = System.Windows.Forms.Cursors.No;
            this.txt_KM99.Enabled = false;
            this.txt_KM99.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_KM99.Location = new System.Drawing.Point(181, 74);
            this.txt_KM99.Mask = "999 KM";
            this.txt_KM99.Name = "txt_KM99";
            this.txt_KM99.Size = new System.Drawing.Size(72, 26);
            this.txt_KM99.TabIndex = 120;
            // 
            // txt_GASTOS99
            // 
            this.txt_GASTOS99.Cursor = System.Windows.Forms.Cursors.No;
            this.txt_GASTOS99.Enabled = false;
            this.txt_GASTOS99.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_GASTOS99.Location = new System.Drawing.Point(780, 75);
            this.txt_GASTOS99.Name = "txt_GASTOS99";
            this.txt_GASTOS99.Size = new System.Drawing.Size(119, 26);
            this.txt_GASTOS99.TabIndex = 119;
            // 
            // txt_GANHOS99
            // 
            this.txt_GANHOS99.Cursor = System.Windows.Forms.Cursors.No;
            this.txt_GANHOS99.Enabled = false;
            this.txt_GANHOS99.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_GANHOS99.Location = new System.Drawing.Point(649, 75);
            this.txt_GANHOS99.Mask = "$ 999,99";
            this.txt_GANHOS99.Name = "txt_GANHOS99";
            this.txt_GANHOS99.Size = new System.Drawing.Size(125, 26);
            this.txt_GANHOS99.TabIndex = 118;
            // 
            // txt_CORRIDAS99
            // 
            this.txt_CORRIDAS99.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txt_CORRIDAS99.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txt_CORRIDAS99.Cursor = System.Windows.Forms.Cursors.No;
            this.txt_CORRIDAS99.Enabled = false;
            this.txt_CORRIDAS99.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_CORRIDAS99.FormattingEnabled = true;
            this.txt_CORRIDAS99.Items.AddRange(new object[] {
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
            this.txt_CORRIDAS99.Location = new System.Drawing.Point(352, 72);
            this.txt_CORRIDAS99.Name = "txt_CORRIDAS99";
            this.txt_CORRIDAS99.Size = new System.Drawing.Size(121, 28);
            this.txt_CORRIDAS99.TabIndex = 117;
            // 
            // txt_Horas99
            // 
            this.txt_Horas99.Cursor = System.Windows.Forms.Cursors.No;
            this.txt_Horas99.Enabled = false;
            this.txt_Horas99.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F);
            this.txt_Horas99.Location = new System.Drawing.Point(258, 73);
            this.txt_Horas99.Mask = "00:00";
            this.txt_Horas99.Name = "txt_Horas99";
            this.txt_Horas99.Size = new System.Drawing.Size(88, 27);
            this.txt_Horas99.TabIndex = 116;
            this.txt_Horas99.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_Horas99.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            this.txt_Horas99.ValidatingType = typeof(System.DateTime);
            // 
            // txt_DATA99
            // 
            this.txt_DATA99.Cursor = System.Windows.Forms.Cursors.No;
            this.txt_DATA99.Enabled = false;
            this.txt_DATA99.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_DATA99.Location = new System.Drawing.Point(59, 74);
            this.txt_DATA99.Mask = "00/00/0000";
            this.txt_DATA99.Name = "txt_DATA99";
            this.txt_DATA99.Size = new System.Drawing.Size(116, 26);
            this.txt_DATA99.TabIndex = 115;
            this.txt_DATA99.ValidatingType = typeof(System.DateTime);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.label10.Location = new System.Drawing.Point(59, 43);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 27);
            this.label10.TabIndex = 114;
            this.label10.Text = "DATA";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(181, 42);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 27);
            this.label9.TabIndex = 113;
            this.label9.Text = "KM";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(479, 42);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(164, 27);
            this.label8.TabIndex = 112;
            this.label8.Text = "COMBUSTÍVEL";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(780, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 27);
            this.label5.TabIndex = 111;
            this.label5.Text = "GASTOS";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(649, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 27);
            this.label4.TabIndex = 110;
            this.label4.Text = "GANHOS";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(352, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 27);
            this.label3.TabIndex = 109;
            this.label3.Text = "CORRIDAS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(258, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 27);
            this.label2.TabIndex = 108;
            this.label2.Text = "HORAS";
            // 
            // Grid99
            // 
            this.Grid99.AllowUserToResizeColumns = false;
            this.Grid99.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Grid99.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.Grid99.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.Grid99.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Grid99.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Grid99.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.Grid99.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Grid99.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Grid99.DefaultCellStyle = dataGridViewCellStyle3;
            this.Grid99.Location = new System.Drawing.Point(58, 107);
            this.Grid99.MultiSelect = false;
            this.Grid99.Name = "Grid99";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Grid99.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.Grid99.RowHeadersVisible = false;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            this.Grid99.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.Grid99.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Grid99.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Grid99.Size = new System.Drawing.Size(932, 325);
            this.Grid99.TabIndex = 107;
            this.Grid99.SelectionChanged += new System.EventHandler(this.Grid99_SelectionChanged);
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
            this.cmb_Periodo.Location = new System.Drawing.Point(58, 456);
            this.cmb_Periodo.Name = "cmb_Periodo";
            this.cmb_Periodo.Size = new System.Drawing.Size(141, 28);
            this.cmb_Periodo.TabIndex = 106;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(59, 501);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 33);
            this.label1.TabIndex = 105;
            this.label1.Text = "TOTAL";
            // 
            // btn_VOLTAR
            // 
            this.btn_VOLTAR.BackColor = System.Drawing.Color.White;
            this.btn_VOLTAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_VOLTAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.btn_VOLTAR.Image = ((System.Drawing.Image)(resources.GetObject("btn_VOLTAR.Image")));
            this.btn_VOLTAR.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btn_VOLTAR.Location = new System.Drawing.Point(805, 547);
            this.btn_VOLTAR.Name = "btn_VOLTAR";
            this.btn_VOLTAR.Size = new System.Drawing.Size(185, 57);
            this.btn_VOLTAR.TabIndex = 104;
            this.btn_VOLTAR.Text = "VOLTAR";
            this.btn_VOLTAR.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_VOLTAR.UseVisualStyleBackColor = false;
            this.btn_VOLTAR.Click += new System.EventHandler(this.btn_VOLTAR_Click);
            // 
            // Tela_da_99
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1058, 613);
            this.Controls.Add(this.BtnExportar);
            this.Controls.Add(this.btn_Buscar);
            this.Controls.Add(this.txt_Total99);
            this.Controls.Add(this.txt_COMBUSTIVEL99);
            this.Controls.Add(this.txt_KM99);
            this.Controls.Add(this.txt_GASTOS99);
            this.Controls.Add(this.txt_GANHOS99);
            this.Controls.Add(this.txt_CORRIDAS99);
            this.Controls.Add(this.txt_Horas99);
            this.Controls.Add(this.txt_DATA99);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Grid99);
            this.Controls.Add(this.cmb_Periodo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_VOLTAR);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Tela_da_99";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tela da 99";
            ((System.ComponentModel.ISupportInitialize)(this.Grid99)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnExportar;
        private System.Windows.Forms.Button btn_Buscar;
        private System.Windows.Forms.TextBox txt_Total99;
        public System.Windows.Forms.MaskedTextBox txt_COMBUSTIVEL99;
        public System.Windows.Forms.MaskedTextBox txt_KM99;
        private System.Windows.Forms.MaskedTextBox txt_GASTOS99;
        public System.Windows.Forms.MaskedTextBox txt_GANHOS99;
        public System.Windows.Forms.ComboBox txt_CORRIDAS99;
        private System.Windows.Forms.MaskedTextBox txt_Horas99;
        private System.Windows.Forms.MaskedTextBox txt_DATA99;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView Grid99;
        private System.Windows.Forms.ComboBox cmb_Periodo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_VOLTAR;
    }
}