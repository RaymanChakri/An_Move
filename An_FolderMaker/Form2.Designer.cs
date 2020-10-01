namespace An_FolderMaker
{
	partial class Form2
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
			this.CloseBut = new System.Windows.Forms.Button();
			this.richFolder = new System.Windows.Forms.RichTextBox();
			this.RefreshBut = new System.Windows.Forms.Button();
			this.FoldList = new System.Windows.Forms.Label();
			this.AudList = new System.Windows.Forms.Label();
			this.richAudio = new System.Windows.Forms.RichTextBox();
			this.SuspendLayout();
			// 
			// CloseBut
			// 
			this.CloseBut.Location = new System.Drawing.Point(290, 465);
			this.CloseBut.Name = "CloseBut";
			this.CloseBut.Size = new System.Drawing.Size(92, 52);
			this.CloseBut.TabIndex = 1;
			this.CloseBut.Text = "CloseBut";
			this.CloseBut.UseVisualStyleBackColor = true;
			this.CloseBut.Click += new System.EventHandler(this.button1_Click);
			// 
			// richFolder
			// 
			this.richFolder.Location = new System.Drawing.Point(16, 30);
			this.richFolder.Name = "richFolder";
			this.richFolder.Size = new System.Drawing.Size(175, 430);
			this.richFolder.TabIndex = 2;
			this.richFolder.Text = "";
			this.richFolder.TextChanged += new System.EventHandler(this.richTextBox_TextChanged);
			// 
			// RefreshBut
			// 
			this.RefreshBut.Location = new System.Drawing.Point(12, 465);
			this.RefreshBut.Name = "RefreshBut";
			this.RefreshBut.Size = new System.Drawing.Size(272, 52);
			this.RefreshBut.TabIndex = 3;
			this.RefreshBut.Text = "Refresh";
			this.RefreshBut.UseVisualStyleBackColor = true;
			this.RefreshBut.Click += new System.EventHandler(this.RefreshBut_Click);
			// 
			// FoldList
			// 
			this.FoldList.AutoSize = true;
			this.FoldList.Location = new System.Drawing.Point(14, 9);
			this.FoldList.Name = "FoldList";
			this.FoldList.Size = new System.Drawing.Size(37, 13);
			this.FoldList.TabIndex = 4;
			this.FoldList.Text = "FolList";
			// 
			// AudList
			// 
			this.AudList.AutoSize = true;
			this.AudList.Location = new System.Drawing.Point(205, 8);
			this.AudList.Name = "AudList";
			this.AudList.Size = new System.Drawing.Size(37, 13);
			this.AudList.TabIndex = 6;
			this.AudList.Text = "FolList";
			// 
			// richAudio
			// 
			this.richAudio.Location = new System.Drawing.Point(207, 29);
			this.richAudio.Name = "richAudio";
			this.richAudio.Size = new System.Drawing.Size(175, 430);
			this.richAudio.TabIndex = 5;
			this.richAudio.Text = "";
			// 
			// Form2
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(394, 524);
			this.Controls.Add(this.AudList);
			this.Controls.Add(this.richAudio);
			this.Controls.Add(this.FoldList);
			this.Controls.Add(this.RefreshBut);
			this.Controls.Add(this.richFolder);
			this.Controls.Add(this.CloseBut);
			this.Name = "Form2";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Form2";
			this.Load += new System.EventHandler(this.Form2_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Button CloseBut;
		private System.Windows.Forms.RichTextBox richFolder;
		private System.Windows.Forms.Button RefreshBut;
		private System.Windows.Forms.Label FoldList;
		private System.Windows.Forms.Label AudList;
		private System.Windows.Forms.RichTextBox richAudio;
	}
}