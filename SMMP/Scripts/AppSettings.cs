using System;
using System.Collections.Generic;
using System.Text;

namespace SMMP.Scripts
{
	public class AppSettings
	{
		public string OpenAIKey { get; set; } = "";
		public string OpenAIModel { get; set; } = "";

		public string FacebookAppId { get; set; } = "";
		public string FacebookAppSecret { get; set; } = "";
		public string FacebookAccessToken { get; set; } = "";
		public string FacebookRefreshToken { get; set; } = "";

		public string InstagramAppId { get; set; } = "";
		public string InstagramAppSecret { get; set; } = "";
		public string InstagramAccessToken { get; set; } = "";
		public string InstagramRefreshToken { get; set; } = "";

		public string TikTokClientId { get; set; } = "";
		public string TikTokClientSecret { get; set; } = "";
		public string TikTokAccessToken { get; set; } = "";
		public string TikTokRefreshToken { get; set; } = "";
	}
}
