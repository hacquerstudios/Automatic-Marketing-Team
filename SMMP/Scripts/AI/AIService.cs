using System.Text;
using System.Text.Json;

namespace SMMP.Scripts.AI
{
	internal static class AIService
	{
		private static readonly HttpClient Client = new();

		public const string DefaultBasePrompt = """
Please proofread and improve the following social media post.

Rules:
- Fix grammar
- Fix spelling
- Improve readability
- Make it professional
- Make it Exciting
- Keep the original meaning
- Do not add hashtags unless appropriate
- Return ONLY the improved post
- Treat the post as a caption for a social media post
- Treat the reader as the player
""";

		public static async Task<string> TestConnection(string apiKey, string model)
		{
			string url =
	$"https://generativelanguage.googleapis.com/v1beta/models/{Uri.EscapeDataString(model)}:generateContent?key={Uri.EscapeDataString(apiKey)}";
			var requestBody = new
			{
				contents = new[]
				{
					new
					{
						parts = new[]
						{
							new
							{
								text = "Reply with: Connection Successful"
							}
						}
					}
				}
			};

			string json =
				JsonSerializer.Serialize(requestBody);

			StringContent content =
				new(
					json,
					Encoding.UTF8,
					"application/json");

			HttpResponseMessage response =
				await Client.PostAsync(url, content);

			string result =
				await response.Content.ReadAsStringAsync();

			if (!response.IsSuccessStatusCode)
			{
				throw new Exception(
					$"Gemini Error: {response.StatusCode}\n\n{result}");
			}

			using JsonDocument doc =
				JsonDocument.Parse(result);

			return doc.RootElement
				.GetProperty("candidates")[0]
				.GetProperty("content")
				.GetProperty("parts")[0]
				.GetProperty("text")
				.GetString()
				?? "No response";
		}
		public static async Task<string> RefineCaption(
	string apiKey,
	string model,
	string basePrompt,
	string caption)
		{
			string url =
				$"https://generativelanguage.googleapis.com/v1beta/models/{Uri.EscapeDataString(model)}:generateContent?key={Uri.EscapeDataString(apiKey)}";

			var requestBody = new
			{
				contents = new[]
				{
			new
			{
				parts = new[]
				{
					new
					{
						text =
							basePrompt +
							Environment.NewLine +
							"Post:" +
							Environment.NewLine +
							Environment.NewLine +
							caption
					}
				}
			}
		}
			};

			string json =
				JsonSerializer.Serialize(requestBody);

			StringContent content =
				new(
					json,
					Encoding.UTF8,
					"application/json");

			HttpResponseMessage response =
				await Client.PostAsync(url, content);

			string result =
				await response.Content.ReadAsStringAsync();

			if (!response.IsSuccessStatusCode)
			{
				throw new Exception(
					$"Gemini Error: {response.StatusCode}\n\n{result}");
			}

			using JsonDocument doc =
				JsonDocument.Parse(result);

			return doc.RootElement
				.GetProperty("candidates")[0]
				.GetProperty("content")
				.GetProperty("parts")[0]
				.GetProperty("text")
				.GetString()
				?? caption;
		}
	}
}