
namespace aula06
{
    partial class FormMath
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
            this.BtnSomar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNum1 = new System.Windows.Forms.TextBox();
            this.txtNum2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnSubtrair = new System.Windows.Forms.Button();
            this.BtnDividir = new System.Windows.Forms.Button();
            this.BtnMulti = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnSomar
            // 
            this.BtnSomar.Location = new System.Drawing.Point(30, 93);
            this.BtnSomar.Name = "BtnSomar";
            this.BtnSomar.Size = new System.Drawing.Size(112, 34);
            this.BtnSomar.TabIndex = 0;
            this.BtnSomar.Text = "Somar";
            this.BtnSomar.UseVisualStyleBackColor = true;
            this.BtnSomar.Click += new System.EventHandler(this.BtnSomar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "1º Número:";
            // 
            // txtNum1
            // 
            this.txtNum1.Location = new System.Drawing.Point(13, 42);
            this.txtNum1.Name = "txtNum1";
            this.txtNum1.Size = new System.Drawing.Size(150, 31);
            this.txtNum1.TabIndex = 2;
            // 
            // txtNum2
            // 
            this.txtNum2.Location = new System.Drawing.Point(184, 41);
            this.txtNum2.Name = "txtNum2";
            this.txtNum2.Size = new System.Drawing.Size(150, 31);
            this.txtNum2.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(184, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "2º Número:";
            // 
            // BtnSubtrair
            // 
            this.BtnSubtrair.Location = new System.Drawing.Point(201, 93);
            this.BtnSubtrair.Name = "BtnSubtrair";
            this.BtnSubtrair.Size = new System.Drawing.Size(112, 34);
            this.BtnSubtrair.TabIndex = 5;
            this.BtnSubtrair.Text = "Subtrair";
            this.BtnSubtrair.UseVisualStyleBackColor = true;
            this.BtnSubtrair.Click += new System.EventHandler(this.BtnSubtrair_Click);
            // 
            // BtnDividir
            // 
            this.BtnDividir.Location = new System.Drawing.Point(201, 154);
            this.BtnDividir.Name = "BtnDividir";
            this.BtnDividir.Size = new System.Drawing.Size(112, 34);
            this.BtnDividir.TabIndex = 7;
            this.BtnDividir.Text = "Dividir";
            this.BtnDividir.UseVisualStyleBackColor = true;
            this.BtnDividir.Click += new System.EventHandler(this.BtnDividir_Click);
            // 
            // BtnMulti
            // 
            this.BtnMulti.Location = new System.Drawing.Point(30, 154);
            this.BtnMulti.Name = "BtnMulti";
            this.BtnMulti.Size = new System.Drawing.Size(112, 34);
            this.BtnMulti.TabIndex = 6;
            this.BtnMulti.Text = "Multiplicar";
            this.BtnMulti.UseVisualStyleBackColor = true;
            this.BtnMulti.Click += new System.EventHandler(this.BtnMulti_Click);
            // 
            // FormMath
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 212);
            this.Controls.Add(this.BtnDividir);
            this.Controls.Add(this.BtnMulti);
            this.Controls.Add(this.BtnSubtrair);
            this.Controls.Add(this.txtNum2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNum1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnSomar);
            this.Name = "FormMath";
            this.Text = "FormMath";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnSomar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNum1;
        private System.Windows.Forms.TextBox txtNum2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnSubtrair;
        private System.Windows.Forms.Button BtnDividir;
        private System.Windows.Forms.Button BtnMulti;
    }
}