namespace WinForms_dz_DopForms
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
            this.txbMaskaPoiska = new System.Windows.Forms.TextBox();
            this.btnPoisk = new System.Windows.Forms.Button();
            this.lsbResult = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите маску поиска";
            // 
            // txbMaskaPoiska
            // 
            this.txbMaskaPoiska.Location = new System.Drawing.Point(153, 36);
            this.txbMaskaPoiska.Name = "txbMaskaPoiska";
            this.txbMaskaPoiska.Size = new System.Drawing.Size(100, 20);
            this.txbMaskaPoiska.TabIndex = 1;
            // 
            // btnPoisk
            // 
            this.btnPoisk.Location = new System.Drawing.Point(68, 75);
            this.btnPoisk.Name = "btnPoisk";
            this.btnPoisk.Size = new System.Drawing.Size(133, 71);
            this.btnPoisk.TabIndex = 2;
            this.btnPoisk.Text = "Поиск";
            this.btnPoisk.UseVisualStyleBackColor = true;
            this.btnPoisk.Click += new System.EventHandler(this.btnPoisk_Click);
            // 
            // lsbResult
            // 
            this.lsbResult.FormattingEnabled = true;
            this.lsbResult.Location = new System.Drawing.Point(15, 191);
            this.lsbResult.Name = "lsbResult";
            this.lsbResult.Size = new System.Drawing.Size(714, 160);
            this.lsbResult.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(74, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Результат:";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 362);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lsbResult);
            this.Controls.Add(this.btnPoisk);
            this.Controls.Add(this.txbMaskaPoiska);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbMaskaPoiska;
        private System.Windows.Forms.Button btnPoisk;
        private System.Windows.Forms.ListBox lsbResult;
        private System.Windows.Forms.Label label2;
    }
}