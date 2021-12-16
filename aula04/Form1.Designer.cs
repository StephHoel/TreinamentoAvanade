
namespace aula04
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
            this.btnRadio = new System.Windows.Forms.Button();
            this.btnLoop = new System.Windows.Forms.Button();
            this.btnFatorial = new System.Windows.Forms.Button();
            this.btnSoma2 = new System.Windows.Forms.Button();
            this.btnPares = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRadio
            // 
            this.btnRadio.Location = new System.Drawing.Point(13, 13);
            this.btnRadio.Name = "btnRadio";
            this.btnRadio.Size = new System.Drawing.Size(229, 34);
            this.btnRadio.TabIndex = 0;
            this.btnRadio.Text = "Exercício Radio";
            this.btnRadio.UseVisualStyleBackColor = true;
            this.btnRadio.Click += new System.EventHandler(this.btnRadio_Click);
            // 
            // btnLoop
            // 
            this.btnLoop.Location = new System.Drawing.Point(12, 64);
            this.btnLoop.Name = "btnLoop";
            this.btnLoop.Size = new System.Drawing.Size(229, 34);
            this.btnLoop.TabIndex = 1;
            this.btnLoop.Text = "Exercício Looping";
            this.btnLoop.UseVisualStyleBackColor = true;
            this.btnLoop.Click += new System.EventHandler(this.btnLoop_Click);
            // 
            // btnFatorial
            // 
            this.btnFatorial.Location = new System.Drawing.Point(12, 114);
            this.btnFatorial.Name = "btnFatorial";
            this.btnFatorial.Size = new System.Drawing.Size(229, 34);
            this.btnFatorial.TabIndex = 2;
            this.btnFatorial.Text = "Exercício Fatorial";
            this.btnFatorial.UseVisualStyleBackColor = true;
            this.btnFatorial.Click += new System.EventHandler(this.btnFatorial_Click);
            // 
            // btnSoma2
            // 
            this.btnSoma2.Location = new System.Drawing.Point(12, 164);
            this.btnSoma2.Name = "btnSoma2";
            this.btnSoma2.Size = new System.Drawing.Size(229, 34);
            this.btnSoma2.TabIndex = 3;
            this.btnSoma2.Text = "Exercício Soma 2";
            this.btnSoma2.UseVisualStyleBackColor = true;
            this.btnSoma2.Click += new System.EventHandler(this.btnSoma2_Click);
            // 
            // btnPares
            // 
            this.btnPares.Location = new System.Drawing.Point(12, 213);
            this.btnPares.Name = "btnPares";
            this.btnPares.Size = new System.Drawing.Size(229, 34);
            this.btnPares.TabIndex = 4;
            this.btnPares.Text = "Exercício Pares";
            this.btnPares.UseVisualStyleBackColor = true;
            this.btnPares.Click += new System.EventHandler(this.btnPares_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(263, 294);
            this.Controls.Add(this.btnPares);
            this.Controls.Add(this.btnSoma2);
            this.Controls.Add(this.btnFatorial);
            this.Controls.Add(this.btnLoop);
            this.Controls.Add(this.btnRadio);
            this.Name = "Form1";
            this.Text = "Entrada";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRadio;
        private System.Windows.Forms.Button btnLoop;
        private System.Windows.Forms.Button btnFatorial;
        private System.Windows.Forms.Button btnSoma2;
        private System.Windows.Forms.Button btnPares;
    }
}

