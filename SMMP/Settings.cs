using SMMP.Scripts;
using SMMP.Scripts.AI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Reflection.Emit;
using System.Text.Json;
using System.Windows.Forms;

namespace SMMP
{
	public partial class Settings : Form
	{
		public Settings()
		{
			InitializeComponent();

			LoadSettings();

			OpenAIKeyShowButton.Click +=
				(s, e) => ShowPassword(OpenAIKey);

			FacebookAppSecretShowButton.Click +=
				(s, e) => ShowPassword(FacebookAppSecret);

			FacebookAccessTokenShowButton.Click +=
				(s, e) => ShowPassword(FacebookAccessToken);

			FacebookRefreshTokenShowButton.Click +=
				(s, e) => ShowPassword(FacebookRefreshToken);

			InstagramAppSecretShowButton.Click +=
				(s, e) => ShowPassword(InstagramAppSecret);

			InstagramAccessTokenShowButton.Click +=
				(s, e) => ShowPassword(InstagramAccessToken);

			InstagramRefreshTokenShowButton.Click +=
				(s, e) => ShowPassword(InstagramRefreshToken);

			TikTokClientSecretShowButton.Click +=
				(s, e) => ShowPassword(TikTokClientSecret);

			TikTokAccessTokenShowButton.Click +=
				(s, e) => ShowPassword(TikTokAccessToken);

			TikTokRefreshTokenShowButton.Click +=
				(s, e) => ShowPassword(TikTokRefreshToken);
		}
		private void LoadSettings()
		{
			AppSettings settings = SettingsManager.Load();

			OpenAIKey.Text = settings.OpenAIKey;
			AIModel.SelectedItem =
				AIModel.Items.Contains(settings.OpenAIModel)
					? settings.OpenAIModel
					: AIModel.Items[0];

			FacebookAppId.Text = settings.FacebookAppId;
			FacebookAppSecret.Text = settings.FacebookAppSecret;
			FacebookAccessToken.Text = settings.FacebookAccessToken;
			FacebookRefreshToken.Text = settings.FacebookRefreshToken;

			InstagramAppId.Text = settings.InstagramAppId;
			InstagramAppSecret.Text = settings.InstagramAppSecret;
			InstagramAccessToken.Text = settings.InstagramAccessToken;
			InstagramRefreshToken.Text = settings.InstagramRefreshToken;

			TikTokClientId.Text = settings.TikTokClientId;
			TikTokClientSecret.Text = settings.TikTokClientSecret;
			TikTokAccessToken.Text = settings.TikTokAccessToken;
			TikTokRefreshToken.Text = settings.TikTokRefreshToken;
		}
		private async void AITest_Click(object sender, EventArgs e)
		{
			label1.Show();
			try
			{
				string result =
					await AIService.TestConnection(
						OpenAIKey.Text,
						AIModel.Text);

				MessageBox.Show(result);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			label1.Hide();
		}
		private void FacebookTest_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Facebook Test button clicked!");
		}

		private void TestInsta_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Instagram Test button clicked!");
		}

		private void TikTokTest_Click(object sender, EventArgs e)
		{
			MessageBox.Show("TikTok Test button clicked!");
		}

		private void CancelButton_Click(object sender, EventArgs e)
		{
			Close();
		}
		private void ShowPassword(TextBox passwordBox)
		{
			passwordBox.UseSystemPasswordChar =
				!passwordBox.UseSystemPasswordChar;
		}
		private void SaveButton_Click_1(object sender, EventArgs e)
		{
			AppSettings settings = new AppSettings
			{
				OpenAIKey = OpenAIKey.Text,
				OpenAIModel = AIModel.Text,

				FacebookAppId = FacebookAppId.Text,
				FacebookAppSecret = FacebookAppSecret.Text,
				FacebookAccessToken = FacebookAccessToken.Text,
				FacebookRefreshToken = FacebookRefreshToken.Text,

				InstagramAppId = InstagramAppId.Text,
				InstagramAppSecret = InstagramAppSecret.Text,
				InstagramAccessToken = InstagramAccessToken.Text,
				InstagramRefreshToken = InstagramRefreshToken.Text,

				TikTokClientId = TikTokClientId.Text,
				TikTokClientSecret = TikTokClientSecret.Text,
				TikTokAccessToken = TikTokAccessToken.Text,
				TikTokRefreshToken = TikTokRefreshToken.Text
			};

			SettingsManager.Save(settings);

			MessageBox.Show(
				"Settings saved successfully.",
				"Success",
				MessageBoxButtons.OK,
				MessageBoxIcon.Information);
		}

		private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			System.Diagnostics.Process.Start(
	   new ProcessStartInfo
	   {
		   FileName = "https://aistudio.google.com/api-keys",
		   UseShellExecute = true
	   });
		}
	}
}
