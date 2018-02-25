using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace dwFotoWisuda
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            grd.Clear();
            grd.Cols.Count = 5;

            grd.Cols[0].Caption = "NO";
            grd.Cols[0].Name = "NO";
            grd.Cols[0].DataType = typeof(int);

            grd.Cols[1].Caption = "NPM";
            grd.Cols[1].Name = "NPM";
            grd.Cols[1].DataType = typeof(string);

            grd.Cols[2].Caption = "NAMA";
            grd.Cols[2].Name = "NAMA";
            grd.Cols[2].DataType = typeof(string);

            grd.Cols[3].Caption = "FROM AKADEMIK";
            grd.Cols[3].Name = "FOTO_A";
            grd.Cols[3].DataType = typeof(string);

            grd.Cols[4].Caption = "FROM SIDANG";
            grd.Cols[4].Name = "FOTO_S";
            grd.Cols[4].DataType = typeof(string);

            grd.AutoSizeCols();
        }

        private DataTable loadDBF(string FILE_PATH, string DB_FILE)
        {
            string conn = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + FILE_PATH +
                ";Extended Properties=dBASE IV;";
            System.Data.OleDb.OleDbConnection db = new System.Data.OleDb.OleDbConnection(conn);

            string sql = "SELECT * FROM " + DB_FILE;
            System.Data.OleDb.OleDbCommand cmd = new System.Data.OleDb.OleDbCommand(sql, db);
            db.Open();

            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            db.Close();
            db = null;

            return dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string DBFPath = txt_DBFPath.Text;
            string DBFFile = txt_DBFFile.Text;
            string fotoSidangPath = txt_fotoSidangPath.Text;
            string resultPath = txt_resultPath.Text;
            string npm_noFoto = "FAKULTAS : " + DBFFile + "\n";
            string nama_noFoto ="\n";

            DataTable dt = loadDBF(DBFPath, DBFFile);
            grd.Rows.Count = dt.Rows.Count + 1;
            progressBar1.Maximum = grd.Rows.Count;

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                grd[i + 1, "NO"] = i + 1;
                grd[i + 1, "NPM"] = dt.Rows[i]["NPM"].ToString();
                grd[i + 1, "NAMA"] = dt.Rows[i]["NAMA"].ToString();
                grd[i + 1, "FOTO_A"] = "N";
                grd[i + 1, "FOTO_S"] = "N";

                string npm = dt.Rows[i]["NPM"].ToString();
                string nama = dt.Rows[i]["NAMA"].ToString();
                
                try
                {
                    clsImageMySQL img = new clsImageMySQL();
                    byte[] file_foto = img.getImage(npm);
                    if (file_foto != null)
                    {
                        grd[i + 1, "FOTO_A"] = "Y";

                        string fsPath = @"" + fotoSidangPath + "\\" + npm + ".jpg";
                        if (System.IO.File.Exists(fsPath))
                        {
                            grd[i + 1, "FOTO_S"] = "Y";
                        }

                        string path = @"" + resultPath + "\\" + npm + ".jpg";
                        System.IO.File.WriteAllBytes(path, file_foto);
                    }
                    else
                    {

                        string fsPath = @"" + fotoSidangPath + "\\" + npm + ".jpg";
                        if (System.IO.File.Exists(fsPath))
                        {
                            grd[i + 1, "FOTO_S"] = "Y";

                            string path = @"" + resultPath + "\\" + npm + ".jpg";
                            System.IO.File.Copy(fsPath, path);
                        }
                        else
                        {
                            npm_noFoto = npm_noFoto + npm + "\n";
                            nama_noFoto = nama_noFoto + nama + "\n";
                        }
                    }
                    img = null;
                }
                catch (Exception ex)
                {
                    grd[i + 1, "FOTO_A"] = ex.Message;
                }

                System.Threading.Thread.Sleep(300);
                progressBar1.Value = i + 1;

            }

            progressBar1.Value = 0;
            progressBar1.Hide();
            lbl_progress.Text = "Download Complete.";

            lbl_nofoto.Text = npm_noFoto+" "+nama_noFoto;
           
           // lbl_nofoto.Text = nama_noFoto;

            grd.AutoSizeCols();

        }

        private void grd_AfterSort(object sender, C1.Win.C1FlexGrid.SortColEventArgs e)
        {
            for (int i = 1; i < grd.Rows.Count; i++)
            {
                grd[i, "NO"] = i;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openFile.ShowDialog();
            if(openFile.FileName.Trim().Length > 0)
            {
                string[] file = openFile.FileName.Split('\\');
                string dir = "";

                for (int i = 0; i < file.Length - 1; i++)
                {
                    dir += file[i] + "\\";
                }

                txt_DBFPath.Text = dir;
                txt_DBFFile.Text = file[file.Length - 1];
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            folderBroswer.ShowDialog();
            if (folderBroswer.SelectedPath.Trim().Length > 0)
            {
                txt_fotoSidangPath.Text = folderBroswer.SelectedPath;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            folderBroswer.ShowDialog();
            if (folderBroswer.SelectedPath.Trim().Length > 0)
            {
                txt_resultPath.Text = folderBroswer.SelectedPath;
            }
        }

        private void lbl_nofoto_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
