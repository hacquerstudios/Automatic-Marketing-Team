namespace SMMP
{
	partial class Settings
	{
		private System.ComponentModel.IContainer components = null;

		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		private void InitializeComponent()
		{
			SettingsTabs = new TabControl();
			AITab = new TabPage();
			AIModel = new ComboBox();
			label1 = new Label();
			OpenAIKeyShowButton = new Button();
			AITest = new Button();
			OpenAIKey = new TextBox();
			FacebookTab = new TabPage();
			FacebookRefreshTokenShowButton = new Button();
			FacebookAccessTokenShowButton = new Button();
			FacebookAppSecretShowButton = new Button();
			FacebookTest = new Button();
			FacebookAppId = new TextBox();
			FacebookAppSecret = new TextBox();
			FacebookAccessToken = new TextBox();
			FacebookRefreshToken = new TextBox();
			InstagramTab = new TabPage();
			InstagramRefreshTokenShowButton = new Button();
			InstagramAccessTokenShowButton = new Button();
			InstagramAppSecretShowButton = new Button();
			TestInsta = new Button();
			InstagramAppId = new TextBox();
			InstagramAppSecret = new TextBox();
			InstagramAccessToken = new TextBox();
			InstagramRefreshToken = new TextBox();
			TikTokTab = new TabPage();
			TikTokRefreshTokenShowButton = new Button();
			TikTokAccessTokenShowButton = new Button();
			TikTokClientSecretShowButton = new Button();
			TikTokTest = new Button();
			TikTokClientId = new TextBox();
			TikTokClientSecret = new TextBox();
			TikTokAccessToken = new TextBox();
			TikTokRefreshToken = new TextBox();
			SaveButton = new Button();
			CancelButton = new Button();
			linkLabel1 = new LinkLabel();
			SettingsTabs.SuspendLayout();
			AITab.SuspendLayout();
			FacebookTab.SuspendLayout();
			InstagramTab.SuspendLayout();
			TikTokTab.SuspendLayout();
			SuspendLayout();
			// 
			// SettingsTabs
			// 
			SettingsTabs.Controls.Add(AITab);
			SettingsTabs.Controls.Add(FacebookTab);
			SettingsTabs.Controls.Add(InstagramTab);
			SettingsTabs.Controls.Add(TikTokTab);
			SettingsTabs.Location = new Point(12, 12);
			SettingsTabs.Name = "SettingsTabs";
			SettingsTabs.SelectedIndex = 0;
			SettingsTabs.Size = new Size(760, 390);
			SettingsTabs.TabIndex = 0;
			// 
			// AITab
			// 
			AITab.Controls.Add(linkLabel1);
			AITab.Controls.Add(AIModel);
			AITab.Controls.Add(label1);
			AITab.Controls.Add(OpenAIKeyShowButton);
			AITab.Controls.Add(AITest);
			AITab.Controls.Add(OpenAIKey);
			AITab.Location = new Point(4, 24);
			AITab.Name = "AITab";
			AITab.Size = new Size(752, 362);
			AITab.TabIndex = 0;
			AITab.Text = "AI";
			// 
			// AIModel
			// 
			AIModel.DropDownStyle = ComboBoxStyle.DropDownList;
			AIModel.FormattingEnabled = true;
			AIModel.Items.AddRange(new object[] { "gemini-3.5-flash", "gemini-3.5-flash-lite" });
			AIModel.Location = new Point(10, 59);
			AIModel.Name = "AIModel";
			AIModel.Size = new Size(300, 23);
			AIModel.TabIndex = 6;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(682, 318);
			label1.Name = "label1";
			label1.Size = new Size(67, 15);
			label1.TabIndex = 4;
			label1.Text = "Please Wait";
			label1.Visible = false;
			// 
			// OpenAIKeyShowButton
			// 
			OpenAIKeyShowButton.Location = new Point(709, 30);
			OpenAIKeyShowButton.Name = "OpenAIKeyShowButton";
			OpenAIKeyShowButton.Size = new Size(47, 23);
			OpenAIKeyShowButton.TabIndex = 3;
			OpenAIKeyShowButton.Text = "show";
			OpenAIKeyShowButton.UseVisualStyleBackColor = true;
			// 
			// AITest
			// 
			AITest.Location = new Point(674, 336);
			AITest.Name = "AITest";
			AITest.Size = new Size(75, 23);
			AITest.TabIndex = 2;
			AITest.Text = "AI Test";
			AITest.UseVisualStyleBackColor = true;
			AITest.Click += AITest_Click;
			// 
			// OpenAIKey
			// 
			OpenAIKey.Location = new Point(10, 30);
			OpenAIKey.Name = "OpenAIKey";
			OpenAIKey.PlaceholderText = "OpenAI API Key";
			OpenAIKey.Size = new Size(700, 23);
			OpenAIKey.TabIndex = 0;
			OpenAIKey.UseSystemPasswordChar = true;
			// 
			// FacebookTab
			// 
			FacebookTab.Controls.Add(FacebookRefreshTokenShowButton);
			FacebookTab.Controls.Add(FacebookAccessTokenShowButton);
			FacebookTab.Controls.Add(FacebookAppSecretShowButton);
			FacebookTab.Controls.Add(FacebookTest);
			FacebookTab.Controls.Add(FacebookAppId);
			FacebookTab.Controls.Add(FacebookAppSecret);
			FacebookTab.Controls.Add(FacebookAccessToken);
			FacebookTab.Controls.Add(FacebookRefreshToken);
			FacebookTab.Location = new Point(4, 24);
			FacebookTab.Name = "FacebookTab";
			FacebookTab.Size = new Size(752, 362);
			FacebookTab.TabIndex = 1;
			FacebookTab.Text = "Facebook";
			// 
			// FacebookRefreshTokenShowButton
			// 
			FacebookRefreshTokenShowButton.Location = new Point(702, 140);
			FacebookRefreshTokenShowButton.Name = "FacebookRefreshTokenShowButton";
			FacebookRefreshTokenShowButton.Size = new Size(47, 23);
			FacebookRefreshTokenShowButton.TabIndex = 7;
			FacebookRefreshTokenShowButton.Text = "show";
			FacebookRefreshTokenShowButton.UseVisualStyleBackColor = true;
			// 
			// FacebookAccessTokenShowButton
			// 
			FacebookAccessTokenShowButton.Location = new Point(705, 99);
			FacebookAccessTokenShowButton.Name = "FacebookAccessTokenShowButton";
			FacebookAccessTokenShowButton.Size = new Size(47, 23);
			FacebookAccessTokenShowButton.TabIndex = 6;
			FacebookAccessTokenShowButton.Text = "show";
			FacebookAccessTokenShowButton.UseVisualStyleBackColor = true;
			// 
			// FacebookAppSecretShowButton
			// 
			FacebookAppSecretShowButton.Location = new Point(705, 60);
			FacebookAppSecretShowButton.Name = "FacebookAppSecretShowButton";
			FacebookAppSecretShowButton.Size = new Size(47, 23);
			FacebookAppSecretShowButton.TabIndex = 5;
			FacebookAppSecretShowButton.Text = "show";
			FacebookAppSecretShowButton.UseVisualStyleBackColor = true;
			// 
			// FacebookTest
			// 
			FacebookTest.Location = new Point(647, 336);
			FacebookTest.Name = "FacebookTest";
			FacebookTest.Size = new Size(102, 23);
			FacebookTest.TabIndex = 4;
			FacebookTest.Text = "Test Connecton";
			FacebookTest.UseVisualStyleBackColor = true;
			FacebookTest.Click += FacebookTest_Click;
			// 
			// FacebookAppId
			// 
			FacebookAppId.Location = new Point(10, 20);
			FacebookAppId.Name = "FacebookAppId";
			FacebookAppId.PlaceholderText = "Facebook App ID";
			FacebookAppId.Size = new Size(700, 23);
			FacebookAppId.TabIndex = 0;
			// 
			// FacebookAppSecret
			// 
			FacebookAppSecret.Location = new Point(10, 60);
			FacebookAppSecret.Name = "FacebookAppSecret";
			FacebookAppSecret.PlaceholderText = "Facebook App Secret";
			FacebookAppSecret.Size = new Size(700, 23);
			FacebookAppSecret.TabIndex = 1;
			FacebookAppSecret.UseSystemPasswordChar = true;
			// 
			// FacebookAccessToken
			// 
			FacebookAccessToken.Location = new Point(10, 100);
			FacebookAccessToken.Name = "FacebookAccessToken";
			FacebookAccessToken.PlaceholderText = "Facebook Access Token";
			FacebookAccessToken.Size = new Size(700, 23);
			FacebookAccessToken.TabIndex = 2;
			// 
			// FacebookRefreshToken
			// 
			FacebookRefreshToken.Location = new Point(10, 140);
			FacebookRefreshToken.Name = "FacebookRefreshToken";
			FacebookRefreshToken.PlaceholderText = "Facebook Refresh Token";
			FacebookRefreshToken.Size = new Size(700, 23);
			FacebookRefreshToken.TabIndex = 3;
			// 
			// InstagramTab
			// 
			InstagramTab.Controls.Add(InstagramRefreshTokenShowButton);
			InstagramTab.Controls.Add(InstagramAccessTokenShowButton);
			InstagramTab.Controls.Add(InstagramAppSecretShowButton);
			InstagramTab.Controls.Add(TestInsta);
			InstagramTab.Controls.Add(InstagramAppId);
			InstagramTab.Controls.Add(InstagramAppSecret);
			InstagramTab.Controls.Add(InstagramAccessToken);
			InstagramTab.Controls.Add(InstagramRefreshToken);
			InstagramTab.Location = new Point(4, 24);
			InstagramTab.Name = "InstagramTab";
			InstagramTab.Size = new Size(752, 362);
			InstagramTab.TabIndex = 2;
			InstagramTab.Text = "Instagram";
			// 
			// InstagramRefreshTokenShowButton
			// 
			InstagramRefreshTokenShowButton.Location = new Point(702, 140);
			InstagramRefreshTokenShowButton.Name = "InstagramRefreshTokenShowButton";
			InstagramRefreshTokenShowButton.Size = new Size(47, 23);
			InstagramRefreshTokenShowButton.TabIndex = 8;
			InstagramRefreshTokenShowButton.Text = "show";
			InstagramRefreshTokenShowButton.UseVisualStyleBackColor = true;
			// 
			// InstagramAccessTokenShowButton
			// 
			InstagramAccessTokenShowButton.Location = new Point(705, 99);
			InstagramAccessTokenShowButton.Name = "InstagramAccessTokenShowButton";
			InstagramAccessTokenShowButton.Size = new Size(47, 23);
			InstagramAccessTokenShowButton.TabIndex = 7;
			InstagramAccessTokenShowButton.Text = "show";
			InstagramAccessTokenShowButton.UseVisualStyleBackColor = true;
			// 
			// InstagramAppSecretShowButton
			// 
			InstagramAppSecretShowButton.Location = new Point(709, 60);
			InstagramAppSecretShowButton.Name = "InstagramAppSecretShowButton";
			InstagramAppSecretShowButton.Size = new Size(47, 23);
			InstagramAppSecretShowButton.TabIndex = 6;
			InstagramAppSecretShowButton.Text = "show";
			InstagramAppSecretShowButton.UseVisualStyleBackColor = true;
			// 
			// TestInsta
			// 
			TestInsta.Location = new Point(648, 336);
			TestInsta.Name = "TestInsta";
			TestInsta.Size = new Size(101, 23);
			TestInsta.TabIndex = 4;
			TestInsta.Text = "Test Connection";
			TestInsta.UseVisualStyleBackColor = true;
			TestInsta.Click += TestInsta_Click;
			// 
			// InstagramAppId
			// 
			InstagramAppId.Location = new Point(10, 20);
			InstagramAppId.Name = "InstagramAppId";
			InstagramAppId.PlaceholderText = "Instagram App ID";
			InstagramAppId.Size = new Size(700, 23);
			InstagramAppId.TabIndex = 0;
			// 
			// InstagramAppSecret
			// 
			InstagramAppSecret.Location = new Point(10, 60);
			InstagramAppSecret.Name = "InstagramAppSecret";
			InstagramAppSecret.PlaceholderText = "Instagram App Secret";
			InstagramAppSecret.Size = new Size(700, 23);
			InstagramAppSecret.TabIndex = 1;
			InstagramAppSecret.UseSystemPasswordChar = true;
			// 
			// InstagramAccessToken
			// 
			InstagramAccessToken.Location = new Point(10, 100);
			InstagramAccessToken.Name = "InstagramAccessToken";
			InstagramAccessToken.PlaceholderText = "Instagram Access Token";
			InstagramAccessToken.Size = new Size(700, 23);
			InstagramAccessToken.TabIndex = 2;
			// 
			// InstagramRefreshToken
			// 
			InstagramRefreshToken.Location = new Point(10, 140);
			InstagramRefreshToken.Name = "InstagramRefreshToken";
			InstagramRefreshToken.PlaceholderText = "Instagram Refresh Token";
			InstagramRefreshToken.Size = new Size(700, 23);
			InstagramRefreshToken.TabIndex = 3;
			// 
			// TikTokTab
			// 
			TikTokTab.Controls.Add(TikTokRefreshTokenShowButton);
			TikTokTab.Controls.Add(TikTokAccessTokenShowButton);
			TikTokTab.Controls.Add(TikTokClientSecretShowButton);
			TikTokTab.Controls.Add(TikTokTest);
			TikTokTab.Controls.Add(TikTokClientId);
			TikTokTab.Controls.Add(TikTokClientSecret);
			TikTokTab.Controls.Add(TikTokAccessToken);
			TikTokTab.Controls.Add(TikTokRefreshToken);
			TikTokTab.Location = new Point(4, 24);
			TikTokTab.Name = "TikTokTab";
			TikTokTab.Size = new Size(752, 362);
			TikTokTab.TabIndex = 3;
			TikTokTab.Text = "TikTok";
			// 
			// TikTokRefreshTokenShowButton
			// 
			TikTokRefreshTokenShowButton.Location = new Point(702, 140);
			TikTokRefreshTokenShowButton.Name = "TikTokRefreshTokenShowButton";
			TikTokRefreshTokenShowButton.Size = new Size(47, 23);
			TikTokRefreshTokenShowButton.TabIndex = 8;
			TikTokRefreshTokenShowButton.Text = "show";
			TikTokRefreshTokenShowButton.UseVisualStyleBackColor = true;
			// 
			// TikTokAccessTokenShowButton
			// 
			TikTokAccessTokenShowButton.Location = new Point(702, 100);
			TikTokAccessTokenShowButton.Name = "TikTokAccessTokenShowButton";
			TikTokAccessTokenShowButton.Size = new Size(47, 23);
			TikTokAccessTokenShowButton.TabIndex = 7;
			TikTokAccessTokenShowButton.Text = "show";
			TikTokAccessTokenShowButton.UseVisualStyleBackColor = true;
			// 
			// TikTokClientSecretShowButton
			// 
			TikTokClientSecretShowButton.Location = new Point(702, 60);
			TikTokClientSecretShowButton.Name = "TikTokClientSecretShowButton";
			TikTokClientSecretShowButton.Size = new Size(47, 23);
			TikTokClientSecretShowButton.TabIndex = 6;
			TikTokClientSecretShowButton.Text = "show";
			TikTokClientSecretShowButton.UseVisualStyleBackColor = true;
			// 
			// TikTokTest
			// 
			TikTokTest.Location = new Point(654, 336);
			TikTokTest.Name = "TikTokTest";
			TikTokTest.Size = new Size(95, 23);
			TikTokTest.TabIndex = 4;
			TikTokTest.Text = "Test Conection";
			TikTokTest.UseVisualStyleBackColor = true;
			TikTokTest.Click += TikTokTest_Click;
			// 
			// TikTokClientId
			// 
			TikTokClientId.Location = new Point(10, 20);
			TikTokClientId.Name = "TikTokClientId";
			TikTokClientId.PlaceholderText = "TikTok Client ID";
			TikTokClientId.Size = new Size(700, 23);
			TikTokClientId.TabIndex = 0;
			// 
			// TikTokClientSecret
			// 
			TikTokClientSecret.Location = new Point(10, 60);
			TikTokClientSecret.Name = "TikTokClientSecret";
			TikTokClientSecret.PlaceholderText = "TikTok Client Secret";
			TikTokClientSecret.Size = new Size(700, 23);
			TikTokClientSecret.TabIndex = 1;
			TikTokClientSecret.UseSystemPasswordChar = true;
			// 
			// TikTokAccessToken
			// 
			TikTokAccessToken.Location = new Point(10, 100);
			TikTokAccessToken.Name = "TikTokAccessToken";
			TikTokAccessToken.PlaceholderText = "TikTok Access Token";
			TikTokAccessToken.Size = new Size(700, 23);
			TikTokAccessToken.TabIndex = 2;
			// 
			// TikTokRefreshToken
			// 
			TikTokRefreshToken.Location = new Point(10, 140);
			TikTokRefreshToken.Name = "TikTokRefreshToken";
			TikTokRefreshToken.PlaceholderText = "TikTok Refresh Token";
			TikTokRefreshToken.Size = new Size(700, 23);
			TikTokRefreshToken.TabIndex = 3;
			// 
			// SaveButton
			// 
			SaveButton.Location = new Point(12, 410);
			SaveButton.Name = "SaveButton";
			SaveButton.Size = new Size(100, 30);
			SaveButton.TabIndex = 1;
			SaveButton.Text = "Save";
			SaveButton.UseVisualStyleBackColor = true;
			SaveButton.Click += SaveButton_Click_1;
			// 
			// CancelButton
			// 
			CancelButton.Location = new Point(118, 410);
			CancelButton.Name = "CancelButton";
			CancelButton.Size = new Size(100, 30);
			CancelButton.TabIndex = 2;
			CancelButton.Text = "Cancel";
			CancelButton.UseVisualStyleBackColor = true;
			CancelButton.Click += CancelButton_Click;
			// 
			// linkLabel1
			// 
			linkLabel1.AutoSize = true;
			linkLabel1.Location = new Point(316, 67);
			linkLabel1.Name = "linkLabel1";
			linkLabel1.Size = new Size(68, 15);
			linkLabel1.TabIndex = 7;
			linkLabel1.TabStop = true;
			linkLabel1.Text = "Get API Key";
			linkLabel1.LinkClicked += linkLabel1_LinkClicked;
			// 
			// Settings
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(784, 451);
			Controls.Add(SettingsTabs);
			Controls.Add(SaveButton);
			Controls.Add(CancelButton);
			Name = "Settings";
			Text = "Settings";
			SettingsTabs.ResumeLayout(false);
			AITab.ResumeLayout(false);
			AITab.PerformLayout();
			FacebookTab.ResumeLayout(false);
			FacebookTab.PerformLayout();
			InstagramTab.ResumeLayout(false);
			InstagramTab.PerformLayout();
			TikTokTab.ResumeLayout(false);
			TikTokTab.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private TabControl SettingsTabs;

		private TabPage AITab;
		private TabPage FacebookTab;
		private TabPage InstagramTab;
		private TabPage TikTokTab;

		private TextBox OpenAIKey;

		private TextBox FacebookAppId;
		private TextBox FacebookAppSecret;
		private TextBox FacebookAccessToken;
		private TextBox FacebookRefreshToken;

		private TextBox InstagramAppId;
		private TextBox InstagramAppSecret;
		private TextBox InstagramAccessToken;
		private TextBox InstagramRefreshToken;

		private TextBox TikTokClientId;
		private TextBox TikTokClientSecret;
		private TextBox TikTokAccessToken;
		private TextBox TikTokRefreshToken;

		private Button SaveButton;
		private Button CancelButton;
		private Button AITest;
		private Button FacebookTest;
		private Button TestInsta;
		private Button TikTokTest;
		private Button OpenAIKeyShowButton;
		private Button FacebookRefreshTokenShowButton;
		private Button FacebookAccessTokenShowButton;
		private Button FacebookAppSecretShowButton;
		private Button InstagramRefreshTokenShowButton;
		private Button InstagramAccessTokenShowButton;
		private Button InstagramAppSecretShowButton;
		private Button TikTokRefreshTokenShowButton;
		private Button TikTokAccessTokenShowButton;
		private Button TikTokClientSecretShowButton;
		private Label label1;
		private ComboBox AIModel;
		private LinkLabel linkLabel1;
	}
}