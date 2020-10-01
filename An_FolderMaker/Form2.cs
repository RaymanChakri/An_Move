using System;
using System.Drawing;
using System.Windows.Forms;

namespace An_FolderMaker
{
	public partial class Form2 : Form
	{
		Form1 F1 = new Form1();
		int i = 1;
		public Form2()
		{
			InitializeComponent();

		}

		public void Form2_Load(object sender, EventArgs e)
		{
			FoldList.Text = "Folders List";
			AudList.Text = "Audio List";
			CloseBut.Text = "Close";
			CheckMessag();
			//FoldersList_SelectedIndexChanged(sender,e);

		}

		void UpdateStatus(string textMessage)
		{
			if (richFolder.InvokeRequired)
			{
				richFolder.Invoke(new MethodInvoker(() => UpdateStatus(textMessage)));
				return;
			}

			richFolder.AppendText(textMessage + Environment.NewLine);
		}

		public void CheckMessag()
		{

			//MessageBox.Show("Hello mtf");
			Color TextColor = Color.Black, OKColor = Color.Green, FailedColor = Color.Red;
			richFolder.Clear();
			i = 1;
			foreach (string s in Form1.Error)
			{
				richFolder.SelectionColor = TextColor;
				//richTextBox.AppendText(F1.messagtext(i) + "" + i);
				UpdateStatus(F1.messagtext(i) + "" + i);
				i++;

				if (s.Contains("already"))
				{
					richFolder.SelectionColor = FailedColor;
					//richTextBox.AppendText(s);
					UpdateStatus(s);
				}
				else
				{
					richFolder.SelectionColor = OKColor;
					//richTextBox.AppendText(s);
					UpdateStatus(s);
				}
				//bool ok = (random.Next() & 1) != 0;
				//richTextBox.SelectionColor = ok ? OKColor : FailedColor;
				//richTextBox.AppendText(ok ? "Created" : "Failed");
			}
		}
		private void FolderNumber_Click(object sender, EventArgs e)
		{

		}

		public void button1_Click(object sender, EventArgs e)
		{
			this.Close();

		}

		private void richTextBox_TextChanged(object sender, EventArgs e)
		{

		}

		public void RefreshBut_Click(object sender, EventArgs e)
		{
			//Form2 F2 = new Form2();
			richFolder.Clear();
			i = 1;
			Form2_Load(sender, e);
			//FoldersList = null;
			Form1.Error.Clear();
		}

		public void FolderListCounter()
		{
			Color TextColor = Color.Black, OKColor = Color.Green, FailedColor = Color.Red;
			i = 1;

			//FoldersList.Items.Add(("a " + i).ToString());
			foreach (string s in Form1.Error)
			{
				//FoldersList.Items.Add(s + "" +i);
				i++;
			}


		}

		public void FoldersList_SelectedIndexChanged(object sender, EventArgs e)
		{

		}
	}
}
