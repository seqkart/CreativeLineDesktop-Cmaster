using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1;
namespace School_Management_System
{
    public partial class frmAPICoupon : DevExpress.XtraEditors.XtraForm
    {
        public String s1 { get; set; }
        public frmAPICoupon()
        {
            InitializeComponent();
        }

        private void txtamount_KeyPress(object sender, KeyPressEventArgs e)
        {
            ProjectFunctions.NumericWithDecimal(e);
        }

        private void textEdit1_KeyPress(object sender, KeyPressEventArgs e)
        {
            ProjectFunctions.NumericWithDecimal(e);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private async Task AddCouponAsync()
        {


            using (var httpClient = new HttpClient())
            {
                using (var request = new HttpRequestMessage(new HttpMethod("POST"), "https://creativelineindia.com/wp-json/wc/v3/coupons"))
                {
                    var base64authorization = Convert.ToBase64String(Encoding.ASCII.GetBytes("ck_1d3f7a9a8dd55295407c7d512bbcf7805cf3166b:cs_87168492d6c089d2bf84bae5d5fd4a9ce3e4852f"));
                    request.Headers.TryAddWithoutValidation("Authorization", $"Basic {base64authorization}");
                   // request.Content = new StringContent("{\n  \"code\": \"" + txtcode.Text + "\",\n  \"discount_type\": \"" + txtdiscount_type.Text + "\",\n  \"amount\": \"" + txtamount.Text + "\",\n  \"individual_use\": " + txtindividual_use + ",\n  \"exclude_sale_items\": " + txtexclude_sale_items.Text + ",\n  \"minimum_amount\": \"" + txtminimum_amount.Text + "\"\n}");

                    request.Content = new StringContent("{\n  \"code\": \"" + txtcode.Text + "\",\n  \"discount_type\": \"" + txtdiscount_type.Text + "\",\n  \"amount\": \"" + txtamount.Text + "\",\n  \"individual_use\": " + txtindividual_use.Text + ",\n  \"exclude_sale_items\": " + txtexclude_sale_items.Text + ",\n  \"minimum_amount\": \"" + txtminimum_amount.Text + "\"\n}");
                    request.Content.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json");

                    var response = await httpClient.SendAsync(request);
                }
            }


            //using (var httpClient = new HttpClient())
            //{
            //    using (var request = new HttpRequestMessage(new HttpMethod("POST"), "https://creativelineindia.com/wp-json/wc/v3/coupons"))
            //    {
            //      //  var base64authorization = Convert.ToBase64String(Encoding.ASCII.GetBytes("ck_1d3f7a9a8dd55295407c7d512bbcf7805cf3166b:cs_87168492d6c089d2bf84bae5d5fd4a9ce3e4852f"));
            //        request.Headers.TryAddWithoutValidation("Authorization", $"Basic Y2tfMWQzZjdhOWE4ZGQ1NTI5NTQwN2M3ZDUxMmJiY2Y3ODA1Y2YzMTY2Yjpjc184NzE2ODQ5MmQ2YzA4OWQyYmY4NGJhZTVkNWZkNGE5Y2UzZTQ4NTJm");
            //       // request.Headers["Authorization"] = "Basic Y2tfMWQzZjdhOWE4ZGQ1NTI5NTQwN2M3ZDUxMmJiY2Y3ODA1Y2YzMTY2Yjpjc184NzE2ODQ5MmQ2YzA4OWQyYmY4NGJhZTVkNWZkNGE5Y2UzZTQ4NTJm";



            //        request.Content = new StringContent("{\n  \"code\": \"" + txtcode.Text + "\",\n  \"discount_type\": \"" + txtdiscount_type.Text + "\",\n  \"amount\": \"" + txtamount.Text + "\",\n  \"individual_use\": " + txtindividual_use + ",\n  \"exclude_sale_items\": " + txtexclude_sale_items.Text + ",\n  \"minimum_amount\": \"" + txtminimum_amount.Text + "\"\n}");
            //        request.Content.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json");

            //        var response = await httpClient.SendAsync(request);
            //    }
            //}
        }


        private async Task DeleteCouponsAsync()
        {
            using (var httpClient = new HttpClient())
            {
                using (var request = new HttpRequestMessage(new HttpMethod("DELETE"), "https://creativelineindia.com/wp-json/wc/v3/coupons/" + txtid.Text + "?force=true"))
                {
                    var base64authorization = Convert.ToBase64String(Encoding.ASCII.GetBytes("ck_1d3f7a9a8dd55295407c7d512bbcf7805cf3166b:cs_87168492d6c089d2bf84bae5d5fd4a9ce3e4852f"));
                    request.Headers.TryAddWithoutValidation("Authorization", $"Basic {base64authorization}");

                    var response = await httpClient.SendAsync(request);
                }
            }
        }
        
        private async Task EditCouponAsync()
        {
            using (var httpClient = new HttpClient())
            {
                using (var request = new HttpRequestMessage(new HttpMethod("PUT"), "https://creativelineindia.com/wp-json/wc/v3/coupons/" + txtid.Text + "")) 
                {
                    var base64authorization = Convert.ToBase64String(Encoding.ASCII.GetBytes("ck_1d3f7a9a8dd55295407c7d512bbcf7805cf3166b:cs_87168492d6c089d2bf84bae5d5fd4a9ce3e4852f"));
                    request.Headers.TryAddWithoutValidation("Authorization", $"Basic {base64authorization}");

                    request.Content = new StringContent("{\n  \"amount\": \"" + txtamount.Text + "\"\n}");
                    request.Content.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json");

                    var response = await httpClient.SendAsync(request);
                }
            }
        }

        private  void btnSave_Click(object sender, EventArgs e)
        {
            if (txtcode.Text.Trim().Length == 0)
            {
                XtraMessageBox.Show("Invalid code");
                txtcode.Focus();
                return;
            }
            if (txtdiscount_type.Text.Trim().Length == 0)
            {
                XtraMessageBox.Show("Invalid discount type");
                txtdiscount_type.Focus();
                return;
            }
            if (txtexclude_sale_items.Text.Trim().Length == 0)
            {
                XtraMessageBox.Show("Invalid txtexclude_sale_items ");
                txtexclude_sale_items.Focus();
                return;
            }
            if (txtexclude_sale_items.Text.Trim().Length == 0)
            {
                XtraMessageBox.Show("Invalid txtexclude_sale_items ");
                txtexclude_sale_items.Focus();
                return;
            }  
            if (txtamount.Text.Trim().Length==0)
            {
                XtraMessageBox.Show("Invalid Amount");
                txtamount.Focus();
                return;
            }
            if (txtminimum_amount.Text.Trim().Length == 0)
            {
                XtraMessageBox.Show("Invalid Minimum Amount");
                txtminimum_amount.Focus();
                return;
            }


            if (s1 == "&Add")
            {
                AddCouponAsync();
                this.Close();
            }
            if (s1 == "Edit")
            {
                EditCouponAsync();
                this.Close();
            }
        }

        private void frmAPICoupon_Load(object sender, EventArgs e)
        {
            txtid.Enabled = false;
            ProjectFunctions.ToolStripVisualize(Menu_ToolStrip);
            ProjectFunctions.TextBoxVisualize(this);
            if (s1 == "&Add")
            {
                txtcode.Focus();

            }
            if (s1 == "Edit")
            {
                txtcode.Focus();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteCouponsAsync();
            this.Close();
        }
    }
}