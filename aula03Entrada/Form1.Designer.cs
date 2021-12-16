
namespace aula03Entrada
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
            this.btnBanco = new System.Windows.Forms.Button();
            this.btnMedia = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBanco
            // 
            this.btnBanco.Location = new System.Drawing.Point(12, 12);
            this.btnBanco.Name = "btnBanco";
            this.btnBanco.Size = new System.Drawing.Size(281, 34);
            this.btnBanco.TabIndex = 0;
            this.btnBanco.Text = "Projeto Banco";
            this.btnBanco.UseVisualStyleBackColor = true;
            this.btnBanco.Click += new System.EventHandler(this.btnBanco_Click);
            // 
            // btnMedia
            // 
            this.btnMedia.Location = new System.Drawing.Point(12, 68);
            this.btnMedia.Name = "btnMedia";
            this.btnMedia.Size = new System.Drawing.Size(281, 34);
            this.btnMedia.TabIndex = 1;
            this.btnMedia.Text = "Projeto Média";
            this.btnMedia.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 123);
            this.Controls.Add(this.btnMedia);
            this.Controls.Add(this.btnBanco);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBanco;
        private System.Windows.Forms.Button btnMedia;
    }
}

