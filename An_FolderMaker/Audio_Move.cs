using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace An_FolderMaker
{
	class Audio_Move
	{
		public void audioMove(string SourceFolder, string foldersName, string audioName)
		{

			try
			{
				bool i = false;
				string[] audioArray = Directory.GetFiles(SourceFolder, audioName + "_*");
				string[] folderArray = Directory.GetDirectories(SourceFolder, foldersName + "_*");
				int index = 0;
				List<string> messagList = new List<string>();
				if (Directory.GetFiles(SourceFolder, audioName + "_*").Length == 0)
				{
					MessageBox.Show("no file with this name ");
				}
				else
				{
					i = true;
					foreach (string fN in folderArray)
					{
						try
						{
							string folderName = fN.Substring(SourceFolder.Length);

							int folderNum = folderName.Length - (folderName.IndexOf("_") + 1);

							string resultaFolder = folderName.Substring((folderName).IndexOf("_") + 1, folderNum);

							foreach (string f in audioArray)
							{
								string fileName = f.Substring(SourceFolder.Length);

								int fileNum = fileName.Length - (fileName.IndexOf("_") + 1) - 4;
								string resultaFile = fileName.Substring(fileName.IndexOf("_") + 1, fileNum);
								/////////////////////////////////////////////
								if (resultaFolder == resultaFile)
								{

									//MessageBox.Show("" + index);
									messagList.Add("folder name " + fN);
									index++;
									File.Copy(Path.Combine(SourceFolder, fileName), Path.Combine(fN, fileName));
									//Console.WriteLine("Done  " + index);		
									File.Delete(f);
									break;

								}

							}
						}
						catch (IOException FolderError)
						{
							MessageBox.Show("" + FolderError.Message);
						}




					}

				}

				//remove old files
				foreach (string f in audioArray)
				{

				}
				/*MessageBox.Show("the index is " + index);
				string text1 = "";
				for (int y = 0; y < index; y++)
				{
				text1 = messagList[y] + "\n" + " ";
				}



				MessageBox.Show("the messag index \n " + text1 + "");*/
				if (i == true)
					MessageBox.Show("Moving Audio Done");



			}
			catch (DirectoryNotFoundException dirNotFound)
			{
				MessageBox.Show("" + dirNotFound);
			}

		}
	}
}
