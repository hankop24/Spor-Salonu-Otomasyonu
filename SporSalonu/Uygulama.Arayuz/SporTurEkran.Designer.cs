namespace Uygulama.Arayuz
{
    partial class SporTurEkran
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbUyelikTuru = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.numIndirimMiktari = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.btnUyelikTuruSil = new Guna.UI2.WinForms.Guna2Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnUyelikTuruKaydet = new Guna.UI2.WinForms.Guna2Button();
            this.btnUyelikTuruEkle = new Guna.UI2.WinForms.Guna2Button();
            this.txtUyelikTuru = new Guna.UI2.WinForms.Guna2TextBox();
            this.dgvSporListesi = new Guna.UI2.WinForms.Guna2DataGridView();
            this.guna2ContextMenuStrip1 = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            this.silToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.güncelleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.numAylikFiyat = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.btnEkle = new Guna.UI2.WinForms.Guna2Button();
            this.btnKaydet = new Guna.UI2.WinForms.Guna2Button();
            this.txtSporAdi = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtSporTuru = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblUyelikTurTemizle = new System.Windows.Forms.Label();
            this.lblSporTemizle = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numIndirimMiktari)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSporListesi)).BeginInit();
            this.guna2ContextMenuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAylikFiyat)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmbUyelikTuru);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.numIndirimMiktari);
            this.groupBox2.Controls.Add(this.btnUyelikTuruSil);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.btnUyelikTuruKaydet);
            this.groupBox2.Controls.Add(this.btnUyelikTuruEkle);
            this.groupBox2.Controls.Add(this.txtUyelikTuru);
            this.groupBox2.Location = new System.Drawing.Point(644, 61);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(422, 222);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            // 
            // cmbUyelikTuru
            // 
            this.cmbUyelikTuru.BackColor = System.Drawing.Color.Transparent;
            this.cmbUyelikTuru.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbUyelikTuru.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUyelikTuru.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbUyelikTuru.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbUyelikTuru.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbUyelikTuru.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbUyelikTuru.ItemHeight = 30;
            this.cmbUyelikTuru.Location = new System.Drawing.Point(165, 21);
            this.cmbUyelikTuru.Name = "cmbUyelikTuru";
            this.cmbUyelikTuru.Size = new System.Drawing.Size(222, 36);
            this.cmbUyelikTuru.TabIndex = 26;
            this.cmbUyelikTuru.SelectedIndexChanged += new System.EventHandler(this.cmbUyelikTuru_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.label4.Location = new System.Drawing.Point(238, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(163, 25);
            this.label4.TabIndex = 21;
            this.label4.Text = "İndirim Miktarı(%)";
            // 
            // numIndirimMiktari
            // 
            this.numIndirimMiktari.BackColor = System.Drawing.Color.Transparent;
            this.numIndirimMiktari.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.numIndirimMiktari.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.numIndirimMiktari.Location = new System.Drawing.Point(233, 100);
            this.numIndirimMiktari.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numIndirimMiktari.Name = "numIndirimMiktari";
            this.numIndirimMiktari.Size = new System.Drawing.Size(183, 40);
            this.numIndirimMiktari.TabIndex = 20;
            this.numIndirimMiktari.UpDownButtonFillColor = System.Drawing.Color.DodgerBlue;
            this.numIndirimMiktari.UpDownButtonForeColor = System.Drawing.Color.White;
            // 
            // btnUyelikTuruSil
            // 
            this.btnUyelikTuruSil.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnUyelikTuruSil.BorderRadius = 15;
            this.btnUyelikTuruSil.BorderThickness = 1;
            this.btnUyelikTuruSil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUyelikTuruSil.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUyelikTuruSil.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUyelikTuruSil.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUyelikTuruSil.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUyelikTuruSil.Enabled = false;
            this.btnUyelikTuruSil.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnUyelikTuruSil.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnUyelikTuruSil.ForeColor = System.Drawing.Color.White;
            this.btnUyelikTuruSil.Location = new System.Drawing.Point(283, 152);
            this.btnUyelikTuruSil.Name = "btnUyelikTuruSil";
            this.btnUyelikTuruSil.Size = new System.Drawing.Size(129, 45);
            this.btnUyelikTuruSil.TabIndex = 16;
            this.btnUyelikTuruSil.Text = "Sil";
            this.btnUyelikTuruSil.Click += new System.EventHandler(this.btnUyelikTuruSil_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(48, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 25);
            this.label2.TabIndex = 19;
            this.label2.Text = "Üyelik Türü";
            // 
            // btnUyelikTuruKaydet
            // 
            this.btnUyelikTuruKaydet.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnUyelikTuruKaydet.BorderRadius = 15;
            this.btnUyelikTuruKaydet.BorderThickness = 1;
            this.btnUyelikTuruKaydet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUyelikTuruKaydet.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUyelikTuruKaydet.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUyelikTuruKaydet.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUyelikTuruKaydet.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUyelikTuruKaydet.Enabled = false;
            this.btnUyelikTuruKaydet.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnUyelikTuruKaydet.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnUyelikTuruKaydet.ForeColor = System.Drawing.Color.White;
            this.btnUyelikTuruKaydet.Location = new System.Drawing.Point(148, 152);
            this.btnUyelikTuruKaydet.Name = "btnUyelikTuruKaydet";
            this.btnUyelikTuruKaydet.Size = new System.Drawing.Size(129, 45);
            this.btnUyelikTuruKaydet.TabIndex = 16;
            this.btnUyelikTuruKaydet.Text = "Kaydet";
            this.btnUyelikTuruKaydet.Click += new System.EventHandler(this.btnUyelikTuruKaydet_Click);
            // 
            // btnUyelikTuruEkle
            // 
            this.btnUyelikTuruEkle.Animated = true;
            this.btnUyelikTuruEkle.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnUyelikTuruEkle.BorderRadius = 15;
            this.btnUyelikTuruEkle.BorderThickness = 1;
            this.btnUyelikTuruEkle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUyelikTuruEkle.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUyelikTuruEkle.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUyelikTuruEkle.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUyelikTuruEkle.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUyelikTuruEkle.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnUyelikTuruEkle.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnUyelikTuruEkle.ForeColor = System.Drawing.Color.White;
            this.btnUyelikTuruEkle.Location = new System.Drawing.Point(13, 152);
            this.btnUyelikTuruEkle.Name = "btnUyelikTuruEkle";
            this.btnUyelikTuruEkle.Size = new System.Drawing.Size(129, 45);
            this.btnUyelikTuruEkle.TabIndex = 15;
            this.btnUyelikTuruEkle.Text = "Ekle";
            this.btnUyelikTuruEkle.Click += new System.EventHandler(this.btnUyelikTuruEkle_Click);
            // 
            // txtUyelikTuru
            // 
            this.txtUyelikTuru.BorderColor = System.Drawing.Color.Black;
            this.txtUyelikTuru.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUyelikTuru.DefaultText = "";
            this.txtUyelikTuru.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtUyelikTuru.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtUyelikTuru.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUyelikTuru.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUyelikTuru.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUyelikTuru.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtUyelikTuru.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUyelikTuru.Location = new System.Drawing.Point(7, 100);
            this.txtUyelikTuru.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtUyelikTuru.Name = "txtUyelikTuru";
            this.txtUyelikTuru.PasswordChar = '\0';
            this.txtUyelikTuru.PlaceholderText = "Üyelik Türü";
            this.txtUyelikTuru.SelectedText = "";
            this.txtUyelikTuru.Size = new System.Drawing.Size(183, 30);
            this.txtUyelikTuru.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtUyelikTuru.TabIndex = 17;
            // 
            // dgvSporListesi
            // 
            this.dgvSporListesi.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvSporListesi.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSporListesi.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSporListesi.ColumnHeadersHeight = 34;
            this.dgvSporListesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvSporListesi.ContextMenuStrip = this.guna2ContextMenuStrip1;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSporListesi.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvSporListesi.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvSporListesi.Location = new System.Drawing.Point(12, 300);
            this.dgvSporListesi.Name = "dgvSporListesi";
            this.dgvSporListesi.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSporListesi.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvSporListesi.RowHeadersVisible = false;
            this.dgvSporListesi.RowHeadersWidth = 51;
            this.dgvSporListesi.RowTemplate.Height = 24;
            this.dgvSporListesi.Size = new System.Drawing.Size(1054, 357);
            this.dgvSporListesi.TabIndex = 11;
            this.dgvSporListesi.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvSporListesi.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dgvSporListesi.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.dgvSporListesi.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvSporListesi.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvSporListesi.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvSporListesi.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvSporListesi.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.Red;
            this.dgvSporListesi.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvSporListesi.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dgvSporListesi.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvSporListesi.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvSporListesi.ThemeStyle.HeaderStyle.Height = 34;
            this.dgvSporListesi.ThemeStyle.ReadOnly = false;
            this.dgvSporListesi.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvSporListesi.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvSporListesi.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dgvSporListesi.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvSporListesi.ThemeStyle.RowsStyle.Height = 24;
            this.dgvSporListesi.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvSporListesi.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvSporListesi.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvSporListesi_CellMouseDown);
            // 
            // guna2ContextMenuStrip1
            // 
            this.guna2ContextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.guna2ContextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.silToolStripMenuItem,
            this.güncelleToolStripMenuItem});
            this.guna2ContextMenuStrip1.Name = "guna2ContextMenuStrip1";
            this.guna2ContextMenuStrip1.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.guna2ContextMenuStrip1.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro;
            this.guna2ContextMenuStrip1.RenderStyle.ColorTable = null;
            this.guna2ContextMenuStrip1.RenderStyle.RoundedEdges = true;
            this.guna2ContextMenuStrip1.RenderStyle.SelectionArrowColor = System.Drawing.Color.White;
            this.guna2ContextMenuStrip1.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.guna2ContextMenuStrip1.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.guna2ContextMenuStrip1.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro;
            this.guna2ContextMenuStrip1.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.guna2ContextMenuStrip1.Size = new System.Drawing.Size(136, 52);
            // 
            // silToolStripMenuItem
            // 
            this.silToolStripMenuItem.Name = "silToolStripMenuItem";
            this.silToolStripMenuItem.Size = new System.Drawing.Size(135, 24);
            this.silToolStripMenuItem.Text = "Sil";
            this.silToolStripMenuItem.Click += new System.EventHandler(this.silToolStripMenuItem_Click);
            // 
            // güncelleToolStripMenuItem
            // 
            this.güncelleToolStripMenuItem.Name = "güncelleToolStripMenuItem";
            this.güncelleToolStripMenuItem.Size = new System.Drawing.Size(135, 24);
            this.güncelleToolStripMenuItem.Text = "Güncelle";
            this.güncelleToolStripMenuItem.Click += new System.EventHandler(this.güncelleToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.numAylikFiyat);
            this.groupBox1.Controls.Add(this.btnEkle);
            this.groupBox1.Controls.Add(this.btnKaydet);
            this.groupBox1.Controls.Add(this.txtSporAdi);
            this.groupBox1.Controls.Add(this.txtSporTuru);
            this.groupBox1.Location = new System.Drawing.Point(12, 61);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(626, 222);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.label3.Location = new System.Drawing.Point(430, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 25);
            this.label3.TabIndex = 17;
            this.label3.Text = "Aylık Fiyat";
            // 
            // numAylikFiyat
            // 
            this.numAylikFiyat.BackColor = System.Drawing.Color.Transparent;
            this.numAylikFiyat.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.numAylikFiyat.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.numAylikFiyat.Location = new System.Drawing.Point(428, 65);
            this.numAylikFiyat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numAylikFiyat.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numAylikFiyat.Name = "numAylikFiyat";
            this.numAylikFiyat.Size = new System.Drawing.Size(183, 37);
            this.numAylikFiyat.TabIndex = 13;
            this.numAylikFiyat.UpDownButtonFillColor = System.Drawing.Color.DodgerBlue;
            this.numAylikFiyat.UpDownButtonForeColor = System.Drawing.Color.White;
            // 
            // btnEkle
            // 
            this.btnEkle.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnEkle.BorderRadius = 15;
            this.btnEkle.BorderThickness = 1;
            this.btnEkle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEkle.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEkle.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEkle.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEkle.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEkle.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnEkle.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnEkle.ForeColor = System.Drawing.Color.White;
            this.btnEkle.Location = new System.Drawing.Point(330, 138);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(145, 45);
            this.btnEkle.TabIndex = 16;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Animated = true;
            this.btnKaydet.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnKaydet.BorderRadius = 15;
            this.btnKaydet.BorderThickness = 1;
            this.btnKaydet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKaydet.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnKaydet.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnKaydet.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnKaydet.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnKaydet.Enabled = false;
            this.btnKaydet.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnKaydet.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnKaydet.ForeColor = System.Drawing.Color.White;
            this.btnKaydet.Location = new System.Drawing.Point(155, 138);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(145, 45);
            this.btnKaydet.TabIndex = 15;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // txtSporAdi
            // 
            this.txtSporAdi.BorderColor = System.Drawing.Color.DimGray;
            this.txtSporAdi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSporAdi.DefaultText = "";
            this.txtSporAdi.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSporAdi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSporAdi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSporAdi.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSporAdi.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSporAdi.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtSporAdi.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSporAdi.Location = new System.Drawing.Point(11, 68);
            this.txtSporAdi.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtSporAdi.Name = "txtSporAdi";
            this.txtSporAdi.PasswordChar = '\0';
            this.txtSporAdi.PlaceholderText = "Spor Adı";
            this.txtSporAdi.SelectedText = "";
            this.txtSporAdi.Size = new System.Drawing.Size(183, 30);
            this.txtSporAdi.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtSporAdi.TabIndex = 13;
            // 
            // txtSporTuru
            // 
            this.txtSporTuru.BorderColor = System.Drawing.Color.Black;
            this.txtSporTuru.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSporTuru.DefaultText = "";
            this.txtSporTuru.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSporTuru.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSporTuru.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSporTuru.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSporTuru.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSporTuru.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtSporTuru.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSporTuru.Location = new System.Drawing.Point(225, 68);
            this.txtSporTuru.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtSporTuru.Name = "txtSporTuru";
            this.txtSporTuru.PasswordChar = '\0';
            this.txtSporTuru.PlaceholderText = "Spor Türü";
            this.txtSporTuru.SelectedText = "";
            this.txtSporTuru.Size = new System.Drawing.Size(183, 30);
            this.txtSporTuru.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtSporTuru.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(379, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(278, 37);
            this.label1.TabIndex = 9;
            this.label1.Text = "Spor/Üyelik Ekranı";
            // 
            // lblUyelikTurTemizle
            // 
            this.lblUyelikTurTemizle.AutoSize = true;
            this.lblUyelikTurTemizle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblUyelikTurTemizle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUyelikTurTemizle.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblUyelikTurTemizle.Location = new System.Drawing.Point(995, 47);
            this.lblUyelikTurTemizle.Name = "lblUyelikTurTemizle";
            this.lblUyelikTurTemizle.Size = new System.Drawing.Size(67, 18);
            this.lblUyelikTurTemizle.TabIndex = 13;
            this.lblUyelikTurTemizle.Text = "Temizle";
            this.lblUyelikTurTemizle.Click += new System.EventHandler(this.lblUyelikTurTemizle_Click);
            // 
            // lblSporTemizle
            // 
            this.lblSporTemizle.AutoSize = true;
            this.lblSporTemizle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblSporTemizle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSporTemizle.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblSporTemizle.Location = new System.Drawing.Point(567, 47);
            this.lblSporTemizle.Name = "lblSporTemizle";
            this.lblSporTemizle.Size = new System.Drawing.Size(67, 18);
            this.lblSporTemizle.TabIndex = 13;
            this.lblSporTemizle.Text = "Temizle";
            this.lblSporTemizle.Click += new System.EventHandler(this.lblSporTemizle_Click);
            // 
            // SporTurEkran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1078, 714);
            this.Controls.Add(this.lblSporTemizle);
            this.Controls.Add(this.lblUyelikTurTemizle);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dgvSporListesi);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SporTurEkran";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SporTurEkran";
            this.Load += new System.EventHandler(this.SporTurEkran_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numIndirimMiktari)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSporListesi)).EndInit();
            this.guna2ContextMenuStrip1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAylikFiyat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private Guna.UI2.WinForms.Guna2Button btnUyelikTuruSil;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Button btnUyelikTuruKaydet;
        private Guna.UI2.WinForms.Guna2Button btnUyelikTuruEkle;
        private Guna.UI2.WinForms.Guna2TextBox txtUyelikTuru;
        private Guna.UI2.WinForms.Guna2DataGridView dgvSporListesi;
        private System.Windows.Forms.GroupBox groupBox1;
        private Guna.UI2.WinForms.Guna2Button btnEkle;
        private Guna.UI2.WinForms.Guna2Button btnKaydet;
        private Guna.UI2.WinForms.Guna2TextBox txtSporAdi;
        private Guna.UI2.WinForms.Guna2TextBox txtSporTuru;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2NumericUpDown numAylikFiyat;
        private Guna.UI2.WinForms.Guna2NumericUpDown numIndirimMiktari;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2ComboBox cmbUyelikTuru;
        private System.Windows.Forms.Label lblUyelikTurTemizle;
        private System.Windows.Forms.Label lblSporTemizle;
        private Guna.UI2.WinForms.Guna2ContextMenuStrip guna2ContextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem silToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem güncelleToolStripMenuItem;
    }
}