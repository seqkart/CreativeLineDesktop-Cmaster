using DevExpress.XtraEditors;
using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.Administration
{
    public partial class FrmProductCategories : DevExpress.XtraEditors.XtraForm
    {
        public string S1 { get; set; }

        public string Id { get; set; }
        public string Name { get; set; }
        public string Slug { get; set; }
        public string Parent { get; set; }
        public string Description { get; set; }
        public string Display { get; set; }
        public string Image { get; set; }
        public string Date_created { get; set; }
        public string Date_created_gmt { get; set; }
        public string Date_modified_gmt { get; set; }
        public string Src { get; set; }
        public string Alt { get; set; }
        public string Menu_order { get; set; }
        public string Count { get; set; }
        public string Links { get; set; }
        public string Collection { get; set; }
        public FrmProductCategories()
        {
            InitializeComponent();
        }

        private void BtnClose_Click(object sender, EventArgs e)
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

                    request.Content = new StringContent("{\n  \"name\": \"" + txtname.Text + "\",\n  \"image\": {\n    \"src\": \"http://demo.woothemes.com/woocommerce/wp-content/uploads/sites/56/2013/06/T_2_front.jpg\"\n  }\n}");
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
        private void FrmProductCategories_Load(object sender, EventArgs e)
        {
            txtid.Enabled = false;
            ProjectFunctions.ToolStripVisualize(Menu_ToolStrip);
            ProjectFunctions.TextBoxVisualize(this);
            if (S1 == "Add")
            {
                txtname.Focus();
            }
            if (S1 == "Edit")
            {
                txtid.Text = Id;
                txtid.Text = Id;
                txtname.Text = Name;
                txtslug.Text = Slug;
                txtparent.Text = Parent;
                txtdescription.Text = Description;
                txtdisplay.Text = Display;
                txtimage.Text = Image;
                txtdate_created.Text = Date_created;
                txtdate_created_gmt.Text = Date_created_gmt;
                txtdate_modified_gmt.Text = Date_modified_gmt;
                txtsrc.Text = Src;
                txtalt.Text = Alt;
                txtmenu_order.Text = Menu_order;
                txtcount.Text = Count;
                txt_links.Text = Links;
                txtcollection.Text = Collection;
                txtname.Focus();
            }
        }

        private void ToolStripButton1_Click(object sender, EventArgs e)
        {
            DeleteCategoryAsync();
            this.Close();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (txtname.Text.Trim().Length == 0)
            {
                XtraMessageBox.Show("Invalid category name");
                txtname.Focus();
                return;
            }


            if (S1 == "&Add")
            {
                AddCategoryAsync();
                this.Close();
            }
            if (S1 == "Edit")
            {
                UpdateCategoryAsync();
                this.Close();
            }
        }
    }
}