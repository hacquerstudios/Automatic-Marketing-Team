using SMMP.Scripts;
using SMMP.Scripts.AI;
using System.Windows.Forms;
namespace SMMP
{
	public partial class Form1 : Form
	{
		private readonly string[] TextFormats =
{
	".txt",
	".docx",
	".pdf",
	".rtf",
	".md",
	".odt"
};

		private readonly string[] ImageFormats =
		{
	".png",
	".jpg",
	".jpeg",
	".gif",
	".bmp",
	".webp"
};

		private readonly string[] VideoFormats =
		{
	".mp4",
	".mov",
	".avi",
	".mkv",
	".wmv",
	".webm"
};

		public Form1()
		{
			InitializeComponent();
			ReturnToDefaultPrompt();
			//assing methods to the drag drop her instead of touching editor
			DropZone.DragEnter += DropZone_DragEnter;
			DropZone.DragDrop += DropZone_DragDrop;
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			if (SettingsButton.Image != null)
			{
				SettingsButton.Image =
					new Bitmap(SettingsButton.Image, new Size(30, 30));
			}
		}

		private void DropZone_Paint(object sender, PaintEventArgs e)
		{
			//do nothing
		}
		private void DropZone_DragEnter(object sender, DragEventArgs e)
		{
			if (e.Data.GetDataPresent(DataFormats.FileDrop))
			{
				e.Effect = DragDropEffects.Copy;
			}
			else
			{
				e.Effect = DragDropEffects.None;
			}
		}
		private void DropZone_DragDrop(object sender, DragEventArgs e)
		{
			if (!e.Data.GetDataPresent(DataFormats.FileDrop))
				return;

			string[] files =
				(string[])e.Data.GetData(DataFormats.FileDrop);

			DataLabel.Text = "";

			foreach (string file in files)
			{
				string extension =
					Path.GetExtension(file).ToLower();

				if (TextFormats.Contains(extension))
				{
					try
					{
						switch (extension)
						{
							case ".txt":
							case ".md":
							case ".rtf":
								Caption.Text = File.ReadAllText(file);
								break;

							default:
								// Supported text format,
								// but can't extract text yet.
								Caption.Text =
									$"Loaded document:\n{Path.GetFileName(file)}\n\n" +
									"Text extraction for this format is not yet implemented.";
								break;
						}
					}
					catch (Exception ex)
					{
						MessageBox.Show(
							$"Unable to read file.\n\n{ex.Message}",
							"Read Error",
							MessageBoxButtons.OK,
							MessageBoxIcon.Error);
					}
				}
				else if (ImageFormats.Contains(extension))
				{
					DataLabel.Text +=
						$"Image: {Path.GetFileName(file)}{Environment.NewLine}";
				}
				else if (VideoFormats.Contains(extension))
				{
					DataLabel.Text +=
						$"Video: {Path.GetFileName(file)}{Environment.NewLine}";
				}
				else
				{
					MessageBox.Show(
						$"Sorry, '{extension}' files are not currently supported.\n\n" +
						"Supported file types:\n\n" +
						"Documents:\n" +
						string.Join(", ", TextFormats) +
						"\n\nImages:\n" +
						string.Join(", ", ImageFormats) +
						"\n\nVideos:\n" +
						string.Join(", ", VideoFormats),
						"Unsupported File Type",
						MessageBoxButtons.OK,
						MessageBoxIcon.Information);

					return;
				}
			}
		}

		private void DataLabel_Click(object sender, EventArgs e)
		{

		}

		private void SettingsButton_Click(object sender, EventArgs e)
		{
			Settings settingsForm = new Settings();
			settingsForm.ShowDialog(); // Show the settings form as a modal dialog
									   //open settings form
		}

		private async void AIButton_Click(
	object sender,
	EventArgs e)
		{
			try
			{
				PleaseWaitLabel.Visible = true;

				AppSettings settings =
					SettingsManager.Load();

				Caption.Text =
					await AIService.RefineCaption(
						settings.OpenAIKey,
						settings.OpenAIModel,
						BaseAIPrompt.Text,
						Caption.Text);
			}
			catch (Exception ex)
			{
				MessageBox.Show(
					ex.Message,
					"AI Error",
					MessageBoxButtons.OK,
					MessageBoxIcon.Error);
			}
			finally
			{
				PleaseWaitLabel.Visible = false;
			}
		}

		private void ReturnToDefaultButton_Click(object sender, EventArgs e)
		{
			ReturnToDefaultPrompt();
		}

		private void ReturnToDefaultPrompt()
		{
			BaseAIPrompt.Text = AIService.DefaultBasePrompt;
		}
	}
}
