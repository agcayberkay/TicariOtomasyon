
namespace TicariOtomasyon
{
    partial class frmAgcayTicariOtomasyon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAgcayTicariOtomasyon));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnHomePage = new DevExpress.XtraBars.BarButtonItem();
            this.btnProduct = new DevExpress.XtraBars.BarButtonItem();
            this.btnStok = new DevExpress.XtraBars.BarButtonItem();
            this.btnCustomers = new DevExpress.XtraBars.BarButtonItem();
            this.btnCompanys = new DevExpress.XtraBars.BarButtonItem();
            this.btnPersons = new DevExpress.XtraBars.BarButtonItem();
            this.btnExpenses = new DevExpress.XtraBars.BarButtonItem();
            this.btnCase = new DevExpress.XtraBars.BarButtonItem();
            this.btnNotes = new DevExpress.XtraBars.BarButtonItem();
            this.btnBank = new DevExpress.XtraBars.BarButtonItem();
            this.btnDirectory = new DevExpress.XtraBars.BarButtonItem();
            this.btnInovice = new DevExpress.XtraBars.BarButtonItem();
            this.btnSettings = new DevExpress.XtraBars.BarButtonItem();
            this.rpageOtomasyon = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.ribbonControl1.SearchEditItem,
            this.btnHomePage,
            this.btnProduct,
            this.btnStok,
            this.btnCustomers,
            this.btnCompanys,
            this.btnPersons,
            this.btnExpenses,
            this.btnCase,
            this.btnNotes,
            this.btnBank,
            this.btnDirectory,
            this.btnInovice,
            this.btnSettings});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 14;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.rpageOtomasyon});
            this.ribbonControl1.Size = new System.Drawing.Size(914, 150);
            // 
            // btnHomePage
            // 
            this.btnHomePage.Caption = "ANA SAYFA";
            this.btnHomePage.Id = 1;
            this.btnHomePage.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnHomePage.ImageOptions.SvgImage")));
            this.btnHomePage.ItemAppearance.Disabled.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHomePage.ItemAppearance.Disabled.Options.UseFont = true;
            this.btnHomePage.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHomePage.ItemAppearance.Normal.Options.UseFont = true;
            this.btnHomePage.Name = "btnHomePage";
            this.btnHomePage.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnHomePage.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // btnProduct
            // 
            this.btnProduct.Caption = "ÜRÜNLER";
            this.btnProduct.Id = 2;
            this.btnProduct.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnProduct.ImageOptions.SvgImage")));
            this.btnProduct.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnProduct.ItemAppearance.Normal.Options.UseFont = true;
            this.btnProduct.Name = "btnProduct";
            this.btnProduct.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnProduct_ItemClick);
            // 
            // btnStok
            // 
            this.btnStok.Caption = "STOKLAR";
            this.btnStok.Id = 3;
            this.btnStok.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnStok.ImageOptions.SvgImage")));
            this.btnStok.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnStok.ItemAppearance.Normal.Options.UseFont = true;
            this.btnStok.Name = "btnStok";
            // 
            // btnCustomers
            // 
            this.btnCustomers.Caption = "MÜŞTERİLER";
            this.btnCustomers.Id = 4;
            this.btnCustomers.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnCustomers.ImageOptions.SvgImage")));
            this.btnCustomers.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCustomers.ItemAppearance.Normal.Options.UseFont = true;
            this.btnCustomers.Name = "btnCustomers";
            // 
            // btnCompanys
            // 
            this.btnCompanys.Caption = "FİRMALAR";
            this.btnCompanys.Id = 5;
            this.btnCompanys.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnCompanys.ImageOptions.SvgImage")));
            this.btnCompanys.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCompanys.ItemAppearance.Normal.Options.UseFont = true;
            this.btnCompanys.Name = "btnCompanys";
            // 
            // btnPersons
            // 
            this.btnPersons.Caption = "PERSONELLER";
            this.btnPersons.Id = 6;
            this.btnPersons.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnPersons.ImageOptions.SvgImage")));
            this.btnPersons.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPersons.ItemAppearance.Normal.Options.UseFont = true;
            this.btnPersons.Name = "btnPersons";
            // 
            // btnExpenses
            // 
            this.btnExpenses.Caption = "GİDERLER";
            this.btnExpenses.Id = 7;
            this.btnExpenses.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnExpenses.ImageOptions.SvgImage")));
            this.btnExpenses.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnExpenses.ItemAppearance.Normal.Options.UseFont = true;
            this.btnExpenses.Name = "btnExpenses";
            // 
            // btnCase
            // 
            this.btnCase.Caption = "KASA";
            this.btnCase.Id = 8;
            this.btnCase.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnCase.ImageOptions.SvgImage")));
            this.btnCase.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCase.ItemAppearance.Normal.Options.UseFont = true;
            this.btnCase.Name = "btnCase";
            // 
            // btnNotes
            // 
            this.btnNotes.Caption = "NOTLAR";
            this.btnNotes.Id = 9;
            this.btnNotes.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnNotes.ImageOptions.SvgImage")));
            this.btnNotes.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnNotes.ItemAppearance.Normal.Options.UseFont = true;
            this.btnNotes.Name = "btnNotes";
            // 
            // btnBank
            // 
            this.btnBank.Caption = "BANKALAR";
            this.btnBank.Id = 10;
            this.btnBank.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnBank.ImageOptions.SvgImage")));
            this.btnBank.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBank.ItemAppearance.Normal.Options.UseFont = true;
            this.btnBank.Name = "btnBank";
            // 
            // btnDirectory
            // 
            this.btnDirectory.Caption = "REHBER";
            this.btnDirectory.Id = 11;
            this.btnDirectory.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnDirectory.ImageOptions.SvgImage")));
            this.btnDirectory.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDirectory.ItemAppearance.Normal.Options.UseFont = true;
            this.btnDirectory.Name = "btnDirectory";
            // 
            // btnInovice
            // 
            this.btnInovice.Caption = "FATURALAR";
            this.btnInovice.Id = 12;
            this.btnInovice.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnInovice.ImageOptions.SvgImage")));
            this.btnInovice.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnInovice.ItemAppearance.Normal.Options.UseFont = true;
            this.btnInovice.Name = "btnInovice";
            // 
            // btnSettings
            // 
            this.btnSettings.Caption = "AYARLAR";
            this.btnSettings.Id = 13;
            this.btnSettings.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnSettings.ImageOptions.SvgImage")));
            this.btnSettings.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSettings.ItemAppearance.Normal.Options.UseFont = true;
            this.btnSettings.Name = "btnSettings";
            // 
            // rpageOtomasyon
            // 
            this.rpageOtomasyon.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.rpageOtomasyon.Name = "rpageOtomasyon";
            this.rpageOtomasyon.Text = "AGCAY Ticari Otomasyon";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnHomePage);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnProduct);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnStok);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnCustomers);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnCompanys);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnPersons);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnExpenses);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnCase);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnNotes);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnBank);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnDirectory);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnInovice);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnSettings);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // frmAgcayTicariOtomasyon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 603);
            this.Controls.Add(this.ribbonControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IconOptions.Image = ((System.Drawing.Image)(resources.GetObject("frmAgcayTicariOtomasyon.IconOptions.Image")));
            this.IsMdiContainer = true;
            this.Name = "frmAgcayTicariOtomasyon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "-- AGCAY --";
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage rpageOtomasyon;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem btnHomePage;
        private DevExpress.XtraBars.BarButtonItem btnProduct;
        private DevExpress.XtraBars.BarButtonItem btnStok;
        private DevExpress.XtraBars.BarButtonItem btnCustomers;
        private DevExpress.XtraBars.BarButtonItem btnCompanys;
        private DevExpress.XtraBars.BarButtonItem btnPersons;
        private DevExpress.XtraBars.BarButtonItem btnExpenses;
        private DevExpress.XtraBars.BarButtonItem btnCase;
        private DevExpress.XtraBars.BarButtonItem btnNotes;
        private DevExpress.XtraBars.BarButtonItem btnBank;
        private DevExpress.XtraBars.BarButtonItem btnDirectory;
        private DevExpress.XtraBars.BarButtonItem btnInovice;
        private DevExpress.XtraBars.BarButtonItem btnSettings;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
    }
}

