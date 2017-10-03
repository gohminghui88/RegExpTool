/*
 * Created by SharpDevelop.
 * User: IRU-OAS
 * Date: 03/10/2017
 * Time: 10:09 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;

namespace RegExpTool
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void Button3Click(object sender, EventArgs e)
		{
			try {
				this.Close();
			}
			
			catch(Exception ex) {
				MessageBox.Show(ex.Message);
			}
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			try {
			OpenFileDialog ofd = new OpenFileDialog();
			
			if(ofd.ShowDialog() == DialogResult.OK) {
				
				string filePath = ofd.FileName;
				string line = "";
				
				int i = 0;
				StreamReader sr = new StreamReader(filePath);
				line = sr.ReadLine();
				while(line != null) {
					
					if(i > 0) richTextBox1.Text = line;
					else richTextBox1.Text += "\n" + line;
					
					line = sr.ReadLine();
					
					i++;
				}
				
			}
			
			}
			
			catch(Exception ex) {
				MessageBox.Show(ex.Message);
			}
		}
		
		//Ref: https://social.msdn.microsoft.com/Forums/windows/en-US/8683fec1-f269-45a3-9dd7-6e73e6be464f/richtextbox-find-the-text-and-highlight-all-text?forum=winforms
		void Button4Click(object sender, EventArgs e)
		{
			
			try {
			richTextBox2.Text = "";
			MatchCollection mc = Regex.Matches(this.richTextBox1.Text, this.textBox1.Text);
			
			
			if(radioButton1.Checked) {
				
				richTextBox2.Text = richTextBox1.Text;
				
				foreach(Match m in mc) {
					
					int index = 0;
					int lastIndex = richTextBox2.Text.LastIndexOf(m.ToString(), StringComparison.OrdinalIgnoreCase);
				
					while ( index < lastIndex )
      				{
						richTextBox2.Find(m.ToString(), index, richTextBox2.Text.Length, RichTextBoxFinds.None);
        				richTextBox2.SelectionBackColor = Color.Khaki;
        				index = richTextBox2.Text.IndexOf(m.ToString(), index) + 1;
      				}
				}
			}
			
			else if(radioButton3.Checked) {
			
				int i = 0;
				foreach(Match m in mc) {
					
					if(i > 0) richTextBox2.Text += "\n" + m.ToString();
					else richTextBox2.Text = m.ToString();
					
					i++;
				}
			}
			
			else {
				
				string text = richTextBox1.Text;
				
				foreach(Match m in mc) {
					text = text.Replace(m.ToString(), textBox2.Text);
					
					richTextBox2.Text = text;
					
				}
			}
			
			}
			
			catch(Exception ex) {
				MessageBox.Show(ex.Message);
			}
			
		}
		void Button2Click(object sender, EventArgs e)
		{
			MessageBox.Show("RegExpTool v1.0 beta\nDeveloped By: Eric M. H. Goh\nLicense: GNU GPL License\n\nURL: http://www.lajusoft.com/");
		}
		void Button5Click(object sender, EventArgs e)
		{
			SaveFileDialog sfd = new SaveFileDialog();
			sfd.Filter = "*.txt | Text Files";
			if(sfd.ShowDialog() == DialogResult.OK) {
				
				richTextBox2.SaveFile(sfd.FileName);
			}
		}
		void ComboBox1SelectedIndexChanged(object sender, EventArgs e)
		{
			if(comboBox1.Text == "Email")
				textBox1.Text = @"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*";
			
			else if(comboBox1.Text == "Word") textBox1.Text = @"\w+";
		}
		
		
	}
}
