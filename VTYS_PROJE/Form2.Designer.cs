namespace VTYS_PROJE
{
    partial class Form2
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
            this.buttonProjeEkle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(291, 15);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(5);
            this.label1.Size = new System.Drawing.Size(166, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "PROJELERİMİZ";
            // 
            // buttonProjeEkle
            // 
            this.buttonProjeEkle.BackColor = System.Drawing.Color.White;
            this.buttonProjeEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonProjeEkle.Location = new System.Drawing.Point(646, 18);
            this.buttonProjeEkle.Name = "buttonProjeEkle";
            this.buttonProjeEkle.Size = new System.Drawing.Size(115, 34);
            this.buttonProjeEkle.TabIndex = 1;
            this.buttonProjeEkle.Text = "Proje Ekle";
            this.buttonProjeEkle.UseVisualStyleBackColor = false;
            this.buttonProjeEkle.Click += new System.EventHandler(this.buttonProjeEkle_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(773, 450);
            this.Controls.Add(this.buttonProjeEkle);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Projeler";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonProjeEkle;
    }
}