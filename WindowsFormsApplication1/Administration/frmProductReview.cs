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
    public partial class frmProductReview : DevExpress.XtraEditors.XtraForm
    {

        public string S1 { get; set; }
        public string Id { get; set; }
        public string Date_created { get; set; }
        public string Date_created_gmt { get; set; }
        public string Product_id { get; set; }
        public string Status { get; set; }
        public string Reviewer { get; set; }

        public string Reviewer_email { get; set; }

        public string Review { get; set; }

        public string Rating { get; set; }

        public string Verified { get; set; }

        public string Reviewer_avatar_urls { get; set; }
        public string A48 { get; set; }
        public string A96 { get; set; }
        public string _links { get; set; }
        public string Collection { get; set; }
        public string Up { get; set; }



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

        private void FrmProductReview_Load(object sender, EventArgs e)
        {
            txtID.Enabled = false;
            ProjectFunctions.ToolStripVisualize(Menu_ToolStrip);
            ProjectFunctions.TextBoxVisualize(this);
            if (S1 == "Add")
            {
                txtDateCreated.Focus();

            }
            if (S1 == "Edit")
            {
                txtID.Text = Id;
                txtDateCreated.Text = Date_created;
                txtDateCreatedGMT.Text = Date_created_gmt;
                txtProduct_ID.Text = Product_id;
                txtStatus.Text = Status;
                txtReviewer.Text = Reviewer;
                txtReviewerEmail.Text = Reviewer_email;
                txtReview.Text = Review;
                txtRating.Text = Rating;
                txtVerified.Text = Verified;
                txtreviewer_avatar_urls.Text = Reviewer_avatar_urls;
                txtA48.Text = A48;
                txtA96.Text = A96;
                txtLinks.Text = _links;
                txtCollection.Text = Collection;
                txtUp.Text = Up;
                txtDateCreated.Focus();
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            DeleteProductReviewAsync();
            this.Close();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (txtReview.Text.Trim().Length == 0)
            {
                XtraMessageBox.Show("Invalid REVIEW");
                txtReview.Focus();
                return;
            }


            if (S1 == "&Add")
            {
                AddProductReviewAsync();
                this.Close();
            }
            if (S1 == "Edit")
            {
                UpdateProductReviewAsync();
                this.Close();
            }
        }
    }
}