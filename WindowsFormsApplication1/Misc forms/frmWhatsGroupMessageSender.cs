using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1.Miscforms
{
    public partial class FrmWhatsGroupMessageSender : DevExpress.XtraEditors.XtraForm
    {
        public FrmWhatsGroupMessageSender()
        {
            InitializeComponent();
        }


        private void FillGrid()
        {
            DataSet ds = new DataSet();
            ds = ProjectFunctions.GetDataSet("Select * from WhatsAppContacts");
            if (ds.Tables[0].Rows.Count > 0)
            {
                ds.Tables[0].Columns.Add("Select", typeof(bool));
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    dr["Select"] = false;
                }

                ContactGrid.DataSource = ds.Tables[0];
                ContactGridView.BestFitColumns();
            }
            else
            {
                ContactGrid.DataSource = null;
                ContactGridView.BestFitColumns();
            }
        }
        private void BtnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmWhatsGroupMessageSender_Load(object sender, EventArgs e)
        {
            ProjectFunctions.ToolStripVisualize(Menu_ToolStrip);
            FillGrid();
        }

        private void ContactGridView_PopupMenuShowing(object sender, DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs e)
        {
            e.Menu.Items
                    .Add(new DevExpress.Utils.Menu.DXMenuItem("Select All Records",
                                                              (o1, e1) =>
                                                              {
                                                                  var MaxRow = ((ContactGrid.FocusedView as GridView).RowCount);
                                                                  // var MaxRow = ((InvoiceGrid.KeyboardFocusView as GridView).RowCount);
                                                                  for (var i = 0; i < MaxRow; i++)
                                                                  {
                                                                      ContactGridView.SetRowCellValue(i,
                                                                                                      ContactGridView.Columns["Select"],
                                                                                                      true);
                                                                  }
                                                              }));
            e.Menu.Items
                .Add(new DevExpress.Utils.Menu.DXMenuItem("UnSelect All Records",
                                                          (o1, e1) =>
                                                          {
                                                              var MaxRow = ((ContactGrid.FocusedView as GridView).RowCount);
                                                                  //     var MaxRow = ((InvoiceGrid.KeyboardFocusView as GridView).RowCount);
                                                                  for (var i = 0; i < MaxRow; i++)
                                                              {
                                                                  ContactGridView.SetRowCellValue(i,
                                                                                               ContactGridView.Columns["Select"],
                                                                                                  false);
                                                              }
                                                          }));
        }



        public static async Task SendMessageAsync(String ContactNo, String Message)
        {
            using (var httpClient = new HttpClient())
            {
                using (var request = new HttpRequestMessage(new HttpMethod("POST"), "http://103.223.12.170:3000/91" + ContactNo + "/sendText"))
                {
                    request.Headers.TryAddWithoutValidation("accept", "application/json");
                    //request.Content = new StringContent("{\"text\":\"*GREETINGS FROM CREATIVE LINE* <br> Offer%20you%20can%E2%80%99t%20resist/%20/*Flat%2050%%20off%20on%20New%20Winter%20Wear%20Collection*/%20/T&C%20Apply/%20/At:%20CREATIVE%20LINE%20SHOWROOM,%201-G,%20SARABHA%20NAGAR,%20LUDHIANA/%22\",\"sendLinkPreview\":false}");
                     
                    request.Content = new StringContent("{\"text\":\"*GREETINGS FROM CREATIVE LINE* \n Offer you can’t resist\n \n*Flat 50% off on New Winter Wear Collection*\n \nT&C Apply\n \nAt: CREATIVE LINE SHOWROOM, 1-G, SARABHA NAGAR, LUDHIANA\",\"sendLinkPreview\":false}");
                    request.Content.Headers.ContentType = System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");

                    var response = await httpClient.SendAsync(request);
                }
            }
        }

        //public static async Task SendMessageAsync(String ContactNo,String Message)
        //{
        //    ////String Message = richEditControl1.Text;

        //     Message = @"GREETINGS FROM CREATIVE LINE  Offer you can’t resist  Flat 50 % off on New Winter Wear Collection \n         T & C Apply             At: CREATIVE LINE SHOWROOM, 1 - G, SARABHA NAGAR, LUDHIANA";

        //    ////Message = Message + "Flat 50 % off on New Winter Wear Collection \n ";
        //    ////Message = Message + "T & C Apply \n ";
        //    ////Message = Message + "At: CREATIVE LINE SHOWROOM, 1 - G, SARABHA NAGAR, LUDHIANA";

        //    using (var httpClient = new HttpClient())
        //    {
        //        using (var request = new HttpRequestMessage(new HttpMethod("POST"), "http://103.223.12.170:3000/91" + ContactNo.Trim() + "/sendText"))
        //        {
        //            request.Headers.TryAddWithoutValidation("accept", "application/json");

        //            request.Content = new StringContent("{\"text\":\"" + Message + "\",\"sendLinkPreview\":false}");
        //            request.Content.Headers.ContentType = System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");

        //            var response = await httpClient.SendAsync(request);

        //            //XtraMessageBox.Show(response.StatusCode.ToString());
        //        }
        //    }
        //}
        public static async Task SendImageAsync(String MobileNo, String ImageLoc)
        {
            //byte[] imageBytes = System.IO.File.ReadAllBytes("C://Temp//GST//" + DocNo + ".pdf");
            byte[] imageBytes = System.IO.File.ReadAllBytes(ImageLoc);

            string base64String = Convert.ToBase64String(imageBytes);

            using (var httpClient = new HttpClient())
            {
                using (var request = new HttpRequestMessage(new HttpMethod("POST"), "http://103.223.12.170:3000/91" + MobileNo + "/sendMedia"))
                {
                    request.Headers.TryAddWithoutValidation("accept", "application/json");

                    request.Content = new StringContent("{\"base64data\":\"" + base64String + "\",\"mimeType\":\"image/jpeg\",\"caption\":\"\",\"filename\":\"\"}");
                    request.Content.Headers.ContentType = System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");

                    var response = await httpClient.SendAsync(request);
                }
            }

        }
        private void BtnSave_Click(object sender, EventArgs e)
        {
            foreach (DataRow dr in (ContactGrid.DataSource as DataTable).Rows)
            {
                if (dr["Select"].ToString().ToUpper() == "TRUE")
                {
                    SendMessageAsync(dr["WhatsAppNo"].ToString(), txtmsg.Text.Trim());
                    SendImageAsync(dr["WhatsAppNo"].ToString(), @"E:\IMAGE1.JPEG");
                    SendImageAsync(dr["WhatsAppNo"].ToString(), @"E:\IMAGE2.JPEG");
                    SendImageAsync(dr["WhatsAppNo"].ToString(), @"E:\IMAGE3.JPEG");
                }
            }
        }
    }
}