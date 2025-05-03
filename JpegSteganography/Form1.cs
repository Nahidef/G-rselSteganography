using System;
using System.Windows.Forms;
using System.IO;

namespace JpegSteganography
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void btnEmbed_Click(object sender, EventArgs e)
		{
			OpenFileDialog ofd = new OpenFileDialog
			{
				Filter = "Image Files (*.png)|*.png|All files (*.*)|*.*",
				Title = "Select a PNG Image"
			};

			if (ofd.ShowDialog() == DialogResult.OK)
			{
				try
				{
					string imagePath = ofd.FileName;
					string message = txtMessage.Text;
					string outputPath = Path.Combine(
						Path.GetDirectoryName(imagePath),
						"stego_" + Path.GetFileName(imagePath)
					);

					JpegHelper.EmbedMessage(imagePath, outputPath, message);
					MessageBox.Show("Message embedded successfully!", "Success",
								 MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
				catch (Exception ex)
				{
					MessageBox.Show($"Error: {ex.Message}", "Error",
								 MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}

		private void btnExtract_Click(object sender, EventArgs e)
		{
			OpenFileDialog ofd = new OpenFileDialog
			{
				Filter = "Image Files (*.png)|*.png|All files (*.*)|*.*",
				Title = "Select a Stego Image"
			};

			if (ofd.ShowDialog() == DialogResult.OK)
			{
				try
				{
					string extractedMsg = JpegHelper.ExtractMessage(ofd.FileName);
					txtExtracted.Text = extractedMsg;
				}
				catch (Exception ex)
				{
					MessageBox.Show($"Error: {ex.Message}", "Error",
								 MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}
	}
}