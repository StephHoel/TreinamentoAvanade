
namespace aula05
{
    partial class FormArray
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtV1 = new System.Windows.Forms.TextBox();
            this.BtnCalular = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtV2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtV3 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtV4 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtV5 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(365, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Digite o valor das vendas de cada vendedor:";
            // 
            // txtV1
            // 
            this.txtV1.Location = new System.Drawing.Point(150, 48);
            this.txtV1.Name = "txtV1";
            this.txtV1.Size = new System.Drawing.Size(207, 31);
            this.txtV1.TabIndex = 1;
            // 
            // BtnCalular
            // 
            this.BtnCalular.Location = new System.Drawing.Point(36, 251);
            this.BtnCalular.Name = "BtnCalular";
            this.BtnCalular.Size = new System.Drawing.Size(321, 34);
            this.BtnCalular.TabIndex = 6;
            this.BtnCalular.Text = "Calcular";
            this.BtnCalular.UseVisualStyleBackColor = true;
            this.BtnCalular.Click += new System.EventHandler(this.BtnCalular_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Vendedor 1:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Vendedor 2:";
            // 
            // txtV2
            // 
            this.txtV2.Location = new System.Drawing.Point(150, 85);
            this.txtV2.Name = "txtV2";
            this.txtV2.Size = new System.Drawing.Size(207, 31);
            this.txtV2.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Vendedor 3:";
            // 
            // txtV3
            // 
            this.txtV3.Location = new System.Drawing.Point(150, 122);
            this.txtV3.Name = "txtV3";
            this.txtV3.Size = new System.Drawing.Size(207, 31);
            this.txtV3.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "Vendedor 4:";
            // 
            // txtV4
            // 
            this.txtV4.Location = new System.Drawing.Point(150, 159);
            this.txtV4.Name = "txtV4";
            this.txtV4.Size = new System.Drawing.Size(207, 31);
            this.txtV4.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(36, 198);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 25);
            this.label6.TabIndex = 11;
            this.label6.Text = "Vendedor 5:";
            // 
            // txtV5
            // 
            this.txtV5.Location = new System.Drawing.Point(150, 196);
            this.txtV5.Name = "txtV5";
            this.txtV5.Size = new System.Drawing.Size(207, 31);
            this.txtV5.TabIndex = 5;
            // 
            // FormArray
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 301);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtV5);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtV4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtV3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtV2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnCalular);
            this.Controls.Add(this.txtV1);
            this.Controls.Add(this.label1);
            this.Name = "FormArray";
            this.Text = "FormArray";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtV1;
        private System.Windows.Forms.Button BtnCalular;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtV2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtV3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtV4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtV5;
    }
}