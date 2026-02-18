namespace VisualProgramingProje
{
    partial class FormOdeme
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
            this.components = new System.ComponentModel.Container();
            this.cmb_uyeler = new System.Windows.Forms.ComboBox();
            this.uyelerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.visual_ProjeDataSet = new VisualProgramingProje.Visual_ProjeDataSet();
            this.uyelerTableAdapter = new VisualProgramingProje.Visual_ProjeDataSetTableAdapters.UyelerTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.odemeIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kullaniciIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tutarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.odemeTarihiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.odemelerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.visual_ProjeDataSet1 = new VisualProgramingProje.Visual_ProjeDataSet1();
            this.odemelerTableAdapter = new VisualProgramingProje.Visual_ProjeDataSet1TableAdapters.OdemelerTableAdapter();
            this.btn_ekle = new System.Windows.Forms.Button();
            this.txt_kullaniciId = new System.Windows.Forms.TextBox();
            this.txt_tutar = new System.Windows.Forms.TextBox();
            this.dtp_odemetarihi = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_filtrele = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.uyelerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.visual_ProjeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.odemelerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.visual_ProjeDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmb_uyeler
            // 
            this.cmb_uyeler.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.uyelerBindingSource, "UyeId", true));
            this.cmb_uyeler.DataSource = this.uyelerBindingSource;
            this.cmb_uyeler.DisplayMember = "Isim";
            this.cmb_uyeler.FormattingEnabled = true;
            this.cmb_uyeler.Location = new System.Drawing.Point(40, 98);
            this.cmb_uyeler.Name = "cmb_uyeler";
            this.cmb_uyeler.Size = new System.Drawing.Size(121, 24);
            this.cmb_uyeler.TabIndex = 0;
            this.cmb_uyeler.ValueMember = "UyeId";
            this.cmb_uyeler.SelectedIndexChanged += new System.EventHandler(this.cmb_uyeler_SelectedIndexChanged);
            // 
            // uyelerBindingSource
            // 
            this.uyelerBindingSource.DataMember = "Uyeler";
            this.uyelerBindingSource.DataSource = this.visual_ProjeDataSet;
            // 
            // visual_ProjeDataSet
            // 
            this.visual_ProjeDataSet.DataSetName = "Visual_ProjeDataSet";
            this.visual_ProjeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // uyelerTableAdapter
            // 
            this.uyelerTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.odemeIdDataGridViewTextBoxColumn,
            this.kullaniciIdDataGridViewTextBoxColumn,
            this.tutarDataGridViewTextBoxColumn,
            this.odemeTarihiDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.odemelerBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(213, 98);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(553, 150);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // odemeIdDataGridViewTextBoxColumn
            // 
            this.odemeIdDataGridViewTextBoxColumn.DataPropertyName = "OdemeId";
            this.odemeIdDataGridViewTextBoxColumn.HeaderText = "OdemeId";
            this.odemeIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.odemeIdDataGridViewTextBoxColumn.Name = "odemeIdDataGridViewTextBoxColumn";
            this.odemeIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.odemeIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // kullaniciIdDataGridViewTextBoxColumn
            // 
            this.kullaniciIdDataGridViewTextBoxColumn.DataPropertyName = "KullaniciId";
            this.kullaniciIdDataGridViewTextBoxColumn.HeaderText = "KullaniciId";
            this.kullaniciIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kullaniciIdDataGridViewTextBoxColumn.Name = "kullaniciIdDataGridViewTextBoxColumn";
            this.kullaniciIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // tutarDataGridViewTextBoxColumn
            // 
            this.tutarDataGridViewTextBoxColumn.DataPropertyName = "Tutar";
            this.tutarDataGridViewTextBoxColumn.HeaderText = "Tutar";
            this.tutarDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tutarDataGridViewTextBoxColumn.Name = "tutarDataGridViewTextBoxColumn";
            this.tutarDataGridViewTextBoxColumn.Width = 125;
            // 
            // odemeTarihiDataGridViewTextBoxColumn
            // 
            this.odemeTarihiDataGridViewTextBoxColumn.DataPropertyName = "OdemeTarihi";
            this.odemeTarihiDataGridViewTextBoxColumn.HeaderText = "OdemeTarihi";
            this.odemeTarihiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.odemeTarihiDataGridViewTextBoxColumn.Name = "odemeTarihiDataGridViewTextBoxColumn";
            this.odemeTarihiDataGridViewTextBoxColumn.Width = 125;
            // 
            // odemelerBindingSource
            // 
            this.odemelerBindingSource.DataMember = "Odemeler";
            this.odemelerBindingSource.DataSource = this.visual_ProjeDataSet1;
            // 
            // visual_ProjeDataSet1
            // 
            this.visual_ProjeDataSet1.DataSetName = "Visual_ProjeDataSet1";
            this.visual_ProjeDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // odemelerTableAdapter
            // 
            this.odemelerTableAdapter.ClearBeforeFill = true;
            // 
            // btn_ekle
            // 
            this.btn_ekle.Location = new System.Drawing.Point(567, 375);
            this.btn_ekle.Name = "btn_ekle";
            this.btn_ekle.Size = new System.Drawing.Size(75, 23);
            this.btn_ekle.TabIndex = 2;
            this.btn_ekle.Text = "EKLE";
            this.btn_ekle.UseVisualStyleBackColor = true;
            this.btn_ekle.Click += new System.EventHandler(this.btn_ekle_Click);
            // 
            // txt_kullaniciId
            // 
            this.txt_kullaniciId.Enabled = false;
            this.txt_kullaniciId.Location = new System.Drawing.Point(95, 146);
            this.txt_kullaniciId.Name = "txt_kullaniciId";
            this.txt_kullaniciId.Size = new System.Drawing.Size(66, 22);
            this.txt_kullaniciId.TabIndex = 3;
            this.txt_kullaniciId.TextChanged += new System.EventHandler(this.txt_kullaniciId_TextChanged);
            // 
            // txt_tutar
            // 
            this.txt_tutar.Location = new System.Drawing.Point(181, 376);
            this.txt_tutar.Name = "txt_tutar";
            this.txt_tutar.Size = new System.Drawing.Size(100, 22);
            this.txt_tutar.TabIndex = 4;
            // 
            // dtp_odemetarihi
            // 
            this.dtp_odemetarihi.Location = new System.Drawing.Point(319, 376);
            this.dtp_odemetarihi.Name = "dtp_odemetarihi";
            this.dtp_odemetarihi.Size = new System.Drawing.Size(200, 22);
            this.dtp_odemetarihi.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Üye id :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(316, 348);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Ödeme Tarihi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(178, 348);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Ödeme Tutarı";
            // 
            // btn_filtrele
            // 
            this.btn_filtrele.Location = new System.Drawing.Point(40, 192);
            this.btn_filtrele.Name = "btn_filtrele";
            this.btn_filtrele.Size = new System.Drawing.Size(75, 23);
            this.btn_filtrele.TabIndex = 9;
            this.btn_filtrele.Text = "Filtrele";
            this.btn_filtrele.UseVisualStyleBackColor = true;
            this.btn_filtrele.Click += new System.EventHandler(this.btn_filtrele_Click);
            // 
            // btn_back
            // 
            this.btn_back.ImageKey = "(none)";
            this.btn_back.Location = new System.Drawing.Point(40, 26);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(98, 49);
            this.btn_back.TabIndex = 10;
            this.btn_back.Text = "Menüye Dön";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // FormOdeme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 449);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_filtrele);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtp_odemetarihi);
            this.Controls.Add(this.txt_tutar);
            this.Controls.Add(this.txt_kullaniciId);
            this.Controls.Add(this.btn_ekle);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cmb_uyeler);
            this.Name = "FormOdeme";
            this.Text = "FormOdeme";
            this.Load += new System.EventHandler(this.FormOdeme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.uyelerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.visual_ProjeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.odemelerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.visual_ProjeDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_uyeler;
        private Visual_ProjeDataSet visual_ProjeDataSet;
        private System.Windows.Forms.BindingSource uyelerBindingSource;
        private Visual_ProjeDataSetTableAdapters.UyelerTableAdapter uyelerTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Visual_ProjeDataSet1 visual_ProjeDataSet1;
        private System.Windows.Forms.BindingSource odemelerBindingSource;
        private Visual_ProjeDataSet1TableAdapters.OdemelerTableAdapter odemelerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn odemeIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kullaniciIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tutarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn odemeTarihiDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btn_ekle;
        private System.Windows.Forms.TextBox txt_kullaniciId;
        private System.Windows.Forms.TextBox txt_tutar;
        private System.Windows.Forms.DateTimePicker dtp_odemetarihi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_filtrele;
        private System.Windows.Forms.Button btn_back;
    }
}