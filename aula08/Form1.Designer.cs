
namespace aula08
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.tabProdutos = new System.Windows.Forms.TabControl();
            this.tabLivros = new System.Windows.Forms.TabPage();
            this.BtnListarLivro = new System.Windows.Forms.Button();
            this.BtnVendLivro = new System.Windows.Forms.Button();
            this.BtnCompLivro = new System.Windows.Forms.Button();
            this.BtnCadLivro = new System.Windows.Forms.Button();
            this.txtEdicao = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtEditora = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAutor = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tabCD = new System.Windows.Forms.TabPage();
            this.BtnListarCD = new System.Windows.Forms.Button();
            this.BtnVendCD = new System.Windows.Forms.Button();
            this.txtOrigem = new System.Windows.Forms.TextBox();
            this.BtnCompCD = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.BtnCadCD = new System.Windows.Forms.Button();
            this.txtGravadora = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtArtista = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tabDVD = new System.Windows.Forms.TabPage();
            this.BtnListarDVD = new System.Windows.Forms.Button();
            this.BtnVendDVD = new System.Windows.Forms.Button();
            this.BtnCompDVD = new System.Windows.Forms.Button();
            this.BtnCadDVD = new System.Windows.Forms.Button();
            this.txtCensura = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtDuracao = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtDiretor = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtGenero = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEstoque = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.tabProdutos.SuspendLayout();
            this.tabLivros.SuspendLayout();
            this.tabCD.SuspendLayout();
            this.tabDVD.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Descrição do Produto:";
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(18, 43);
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(424, 31);
            this.txtDesc.TabIndex = 1;
            // 
            // tabProdutos
            // 
            this.tabProdutos.Controls.Add(this.tabLivros);
            this.tabProdutos.Controls.Add(this.tabCD);
            this.tabProdutos.Controls.Add(this.tabDVD);
            this.tabProdutos.Location = new System.Drawing.Point(18, 260);
            this.tabProdutos.Name = "tabProdutos";
            this.tabProdutos.SelectedIndex = 0;
            this.tabProdutos.Size = new System.Drawing.Size(424, 333);
            this.tabProdutos.TabIndex = 2;
            // 
            // tabLivros
            // 
            this.tabLivros.Controls.Add(this.BtnListarLivro);
            this.tabLivros.Controls.Add(this.BtnVendLivro);
            this.tabLivros.Controls.Add(this.BtnCompLivro);
            this.tabLivros.Controls.Add(this.BtnCadLivro);
            this.tabLivros.Controls.Add(this.txtEdicao);
            this.tabLivros.Controls.Add(this.label7);
            this.tabLivros.Controls.Add(this.txtEditora);
            this.tabLivros.Controls.Add(this.label6);
            this.tabLivros.Controls.Add(this.txtAutor);
            this.tabLivros.Controls.Add(this.label5);
            this.tabLivros.Location = new System.Drawing.Point(4, 34);
            this.tabLivros.Name = "tabLivros";
            this.tabLivros.Padding = new System.Windows.Forms.Padding(3);
            this.tabLivros.Size = new System.Drawing.Size(416, 295);
            this.tabLivros.TabIndex = 0;
            this.tabLivros.Text = "Livros";
            this.tabLivros.UseVisualStyleBackColor = true;
            // 
            // BtnListarLivro
            // 
            this.BtnListarLivro.Location = new System.Drawing.Point(314, 241);
            this.BtnListarLivro.Name = "BtnListarLivro";
            this.BtnListarLivro.Size = new System.Drawing.Size(87, 34);
            this.BtnListarLivro.TabIndex = 11;
            this.BtnListarLivro.Text = "Listar";
            this.BtnListarLivro.UseVisualStyleBackColor = true;
            this.BtnListarLivro.Click += new System.EventHandler(this.BtnListarLivro_Click);
            // 
            // BtnVendLivro
            // 
            this.BtnVendLivro.Location = new System.Drawing.Point(218, 241);
            this.BtnVendLivro.Name = "BtnVendLivro";
            this.BtnVendLivro.Size = new System.Drawing.Size(90, 34);
            this.BtnVendLivro.TabIndex = 10;
            this.BtnVendLivro.Text = "Vender";
            this.BtnVendLivro.UseVisualStyleBackColor = true;
            this.BtnVendLivro.Click += new System.EventHandler(this.BtnVendLivro_Click);
            // 
            // BtnCompLivro
            // 
            this.BtnCompLivro.Location = new System.Drawing.Point(114, 241);
            this.BtnCompLivro.Name = "BtnCompLivro";
            this.BtnCompLivro.Size = new System.Drawing.Size(98, 34);
            this.BtnCompLivro.TabIndex = 9;
            this.BtnCompLivro.Text = "Comprar";
            this.BtnCompLivro.UseVisualStyleBackColor = true;
            this.BtnCompLivro.Click += new System.EventHandler(this.BtnCompLivro_Click);
            // 
            // BtnCadLivro
            // 
            this.BtnCadLivro.Location = new System.Drawing.Point(7, 241);
            this.BtnCadLivro.Name = "BtnCadLivro";
            this.BtnCadLivro.Size = new System.Drawing.Size(101, 34);
            this.BtnCadLivro.TabIndex = 8;
            this.BtnCadLivro.Text = "Cadastrar";
            this.BtnCadLivro.UseVisualStyleBackColor = true;
            this.BtnCadLivro.Click += new System.EventHandler(this.BtnCadLivro_Click);
            // 
            // txtEdicao
            // 
            this.txtEdicao.Location = new System.Drawing.Point(6, 181);
            this.txtEdicao.Name = "txtEdicao";
            this.txtEdicao.Size = new System.Drawing.Size(404, 31);
            this.txtEdicao.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 153);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 25);
            this.label7.TabIndex = 6;
            this.label7.Text = "Edição:";
            // 
            // txtEditora
            // 
            this.txtEditora.Location = new System.Drawing.Point(6, 105);
            this.txtEditora.Name = "txtEditora";
            this.txtEditora.Size = new System.Drawing.Size(404, 31);
            this.txtEditora.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 25);
            this.label6.TabIndex = 4;
            this.label6.Text = "Editora:";
            // 
            // txtAutor
            // 
            this.txtAutor.Location = new System.Drawing.Point(6, 31);
            this.txtAutor.Name = "txtAutor";
            this.txtAutor.Size = new System.Drawing.Size(404, 31);
            this.txtAutor.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 25);
            this.label5.TabIndex = 2;
            this.label5.Text = "Autor:";
            // 
            // tabCD
            // 
            this.tabCD.Controls.Add(this.BtnListarCD);
            this.tabCD.Controls.Add(this.BtnVendCD);
            this.tabCD.Controls.Add(this.txtOrigem);
            this.tabCD.Controls.Add(this.BtnCompCD);
            this.tabCD.Controls.Add(this.label8);
            this.tabCD.Controls.Add(this.BtnCadCD);
            this.tabCD.Controls.Add(this.txtGravadora);
            this.tabCD.Controls.Add(this.label9);
            this.tabCD.Controls.Add(this.txtArtista);
            this.tabCD.Controls.Add(this.label10);
            this.tabCD.Location = new System.Drawing.Point(4, 34);
            this.tabCD.Name = "tabCD";
            this.tabCD.Padding = new System.Windows.Forms.Padding(3);
            this.tabCD.Size = new System.Drawing.Size(416, 295);
            this.tabCD.TabIndex = 1;
            this.tabCD.Text = "CD";
            this.tabCD.UseVisualStyleBackColor = true;
            // 
            // BtnListarCD
            // 
            this.BtnListarCD.Location = new System.Drawing.Point(314, 243);
            this.BtnListarCD.Name = "BtnListarCD";
            this.BtnListarCD.Size = new System.Drawing.Size(87, 34);
            this.BtnListarCD.TabIndex = 18;
            this.BtnListarCD.Text = "Listar";
            this.BtnListarCD.UseVisualStyleBackColor = true;
            this.BtnListarCD.Click += new System.EventHandler(this.BtnListarCD_Click);
            // 
            // BtnVendCD
            // 
            this.BtnVendCD.Location = new System.Drawing.Point(218, 243);
            this.BtnVendCD.Name = "BtnVendCD";
            this.BtnVendCD.Size = new System.Drawing.Size(90, 34);
            this.BtnVendCD.TabIndex = 17;
            this.BtnVendCD.Text = "Vender";
            this.BtnVendCD.UseVisualStyleBackColor = true;
            this.BtnVendCD.Click += new System.EventHandler(this.BtnVendCD_Click);
            // 
            // txtOrigem
            // 
            this.txtOrigem.Location = new System.Drawing.Point(6, 189);
            this.txtOrigem.Name = "txtOrigem";
            this.txtOrigem.Size = new System.Drawing.Size(404, 31);
            this.txtOrigem.TabIndex = 14;
            // 
            // BtnCompCD
            // 
            this.BtnCompCD.Location = new System.Drawing.Point(114, 243);
            this.BtnCompCD.Name = "BtnCompCD";
            this.BtnCompCD.Size = new System.Drawing.Size(98, 34);
            this.BtnCompCD.TabIndex = 16;
            this.BtnCompCD.Text = "Comprar";
            this.BtnCompCD.UseVisualStyleBackColor = true;
            this.BtnCompCD.Click += new System.EventHandler(this.BtnCompCD_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 161);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(136, 25);
            this.label8.TabIndex = 15;
            this.label8.Text = "País de Origem:";
            // 
            // BtnCadCD
            // 
            this.BtnCadCD.Location = new System.Drawing.Point(7, 243);
            this.BtnCadCD.Name = "BtnCadCD";
            this.BtnCadCD.Size = new System.Drawing.Size(101, 34);
            this.BtnCadCD.TabIndex = 15;
            this.BtnCadCD.Text = "Cadastrar";
            this.BtnCadCD.UseVisualStyleBackColor = true;
            this.BtnCadCD.Click += new System.EventHandler(this.BtnCadCD_Click);
            // 
            // txtGravadora
            // 
            this.txtGravadora.Location = new System.Drawing.Point(6, 113);
            this.txtGravadora.Name = "txtGravadora";
            this.txtGravadora.Size = new System.Drawing.Size(404, 31);
            this.txtGravadora.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 85);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 25);
            this.label9.TabIndex = 13;
            this.label9.Text = "Gravadora:";
            // 
            // txtArtista
            // 
            this.txtArtista.Location = new System.Drawing.Point(6, 39);
            this.txtArtista.Name = "txtArtista";
            this.txtArtista.Size = new System.Drawing.Size(404, 31);
            this.txtArtista.TabIndex = 12;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 11);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 25);
            this.label10.TabIndex = 11;
            this.label10.Text = "Artista:";
            // 
            // tabDVD
            // 
            this.tabDVD.Controls.Add(this.BtnListarDVD);
            this.tabDVD.Controls.Add(this.BtnVendDVD);
            this.tabDVD.Controls.Add(this.BtnCompDVD);
            this.tabDVD.Controls.Add(this.BtnCadDVD);
            this.tabDVD.Controls.Add(this.txtCensura);
            this.tabDVD.Controls.Add(this.label11);
            this.tabDVD.Controls.Add(this.txtDuracao);
            this.tabDVD.Controls.Add(this.label12);
            this.tabDVD.Controls.Add(this.txtDiretor);
            this.tabDVD.Controls.Add(this.label13);
            this.tabDVD.Location = new System.Drawing.Point(4, 34);
            this.tabDVD.Name = "tabDVD";
            this.tabDVD.Padding = new System.Windows.Forms.Padding(3);
            this.tabDVD.Size = new System.Drawing.Size(416, 295);
            this.tabDVD.TabIndex = 2;
            this.tabDVD.Text = "DVD";
            this.tabDVD.UseVisualStyleBackColor = true;
            // 
            // BtnListarDVD
            // 
            this.BtnListarDVD.Location = new System.Drawing.Point(313, 245);
            this.BtnListarDVD.Name = "BtnListarDVD";
            this.BtnListarDVD.Size = new System.Drawing.Size(87, 34);
            this.BtnListarDVD.TabIndex = 29;
            this.BtnListarDVD.Text = "Listar";
            this.BtnListarDVD.UseVisualStyleBackColor = true;
            this.BtnListarDVD.Click += new System.EventHandler(this.BtnListarDVD_Click);
            // 
            // BtnVendDVD
            // 
            this.BtnVendDVD.Location = new System.Drawing.Point(217, 245);
            this.BtnVendDVD.Name = "BtnVendDVD";
            this.BtnVendDVD.Size = new System.Drawing.Size(90, 34);
            this.BtnVendDVD.TabIndex = 28;
            this.BtnVendDVD.Text = "Vender";
            this.BtnVendDVD.UseVisualStyleBackColor = true;
            this.BtnVendDVD.Click += new System.EventHandler(this.BtnVendDVD_Click);
            // 
            // BtnCompDVD
            // 
            this.BtnCompDVD.Location = new System.Drawing.Point(113, 245);
            this.BtnCompDVD.Name = "BtnCompDVD";
            this.BtnCompDVD.Size = new System.Drawing.Size(98, 34);
            this.BtnCompDVD.TabIndex = 27;
            this.BtnCompDVD.Text = "Comprar";
            this.BtnCompDVD.UseVisualStyleBackColor = true;
            this.BtnCompDVD.Click += new System.EventHandler(this.BtnCompDVD_Click);
            // 
            // BtnCadDVD
            // 
            this.BtnCadDVD.Location = new System.Drawing.Point(6, 245);
            this.BtnCadDVD.Name = "BtnCadDVD";
            this.BtnCadDVD.Size = new System.Drawing.Size(101, 34);
            this.BtnCadDVD.TabIndex = 26;
            this.BtnCadDVD.Text = "Cadastrar";
            this.BtnCadDVD.UseVisualStyleBackColor = true;
            this.BtnCadDVD.Click += new System.EventHandler(this.BtnCadDVD_Click);
            // 
            // txtCensura
            // 
            this.txtCensura.Location = new System.Drawing.Point(6, 189);
            this.txtCensura.Name = "txtCensura";
            this.txtCensura.Size = new System.Drawing.Size(404, 31);
            this.txtCensura.TabIndex = 25;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 161);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(79, 25);
            this.label11.TabIndex = 24;
            this.label11.Text = "Censura:";
            // 
            // txtDuracao
            // 
            this.txtDuracao.Location = new System.Drawing.Point(6, 113);
            this.txtDuracao.Name = "txtDuracao";
            this.txtDuracao.Size = new System.Drawing.Size(404, 31);
            this.txtDuracao.TabIndex = 23;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 85);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(82, 25);
            this.label12.TabIndex = 22;
            this.label12.Text = "Duração:";
            // 
            // txtDiretor
            // 
            this.txtDiretor.Location = new System.Drawing.Point(6, 39);
            this.txtDiretor.Name = "txtDiretor";
            this.txtDiretor.Size = new System.Drawing.Size(404, 31);
            this.txtDiretor.TabIndex = 21;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 11);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(71, 25);
            this.label13.TabIndex = 20;
            this.label13.Text = "Diretor:";
            // 
            // txtGenero
            // 
            this.txtGenero.Location = new System.Drawing.Point(18, 116);
            this.txtGenero.Name = "txtGenero";
            this.txtGenero.Size = new System.Drawing.Size(424, 31);
            this.txtGenero.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Gênero:";
            // 
            // txtEstoque
            // 
            this.txtEstoque.Location = new System.Drawing.Point(18, 195);
            this.txtEstoque.Name = "txtEstoque";
            this.txtEstoque.Size = new System.Drawing.Size(189, 31);
            this.txtEstoque.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Qtde em Estoque:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(259, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Preço:";
            // 
            // txtPreco
            // 
            this.txtPreco.Location = new System.Drawing.Point(253, 195);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(189, 31);
            this.txtPreco.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 617);
            this.Controls.Add(this.txtPreco);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtEstoque);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtGenero);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tabProdutos);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabProdutos.ResumeLayout(false);
            this.tabLivros.ResumeLayout(false);
            this.tabLivros.PerformLayout();
            this.tabCD.ResumeLayout(false);
            this.tabCD.PerformLayout();
            this.tabDVD.ResumeLayout(false);
            this.tabDVD.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.TabControl tabProdutos;
        private System.Windows.Forms.TabPage tabLivros;
        private System.Windows.Forms.Button BtnVendLivro;
        private System.Windows.Forms.Button BtnCompLivro;
        private System.Windows.Forms.Button BtnCadLivro;
        private System.Windows.Forms.TextBox txtEdicao;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtEditora;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAutor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabPage tabCD;
        private System.Windows.Forms.TextBox txtOrigem;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtGravadora;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtArtista;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TabPage tabDVD;
        private System.Windows.Forms.TextBox txtCensura;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtDuracao;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtDiretor;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtGenero;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEstoque;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.Button BtnListarLivro;
        private System.Windows.Forms.Button BtnListarCD;
        private System.Windows.Forms.Button BtnVendCD;
        private System.Windows.Forms.Button BtnCompCD;
        private System.Windows.Forms.Button BtnCadCD;
        private System.Windows.Forms.Button BtnListarDVD;
        private System.Windows.Forms.Button BtnVendDVD;
        private System.Windows.Forms.Button BtnCompDVD;
        private System.Windows.Forms.Button BtnCadDVD;
    }
}

