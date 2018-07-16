namespace EmoDic
{
    partial class frmTuDien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTuDien));
            this.barManager1 = new DevExpress.XtraBars.BarManager();
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnXoa = new DevExpress.XtraBars.BarButtonItem();
            this.btnRefresh = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.edDS = new EmoDic.Emo_DictionaryDataSet();
            this.tsBS = new System.Windows.Forms.BindingSource();
            this.tsTA = new EmoDic.Emo_DictionaryDataSetTableAdapters.TRONG_SOTableAdapter();
            this.tableAdapterManager = new EmoDic.Emo_DictionaryDataSetTableAdapters.TableAdapterManager();
            this.dAC_TRUNG_CAM_XUCBindingSource = new System.Windows.Forms.BindingSource();
            this.dAC_TRUNG_CAM_XUCTableAdapter = new EmoDic.Emo_DictionaryDataSetTableAdapters.DAC_TRUNG_CAM_XUCTableAdapter();
            this.dAC_TRUNG_NGU_NGHIABindingSource = new System.Windows.Forms.BindingSource();
            this.dAC_TRUNG_NGU_NGHIATableAdapter = new EmoDic.Emo_DictionaryDataSetTableAdapters.DAC_TRUNG_NGU_NGHIATableAdapter();
            this.dAC_TRUNG_CAM_XUCGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colEID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTHUC_THE_CAM_XUC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHAT_GIONG = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tsBS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dAC_TRUNG_CAM_XUCBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dAC_TRUNG_NGU_NGHIABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dAC_TRUNG_CAM_XUCGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnXoa,
            this.btnRefresh});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 2;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnXoa, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnRefresh, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // btnXoa
            // 
            this.btnXoa.Caption = "Delete";
            this.btnXoa.Id = 0;
            this.btnXoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.Image")));
            this.btnXoa.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.LargeImage")));
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXoa_ItemClick);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Caption = "Refresh";
            this.btnRefresh.Id = 1;
            this.btnRefresh.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.ImageOptions.Image")));
            this.btnRefresh.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnRefresh.ImageOptions.LargeImage")));
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnRefresh_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(819, 24);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 385);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(819, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 24);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 361);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(819, 24);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 361);
            // 
            // edDS
            // 
            this.edDS.DataSetName = "Emo_DictionaryDataSet";
            this.edDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tsBS
            // 
            this.tsBS.DataMember = "TRONG_SO";
            this.tsBS.DataSource = this.edDS;
            // 
            // tsTA
            // 
            this.tsTA.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Dac_TaTableAdapter = null;
            this.tableAdapterManager.DAC_TRUNG_CAM_XUCTableAdapter = null;
            this.tableAdapterManager.DAC_TRUNG_NGU_NGHIATableAdapter = null;
            this.tableAdapterManager.TRONG_SOTableAdapter = this.tsTA;
            this.tableAdapterManager.UpdateOrder = EmoDic.Emo_DictionaryDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // dAC_TRUNG_CAM_XUCBindingSource
            // 
            this.dAC_TRUNG_CAM_XUCBindingSource.DataMember = "DAC_TRUNG_CAM_XUC";
            this.dAC_TRUNG_CAM_XUCBindingSource.DataSource = this.edDS;
            // 
            // dAC_TRUNG_CAM_XUCTableAdapter
            // 
            this.dAC_TRUNG_CAM_XUCTableAdapter.ClearBeforeFill = true;
            // 
            // dAC_TRUNG_NGU_NGHIABindingSource
            // 
            this.dAC_TRUNG_NGU_NGHIABindingSource.DataMember = "DAC_TRUNG_NGU_NGHIA";
            this.dAC_TRUNG_NGU_NGHIABindingSource.DataSource = this.edDS;
            // 
            // dAC_TRUNG_NGU_NGHIATableAdapter
            // 
            this.dAC_TRUNG_NGU_NGHIATableAdapter.ClearBeforeFill = true;
            // 
            // dAC_TRUNG_CAM_XUCGridControl
            // 
            this.dAC_TRUNG_CAM_XUCGridControl.DataSource = this.dAC_TRUNG_CAM_XUCBindingSource;
            this.dAC_TRUNG_CAM_XUCGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dAC_TRUNG_CAM_XUCGridControl.Location = new System.Drawing.Point(0, 24);
            this.dAC_TRUNG_CAM_XUCGridControl.MainView = this.gridView1;
            this.dAC_TRUNG_CAM_XUCGridControl.MenuManager = this.barManager1;
            this.dAC_TRUNG_CAM_XUCGridControl.Name = "dAC_TRUNG_CAM_XUCGridControl";
            this.dAC_TRUNG_CAM_XUCGridControl.Size = new System.Drawing.Size(819, 361);
            this.dAC_TRUNG_CAM_XUCGridControl.TabIndex = 17;
            this.dAC_TRUNG_CAM_XUCGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colEID,
            this.colTHUC_THE_CAM_XUC,
            this.colHAT_GIONG});
            this.gridView1.GridControl = this.dAC_TRUNG_CAM_XUCGridControl;
            this.gridView1.Name = "gridView1";
            // 
            // colEID
            // 
            this.colEID.FieldName = "EID";
            this.colEID.Name = "colEID";
            this.colEID.Visible = true;
            this.colEID.VisibleIndex = 0;
            // 
            // colTHUC_THE_CAM_XUC
            // 
            this.colTHUC_THE_CAM_XUC.FieldName = "THUC_THE_CAM_XUC";
            this.colTHUC_THE_CAM_XUC.Name = "colTHUC_THE_CAM_XUC";
            this.colTHUC_THE_CAM_XUC.Visible = true;
            this.colTHUC_THE_CAM_XUC.VisibleIndex = 1;
            // 
            // colHAT_GIONG
            // 
            this.colHAT_GIONG.FieldName = "HAT_GIONG";
            this.colHAT_GIONG.Name = "colHAT_GIONG";
            this.colHAT_GIONG.Visible = true;
            this.colHAT_GIONG.VisibleIndex = 2;
            // 
            // frmTuDien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 385);
            this.Controls.Add(this.dAC_TRUNG_CAM_XUCGridControl);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmTuDien";
            this.Text = "Từ diển";
            this.Load += new System.EventHandler(this.EmotionDictionary_View_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tsBS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dAC_TRUNG_CAM_XUCBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dAC_TRUNG_NGU_NGHIABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dAC_TRUNG_CAM_XUCGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem btnXoa;
        private DevExpress.XtraBars.BarButtonItem btnRefresh;
        private System.Windows.Forms.BindingSource tsBS;
        private Emo_DictionaryDataSet edDS;
        private Emo_DictionaryDataSetTableAdapters.TRONG_SOTableAdapter tsTA;
        private Emo_DictionaryDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource dAC_TRUNG_CAM_XUCBindingSource;
        private Emo_DictionaryDataSetTableAdapters.DAC_TRUNG_CAM_XUCTableAdapter dAC_TRUNG_CAM_XUCTableAdapter;
        private System.Windows.Forms.BindingSource dAC_TRUNG_NGU_NGHIABindingSource;
        private Emo_DictionaryDataSetTableAdapters.DAC_TRUNG_NGU_NGHIATableAdapter dAC_TRUNG_NGU_NGHIATableAdapter;
        private DevExpress.XtraGrid.GridControl dAC_TRUNG_CAM_XUCGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colEID;
        private DevExpress.XtraGrid.Columns.GridColumn colTHUC_THE_CAM_XUC;
        private DevExpress.XtraGrid.Columns.GridColumn colHAT_GIONG;
    }
}