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
    public partial class FrmAPIProducts : DevExpress.XtraEditors.XtraForm
    {
        public string S1 { get; set; }
        public FrmAPIProducts()
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

                    request.Content = new StringContent("{\n  \"name\": \""+txtname.Text+"\",\n  \"type\": \""+txttype.Text+"\",\n  \"regular_price\": \""+txtregular_price.Text+ "\",\n  \"sale_price\": \"" + txtsale_price.Text + "\",\n  \"price\": \"" + txtprice.Text + "\",\n  \"description\": \"" + txtdescription.Text+"\",\n  \"short_description\": \""+txtshort_description.Text+"\",\n  \"categories\": [\n    {\n      \"id\": 9\n    },\n    {\n      \"id\": 14\n    }\n  ],\n  \"images\": [\n    {\n      \"src\": \"http://demo.woothemes.com/woocommerce/wp-content/uploads/sites/56/2013/06/T_2_front.jpg\"\n    },\n    {\n      \"src\": \"http://demo.woothemes.com/woocommerce/wp-content/uploads/sites/56/2013/06/T_2_back.jpg\"\n    }\n  ]\n}");
                    request.Content.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json");

                    var response = await httpClient.SendAsync(request);
                    if (response.StatusCode.ToString() == "Created")
                    {
                        XtraMessageBox.Show("API Product Created");
                    }
                    else
                    {
                        XtraMessageBox.Show("There is something wrong");

                    }
                }
            }
        }
        private async Task UpdateProductAsync()
        {
            using (var httpClient = new HttpClient())
            {
                using (var request = new HttpRequestMessage(new HttpMethod("PUT"), "https://creativelineindia.com/wp-json/wc/v3/products/"+txtid.Text+""))
                {
                    var base64authorization = Convert.ToBase64String(Encoding.ASCII.GetBytes("ck_1d3f7a9a8dd55295407c7d512bbcf7805cf3166b:cs_87168492d6c089d2bf84bae5d5fd4a9ce3e4852f"));
                    request.Headers.TryAddWithoutValidation("Authorization", $"Basic {base64authorization}");

                    request.Content = new StringContent("{\n  \"name\": \""+txtname.Text+"\",\n  \"type\": \""+txttype.Text+"\",\n  \"regular_price\": \""+txtregular_price.Text+"\",\n  \"price\": \""+txtprice.Text+"\",\n  \"sale_price\": \""+txtsale_price.Text+"\",\n  \"description\": \""+txtdescription.Text+"\",\n  \"short_description\": \""+txtshort_description.Text+"\",\n  \"categories\": [\n    {\n      \"id\": 9\n    },\n    {\n      \"id\": 14\n    }\n  ],\n  \"images\": [\n    {\n      \"src\": \"http://demo.woothemes.com/woocommerce/wp-content/uploads/sites/56/2013/06/T_2_front.jpg\"\n    },\n    {\n      \"src\": \"http://demo.woothemes.com/woocommerce/wp-content/uploads/sites/56/2013/06/T_2_back.jpg\"\n    }\n  ]\n}");
                    request.Content.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json");

                    var response = await httpClient.SendAsync(request);
                    if (response.StatusCode.ToString() == "OK")
                    {
                        XtraMessageBox.Show("API Product Updated");
                    }
                    else
                    {
                        XtraMessageBox.Show("There is something wrong");

                    }
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
                    if (response.StatusCode.ToString() == "OK")
                    {
                        XtraMessageBox.Show("API Product Deleted");
                    }
                    else
                    {
                        XtraMessageBox.Show("There is something wrong");

                    }
                }
            }
        }
        private void FrmAPIProducts_Load(object sender, EventArgs e)
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
            if (txtsale_price.Text.Trim().Length == 0)
            {
                XtraMessageBox.Show("Invalid sale price");
                txtsale_price.Focus();
                return;
            }
            if (txtprice.Text.Trim().Length == 0)
            {
                XtraMessageBox.Show("Invalid  price");
                txtprice.Focus();
                return;
            }
            if (S1 == "&Add")
            {
                AddProductAsync();
                this.Close();
            }
            if (S1 == "Edit")
            {
                UpdateProductAsync();
                this.Close();
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            DeleteProductAsync();
            this.Close();
        }
    }
}