using System;
using System.Data;
using System.Data.Odbc;

public class clsImageMySQL
{
    //private string _strConn =
    //    @"Driver={MySQLODBC 3.51 Driver};SERVER=202.125.94.9;DATABASE=sidangsarjana;Uid=jurusan;Pwd=remoteremote;";

    private string _strConn =
       @"Driver={MySQL ODBC 5.2 Unicode Driver};SERVER=202.125.94.9;DATABASE=sidangsarjana;Uid=jurusan;Pwd=remoteremote;";
    private string p_IP = "sisapi.gunadarma.ac.id";
    private string p_DB = "sidangsarjana";
    private string p_UID = "jurusan";
    private string p_PASS = "remoteremote";

    private System.Data.Odbc.OdbcConnection _objConn;

    public clsImageMySQL()
	{
        //_strConn = @"Driver={MySQL ODBC 5.2 Unicode Driver};SERVER=" + p_IP +
        //    ";DATABASE=" + p_DB + ";Uid=" + p_UID + ";Pwd=" + p_PASS + ";OPTION=3;";

        //WIN7 64bit gak dapet ODBC, mesti pake DSN
        _strConn = @"DSN=sidang2;SERVER=" + p_IP +
            ";DATABASE=" + p_DB + ";Uid=" + p_UID + ";Pwd=" + p_PASS + ";OPTION=3;";

        this._objConn = new OdbcConnection(this._strConn);
	}

    public string addImage(byte[] buffer, string NPM)
    {
        string strSql = "SELECT * FROM data_sidang WHERE NPM='" + NPM + "'";
        DataSet ds = new DataSet("Image");
        OdbcDataAdapter tempAP = new OdbcDataAdapter(strSql, this._objConn);
        OdbcCommandBuilder objCommand = new OdbcCommandBuilder(tempAP);
        tempAP.Fill(ds, "DATA");

        DataTable dt = ds.Tables["DATA"];
        if (dt.Rows.Count == 0)
        {
            try
            {
                this._objConn.Open();
                DataRow objNewRow = ds.Tables["DATA"].NewRow();
                objNewRow["NPM"] = NPM;
                objNewRow["FILE_FOTO"] = buffer;
                ds.Tables["DATA"].Rows.Add(objNewRow);
                // trying to update the table to add the image
                tempAP.Update(ds, "DATA");
            }
            catch (Exception e) { return e.Message; }
            finally { this._objConn.Close(); }
        }
        else
        {
            try
            {
                this._objConn.Open();
                dt.Rows[0]["FILE_FOTO"] = buffer;
                //DataRow objNewRow = ds.Tables["DATA"].NewRow();
                //objNewRow["NPM"] = NPM;
                //objNewRow["FILE_FOTO"] = buffer;
                //ds.Tables["DATA"].Rows.Add(objNewRow);
                // trying to update the table to add the image
                tempAP.Update(ds, "DATA");
            }
            catch (Exception e) { return e.Message; }
            finally { this._objConn.Close(); }
        }

        return "OK";
    }

    // This function to get the image data from the database
    public byte[] getImage(string NPM)
    {
        string strSql = "SELECT FILE_FOTO FROM data_sidang WHERE NPM='" + NPM + "'";
        DataSet ds = new DataSet("Image");
        OdbcDataAdapter tempAP = new OdbcDataAdapter(strSql, this._objConn);
        OdbcCommandBuilder objCommand = new OdbcCommandBuilder(tempAP);
        tempAP.Fill(ds, "DATA");

        DataTable dt = ds.Tables["DATA"];
        if (dt.Rows.Count > 0)
        {
            try
            {
                this._objConn.Open();
                byte[] buffer = (byte[])dt.Rows[0]["FILE_FOTO"];
                return buffer;
            }
            catch { this._objConn.Close(); return null; }
            finally { this._objConn.Close(); }
        }
        else
            return null;
    }

    // Get the image count
    public int getCount()
    {
        string strSql = "SELECT COUNT(FILE_FOTO) FROM data_sidang";
        DataSet ds = new DataSet("Image");
        OdbcDataAdapter tempAP = new OdbcDataAdapter(strSql,this._objConn);
        OdbcCommandBuilder objCommand = new OdbcCommandBuilder(tempAP);
        tempAP.Fill(ds,"DATA");

        try
        {
            this._objConn.Open();
            int count = (int)ds.Tables["DATA"].Rows[0][0];
            return count;
        }
        catch{this._objConn.Close();return 0;}
        finally{this._objConn.Close();}
    }

}
