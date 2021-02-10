

using System;

using System.Linq;

namespace SeqKartSecurity.Connections
{
    public class ConnectionStringsDb
    {
        // public static string DefaultConnectionString = @"Data Source=seqkart.ddns.net;Initial Catalog=SEQKARTNew;User ID=sa;pwd=Seq@2021";
        //String HO = System.IO.File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + @"\HO.txt");




        public static string DefaultConnectionString = @"Data Source=cserver;Initial Catalog=SEQKARTnew;User ID=sa;pwd=Seq@2021";
        public static string ImageConnectionString = @"Data Source = cserver; Initial Catalog = EFileSeqKart; User ID = sa; pwd=Seq@2021";
    }

}