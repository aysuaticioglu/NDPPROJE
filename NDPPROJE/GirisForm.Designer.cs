
namespace NDPPROJE
{
    partial class GirisForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GirisForm));
            this.btnOyna = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.txtSure = new System.Windows.Forms.TextBox();
            this.txtMiktar = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.tOYUNBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.oYUNDataSet = new NDPPROJE.OYUNDataSet();
            this.t_OYUNTableAdapter = new NDPPROJE.OYUNDataSetTableAdapters.T_OYUNTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnSkor = new Guna.UI2.WinForms.Guna2GradientCircleButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCikis = new Guna.UI2.WinForms.Guna2GradientCircleButton();
            this.btnBilgi = new Guna.UI2.WinForms.Guna2GradientCircleButton();
            ((System.ComponentModel.ISupportInitialize)(this.tOYUNBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oYUNDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOyna
            // 
            this.btnOyna.BorderRadius = 10;
            this.btnOyna.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnOyna.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnOyna.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnOyna.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnOyna.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnOyna.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(104)))), ((int)(((byte)(98)))));
            this.btnOyna.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(39)))), ((int)(((byte)(48)))));
            this.btnOyna.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.btnOyna.ForeColor = System.Drawing.Color.White;
            this.btnOyna.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
            this.btnOyna.Location = new System.Drawing.Point(625, 266);
            this.btnOyna.Name = "btnOyna";
            this.btnOyna.Size = new System.Drawing.Size(180, 45);
            this.btnOyna.TabIndex = 2;
            this.btnOyna.Text = "Oyna";
            this.btnOyna.Click += new System.EventHandler(this.btnOyna_Click);
            // 
            // txtSure
            // 
            this.txtSure.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtSure.Location = new System.Drawing.Point(625, 213);
            this.txtSure.Name = "txtSure";
            this.txtSure.Size = new System.Drawing.Size(180, 20);
            this.txtSure.TabIndex = 43;
            // 
            // txtMiktar
            // 
            this.txtMiktar.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtMiktar.Location = new System.Drawing.Point(625, 178);
            this.txtMiktar.Name = "txtMiktar";
            this.txtMiktar.Size = new System.Drawing.Size(180, 20);
            this.txtMiktar.TabIndex = 40;
            // 
            // txtAd
            // 
            this.txtAd.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtAd.Location = new System.Drawing.Point(625, 144);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(180, 20);
            this.txtAd.TabIndex = 39;
            // 
            // tOYUNBindingSource
            // 
            this.tOYUNBindingSource.DataMember = "T_OYUN";
            this.tOYUNBindingSource.DataSource = this.oYUNDataSet;
            // 
            // oYUNDataSet
            // 
            this.oYUNDataSet.DataSetName = "OYUNDataSet";
            this.oYUNDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // t_OYUNTableAdapter
            // 
            this.t_OYUNTableAdapter.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.guna2HtmlLabel3);
            this.panel1.Controls.Add(this.guna2HtmlLabel2);
            this.panel1.Controls.Add(this.guna2HtmlLabel1);
            this.panel1.Controls.Add(this.btnSkor);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btnCikis);
            this.panel1.Controls.Add(this.btnOyna);
            this.panel1.Controls.Add(this.btnBilgi);
            this.panel1.Controls.Add(this.txtAd);
            this.panel1.Controls.Add(this.txtMiktar);
            this.panel1.Controls.Add(this.txtSure);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(875, 496);
            this.panel1.TabIndex = 48;
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.guna2HtmlLabel3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(557, 212);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(66, 22);
            this.guna2HtmlLabel3.TabIndex = 50;
            this.guna2HtmlLabel3.Text = "Süre(sn):";
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.guna2HtmlLabel2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(556, 177);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(53, 22);
            this.guna2HtmlLabel2.TabIndex = 49;
            this.guna2HtmlLabel2.Text = "Miktar:";
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(556, 142);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(51, 22);
            this.guna2HtmlLabel1.TabIndex = 48;
            this.guna2HtmlLabel1.Text = "Adınız:";
            // 
            // btnSkor
            // 
            this.btnSkor.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSkor.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSkor.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSkor.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSkor.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSkor.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(104)))), ((int)(((byte)(98)))));
            this.btnSkor.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(39)))), ((int)(((byte)(48)))));
            this.btnSkor.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.btnSkor.ForeColor = System.Drawing.Color.White;
            this.btnSkor.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.btnSkor.Image = ((System.Drawing.Image)(resources.GetObject("btnSkor.Image")));
            this.btnSkor.ImageSize = new System.Drawing.Size(40, 40);
            this.btnSkor.Location = new System.Drawing.Point(673, 436);
            this.btnSkor.Name = "btnSkor";
            this.btnSkor.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnSkor.Size = new System.Drawing.Size(63, 57);
            this.btnSkor.TabIndex = 46;
            this.btnSkor.Click += new System.EventHandler(this.btnSkor_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::NDPPROJE.Properties.Resources.ninjakedigiris;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(540, 496);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 47;
            this.pictureBox1.TabStop = false;
            // 
            // btnCikis
            // 
            this.btnCikis.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCikis.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCikis.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCikis.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCikis.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCikis.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(104)))), ((int)(((byte)(98)))));
            this.btnCikis.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(39)))), ((int)(((byte)(48)))));
            this.btnCikis.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.btnCikis.ForeColor = System.Drawing.Color.White;
            this.btnCikis.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.btnCikis.Image = ((System.Drawing.Image)(resources.GetObject("btnCikis.Image")));
            this.btnCikis.ImageSize = new System.Drawing.Size(40, 40);
            this.btnCikis.Location = new System.Drawing.Point(811, 436);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnCikis.Size = new System.Drawing.Size(63, 57);
            this.btnCikis.TabIndex = 5;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // btnBilgi
            // 
            this.btnBilgi.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBilgi.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBilgi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBilgi.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBilgi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBilgi.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(104)))), ((int)(((byte)(98)))));
            this.btnBilgi.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(39)))), ((int)(((byte)(48)))));
            this.btnBilgi.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.btnBilgi.ForeColor = System.Drawing.Color.White;
            this.btnBilgi.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.btnBilgi.Image = ((System.Drawing.Image)(resources.GetObject("btnBilgi.Image")));
            this.btnBilgi.ImageSize = new System.Drawing.Size(40, 40);
            this.btnBilgi.Location = new System.Drawing.Point(742, 436);
            this.btnBilgi.Name = "btnBilgi";
            this.btnBilgi.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnBilgi.Size = new System.Drawing.Size(63, 57);
            this.btnBilgi.TabIndex = 4;
            this.btnBilgi.Click += new System.EventHandler(this.btnBilgi_Click);
            // 
            // GirisForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.ClientSize = new System.Drawing.Size(875, 496);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MaximizeBox = false;
            this.Name = "GirisForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.GirisForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tOYUNBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oYUNDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientButton btnOyna;
        private Guna.UI2.WinForms.Guna2GradientCircleButton btnCikis;
        private Guna.UI2.WinForms.Guna2GradientCircleButton btnBilgi;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        private System.Windows.Forms.TextBox txtSure;
        private System.Windows.Forms.TextBox txtMiktar;
        private System.Windows.Forms.TextBox txtAd;
        private OYUNDataSet oYUNDataSet;
        private System.Windows.Forms.BindingSource tOYUNBindingSource;
        private OYUNDataSetTableAdapters.T_OYUNTableAdapter t_OYUNTableAdapter;
        private Guna.UI2.WinForms.Guna2GradientCircleButton btnSkor;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
    }
}