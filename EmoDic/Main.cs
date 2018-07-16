using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EmoDic
{
    public partial class Main : DevExpress.XtraEditors.XtraForm
    {
        private List<CheckBox> before;
        private List<CheckBox> after;
        public Main()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'edDS.TRONG_SO' table. You can move, or remove it, as needed.
            
            // TODO: This line of code loads data into the 'edDS.DAC_TRUNG_CAM_XUC' table. You can move, or remove it, as needed.
            // TODO: This line of code loads data into the 'emo_DictionaryDataSet.DAC_TRUNG_NGU_NGHIA' table. You can move, or remove it, as needed.
            this.dtnnTA.Fill(this.edDS.DAC_TRUNG_NGU_NGHIA);

            before = bf.Controls.OfType<CheckBox>().ToList<CheckBox>();
            after = aft.Controls.OfType<CheckBox>().ToList<CheckBox>();
            foreach (CheckBox box in before)
                box.CheckedChanged += new System.EventHandler(this.before_CheckBox_CheckedChange);
            foreach (CheckBox box in after)
                box.CheckedChanged += new System.EventHandler(this.after_CheckBox_CheckedChange);
            checkAllA.Click += new System.EventHandler(this.checkAllA_CheckedChange);
            checkAllB.Click += new System.EventHandler(this.checkAllB_CheckedChange);
            checkAllA.Checked = checkAllB.Checked = true;
            txtSeed.Focus();
            ttCb.SelectedIndex = 1;
            ttCb.SelectedIndex = 0;
        }

        private void add_Click(object sender, EventArgs e)
        {
            if (txtMA.Text == "")
            {
                alert2lb.Text = "Không được để trống mã thực thể";
                txtMA.Focus();
                return;
            }
            if (txtTTYN.Text == "")
            {
                alert2lb.Text = "Không được để trống thực thể ý nghĩa";
                txtTTYN.Focus();
                return;
            }
            try
            {
                dtnnTA.Insert(txtMA.Text.Trim(), txtTTYN.Text.Trim());
                this.dtnnTA.Fill(this.edDS.DAC_TRUNG_NGU_NGHIA);
                this.ttCb.DataSource = this.dtnnBS;
                alert2lb.Text = "THêm thành công";
                int temp = ttCb.SelectedIndex;
                ttCb.SelectedIndex = 1;
                ttCb.SelectedIndex = temp;
            }
            catch (Exception ex)
            {
                alert2lb.Text = "Thêm thất bại";
                MessageBox.Show(ex.Message);
            }
        }

        private void update_Click(object sender, EventArgs e)
        {
            int dem;
            if (txtSeed.Text == "")
            {
                alert.Text = "Không được để trống";
                return;
            }
            if (Program.KetNoi() == 0) return;
            dem = Add(ttCb.SelectedValue.ToString(), txtSeed.Text, (short)spnW.Value, false);
            AddNotSeed(txtSeed.Text,dem);
        }

        private int Add(string id,string tuCamXuc,short trongSo,bool hatGiong)
        {
            SqlDataReader myReader;
            int ret =0;
            string strLenh = "exec [dbo].[SP_Them] N'" + id + "',N'" + tuCamXuc + "'," + trongSo + "," + hatGiong;
            try
            {
                myReader = Program.ExecSqlDataReader(strLenh);
                myReader.Read();
                ret = myReader.GetInt32(0);
                myReader.Close();
            }
            catch (Exception ex)
            {
              //  MessageBox.Show(ex.Message);
            }
            return ret;
        }

        private void AddNotSeed(string seed, int d)
        {
            int tong = 1;
            int dem = d;
            try
            {
                foreach (CheckBox box in before)
                {
                    if (box.Checked)
                    {
                        tong++;
                        string emo = box.Text + " " + seed;
                        short weight = (short)spnW.Value;
                        weight *= short.Parse(box.Tag.ToString());
                        string id = ttCb.SelectedValue.ToString().Trim();
                        dem += Add(id, emo, weight, false);
                    }
                }
                foreach (CheckBox box in after)
                {
                    if (box.Checked)
                    {
                        tong++;
                        string emo = seed + " " + box.Text;
                        short weight = (short)spnW.Value;
                        weight *= short.Parse(box.Tag.ToString());
                        string id = ttCb.SelectedValue.ToString().Trim();
                        dem += Add(id, emo, weight, false);
                    }
                }
            }
            catch { }
            alert.Text = "Thêm thành công"+ dem+"/"+tong;
        }

        private void before_CheckBox_CheckedChange(object sender, EventArgs e)
        {
            if (Count(before) == before.Count)
                checkAllB.Checked = true;
            else
                checkAllB.Checked = false;
        }
        private void after_CheckBox_CheckedChange(object sender, EventArgs e)
        {
            if (Count(after) == after.Count)
                checkAllA.Checked = true;
            else
                checkAllA.Checked = false;
        }
        private void checkAllA_CheckedChange(object sender, EventArgs e)
        {
            if (checkAllA.Checked)
                checkAll(after);
            else
                uncheckAll(after);
        }
        private void checkAllB_CheckedChange(object sender, EventArgs e)
        {
            if (checkAllB.Checked)
                checkAll(before);
            else
                uncheckAll(before);
        }
        private int Count(List<CheckBox> l)
        {
            int count = 0;
            foreach(CheckBox box in l)
            {
                if (box.Checked)
                    count++;
            }
            return count;
        }

        private void checkAll(List<CheckBox> l)
        {
            foreach (CheckBox box in l)
                box.Checked = true;
        }

        private void uncheckAll(List<CheckBox> l)
        {
            foreach (CheckBox box in l)
                box.Checked = false;
        }

        private void reset_Click(object sender, EventArgs e)
        {
            txtSeed.Text = "";
            txtSeed.Focus();
        }

        private void btnWatch_Click(object sender, EventArgs e)
        {
            Form frm = new frmTuDien();
            frm.Show();
        }

        private void spinEdit1_EditValueChanged(object sender, EventArgs e)
        {
            if (spnW.Value >3)
                spnW.Value = 3;
            if (spnW.Value < -3)
                spnW.Value = -3;
        }

        private void btnXtract_Click(object sender, EventArgs e)
        {
            Form frm = new frmXtract();
            frm.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            int dem;
            if (txtSeed.Text == "")
            {
                alert.Text = "Không được để trống từ cảm xúc";
                txtSeed.Focus();
                return;
            }
            if (Program.KetNoi() == 0) return;
            try
            {
                dem = Add(ttCb.SelectedValue.ToString(), txtSeed.Text, (short)spnW.Value, true);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã tồn tại, hãy kiểm tra lại từ cảm xúc \n" + ex.Message);
                txtSeed.Focus();
                return;
            }
            AddNotSeed(txtSeed.Text.Trim(),dem);
        }

        private void dAC_TRUNG_NGU_NGHIABindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.dtnnBS.EndEdit();
            this.tableAdapterManager.UpdateAll(this.edDS);

        }
    }
}
