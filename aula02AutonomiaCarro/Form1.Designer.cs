
namespace aula02AutonomiaCarro
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
            this.txtAnt = new System.Windows.Forms.TextBox();
            this.btnConvert = new System.Windows.Forms.Button();
            this.txtAtu = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtGas = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRes = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quilometragem anterior:";
            // 
            // txtAnt
            // 
            this.txtAnt.Location = new System.Drawing.Point(12, 37);
            this.txtAnt.Name = "txtAnt";
            this.txtAnt.Size = new System.Drawing.Size(254, 31);
            this.txtAnt.TabIndex = 1;
            this.txtAnt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(85, 260);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(112, 34);
            this.btnConvert.TabIndex = 4;
            this.btnConvert.Text = "Converter";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // txtAtu
            // 
            this.txtAtu.Location = new System.Drawing.Point(12, 114);
            this.txtAtu.Name = "txtAtu";
            this.txtAtu.Size = new System.Drawing.Size(254, 31);
            this.txtAtu.TabIndex = 2;
            this.txtAtu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Quilometragem atual:";
            // 
            // txtGas
            // 
            this.txtGas.Location = new System.Drawing.Point(12, 191);
            this.txtGas.Name = "txtGas";
            this.txtGas.Size = new System.Drawing.Size(254, 31);
            this.txtGas.TabIndex = 3;
            this.txtGas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Litros de Gasolina:";
            // 
            // txtRes
            // 
            this.txtRes.Location = new System.Drawing.Point(12, 356);
            this.txtRes.Name = "txtRes";
            this.txtRes.ReadOnly = true;
            this.txtRes.Size = new System.Drawing.Size(254, 31);
            this.txtRes.TabIndex = 5;
            this.txtRes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 328);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(181, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Autônomia em KM/L:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 444);
            this.Controls.Add(this.txtRes);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtGas);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtAtu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.txtAnt);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Autonomia";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAnt;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.TextBox txtAtu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtGas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtRes;
        private System.Windows.Forms.Label label4;
    }
}

