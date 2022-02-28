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
    public partial class FrmShippingZones : DevExpress.XtraEditors.XtraForm
    {
        public string S1 { get; set; }
        public string ID { get; set; }
        public string Name { get; set; }
        public string Order { get; set; }
        public string Link { get; set; }
        public string Collection { get; set; }
        public string DescribedBy { get; set; }
        public FrmShippingZones()
        {
            InitializeComponent();
        }

        private async Task AddShippingZoneAsync()
        {
            using (var httpClient = new HttpClient())
            {
                using (var request = new HttpRequestMessage(new HttpMethod("POST"), "https://creativelineindia.com/wp-json/wc/v3/shipping/zones"))
                {
                    var base64authorization = Convert.ToBase64String(Encoding.ASCII.GetBytes("ck_1d3f7a9a8dd55295407c7d512bbcf7805cf3166b:cs_87168492d6c089d2bf84bae5d5fd4a9ce3e4852f"));
                    request.Headers.TryAddWithoutValidation("Authorization", $"Basic {base64authorization}");

                    request.Content = new StringContent("{\n  \"name\": \"" + txtName.Text + "\"\n}");
                    request.Content.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json");

                    var response = await httpClient.SendAsync(request);
                }
            }
        }
        private async Task UpdateShippingZoneAsync()
        {
            using (var httpClient = new HttpClient())
            {
                using (var request = new HttpRequestMessage(new HttpMethod("PUT"), "https://creativelineindia.com/wp-json/wc/v3/shipping/zones/" + txtID.Text + ""))
                {
                    var base64authorization = Convert.ToBase64String(Encoding.ASCII.GetBytes("ck_1d3f7a9a8dd55295407c7d512bbcf7805cf3166b:cs_87168492d6c089d2bf84bae5d5fd4a9ce3e4852f"));
                    request.Headers.TryAddWithoutValidation("Authorization", $"Basic {base64authorization}");

                    request.Content = new StringContent("{\n  \"name\": \"" + txtName.Text + "\"\n}");
                    request.Content.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json");

                    var response = await httpClient.SendAsync(request);
                }
            }
        }
        private async Task DeleteShippingZoneAsync()
        {
            using (var httpClient = new HttpClient())
            {
                using (var request = new HttpRequestMessage(new HttpMethod("DELETE"), "https://creativelineindia.com/wp-json/wc/v3/shipping/zones/"+ txtID.Text + "?force=true"))
                {
                    var base64authorization = Convert.ToBase64String(Encoding.ASCII.GetBytes("ck_1d3f7a9a8dd55295407c7d512bbcf7805cf3166b:cs_87168492d6c089d2bf84bae5d5fd4a9ce3e4852f"));
                    request.Headers.TryAddWithoutValidation("Authorization", $"Basic {base64authorization}");

                    var response = await httpClient.SendAsync(request);
                }
            }   
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmShippingZones_Load(object sender, EventArgs e)
        {
            txtID.Enabled = false;
            ProjectFunctions.ToolStripVisualize(Menu_ToolStrip);
            ProjectFunctions.TextBoxVisualize(this);
            if (S1 == "Add")
            {
                txtName.Focus();

            }
            if (S1 == "Edit")
            {
                txtID.Text = ID;
                txtName.Text = Name;
                txtOrder.Text = Order;
                txt_Links.Text = Link;
                txtCollection.Text = Collection;
                txtDescribedBy.Text = DescribedBy;
                txtName.Focus();
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            DeleteShippingZoneAsync();
            this.Close();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (txtName.Text.Trim().Length == 0)
            {
                XtraMessageBox.Show("Invalid Shipping Zone");
                txtName.Focus();
                return;
            }
            

            if (S1 == "&Add")
            {
                AddShippingZoneAsync();
                this.Close();
            }
            if (S1 == "Edit")
            {
                UpdateShippingZoneAsync ();
                this.Close();
            }
        }
    }
}