namespace Uygulama.Arayuz
{
    partial class AnaEkran
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnaEkran));
            this.lblKapat = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.flpEkran = new System.Windows.Forms.FlowLayoutPanel();
            this.pbAnaEkran = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnCikis = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnSpor = new System.Windows.Forms.Button();
            this.btnAntrenor = new System.Windows.Forms.Button();
            this.btnUye = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.flpEkran.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAnaEkran)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblKapat
            // 
            this.lblKapat.AutoSize = true;
            this.lblKapat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblKapat.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKapat.Location = new System.Drawing.Point(1350, 10);
            this.lblKapat.Name = "lblKapat";
            this.lblKapat.Size = new System.Drawing.Size(34, 32);
            this.lblKapat.TabIndex = 6;
            this.lblKapat.Text = "X";
            this.lblKapat.Click += new System.EventHandler(this.lblKapat_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.flpEkran);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(47, 49);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1311, 714);
            this.panel1.TabIndex = 4;
            // 
            // flpEkran
            // 
            this.flpEkran.BackColor = System.Drawing.Color.White;
            this.flpEkran.Controls.Add(this.pbAnaEkran);
            this.flpEkran.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpEkran.Location = new System.Drawing.Point(239, 0);
            this.flpEkran.Name = "flpEkran";
            this.flpEkran.Size = new System.Drawing.Size(1072, 714);
            this.flpEkran.TabIndex = 2;
            // 
            // pbAnaEkran
            // 
            this.pbAnaEkran.Image = ((System.Drawing.Image)(resources.GetObject("pbAnaEkran.Image")));
            this.pbAnaEkran.Location = new System.Drawing.Point(3, 3);
            this.pbAnaEkran.Name = "pbAnaEkran";
            this.pbAnaEkran.Size = new System.Drawing.Size(1066, 708);
            this.pbAnaEkran.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbAnaEkran.TabIndex = 0;
            this.pbAnaEkran.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkRed;
            this.panel3.Controls.Add(this.btnCikis);
            this.panel3.Controls.Add(this.btnSpor);
            this.panel3.Controls.Add(this.btnAntrenor);
            this.panel3.Controls.Add(this.btnUye);
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(239, 714);
            this.panel3.TabIndex = 1;
            // 
            // btnCikis
            // 
            this.btnCikis.BackColor = System.Drawing.Color.DarkRed;
            this.btnCikis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCikis.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCikis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCikis.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCikis.ImageKey = "logout.png";
            this.btnCikis.ImageList = this.imageList1;
            this.btnCikis.Location = new System.Drawing.Point(0, 657);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(244, 57);
            this.btnCikis.TabIndex = 5;
            this.btnCikis.Text = "Çıkış";
            this.btnCikis.UseVisualStyleBackColor = false;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "body-building.png");
            this.imageList1.Images.SetKeyName(1, "icons8-center-64.png");
            this.imageList1.Images.SetKeyName(2, "icons8-deadlift-50.png");
            this.imageList1.Images.SetKeyName(3, "logout.png");
            this.imageList1.Images.SetKeyName(4, "money.png");
            this.imageList1.Images.SetKeyName(5, "receptionist.png");
            this.imageList1.Images.SetKeyName(6, "trainer.png");
            // 
            // btnSpor
            // 
            this.btnSpor.BackColor = System.Drawing.Color.White;
            this.btnSpor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSpor.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSpor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSpor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSpor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSpor.ImageKey = "icons8-center-64.png";
            this.btnSpor.ImageList = this.imageList1;
            this.btnSpor.Location = new System.Drawing.Point(44, 364);
            this.btnSpor.Name = "btnSpor";
            this.btnSpor.Size = new System.Drawing.Size(200, 57);
            this.btnSpor.TabIndex = 4;
            this.btnSpor.Text = "Sporlar";
            this.btnSpor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSpor.UseVisualStyleBackColor = false;
            this.btnSpor.Click += new System.EventHandler(this.btnSpor_Click);
            this.btnSpor.MouseEnter += new System.EventHandler(this.btnSpor_MouseEnter);
            this.btnSpor.MouseLeave += new System.EventHandler(this.btnSpor_MouseLeave);
            // 
            // btnAntrenor
            // 
            this.btnAntrenor.BackColor = System.Drawing.Color.White;
            this.btnAntrenor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAntrenor.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAntrenor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAntrenor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAntrenor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAntrenor.ImageKey = "trainer.png";
            this.btnAntrenor.ImageList = this.imageList1;
            this.btnAntrenor.Location = new System.Drawing.Point(44, 238);
            this.btnAntrenor.Name = "btnAntrenor";
            this.btnAntrenor.Size = new System.Drawing.Size(200, 57);
            this.btnAntrenor.TabIndex = 4;
            this.btnAntrenor.Text = "Antrenör";
            this.btnAntrenor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAntrenor.UseVisualStyleBackColor = false;
            this.btnAntrenor.Click += new System.EventHandler(this.btnAntrenor_Click);
            this.btnAntrenor.MouseEnter += new System.EventHandler(this.btnAntrenor_MouseEnter);
            this.btnAntrenor.MouseLeave += new System.EventHandler(this.btnAntrenor_MouseLeave);
            // 
            // btnUye
            // 
            this.btnUye.BackColor = System.Drawing.Color.White;
            this.btnUye.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUye.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnUye.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUye.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUye.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUye.ImageKey = "icons8-deadlift-50.png";
            this.btnUye.ImageList = this.imageList1;
            this.btnUye.Location = new System.Drawing.Point(44, 301);
            this.btnUye.Name = "btnUye";
            this.btnUye.Size = new System.Drawing.Size(200, 57);
            this.btnUye.TabIndex = 3;
            this.btnUye.Text = "Üyeler";
            this.btnUye.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUye.UseVisualStyleBackColor = false;
            this.btnUye.Click += new System.EventHandler(this.btnUye_Click);
            this.btnUye.MouseEnter += new System.EventHandler(this.btnUye_MouseEnter);
            this.btnUye.MouseLeave += new System.EventHandler(this.btnUye_MouseLeave);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(18, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(200, 173);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(14, 25);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(266, 768);
            this.panel2.TabIndex = 5;
            // 
            // AnaEkran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.ClientSize = new System.Drawing.Size(1399, 803);
            this.Controls.Add(this.lblKapat);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AnaEkran";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AnaEkran";
            this.panel1.ResumeLayout(false);
            this.flpEkran.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbAnaEkran)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblKapat;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flpEkran;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Button btnSpor;
        private System.Windows.Forms.Button btnAntrenor;
        private System.Windows.Forms.Button btnUye;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox pbAnaEkran;
    }
}