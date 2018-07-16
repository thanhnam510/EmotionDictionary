using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.UserSkins;
using DevExpress.Skins;
using DevExpress.LookAndFeel;
using System.IO;
using System.Data.SqlClient;
using System.Text;
using System.Data;

namespace EmoDic
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            BonusSkins.Register();
            SkinManager.EnableFormSkins();
            UserLookAndFeel.Default.SetSkinStyle("DevExpress Style");
            Program.CheckConnectString();
        }
        public static string connStr= "";
        public static string path = "";
        public static FileStream fs;
        public static int Count = 0;
        public static SqlConnection conn = new SqlConnection();
        static public void Connect(string server,string db,string user,string pass)
        {

            connStr = "Data Source = "+server + ";Initial Catalog = " + db + "; Persist Security Info=True;User ID = " + user + "; Password=" + pass;
            createFile();
        }
        static public Boolean CheckConnectString()
        {
            path = Directory.GetParent(Directory.GetCurrentDirectory()).ToString();
            path = Directory.GetParent(path) + "\\connstring.txt";
            if (File.Exists(path))
            {
                fs = new FileStream(path, FileMode.Open);
                StreamReader rd = new StreamReader(fs, Encoding.Unicode);
                connStr = rd.ReadLine();
                fs.Close();
                return CheckConnect();
            }
            OpenForm(new frmKetnoi());
            return false;
        }

        static public Boolean CheckConnect()
        {
            try
            {
                SqlConnection sql = new SqlConnection(connStr);
                if (sql.State == System.Data.ConnectionState.Closed)
                {
                    sql.Open();
                    sql.Close();
                    OpenForm(new Main());
                    return true;
                }
            }
            catch (SqlException sqlE)
            {
                if (sqlE.Number == -1 || sqlE.Number == 2 || sqlE.Number == 67)
                {
                    MessageBox.Show("Chuỗi kết nối (Connect string) không đúng hoặc có lỗi khi kết nối đến server.");
                }else
                MessageBox.Show(sqlE.Message);
                foreach (Form frm in Application.OpenForms)
                    if (frm is frmKetnoi)
                        return false;
                OpenForm(new frmKetnoi());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                foreach (Form frm in Application.OpenForms)
                    if (frm is frmKetnoi)
                        return false;
                OpenForm(new frmKetnoi());
            }
            return false;
        }
        public static void OpenForm(Form frm)
        {
            if (Count == 0)
            {
                Count++;
                Application.Run(frm);
            }
            else
            {
                foreach (Form form in Application.OpenForms)
                    if (form is frmKetnoi)
                        form.Hide();
                frm.ShowDialog();
            }
        }

        public static void createFile()
        {
            fs = new FileStream(path, FileMode.Create);//Tạo file mới tên là test.txt            
            StreamWriter sWriter = new StreamWriter(fs, Encoding.UTF8);//fs là 1 FileStream 
            sWriter.WriteLine(connStr);
            sWriter.Flush();
            fs.Close();
        }
        public static int KetNoi()
        {
            if (Program.conn != null && Program.conn.State == ConnectionState.Open)
            {
                Program.conn.Close();
            }
            try
            {
                Program.conn.ConnectionString = Program.connStr;
                Program.conn.Open();
                return 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối CSDL.\nBạn xem lại username và password.\n" + ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
        }
        public static SqlDataReader ExecSqlDataReader(String strLenh)
        {
            SqlDataReader myreader;
            SqlCommand sqlcmd = new SqlCommand(strLenh, Program.conn);
            sqlcmd.CommandType = CommandType.Text;
            if (Program.conn.State == ConnectionState.Closed)
                Program.conn.Open();
            try
            {
                myreader = sqlcmd.ExecuteReader();
                return myreader;
            }
            catch (SqlException ex)
            {
                Program.conn.Close();
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public static DataTable ExecSqlDataTable(String strLenh)
        {
            DataTable dt = new DataTable();
            if (Program.conn.State == ConnectionState.Closed)
                Program.conn.Open();
            SqlDataAdapter da = new SqlDataAdapter(strLenh, Program.conn);
            da.Fill(dt);
            conn.Close();
            return dt;

        }


        public static Boolean ExecSqlNonQuery(String strLenh)
        {
            if (Program.conn.State == ConnectionState.Closed)
                Program.conn.Open();
            SqlCommand sqlcmd = Program.conn.CreateCommand();
            try
            {
                sqlcmd.CommandText = strLenh;
                sqlcmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

    }
}

