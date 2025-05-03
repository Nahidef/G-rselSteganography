using System;
using System.Drawing;
using System.Text;

namespace JpegSteganography
{
	public static class JpegHelper
	{
		public static void EmbedMessage(string inputPath, string outputPath, string message)
		{
			
			if (string.IsNullOrEmpty(message))
				throw new ArgumentException("Message cannot be empty");

			using (Bitmap bmp = new Bitmap(inputPath))
			{
				byte[] msgBytes = Encoding.UTF8.GetBytes(message);
				int msgLength = msgBytes.Length;

				
				int maxCapacity = (bmp.Width * bmp.Height * 3) / 8 - 4; 
				if (msgLength > maxCapacity)
					throw new Exception($"Message too long! Max: {maxCapacity} bytes");

				
				byte[] lengthBytes = BitConverter.GetBytes(msgLength);
				EmbedBytes(bmp, lengthBytes, startPixel: 0);

				
				EmbedBytes(bmp, msgBytes, startPixel: 4 * 8); 

				bmp.Save(outputPath, System.Drawing.Imaging.ImageFormat.Png);
			}
		}

		private static void EmbedBytes(Bitmap bmp, byte[] bytes, int startPixel)
		{
			int pixelIndex = startPixel;

			for (int i = 0; i < bytes.Length; i++)
			{
				byte currentByte = bytes[i];

				for (int bit = 0; bit < 8; bit++)
				{
					int x = pixelIndex % bmp.Width;
					int y = pixelIndex / bmp.Width;

					Color pixel = bmp.GetPixel(x, y);

					
					int newR = (pixel.R & 0xFE) | ((currentByte >> bit) & 1);
					Color newPixel = Color.FromArgb(newR, pixel.G, pixel.B);
					bmp.SetPixel(x, y, newPixel);

					pixelIndex++;
					if (pixelIndex >= bmp.Width * bmp.Height) return;
				}
			}
		}

		public static string ExtractMessage(string inputPath)
		{
			using (Bitmap bmp = new Bitmap(inputPath))
			{
				
				int msgLength = ExtractInt(bmp, startPixel: 0);

				
				byte[] msgBytes = new byte[msgLength];
				ExtractBytes(bmp, msgBytes, startPixel: 4 * 8);

				return Encoding.UTF8.GetString(msgBytes);
			}
		}

		private static int ExtractInt(Bitmap bmp, int startPixel)
		{
			byte[] buffer = new byte[4];
			ExtractBytes(bmp, buffer, startPixel);
			return BitConverter.ToInt32(buffer, 0);
		}

		private static void ExtractBytes(Bitmap bmp, byte[] buffer, int startPixel)
		{
			int pixelIndex = startPixel;

			for (int i = 0; i < buffer.Length; i++)
			{
				byte currentByte = 0;

				for (int bit = 0; bit < 8; bit++)
				{
					int x = pixelIndex % bmp.Width;
					int y = pixelIndex / bmp.Width;

					Color pixel = bmp.GetPixel(x, y);
					currentByte |= (byte)((pixel.R & 1) << bit);

					pixelIndex++;
					if (pixelIndex >= bmp.Width * bmp.Height) return;
				}

				buffer[i] = currentByte;
			}
		}
	}
}