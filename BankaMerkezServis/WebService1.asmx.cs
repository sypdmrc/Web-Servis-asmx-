using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data;
using System.Data.SqlClient;


namespace BankaMerkezServis
{
    /// <summary>
    /// Summary description for WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {

        [WebMethod]
        public DataSet BankaBilgiGetir(string tcNo)
        {
            SqlConnectionStringBuilder ayarlar = new SqlConnectionStringBuilder();
            ayarlar.DataSource = "DESKTOP-LABBUN5";
            ayarlar.InitialCatalog = "bankaBilgi";
            ayarlar.IntegratedSecurity = true;
            SqlConnection bgl=new SqlConnection(ayarlar.ConnectionString);

            string bankaBilgi = "select * from MusteriBilgi where tcNo='"+tcNo+"'";
            SqlDataAdapter sadp = new SqlDataAdapter(bankaBilgi, bgl);

            DataSet dt=new DataSet();

            sadp.Fill(dt);
                
            
            return dt;
        }
    }
}
