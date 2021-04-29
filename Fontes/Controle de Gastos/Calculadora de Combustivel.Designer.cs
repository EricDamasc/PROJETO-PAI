
namespace Controle_de_Gastos
{
    partial class Calculadora_de_Combustivel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calculadora_de_Combustivel));
            this.txt_Alcool = new System.Windows.Forms.MaskedTextBox();
            this.txt_Gasolina = new System.Windows.Forms.MaskedTextBox();
            this.txt_Porcentagem = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Resultado = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_Calculo_Explicacao = new System.Windows.Forms.Label();
            this.btn_CalcularCombustivel = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_CalcularCombustivel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_Alcool
            // 
            this.txt_Alcool.AccessibleRole = System.Windows.Forms.AccessibleRole.Grip;
            this.txt_Alcool.BeepOnError = true;
            this.txt_Alcool.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            this.txt_Alcool.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Alcool.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Overwrite;
            this.txt_Alcool.Location = new System.Drawing.Point(251, 155);
            this.txt_Alcool.Mask = "$ 0,00";
            this.txt_Alcool.Name = "txt_Alcool";
            this.txt_Alcool.PromptChar = '0';
            this.txt_Alcool.RejectInputOnFirstFailure = true;
            this.txt_Alcool.Size = new System.Drawing.Size(121, 31);
            this.txt_Alcool.SkipLiterals = false;
            this.txt_Alcool.TabIndex = 1;
            this.txt_Alcool.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Alcool_KeyDown);
            // 
            // txt_Gasolina
            // 
            this.txt_Gasolina.BeepOnError = true;
            this.txt_Gasolina.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            this.txt_Gasolina.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Gasolina.Location = new System.Drawing.Point(251, 208);
            this.txt_Gasolina.Mask = "$ 0,00";
            this.txt_Gasolina.Name = "txt_Gasolina";
            this.txt_Gasolina.PromptChar = '0';
            this.txt_Gasolina.RejectInputOnFirstFailure = true;
            this.txt_Gasolina.Size = new System.Drawing.Size(121, 31);
            this.txt_Gasolina.TabIndex = 2;
            this.txt_Gasolina.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Gasolina_KeyDown);
            // 
            // txt_Porcentagem
            // 
            this.txt_Porcentagem.BackColor = System.Drawing.Color.White;
            this.txt_Porcentagem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Porcentagem.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            this.txt_Porcentagem.Enabled = false;
            this.txt_Porcentagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Porcentagem.Location = new System.Drawing.Point(224, 324);
            this.txt_Porcentagem.Mask = "0,00 %";
            this.txt_Porcentagem.Name = "txt_Porcentagem";
            this.txt_Porcentagem.PromptChar = '0';
            this.txt_Porcentagem.Size = new System.Drawing.Size(66, 29);
            this.txt_Porcentagem.SkipLiterals = false;
            this.txt_Porcentagem.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Dubai", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(95, 322);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 35);
            this.label3.TabIndex = 5;
            this.label3.Text = "Resultado:";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Dubai", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(416, 322);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(159, 35);
            this.label4.TabIndex = 6;
            this.label4.Text = "Melhor opção é:";
            // 
            // txt_Resultado
            // 
            this.txt_Resultado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Resultado.Enabled = false;
            this.txt_Resultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Resultado.Location = new System.Drawing.Point(581, 322);
            this.txt_Resultado.Multiline = true;
            this.txt_Resultado.Name = "txt_Resultado";
            this.txt_Resultado.ReadOnly = true;
            this.txt_Resultado.Size = new System.Drawing.Size(190, 35);
            this.txt_Resultado.TabIndex = 7;
            this.txt_Resultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(90, -41);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(727, 197);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // btn_Calculo_Explicacao
            // 
            this.btn_Calculo_Explicacao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btn_Calculo_Explicacao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Calculo_Explicacao.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Calculo_Explicacao.Image = ((System.Drawing.Image)(resources.GetObject("btn_Calculo_Explicacao.Image")));
            this.btn_Calculo_Explicacao.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Calculo_Explicacao.Location = new System.Drawing.Point(615, 432);
            this.btn_Calculo_Explicacao.Name = "btn_Calculo_Explicacao";
            this.btn_Calculo_Explicacao.Size = new System.Drawing.Size(236, 40);
            this.btn_Calculo_Explicacao.TabIndex = 9;
            this.btn_Calculo_Explicacao.Text = "COMO É FEITO O CÁLCULO?";
            this.btn_Calculo_Explicacao.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Calculo_Explicacao.Click += new System.EventHandler(this.btn_Calculo_Explicacao_Click);
            // 
            // btn_CalcularCombustivel
            // 
            this.btn_CalcularCombustivel.BackColor = System.Drawing.Color.Transparent;
            this.btn_CalcularCombustivel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_CalcularCombustivel.BackgroundImage")));
            this.btn_CalcularCombustivel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_CalcularCombustivel.Location = new System.Drawing.Point(435, 135);
            this.btn_CalcularCombustivel.Name = "btn_CalcularCombustivel";
            this.btn_CalcularCombustivel.Size = new System.Drawing.Size(344, 124);
            this.btn_CalcularCombustivel.TabIndex = 10;
            this.btn_CalcularCombustivel.TabStop = false;
            this.btn_CalcularCombustivel.Click += new System.EventHandler(this.btn_CalcularCombustivel_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox2.Location = new System.Drawing.Point(65, 148);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(180, 40);
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox3.Location = new System.Drawing.Point(54, 201);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(191, 40);
            this.pictureBox3.TabIndex = 12;
            this.pictureBox3.TabStop = false;
            // 
            // Calculadora_de_Combustivel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(859, 476);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btn_CalcularCombustivel);
            this.Controls.Add(this.btn_Calculo_Explicacao);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txt_Resultado);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_Porcentagem);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_Gasolina);
            this.Controls.Add(this.txt_Alcool);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Calculadora_de_Combustivel";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora de Combustível";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_CalcularCombustivel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MaskedTextBox txt_Alcool;
        private System.Windows.Forms.MaskedTextBox txt_Gasolina;
        private System.Windows.Forms.MaskedTextBox txt_Porcentagem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_Resultado;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label btn_Calculo_Explicacao;
        private System.Windows.Forms.PictureBox btn_CalcularCombustivel;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}