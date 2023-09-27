
namespace aula07
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
            this.BtnVendedor = new System.Windows.Forms.Button();
            this.BtnPercurso = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnVendedor
            // 
            this.BtnVendedor.Location = new System.Drawing.Point(39, 27);
            this.BtnVendedor.Name = "BtnVendedor";
            this.BtnVendedor.Size = new System.Drawing.Size(249, 75);
            this.BtnVendedor.TabIndex = 0;
            this.BtnVendedor.Text = "Ex. Vendedor";
            this.BtnVendedor.UseVisualStyleBackColor = true;
            this.BtnVendedor.Click += new System.EventHandler(this.BtnVendedor_Click);
            // 
            // BtnPercurso
            // 
            this.BtnPercurso.Location = new System.Drawing.Point(39, 138);
            this.BtnPercurso.Name = "BtnPercurso";
            this.BtnPercurso.Size = new System.Drawing.Size(249, 75);
            this.BtnPercurso.TabIndex = 1;
            this.BtnPercurso.Text = "Ex. Percurso";
            this.BtnPercurso.UseVisualStyleBackColor = true;
            this.BtnPercurso.Click += new System.EventHandler(this.BtnPercurso_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 233);
            this.Controls.Add(this.BtnPercurso);
            this.Controls.Add(this.BtnVendedor);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnVendedor;
        private System.Windows.Forms.Button BtnPercurso;
    }
}

