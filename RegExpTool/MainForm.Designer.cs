﻿/*
 * Created by SharpDevelop.
 * User: IRU-OAS
 * Date: 03/10/2017
 * Time: 10:09 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace RegExpTool
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.RichTextBox richTextBox1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.RadioButton radioButton3;
		private System.Windows.Forms.RadioButton radioButton2;
		private System.Windows.Forms.RadioButton radioButton1;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.RichTextBox richTextBox2;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.ComboBox comboBox1;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.richTextBox1 = new System.Windows.Forms.RichTextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.radioButton3 = new System.Windows.Forms.RadioButton();
			this.radioButton2 = new System.Windows.Forms.RadioButton();
			this.radioButton1 = new System.Windows.Forms.RadioButton();
			this.button4 = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.richTextBox2 = new System.Windows.Forms.RichTextBox();
			this.button5 = new System.Windows.Forms.Button();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// richTextBox1
			// 
			this.richTextBox1.Location = new System.Drawing.Point(12, 48);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.Size = new System.Drawing.Size(676, 101);
			this.richTextBox1.TabIndex = 0;
			this.richTextBox1.Text = "";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(642, 19);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(46, 23);
			this.button1.TabIndex = 1;
			this.button1.Text = "...";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(12, 18);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 2;
			this.label1.Text = "Text: ";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(12, 337);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(117, 23);
			this.label2.TabIndex = 3;
			this.label2.Text = "Regular Expression: ";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(119, 334);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(405, 20);
			this.textBox1.TabIndex = 4;
			this.textBox1.Text = "\\w+";
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(119, 363);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(569, 20);
			this.textBox2.TabIndex = 6;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(12, 366);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(117, 23);
			this.label3.TabIndex = 5;
			this.label3.Text = "Replace With: ";
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(613, 494);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 23);
			this.button2.TabIndex = 7;
			this.button2.Text = "About";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.Button2Click);
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(532, 494);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(75, 23);
			this.button3.TabIndex = 8;
			this.button3.Text = "Cancel";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.Button3Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.radioButton3);
			this.groupBox1.Controls.Add(this.radioButton2);
			this.groupBox1.Controls.Add(this.radioButton1);
			this.groupBox1.Location = new System.Drawing.Point(12, 396);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(211, 55);
			this.groupBox1.TabIndex = 9;
			this.groupBox1.TabStop = false;
			// 
			// radioButton3
			// 
			this.radioButton3.Location = new System.Drawing.Point(141, 16);
			this.radioButton3.Name = "radioButton3";
			this.radioButton3.Size = new System.Drawing.Size(104, 24);
			this.radioButton3.TabIndex = 2;
			this.radioButton3.Text = "Extract";
			this.radioButton3.UseVisualStyleBackColor = true;
			// 
			// radioButton2
			// 
			this.radioButton2.Location = new System.Drawing.Point(66, 16);
			this.radioButton2.Name = "radioButton2";
			this.radioButton2.Size = new System.Drawing.Size(104, 24);
			this.radioButton2.TabIndex = 1;
			this.radioButton2.Text = "Replace";
			this.radioButton2.UseVisualStyleBackColor = true;
			// 
			// radioButton1
			// 
			this.radioButton1.Checked = true;
			this.radioButton1.Location = new System.Drawing.Point(13, 16);
			this.radioButton1.Name = "radioButton1";
			this.radioButton1.Size = new System.Drawing.Size(104, 24);
			this.radioButton1.TabIndex = 0;
			this.radioButton1.TabStop = true;
			this.radioButton1.Text = "Find";
			this.radioButton1.UseVisualStyleBackColor = true;
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(250, 413);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(75, 23);
			this.button4.TabIndex = 10;
			this.button4.Text = "Execute";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.Button4Click);
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(12, 168);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 23);
			this.label4.TabIndex = 11;
			this.label4.Text = "Results: ";
			// 
			// richTextBox2
			// 
			this.richTextBox2.Location = new System.Drawing.Point(12, 197);
			this.richTextBox2.Name = "richTextBox2";
			this.richTextBox2.Size = new System.Drawing.Size(676, 117);
			this.richTextBox2.TabIndex = 12;
			this.richTextBox2.Text = "";
			// 
			// button5
			// 
			this.button5.Location = new System.Drawing.Point(613, 168);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(75, 23);
			this.button5.TabIndex = 13;
			this.button5.Text = "Save As";
			this.button5.UseVisualStyleBackColor = true;
			this.button5.Click += new System.EventHandler(this.Button5Click);
			// 
			// comboBox1
			// 
			this.comboBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.DropList;
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Items.AddRange(new object[] {
			"Word",
			"Email"});
			this.comboBox1.Location = new System.Drawing.Point(530, 333);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(158, 21);
			this.comboBox1.TabIndex = 14;
			this.comboBox1.Text = "Word";
			this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.ComboBox1SelectedIndexChanged);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(700, 529);
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(this.button5);
			this.Controls.Add(this.richTextBox2);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.richTextBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "RegExpTool - Regular Expression Tool v1.0.0 beta";
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
