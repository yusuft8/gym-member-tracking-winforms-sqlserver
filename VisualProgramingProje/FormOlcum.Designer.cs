namespace VisualProgramingProje
{
    partial class FormOlcum
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
            this.btn_filtrele = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.olcumIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uyeIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ağırlıkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.olcumlerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.visual_ProjeDataSetolcumler = new VisualProgramingProje.Visual_ProjeDataSetolcumler();
            this.cmb_uyeler = new System.Windows.Forms.ComboBox();
            this.uyelerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.visualProjeDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.visual_ProjeDataSet = new VisualProgramingProje.Visual_ProjeDataSet();
            this.olcumlerTableAdapter = new VisualProgramingProje.Visual_ProjeDataSetolcumlerTableAdapters.OlcumlerTableAdapter();
            this.btn_ekle = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_kilo = new System.Windows.Forms.TextBox();
            this.dtp_kayitTarihi = new System.Windows.Forms.DateTimePicker();
            this.btn_back = new System.Windows.Forms.Button();
            this.uyelerTableAdapter = new VisualProgramingProje.Visual_ProjeDataSetTableAdapters.UyelerTableAdapter();
            this.txt_kullaniciId = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.olcumlerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.visual_ProjeDataSetolcumler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uyelerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.visualProjeDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.visual_ProjeDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_filtrele
            // 
            this.btn_filtrele.Location = new System.Drawing.Point(13, 225);
            this.btn_filtrele.Name = "btn_filtrele";
            this.btn_filtrele.Size = new System.Drawing.Size(75, 23);
            this.btn_filtrele.TabIndex = 14;
            this.btn_filtrele.Text = "Filtrele";
            this.btn_filtrele.UseVisualStyleBackColor = true;
            this.btn_filtrele.Click += new System.EventHandler(this.btn_filtrele_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 182);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "Üye id :";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.olcumIdDataGridViewTextBoxColumn,
            this.uyeIdDataGridViewTextBoxColumn,
            this.ağırlıkDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.olcumlerBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(191, 118);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(697, 150);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // olcumIdDataGridViewTextBoxColumn
            // 
            this.olcumIdDataGridViewTextBoxColumn.DataPropertyName = "OlcumId";
            this.olcumIdDataGridViewTextBoxColumn.HeaderText = "OlcumId";
            this.olcumIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.olcumIdDataGridViewTextBoxColumn.Name = "olcumIdDataGridViewTextBoxColumn";
            this.olcumIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.olcumIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // uyeIdDataGridViewTextBoxColumn
            // 
            this.uyeIdDataGridViewTextBoxColumn.DataPropertyName = "UyeId";
            this.uyeIdDataGridViewTextBoxColumn.HeaderText = "UyeId";
            this.uyeIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.uyeIdDataGridViewTextBoxColumn.Name = "uyeIdDataGridViewTextBoxColumn";
            this.uyeIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // ağırlıkDataGridViewTextBoxColumn
            // 
            this.ağırlıkDataGridViewTextBoxColumn.DataPropertyName = "Ağırlık";
            this.ağırlıkDataGridViewTextBoxColumn.HeaderText = "Kilo";
            this.ağırlıkDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ağırlıkDataGridViewTextBoxColumn.Name = "ağırlıkDataGridViewTextBoxColumn";
            this.ağırlıkDataGridViewTextBoxColumn.Width = 125;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Kayıt Tarihi";
            this.dateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.Width = 125;
            // 
            // olcumlerBindingSource
            // 
            this.olcumlerBindingSource.DataMember = "Olcumler";
            this.olcumlerBindingSource.DataSource = this.visual_ProjeDataSetolcumler;
            // 
            // visual_ProjeDataSetolcumler
            // 
            this.visual_ProjeDataSetolcumler.DataSetName = "Visual_ProjeDataSetolcumler";
            this.visual_ProjeDataSetolcumler.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cmb_uyeler
            // 
            this.cmb_uyeler.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.uyelerBindingSource, "UyeId", true));
            this.cmb_uyeler.DataSource = this.uyelerBindingSource;
            this.cmb_uyeler.DisplayMember = "UyeId";
            this.cmb_uyeler.FormattingEnabled = true;
            this.cmb_uyeler.Location = new System.Drawing.Point(13, 131);
            this.cmb_uyeler.Name = "cmb_uyeler";
            this.cmb_uyeler.Size = new System.Drawing.Size(121, 24);
            this.cmb_uyeler.TabIndex = 10;
            this.cmb_uyeler.ValueMember = "UyeId";
            this.cmb_uyeler.SelectedIndexChanged += new System.EventHandler(this.cmb_uyeler_SelectedIndexChanged);
            // 
            // uyelerBindingSource
            // 
            this.uyelerBindingSource.DataMember = "Uyeler";
            this.uyelerBindingSource.DataSource = this.visualProjeDataSetBindingSource;
            // 
            // visualProjeDataSetBindingSource
            // 
            this.visualProjeDataSetBindingSource.DataSource = this.visual_ProjeDataSet;
            this.visualProjeDataSetBindingSource.Position = 0;
            // 
            // visual_ProjeDataSet
            // 
            this.visual_ProjeDataSet.DataSetName = "Visual_ProjeDataSet";
            this.visual_ProjeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // olcumlerTableAdapter
            // 
            this.olcumlerTableAdapter.ClearBeforeFill = true;
            // 
            // btn_ekle
            // 
            this.btn_ekle.Location = new System.Drawing.Point(758, 402);
            this.btn_ekle.Name = "btn_ekle";
            this.btn_ekle.Size = new System.Drawing.Size(75, 23);
            this.btn_ekle.TabIndex = 15;
            this.btn_ekle.Text = "EKLE";
            this.btn_ekle.UseVisualStyleBackColor = true;
            this.btn_ekle.Click += new System.EventHandler(this.btn_ekle_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(280, 371);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 16);
            this.label2.TabIndex = 16;
            this.label2.Text = "Güncel kilo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(493, 371);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 16);
            this.label3.TabIndex = 17;
            this.label3.Text = "Kayıt Tarihi";
            // 
            // txt_kilo
            // 
            this.txt_kilo.Location = new System.Drawing.Point(283, 401);
            this.txt_kilo.Name = "txt_kilo";
            this.txt_kilo.Size = new System.Drawing.Size(100, 22);
            this.txt_kilo.TabIndex = 18;
            // 
            // dtp_kayitTarihi
            // 
            this.dtp_kayitTarihi.Location = new System.Drawing.Point(496, 400);
            this.dtp_kayitTarihi.Name = "dtp_kayitTarihi";
            this.dtp_kayitTarihi.Size = new System.Drawing.Size(200, 22);
            this.dtp_kayitTarihi.TabIndex = 19;
            // 
            // btn_back
            // 
            this.btn_back.ImageKey = "(none)";
            this.btn_back.Location = new System.Drawing.Point(15, 12);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(98, 49);
            this.btn_back.TabIndex = 20;
            this.btn_back.Text = "Menüye Dön";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // uyelerTableAdapter
            // 
            this.uyelerTableAdapter.ClearBeforeFill = true;
            // 
            // txt_kullaniciId
            // 
            this.txt_kullaniciId.Enabled = false;
            this.txt_kullaniciId.Location = new System.Drawing.Point(68, 182);
            this.txt_kullaniciId.Name = "txt_kullaniciId";
            this.txt_kullaniciId.Size = new System.Drawing.Size(100, 22);
            this.txt_kullaniciId.TabIndex = 21;
            // 
            // FormOlcum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 492);
            this.Controls.Add(this.txt_kullaniciId);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.dtp_kayitTarihi);
            this.Controls.Add(this.txt_kilo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_ekle);
            this.Controls.Add(this.btn_filtrele);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cmb_uyeler);
            this.Name = "FormOlcum";
            this.Text = "FormOlcum";
            this.Load += new System.EventHandler(this.FormOlcum_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.olcumlerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.visual_ProjeDataSetolcumler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uyelerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.visualProjeDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.visual_ProjeDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_filtrele;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cmb_uyeler;
        private Visual_ProjeDataSetolcumler visual_ProjeDataSetolcumler;
        private System.Windows.Forms.BindingSource olcumlerBindingSource;
        private Visual_ProjeDataSetolcumlerTableAdapters.OlcumlerTableAdapter olcumlerTableAdapter;
        private System.Windows.Forms.Button btn_ekle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_kilo;
        private System.Windows.Forms.DateTimePicker dtp_kayitTarihi;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.BindingSource visualProjeDataSetBindingSource;
        private Visual_ProjeDataSet visual_ProjeDataSet;
        private System.Windows.Forms.BindingSource uyelerBindingSource;
        private Visual_ProjeDataSetTableAdapters.UyelerTableAdapter uyelerTableAdapter;
        private System.Windows.Forms.TextBox txt_kullaniciId;
        private System.Windows.Forms.DataGridViewTextBoxColumn olcumIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uyeIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ağırlıkDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
    }
}