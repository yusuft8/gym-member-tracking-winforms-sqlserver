namespace VisualProgramingProje
{
    partial class Form3
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
            this.btn_uyelik = new System.Windows.Forms.Button();
            this.btn_olcum = new System.Windows.Forms.Button();
            this.btn_raporlar = new System.Windows.Forms.Button();
            this.btn_odeme = new System.Windows.Forms.Button();
            this.lb_hgmesaj = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_uyelik
            // 
            this.btn_uyelik.Location = new System.Drawing.Point(78, 85);
            this.btn_uyelik.Name = "btn_uyelik";
            this.btn_uyelik.Size = new System.Drawing.Size(353, 262);
            this.btn_uyelik.TabIndex = 0;
            this.btn_uyelik.Text = "Üyelik İşlemleri";
            this.btn_uyelik.UseVisualStyleBackColor = true;
            this.btn_uyelik.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_olcum
            // 
            this.btn_olcum.Location = new System.Drawing.Point(437, 85);
            this.btn_olcum.Name = "btn_olcum";
            this.btn_olcum.Size = new System.Drawing.Size(353, 262);
            this.btn_olcum.TabIndex = 1;
            this.btn_olcum.Text = "Ölçüm İşlemleri";
            this.btn_olcum.UseVisualStyleBackColor = true;
            this.btn_olcum.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_raporlar
            // 
            this.btn_raporlar.Location = new System.Drawing.Point(437, 353);
            this.btn_raporlar.Name = "btn_raporlar";
            this.btn_raporlar.Size = new System.Drawing.Size(353, 262);
            this.btn_raporlar.TabIndex = 2;
            this.btn_raporlar.Text = "Raporlar";
            this.btn_raporlar.UseVisualStyleBackColor = true;
            this.btn_raporlar.Click += new System.EventHandler(this.button3_Click);
            // 
            // btn_odeme
            // 
            this.btn_odeme.Location = new System.Drawing.Point(78, 353);
            this.btn_odeme.Name = "btn_odeme";
            this.btn_odeme.Size = new System.Drawing.Size(353, 262);
            this.btn_odeme.TabIndex = 3;
            this.btn_odeme.Text = "Ödeme İşlemleri";
            this.btn_odeme.UseVisualStyleBackColor = true;
            this.btn_odeme.Click += new System.EventHandler(this.button4_Click);
            // 
            // lb_hgmesaj
            // 
            this.lb_hgmesaj.AutoSize = true;
            this.lb_hgmesaj.Font = new System.Drawing.Font("MS Reference Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_hgmesaj.Location = new System.Drawing.Point(305, 29);
            this.lb_hgmesaj.Name = "lb_hgmesaj";
            this.lb_hgmesaj.Size = new System.Drawing.Size(69, 40);
            this.lb_hgmesaj.TabIndex = 4;
            this.lb_hgmesaj.Text = "    ";
            this.lb_hgmesaj.Click += new System.EventHandler(this.lb_hgmesaj_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 710);
            this.Controls.Add(this.lb_hgmesaj);
            this.Controls.Add(this.btn_odeme);
            this.Controls.Add(this.btn_raporlar);
            this.Controls.Add(this.btn_olcum);
            this.Controls.Add(this.btn_uyelik);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_uyelik;
        private System.Windows.Forms.Button btn_olcum;
        private System.Windows.Forms.Button btn_raporlar;
        private System.Windows.Forms.Button btn_odeme;
        private System.Windows.Forms.Label lb_hgmesaj;
    }
}