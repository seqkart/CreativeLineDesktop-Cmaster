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
    public partial class frmAPITaxRates : DevExpress.XtraEditors.XtraForm
    {
        public String s1 { get; set; }
        public frmAPITaxRates()
        {
            InitializeComponent();
        }

        private async Task AddTaxRateAsync()
        {
            using (var httpClient = new HttpClient())
            {
                using (var request = new HttpRequestMessage(new HttpMethod("POST"), "https://creativelineindia.com/wp-json/wc/v3/taxes"))
                {
                    var base64authorization = Convert.ToBase64String(Encoding.ASCII.GetBytes("ck_1d3f7a9a8dd55295407c7d512bbcf7805cf3166b:cs_87168492d6c089d2bf84bae5d5fd4a9ce3e4852f"));
                    request.Headers.TryAddWithoutValidation("Authorization", $"Basic {base64authorization}");
                    request.Content = new StringContent("{\n  \"country\": \"" + txtcountry.Text + "\",\n  \"state\": \"" + txtstate.Text + "\",\n  \"cities\": [\"" + txtcity.Text + "\"],\n  \"postcodes\": [\"" + txtpostcode.Text + "\"],\n  \"rate\": \"" + txtrate.Text + "\",\n  \"name\": \"" + txtname.Text + "\",\n  \"shipping\": " + txtshipping.Text + "\n}");
                    request.Content.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json");
                    var response = await httpClient.SendAsync(request);
                }
            }
        }
        private async Task EditTaxRateAsync()
        {
            using (var httpClient = new HttpClient())
            {
                using (var request = new HttpRequestMessage(new HttpMethod("PUT"), "https://creativelineindia.com/wp-json/wc/v3/taxes/" + txtid.Text + ""))
                {
                    var base64authorization = Convert.ToBase64String(Encoding.ASCII.GetBytes("ck_1d3f7a9a8dd55295407c7d512bbcf7805cf3166b:cs_87168492d6c089d2bf84bae5d5fd4a9ce3e4852f"));
                    request.Headers.TryAddWithoutValidation("Authorization", $"Basic {base64authorization}");
                    request.Content = new StringContent("{\n  \"name\": \"" + txtname.Text + "\"\n}");
                    request.Content.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json");
                    var response = await httpClient.SendAsync(request);
                }
            }
        }
        private async Task DeleteTaxRateAsync()
        {
            using (var httpClient = new HttpClient())
            {
                using (var request = new HttpRequestMessage(new HttpMethod("DELETE"), "https://creativelineindia.com/wp-json/wc/v3/taxes/" + txtid.Text + "?force=true"))
                {
                    var base64authorization = Convert.ToBase64String(Encoding.ASCII.GetBytes("ck_1d3f7a9a8dd55295407c7d512bbcf7805cf3166b:cs_87168492d6c089d2bf84bae5d5fd4a9ce3e4852f"));
                    request.Headers.TryAddWithoutValidation("Authorization", $"Basic {base64authorization}");
                    var response = await httpClient.SendAsync(request);
                }
            }
        }

        private void frmAPITaxRates_Load(object sender, EventArgs e)
        {
            txtid.Enabled = false;
            ProjectFunctions.ToolStripVisualize(Menu_ToolStrip);
            ProjectFunctions.TextBoxVisualize(this);
            if (s1 == "&Add")
            {
                txtname.Focus();
            }
            if (s1 == "Edit")
            {
                txtname.Focus();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtname.Text.Trim().Length == 0)
            {
                XtraMessageBox.Show("Invalid name");
                txtname.Focus();
                return;
            }
            if (txtrate.Text.Trim().Length == 0)
            {
                XtraMessageBox.Show("Invalid rate");
                txtrate.Focus();
                return;
            }
            
            if (s1 == "&Add")
            {
                AddTaxRateAsync();
                this.Close();
            }
            if (s1 == "Edit")
            {
                EditTaxRateAsync();
                this.Close();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteTaxRateAsync();
            this.Close();
        }
    }
}