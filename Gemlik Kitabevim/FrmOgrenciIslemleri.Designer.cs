namespace Gemlik_Kitabevim
{
    partial class FrmOgrenciIslemleri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOgrenciIslemleri));
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.MskTc = new System.Windows.Forms.MaskedTextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.MskKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.MskAdres = new System.Windows.Forms.RichTextBox();
            this.MskCinsiyet = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.MskUT = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.MskMail = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.MskTelefon = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.MskDT = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.MskAd = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.MskTcG = new System.Windows.Forms.MaskedTextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.MskIDG = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.MskGüncelle = new DevExpress.XtraEditors.SimpleButton();
            this.MskAdresG = new System.Windows.Forms.RichTextBox();
            this.MskCinsiyetG = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.MskUTG = new System.Windows.Forms.MaskedTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.MskMailG = new System.Windows.Forms.MaskedTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.MskTelefonG = new System.Windows.Forms.MaskedTextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.MskDTG = new System.Windows.Forms.MaskedTextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.MskAdG = new System.Windows.Forms.MaskedTextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.xtraTabPage3 = new DevExpress.XtraTab.XtraTabPage();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.MskIDS = new System.Windows.Forms.MaskedTextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.MskSil = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.xtraTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.xtraTabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            this.SuspendLayout();
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Location = new System.Drawing.Point(12, 12);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(970, 500);
            this.xtraTabControl1.TabIndex = 0;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2,
            this.xtraTabPage3});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.gridControl1);
            this.xtraTabPage1.Controls.Add(this.groupControl1);
            this.xtraTabPage1.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("xtraTabPage1.ImageOptions.SvgImage")));
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(968, 456);
            this.xtraTabPage1.Text = "Öğrenci Ekle";
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(336, 3);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(629, 450);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.gridView1.Appearance.Row.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.gridView1.Appearance.Row.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gridView1.Appearance.Row.Options.UseBackColor = true;
            this.gridView1.Appearance.Row.Options.UseBorderColor = true;
            this.gridView1.Appearance.Row.Options.UseFont = true;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.MskTc);
            this.groupControl1.Controls.Add(this.label16);
            this.groupControl1.Controls.Add(this.MskKaydet);
            this.groupControl1.Controls.Add(this.MskAdres);
            this.groupControl1.Controls.Add(this.MskCinsiyet);
            this.groupControl1.Controls.Add(this.label7);
            this.groupControl1.Controls.Add(this.label6);
            this.groupControl1.Controls.Add(this.MskUT);
            this.groupControl1.Controls.Add(this.label5);
            this.groupControl1.Controls.Add(this.MskMail);
            this.groupControl1.Controls.Add(this.label4);
            this.groupControl1.Controls.Add(this.MskTelefon);
            this.groupControl1.Controls.Add(this.label3);
            this.groupControl1.Controls.Add(this.MskDT);
            this.groupControl1.Controls.Add(this.label2);
            this.groupControl1.Controls.Add(this.MskAd);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Location = new System.Drawing.Point(3, 3);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(327, 450);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Öğrenci Bilgileri";
            this.groupControl1.Paint += new System.Windows.Forms.PaintEventHandler(this.groupControl1_Paint);
            // 
            // MskTc
            // 
            this.MskTc.Location = new System.Drawing.Point(106, 200);
            this.MskTc.Name = "MskTc";
            this.MskTc.Size = new System.Drawing.Size(203, 21);
            this.MskTc.TabIndex = 18;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label16.Location = new System.Drawing.Point(7, 200);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(92, 20);
            this.label16.TabIndex = 17;
            this.label16.Text = "TC. Kimlik No :";
            // 
            // MskKaydet
            // 
            this.MskKaydet.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("MskKaydet.ImageOptions.SvgImage")));
            this.MskKaydet.Location = new System.Drawing.Point(105, 352);
            this.MskKaydet.Name = "MskKaydet";
            this.MskKaydet.Size = new System.Drawing.Size(204, 54);
            this.MskKaydet.TabIndex = 16;
            this.MskKaydet.Text = "Kaydet";
            this.MskKaydet.Click += new System.EventHandler(this.MskKaydet_Click);
            // 
            // MskAdres
            // 
            this.MskAdres.Location = new System.Drawing.Point(105, 227);
            this.MskAdres.Name = "MskAdres";
            this.MskAdres.Size = new System.Drawing.Size(203, 109);
            this.MskAdres.TabIndex = 15;
            this.MskAdres.Text = "";
            // 
            // MskCinsiyet
            // 
            this.MskCinsiyet.FormattingEnabled = true;
            this.MskCinsiyet.Items.AddRange(new object[] {
            "Erkek ",
            "Kadın"});
            this.MskCinsiyet.Location = new System.Drawing.Point(106, 173);
            this.MskCinsiyet.Name = "MskCinsiyet";
            this.MskCinsiyet.Size = new System.Drawing.Size(202, 21);
            this.MskCinsiyet.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(53, 227);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "Adres :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(41, 173);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Cinsiyet :";
            // 
            // MskUT
            // 
            this.MskUT.Location = new System.Drawing.Point(105, 146);
            this.MskUT.Mask = "00/00/0000";
            this.MskUT.Name = "MskUT";
            this.MskUT.Size = new System.Drawing.Size(203, 21);
            this.MskUT.TabIndex = 9;
            this.MskUT.ValidatingType = typeof(System.DateTime);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(15, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Üyelik Tarihi :";
            // 
            // MskMail
            // 
            this.MskMail.Location = new System.Drawing.Point(105, 119);
            this.MskMail.Name = "MskMail";
            this.MskMail.Size = new System.Drawing.Size(203, 21);
            this.MskMail.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(48, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "E-Mail :";
            // 
            // MskTelefon
            // 
            this.MskTelefon.Location = new System.Drawing.Point(105, 92);
            this.MskTelefon.Mask = "(999) 000-0000";
            this.MskTelefon.Name = "MskTelefon";
            this.MskTelefon.Size = new System.Drawing.Size(203, 21);
            this.MskTelefon.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(41, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Telefon :";
            // 
            // MskDT
            // 
            this.MskDT.Location = new System.Drawing.Point(105, 65);
            this.MskDT.Mask = "00/00/0000";
            this.MskDT.Name = "MskDT";
            this.MskDT.Size = new System.Drawing.Size(203, 21);
            this.MskDT.TabIndex = 3;
            this.MskDT.ValidatingType = typeof(System.DateTime);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(7, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Doğum Tarihi :";
            // 
            // MskAd
            // 
            this.MskAd.Location = new System.Drawing.Point(105, 38);
            this.MskAd.Name = "MskAd";
            this.MskAd.Size = new System.Drawing.Size(203, 21);
            this.MskAd.TabIndex = 1;
            this.MskAd.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(33, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad Soyad :";
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.groupControl2);
            this.xtraTabPage2.Controls.Add(this.gridControl2);
            this.xtraTabPage2.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("xtraTabPage2.ImageOptions.SvgImage")));
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(968, 456);
            this.xtraTabPage2.Text = "Öğrenci Güncelle";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.MskTcG);
            this.groupControl2.Controls.Add(this.label17);
            this.groupControl2.Controls.Add(this.MskIDG);
            this.groupControl2.Controls.Add(this.label8);
            this.groupControl2.Controls.Add(this.MskGüncelle);
            this.groupControl2.Controls.Add(this.MskAdresG);
            this.groupControl2.Controls.Add(this.MskCinsiyetG);
            this.groupControl2.Controls.Add(this.label9);
            this.groupControl2.Controls.Add(this.label10);
            this.groupControl2.Controls.Add(this.MskUTG);
            this.groupControl2.Controls.Add(this.label11);
            this.groupControl2.Controls.Add(this.MskMailG);
            this.groupControl2.Controls.Add(this.label12);
            this.groupControl2.Controls.Add(this.MskTelefonG);
            this.groupControl2.Controls.Add(this.label13);
            this.groupControl2.Controls.Add(this.MskDTG);
            this.groupControl2.Controls.Add(this.label14);
            this.groupControl2.Controls.Add(this.MskAdG);
            this.groupControl2.Controls.Add(this.label23);
            this.groupControl2.Location = new System.Drawing.Point(3, 3);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(327, 450);
            this.groupControl2.TabIndex = 3;
            this.groupControl2.Text = "Öğrenci Bilgileri";
            // 
            // MskTcG
            // 
            this.MskTcG.Location = new System.Drawing.Point(106, 227);
            this.MskTcG.Name = "MskTcG";
            this.MskTcG.Size = new System.Drawing.Size(203, 21);
            this.MskTcG.TabIndex = 20;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label17.Location = new System.Drawing.Point(7, 227);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(92, 20);
            this.label17.TabIndex = 19;
            this.label17.Text = "TC. Kimlik No :";
            // 
            // MskIDG
            // 
            this.MskIDG.Location = new System.Drawing.Point(105, 38);
            this.MskIDG.Name = "MskIDG";
            this.MskIDG.Size = new System.Drawing.Size(203, 21);
            this.MskIDG.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(72, 39);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(27, 20);
            this.label8.TabIndex = 17;
            this.label8.Text = "ID :";
            // 
            // MskGüncelle
            // 
            this.MskGüncelle.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("MskGüncelle.ImageOptions.SvgImage")));
            this.MskGüncelle.Location = new System.Drawing.Point(104, 369);
            this.MskGüncelle.Name = "MskGüncelle";
            this.MskGüncelle.Size = new System.Drawing.Size(204, 54);
            this.MskGüncelle.TabIndex = 16;
            this.MskGüncelle.Text = "Güncelle";
            this.MskGüncelle.Click += new System.EventHandler(this.MskKaydetG_Click);
            // 
            // MskAdresG
            // 
            this.MskAdresG.Location = new System.Drawing.Point(105, 254);
            this.MskAdresG.Name = "MskAdresG";
            this.MskAdresG.Size = new System.Drawing.Size(203, 109);
            this.MskAdresG.TabIndex = 15;
            this.MskAdresG.Text = "";
            // 
            // MskCinsiyetG
            // 
            this.MskCinsiyetG.FormattingEnabled = true;
            this.MskCinsiyetG.Items.AddRange(new object[] {
            "Erkek ",
            "Kadın"});
            this.MskCinsiyetG.Location = new System.Drawing.Point(106, 200);
            this.MskCinsiyetG.Name = "MskCinsiyetG";
            this.MskCinsiyetG.Size = new System.Drawing.Size(202, 21);
            this.MskCinsiyetG.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(52, 255);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 20);
            this.label9.TabIndex = 12;
            this.label9.Text = "Adres :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(41, 200);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 20);
            this.label10.TabIndex = 10;
            this.label10.Text = "Cinsiyet :";
            // 
            // MskUTG
            // 
            this.MskUTG.Location = new System.Drawing.Point(105, 173);
            this.MskUTG.Mask = "00/00/0000";
            this.MskUTG.Name = "MskUTG";
            this.MskUTG.Size = new System.Drawing.Size(203, 21);
            this.MskUTG.TabIndex = 9;
            this.MskUTG.ValidatingType = typeof(System.DateTime);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(15, 174);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(84, 20);
            this.label11.TabIndex = 8;
            this.label11.Text = "Üyelik Tarihi :";
            // 
            // MskMailG
            // 
            this.MskMailG.Location = new System.Drawing.Point(105, 146);
            this.MskMailG.Name = "MskMailG";
            this.MskMailG.Size = new System.Drawing.Size(203, 21);
            this.MskMailG.TabIndex = 7;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(48, 147);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(51, 20);
            this.label12.TabIndex = 6;
            this.label12.Text = "E-Mail :";
            // 
            // MskTelefonG
            // 
            this.MskTelefonG.Location = new System.Drawing.Point(105, 119);
            this.MskTelefonG.Mask = "(999) 000-0000";
            this.MskTelefonG.Name = "MskTelefonG";
            this.MskTelefonG.Size = new System.Drawing.Size(203, 21);
            this.MskTelefonG.TabIndex = 5;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.Location = new System.Drawing.Point(41, 120);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(58, 20);
            this.label13.TabIndex = 4;
            this.label13.Text = "Telefon :";
            // 
            // MskDTG
            // 
            this.MskDTG.Location = new System.Drawing.Point(105, 92);
            this.MskDTG.Mask = "00/00/0000";
            this.MskDTG.Name = "MskDTG";
            this.MskDTG.Size = new System.Drawing.Size(203, 21);
            this.MskDTG.TabIndex = 3;
            this.MskDTG.ValidatingType = typeof(System.DateTime);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.Location = new System.Drawing.Point(7, 92);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(92, 20);
            this.label14.TabIndex = 2;
            this.label14.Text = "Doğum Tarihi :";
            // 
            // MskAdG
            // 
            this.MskAdG.Location = new System.Drawing.Point(105, 65);
            this.MskAdG.Name = "MskAdG";
            this.MskAdG.Size = new System.Drawing.Size(203, 21);
            this.MskAdG.TabIndex = 1;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label23.Location = new System.Drawing.Point(33, 66);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(66, 20);
            this.label23.TabIndex = 0;
            this.label23.Text = "Ad Soyad :";
            // 
            // gridControl2
            // 
            this.gridControl2.Location = new System.Drawing.Point(336, 3);
            this.gridControl2.MainView = this.gridView2;
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.Size = new System.Drawing.Size(629, 450);
            this.gridControl2.TabIndex = 2;
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.gridView2.Appearance.Row.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.gridView2.Appearance.Row.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gridView2.Appearance.Row.Options.UseBackColor = true;
            this.gridView2.Appearance.Row.Options.UseBorderColor = true;
            this.gridView2.Appearance.Row.Options.UseFont = true;
            this.gridView2.GridControl = this.gridControl2;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // xtraTabPage3
            // 
            this.xtraTabPage3.Controls.Add(this.groupControl3);
            this.xtraTabPage3.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("xtraTabPage3.ImageOptions.SvgImage")));
            this.xtraTabPage3.Name = "xtraTabPage3";
            this.xtraTabPage3.Size = new System.Drawing.Size(968, 456);
            this.xtraTabPage3.Text = "Öğrenci Sil";
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.MskIDS);
            this.groupControl3.Controls.Add(this.label15);
            this.groupControl3.Controls.Add(this.MskSil);
            this.groupControl3.Location = new System.Drawing.Point(3, 3);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(327, 189);
            this.groupControl3.TabIndex = 3;
            this.groupControl3.Text = "Öğrenci Bilgileri";
            // 
            // MskIDS
            // 
            this.MskIDS.Location = new System.Drawing.Point(105, 38);
            this.MskIDS.Name = "MskIDS";
            this.MskIDS.Size = new System.Drawing.Size(203, 21);
            this.MskIDS.TabIndex = 18;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label15.Location = new System.Drawing.Point(72, 39);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(27, 20);
            this.label15.TabIndex = 17;
            this.label15.Text = "ID :";
            // 
            // MskSil
            // 
            this.MskSil.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("MskSil.ImageOptions.SvgImage")));
            this.MskSil.Location = new System.Drawing.Point(105, 97);
            this.MskSil.Name = "MskSil";
            this.MskSil.Size = new System.Drawing.Size(204, 54);
            this.MskSil.TabIndex = 16;
            this.MskSil.Text = "Sil";
            this.MskSil.Click += new System.EventHandler(this.MskSil_Click);
            // 
            // FrmOgrenciIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(994, 526);
            this.Controls.Add(this.xtraTabControl1);
            this.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmOgrenciIslemleri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Öğrenci İşlemleri";
            this.Load += new System.EventHandler(this.FrmOgrenciIslemleri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            this.xtraTabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.xtraTabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            this.groupControl3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage3;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.MaskedTextBox MskAd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox MskUT;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox MskMail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox MskTelefon;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox MskDT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox MskAdres;
        private System.Windows.Forms.ComboBox MskCinsiyet;
        private System.Windows.Forms.Label label7;
        private DevExpress.XtraEditors.SimpleButton MskKaydet;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.GridControl gridControl2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private System.Windows.Forms.MaskedTextBox MskIDG;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RichTextBox MskAdresG;
        private System.Windows.Forms.ComboBox MskCinsiyetG;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.MaskedTextBox MskUTG;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.MaskedTextBox MskMailG;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.MaskedTextBox MskTelefonG;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.MaskedTextBox MskDTG;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.MaskedTextBox MskAdG;
        private System.Windows.Forms.Label label23;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private System.Windows.Forms.MaskedTextBox MskIDS;
        private System.Windows.Forms.Label label15;
        private DevExpress.XtraEditors.SimpleButton MskSil;
        private System.Windows.Forms.MaskedTextBox MskTc;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.MaskedTextBox MskTcG;
        private System.Windows.Forms.Label label17;
        private DevExpress.XtraEditors.SimpleButton MskGüncelle;
    }
}