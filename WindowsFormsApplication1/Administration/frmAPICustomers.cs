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

namespace WindowsFormsApplication1.Administration
{
    public partial class frmAPICustomers : DevExpress.XtraEditors.XtraForm
    {
        public String s1 { get; set; }
        public frmAPICustomers()
        {
            InitializeComponent();
        }


        private async Task UpdateCustomerAsync()
        {
            using (var httpClient = new HttpClient())
            {
                using (var request = new HttpRequestMessage(new HttpMethod("PUT"), "https://creativelineindia.com/wp-json/wc/v3/customers/" + txtid.Text + ""))
                {
                    var base64authorization = Convert.ToBase64String(Encoding.ASCII.GetBytes("ck_1d3f7a9a8dd55295407c7d512bbcf7805cf3166b:cs_87168492d6c089d2bf84bae5d5fd4a9ce3e4852f"));
                    request.Headers.TryAddWithoutValidation("Authorization", $"Basic {base64authorization}");

                    request.Content = new StringContent("{\n  \"email\": \"" + txtemail.Text + "\",\n  \"first_name\": \"" + txtfirst_name.Text + "\",\n  \"last_name\": \"" + txtlast_name.Text + "\",\n  \"billing\": {\n    \"first_name\": \"" + txtfirst_name.Text + "\",\n    \"last_name\": \"" + txtlast_name.Text + "\",\n    \"company\": \"\",\n    \"address_1\": \"" + txtaddress_1.Text + "\",\n    \"address_2\": \"" + txtaddress_2.Text + "\",\n    \"city\": \"" + txtcity.Text + "\",\n    \"state\": \"" + txtstate.Text + "\",\n    \"postcode\": \"" + txtpostcode.Text + "\",\n    \"country\": \"" + txtcountry.Text + "\",\n    \"email\": \"" + txtemail.Text + "\",\n    \"phone\": \"" + txtphone.Text + "\"\n  },\n  \"shipping\": {\n    \"first_name\": \"" + txtfirst_name.Text + "\",\n    \"last_name\": \"" + txtlast_name.Text + "\",\n    \"company\": \"" + txtcompany.Text + "\",\n    \"address_1\": \"" + txtaddress_1.Text + "\",\n    \"address_2\": \"" + txtaddress_2.Text + "\",\n    \"city\": \"" + txtcity.Text + "\",\n    \"state\": \"" + txtstate.Text + "\",\n    \"postcode\": \"" + txtpostcode.Text + "\",\n    \"country\": \"" + txtcountry.Text + "\"\n  }\n}");
                    request.Content.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json");

                    var response = await httpClient.SendAsync(request);
                }
            }
        }


