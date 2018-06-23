namespace EmoDic
{
    partial class EmotionDictionary_View
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmotionDictionary_View));
            System.Windows.Forms.Label hat_giongLabel;
            System.Windows.Forms.Label tRONG_SOLabel;
            System.Windows.Forms.Label tU_CAM_XUCLabel;
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnXoa = new DevExpress.XtraBars.BarButtonItem();
            this.btnRefresh = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.edDS = new EmoDic.Emo_DictionaryDataSet();
            this.tdcxBS = new System.Windows.Forms.BindingSource(this.components);
            this.tuDienCamXucTableAdapter = new EmoDic.Emo_DictionaryDataSetTableAdapters.TuDienCamXucTableAdapter();
            this.tableAdapterManager = new EmoDic.Emo_DictionaryDataSetTableAdapters.TableAdapterManager();
            this.tuDienCamXucGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colTU_CAM_XUC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTRONG_SO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colhat_giong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ceSeed = new DevExpress.XtraEditors.CheckEdit();
            this.spnW = new DevExpress.XtraEditors.SpinEdit();
            this.txtE = new DevExpress.XtraEditors.TextEdit();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            hat_giongLabel = new System.Windows.Forms.Label();
            tRONG_SOLabel = new System.Windows.Forms.Label();
            tU_CAM_XUCLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tdcxBS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tuDienCamXucGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ceSeed.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnW.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtE.Properties)).BeginInit();
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
            this.btnRefresh,
            this.barButtonItem1});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 3;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnXoa, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnRefresh, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItem1, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
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
            this.barDockControlTop.Size = new System.Drawing.Size(831, 24);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 404);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(831, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 24);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 380);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(831, 24);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 380);
            // 
            // edDS
            // 
            this.edDS.DataSetName = "Emo_DictionaryDataSet";
            this.edDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tdcxBS
            // 
            this.tdcxBS.DataMember = "TuDienCamXuc";
            this.tdcxBS.DataSource = this.edDS;
            // 
            // tuDienCamXucTableAdapter
            // 
            this.tuDienCamXucTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Dac_TaTableAdapter = null;
            this.tableAdapterManager.TuDienCamXucTableAdapter = this.tuDienCamXucTableAdapter;
            this.tableAdapterManager.UpdateOrder = EmoDic.Emo_DictionaryDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tuDienCamXucGridControl
            // 
            this.tuDienCamXucGridControl.DataSource = this.tdcxBS;
            this.tuDienCamXucGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tuDienCamXucGridControl.Location = new System.Drawing.Point(0, 24);
            this.tuDienCamXucGridControl.MainView = this.gridView1;
            this.tuDienCamXucGridControl.MenuManager = this.barManager1;
            this.tuDienCamXucGridControl.Name = "tuDienCamXucGridControl";
            this.tuDienCamXucGridControl.Size = new System.Drawing.Size(831, 380);
            this.tuDienCamXucGridControl.TabIndex = 8;
            this.tuDienCamXucGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTU_CAM_XUC,
            this.colTRONG_SO,
            this.colhat_giong});
            this.gridView1.GridControl = this.tuDienCamXucGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colTU_CAM_XUC, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.gridView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gridView1_KeyDown);
            // 
            // colTU_CAM_XUC
            // 
            this.colTU_CAM_XUC.AppearanceCell.Options.UseTextOptions = true;
            this.colTU_CAM_XUC.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colTU_CAM_XUC.AppearanceHeader.BackColor = System.Drawing.Color.WhiteSmoke;
            this.colTU_CAM_XUC.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colTU_CAM_XUC.AppearanceHeader.Options.UseBackColor = true;
            this.colTU_CAM_XUC.AppearanceHeader.Options.UseFont = true;
            this.colTU_CAM_XUC.AppearanceHeader.Options.UseTextOptions = true;
            this.colTU_CAM_XUC.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTU_CAM_XUC.Caption = "Emotion";
            this.colTU_CAM_XUC.FieldName = "TU_CAM_XUC";
            this.colTU_CAM_XUC.Name = "colTU_CAM_XUC";
            this.colTU_CAM_XUC.Visible = true;
            this.colTU_CAM_XUC.VisibleIndex = 0;
            // 
            // colTRONG_SO
            // 
            this.colTRONG_SO.AppearanceCell.Options.UseTextOptions = true;
            this.colTRONG_SO.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTRONG_SO.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colTRONG_SO.AppearanceHeader.BackColor = System.Drawing.Color.WhiteSmoke;
            this.colTRONG_SO.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colTRONG_SO.AppearanceHeader.Options.UseBackColor = true;
            this.colTRONG_SO.AppearanceHeader.Options.UseFont = true;
            this.colTRONG_SO.AppearanceHeader.Options.UseTextOptions = true;
            this.colTRONG_SO.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTRONG_SO.Caption = "Weight";
            this.colTRONG_SO.FieldName = "TRONG_SO";
            this.colTRONG_SO.Name = "colTRONG_SO";
            this.colTRONG_SO.Visible = true;
            this.colTRONG_SO.VisibleIndex = 1;
            // 
            // colhat_giong
            // 
            this.colhat_giong.AppearanceCell.Options.UseTextOptions = true;
            this.colhat_giong.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colhat_giong.AppearanceHeader.BackColor = System.Drawing.Color.WhiteSmoke;
            this.colhat_giong.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colhat_giong.AppearanceHeader.Options.UseBackColor = true;
            this.colhat_giong.AppearanceHeader.Options.UseFont = true;
            this.colhat_giong.AppearanceHeader.Options.UseTextOptions = true;
            this.colhat_giong.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colhat_giong.Caption = "Seed";
            this.colhat_giong.FieldName = "hat_giong";
            this.colhat_giong.Name = "colhat_giong";
            this.colhat_giong.Visible = true;
            this.colhat_giong.VisibleIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(tU_CAM_XUCLabel);
            this.groupBox1.Controls.Add(this.txtE);
            this.groupBox1.Controls.Add(tRONG_SOLabel);
            this.groupBox1.Controls.Add(this.spnW);
            this.groupBox1.Controls.Add(hat_giongLabel);
            this.groupBox1.Controls.Add(this.ceSeed);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(0, 403);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(831, 1);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            // 
            // hat_giongLabel
            // 
            hat_giongLabel.AutoSize = true;
            hat_giongLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            hat_giongLabel.Location = new System.Drawing.Point(263, 132);
            hat_giongLabel.Name = "hat_giongLabel";
            hat_giongLabel.Size = new System.Drawing.Size(79, 18);
            hat_giongLabel.TabIndex = 0;
            hat_giongLabel.Text = "Hạt giống: ";
            // 
            // ceSeed
            // 
            this.ceSeed.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tdcxBS, "hat_giong", true));
            this.ceSeed.Location = new System.Drawing.Point(371, 133);
            this.ceSeed.MenuManager = this.barManager1;
            this.ceSeed.Name = "ceSeed";
            this.ceSeed.Properties.Caption = "True";
            this.ceSeed.Size = new System.Drawing.Size(75, 19);
            this.ceSeed.TabIndex = 1;
            // 
            // tRONG_SOLabel
            // 
            tRONG_SOLabel.AutoSize = true;
            tRONG_SOLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tRONG_SOLabel.Location = new System.Drawing.Point(266, 98);
            tRONG_SOLabel.Name = "tRONG_SOLabel";
            tRONG_SOLabel.Size = new System.Drawing.Size(76, 18);
            tRONG_SOLabel.TabIndex = 2;
            tRONG_SOLabel.Text = "Trọng số: ";
            // 
            // spnW
            // 
            this.spnW.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tdcxBS, "TRONG_SO", true));
            this.spnW.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spnW.Location = new System.Drawing.Point(371, 95);
            this.spnW.MenuManager = this.barManager1;
            this.spnW.Name = "spnW";
            this.spnW.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spnW.Properties.Mask.EditMask = "f0";
            this.spnW.Size = new System.Drawing.Size(91, 20);
            this.spnW.TabIndex = 3;
            // 
            // tU_CAM_XUCLabel
            // 
            tU_CAM_XUCLabel.AutoSize = true;
            tU_CAM_XUCLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tU_CAM_XUCLabel.Location = new System.Drawing.Point(260, 59);
            tU_CAM_XUCLabel.Name = "tU_CAM_XUCLabel";
            tU_CAM_XUCLabel.Size = new System.Drawing.Size(89, 18);
            tU_CAM_XUCLabel.TabIndex = 4;
            tU_CAM_XUCLabel.Text = "Từ cảm xúc:";
            // 
            // txtE
            // 
            this.txtE.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tdcxBS, "TU_CAM_XUC", true));
            this.txtE.Location = new System.Drawing.Point(371, 60);
            this.txtE.MenuManager = this.barManager1;
            this.txtE.Name = "txtE";
            this.txtE.Size = new System.Drawing.Size(233, 20);
            this.txtE.TabIndex = 5;
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Update";
            this.barButtonItem1.Id = 2;
            this.barButtonItem1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.Image")));
            this.barButtonItem1.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.LargeImage")));
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // EmotionDictionary_View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(831, 404);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tuDienCamXucGridControl);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "EmotionDictionary_View";
            this.Text = "EmotionDictionary_View";
            this.Load += new System.EventHandler(this.EmotionDictionary_View_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tdcxBS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tuDienCamXucGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ceSeed.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnW.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtE.Properties)).EndInit();
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
        private System.Windows.Forms.BindingSource tdcxBS;
        private Emo_DictionaryDataSet edDS;
        private Emo_DictionaryDataSetTableAdapters.TuDienCamXucTableAdapter tuDienCamXucTableAdapter;
        private Emo_DictionaryDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraBars.BarButtonItem btnRefresh;
        private DevExpress.XtraGrid.GridControl tuDienCamXucGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colTU_CAM_XUC;
        private DevExpress.XtraGrid.Columns.GridColumn colTRONG_SO;
        private DevExpress.XtraGrid.Columns.GridColumn colhat_giong;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.TextEdit txtE;
        private DevExpress.XtraEditors.SpinEdit spnW;
        private DevExpress.XtraEditors.CheckEdit ceSeed;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
    }
}