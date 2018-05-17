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
    public partial class EmotionDictionary_View : Form
    {
        public EmotionDictionary_View()
        {
            InitializeComponent();
        }


        private void EmotionDictionary_View_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'emo_DictionaryDataSet.TuDienCamXuc' table. You can move, or remove it, as needed.
            this.tuDienCamXucTableAdapter.Fill(this.edDS.TuDienCamXuc);
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            delete();
        }

        private void btnRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.tuDienCamXucTableAdapter.Fill(this.edDS.TuDienCamXuc);
        }

        private void delete()
        {
            try
            {
                MessageBox.Show("Bạn có thực sự muốn xóa", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                tdcxBS.RemoveCurrent();
                tuDienCamXucTableAdapter.Update(this.edDS.TuDienCamXuc);
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
    }
}
