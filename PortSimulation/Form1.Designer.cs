﻿namespace PortSimulation
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
			button1 = new Button();
			button2 = new Button();
			pictureBox1 = new PictureBox();
			richTextBox1 = new RichTextBox();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			SuspendLayout();
			// 
			// button1
			// 
			button1.Location = new Point(12, 415);
			button1.Name = "button1";
			button1.Size = new Size(75, 23);
			button1.TabIndex = 0;
			button1.Text = "&Add Ship";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// button2
			// 
			button2.Location = new Point(713, 415);
			button2.Name = "button2";
			button2.Size = new Size(75, 23);
			button2.TabIndex = 1;
			button2.Text = "button2";
			button2.UseVisualStyleBackColor = true;
			button2.Click += button2_Click;
			// 
			// pictureBox1
			// 
			pictureBox1.Image = Properties.Resources.МАОУ_гимназия_имени_Антона_Павловича_Чехова_3;
			pictureBox1.Location = new Point(12, 12);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(352, 366);
			pictureBox1.TabIndex = 2;
			pictureBox1.TabStop = false;
			// 
			// richTextBox1
			// 
			richTextBox1.Location = new Point(449, 12);
			richTextBox1.Name = "richTextBox1";
			richTextBox1.ReadOnly = true;
			richTextBox1.Size = new Size(339, 366);
			richTextBox1.TabIndex = 3;
			richTextBox1.Text = "";
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(richTextBox1);
			Controls.Add(pictureBox1);
			Controls.Add(button2);
			Controls.Add(button1);
			Name = "Form1";
			Text = "Form1";
			Load += Form1_Load;
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private Button button1;
		private Button button2;
		private PictureBox pictureBox1;
		private RichTextBox richTextBox1;
	}
}