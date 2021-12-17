
namespace aula05Framework
{
    partial class FormMatrizes
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
            this.BtnTamanho = new System.Windows.Forms.Button();
            this.BtnOrdena = new System.Windows.Forms.Button();
            this.BtnInverter = new System.Windows.Forms.Button();
            this.BtnBuscaBinaria = new System.Windows.Forms.Button();
            this.BtnIndice = new System.Windows.Forms.Button();
            this.ListResultado = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // BtnTamanho
            // 
            this.BtnTamanho.Location = new System.Drawing.Point(12, 8);
            this.BtnTamanho.Name = "BtnTamanho";
            this.BtnTamanho.Size = new System.Drawing.Size(272, 51);
            this.BtnTamanho.TabIndex = 0;
            this.BtnTamanho.Text = "Tamanho do Array";
            this.BtnTamanho.UseVisualStyleBackColor = true;
            this.BtnTamanho.Click += new System.EventHandler(this.BtnTamanho_Click);
            // 
            // BtnOrdena
            // 
            this.BtnOrdena.Location = new System.Drawing.Point(12, 65);
            this.BtnOrdena.Name = "BtnOrdena";
            this.BtnOrdena.Size = new System.Drawing.Size(272, 51);
            this.BtnOrdena.TabIndex = 1;
            this.BtnOrdena.Text = "Ordenar o Array";
            this.BtnOrdena.UseVisualStyleBackColor = true;
            this.BtnOrdena.Click += new System.EventHandler(this.BtnOrdena_Click);
            // 
            // BtnInverter
            // 
            this.BtnInverter.Location = new System.Drawing.Point(12, 122);
            this.BtnInverter.Name = "BtnInverter";
            this.BtnInverter.Size = new System.Drawing.Size(272, 51);
            this.BtnInverter.TabIndex = 2;
            this.BtnInverter.Text = "Inverter o Array";
            this.BtnInverter.UseVisualStyleBackColor = true;
            this.BtnInverter.Click += new System.EventHandler(this.BtnInverter_Click);
            // 
            // BtnBuscaBinaria
            // 
            this.BtnBuscaBinaria.Location = new System.Drawing.Point(12, 179);
            this.BtnBuscaBinaria.Name = "BtnBuscaBinaria";
            this.BtnBuscaBinaria.Size = new System.Drawing.Size(272, 51);
            this.BtnBuscaBinaria.TabIndex = 3;
            this.BtnBuscaBinaria.Text = "Busca Binária";
            this.BtnBuscaBinaria.UseVisualStyleBackColor = true;
            this.BtnBuscaBinaria.Click += new System.EventHandler(this.BtnBuscaBinaria_Click);
            // 
            // BtnIndice
            // 
            this.BtnIndice.Location = new System.Drawing.Point(12, 236);
            this.BtnIndice.Name = "BtnIndice";
            this.BtnIndice.Size = new System.Drawing.Size(272, 51);
            this.BtnIndice.TabIndex = 4;
            this.BtnIndice.Text = "Obtendo um Índice";
            this.BtnIndice.UseVisualStyleBackColor = true;
            this.BtnIndice.Click += new System.EventHandler(this.BtnIndice_Click);
            // 
            // ListResultado
            // 
            this.ListResultado.FormattingEnabled = true;
            this.ListResultado.ItemHeight = 20;
            this.ListResultado.Location = new System.Drawing.Point(13, 294);
            this.ListResultado.Name = "ListResultado";
            this.ListResultado.Size = new System.Drawing.Size(271, 144);
            this.ListResultado.TabIndex = 5;
            // 
            // FormMatrizes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 450);
            this.Controls.Add(this.ListResultado);
            this.Controls.Add(this.BtnIndice);
            this.Controls.Add(this.BtnBuscaBinaria);
            this.Controls.Add(this.BtnInverter);
            this.Controls.Add(this.BtnOrdena);
            this.Controls.Add(this.BtnTamanho);
            this.Name = "FormMatrizes";
            this.Text = "Matrizes";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnTamanho;
        private System.Windows.Forms.Button BtnOrdena;
        private System.Windows.Forms.Button BtnInverter;
        private System.Windows.Forms.Button BtnBuscaBinaria;
        private System.Windows.Forms.Button BtnIndice;
        private System.Windows.Forms.ListBox ListResultado;
    }
}