        private async Task DeleteCustomerAsync()
        {
            using (var httpClient = new HttpClient())
            {
                using (var request = new HttpRequestMessage(new HttpMethod("DELETE"), "https://creativelineindia.com/wp-json/wc/v3/customers/"+txtid.Text+"?force=true"))
                {
                    var base64authorization = Convert.ToBase64String(Encoding.ASCII.GetBytes("ck_1d3f7a9a8dd55295407c7d512bbcf7805cf3166b:cs_87168492d6c089d2bf84bae5d5fd4a9ce3e4852f"));
                    request.Headers.TryAddWithoutValidation("Authorization", $"Basic {base64authorization}");

                    var response = await httpClient.SendAsync(request);
                }
            }
        }
        private async Task AddCustomerAsync()
        {
            using (var httpClient = new HttpClient())
            {
                using (var request = new HttpRequestMessage(new HttpMethod("POST"), "https://creativelineindia.com/wp-json/wc/v3/customers"))
                {
                    var base64authorization = Convert.ToBase64String(Encoding.ASCII.GetBytes("ck_1d3f7a9a8dd55295407c7d512bbcf7805cf3166b:cs_87168492d6c089d2bf84bae5d5fd4a9ce3e4852f"));
                    request.Headers.TryAddWithoutValidation("Authorization", $"Basic {base64authorization}");

                    request.Content = new StringContent("{\n  \"email\": \"" + txtemail.Text + "\",\n  \"first_name\": \"" + txtfirst_name.Text + "\",\n  \"last_name\": \"" + txtlast_name.Text + "\",\n  \"billing\": {\n    \"first_name\": \"" + txtfirst_name.Text + "\",\n    \"last_name\": \"" + txtlast_name.Text + "\",\n    \"company\": \"\",\n    \"address_1\": \"" + txtaddress_1.Text + "\",\n    \"address_2\": \"" + txtaddress_2.Text + "\",\n    \"city\": \"" + txtcity.Text + "\",\n    \"state\": \"" + txtstate.Text + "\",\n    \"postcode\": \"" + txtpostcode.Text + "\",\n    \"country\": \"" + txtcountry.Text + "\",\n    \"email\": \"" + txtemail.Text + "\",\n    \"phone\": \"" + txtphone.Text + "\"\n  },\n  \"shipping\": {\n    \"first_name\": \"" + txtfirst_name.Text + "\",\n    \"last_name\": \"" + txtlast_name.Text + "\",\n    \"company\": \"" + txtcompany.Text + "\",\n    \"address_1\": \"" + txtaddress_1.Text + "\",\n    \"address_2\": \"" + txtaddress_2.Text + "\",\n    \"city\": \"" + txtcity.Text + "\",\n    \"state\": \"" + txtstate.Text + "\",\n    \"postcode\": \"" + txtpostcode.Text + "\",\n    \"country\": \"" + txtcountry.Text + "\"\n  }\n}");
                    request.Content.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json");

                    var response = await httpClient.SendAsync(request);
                }
            }
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAPICustomers_Load(object sender, EventArgs e)
        {
            txtid.Enabled = false;
            ProjectFunctions.ToolStripVisualize(Menu_ToolStrip);
            ProjectFunctions.TextBoxVisualize(this);
            if (s1 == "Add")
            {
                txtfirst_name.Focus();
            }
            if (s1 == "Edit")
            {

                txtfirst_name.Focus();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtfirst_name.Text.Trim().Length == 0)
            {
                XtraMessageBox.Show("Invalid firstname");
                txtfirst_name.Focus();
                return;
            }
            if (txtlast_name.Text.Trim().Length == 0)
            {
                XtraMessageBox.Show("Invalid lastname");
                txtlast_name.Focus();
                return;
            }
            if (txtemail.Text.Trim().Length == 0)
            {
                XtraMessageBox.Show("Invalid email ");
                txtemail.Focus();
                return;
            }
            if (txtaddress_1.Text.Trim().Length == 0)
            {
                XtraMessageBox.Show("Invalid address ");
                txtaddress_1.Focus();
                return;
            }
            if (txtaddress_2.Text.Trim().Length == 0)
            {
                XtraMessageBox.Show("Invalid address");
                txtaddress_2.Focus();
                return;
            }
            if (txtcity.Text.Trim().Length == 0)
            {
                XtraMessageBox.Show("Invalid city");
                txtcity.Focus();
                return;
            }
            if (txtstate.Text.Trim().Length == 0)
            {
                XtraMessageBox.Show("Invalid state");
                txtstate.Focus();
                return;
            }
            if (txtpostcode.Text.Trim().Length == 0)
            {
                XtraMessageBox.Show("Invalid postcode");
                txtpostcode.Focus();
                return;
            }
            if (txtcountry.Text.Trim().Length == 0)
            {
                XtraMessageBox.Show("Invalid country");
                txtcountry.Focus();
                return;
            }
           

            if (s1 == "&Add")
            {
                AddCustomerAsync();
                this.Close();
            }
            if (s1 == "Edit")
            {
                UpdateCustomerAsync();
                this.Close();
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            DeleteCustomerAsync();
            this.Close();
        }
    }
}
