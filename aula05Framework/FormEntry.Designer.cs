﻿
namespace aula05Framework
{
    partial class FormEntry
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
            this.btnArrayInterative = new System.Windows.Forms.Button();
            this.BtnArrayInverse = new System.Windows.Forms.Button();
            this.BtnNota = new System.Windows.Forms.Button();
            this.BtnMatrizPares = new System.Windows.Forms.Button();
            this.BtnMatrizes = new System.Windows.Forms.Button();
            this.BtnLer = new System.Windows.Forms.Button();
            this.BtnMatriz4x4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnArrayInterative
            // 
            this.btnArrayInterative.Location = new System.Drawing.Point(13, 13);
            this.btnArrayInterative.Name = "btnArrayInterative";
            this.btnArrayInterative.Size = new System.Drawing.Size(232, 53);
            this.btnArrayInterative.TabIndex = 0;
            this.btnArrayInterative.Text = "Array Interative";
            this.btnArrayInterative.UseVisualStyleBackColor = true;
            this.btnArrayInterative.Click += new System.EventHandler(this.btnArrayInterative_Click);
            // 
            // BtnArrayInverse
            // 
            this.BtnArrayInverse.Location = new System.Drawing.Point(13, 85);
            this.BtnArrayInverse.Name = "BtnArrayInverse";
            this.BtnArrayInverse.Size = new System.Drawing.Size(232, 53);
            this.BtnArrayInverse.TabIndex = 1;
            this.BtnArrayInverse.Text = "Array Inverse";
            this.BtnArrayInverse.UseVisualStyleBackColor = true;
            this.BtnArrayInverse.Click += new System.EventHandler(this.BtnArrayInverse_Click);
            // 
            // BtnNota
            // 
            this.BtnNota.Location = new System.Drawing.Point(13, 162);
            this.BtnNota.Name = "BtnNota";
            this.BtnNota.Size = new System.Drawing.Size(232, 53);
            this.BtnNota.TabIndex = 2;
            this.BtnNota.Text = "Array Nota";
            this.BtnNota.UseVisualStyleBackColor = true;
            this.BtnNota.Click += new System.EventHandler(this.BtnNota_Click);
            // 
            // BtnMatrizPares
            // 
            this.BtnMatrizPares.Location = new System.Drawing.Point(13, 237);
            this.BtnMatrizPares.Name = "BtnMatrizPares";
            this.BtnMatrizPares.Size = new System.Drawing.Size(232, 53);
            this.BtnMatrizPares.TabIndex = 3;
            this.BtnMatrizPares.Text = "Matriz Pares";
            this.BtnMatrizPares.UseVisualStyleBackColor = true;
            this.BtnMatrizPares.Click += new System.EventHandler(this.BtnMatrizPares_Click);
            // 
            // BtnMatrizes
            // 
            this.BtnMatrizes.Location = new System.Drawing.Point(12, 311);
            this.BtnMatrizes.Name = "BtnMatrizes";
            this.BtnMatrizes.Size = new System.Drawing.Size(232, 53);
            this.BtnMatrizes.TabIndex = 4;
            this.BtnMatrizes.Text = "Matrizes";
            this.BtnMatrizes.UseVisualStyleBackColor = true;
            this.BtnMatrizes.Click += new System.EventHandler(this.BtnMatrizes_Click);
            // 
            // BtnLer
            // 
            this.BtnLer.Location = new System.Drawing.Point(13, 391);
            this.BtnLer.Name = "BtnLer";
            this.BtnLer.Size = new System.Drawing.Size(232, 53);
            this.BtnLer.TabIndex = 5;
            this.BtnLer.Text = "Ler Matriz";
            this.BtnLer.UseVisualStyleBackColor = true;
            this.BtnLer.Click += new System.EventHandler(this.BtnLer_Click);
            // 
            // BtnMatriz4x4
            // 
            this.BtnMatriz4x4.Location = new System.Drawing.Point(13, 466);
            this.BtnMatriz4x4.Name = "BtnMatriz4x4";
            this.BtnMatriz4x4.Size = new System.Drawing.Size(232, 53);
            this.BtnMatriz4x4.TabIndex = 6;
            this.BtnMatriz4x4.Text = "Matriz 4x4";
            this.BtnMatriz4x4.UseVisualStyleBackColor = true;
            this.BtnMatriz4x4.Click += new System.EventHandler(this.BtnMatriz4x4_Click);
            // 
            // FormEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(263, 581);
            this.Controls.Add(this.BtnMatriz4x4);
            this.Controls.Add(this.BtnLer);
            this.Controls.Add(this.BtnMatrizes);
            this.Controls.Add(this.BtnMatrizPares);
            this.Controls.Add(this.BtnNota);
            this.Controls.Add(this.BtnArrayInverse);
            this.Controls.Add(this.btnArrayInterative);
            this.Name = "FormEntry";
            this.Text = "Entrada";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnArrayInterative;
        private System.Windows.Forms.Button BtnArrayInverse;
        private System.Windows.Forms.Button BtnNota;
        private System.Windows.Forms.Button BtnMatrizPares;
        private System.Windows.Forms.Button BtnMatrizes;
        private System.Windows.Forms.Button BtnLer;
        private System.Windows.Forms.Button BtnMatriz4x4;
    }
}