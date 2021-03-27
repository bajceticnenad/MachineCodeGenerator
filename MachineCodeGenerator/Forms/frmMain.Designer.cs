namespace MachineCodeGenerator.Forms
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.pnBarCode = new System.Windows.Forms.Panel();
            this.pbBarCode = new System.Windows.Forms.PictureBox();
            this.txtData = new System.Windows.Forms.TextBox();
            this.pnDataList = new System.Windows.Forms.Panel();
            this.rbQrCode = new System.Windows.Forms.RadioButton();
            this.rbBarCode = new System.Windows.Forms.RadioButton();
            this.btnGenerisanje = new System.Windows.Forms.Button();
            this.cbDisk = new System.Windows.Forms.CheckBox();
            this.btnUcitajFajl = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gbFormat = new System.Windows.Forms.GroupBox();
            this.rbBmp = new System.Windows.Forms.RadioButton();
            this.rbJpeg = new System.Windows.Forms.RadioButton();
            this.rbPng = new System.Windows.Forms.RadioButton();
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.fbd = new System.Windows.Forms.FolderBrowserDialog();
            this.rbGif = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtSeparator = new System.Windows.Forms.TextBox();
            this.pnBarCode.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBarCode)).BeginInit();
            this.pnDataList.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gbFormat.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnBarCode
            // 
            this.pnBarCode.BackColor = System.Drawing.Color.White;
            this.pnBarCode.Controls.Add(this.pbBarCode);
            this.pnBarCode.Location = new System.Drawing.Point(12, 12);
            this.pnBarCode.Name = "pnBarCode";
            this.pnBarCode.Size = new System.Drawing.Size(304, 304);
            this.pnBarCode.TabIndex = 0;
            // 
            // pbBarCode
            // 
            this.pbBarCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbBarCode.Location = new System.Drawing.Point(0, 0);
            this.pbBarCode.Name = "pbBarCode";
            this.pbBarCode.Size = new System.Drawing.Size(304, 304);
            this.pbBarCode.TabIndex = 0;
            this.pbBarCode.TabStop = false;
            // 
            // txtData
            // 
            this.txtData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtData.Location = new System.Drawing.Point(0, 0);
            this.txtData.Multiline = true;
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(955, 262);
            this.txtData.TabIndex = 1;
            // 
            // pnDataList
            // 
            this.pnDataList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnDataList.Controls.Add(this.txtData);
            this.pnDataList.Location = new System.Drawing.Point(12, 322);
            this.pnDataList.Name = "pnDataList";
            this.pnDataList.Size = new System.Drawing.Size(955, 262);
            this.pnDataList.TabIndex = 2;
            // 
            // rbQrCode
            // 
            this.rbQrCode.AutoSize = true;
            this.rbQrCode.Checked = true;
            this.rbQrCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rbQrCode.Location = new System.Drawing.Point(6, 19);
            this.rbQrCode.Name = "rbQrCode";
            this.rbQrCode.Size = new System.Drawing.Size(93, 24);
            this.rbQrCode.TabIndex = 3;
            this.rbQrCode.TabStop = true;
            this.rbQrCode.Text = "QR Code";
            this.rbQrCode.UseVisualStyleBackColor = true;
            // 
            // rbBarCode
            // 
            this.rbBarCode.AutoSize = true;
            this.rbBarCode.Enabled = false;
            this.rbBarCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rbBarCode.Location = new System.Drawing.Point(6, 49);
            this.rbBarCode.Name = "rbBarCode";
            this.rbBarCode.Size = new System.Drawing.Size(90, 24);
            this.rbBarCode.TabIndex = 4;
            this.rbBarCode.Text = "BarCode";
            this.rbBarCode.UseVisualStyleBackColor = true;
            // 
            // btnGenerisanje
            // 
            this.btnGenerisanje.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnGenerisanje.Image = ((System.Drawing.Image)(resources.GetObject("btnGenerisanje.Image")));
            this.btnGenerisanje.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGenerisanje.Location = new System.Drawing.Point(322, 257);
            this.btnGenerisanje.Name = "btnGenerisanje";
            this.btnGenerisanje.Size = new System.Drawing.Size(182, 59);
            this.btnGenerisanje.TabIndex = 5;
            this.btnGenerisanje.Text = "Generisanje";
            this.btnGenerisanje.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGenerisanje.UseVisualStyleBackColor = true;
            this.btnGenerisanje.Click += new System.EventHandler(this.BtnGenerisanje_Click);
            // 
            // cbDisk
            // 
            this.cbDisk.AutoSize = true;
            this.cbDisk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbDisk.Location = new System.Drawing.Point(322, 91);
            this.cbDisk.Name = "cbDisk";
            this.cbDisk.Size = new System.Drawing.Size(153, 24);
            this.cbDisk.TabIndex = 6;
            this.cbDisk.Text = "Sačuvaj na disk";
            this.cbDisk.UseVisualStyleBackColor = true;
            // 
            // btnUcitajFajl
            // 
            this.btnUcitajFajl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnUcitajFajl.Image = ((System.Drawing.Image)(resources.GetObject("btnUcitajFajl.Image")));
            this.btnUcitajFajl.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUcitajFajl.Location = new System.Drawing.Point(322, 192);
            this.btnUcitajFajl.Name = "btnUcitajFajl";
            this.btnUcitajFajl.Size = new System.Drawing.Size(182, 59);
            this.btnUcitajFajl.TabIndex = 7;
            this.btnUcitajFajl.Text = "Učitaj fajl";
            this.btnUcitajFajl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUcitajFajl.UseVisualStyleBackColor = true;
            this.btnUcitajFajl.Click += new System.EventHandler(this.BtnUcitajFajl_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbQrCode);
            this.groupBox1.Controls.Add(this.rbBarCode);
            this.groupBox1.Location = new System.Drawing.Point(322, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(182, 76);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kod";
            // 
            // gbFormat
            // 
            this.gbFormat.Controls.Add(this.rbGif);
            this.gbFormat.Controls.Add(this.rbBmp);
            this.gbFormat.Controls.Add(this.rbJpeg);
            this.gbFormat.Controls.Add(this.rbPng);
            this.gbFormat.Location = new System.Drawing.Point(510, 12);
            this.gbFormat.Name = "gbFormat";
            this.gbFormat.Size = new System.Drawing.Size(182, 233);
            this.gbFormat.TabIndex = 9;
            this.gbFormat.TabStop = false;
            this.gbFormat.Text = "Format";
            // 
            // rbBmp
            // 
            this.rbBmp.AutoSize = true;
            this.rbBmp.Checked = true;
            this.rbBmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rbBmp.Location = new System.Drawing.Point(6, 79);
            this.rbBmp.Name = "rbBmp";
            this.rbBmp.Size = new System.Drawing.Size(62, 24);
            this.rbBmp.TabIndex = 5;
            this.rbBmp.TabStop = true;
            this.rbBmp.Text = ".bmp";
            this.rbBmp.UseVisualStyleBackColor = true;
            // 
            // rbJpeg
            // 
            this.rbJpeg.AutoSize = true;
            this.rbJpeg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rbJpeg.Location = new System.Drawing.Point(6, 19);
            this.rbJpeg.Name = "rbJpeg";
            this.rbJpeg.Size = new System.Drawing.Size(94, 24);
            this.rbJpeg.TabIndex = 3;
            this.rbJpeg.Text = ".jpg; .jpeg";
            this.rbJpeg.UseVisualStyleBackColor = true;
            // 
            // rbPng
            // 
            this.rbPng.AutoSize = true;
            this.rbPng.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rbPng.Location = new System.Drawing.Point(6, 49);
            this.rbPng.Name = "rbPng";
            this.rbPng.Size = new System.Drawing.Size(58, 24);
            this.rbPng.TabIndex = 4;
            this.rbPng.Text = ".png";
            this.rbPng.UseVisualStyleBackColor = true;
            // 
            // ofd
            // 
            this.ofd.FileName = "ofd";
            // 
            // rbGif
            // 
            this.rbGif.AutoSize = true;
            this.rbGif.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rbGif.Location = new System.Drawing.Point(6, 109);
            this.rbGif.Name = "rbGif";
            this.rbGif.Size = new System.Drawing.Size(48, 24);
            this.rbGif.TabIndex = 6;
            this.rbGif.Text = ".gif";
            this.rbGif.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtSeparator);
            this.groupBox3.Location = new System.Drawing.Point(322, 121);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(182, 47);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Separator kodova";
            // 
            // txtSeparator
            // 
            this.txtSeparator.Location = new System.Drawing.Point(6, 19);
            this.txtSeparator.Name = "txtSeparator";
            this.txtSeparator.Size = new System.Drawing.Size(170, 20);
            this.txtSeparator.TabIndex = 0;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSalmon;
            this.ClientSize = new System.Drawing.Size(979, 596);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.gbFormat);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnUcitajFajl);
            this.Controls.Add(this.cbDisk);
            this.Controls.Add(this.btnGenerisanje);
            this.Controls.Add(this.pnDataList);
            this.Controls.Add(this.pnBarCode);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.Text = "Machine Code Generator";
            this.pnBarCode.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbBarCode)).EndInit();
            this.pnDataList.ResumeLayout(false);
            this.pnDataList.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbFormat.ResumeLayout(false);
            this.gbFormat.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnBarCode;
        private System.Windows.Forms.PictureBox pbBarCode;
        private System.Windows.Forms.TextBox txtData;
        private System.Windows.Forms.Panel pnDataList;
        private System.Windows.Forms.RadioButton rbQrCode;
        private System.Windows.Forms.RadioButton rbBarCode;
        private System.Windows.Forms.Button btnGenerisanje;
        private System.Windows.Forms.CheckBox cbDisk;
        private System.Windows.Forms.Button btnUcitajFajl;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox gbFormat;
        private System.Windows.Forms.RadioButton rbBmp;
        private System.Windows.Forms.RadioButton rbJpeg;
        private System.Windows.Forms.RadioButton rbPng;
        private System.Windows.Forms.OpenFileDialog ofd;
        private System.Windows.Forms.FolderBrowserDialog fbd;
        private System.Windows.Forms.RadioButton rbGif;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtSeparator;
    }
}