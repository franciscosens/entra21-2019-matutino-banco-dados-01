namespace Exemplo01
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbCor = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.mtbPreco = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.nudAno = new System.Windows.Forms.NumericUpDown();
            this.btnSalvar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudAno)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Modelo";
            // 
            // txtModelo
            // 
            this.txtModelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtModelo.Location = new System.Drawing.Point(30, 59);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(311, 40);
            this.txtModelo.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 33);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cor";
            // 
            // cbCor
            // 
            this.cbCor.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F);
            this.cbCor.FormattingEnabled = true;
            this.cbCor.Location = new System.Drawing.Point(33, 154);
            this.cbCor.Name = "cbCor";
            this.cbCor.Size = new System.Drawing.Size(308, 41);
            this.cbCor.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 33);
            this.label3.TabIndex = 4;
            this.label3.Text = "Preço";
            // 
            // mtbPreco
            // 
            this.mtbPreco.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F);
            this.mtbPreco.Location = new System.Drawing.Point(33, 250);
            this.mtbPreco.Name = "mtbPreco";
            this.mtbPreco.Size = new System.Drawing.Size(308, 40);
            this.mtbPreco.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(27, 307);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 33);
            this.label4.TabIndex = 6;
            this.label4.Text = "Ano";
            // 
            // nudAno
            // 
            this.nudAno.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F);
            this.nudAno.Location = new System.Drawing.Point(33, 344);
            this.nudAno.Name = "nudAno";
            this.nudAno.Size = new System.Drawing.Size(308, 40);
            this.nudAno.TabIndex = 7;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F);
            this.btnSalvar.Location = new System.Drawing.Point(197, 404);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(144, 48);
            this.btnSalvar.TabIndex = 8;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 464);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.nudAno);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.mtbPreco);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbCor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtModelo);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nudAno)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbCor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox mtbPreco;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nudAno;
        private System.Windows.Forms.Button btnSalvar;
    }
}

