namespace VisualProgramingProje
{
    partial class FormRaporlar
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.btn_back = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.olcumIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uyeIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ağırlıkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.olcumlerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.visual_ProjeDataSetolcumler = new VisualProgramingProje.Visual_ProjeDataSetolcumler();
            this.btn_txt = new System.Windows.Forms.Button();
            this.cmb_uyeler = new System.Windows.Forms.ComboBox();
            this.uyelerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.visual_ProjeDataSet = new VisualProgramingProje.Visual_ProjeDataSet();
            this.uyelerTableAdapter = new VisualProgramingProje.Visual_ProjeDataSetTableAdapters.UyelerTableAdapter();
            this.btn_sonuc = new System.Windows.Forms.Button();
            this.visual_ProjeDataSet1 = new VisualProgramingProje.Visual_ProjeDataSet1();
            this.visualProjeDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.olcumlerTableAdapter = new VisualProgramingProje.Visual_ProjeDataSetolcumlerTableAdapters.OlcumlerTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.olcumlerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.visual_ProjeDataSetolcumler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uyelerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.visual_ProjeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.visual_ProjeDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.visualProjeDataSet1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_back
            // 
            this.btn_back.ImageKey = "(none)";
            this.btn_back.Location = new System.Drawing.Point(12, 12);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(98, 49);
            this.btn_back.TabIndex = 11;
            this.btn_back.Text = "Menüye Dön";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(52, 41);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(768, 337);
            this.chart1.TabIndex = 12;
            this.chart1.Text = "Üye Ölçüm Grafiği";
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.btn_txt);
            this.groupBox1.Controls.Add(this.chart1);
            this.groupBox1.Location = new System.Drawing.Point(221, 80);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(907, 646);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            this.groupBox1.Visible = false;
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
            this.dataGridView1.Location = new System.Drawing.Point(192, 387);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(497, 150);
            this.dataGridView1.TabIndex = 14;
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
            this.ağırlıkDataGridViewTextBoxColumn.HeaderText = "Ağırlık";
            this.ağırlıkDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ağırlıkDataGridViewTextBoxColumn.Name = "ağırlıkDataGridViewTextBoxColumn";
            this.ağırlıkDataGridViewTextBoxColumn.Width = 125;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
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
            // btn_txt
            // 
            this.btn_txt.Location = new System.Drawing.Point(376, 560);
            this.btn_txt.Name = "btn_txt";
            this.btn_txt.Size = new System.Drawing.Size(121, 59);
            this.btn_txt.TabIndex = 13;
            this.btn_txt.Text = "Verileri Çıktı Al";
            this.btn_txt.UseVisualStyleBackColor = true;
            this.btn_txt.Click += new System.EventHandler(this.btn_txt_Click);
            // 
            // cmb_uyeler
            // 
            this.cmb_uyeler.DataSource = this.uyelerBindingSource;
            this.cmb_uyeler.DisplayMember = "UyeId";
            this.cmb_uyeler.FormattingEnabled = true;
            this.cmb_uyeler.Location = new System.Drawing.Point(440, 245);
            this.cmb_uyeler.Name = "cmb_uyeler";
            this.cmb_uyeler.Size = new System.Drawing.Size(121, 24);
            this.cmb_uyeler.TabIndex = 14;
            this.cmb_uyeler.ValueMember = "UyeId";
            this.cmb_uyeler.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
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
            // btn_sonuc
            // 
            this.btn_sonuc.Location = new System.Drawing.Point(626, 222);
            this.btn_sonuc.Name = "btn_sonuc";
            this.btn_sonuc.Size = new System.Drawing.Size(108, 69);
            this.btn_sonuc.TabIndex = 15;
            this.btn_sonuc.Text = "Sonuçları Göster";
            this.btn_sonuc.UseVisualStyleBackColor = true;
            this.btn_sonuc.Click += new System.EventHandler(this.btn_sonuc_Click);
            // 
            // visual_ProjeDataSet1
            // 
            this.visual_ProjeDataSet1.DataSetName = "Visual_ProjeDataSet1";
            this.visual_ProjeDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // visualProjeDataSet1BindingSource
            // 
            this.visualProjeDataSet1BindingSource.DataSource = this.visual_ProjeDataSet1;
            this.visualProjeDataSet1BindingSource.Position = 0;
            // 
            // olcumlerTableAdapter
            // 
            this.olcumlerTableAdapter.ClearBeforeFill = true;
            // 
            // FormRaporlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1686, 853);
            this.Controls.Add(this.btn_sonuc);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.cmb_uyeler);
            this.Name = "FormRaporlar";
            this.Text = "FormRaporlar";
            this.Load += new System.EventHandler(this.FormRaporlar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.olcumlerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.visual_ProjeDataSetolcumler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uyelerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.visual_ProjeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.visual_ProjeDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.visualProjeDataSet1BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmb_uyeler;
        private Visual_ProjeDataSet visual_ProjeDataSet;
        private System.Windows.Forms.BindingSource uyelerBindingSource;
        private Visual_ProjeDataSetTableAdapters.UyelerTableAdapter uyelerTableAdapter;
        private System.Windows.Forms.Button btn_sonuc;
        private System.Windows.Forms.Button btn_txt;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource visualProjeDataSet1BindingSource;
        private Visual_ProjeDataSet1 visual_ProjeDataSet1;
        private Visual_ProjeDataSetolcumler visual_ProjeDataSetolcumler;
        private System.Windows.Forms.BindingSource olcumlerBindingSource;
        private Visual_ProjeDataSetolcumlerTableAdapters.OlcumlerTableAdapter olcumlerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn olcumIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uyeIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ağırlıkDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
    }
}