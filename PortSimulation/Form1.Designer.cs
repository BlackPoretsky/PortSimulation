namespace PortSimulation
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
			button2 = new Button();
			pictureBox1 = new PictureBox();
			richTextBox1 = new RichTextBox();
			button3 = new Button();
			button4 = new Button();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			SuspendLayout();
			// 
			// button2
			// 
			button2.Enabled = false;
			button2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			button2.Location = new Point(674, 384);
			button2.Name = "button2";
			button2.Size = new Size(114, 54);
			button2.TabIndex = 1;
			button2.Text = "&Stop";
			button2.UseVisualStyleBackColor = true;
			button2.Click += Stop_Click;
			// 
			// pictureBox1
			// 
			pictureBox1.Image = Properties.Resources.f1cf5ace6b7a64937904258004603736;
			pictureBox1.Location = new Point(12, 12);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(393, 366);
			pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
			pictureBox1.TabIndex = 2;
			pictureBox1.TabStop = false;
			// 
			// richTextBox1
			// 
			richTextBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			richTextBox1.Location = new Point(426, 12);
			richTextBox1.Name = "richTextBox1";
			richTextBox1.ReadOnly = true;
			richTextBox1.Size = new Size(362, 366);
			richTextBox1.TabIndex = 3;
			richTextBox1.Text = "";
			// 
			// button3
			// 
			button3.Enabled = false;
			button3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			button3.Location = new Point(554, 384);
			button3.Name = "button3";
			button3.Size = new Size(114, 54);
			button3.TabIndex = 4;
			button3.Text = "&Start";
			button3.UseVisualStyleBackColor = true;
			button3.Click += Start_Click;
			// 
			// button4
			// 
			button4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			button4.Location = new Point(434, 384);
			button4.Name = "button4";
			button4.Size = new Size(114, 54);
			button4.TabIndex = 5;
			button4.Text = "&Init";
			button4.UseVisualStyleBackColor = true;
			button4.Click += Init_Click;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(button4);
			Controls.Add(button3);
			Controls.Add(richTextBox1);
			Controls.Add(pictureBox1);
			Controls.Add(button2);
			Name = "Form1";
			Text = "Form1";
			Load += Form1_Load;
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			ResumeLayout(false);
		}

		#endregion
		private Button button2;
		private PictureBox pictureBox1;
		private RichTextBox richTextBox1;
		private Button button3;
		private Button button4;
	}
}