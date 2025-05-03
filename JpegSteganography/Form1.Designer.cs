namespace JpegSteganography
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
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
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.txtMessage = new System.Windows.Forms.TextBox();
			this.txtExtracted = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.btnEmbedJpeg = new System.Windows.Forms.Button();
			this.btnExtractJpeg = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// txtMessage
			// 
			this.txtMessage.Location = new System.Drawing.Point(178, 56);
			this.txtMessage.Name = "txtMessage";
			this.txtMessage.Size = new System.Drawing.Size(208, 22);
			this.txtMessage.TabIndex = 0;
			// 
			// txtExtracted
			// 
			this.txtExtracted.Location = new System.Drawing.Point(500, 59);
			this.txtExtracted.Name = "txtExtracted";
			this.txtExtracted.Size = new System.Drawing.Size(244, 22);
			this.txtExtracted.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(119, 59);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(47, 16);
			this.label1.TabIndex = 2;
			this.label1.Text = "Mesaj:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(419, 62);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(75, 16);
			this.label2.TabIndex = 3;
			this.label2.Text = "Gizli Mesaj:";
			// 
			// btnEmbedJpeg
			// 
			this.btnEmbedJpeg.Location = new System.Drawing.Point(200, 134);
			this.btnEmbedJpeg.Name = "btnEmbedJpeg";
			this.btnEmbedJpeg.Size = new System.Drawing.Size(147, 23);
			this.btnEmbedJpeg.TabIndex = 4;
			this.btnEmbedJpeg.Text = "Görsel\'e Mesaj Göm";
			this.btnEmbedJpeg.UseVisualStyleBackColor = true;
			this.btnEmbedJpeg.Click += new System.EventHandler(this.btnEmbed_Click);
			// 
			// btnExtractJpeg
			// 
			this.btnExtractJpeg.Location = new System.Drawing.Point(539, 134);
			this.btnExtractJpeg.Name = "btnExtractJpeg";
			this.btnExtractJpeg.Size = new System.Drawing.Size(155, 23);
			this.btnExtractJpeg.TabIndex = 5;
			this.btnExtractJpeg.Text = "Görsel\'den Mesaj Çıkar";
			this.btnExtractJpeg.UseVisualStyleBackColor = true;
			this.btnExtractJpeg.Click += new System.EventHandler(this.btnExtract_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(930, 468);
			this.Controls.Add(this.btnExtractJpeg);
			this.Controls.Add(this.btnEmbedJpeg);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtExtracted);
			this.Controls.Add(this.txtMessage);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtMessage;
		private System.Windows.Forms.TextBox txtExtracted;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btnEmbedJpeg;
		private System.Windows.Forms.Button btnExtractJpeg;
	}
}

