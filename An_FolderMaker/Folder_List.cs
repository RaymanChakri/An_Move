using System;
using System.Drawing;
using System.Windows.Forms;

namespace An_FolderMaker
{
	public class Folder_List
	{
		int i = 1;

		Form1 F1 = new Form1();

		public void UpdateStatus(string textMessage, RichTextBox FolList)
		{
			if (FolList.InvokeRequired)
			{
				FolList.Invoke(new MethodInvoker(() => UpdateStatus(textMessage, FolList)));
			}
			FolList.AppendText(textMessage + Environment.NewLine);
		}
		public void ListText(RichTextBox FolList)
		{
			Color TextColor = Color.Black, OKColor = Color.Green, FailedColor = Color.Red;
			FolList.Clear();
			//Form1.FolList.Clear();
			i = 1;
			foreach (string s in Form1.Error)
			{
				FolList.SelectionColor = TextColor;
				//FolList.AppendText(F1.messagtext(i) + "" + i);
				UpdateStatus(F1.messagtext(i) + "" + i, FolList);
				i++;

				if (s.Contains("already"))
				{
					FolList.SelectionColor = FailedColor;
					//FolList.AppendText(s);
					UpdateStatus(s, FolList);
				}
				else
				{
					FolList.SelectionColor = OKColor;
					//FolList.AppendText(s);
					UpdateStatus(s, FolList);
				}
			}
		}
	}
}
