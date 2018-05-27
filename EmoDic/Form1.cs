using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EmoDic
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        private List<CheckBox> before;
        private List<CheckBox> after;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tuDienCamXucTableAdapter.Connection.ConnectionString = Program.connStr;
            this.tuDienCamXucTableAdapter.Fill(this.ed_DS.TuDienCamXuc);
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
        }

        private void add_Click(object sender, EventArgs e)
        {
            if (txtSeed.Text == "")
            {
                alert.Text = "Seed không được để trống";
                txtSeed.Focus();
                return;
            }
            AddNewSeed(txtSeed.Text.Trim());
        }
        private void AddNewSeed(String seed)
        {
            try
            {
                tuDienCamXucTableAdapter.Insert(txtSeed.Text, 1, true);
                AddNotSeed(seed);
                alert.Text = "Thêm thành công";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        private void update_Click(object sender, EventArgs e)
        {
            if (txtSeed.Text == "")
            {
                alert.Text = "Seed không được để trống";
                return;
            }
            Update(txtSeed.Text);
        }

        private void Update(String seed)
        {
            AddNotSeed(seed);
            alert.Text = "Thêm thành công";
        }

        private void AddNotSeed(String seed)
        {
            String emo;
            short weight;
            foreach (CheckBox box in before)
            {
                try
                {
                    if (box.Checked)
                    {
                        emo = box.Text + " " + seed;
                        weight = short.Parse(box.Tag.ToString());
                        tuDienCamXucTableAdapter.Insert(emo, weight, false);
                    }
                }
                catch { }
            }
            foreach (CheckBox box in after)
            {
                try
                {
                    if (box.Checked)
                    {
                        emo = seed + " " + box.Text;
                        weight = short.Parse(box.Tag.ToString());
                        tuDienCamXucTableAdapter.Insert(emo, weight, false);
                    }
                }
                catch { }
            }
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
            Form frm = new EmotionDictionary_View();
            frm.Show();
        }
    }
}
