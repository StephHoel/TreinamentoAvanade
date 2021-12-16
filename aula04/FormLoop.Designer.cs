
namespace aula04
{
    partial class FormLoop
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
            this.txtT = new System.Windows.Forms.TextBox();
            this.btnTabuada = new System.Windows.Forms.Button();
            this.listBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Escreva o número:";
            // 
            // txtT
            // 
            this.txtT.Location = new System.Drawing.Point(13, 42);
            this.txtT.Name = "txtT";
            this.txtT.ShortcutsEnabled = false;
            this.txtT.Size = new System.Drawing.Size(234, 31);
            this.txtT.TabIndex = 1;
            // 
            // btnTabuada
            // 
            this.btnTabuada.Location = new System.Drawing.Point(27, 92);
            this.btnTabuada.Name = "btnTabuada";
            this.btnTabuada.Size = new System.Drawing.Size(203, 34);
            this.btnTabuada.TabIndex = 2;
            this.btnTabuada.Text = "Ver Tabuada";
            this.btnTabuada.UseVisualStyleBackColor = true;
            this.btnTabuada.Click += new System.EventHandler(this.btnTabuada_Click);
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 25;
            this.listBox.Location = new System.Drawing.Point(13, 144);
            this.listBox.MultiColumn = true;
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(234, 254);
            this.listBox.TabIndex = 3;
            // 
            // FormLoop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(266, 413);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.btnTabuada);
            this.Controls.Add(this.txtT);
            this.Controls.Add(this.label1);
            this.Name = "FormLoop";
            this.Text = "Looping";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtT;
        private System.Windows.Forms.Button btnTabuada;
        private System.Windows.Forms.ListBox listBox;
    }
}