
namespace aula06
{
    partial class Form1
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
            this.BtnCriando = new System.Windows.Forms.Button();
            this.BtnMath = new System.Windows.Forms.Button();
            this.BtnCaixa = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnCriando
            // 
            this.BtnCriando.Location = new System.Drawing.Point(13, 13);
            this.BtnCriando.Name = "BtnCriando";
            this.BtnCriando.Size = new System.Drawing.Size(353, 65);
            this.BtnCriando.TabIndex = 0;
            this.BtnCriando.Text = "Criando Classes";
            this.BtnCriando.UseVisualStyleBackColor = true;
            this.BtnCriando.Click += new System.EventHandler(this.BtnCriando_Click);
            // 
            // BtnMath
            // 
            this.BtnMath.Location = new System.Drawing.Point(13, 99);
            this.BtnMath.Name = "BtnMath";
            this.BtnMath.Size = new System.Drawing.Size(353, 65);
            this.BtnMath.TabIndex = 1;
            this.BtnMath.Text = "Matemática";
            this.BtnMath.UseVisualStyleBackColor = true;
            this.BtnMath.Click += new System.EventHandler(this.BtnMath_Click);
            // 
            // BtnCaixa
            // 
            this.BtnCaixa.Location = new System.Drawing.Point(15, 193);
            this.BtnCaixa.Name = "BtnCaixa";
            this.BtnCaixa.Size = new System.Drawing.Size(353, 65);
            this.BtnCaixa.TabIndex = 2;
            this.BtnCaixa.Text = "Saldo de Caixa";
            this.BtnCaixa.UseVisualStyleBackColor = true;
            this.BtnCaixa.Click += new System.EventHandler(this.BtnCaixa_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 450);
            this.Controls.Add(this.BtnCaixa);
            this.Controls.Add(this.BtnMath);
            this.Controls.Add(this.BtnCriando);
            this.Name = "Form1";
            this.Text = "Entrada";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnCriando;
        private System.Windows.Forms.Button BtnMath;
        private System.Windows.Forms.Button BtnCaixa;
    }
}