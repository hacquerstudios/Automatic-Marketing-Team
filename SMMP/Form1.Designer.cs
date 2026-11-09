namespace SMMP
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			SettingsButton = new Button();
			DropZone = new Panel();
			DataLabel = new Label();
			Submitbutton = new Button();
			AIButton = new Button();
			Caption = new RichTextBox();
			CaptionLable = new Label();
			PleaseWaitLabel = new Label();
			BaseAIPromptLabel = new Label();
			BaseAIPrompt = new TextBox();
			ReturnToDefaultButton = new Button();
			label1 = new Label();
			DropZone.SuspendLayout();
			SuspendLayout();
			// 
			// SettingsButton
			// 
			SettingsButton.Image = Properties.Resources.gear_solid_full;
			SettingsButton.Location = new Point(753, 12);
			SettingsButton.Name = "SettingsButton";
			SettingsButton.Size = new Size(35, 35);
			SettingsButton.TabIndex = 0;
			SettingsButton.UseVisualStyleBackColor = true;
			SettingsButton.Click += SettingsButton_Click;
			// 
			// DropZone
			// 
			DropZone.AllowDrop = true;
			DropZone.BorderStyle = BorderStyle.FixedSingle;
			DropZone.Controls.Add(DataLabel);
			DropZone.Location = new Point(12, 70);
			DropZone.Name = "DropZone";
			DropZone.Size = new Size(306, 505);
			DropZone.TabIndex = 1;
			DropZone.Paint += DropZone_Paint;
			// 
			// DataLabel
			// 
			DataLabel.AutoSize = true;
			DataLabel.Location = new Point(3, 168);
			DataLabel.Name = "DataLabel";
			DataLabel.Size = new Size(97, 15);
			DataLabel.TabIndex = 4;
			DataLabel.Text = "Drop Media Here";
			DataLabel.Click += DataLabel_Click;
			// 
			// Submitbutton
			// 
			Submitbutton.Location = new Point(12, 12);
			Submitbutton.Name = "Submitbutton";
			Submitbutton.Size = new Size(75, 23);
			Submitbutton.TabIndex = 0;
			Submitbutton.Text = "Submit";
			Submitbutton.UseVisualStyleBackColor = true;
			// 
			// AIButton
			// 
			AIButton.Location = new Point(12, 41);
			AIButton.Name = "AIButton";
			AIButton.Size = new Size(117, 23);
			AIButton.TabIndex = 2;
			AIButton.Text = "Refine With AI";
			AIButton.UseVisualStyleBackColor = true;
			AIButton.Click += AIButton_Click;
			// 
			// Caption
			// 
			Caption.BorderStyle = BorderStyle.FixedSingle;
			Caption.Location = new Point(324, 70);
			Caption.Name = "Caption";
			Caption.Size = new Size(464, 300);
			Caption.TabIndex = 3;
			Caption.Text = "";
			// 
			// CaptionLable
			// 
			CaptionLable.AutoSize = true;
			CaptionLable.Location = new Point(324, 52);
			CaptionLable.Name = "CaptionLable";
			CaptionLable.Size = new Size(49, 15);
			CaptionLable.TabIndex = 4;
			CaptionLable.Text = "Caption";
			// 
			// PleaseWaitLabel
			// 
			PleaseWaitLabel.AutoSize = true;
			PleaseWaitLabel.Location = new Point(135, 45);
			PleaseWaitLabel.Name = "PleaseWaitLabel";
			PleaseWaitLabel.Size = new Size(130, 15);
			PleaseWaitLabel.TabIndex = 5;
			PleaseWaitLabel.Text = "Waiting for AI response";
			PleaseWaitLabel.Visible = false;
			// 
			// BaseAIPromptLabel
			// 
			BaseAIPromptLabel.AutoSize = true;
			BaseAIPromptLabel.Location = new Point(324, 380);
			BaseAIPromptLabel.Name = "BaseAIPromptLabel";
			BaseAIPromptLabel.Size = new Size(88, 15);
			BaseAIPromptLabel.TabIndex = 6;
			BaseAIPromptLabel.Text = "Base AI prompt";
			// 
			// BaseAIPrompt
			// 
			BaseAIPrompt.AcceptsReturn = true;
			BaseAIPrompt.Location = new Point(324, 400);
			BaseAIPrompt.Multiline = true;
			BaseAIPrompt.Name = "BaseAIPrompt";
			BaseAIPrompt.ScrollBars = ScrollBars.Vertical;
			BaseAIPrompt.Size = new Size(464, 140);
			BaseAIPrompt.TabIndex = 7;
			// 
			// ReturnToDefaultButton
			// 
			ReturnToDefaultButton.Location = new Point(324, 545);
			ReturnToDefaultButton.Name = "ReturnToDefaultButton";
			ReturnToDefaultButton.Size = new Size(130, 30);
			ReturnToDefaultButton.TabIndex = 8;
			ReturnToDefaultButton.Text = "Return to default";
			ReturnToDefaultButton.UseVisualStyleBackColor = true;
			ReturnToDefaultButton.Click += ReturnToDefaultButton_Click;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(379, 52);
			label1.Name = "label1";
			label1.Size = new Size(380, 15);
			label1.TabIndex = 9;
			label1.Text = "- Click refine more than once after spell and grammer check to expand";
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 590);
			Controls.Add(label1);
			Controls.Add(PleaseWaitLabel);
			Controls.Add(ReturnToDefaultButton);
			Controls.Add(BaseAIPrompt);
			Controls.Add(BaseAIPromptLabel);
			Controls.Add(CaptionLable);
			Controls.Add(Caption);
			Controls.Add(AIButton);
			Controls.Add(Submitbutton);
			Controls.Add(DropZone);
			Controls.Add(SettingsButton);
			Name = "Form1";
			Text = "Social Media Manager Platform";
			Load += Form1_Load;
			DropZone.ResumeLayout(false);
			DropZone.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button SettingsButton;
		private Panel DropZone;
		private Label DataLabel;
		private Button Submitbutton;
		private Button AIButton;
		private RichTextBox Caption;
		private Label CaptionLable;
		private Label PleaseWaitLabel;
		private Label BaseAIPromptLabel;
		private TextBox BaseAIPrompt;
		private Button ReturnToDefaultButton;
		private Label label1;
	}
}
