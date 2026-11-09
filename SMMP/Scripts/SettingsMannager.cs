using SMMP.Scripts;
using System.Text.Json;
using System.Text;
using System.Security.Cryptography;
namespace SMMP.Scripts
{
	public static class SettingsManager
	{
		private const string FileName = "settings.dat";

		public static void Save(AppSettings settings)
		{
			string json =
				JsonSerializer.Serialize(
					settings,
					new JsonSerializerOptions
					{
						WriteIndented = true
					});

			byte[] plainBytes =
				Encoding.UTF8.GetBytes(json);

			byte[] encryptedBytes =
				ProtectedData.Protect(
					plainBytes,
					null,
					DataProtectionScope.CurrentUser);

			File.WriteAllBytes(
				FileName,
				encryptedBytes);
		}

		public static AppSettings Load()
		{
			try
			{
				if (!File.Exists(FileName))
					return new AppSettings();

				byte[] encryptedBytes =
					File.ReadAllBytes(FileName);

				byte[] decryptedBytes =
					ProtectedData.Unprotect(
						encryptedBytes,
						null,
						DataProtectionScope.CurrentUser);

				string json =
					Encoding.UTF8.GetString(decryptedBytes);

				return JsonSerializer.Deserialize<AppSettings>(json)
					   ?? new AppSettings();
			}
			catch
			{
				return new AppSettings();
			}
		}
	}
}

