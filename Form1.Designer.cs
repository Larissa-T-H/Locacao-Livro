namespace WF_Aula63_Exer2_Locacao
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
            this.lblCliente = new System.Windows.Forms.Label();
            this.lblLivro = new System.Windows.Forms.Label();
            this.cmbCliente = new System.Windows.Forms.ComboBox();
            this.cmbLivros = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblDataLocacao = new System.Windows.Forms.Label();
            this.txtBoxLocacao = new System.Windows.Forms.TextBox();
            this.lblDataDevolucao = new System.Windows.Forms.Label();
            this.txtBoxDevolucao = new System.Windows.Forms.TextBox();
            this.lblPrazo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblValor = new System.Windows.Forms.Label();
            this.lblvalorLivro = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblMulta = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.Location = new System.Drawing.Point(64, 48);
            this.lblCliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(69, 23);
            this.lblCliente.TabIndex = 0;
            this.lblCliente.Text = "Cliente";
            // 
            // lblLivro
            // 
            this.lblLivro.AutoSize = true;
            this.lblLivro.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLivro.Location = new System.Drawing.Point(69, 151);
            this.lblLivro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLivro.Name = "lblLivro";
            this.lblLivro.Size = new System.Drawing.Size(59, 23);
            this.lblLivro.TabIndex = 1;
            this.lblLivro.Text = "Livros";
            // 
            // cmbCliente
            // 
            this.cmbCliente.FormattingEnabled = true;
            this.cmbCliente.Location = new System.Drawing.Point(73, 84);
            this.cmbCliente.Name = "cmbCliente";
            this.cmbCliente.Size = new System.Drawing.Size(262, 29);
            this.cmbCliente.TabIndex = 2;
            // 
            // cmbLivros
            // 
            this.cmbLivros.FormattingEnabled = true;
            this.cmbLivros.Location = new System.Drawing.Point(73, 178);
            this.cmbLivros.Name = "cmbLivros";
            this.cmbLivros.Size = new System.Drawing.Size(262, 29);
            this.cmbLivros.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(130, 545);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(195, 43);
            this.button1.TabIndex = 4;
            this.button1.Text = "Enviar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblDataLocacao
            // 
            this.lblDataLocacao.AutoSize = true;
            this.lblDataLocacao.Location = new System.Drawing.Point(69, 235);
            this.lblDataLocacao.Name = "lblDataLocacao";
            this.lblDataLocacao.Size = new System.Drawing.Size(123, 21);
            this.lblDataLocacao.TabIndex = 5;
            this.lblDataLocacao.Text = "Data da Locação";
            // 
            // txtBoxLocacao
            // 
            this.txtBoxLocacao.Location = new System.Drawing.Point(73, 260);
            this.txtBoxLocacao.Name = "txtBoxLocacao";
            this.txtBoxLocacao.Size = new System.Drawing.Size(142, 28);
            this.txtBoxLocacao.TabIndex = 6;
            // 
            // lblDataDevolucao
            // 
            this.lblDataDevolucao.AutoSize = true;
            this.lblDataDevolucao.Location = new System.Drawing.Point(236, 235);
            this.lblDataDevolucao.Name = "lblDataDevolucao";
            this.lblDataDevolucao.Size = new System.Drawing.Size(140, 21);
            this.lblDataDevolucao.TabIndex = 7;
            this.lblDataDevolucao.Text = "Data da Devolução";
            // 
            // txtBoxDevolucao
            // 
            this.txtBoxDevolucao.Location = new System.Drawing.Point(240, 260);
            this.txtBoxDevolucao.Name = "txtBoxDevolucao";
            this.txtBoxDevolucao.Size = new System.Drawing.Size(146, 28);
            this.txtBoxDevolucao.TabIndex = 8;
            // 
            // lblPrazo
            // 
            this.lblPrazo.AutoSize = true;
            this.lblPrazo.Location = new System.Drawing.Point(69, 312);
            this.lblPrazo.Name = "lblPrazo";
            this.lblPrazo.Size = new System.Drawing.Size(237, 21);
            this.lblPrazo.TabIndex = 9;
            this.lblPrazo.Text = "Prazo para devolução é de 5 dias";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(206, 362);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 21);
            this.label1.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 362);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 21);
            this.label2.TabIndex = 11;
            this.label2.Text = "Tempo de Locação:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(218, 362);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 21);
            this.label3.TabIndex = 12;
            this.label3.Text = "Dias";
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(64, 399);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(134, 21);
            this.lblValor.TabIndex = 13;
            this.lblValor.Text = "Valor do Livro: R$";
            // 
            // lblvalorLivro
            // 
            this.lblvalorLivro.AutoSize = true;
            this.lblvalorLivro.Location = new System.Drawing.Point(194, 399);
            this.lblvalorLivro.Name = "lblvalorLivro";
            this.lblvalorLivro.Size = new System.Drawing.Size(0, 21);
            this.lblvalorLivro.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(68, 437);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 21);
            this.label4.TabIndex = 15;
            this.label4.Text = "Multa: R$";
            // 
            // lblMulta
            // 
            this.lblMulta.AutoSize = true;
            this.lblMulta.Location = new System.Drawing.Point(142, 437);
            this.lblMulta.Name = "lblMulta";
            this.lblMulta.Size = new System.Drawing.Size(0, 21);
            this.lblMulta.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(69, 478);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 21);
            this.label6.TabIndex = 17;
            this.label6.Text = "Valor Total: R$";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(186, 478);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(0, 21);
            this.lblTotal.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(533, 641);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblMulta);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblvalorLivro);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblPrazo);
            this.Controls.Add(this.txtBoxDevolucao);
            this.Controls.Add(this.lblDataDevolucao);
            this.Controls.Add(this.txtBoxLocacao);
            this.Controls.Add(this.lblDataLocacao);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmbLivros);
            this.Controls.Add(this.cmbCliente);
            this.Controls.Add(this.lblLivro);
            this.Controls.Add(this.lblCliente);
            this.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label lblLivro;
        private System.Windows.Forms.ComboBox cmbCliente;
        private System.Windows.Forms.ComboBox cmbLivros;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblDataLocacao;
        private System.Windows.Forms.TextBox txtBoxLocacao;
        private System.Windows.Forms.Label lblDataDevolucao;
        private System.Windows.Forms.TextBox txtBoxDevolucao;
        private System.Windows.Forms.Label lblPrazo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.Label lblvalorLivro;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblMulta;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblTotal;
    }
}

