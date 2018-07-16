using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmoDic
{
    public partial class frmTuDien : Form
    {
        public frmTuDien()
        {
            InitializeComponent();
        }


        private void EmotionDictionary_View_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'edDS.DAC_TRUNG_NGU_NGHIA' table. You can move, or remove it, as needed.
            this.dAC_TRUNG_NGU_NGHIATableAdapter.Fill(this.edDS.DAC_TRUNG_NGU_NGHIA);
            // TODO: This line of code loads data into the 'edDS.DAC_TRUNG_CAM_XUC' table. You can move, or remove it, as needed.
            this.dAC_TRUNG_CAM_XUCTableAdapter.Fill(this.edDS.DAC_TRUNG_CAM_XUC);
            // TODO: This line of code loads data into the 'emo_DictionaryDataSet.TRONG_SO' table. You can move, or remove it, as needed.
            this.tsTA.Fill(this.edDS.TRONG_SO);
            // TODO: This line of code loads data into the 'emo_DictionaryDataSet.TuDienCamXuc' table. You can move, or remove it, as needed.
            //tuDienCamXucTableAdapter.Connection.ConnectionString = Program.connStr;
            // this.tuDienCamXucTableAdapter.Fill(this.edDS.TuDienCamXuc);
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            delete();
        }

        private void btnRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //this.tuDienCamXucTableAdapter.Fill(this.edDS.TuDienCamXuc);
        }

        private void delete()
        {
            try
            {
                MessageBox.Show("Bạn có thực sự muốn xóa", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                tsBS.RemoveCurrent();
                //tuDienCamXucTableAdapter.Update(this.edDS.TuDienCamXuc);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void gridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                delete();
            }
        }

        private void tRONG_SOBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tsBS.EndEdit();
            this.tableAdapterManager.UpdateAll(this.edDS);

        }
    }
}
