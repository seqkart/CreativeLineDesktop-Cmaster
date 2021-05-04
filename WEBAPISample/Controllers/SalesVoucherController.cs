using Newtonsoft.Json;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web.Http;

namespace WEBAPISample.Controllers
{
    public class SalesVoucherController : ApiController
    {

        SqlConnection con = new SqlConnection(Class1.GetConnection());
        // GET: api/SalesVoucher
        public String Get()
        {
            SqlDataAdapter da = new SqlDataAdapter("sp_ExportSalesVouFBusy  '2021-03-19 00:00:00.000','232','GST','01' ,'2020-2021'", con);
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

        // GET: api/SalesVoucher/5
        public string Get(Int64 id)
        {
            SqlDataAdapter da = new SqlDataAdapter("sp_ExportSalesVouFBusyIDWise  '" + id + "'", con);
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
    }

    //// POST: api/SalesVoucher
    //public void Post([FromBody]string value)
    //{
    //}

    //// PUT: api/SalesVoucher/5
    //public void Put(int id, [FromBody]string value)
    //{
    //}

    //// DELETE: api/SalesVoucher/5
    //public void Delete(int id)
    //{
    //}
}
