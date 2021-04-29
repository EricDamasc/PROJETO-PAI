
namespace Controle_de_Gastos
{
    partial class Controle_99
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Controle_99));
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
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_OBS99 = new System.Windows.Forms.RichTextBox();
            this.btn_VOLTAR = new System.Windows.Forms.Button();
            this.btn_Confirmar99 = new System.Windows.Forms.Button();
            this.btn_LimparCampos99 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cx_DATA99 = new System.Windows.Forms.ToolTip(this.components);
            this.cx_HORAS99 = new System.Windows.Forms.ToolTip(this.components);
            this.cx_Combustivel99 = new System.Windows.Forms.ToolTip(this.components);
            this.cx_KM99 = new System.Windows.Forms.ToolTip(this.components);
            this.cx_Ganhos99 = new System.Windows.Forms.ToolTip(this.components);
            this.cx_Gastos99 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_COMBUSTIVEL99
            // 
            this.txt_COMBUSTIVEL99.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_COMBUSTIVEL99.Location = new System.Drawing.Point(857, 292);
            this.txt_COMBUSTIVEL99.Mask = "$ 999,99";
            this.txt_COMBUSTIVEL99.Name = "txt_COMBUSTIVEL99";
            this.txt_COMBUSTIVEL99.Size = new System.Drawing.Size(171, 26);
            this.txt_COMBUSTIVEL99.TabIndex = 6;
            this.cx_Combustivel99.SetToolTip(this.txt_COMBUSTIVEL99, "Ex: R$ 249,50 ou _89,59");
            // 
            // txt_KM99
            // 
            this.txt_KM99.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_KM99.Location = new System.Drawing.Point(857, 209);
            this.txt_KM99.Mask = "999 KM";
            this.txt_KM99.Name = "txt_KM99";
            this.txt_KM99.Size = new System.Drawing.Size(155, 26);
            this.txt_KM99.TabIndex = 5;
            this.cx_KM99.SetToolTip(this.txt_KM99, "Ex: 345 KM ou _98 KM");
            // 
            // txt_GASTOS99
            // 
            this.txt_GASTOS99.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_GASTOS99.Location = new System.Drawing.Point(857, 361);
            this.txt_GASTOS99.Name = "txt_GASTOS99";
            this.txt_GASTOS99.Size = new System.Drawing.Size(119, 26);
            this.txt_GASTOS99.TabIndex = 7;
            this.cx_Gastos99.SetToolTip(this.txt_GASTOS99, "Digite ultilizando a pontuação corretamente EX: 1.560,59 OU 841,99");
            // 
            // txt_GANHOS99
            // 
            this.txt_GANHOS99.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_GANHOS99.Location = new System.Drawing.Point(569, 444);
            this.txt_GANHOS99.Mask = "$ 999,99";
            this.txt_GANHOS99.Name = "txt_GANHOS99";
            this.txt_GANHOS99.Size = new System.Drawing.Size(125, 26);
            this.txt_GANHOS99.TabIndex = 4;
            this.cx_Ganhos99.SetToolTip(this.txt_GANHOS99, "Ex: R$ 459,99 ou _89,59");
            // 
            // txt_CORRIDAS99
            // 
            this.txt_CORRIDAS99.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txt_CORRIDAS99.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
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
            this.txt_CORRIDAS99.Location = new System.Drawing.Point(569, 361);
            this.txt_CORRIDAS99.Name = "txt_CORRIDAS99";
            this.txt_CORRIDAS99.Size = new System.Drawing.Size(121, 28);
            this.txt_CORRIDAS99.TabIndex = 3;
            // 
            // txt_Horas99
            // 
            this.txt_Horas99.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F);
            this.txt_Horas99.Location = new System.Drawing.Point(569, 287);
            this.txt_Horas99.Mask = "00:00";
            this.txt_Horas99.Name = "txt_Horas99";
            this.txt_Horas99.Size = new System.Drawing.Size(125, 27);
            this.txt_Horas99.TabIndex = 2;
            this.cx_HORAS99.SetToolTip(this.txt_Horas99, "12:59");
            this.txt_Horas99.ValidatingType = typeof(System.DateTime);
            // 
            // txt_DATA99
            // 
            this.txt_DATA99.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_DATA99.Location = new System.Drawing.Point(569, 207);
            this.txt_DATA99.Mask = "00/00/0000";
            this.txt_DATA99.Name = "txt_DATA99";
            this.txt_DATA99.Size = new System.Drawing.Size(116, 26);
            this.txt_DATA99.TabIndex = 1;
            this.cx_DATA99.SetToolTip(this.txt_DATA99, "Ex: 30/12/2021");
            this.txt_DATA99.ValidatingType = typeof(System.DateTime);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.label10.Location = new System.Drawing.Point(569, 176);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 27);
            this.label10.TabIndex = 55;
            this.label10.Text = "DATA";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(857, 177);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 27);
            this.label9.TabIndex = 54;
            this.label9.Text = "KM";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(857, 254);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(164, 27);
            this.label8.TabIndex = 53;
            this.label8.Text = "COMBUSTÍVEL";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(857, 412);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(174, 27);
            this.label6.TabIndex = 52;
            this.label6.Text = "OBSERVAÇÕES";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(857, 329);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 27);
            this.label5.TabIndex = 51;
            this.label5.Text = "GASTOS";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(569, 412);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 27);
            this.label4.TabIndex = 50;
            this.label4.Text = "GANHOS";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(569, 331);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 27);
            this.label3.TabIndex = 49;
            this.label3.Text = "CORRIDAS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(569, 255);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 27);
            this.label2.TabIndex = 48;
            this.label2.Text = "HORAS";
            // 
            // txt_OBS99
            // 
            this.txt_OBS99.Location = new System.Drawing.Point(857, 444);
            this.txt_OBS99.Name = "txt_OBS99";
            this.txt_OBS99.Size = new System.Drawing.Size(260, 68);
            this.txt_OBS99.TabIndex = 8;
            this.txt_OBS99.Text = "";
            // 
            // btn_VOLTAR
            // 
            this.btn_VOLTAR.BackColor = System.Drawing.Color.White;
            this.btn_VOLTAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_VOLTAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.btn_VOLTAR.Image = ((System.Drawing.Image)(resources.GetObject("btn_VOLTAR.Image")));
            this.btn_VOLTAR.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btn_VOLTAR.Location = new System.Drawing.Point(980, 589);
            this.btn_VOLTAR.Name = "btn_VOLTAR";
            this.btn_VOLTAR.Size = new System.Drawing.Size(171, 57);
            this.btn_VOLTAR.TabIndex = 80;
            this.btn_VOLTAR.Text = "VOLTAR";
            this.btn_VOLTAR.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_VOLTAR.UseVisualStyleBackColor = false;
            this.btn_VOLTAR.Click += new System.EventHandler(this.btn_VOLTAR_Click);
            // 
            // btn_Confirmar99
            // 
            this.btn_Confirmar99.BackColor = System.Drawing.Color.White;
            this.btn_Confirmar99.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Confirmar99.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.btn_Confirmar99.Image = ((System.Drawing.Image)(resources.GetObject("btn_Confirmar99.Image")));
            this.btn_Confirmar99.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btn_Confirmar99.Location = new System.Drawing.Point(553, 589);
            this.btn_Confirmar99.Name = "btn_Confirmar99";
            this.btn_Confirmar99.Size = new System.Drawing.Size(204, 57);
            this.btn_Confirmar99.TabIndex = 9;
            this.btn_Confirmar99.Text = "CONFIRMAR";
            this.btn_Confirmar99.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Confirmar99.UseVisualStyleBackColor = false;
            this.btn_Confirmar99.Click += new System.EventHandler(this.btn_Confirmar99_Click);
            // 
            // btn_LimparCampos99
            // 
            this.btn_LimparCampos99.BackColor = System.Drawing.Color.White;
            this.btn_LimparCampos99.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_LimparCampos99.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_LimparCampos99.Image = ((System.Drawing.Image)(resources.GetObject("btn_LimparCampos99.Image")));
            this.btn_LimparCampos99.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btn_LimparCampos99.Location = new System.Drawing.Point(772, 589);
            this.btn_LimparCampos99.Name = "btn_LimparCampos99";
            this.btn_LimparCampos99.Size = new System.Drawing.Size(202, 57);
            this.btn_LimparCampos99.TabIndex = 82;
            this.btn_LimparCampos99.Text = "LIMPAR CAMPOS";
            this.btn_LimparCampos99.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_LimparCampos99.UseVisualStyleBackColor = false;
            this.btn_LimparCampos99.Click += new System.EventHandler(this.btn_LimparCampos99_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(553, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(451, 166);
            this.pictureBox1.TabIndex = 83;
            this.pictureBox1.TabStop = false;
            // 
            // cx_DATA99
            // 
            this.cx_DATA99.AutomaticDelay = 700;
            this.cx_DATA99.AutoPopDelay = 7000;
            this.cx_DATA99.InitialDelay = 0;
            this.cx_DATA99.IsBalloon = true;
            this.cx_DATA99.ReshowDelay = 0;
            this.cx_DATA99.ShowAlways = true;
            this.cx_DATA99.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.cx_DATA99.ToolTipTitle = "SIGA O EXEMPLO";
            // 
            // cx_HORAS99
            // 
            this.cx_HORAS99.AutomaticDelay = 700;
            this.cx_HORAS99.AutoPopDelay = 7000;
            this.cx_HORAS99.InitialDelay = 0;
            this.cx_HORAS99.IsBalloon = true;
            this.cx_HORAS99.ReshowDelay = 0;
            this.cx_HORAS99.ShowAlways = true;
            this.cx_HORAS99.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.cx_HORAS99.ToolTipTitle = "SIGA A INSTRUÇÃO";
            // 
            // cx_Combustivel99
            // 
            this.cx_Combustivel99.AutomaticDelay = 900;
            this.cx_Combustivel99.AutoPopDelay = 1100;
            this.cx_Combustivel99.InitialDelay = 0;
            this.cx_Combustivel99.IsBalloon = true;
            this.cx_Combustivel99.ReshowDelay = 0;
            this.cx_Combustivel99.ShowAlways = true;
            this.cx_Combustivel99.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.cx_Combustivel99.ToolTipTitle = "SIGA AS INSTRUÇÕES";
            // 
            // cx_KM99
            // 
            this.cx_KM99.AutomaticDelay = 950;
            this.cx_KM99.AutoPopDelay = 9500;
            this.cx_KM99.InitialDelay = 0;
            this.cx_KM99.IsBalloon = true;
            this.cx_KM99.ReshowDelay = 0;
            this.cx_KM99.ShowAlways = true;
            this.cx_KM99.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.cx_KM99.ToolTipTitle = "SIGA AS INSTRUÇÕES";
            // 
            // cx_Ganhos99
            // 
            this.cx_Ganhos99.AutoPopDelay = 5000;
            this.cx_Ganhos99.InitialDelay = 0;
            this.cx_Ganhos99.IsBalloon = true;
            this.cx_Ganhos99.ReshowDelay = 0;
            this.cx_Ganhos99.ShowAlways = true;
            this.cx_Ganhos99.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Warning;
            this.cx_Ganhos99.ToolTipTitle = "SIGA AS INSTRUÇÕES";
            // 
            // cx_Gastos99
            // 
            this.cx_Gastos99.AutoPopDelay = 10000;
            this.cx_Gastos99.InitialDelay = 0;
            this.cx_Gastos99.IsBalloon = true;
            this.cx_Gastos99.ReshowDelay = 0;
            this.cx_Gastos99.ShowAlways = true;
            this.cx_Gastos99.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Warning;
            this.cx_Gastos99.ToolTipTitle = "SIGA AS INSTRUÇÕES";
            // 
            // Controle_99
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1163, 674);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_LimparCampos99);
            this.Controls.Add(this.btn_Confirmar99);
            this.Controls.Add(this.btn_VOLTAR);
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
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_OBS99);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Controle_99";
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Controle 99";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox txt_COMBUSTIVEL99;
        public System.Windows.Forms.MaskedTextBox txt_KM99;
        public System.Windows.Forms.MaskedTextBox txt_GASTOS99;
        public System.Windows.Forms.MaskedTextBox txt_GANHOS99;
        public System.Windows.Forms.ComboBox txt_CORRIDAS99;
        private System.Windows.Forms.MaskedTextBox txt_Horas99;
        private System.Windows.Forms.MaskedTextBox txt_DATA99;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox txt_OBS99;
        private System.Windows.Forms.Button btn_VOLTAR;
        private System.Windows.Forms.Button btn_Confirmar99;
        private System.Windows.Forms.Button btn_LimparCampos99;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolTip cx_DATA99;
        private System.Windows.Forms.ToolTip cx_HORAS99;
        private System.Windows.Forms.ToolTip cx_Combustivel99;
        private System.Windows.Forms.ToolTip cx_KM99;
        private System.Windows.Forms.ToolTip cx_Ganhos99;
        private System.Windows.Forms.ToolTip cx_Gastos99;
    }
}