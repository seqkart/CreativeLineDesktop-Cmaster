
using DevExpress.Utils.Menu;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;

using DevExpress.XtraReports.UI;


using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;

using System.Linq;

using System.Net;

using System.Threading.Tasks;
using System.Windows.Forms;
using System;

namespace SeqKartSecurity.Connections
{
    public class ConnectionStringsDb
    {
        // public static string DefaultConnectionString = @"Data Source=seqkart.ddns.net;Initial Catalog=SEQKARTNew;User ID=sa;pwd=Seq@2021";
         //String HO = System.IO.File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + @"\HO.txt");
     

       
        
        public static string DefaultConnectionString = @"Data Source=cserver;Initial Catalog=SEQKART;User ID=sa;pwd=Seq@2021";
        public static string ImageConnectionString = @"Data Source = seqkart.ddns.net; Initial Catalog = EFileSeqKart; User ID = sa; pwd=Seq@2021";
    }

}