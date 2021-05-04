using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WEBAPISample.Controllers
{
    public class SalesReturnVoucherController : ApiController
    {
        SqlConnection con = new SqlConnection(Class1.GetConnection());
        // GET: api/SalesReturnVoucher
        public String Get()
        {
            SqlDataAdapter da = new SqlDataAdapter("sp_ExportCreditNoteVouFBusy  '2021-04-02 00:00:00.000','1','RG','01' ,'2021-2022' ", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                return JsonConvert.SerializeObject(dt);
            }
            else
            {
                return "No Data Found";
            }
        }

        // GET: api/SalesReturnVoucher/5
        public string Get(Int64 id)
        {
            SqlDataAdapter da = new SqlDataAdapter("sp_ExportCreditNoteVouFBusyIDWise  '" + id + "'", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                return JsonConvert.SerializeObject(dt);
            }
            else
            {
                return "No Data Found";
            }
        }

        // POST: api/SalesReturnVoucher
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/SalesReturnVoucher/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/SalesReturnVoucher/5
        public void Delete(int id)
        {
        }
    }
}
