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
            OpenForm(new Form2());
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
                    OpenForm(new Form1());
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                foreach (Form frm in Application.OpenForms)
                    if (frm is Form2)
                        return false;
                OpenForm(new Form2());
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
                    if (form is Form2)
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
    }
}
