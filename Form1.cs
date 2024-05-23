using System;
using System.Numerics;
using System.Windows.Forms;
using System.Net.Http;
using Newtonsoft.Json.Linq;

namespace BanRX
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Size = new System.Drawing.Size(744, 236);
        }

        private async void checkButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(addyTextBox.Text))
            {
                MessageBox.Show("You must enter an address.");
                return;
            }

            string address = addyTextBox.Text.Trim();
            string apiUrl = $"https://banrx.bananoplanet.cc/api/get_worker_stats/{address}";

            try
            {
                using (HttpClient client = new HttpClient())
                {
                    HttpResponseMessage response = await client.GetAsync(apiUrl);
                    response.EnsureSuccessStatusCode();
                    string jsonResponse = await response.Content.ReadAsStringAsync();

                    JObject jsonObject = JObject.Parse(jsonResponse);

                    onemin.Text = jsonObject["data"]["hashrate"]["1m"].ToString();
                    tenmin.Text = jsonObject["data"]["hashrate"]["10m"].ToString();
                    onehour.Text = jsonObject["data"]["hashrate"]["1h"].ToString();
                    twelvehour.Text = jsonObject["data"]["hashrate"]["12h"].ToString();
                    twentyfourhour.Text = jsonObject["data"]["hashrate"]["24h"].ToString();
                    acceptedshares.Text = jsonObject["data"]["accepted_shares"].ToString();
                    totalhashes.Text = jsonObject["data"]["total_hashes"].ToString();
                    
                    long lastSubmittedTimestamp = jsonObject["data"]["last_submitted_timestamp"].ToObject<long>();
                    DateTimeOffset dateTimeOffset = DateTimeOffset.FromUnixTimeMilliseconds(lastSubmittedTimestamp);
                    DateTime lastSubmittedDateTime = dateTimeOffset.LocalDateTime; 

                    lastsubmitted.Text = lastSubmittedDateTime.ToString("yyyy-MM-dd HH:mm:ss"); 

                    BigInteger pending_raw = BigInteger.Parse(jsonObject["data"]["pending"].ToString(), System.Globalization.NumberStyles.Float);
                    BigInteger paid_raw = BigInteger.Parse(jsonObject["data"]["paid"].ToString(), System.Globalization.NumberStyles.Float);
                    pending.Text = ((decimal)Math.Floor((double)(pending_raw / BigInteger.Parse("10000000000000000000000000")) / 10000)).ToString() + " BAN";
                    paid.Text = ((decimal)Math.Floor((double)(paid_raw / BigInteger.Parse("10000000000000000000000000")) / 10000)).ToString() + " BAN";

                    this.ClientSize = new System.Drawing.Size(744, 445);
                }
            }
            catch (HttpRequestException ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "API Error");
            }
        }
    }
}