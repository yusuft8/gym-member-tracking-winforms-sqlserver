namespace VisualProgramingProje
{
    partial class FormUye
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
            this.btn_yeniUye = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.uyeIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ısimDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soyisimDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kayitTarihiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ekleyenKullaniciDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uyelikBitisTarihiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uyelerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.visual_ProjeDataSet = new VisualProgramingProje.Visual_ProjeDataSet();
            this.uyelerTableAdapter = new VisualProgramingProje.Visual_ProjeDataSetTableAdapters.UyelerTableAdapter();
            this.btn_yenile = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uyelerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.visual_ProjeDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_yeniUye
            // 
            this.btn_yeniUye.Location = new System.Drawing.Point(190, 405);
            this.btn_yeniUye.Name = "btn_yeniUye";
            this.btn_yeniUye.Size = new System.Drawing.Size(130, 81);
            this.btn_yeniUye.TabIndex = 1;
            this.btn_yeniUye.Text = "YENİ ÜYE EKLE";
            this.btn_yeniUye.UseVisualStyleBackColor = true;
            this.btn_yeniUye.Click += new System.EventHandler(this.btn_yeniUye_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.uyeIdDataGridViewTextBoxColumn,
            this.ısimDataGridViewTextBoxColumn,
            this.soyisimDataGridViewTextBoxColumn,
            this.telefonNoDataGridViewTextBoxColumn,
            this.kayitTarihiDataGridViewTextBoxColumn,
            this.ekleyenKullaniciDataGridViewTextBoxColumn,
            this.uyelikBitisTarihiDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.uyelerBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(23, 68);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(466, 254);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // uyeIdDataGridViewTextBoxColumn
            // 
            this.uyeIdDataGridViewTextBoxColumn.DataPropertyName = "UyeId";
            this.uyeIdDataGridViewTextBoxColumn.HeaderText = "UyeId";
            this.uyeIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.uyeIdDataGridViewTextBoxColumn.Name = "uyeIdDataGridViewTextBoxColumn";
            this.uyeIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.uyeIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // ısimDataGridViewTextBoxColumn
            // 
            this.ısimDataGridViewTextBoxColumn.DataPropertyName = "Isim";
            this.ısimDataGridViewTextBoxColumn.HeaderText = "Isim";
            this.ısimDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ısimDataGridViewTextBoxColumn.Name = "ısimDataGridViewTextBoxColumn";
            this.ısimDataGridViewTextBoxColumn.Width = 125;
            // 
            // soyisimDataGridViewTextBoxColumn
            // 
            this.soyisimDataGridViewTextBoxColumn.DataPropertyName = "Soyisim";
            this.soyisimDataGridViewTextBoxColumn.HeaderText = "Soyisim";
            this.soyisimDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.soyisimDataGridViewTextBoxColumn.Name = "soyisimDataGridViewTextBoxColumn";
            this.soyisimDataGridViewTextBoxColumn.Width = 125;
            // 
            // telefonNoDataGridViewTextBoxColumn
            // 
            this.telefonNoDataGridViewTextBoxColumn.DataPropertyName = "TelefonNo";
            this.telefonNoDataGridViewTextBoxColumn.HeaderText = "TelefonNo";
            this.telefonNoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.telefonNoDataGridViewTextBoxColumn.Name = "telefonNoDataGridViewTextBoxColumn";
            this.telefonNoDataGridViewTextBoxColumn.Width = 125;
            // 
            // kayitTarihiDataGridViewTextBoxColumn
            // 
            this.kayitTarihiDataGridViewTextBoxColumn.DataPropertyName = "KayitTarihi";
            this.kayitTarihiDataGridViewTextBoxColumn.HeaderText = "KayitTarihi";
            this.kayitTarihiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kayitTarihiDataGridViewTextBoxColumn.Name = "kayitTarihiDataGridViewTextBoxColumn";
            this.kayitTarihiDataGridViewTextBoxColumn.Width = 125;
            // 
            // ekleyenKullaniciDataGridViewTextBoxColumn
            // 
            this.ekleyenKullaniciDataGridViewTextBoxColumn.DataPropertyName = "EkleyenKullanici";
            this.ekleyenKullaniciDataGridViewTextBoxColumn.HeaderText = "EkleyenKullanici";
            this.ekleyenKullaniciDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ekleyenKullaniciDataGridViewTextBoxColumn.Name = "ekleyenKullaniciDataGridViewTextBoxColumn";
            this.ekleyenKullaniciDataGridViewTextBoxColumn.Width = 125;
            // 
            // uyelikBitisTarihiDataGridViewTextBoxColumn
            // 
            this.uyelikBitisTarihiDataGridViewTextBoxColumn.DataPropertyName = "UyelikBitisTarihi";
            this.uyelikBitisTarihiDataGridViewTextBoxColumn.HeaderText = "UyelikBitisTarihi";
            this.uyelikBitisTarihiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.uyelikBitisTarihiDataGridViewTextBoxColumn.Name = "uyelikBitisTarihiDataGridViewTextBoxColumn";
            this.uyelikBitisTarihiDataGridViewTextBoxColumn.Width = 125;
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
            // btn_yenile
            // 
            this.btn_yenile.Location = new System.Drawing.Point(190, 338);
            this.btn_yenile.Name = "btn_yenile";
            this.btn_yenile.Size = new System.Drawing.Size(130, 41);
            this.btn_yenile.TabIndex = 3;
            this.btn_yenile.Text = "Güncelle";
            this.btn_yenile.UseVisualStyleBackColor = true;
            this.btn_yenile.Click += new System.EventHandler(this.btn_yenile_Click);
            // 
            // btn_back
            // 
            this.btn_back.ImageKey = "(none)";
            this.btn_back.Location = new System.Drawing.Point(23, 13);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(98, 49);
            this.btn_back.TabIndex = 4;
            this.btn_back.Text = "Menüye Dön";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // FormUye
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 520);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_yenile);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_yeniUye);
            this.Name = "FormUye";
            this.Text = "FormUye";
            this.Load += new System.EventHandler(this.FormUye_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uyelerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.visual_ProjeDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Visual_ProjeDataSet visual_ProjeDataSet;
        private System.Windows.Forms.BindingSource uyelerBindingSource;
        private Visual_ProjeDataSetTableAdapters.UyelerTableAdapter uyelerTableAdapter;
        private System.Windows.Forms.Button btn_yeniUye;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_yenile;
        private System.Windows.Forms.DataGridViewTextBoxColumn uyeIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ısimDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soyisimDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kayitTarihiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ekleyenKullaniciDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uyelikBitisTarihiDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btn_back;
    }
}