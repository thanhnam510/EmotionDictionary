namespace EmoDic
{
    partial class frmXtract
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
            this.txtA = new System.Windows.Forms.TextBox();
            this.btnStart = new DevExpress.XtraEditors.SimpleButton();
            this.lbrs = new System.Windows.Forms.Label();
            this.lbrs2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(28, 12);
            this.txtA.Multiline = true;
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(624, 121);
            this.txtA.TabIndex = 0;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(274, 159);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(121, 31);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Extract";
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lbrs
            // 
            this.lbrs.AutoSize = true;
            this.lbrs.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbrs.Location = new System.Drawing.Point(12, 216);
            this.lbrs.Name = "lbrs";
            this.lbrs.Size = new System.Drawing.Size(33, 17);
            this.lbrs.TabIndex = 2;
            this.lbrs.Text = "1111";
            // 
            // lbrs2
            // 
            this.lbrs2.AutoSize = true;
            this.lbrs2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbrs2.Location = new System.Drawing.Point(12, 289);
            this.lbrs2.Name = "lbrs2";
            this.lbrs2.Size = new System.Drawing.Size(27, 17);
            this.lbrs2.TabIndex = 3;
            this.lbrs2.Text = "111";
            // 
            // frmXtract
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 336);
            this.Controls.Add(this.lbrs2);
            this.Controls.Add(this.lbrs);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.txtA);
            this.Name = "frmXtract";
            this.Text = "Rút trích văn bản";
            this.Load += new System.EventHandler(this.Xtract_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtA;
        private DevExpress.XtraEditors.SimpleButton btnStart;
        private System.Windows.Forms.Label lbrs;
        private System.Windows.Forms.Label lbrs2;
    }
}

