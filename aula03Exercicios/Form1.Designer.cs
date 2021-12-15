
namespace aula03Exercicios
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtT3 = new System.Windows.Forms.TextBox();
            this.txtT2 = new System.Windows.Forms.TextBox();
            this.txtT1 = new System.Windows.Forms.TextBox();
            this.btnVerificar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMes = new System.Windows.Forms.Button();
            this.txtMes = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtT3);
            this.groupBox1.Controls.Add(this.txtT2);
            this.groupBox1.Controls.Add(this.txtT1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(300, 150);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Valores dos Triângulos:";
            // 
            // txtT3
            // 
            this.txtT3.Location = new System.Drawing.Point(7, 107);
            this.txtT3.Name = "txtT3";
            this.txtT3.PlaceholderText = "Triângulo 3";
            this.txtT3.Size = new System.Drawing.Size(287, 31);
            this.txtT3.TabIndex = 2;
            // 
            // txtT2
            // 
            this.txtT2.Location = new System.Drawing.Point(7, 69);
            this.txtT2.Name = "txtT2";
            this.txtT2.PlaceholderText = "Triângulo 2";
            this.txtT2.Size = new System.Drawing.Size(287, 31);
            this.txtT2.TabIndex = 1;
            // 
            // txtT1
            // 
            this.txtT1.Location = new System.Drawing.Point(7, 31);
            this.txtT1.Name = "txtT1";
            this.txtT1.PlaceholderText = "Triângulo 1";
            this.txtT1.Size = new System.Drawing.Size(287, 31);
            this.txtT1.TabIndex = 0;
            // 
            // btnVerificar
            // 
            this.btnVerificar.Location = new System.Drawing.Point(13, 170);
            this.btnVerificar.Name = "btnVerificar";
            this.btnVerificar.Size = new System.Drawing.Size(300, 34);
            this.btnVerificar.TabIndex = 3;
            this.btnVerificar.Text = "Verificar Triângulo";
            this.btnVerificar.UseVisualStyleBackColor = true;
            this.btnVerificar.Click += new System.EventHandler(this.btnVerificar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 243);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Digite o número do mês:";
            // 
            // btnMes
            // 
            this.btnMes.Location = new System.Drawing.Point(13, 310);
            this.btnMes.Name = "btnMes";
            this.btnMes.Size = new System.Drawing.Size(300, 34);
            this.btnMes.TabIndex = 5;
            this.btnMes.Text = "Verificar Mês";
            this.btnMes.UseVisualStyleBackColor = true;
            this.btnMes.Click += new System.EventHandler(this.btnMes_Click);
            // 
            // txtMes
            // 
            this.txtMes.Location = new System.Drawing.Point(13, 273);
            this.txtMes.Name = "txtMes";
            this.txtMes.PlaceholderText = "Número do Mês";
            this.txtMes.Size = new System.Drawing.Size(300, 31);
            this.txtMes.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 370);
            this.Controls.Add(this.txtMes);
            this.Controls.Add(this.btnMes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnVerificar);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtT3;
        private System.Windows.Forms.TextBox txtT2;
        private System.Windows.Forms.TextBox txtT1;
        private System.Windows.Forms.Button btnVerificar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMes;
        private System.Windows.Forms.TextBox txtMes;
    }
}

