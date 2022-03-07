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
    public partial class FrmAPITaxRates : DevExpress.XtraEditors.XtraForm
    {
        public String S1 { get; set; }
        public FrmAPITaxRates()
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

        private void FrmAPITaxRates_Load(object sender, EventArgs e)
        {
            txtid.Enabled = false;
            ProjectFunctions.ToolStripVisualize(Menu_ToolStrip);
            ProjectFunctions.TextBoxVisualize(this);
            if (S1 == "&Add")
            {
                txtname.Focus();
            }
            if (S1 == "Edit")
            {
                txtname.Focus();
            }
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnSave_Click(object sender, EventArgs e)
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
            
            if (S1 == "&Add")
            {
                AddTaxRateAsync();
                this.Close();
            }
            if (S1 == "Edit")
            {
                EditTaxRateAsync();
                this.Close();
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            DeleteTaxRateAsync();
            this.Close();
        }
    }
}