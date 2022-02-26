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
    public partial class frmAPIProducts : DevExpress.XtraEditors.XtraForm
    {
        public String  s1 { get; set; }
        public frmAPIProducts()
        {
            InitializeComponent();
        }



        private async Task AddProductAsync()
        {
            using (var httpClient = new HttpClient())
            {
                using (var request = new HttpRequestMessage(new HttpMethod("POST"), "https://creativelineindia.com/wp-json/wc/v3/products"))
                {
                    var base64authorization = Convert.ToBase64String(Encoding.ASCII.GetBytes("ck_1d3f7a9a8dd55295407c7d512bbcf7805cf3166b:cs_87168492d6c089d2bf84bae5d5fd4a9ce3e4852f"));
                    request.Headers.TryAddWithoutValidation("Authorization", $"Basic {base64authorization}");

                    request.Content = new StringContent("{\n  \"name\": \""+txtname.Text+"\",\n  \"type\": \""+txttype.Text+"\",\n  \"regular_price\": \""+txtregular_price.Text+"\",\n  \"description\": \""+txtdescription.Text+"\",\n  \"short_description\": \""+txtshort_description.Text+"\",\n  \"categories\": [\n    {\n      \"id\": 9\n    },\n    {\n      \"id\": 14\n    }\n  ],\n  \"images\": [\n    {\n      \"src\": \"http://demo.woothemes.com/woocommerce/wp-content/uploads/sites/56/2013/06/T_2_front.jpg\"\n    },\n    {\n      \"src\": \"http://demo.woothemes.com/woocommerce/wp-content/uploads/sites/56/2013/06/T_2_back.jpg\"\n    }\n  ]\n}");
                    request.Content.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json");

                    var response = await httpClient.SendAsync(request);
                }
            }
        }
        private async Task UpdateProductAsync()
        {
            using (var httpClient = new HttpClient())
            {
                using (var request = new HttpRequestMessage(new HttpMethod("PUT"), "https://creativelineindia.com/wp-json/wc/v3/products/" + txtid.Text + ""))
                {
                    var base64authorization = Convert.ToBase64String(Encoding.ASCII.GetBytes("ck_1d3f7a9a8dd55295407c7d512bbcf7805cf3166b:cs_87168492d6c089d2bf84bae5d5fd4a9ce3e4852f"));
                    request.Headers.TryAddWithoutValidation("Authorization", $"Basic {base64authorization}");

                    request.Content = new StringContent("{\n  \"regular_price\": \"" + txtregular_price.Text + "\"\n}");
                    request.Content.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json");

                    var response = await httpClient.SendAsync(request);
                }
            }
        }

        private async Task DeleteProductAsync()
        {
            using (var httpClient = new HttpClient())
            {
                using (var request = new HttpRequestMessage(new HttpMethod("DELETE"), "https://creativelineindia.com/wp-json/wc/v3/products/" + txtid.Text + "?force=true"))
                {
                    var base64authorization = Convert.ToBase64String(Encoding.ASCII.GetBytes("ck_1d3f7a9a8dd55295407c7d512bbcf7805cf3166b:cs_87168492d6c089d2bf84bae5d5fd4a9ce3e4852f"));
                    request.Headers.TryAddWithoutValidation("Authorization", $"Basic {base64authorization}");

                    var response = await httpClient.SendAsync(request);
                }
            }
        }
        private void frmAPIProducts_Load(object sender, EventArgs e)
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
            if (txtdescription.Text.Trim().Length == 0)
            {
                XtraMessageBox.Show("Invalid short description");
                txtdescription.Focus();
                return;
            }
            if (txtshort_description.Text.Trim().Length == 0)
            {
                XtraMessageBox.Show("Invalid short description ");
                txtshort_description.Focus();
                return;
            }
            if (txttype.Text.Trim().Length == 0)
            {
                XtraMessageBox.Show("Invalid type ");
                txttype.Focus();
                return;
            }
            if (txtregular_price.Text.Trim().Length == 0)
            {
                XtraMessageBox.Show("Invalid regular price");
                txtregular_price.Focus();
                return;
            }
           

            if (s1 == "&Add")
            {
                AddProductAsync();
                this.Close();
            }
            if (s1 == "Edit")
            {
                UpdateProductAsync();
                this.Close();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteProductAsync();
            this.Close();
        }
    }
}