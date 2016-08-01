﻿using System;
using System.Windows.Forms;
using System.Threading.Tasks;

using Tangine.GitHub;
using System.Diagnostics;

namespace Tanji.Pages.About
{
    public class AboutPage : TanjiPage
    {
        public GitRepository TanjiRepo { get; }

        public Version LocalVersion { get; }
        public Version LatestVersion { get; private set; }

        public AboutPage(MainFrm ui, TabPage tab)
            : base(ui, tab)
        {
            TanjiRepo = new GitRepository("Tangerinos", "Tanji");
            LocalVersion = new Version(Application.ProductVersion);

            UI.DonateBtn.Click += DonateBtn_Click;

            UI.Shown += UI_Shown;
            UI.TanjiVersionTxt.Text = ("v" + LocalVersion);
        }

        private async void UI_Shown(object sender, EventArgs e)
        {
            UI.Shown -= UI_Shown;

            GitRelease latestRelease =
                await TanjiRepo.GetLatestReleaseAsync();

            if (latestRelease != null)
            {
                LatestVersion = new Version(
                    latestRelease.TagName.Substring(1));

                UI.TanjiVersionTxt.IsLink = true;

                if (LatestVersion > LocalVersion &&
                    !latestRelease.IsPrerelease)
                {
                    UI.TanjiVersionTxt.Text = "Update Found!";
                }
            }
        }

        private void DonateBtn_Click(object sender, EventArgs e)
        {
            string business = "theoldnutman@gmail.com";
            string description = "Donation";
            string country = "US";
            string currency = "USD";

            string url = "https://www.paypal.com/cgi-bin/webscr" +
                "?cmd=" + "_donations" +
                "&business=" + business +
                "&lc=" + country +
                "&item_name=" + description +
                "&currency_code=" + currency +
                "&bn=" + "PP%2dDonationsBF";

            Process.Start(url);
        }
    }
}