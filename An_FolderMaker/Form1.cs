using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace An_FolderMaker
{
	public partial class Form1 : Form
	{ //kat3raf l3dass?

		public static int I;
		public static List<string> Error = new List<string>();

		//public static string[] MessagListCreatFolder;
		public Form1()
		{
			//FolList.Text= "";
			InitializeComponent();
			/*BG.Checked = true;
			RF.Checked = true;
			AD.Checked = true;
			RT.Checked = true;*/
			FoldName.Text = "Scene";
			AudioName.Text = "Audio";
			//FoldDerictory.Text = @"C:\Users\Aninoss\Desktop\Programmaiton Test\ListOfFiles\";
		}
		bool windoOpen = false;


		private void button2_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		public void CheckExistFolder()
		{
			int FolderCount = System.IO.Directory.GetDirectories(FoldDerictory.Text, FoldName.Text + "_*").Length;
			FolNumPath.Text = FolderCount.ToString();
			/*string root = FoldDerictory.Text;
			Directory.Exists(root);
			do
			{
				
			} while (Directory.Exists(root)==true);*/
		}

		public void CheckExistAudio()
		{
			int AudioCount = System.IO.Directory.GetFiles(FoldDerictory.Text, AudioName.Text + "_*").Length;
			AudNumPath.Text = AudioCount.ToString();
			/*string root = FoldDerictory.Text;
			Directory.Exists(root);
			do
			{
				
			} while (Directory.Exists(root)==true);*/
		}
		public void Emptyfolders()
		{
			int i = 0;
			string[] subDirectories = System.IO.Directory.GetDirectories(FoldDerictory.Text);

			if (subDirectories.Length > 0)
			{
				string firstSubDir = subDirectories[0];
				Console.WriteLine(firstSubDir);
			}
			string folderName = subDirectories[0].Substring(FoldDerictory.Text.Length);
			if ((System.IO.Directory.GetDirectories(FoldDerictory.Text + @"\" + folderName).Length == 0))
			{
				i++;
			}
			EmptyFolder.Text = System.IO.Directory.GetDirectories(FoldDerictory.Text + @"\" + folderName).Length.ToString();

		}
		private void button1_Click(object sender, EventArgs e)
		{
			/*using (var fbd = new FolderBrowserDialog())
			{
				DialogResult result = fbd.ShowDialog();

				if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
				{
					string[] files = Directory.GetFiles(fbd.SelectedPath);
					FoldDerictory.Text = files[0];
					//System.Windows.Forms.MessageBox.Show("Files found: " + files.Length.ToString(), "Message");
				}
			}*/
			OpenFileDialog folderBrowser = new OpenFileDialog();
			// Set validate names and check file exists to false otherwise windows will
			// not let you select "Folder Selection."
			folderBrowser.ValidateNames = false;
			folderBrowser.CheckFileExists = false;
			folderBrowser.CheckPathExists = true;
			// Always default to Folder Selection.
			folderBrowser.FileName = "Folder Selection.";
			if (folderBrowser.ShowDialog() == DialogResult.OK)
			{
				string folderPath = Path.GetDirectoryName(folderBrowser.FileName);
				FoldDerictory.Text = folderPath + @"\";
				CheckExistAudio();
				CheckExistFolder();
				Emptyfolders();
				// ...
			}

		}
		public string messagtext(int i)
		{
			string MessagAlredyExest = " " + FoldName.Text + "_";
			//I = i;
			return MessagAlredyExest;
		}
		public void ProgressBarMareandCopy(int foldNume, int i)
		{


			CMBar.Minimum = 1;
			CMBar.Maximum = foldNume;
			CMBar.Value = i;
			CMBar.Step = 1;
			CMBar.PerformStep();


		}
		private void button3_Click(object sender, EventArgs e)
		{
			Form2 f = new Form2();
			string messagshow = "";
			string root;
			string[] subfold = { "Audio", "BG", "Roth", "Animation" };
			if (OneFolderCheck.Checked == true)
			{
				root = FoldDerictory.Text + FoldName.Text + "_" + FoldNume.Text;
				if (!Directory.Exists(root))
				{
					Directory.CreateDirectory(root);

				}
				else
				{
					Error.Add(" already exist\n");
					messagtext(int.Parse(FoldNume.Text));
				}

			}
			else
			{

				for (int i = 1; i <= int.Parse(FoldNume.Text); i++)
				{
					ProgressBarMareandCopy(int.Parse(FoldNume.Text), i);
					//ProgressBarMareandCopy(int.Parse(FoldNume.Text),i);
					root = FoldDerictory.Text + FoldName.Text + "_" + i;
					if (!Directory.Exists(root))
					{

						Directory.CreateDirectory(root);
						Error.Add(" ok \n");
						messagtext(i);
						if (AD.Checked == false && BG.Checked == false && RF.Checked == false && RT.Checked == false)
						{
						}
						else
						{
							for (int y = 0; y < 4; y++)
							{
								if (AD.Checked == true)
									subfold[0] = FoldDerictory.Text + FoldName.Text + "_" + i + "/Audio";
								if (BG.Checked == true)
									subfold[1] = FoldDerictory.Text + FoldName.Text + "_" + i + "/BG";
								if (RF.Checked == true)
									subfold[2] = FoldDerictory.Text + FoldName.Text + "_" + i + "/Frames";
								if (RT.Checked == true)
									subfold[3] = FoldDerictory.Text + FoldName.Text + "_" + i + "/Roth";
								if (!Directory.Exists(subfold[y]))
									Directory.CreateDirectory(subfold[y]);
								else
								{
									//////////////this is an error

									//MessageBox.Show("Subfolder Directory alredy Exist");

								}
							}
						}
						//MessagListCreatFolder = MessagListCreatFolder + " \n" + root + "Created";				

					}
					else
					{
						Error.Add(" already exist\n");
						messagtext(i);
						//messagshow = messagshow + Error[i] + " \n";
						//MessageBox.Show("Directory alredy exist");

					}

				}
			}

			richTextBox1_TextChanged(sender, e);
			Error.Clear();
			CheckExistFolder();
			/*f.FormClosing += Form2_Closing;
			if (windoOpen == true)
			{
				//f.FoldersList_SelectedIndexChanged(sender,e);



				//f.Show();
				//Error.Clear();
				//f.Form2_Load(sender,e);
				//MessageBox.Show("The Window is already opened");

			}
			else
			{
				//f.CheckMessag();
				//f.Show();
				richTextBox1_TextChanged(sender,e);
				Error.Clear();
				windoOpen = true;

			}*/






			//MessageBox.Show(""+ messagshow);
			//MessageBox.Show("Creating folder Done");


		}

		private void Form2_Closing(object sender, System.ComponentModel.CancelEventArgs e)
		{
			windoOpen = false;
		}

		private void button4_Click(object sender, EventArgs e)
		{
			Audio_Move AM = new Audio_Move();
			AM.audioMove(FoldDerictory.Text + @"\", FoldName.Text, AudioName.Text);
			CheckExistAudio();

		}

		private void Form1_Load(object sender, EventArgs e)
		{
			FolNum.Text = ".";
			FolNumPath.Text = ".";
			AudNumPath.Text = ".";
			EmptyFolder.Text = ".";
			label8.Text = "|\n|\n|\n|\n";
			PathNameError.Visible = false;
			FolderNameError.Visible = false;
			FolderNumError.Visible = false;
			AudioNameError.Visible = false;
			FoldName.ForeColor = Color.FromArgb(192, 192, 255);
			FoldName.Font = new System.Drawing.Font("Arial", 8.25f, System.Drawing.FontStyle.Italic);
			AudioName.ForeColor = Color.FromArgb(192, 192, 255);
			AudioName.Font = new System.Drawing.Font("Arial", 8.25f, System.Drawing.FontStyle.Italic);
			AudioSubFolder.Text = "/Audio";
			AudioSubFolder.ForeColor = Color.FromArgb(192, 192, 255);
			AudioSubFolder.Font = new System.Drawing.Font("Arial", 8.25f, System.Drawing.FontStyle.Italic);
			AudioSubFolder.Enabled = false;
		}

		public void richTextBox1_TextChanged(object sender, EventArgs e)
		{
			Folder_List fL = new Folder_List();
			fL.ListText(FolList);
		}

		private void progressBar1_Click(object sender, EventArgs e)
		{

		}

		private void FoldNume_KeyDown(object sender, KeyEventArgs e)
		{
			//FolNum.Text = FoldNume.Text;
		}

		private void FoldNume_Leave(object sender, EventArgs e)
		{
			if (FoldNume.Text == "")
			{
				FolderNumError.Font = new System.Drawing.Font("Arial", 8.25f, System.Drawing.FontStyle.Bold);
				FolderNumError.ForeColor = System.Drawing.Color.Red;
				FolderNumError.Visible = true;
				FoldNume.BackColor = System.Drawing.Color.LightCoral;

			}
			else
			{
				FolNum.Text = FoldNume.Text;
				FolderNumError.ForeColor = System.Drawing.SystemColors.ControlText;
				FolderNumError.Visible = false;
				FoldNume.BackColor = System.Drawing.SystemColors.Window;

			}
		}

		private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void AudioName_TextChanged(object sender, EventArgs e)
		{

		}

		private void label4_Click(object sender, EventArgs e)
		{

		}

		private void FolNum_Click(object sender, EventArgs e)
		{

		}

		private void AudNumPath_Click(object sender, EventArgs e)
		{

		}

		private void EmptyFolder_Click(object sender, EventArgs e)
		{

		}

		private void FolNumPath_Click(object sender, EventArgs e)
		{

		}

		private void label5_Click(object sender, EventArgs e)
		{

		}

		private void exitToolStripMenuItem_Click(object sender, EventArgs e)
		{

		}

		private void label14_Click(object sender, EventArgs e)
		{

		}

		private void FoldName_Leave(object sender, EventArgs e)
		{

			if (FoldName.Text == "" || FoldName.Text.Contains("_"))
			{
				FolderNameError.Font = new System.Drawing.Font("Arial", 8.25f, System.Drawing.FontStyle.Bold);
				FolderNameError.ForeColor = System.Drawing.Color.Red;
				FolderNameError.Visible = true;
				FoldName.BackColor = System.Drawing.Color.LightCoral;
			}
			else
			{
				FolderNameError.ForeColor = System.Drawing.SystemColors.ControlText;
				FolderNameError.Visible = false;
				FoldName.BackColor = System.Drawing.SystemColors.Window;
			}
		}

		private void AudioName_Leave(object sender, EventArgs e)
		{
			if (AudioName.Text == "" || AudioName.Text.Contains("_"))
			{
				AudioNameError.Text = "Audio name not correct";
				AudioNameError.Font = new System.Drawing.Font("Arial", 8.25f, System.Drawing.FontStyle.Bold);
				AudioNameError.ForeColor = System.Drawing.Color.Red;
				AudioNameError.Visible = true;
				AudioName.BackColor = System.Drawing.Color.LightCoral;
			}
			else
			{
				AudioNameError.ForeColor = System.Drawing.SystemColors.ControlText;
				AudioNameError.Visible = false;
				AudioName.BackColor = System.Drawing.SystemColors.Window;
			}
		}

		private void FoldDerictory_Leave(object sender, EventArgs e)
		{
			if (FoldDerictory.Text == "")
			{
				PathNameError.Font = new System.Drawing.Font("Arial", 8.25f, System.Drawing.FontStyle.Bold);
				PathNameError.ForeColor = System.Drawing.Color.Red;
				PathNameError.Visible = true;
				FoldDerictory.BackColor = System.Drawing.Color.LightCoral;
			}
			else
			{
				PathNameError.ForeColor = System.Drawing.SystemColors.ControlText;
				PathNameError.Visible = false;
				FoldDerictory.BackColor = System.Drawing.SystemColors.Window;
			}
		}

		private void exitToolStripMenuItem_Click_1(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
		{

		}

		private void FoldName_Enter(object sender, EventArgs e)
		{
			if (FoldName.ForeColor == Color.FromArgb(192, 192, 255))
			{
				FoldName.ForeColor = SystemColors.ControlText;
				FoldName.Font = new System.Drawing.Font("Arial", 8.25f, System.Drawing.FontStyle.Regular);
				FoldName.Clear();
				FoldName.Select();
			}
		}

		private void AudioName_Enter(object sender, EventArgs e)
		{
			if (AudioName.ForeColor == Color.FromArgb(192, 192, 255))
			{
				AudioName.ForeColor = SystemColors.ControlText;
				AudioName.Font = new System.Drawing.Font("Arial", 8.25f, System.Drawing.FontStyle.Regular);
				AudioName.Clear();
				AudioName.Select();

			}

		}

		private void FoldName_KeyPress(object sender, KeyPressEventArgs e)
		{

		}

		private void FoldName_KeyUp(object sender, KeyEventArgs e)
		{
			if (FoldName.Text == "" || FoldName.Text.Contains("_"))
			{
				FolderNameError.Font = new System.Drawing.Font("Arial", 8.25f, System.Drawing.FontStyle.Bold);
				FolderNameError.ForeColor = System.Drawing.Color.Red;
				FolderNameError.Visible = true;
				FoldName.BackColor = System.Drawing.Color.LightCoral;
			}
			else
			{
				FolderNameError.ForeColor = System.Drawing.SystemColors.ControlText;
				FolderNameError.Visible = false;
				FoldName.BackColor = System.Drawing.SystemColors.Window;
			}
		}

		private void button3_Click_1(object sender, EventArgs e)
		{
			if (this.Height == 360)
			{
				this.Height = 697;
				HideShowList.Text = "Haid";
				Exit_But.Top = 603;
				Exit_But.Height = 43;

			}
			else
			{
				HideShowList.Text = "Show";
				this.Height = 360;
				Exit_But.Top = 290;
				Exit_But.Height = 25;

			}


		}

		private void AudioSubCheck_CheckedChanged(object sender, EventArgs e)
		{
			if (AudioSubCheck.Checked == true)
			{
				AudioSubFolder.Enabled = true;
			}
		}

		private void AudioSubFolder_Enter(object sender, EventArgs e)
		{
			if (AudioSubFolder.ForeColor == Color.FromArgb(192, 192, 255))
			{
				AudioSubFolder.ForeColor = SystemColors.ControlText;
				AudioSubFolder.Font = new System.Drawing.Font("Arial", 8.25f, System.Drawing.FontStyle.Regular);
				AudioSubFolder.Clear();
				AudioSubFolder.Select();

			}
		}

		private void AudioSubFolder_Leave(object sender, EventArgs e)
		{
			if (AudioSubFolder.Text == "" || AudioSubFolder.Text.Contains(" ") || AudioSubFolder.Text.Length == 1)
			{
				AudioNameError.Text = "the sub folder or the name not right ";
				AudioNameError.Font = new System.Drawing.Font("Arial", 8.25f, System.Drawing.FontStyle.Bold);
				AudioNameError.ForeColor = System.Drawing.Color.Red;
				AudioNameError.Visible = true;
				AudioSubFolder.BackColor = System.Drawing.Color.LightCoral;
			}
			else
			{
				AudioNameError.ForeColor = System.Drawing.SystemColors.ControlText;
				AudioNameError.Visible = false;
				AudioSubFolder.BackColor = System.Drawing.SystemColors.Window;
			}
		}

		private void AudioSubFolder_KeyUp(object sender, KeyEventArgs e)
		{
			if (AudioSubFolder.Text == null)
			{
				AudioNameError.Text = "the sub folder is empty";
				AudioNameError.Font = new System.Drawing.Font("Arial", 8.25f, System.Drawing.FontStyle.Bold);
				AudioNameError.ForeColor = System.Drawing.Color.Red;
				AudioNameError.Visible = true;
				AudioSubFolder.BackColor = System.Drawing.Color.LightCoral;
			}
			else if (AudioSubFolder.Text.Substring(0, 1) != @"\")
			{
				AudioNameError.Text = "the sub folder not start with a " + @" \ ";
				AudioNameError.Font = new System.Drawing.Font("Arial", 8.25f, System.Drawing.FontStyle.Bold);
				AudioNameError.ForeColor = System.Drawing.Color.Red;
				AudioNameError.Visible = true;
				AudioSubFolder.BackColor = System.Drawing.Color.LightCoral;
			}
			else
			{
				AudioNameError.ForeColor = System.Drawing.SystemColors.ControlText;
				AudioNameError.Visible = false;
				AudioSubFolder.BackColor = System.Drawing.SystemColors.Window;
			}

		}

	}
}


