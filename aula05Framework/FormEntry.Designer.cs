
namespace aula05Framework
{
    partial class FormEntry
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
            this.btnArrayInterative = new System.Windows.Forms.Button();
            this.BtnArrayInverse = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnArrayInterative
            // 
            this.btnArrayInterative.Location = new System.Drawing.Point(13, 13);
            this.btnArrayInterative.Name = "btnArrayInterative";
            this.btnArrayInterative.Size = new System.Drawing.Size(232, 53);
            this.btnArrayInterative.TabIndex = 0;
            this.btnArrayInterative.Text = "Array Interative";
            this.btnArrayInterative.UseVisualStyleBackColor = true;
            this.btnArrayInterative.Click += new System.EventHandler(this.btnArrayInterative_Click);
            // 
            // BtnArrayInverse
            // 
            this.BtnArrayInverse.Location = new System.Drawing.Point(13, 85);
            this.BtnArrayInverse.Name = "BtnArrayInverse";
            this.BtnArrayInverse.Size = new System.Drawing.Size(232, 53);
            this.BtnArrayInverse.TabIndex = 1;
            this.BtnArrayInverse.Text = "Array Inverse";
            this.BtnArrayInverse.UseVisualStyleBackColor = true;
            this.BtnArrayInverse.Click += new System.EventHandler(this.BtnArrayInverse_Click);
            // 
            // FormEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(263, 450);
            this.Controls.Add(this.BtnArrayInverse);
            this.Controls.Add(this.btnArrayInterative);
            this.Name = "FormEntry";
            this.Text = "Entrada";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnArrayInterative;
        private System.Windows.Forms.Button BtnArrayInverse;
    }
}