namespace EmoDic
{
    partial class Main
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
            System.Windows.Forms.Label tHUC_THELabel;
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnWatch = new System.Windows.Forms.Button();
            this.btnXtract = new System.Windows.Forms.Button();
            this.aft = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkAllA = new System.Windows.Forms.CheckBox();
            this.a5 = new System.Windows.Forms.CheckBox();
            this.a4 = new System.Windows.Forms.CheckBox();
            this.a3 = new System.Windows.Forms.CheckBox();
            this.a2 = new System.Windows.Forms.CheckBox();
            this.a1 = new System.Windows.Forms.CheckBox();
            this.bf = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.checkAllB = new System.Windows.Forms.CheckBox();
            this.b6 = new System.Windows.Forms.CheckBox();
            this.b5 = new System.Windows.Forms.CheckBox();
            this.b4 = new System.Windows.Forms.CheckBox();
            this.b3 = new System.Windows.Forms.CheckBox();
            this.b2 = new System.Windows.Forms.CheckBox();
            this.b1 = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ttCb = new System.Windows.Forms.ComboBox();
            this.dtnnBS = new System.Windows.Forms.BindingSource(this.components);
            this.edDS = new EmoDic.Emo_DictionaryDataSet();
            this.btnThemWS = new System.Windows.Forms.Button();
            this.spnW = new DevExpress.XtraEditors.SpinEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.btnThemWOS = new System.Windows.Forms.Button();
            this.alert = new System.Windows.Forms.Label();
            this.seed = new System.Windows.Forms.Label();
            this.txtSeed = new System.Windows.Forms.TextBox();
            this.btnThemTTYN = new System.Windows.Forms.Button();
            this.dtnnTA = new EmoDic.Emo_DictionaryDataSetTableAdapters.DAC_TRUNG_NGU_NGHIATableAdapter();
            this.tableAdapterManager = new EmoDic.Emo_DictionaryDataSetTableAdapters.TableAdapterManager();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.alert2lb = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMA = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTTYN = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            tHUC_THELabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.aft.SuspendLayout();
            this.panel1.SuspendLayout();
            this.bf.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtnnBS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnW.Properties)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tHUC_THELabel
            // 
            tHUC_THELabel.AutoSize = true;
            tHUC_THELabel.Location = new System.Drawing.Point(34, 30);
            tHUC_THELabel.Name = "tHUC_THELabel";
            tHUC_THELabel.Size = new System.Drawing.Size(95, 13);
            tHUC_THELabel.TabIndex = 8;
            tHUC_THELabel.Text = "Thực thể ý nghĩa :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnWatch);
            this.groupBox1.Controls.Add(this.btnXtract);
            this.groupBox1.Controls.Add(this.aft);
            this.groupBox1.Controls.Add(this.bf);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(0);
            this.groupBox1.Size = new System.Drawing.Size(792, 151);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // btnWatch
            // 
            this.btnWatch.Location = new System.Drawing.Point(649, 44);
            this.btnWatch.Name = "btnWatch";
            this.btnWatch.Size = new System.Drawing.Size(111, 23);
            this.btnWatch.TabIndex = 2;
            this.btnWatch.Text = "Xem tử điển";
            this.btnWatch.UseVisualStyleBackColor = true;
            this.btnWatch.Click += new System.EventHandler(this.btnWatch_Click);
            // 
            // btnXtract
            // 
            this.btnXtract.Location = new System.Drawing.Point(649, 104);
            this.btnXtract.Name = "btnXtract";
            this.btnXtract.Size = new System.Drawing.Size(111, 23);
            this.btnXtract.TabIndex = 3;
            this.btnXtract.Text = "Rút trích";
            this.btnXtract.UseVisualStyleBackColor = true;
            this.btnXtract.Click += new System.EventHandler(this.btnXtract_Click);
            // 
            // aft
            // 
            this.aft.Controls.Add(this.checkBox2);
            this.aft.Controls.Add(this.checkBox1);
            this.aft.Controls.Add(this.panel1);
            this.aft.Controls.Add(this.a5);
            this.aft.Controls.Add(this.a4);
            this.aft.Controls.Add(this.a3);
            this.aft.Controls.Add(this.a2);
            this.aft.Controls.Add(this.a1);
            this.aft.Dock = System.Windows.Forms.DockStyle.Left;
            this.aft.Location = new System.Drawing.Point(294, 14);
            this.aft.Name = "aft";
            this.aft.Size = new System.Drawing.Size(321, 137);
            this.aft.TabIndex = 6;
            this.aft.TabStop = false;
            this.aft.Text = "Sau";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.checkAllA);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 17);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(315, 23);
            this.panel1.TabIndex = 17;
            // 
            // checkAllA
            // 
            this.checkAllA.AutoSize = true;
            this.checkAllA.Location = new System.Drawing.Point(8, 3);
            this.checkAllA.Name = "checkAllA";
            this.checkAllA.Size = new System.Drawing.Size(82, 17);
            this.checkAllA.TabIndex = 0;
            this.checkAllA.Text = "Chọn tất cả";
            this.checkAllA.UseVisualStyleBackColor = true;
            // 
            // a5
            // 
            this.a5.AutoSize = true;
            this.a5.Checked = true;
            this.a5.CheckState = System.Windows.Forms.CheckState.Checked;
            this.a5.Location = new System.Drawing.Point(93, 46);
            this.a5.Name = "a5";
            this.a5.Size = new System.Drawing.Size(62, 17);
            this.a5.TabIndex = 16;
            this.a5.Tag = "3";
            this.a5.Text = "hết sảy";
            this.a5.UseVisualStyleBackColor = true;
            // 
            // a4
            // 
            this.a4.AutoSize = true;
            this.a4.Checked = true;
            this.a4.CheckState = System.Windows.Forms.CheckState.Checked;
            this.a4.Location = new System.Drawing.Point(11, 111);
            this.a4.Name = "a4";
            this.a4.Size = new System.Drawing.Size(61, 17);
            this.a4.TabIndex = 15;
            this.a4.Tag = "2";
            this.a4.Text = "lắm lắm";
            this.a4.UseVisualStyleBackColor = true;
            // 
            // a3
            // 
            this.a3.AutoSize = true;
            this.a3.Checked = true;
            this.a3.CheckState = System.Windows.Forms.CheckState.Checked;
            this.a3.Location = new System.Drawing.Point(11, 89);
            this.a3.Name = "a3";
            this.a3.Size = new System.Drawing.Size(62, 17);
            this.a3.TabIndex = 14;
            this.a3.Tag = "3";
            this.a3.Text = "hết sức";
            this.a3.UseVisualStyleBackColor = true;
            // 
            // a2
            // 
            this.a2.AutoSize = true;
            this.a2.Checked = true;
            this.a2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.a2.Location = new System.Drawing.Point(12, 67);
            this.a2.Name = "a2";
            this.a2.Size = new System.Drawing.Size(57, 17);
            this.a2.TabIndex = 13;
            this.a2.Tag = "3";
            this.a2.Text = "cực kỳ";
            this.a2.UseVisualStyleBackColor = true;
            // 
            // a1
            // 
            this.a1.AutoSize = true;
            this.a1.Checked = true;
            this.a1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.a1.Location = new System.Drawing.Point(12, 46);
            this.a1.Name = "a1";
            this.a1.Size = new System.Drawing.Size(43, 17);
            this.a1.TabIndex = 12;
            this.a1.Tag = "2";
            this.a1.Text = "cực";
            this.a1.UseVisualStyleBackColor = true;
            // 
            // bf
            // 
            this.bf.Controls.Add(this.panel2);
            this.bf.Controls.Add(this.b6);
            this.bf.Controls.Add(this.b5);
            this.bf.Controls.Add(this.b4);
            this.bf.Controls.Add(this.b3);
            this.bf.Controls.Add(this.b2);
            this.bf.Controls.Add(this.b1);
            this.bf.Dock = System.Windows.Forms.DockStyle.Left;
            this.bf.Location = new System.Drawing.Point(0, 14);
            this.bf.Name = "bf";
            this.bf.Size = new System.Drawing.Size(294, 137);
            this.bf.TabIndex = 5;
            this.bf.TabStop = false;
            this.bf.Text = "Trước";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.checkAllB);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(3, 17);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(288, 23);
            this.panel2.TabIndex = 18;
            // 
            // checkAllB
            // 
            this.checkAllB.AutoSize = true;
            this.checkAllB.Location = new System.Drawing.Point(8, 3);
            this.checkAllB.Name = "checkAllB";
            this.checkAllB.Size = new System.Drawing.Size(82, 17);
            this.checkAllB.TabIndex = 1;
            this.checkAllB.Text = "Chọn tất cả";
            this.checkAllB.UseVisualStyleBackColor = true;
            // 
            // b6
            // 
            this.b6.AutoSize = true;
            this.b6.Checked = true;
            this.b6.CheckState = System.Windows.Forms.CheckState.Checked;
            this.b6.Location = new System.Drawing.Point(98, 47);
            this.b6.Name = "b6";
            this.b6.Size = new System.Drawing.Size(62, 17);
            this.b6.TabIndex = 7;
            this.b6.Tag = "3";
            this.b6.Text = "hết sức";
            this.b6.UseVisualStyleBackColor = true;
            // 
            // b5
            // 
            this.b5.AutoSize = true;
            this.b5.Checked = true;
            this.b5.CheckState = System.Windows.Forms.CheckState.Checked;
            this.b5.Location = new System.Drawing.Point(98, 68);
            this.b5.Name = "b5";
            this.b5.Size = new System.Drawing.Size(44, 17);
            this.b5.TabIndex = 6;
            this.b5.Tag = "2";
            this.b5.Text = "quá";
            this.b5.UseVisualStyleBackColor = true;
            // 
            // b4
            // 
            this.b4.AutoSize = true;
            this.b4.Checked = true;
            this.b4.CheckState = System.Windows.Forms.CheckState.Checked;
            this.b4.Location = new System.Drawing.Point(12, 112);
            this.b4.Name = "b4";
            this.b4.Size = new System.Drawing.Size(53, 17);
            this.b4.TabIndex = 5;
            this.b4.Tag = "3";
            this.b4.Text = "cực kì";
            this.b4.UseVisualStyleBackColor = true;
            // 
            // b3
            // 
            this.b3.AutoSize = true;
            this.b3.Checked = true;
            this.b3.CheckState = System.Windows.Forms.CheckState.Checked;
            this.b3.Location = new System.Drawing.Point(12, 90);
            this.b3.Name = "b3";
            this.b3.Size = new System.Drawing.Size(43, 17);
            this.b3.TabIndex = 4;
            this.b3.Tag = "2";
            this.b3.Text = "cực";
            this.b3.UseVisualStyleBackColor = true;
            // 
            // b2
            // 
            this.b2.AutoSize = true;
            this.b2.Checked = true;
            this.b2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.b2.Location = new System.Drawing.Point(12, 68);
            this.b2.Name = "b2";
            this.b2.Size = new System.Drawing.Size(51, 17);
            this.b2.TabIndex = 3;
            this.b2.Tag = "2";
            this.b2.Text = "rất là";
            this.b2.UseVisualStyleBackColor = true;
            // 
            // b1
            // 
            this.b1.AutoSize = true;
            this.b1.Checked = true;
            this.b1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.b1.Location = new System.Drawing.Point(12, 46);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(40, 17);
            this.b1.TabIndex = 2;
            this.b1.Tag = "2";
            this.b1.Text = "rất";
            this.b1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(tHUC_THELabel);
            this.groupBox2.Controls.Add(this.ttCb);
            this.groupBox2.Controls.Add(this.btnThemWS);
            this.groupBox2.Controls.Add(this.spnW);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.btnThemWOS);
            this.groupBox2.Controls.Add(this.alert);
            this.groupBox2.Controls.Add(this.seed);
            this.groupBox2.Controls.Add(this.txtSeed);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 151);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(792, 149);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thêm từ điển";
            // 
            // ttCb
            // 
            this.ttCb.DataSource = this.dtnnBS;
            this.ttCb.DisplayMember = "THUC_THE";
            this.ttCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ttCb.FormattingEnabled = true;
            this.ttCb.Location = new System.Drawing.Point(37, 52);
            this.ttCb.Name = "ttCb";
            this.ttCb.Size = new System.Drawing.Size(160, 21);
            this.ttCb.TabIndex = 9;
            this.ttCb.ValueMember = "ID";
            // 
            // dtnnBS
            // 
            this.dtnnBS.DataMember = "DAC_TRUNG_NGU_NGHIA";
            this.dtnnBS.DataSource = this.edDS;
            // 
            // edDS
            // 
            this.edDS.DataSetName = "Emo_DictionaryDataSet";
            this.edDS.EnforceConstraints = false;
            this.edDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnThemWS
            // 
            this.btnThemWS.Location = new System.Drawing.Point(294, 91);
            this.btnThemWS.Name = "btnThemWS";
            this.btnThemWS.Size = new System.Drawing.Size(152, 23);
            this.btnThemWS.TabIndex = 8;
            this.btnThemWS.Text = "Thêm";
            this.btnThemWS.UseVisualStyleBackColor = true;
            this.btnThemWS.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // spnW
            // 
            this.spnW.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.spnW.Location = new System.Drawing.Point(640, 53);
            this.spnW.Name = "spnW";
            this.spnW.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spnW.Properties.Mask.EditMask = "f0";
            this.spnW.Size = new System.Drawing.Size(100, 20);
            this.spnW.TabIndex = 7;
            this.spnW.EditValueChanged += new System.EventHandler(this.spinEdit1_EditValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(636, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 19);
            this.label1.TabIndex = 6;
            this.label1.Text = "Trọng số";
            // 
            // btnThemWOS
            // 
            this.btnThemWOS.Location = new System.Drawing.Point(489, 91);
            this.btnThemWOS.Name = "btnThemWOS";
            this.btnThemWOS.Size = new System.Drawing.Size(152, 23);
            this.btnThemWOS.TabIndex = 5;
            this.btnThemWOS.Text = "Thêm không seed";
            this.btnThemWOS.UseVisualStyleBackColor = true;
            this.btnThemWOS.Click += new System.EventHandler(this.update_Click);
            // 
            // alert
            // 
            this.alert.AutoSize = true;
            this.alert.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alert.ForeColor = System.Drawing.Color.Red;
            this.alert.Location = new System.Drawing.Point(211, 26);
            this.alert.Name = "alert";
            this.alert.Size = new System.Drawing.Size(0, 19);
            this.alert.TabIndex = 4;
            // 
            // seed
            // 
            this.seed.AutoSize = true;
            this.seed.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seed.Location = new System.Drawing.Point(227, 26);
            this.seed.Name = "seed";
            this.seed.Size = new System.Drawing.Size(92, 19);
            this.seed.TabIndex = 1;
            this.seed.Text = "Từ cảm xúc:  ";
            // 
            // txtSeed
            // 
            this.txtSeed.Location = new System.Drawing.Point(231, 52);
            this.txtSeed.Name = "txtSeed";
            this.txtSeed.Size = new System.Drawing.Size(375, 21);
            this.txtSeed.TabIndex = 0;
            // 
            // btnThemTTYN
            // 
            this.btnThemTTYN.Location = new System.Drawing.Point(294, 95);
            this.btnThemTTYN.Name = "btnThemTTYN";
            this.btnThemTTYN.Size = new System.Drawing.Size(126, 23);
            this.btnThemTTYN.TabIndex = 2;
            this.btnThemTTYN.Text = "Thêm ";
            this.btnThemTTYN.UseVisualStyleBackColor = true;
            this.btnThemTTYN.Click += new System.EventHandler(this.add_Click);
            // 
            // dtnnTA
            // 
            this.dtnnTA.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Dac_TaTableAdapter = null;
            this.tableAdapterManager.DAC_TRUNG_CAM_XUCTableAdapter = null;
            this.tableAdapterManager.DAC_TRUNG_NGU_NGHIATableAdapter = this.dtnnTA;
            this.tableAdapterManager.TRONG_SOTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = EmoDic.Emo_DictionaryDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.alert2lb);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.txtMA);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.txtTTYN);
            this.groupBox3.Controls.Add(this.btnThemTTYN);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Location = new System.Drawing.Point(0, 300);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(792, 241);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thêm thực thể ý nghĩa";
            // 
            // alert2lb
            // 
            this.alert2lb.AutoSize = true;
            this.alert2lb.Location = new System.Drawing.Point(107, 17);
            this.alert2lb.Name = "alert2lb";
            this.alert2lb.Size = new System.Drawing.Size(0, 13);
            this.alert2lb.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(103, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "Mã thực thể";
            // 
            // txtMA
            // 
            this.txtMA.Location = new System.Drawing.Point(107, 68);
            this.txtMA.Name = "txtMA";
            this.txtMA.Size = new System.Drawing.Size(172, 21);
            this.txtMA.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(295, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Thực thể";
            // 
            // txtTTYN
            // 
            this.txtTTYN.Location = new System.Drawing.Point(297, 68);
            this.txtTTYN.Name = "txtTTYN";
            this.txtTTYN.Size = new System.Drawing.Size(375, 21);
            this.txtTTYN.TabIndex = 2;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(93, 68);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(44, 17);
            this.checkBox1.TabIndex = 18;
            this.checkBox1.Tag = "2";
            this.checkBox1.Text = "quá";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Checked = true;
            this.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox2.Location = new System.Drawing.Point(93, 90);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(44, 17);
            this.checkBox2.TabIndex = 19;
            this.checkBox2.Tag = "2";
            this.checkBox2.Text = "ghê";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 435);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.aft.ResumeLayout(false);
            this.aft.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.bf.ResumeLayout(false);
            this.bf.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtnnBS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnW.Properties)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnThemTTYN;
        private System.Windows.Forms.Label seed;
        private System.Windows.Forms.TextBox txtSeed;
        private System.Windows.Forms.GroupBox aft;
        private System.Windows.Forms.GroupBox bf;
        private System.Windows.Forms.CheckBox a5;
        private System.Windows.Forms.CheckBox a4;
        private System.Windows.Forms.CheckBox a3;
        private System.Windows.Forms.CheckBox a2;
        private System.Windows.Forms.CheckBox a1;
        private System.Windows.Forms.CheckBox b6;
        private System.Windows.Forms.CheckBox b5;
        private System.Windows.Forms.CheckBox b4;
        private System.Windows.Forms.CheckBox b3;
        private System.Windows.Forms.CheckBox b2;
        private System.Windows.Forms.CheckBox b1;
        private System.Windows.Forms.Label alert;
        private System.Windows.Forms.Button btnThemWOS;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox checkAllA;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.CheckBox checkAllB;
        private System.Windows.Forms.Button btnWatch;
        private DevExpress.XtraEditors.SpinEdit spnW;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnXtract;
        private System.Windows.Forms.Button btnThemWS;
        private Emo_DictionaryDataSet edDS;
        private System.Windows.Forms.BindingSource dtnnBS;
        private Emo_DictionaryDataSetTableAdapters.DAC_TRUNG_NGU_NGHIATableAdapter dtnnTA;
        private Emo_DictionaryDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox ttCb;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTTYN;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMA;
        private System.Windows.Forms.Label alert2lb;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
    }
}

