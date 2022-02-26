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
    public partial class frmProductCategories : DevExpress.XtraEditors.XtraForm
    {
        public String s1 { get; set; }

        public String id { get; set; }
        public String name { get; set; }
        public String slug { get; set; }
        public String parent { get; set; }
        public String description { get; set; }
        public String display { get; set; }
        public String image { get; set; }
        public String date_created { get; set; }
        public String date_created_gmt { get; set; }
        public String date_modified_gmt { get; set; }
        public String src { get; set; }
        public String alt { get; set; }
        public String menu_order { get; set; }
        public String count { get; set; }
        public String _links { get; set; }
        public String collection { get; set; }
        public frmProductCategories()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private async Task AddCategoryAsync()
        {
            using (var httpClient = new HttpClient())
            {
                using (var request = new HttpRequestMessage(new HttpMethod("POST"), "https://creativelineindia.com/wp-json/wc/v3/products/categories"))
                {
                    var base64authorization = Convert.ToBase64String(Encoding.ASCII.GetBytes("ck_1d3f7a9a8dd55295407c7d512bbcf7805cf3166b:cs_87168492d6c089d2bf84bae5d5fd4a9ce3e4852f"));
                    request.Headers.TryAddWithoutValidation("Authorization", $"Basic {base64authorization}");

                    request.Content = new StringContent("{\n  \"name\": \""+txtname.Text+"\",\n  \"image\": {\n    \"src\": \"http://demo.woothemes.com/woocommerce/wp-content/uploads/sites/56/2013/06/T_2_front.jpg\"\n  }\n}");
                    request.Content.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json");

                    var response = await httpClient.SendAsync(request);
                }
            }
        }
        private async Task UpdateCategoryAsync()
        {
            using (var httpClient = new HttpClient())
            {
                using (var request = new HttpRequestMessage(new HttpMethod("PUT"), "https://creativelineindia.com/wp-json/wc/v3/products/categories/" + txtid.Text + ""))
                {
                    var base64authorization = Convert.ToBase64String(Encoding.ASCII.GetBytes("ck_1d3f7a9a8dd55295407c7d512bbcf7805cf3166b:cs_87168492d6c089d2bf84bae5d5fd4a9ce3e4852f"));
                    request.Headers.TryAddWithoutValidation("Authorization", $"Basic {base64authorization}");

                    request.Content = new StringContent("{\n  \"description\": \"" + txtdescription.Text + "\"\n}");
                    request.Content.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json");

                    var response = await httpClient.SendAsync(request);
                }
            }
        }
        private async Task DeleteCategoryAsync()
        {
            using (var httpClient = new HttpClient())
            {
                using (var request = new HttpRequestMessage(new HttpMethod("DELETE"), "https://creativelineindia.com/wp-json/wc/v3/products/categories/" + txtid.Text + "?force=true"))
                {
                    var base64authorization = Convert.ToBase64String(Encoding.ASCII.GetBytes("ck_1d3f7a9a8dd55295407c7d512bbcf7805cf3166b:cs_87168492d6c089d2bf84bae5d5fd4a9ce3e4852f"));
                    request.Headers.TryAddWithoutValidation("Authorization", $"Basic {base64authorization}");

                    var response = await httpClient.SendAsync(request);
                }
            }
        }
        private void frmProductCategories_Load(object sender, EventArgs e)
        {
            txtid.Enabled = false;
            ProjectFunctions.ToolStripVisualize(Menu_ToolStrip);
            ProjectFunctions.TextBoxVisualize(this);
            if (s1 == "Add")
            {
                txtname.Focus();
            }
            if (s1 == "Edit")
            {
                txtid.Text = id;
                txtid.Text = id;
                txtname.Text = name;
                txtslug.Text = slug;
                txtparent.Text = parent;
                txtdescription  .Text = description;
                txtdisplay.Text = display;
                txtimage.Text = image;
                txtdate_created.Text = date_created;
                txtdate_created_gmt.Text = date_created_gmt;
                txtdate_modified_gmt.Text = date_modified_gmt;
                txtsrc.Text = src;
                txtalt.Text = alt;
                txtmenu_order.Text = menu_order;
                txtcount.Text = count;
                txt_links.Text = _links;
                txtcollection.Text = collection;
                txtname.Focus();
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            DeleteCategoryAsync();
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtname.Text.Trim().Length == 0)
            {
                XtraMessageBox.Show("Invalid category name");
                txtname.Focus();
                return;
            }


            if (s1 == "&Add")
            {
                AddCategoryAsync();
                this.Close();
            }
            if (s1 == "Edit")
            {
                UpdateCategoryAsync();
                this.Close();
            }
        }
    }
}