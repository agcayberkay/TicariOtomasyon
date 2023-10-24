
namespace TicariOtomasyon
{
    partial class frmProducts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProducts));
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.grdProducts = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.pnlRight = new System.Windows.Forms.Panel();
            this.txtUnity = new System.Windows.Forms.NumericUpDown();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.lbDetail = new DevExpress.XtraEditors.LabelControl();
            this.lbSaledPrice = new DevExpress.XtraEditors.LabelControl();
            this.lbFixedPrice = new DevExpress.XtraEditors.LabelControl();
            this.lbUnity = new DevExpress.XtraEditors.LabelControl();
            this.lbYear = new DevExpress.XtraEditors.LabelControl();
            this.lbModel = new DevExpress.XtraEditors.LabelControl();
            this.lbMark = new DevExpress.XtraEditors.LabelControl();
            this.lbName = new DevExpress.XtraEditors.LabelControl();
            this.lbId = new DevExpress.XtraEditors.LabelControl();
            this.txtSaledPrice = new DevExpress.XtraEditors.TextEdit();
            this.txtFixedPrice = new DevExpress.XtraEditors.TextEdit();
            this.txtYear = new DevExpress.XtraEditors.TextEdit();
            this.txtModel = new DevExpress.XtraEditors.TextEdit();
            this.txtMark = new DevExpress.XtraEditors.TextEdit();
            this.txtName = new DevExpress.XtraEditors.TextEdit();
            this.txtId = new DevExpress.XtraEditors.TextEdit();
            this.txtDetail = new DevExpress.XtraEditors.TextEdit();
            this.pnlLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.pnlRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtUnity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSaledPrice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFixedPrice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYear.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtModel.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMark.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDetail.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlLeft
            // 
            this.pnlLeft.Controls.Add(this.grdProducts);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Location = new System.Drawing.Point(0, 0);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(601, 450);
            this.pnlLeft.TabIndex = 0;
            // 
            // grdProducts
            // 
            this.grdProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdProducts.Location = new System.Drawing.Point(0, 0);
            this.grdProducts.MainView = this.gridView1;
            this.grdProducts.Name = "grdProducts";
            this.grdProducts.Size = new System.Drawing.Size(601, 450);
            this.grdProducts.TabIndex = 0;
            this.grdProducts.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.grdProducts;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // pnlRight
            // 
            this.pnlRight.Controls.Add(this.txtUnity);
            this.pnlRight.Controls.Add(this.btnSave);
            this.pnlRight.Controls.Add(this.lbDetail);
            this.pnlRight.Controls.Add(this.lbSaledPrice);
            this.pnlRight.Controls.Add(this.lbFixedPrice);
            this.pnlRight.Controls.Add(this.lbUnity);
            this.pnlRight.Controls.Add(this.lbYear);
            this.pnlRight.Controls.Add(this.lbModel);
            this.pnlRight.Controls.Add(this.lbMark);
            this.pnlRight.Controls.Add(this.lbName);
            this.pnlRight.Controls.Add(this.lbId);
            this.pnlRight.Controls.Add(this.txtSaledPrice);
            this.pnlRight.Controls.Add(this.txtFixedPrice);
            this.pnlRight.Controls.Add(this.txtYear);
            this.pnlRight.Controls.Add(this.txtModel);
            this.pnlRight.Controls.Add(this.txtMark);
            this.pnlRight.Controls.Add(this.txtName);
            this.pnlRight.Controls.Add(this.txtId);
            this.pnlRight.Controls.Add(this.txtDetail);
            this.pnlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlRight.Location = new System.Drawing.Point(607, 0);
            this.pnlRight.Name = "pnlRight";
            this.pnlRight.Size = new System.Drawing.Size(293, 450);
            this.pnlRight.TabIndex = 0;
            // 
            // txtUnity
            // 
            this.txtUnity.Location = new System.Drawing.Point(90, 192);
            this.txtUnity.Name = "txtUnity";
            this.txtUnity.Size = new System.Drawing.Size(142, 21);
            this.txtUnity.TabIndex = 5;
            // 
            // btnSave
            // 
            this.btnSave.Appearance.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSave.Appearance.Options.UseFont = true;
            this.btnSave.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnSave.ImageOptions.SvgImage")));
            this.btnSave.Location = new System.Drawing.Point(90, 381);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(142, 37);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Kaydet";
            // 
            // lbDetail
            // 
            this.lbDetail.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbDetail.Appearance.Options.UseFont = true;
            this.lbDetail.Location = new System.Drawing.Point(42, 291);
            this.lbDetail.Name = "lbDetail";
            this.lbDetail.Size = new System.Drawing.Size(36, 14);
            this.lbDetail.TabIndex = 1;
            this.lbDetail.Text = "Detay:";
            // 
            // lbSaledPrice
            // 
            this.lbSaledPrice.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbSaledPrice.Appearance.Options.UseFont = true;
            this.lbSaledPrice.Location = new System.Drawing.Point(21, 259);
            this.lbSaledPrice.Name = "lbSaledPrice";
            this.lbSaledPrice.Size = new System.Drawing.Size(58, 14);
            this.lbSaledPrice.TabIndex = 1;
            this.lbSaledPrice.Text = "Satış Fiyat:";
            // 
            // lbFixedPrice
            // 
            this.lbFixedPrice.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbFixedPrice.Appearance.Options.UseFont = true;
            this.lbFixedPrice.Location = new System.Drawing.Point(28, 227);
            this.lbFixedPrice.Name = "lbFixedPrice";
            this.lbFixedPrice.Size = new System.Drawing.Size(50, 14);
            this.lbFixedPrice.TabIndex = 1;
            this.lbFixedPrice.Text = "Alış Fiyat:";
            // 
            // lbUnity
            // 
            this.lbUnity.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbUnity.Appearance.Options.UseFont = true;
            this.lbUnity.Location = new System.Drawing.Point(48, 195);
            this.lbUnity.Name = "lbUnity";
            this.lbUnity.Size = new System.Drawing.Size(31, 14);
            this.lbUnity.TabIndex = 1;
            this.lbUnity.Text = "Adet:";
            // 
            // lbYear
            // 
            this.lbYear.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbYear.Appearance.Options.UseFont = true;
            this.lbYear.Location = new System.Drawing.Point(61, 163);
            this.lbYear.Name = "lbYear";
            this.lbYear.Size = new System.Drawing.Size(16, 14);
            this.lbYear.TabIndex = 1;
            this.lbYear.Text = "Yıl:";
            // 
            // lbModel
            // 
            this.lbModel.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbModel.Appearance.Options.UseFont = true;
            this.lbModel.Location = new System.Drawing.Point(43, 131);
            this.lbModel.Name = "lbModel";
            this.lbModel.Size = new System.Drawing.Size(36, 14);
            this.lbModel.TabIndex = 1;
            this.lbModel.Text = "Model:";
            // 
            // lbMark
            // 
            this.lbMark.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbMark.Appearance.Options.UseFont = true;
            this.lbMark.Location = new System.Drawing.Point(42, 99);
            this.lbMark.Name = "lbMark";
            this.lbMark.Size = new System.Drawing.Size(35, 14);
            this.lbMark.TabIndex = 1;
            this.lbMark.Text = "Marka:";
            // 
            // lbName
            // 
            this.lbName.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbName.Appearance.Options.UseFont = true;
            this.lbName.Location = new System.Drawing.Point(58, 67);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(19, 14);
            this.lbName.TabIndex = 1;
            this.lbName.Text = "Ad:";
            // 
            // lbId
            // 
            this.lbId.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbId.Appearance.Options.UseFont = true;
            this.lbId.Location = new System.Drawing.Point(63, 35);
            this.lbId.Name = "lbId";
            this.lbId.Size = new System.Drawing.Size(16, 14);
            this.lbId.TabIndex = 1;
            this.lbId.Text = "ID:";
            // 
            // txtSaledPrice
            // 
            this.txtSaledPrice.Location = new System.Drawing.Point(90, 257);
            this.txtSaledPrice.Name = "txtSaledPrice";
            this.txtSaledPrice.Size = new System.Drawing.Size(142, 20);
            this.txtSaledPrice.TabIndex = 7;
            // 
            // txtFixedPrice
            // 
            this.txtFixedPrice.Location = new System.Drawing.Point(90, 225);
            this.txtFixedPrice.Name = "txtFixedPrice";
            this.txtFixedPrice.Size = new System.Drawing.Size(142, 20);
            this.txtFixedPrice.TabIndex = 6;
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(90, 161);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(142, 20);
            this.txtYear.TabIndex = 4;
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(90, 129);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(142, 20);
            this.txtModel.TabIndex = 3;
            // 
            // txtMark
            // 
            this.txtMark.Location = new System.Drawing.Point(90, 97);
            this.txtMark.Name = "txtMark";
            this.txtMark.Size = new System.Drawing.Size(142, 20);
            this.txtMark.TabIndex = 2;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(90, 65);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(142, 20);
            this.txtName.TabIndex = 1;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(90, 33);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(142, 20);
            this.txtId.TabIndex = 0;
            // 
            // txtDetail
            // 
            this.txtDetail.Location = new System.Drawing.Point(90, 289);
            this.txtDetail.Name = "txtDetail";
            this.txtDetail.Properties.AutoHeight = false;
            this.txtDetail.Size = new System.Drawing.Size(142, 85);
            this.txtDetail.TabIndex = 8;
            // 
            // frmProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 450);
            this.Controls.Add(this.pnlRight);
            this.Controls.Add(this.pnlLeft);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmProducts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "-- Ürünler --";
            this.pnlLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.pnlRight.ResumeLayout(false);
            this.pnlRight.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtUnity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSaledPrice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFixedPrice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYear.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtModel.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMark.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDetail.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlLeft;
        private DevExpress.XtraGrid.GridControl grdProducts;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.Panel pnlRight;
        private DevExpress.XtraEditors.LabelControl lbDetail;
        private DevExpress.XtraEditors.LabelControl lbSaledPrice;
        private DevExpress.XtraEditors.LabelControl lbFixedPrice;
        private DevExpress.XtraEditors.LabelControl lbUnity;
        private DevExpress.XtraEditors.LabelControl lbYear;
        private DevExpress.XtraEditors.LabelControl lbModel;
        private DevExpress.XtraEditors.LabelControl lbMark;
        private DevExpress.XtraEditors.LabelControl lbName;
        private DevExpress.XtraEditors.LabelControl lbId;
        private DevExpress.XtraEditors.TextEdit txtSaledPrice;
        private DevExpress.XtraEditors.TextEdit txtFixedPrice;
        private DevExpress.XtraEditors.TextEdit txtYear;
        private DevExpress.XtraEditors.TextEdit txtModel;
        private DevExpress.XtraEditors.TextEdit txtMark;
        private DevExpress.XtraEditors.TextEdit txtName;
        private DevExpress.XtraEditors.TextEdit txtId;
        private DevExpress.XtraEditors.TextEdit txtDetail;
        private System.Windows.Forms.NumericUpDown txtUnity;
        private DevExpress.XtraEditors.SimpleButton btnSave;
    }
}