
namespace aula02Media
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
            this.txtNota1 = new System.Windows.Forms.TextBox();
            this.btnVerificar = new System.Windows.Forms.Button();
            this.txtNota2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNota3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nota do 1º Trimestre:";
            // 
            // txtNota1
            // 
            this.txtNota1.Location = new System.Drawing.Point(13, 42);
            this.txtNota1.Name = "txtNota1";
            this.txtNota1.Size = new System.Drawing.Size(268, 31);
            this.txtNota1.TabIndex = 1;
            // 
            // btnVerificar
            // 
            this.btnVerificar.Location = new System.Drawing.Point(13, 251);
            this.btnVerificar.Name = "btnVerificar";
            this.btnVerificar.Size = new System.Drawing.Size(268, 34);
            this.btnVerificar.TabIndex = 2;
            this.btnVerificar.Text = "Verificar";
            this.btnVerificar.UseVisualStyleBackColor = true;
            this.btnVerificar.Click += new System.EventHandler(this.btnVerificar_Click);
            // 
            // txtNota2
            // 
            this.txtNota2.Location = new System.Drawing.Point(13, 115);
            this.txtNota2.Name = "txtNota2";
            this.txtNota2.Size = new System.Drawing.Size(268, 31);
            this.txtNota2.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nota do 2º Trimestre:";
            // 
            // txtNota3
            // 
            this.txtNota3.Location = new System.Drawing.Point(13, 193);
            this.txtNota3.Name = "txtNota3";
            this.txtNota3.Size = new System.Drawing.Size(268, 31);
            this.txtNota3.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(181, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nota do 3º Trimestre:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 310);
            this.Controls.Add(this.txtNota3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNota2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnVerificar);
            this.Controls.Add(this.txtNota1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNota1;
        private System.Windows.Forms.Button btnVerificar;
        private System.Windows.Forms.TextBox txtNota2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNota3;
        private System.Windows.Forms.Label label3;
    }
}

