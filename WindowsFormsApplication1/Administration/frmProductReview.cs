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
    public partial class frmProductReview : DevExpress.XtraEditors.XtraForm
    {

        public String s1 { get; set; }
        public String id { get; set; }
        public String date_created { get; set; }
        public String date_created_gmt { get; set; }
        public String product_id { get; set; }
        public String status { get; set; }
        public String reviewer { get; set; }

        public String reviewer_email { get; set; }

        public String review { get; set; }

        public String rating { get; set; }

        public String verified { get; set; }

        public String reviewer_avatar_urls { get; set; }
        public String A48 { get; set; }
        public String A96 { get; set; }
        public String _links { get; set; }
        public String collection { get; set; }
        public String up { get; set; }



        public frmProductReview()
        {
            InitializeComponent();
        }

        private async Task AddProductReviewAsync()
        {
            using (var httpClient = new HttpClient())
            {
                using (var request = new HttpRequestMessage(new HttpMethod("POST"), "https://creativelineindia.com/wp-json/wc/v3/products/reviews"))
                {
                    var base64authorization = Convert.ToBase64String(Encoding.ASCII.GetBytes("ck_1d3f7a9a8dd55295407c7d512bbcf7805cf3166b:cs_87168492d6c089d2bf84bae5d5fd4a9ce3e4852f"));
                    request.Headers.TryAddWithoutValidation("Authorization", $"Basic {base64authorization}");

                    request.Content = new StringContent("{\n  \"product_id\": " + txtProduct_ID.Text + ",\n  \"review\": \"" + txtReview.Text + "\",\n  \"reviewer\": \"" + txtReviewer.Text + "\",\n  \"reviewer_email\": \"" + txtReviewerEmail.Text + "\",\n  \"rating\": " + txtRating.Text + "\n}");
                    request.Content.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json");

                    var response = await httpClient.SendAsync(request);
                }
            }
        }
        private async Task UpdateProductReviewAsync()
        {
            using (var httpClient = new HttpClient())
            {
                using (var request = new HttpRequestMessage(new HttpMethod("PUT"), "https://creativelineindia.com/wp-json/wc/v3/products/reviews/" + txtID.Text + ""))
                {
                    var base64authorization = Convert.ToBase64String(Encoding.ASCII.GetBytes("ck_1d3f7a9a8dd55295407c7d512bbcf7805cf3166b:cs_87168492d6c089d2bf84bae5d5fd4a9ce3e4852f"));
                    request.Headers.TryAddWithoutValidation("Authorization", $"Basic {base64authorization}");

                    request.Content = new StringContent("{\n  \"rating\": " + txtRating.Text + "\n}");
                    request.Content.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json");

                    var response = await httpClient.SendAsync(request);
                }
            }
        }
        private async Task DeleteProductReviewAsync()
        {
            using (var httpClient = new HttpClient())
            {
                using (var request = new HttpRequestMessage(new HttpMethod("DELETE"), "https://creativelineindia.com/wp-json/wc/v3/products/reviews/" + txtID.Text + "?force=true"))
                {
                    var base64authorization = Convert.ToBase64String(Encoding.ASCII.GetBytes("ck_1d3f7a9a8dd55295407c7d512bbcf7805cf3166b:cs_87168492d6c089d2bf84bae5d5fd4a9ce3e4852f"));
                    request.Headers.TryAddWithoutValidation("Authorization", $"Basic {base64authorization}");

                    var response = await httpClient.SendAsync(request);
                }
            }
        }
        private void Menu_ToolStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            this.Close();
        }

        private void frmProductReview_Load(object sender, EventArgs e)
        {
            txtID.Enabled = false;
            ProjectFunctions.ToolStripVisualize(Menu_ToolStrip);
            ProjectFunctions.TextBoxVisualize(this);
            if (s1 == "Add")
            {
                txtDateCreated.Focus();

            }
            if (s1 == "Edit")
            {
                txtID.Text = id;
                txtDateCreated.Text = date_created;
                txtDateCreatedGMT.Text = date_created_gmt;
                txtProduct_ID.Text = product_id;
                txtStatus.Text = status;
                txtReviewer.Text = reviewer;
                txtReviewerEmail.Text = reviewer_email;
                txtReview.Text = review;
                txtRating.Text = rating;
                txtVerified.Text = verified;
                txtreviewer_avatar_urls.Text = reviewer_avatar_urls;
                txtA48.Text = A48;
                txtA96.Text = A96;
                txtLinks.Text = _links;
                txtCollection.Text = collection;
                txtUp.Text = up;
                txtDateCreated.Focus();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteProductReviewAsync();
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtReview.Text.Trim().Length == 0)
            {
                XtraMessageBox.Show("Invalid REVIEW");
                txtReview.Focus();
                return;
            }


            if (s1 == "&Add")
            {
                AddProductReviewAsync();
                this.Close();
            }
            if (s1 == "Edit")
            {
                UpdateProductReviewAsync();
                this.Close();
            }
        }
    }
}