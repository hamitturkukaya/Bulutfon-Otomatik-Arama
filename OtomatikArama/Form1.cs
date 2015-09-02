using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Add Bulutfon refences
using Bulutfon.OAuth;
using Bulutfon.OAuth.Win;
using Bulutfon.Sdk;
using Bulutfon.Sdk.Models;
using Bulutfon.Sdk.Models.Post;

namespace OtomatikArama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string client_id = "CLIENT_ID";
            string client_secret = "CLIENT_SECRET";

            /* Tokenları Saklayıp her seferinde giriş yapmadan kullanabilirsiniz */

            if (tokensPresentInDb())
            {
                /* Eğer tokenlar saklandıysa */
                string access_token = getAccessTokenFromDb();
                string refresh_token = getRefreshTokenFromDb();

                Token tkn = new Token(access_token, refresh_token);
                BulutfonWinClient client = new BulutfonWinClient(client_id, client_secret);
                tkn.TokenExpired += client.tokenProviderTokenExpired;
                Authentication.Token = tkn;
                showCallPanel(true);
            }
            else
            {
                /* Baştan token al */
                var loggedIn = LoginForm.Login(client_id, client_secret, this);
                showCallPanel(loggedIn);
            }
            
        }

        private void showCallPanel(bool p)
        {
            if (p)
            {
                btnLogin.Visible = false;
                callPanel.Visible = true;

                // Expire olan token refreshlenince tetiklenecek method
                Authentication.Token.RefreshCallback += TokensRefreshed;
                List<Announcement> announcements = BulutfonApi.GetAnnouncements(Authentication.Token);
                announcementCombo.DataSource = announcements;
                announcementCombo.DisplayMember = "name";
                announcementCombo.ValueMember = "id";

                List<Did> dids = BulutfonApi.GetDids(Authentication.Token);

                didCombo.DataSource = dids;
                didCombo.DisplayMember = "number";
                didCombo.ValueMember = "number";

            }
            else
            {
                MessageBox.Show("Bir Hata Oluştu!");
            }
        }

        void TokensRefreshed(object sender, string access_token, string refreh_token)
        {
            MessageBox.Show("Tokenlar yenilendi.");
            // Update Tokens on db
        }

        private bool tokensPresentInDb()
        {
            // Token Db de tutuluyor mu kontrolü
            return false;
        }

        private string getAccessTokenFromDb()
        {
            return "ACCESS_TOKEN";
        }

        private string getRefreshTokenFromDb()
        {
            return "REFRESH_TOKEN";
        }

        private void makeCallButton_Click(object sender, EventArgs e)
        {
            string title = txtTitle.Text.ToString();
            long did = Convert.ToInt64(didCombo.SelectedValue.ToString());
            string receivers = txtReceivers.Text.ToString();
            int announcement_id = Convert.ToInt32(announcementCombo.SelectedValue.ToString());

            AutomaticCallCreator auto = new AutomaticCallCreator();
            auto.title = title;
            auto.did = did;
            auto.receivers = receivers;
            auto.announcement_id = announcement_id;
            ResponseAutomaticCall response = BulutfonApi.CreateAutomaticCall(Authentication.Token, auto);
            if (response.message != null)
            {
                txtTitle.Clear();
                txtReceivers.Clear();
                MessageBox.Show(response.message);
            }
        }
    }
}
