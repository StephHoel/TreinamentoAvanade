
namespace aula05Framework
{
    partial class FormVetorInverso
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
            this.BtnComeçar = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.listView2 = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // BtnComeçar
            // 
            this.BtnComeçar.Location = new System.Drawing.Point(13, 13);
            this.BtnComeçar.Name = "BtnComeçar";
            this.BtnComeçar.Size = new System.Drawing.Size(312, 49);
            this.BtnComeçar.TabIndex = 0;
            this.BtnComeçar.Text = "Começar";
            this.BtnComeçar.UseVisualStyleBackColor = true;
            this.BtnComeçar.Click += new System.EventHandler(this.BtnComeçar_Click);
            // 
            // listView1
            // 
            this.listView1.Enabled = false;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(13, 91);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(145, 582);
            this.listView1.TabIndex = 1;
            this.listView1.TabStop = false;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // listView2
            // 
            this.listView2.Enabled = false;
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(179, 91);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(146, 582);
            this.listView2.TabIndex = 2;
            this.listView2.TabStop = false;
            this.listView2.UseCompatibleStateImageBehavior = false;
            // 
            // FormVetorInverso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 685);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.BtnComeçar);
            this.Name = "FormVetorInverso";
            this.Text = "Vetor Inverso";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnComeçar;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ListView listView2;
    }
}