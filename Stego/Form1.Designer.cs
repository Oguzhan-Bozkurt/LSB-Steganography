namespace Stego
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.MetinTBOX = new System.Windows.Forms.RichTextBox();
            this.ResimPBOX = new System.Windows.Forms.PictureBox();
            this.ResimSecBTN = new System.Windows.Forms.Button();
            this.GizleBTN = new System.Windows.Forms.Button();
            this.CozBTN = new System.Windows.Forms.Button();
            this.ResimKaydetBTN = new System.Windows.Forms.Button();
            this.SifreleBTN = new System.Windows.Forms.Button();
            this.SifreCBOX = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.MetinSecBTN = new System.Windows.Forms.Button();
            this.MetinKaydetBTN = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.TextSizeLBL = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ResimPBOX)).BeginInit();
            this.SuspendLayout();
            // 
            // MetinTBOX
            // 
            this.MetinTBOX.Location = new System.Drawing.Point(12, 105);
            this.MetinTBOX.Name = "MetinTBOX";
            this.MetinTBOX.Size = new System.Drawing.Size(250, 305);
            this.MetinTBOX.TabIndex = 0;
            this.MetinTBOX.Text = "";
            this.MetinTBOX.TextChanged += new System.EventHandler(this.MetinTBOX_TextChanged);
            // 
            // ResimPBOX
            // 
            this.ResimPBOX.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ResimPBOX.Location = new System.Drawing.Point(268, 105);
            this.ResimPBOX.Name = "ResimPBOX";
            this.ResimPBOX.Size = new System.Drawing.Size(250, 305);
            this.ResimPBOX.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ResimPBOX.TabIndex = 1;
            this.ResimPBOX.TabStop = false;
            // 
            // ResimSecBTN
            // 
            this.ResimSecBTN.Location = new System.Drawing.Point(12, 12);
            this.ResimSecBTN.Name = "ResimSecBTN";
            this.ResimSecBTN.Size = new System.Drawing.Size(87, 33);
            this.ResimSecBTN.TabIndex = 2;
            this.ResimSecBTN.Text = "Resim Seç";
            this.ResimSecBTN.UseVisualStyleBackColor = true;
            this.ResimSecBTN.Click += new System.EventHandler(this.ResimSecBTN_Click);
            // 
            // GizleBTN
            // 
            this.GizleBTN.Enabled = false;
            this.GizleBTN.Location = new System.Drawing.Point(12, 51);
            this.GizleBTN.Name = "GizleBTN";
            this.GizleBTN.Size = new System.Drawing.Size(87, 33);
            this.GizleBTN.TabIndex = 3;
            this.GizleBTN.Text = "Gizle";
            this.GizleBTN.UseVisualStyleBackColor = true;
            this.GizleBTN.Click += new System.EventHandler(this.GizleBTN_Click);
            // 
            // CozBTN
            // 
            this.CozBTN.Enabled = false;
            this.CozBTN.Location = new System.Drawing.Point(105, 51);
            this.CozBTN.Name = "CozBTN";
            this.CozBTN.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.CozBTN.Size = new System.Drawing.Size(87, 33);
            this.CozBTN.TabIndex = 4;
            this.CozBTN.Text = "Çöz";
            this.CozBTN.UseVisualStyleBackColor = true;
            this.CozBTN.Click += new System.EventHandler(this.CozBTN_Click);
            // 
            // ResimKaydetBTN
            // 
            this.ResimKaydetBTN.Enabled = false;
            this.ResimKaydetBTN.Location = new System.Drawing.Point(105, 12);
            this.ResimKaydetBTN.Name = "ResimKaydetBTN";
            this.ResimKaydetBTN.Size = new System.Drawing.Size(87, 33);
            this.ResimKaydetBTN.TabIndex = 5;
            this.ResimKaydetBTN.Text = "Resim Kaydet";
            this.ResimKaydetBTN.UseVisualStyleBackColor = true;
            this.ResimKaydetBTN.Click += new System.EventHandler(this.ResimKaydetBTN_Click);
            // 
            // SifreleBTN
            // 
            this.SifreleBTN.Enabled = false;
            this.SifreleBTN.Location = new System.Drawing.Point(291, 51);
            this.SifreleBTN.Name = "SifreleBTN";
            this.SifreleBTN.Size = new System.Drawing.Size(87, 33);
            this.SifreleBTN.TabIndex = 6;
            this.SifreleBTN.Text = "Şifrele";
            this.SifreleBTN.UseVisualStyleBackColor = true;
            this.SifreleBTN.Click += new System.EventHandler(this.SifreleBTN_Click);
            // 
            // SifreCBOX
            // 
            this.SifreCBOX.Enabled = false;
            this.SifreCBOX.FormattingEnabled = true;
            this.SifreCBOX.Items.AddRange(new object[] {
            "Şifresiz",
            "MD5"});
            this.SifreCBOX.Location = new System.Drawing.Point(198, 61);
            this.SifreCBOX.Name = "SifreCBOX";
            this.SifreCBOX.Size = new System.Drawing.Size(87, 23);
            this.SifreCBOX.TabIndex = 7;
            this.SifreCBOX.SelectedIndexChanged += new System.EventHandler(this.SifreCBOX_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(198, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Şifreleme";
            // 
            // MetinSecBTN
            // 
            this.MetinSecBTN.Enabled = false;
            this.MetinSecBTN.Location = new System.Drawing.Point(198, 12);
            this.MetinSecBTN.Name = "MetinSecBTN";
            this.MetinSecBTN.Size = new System.Drawing.Size(87, 33);
            this.MetinSecBTN.TabIndex = 9;
            this.MetinSecBTN.Text = "Metin Seç";
            this.MetinSecBTN.UseVisualStyleBackColor = true;
            this.MetinSecBTN.Click += new System.EventHandler(this.MetinSecBTN_Click);
            // 
            // MetinKaydetBTN
            // 
            this.MetinKaydetBTN.Enabled = false;
            this.MetinKaydetBTN.Location = new System.Drawing.Point(291, 12);
            this.MetinKaydetBTN.Name = "MetinKaydetBTN";
            this.MetinKaydetBTN.Size = new System.Drawing.Size(87, 33);
            this.MetinKaydetBTN.TabIndex = 10;
            this.MetinKaydetBTN.Text = "Metin Kaydet";
            this.MetinKaydetBTN.UseVisualStyleBackColor = true;
            this.MetinKaydetBTN.Click += new System.EventHandler(this.MetinKaydetBTN_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 15);
            this.label2.TabIndex = 11;
            this.label2.Text = "Metin Girin";
            // 
            // TextSizeLBL
            // 
            this.TextSizeLBL.AutoSize = true;
            this.TextSizeLBL.Location = new System.Drawing.Point(105, 87);
            this.TextSizeLBL.Name = "TextSizeLBL";
            this.TextSizeLBL.Size = new System.Drawing.Size(108, 15);
            this.TextSizeLBL.TabIndex = 12;
            this.TextSizeLBL.Text = "Yazılabilir Karakter: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 415);
            this.Controls.Add(this.TextSizeLBL);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.MetinKaydetBTN);
            this.Controls.Add(this.MetinSecBTN);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SifreCBOX);
            this.Controls.Add(this.SifreleBTN);
            this.Controls.Add(this.ResimKaydetBTN);
            this.Controls.Add(this.CozBTN);
            this.Controls.Add(this.GizleBTN);
            this.Controls.Add(this.ResimSecBTN);
            this.Controls.Add(this.ResimPBOX);
            this.Controls.Add(this.MetinTBOX);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Steganografi";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ResimPBOX)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RichTextBox MetinTBOX;
        private PictureBox ResimPBOX;
        private Button ResimSecBTN;
        private Button GizleBTN;
        private Button CozBTN;
        private Button ResimKaydetBTN;
        private Button SifreleBTN;
        private ComboBox SifreCBOX;
        private Label label1;
        private Button MetinSecBTN;
        private Button MetinKaydetBTN;
        private Label label2;
        private Label TextSizeLBL;
    }
}