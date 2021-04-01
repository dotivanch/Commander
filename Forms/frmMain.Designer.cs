
namespace Commander
{
	partial class frmMain
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
			this.commandsGroupBox = new System.Windows.Forms.GroupBox();
			this.runButton = new System.Windows.Forms.Button();
			this.modifyButton = new System.Windows.Forms.Button();
			this.removeButton = new System.Windows.Forms.Button();
			this.createNewButton = new System.Windows.Forms.Button();
			this.commandsListBox = new System.Windows.Forms.ListBox();
			this.commandsGroupBox.SuspendLayout();
			this.SuspendLayout();
			// 
			// commandsGroupBox
			// 
			this.commandsGroupBox.Controls.Add(this.commandsListBox);
			this.commandsGroupBox.Location = new System.Drawing.Point(13, 13);
			this.commandsGroupBox.Name = "commandsGroupBox";
			this.commandsGroupBox.Size = new System.Drawing.Size(545, 425);
			this.commandsGroupBox.TabIndex = 0;
			this.commandsGroupBox.TabStop = false;
			this.commandsGroupBox.Text = "Commands";
			// 
			// runButton
			// 
			this.runButton.Location = new System.Drawing.Point(564, 20);
			this.runButton.Name = "runButton";
			this.runButton.Size = new System.Drawing.Size(189, 41);
			this.runButton.TabIndex = 1;
			this.runButton.Text = "Run";
			this.runButton.UseVisualStyleBackColor = true;
			this.runButton.Click += new System.EventHandler(this.runButton_Click);
			// 
			// modifyButton
			// 
			this.modifyButton.Location = new System.Drawing.Point(564, 67);
			this.modifyButton.Name = "modifyButton";
			this.modifyButton.Size = new System.Drawing.Size(189, 41);
			this.modifyButton.TabIndex = 2;
			this.modifyButton.Text = "Modify";
			this.modifyButton.UseVisualStyleBackColor = true;
			// 
			// removeButton
			// 
			this.removeButton.Location = new System.Drawing.Point(564, 114);
			this.removeButton.Name = "removeButton";
			this.removeButton.Size = new System.Drawing.Size(189, 41);
			this.removeButton.TabIndex = 3;
			this.removeButton.Text = "Remove";
			this.removeButton.UseVisualStyleBackColor = true;
			// 
			// createNewButton
			// 
			this.createNewButton.Location = new System.Drawing.Point(564, 397);
			this.createNewButton.Name = "createNewButton";
			this.createNewButton.Size = new System.Drawing.Size(189, 41);
			this.createNewButton.TabIndex = 4;
			this.createNewButton.Text = "Create New";
			this.createNewButton.UseVisualStyleBackColor = true;
			this.createNewButton.Click += new System.EventHandler(this.createNewButton_Click);
			// 
			// commandsListBox
			// 
			this.commandsListBox.FormattingEnabled = true;
			this.commandsListBox.ItemHeight = 15;
			this.commandsListBox.Location = new System.Drawing.Point(7, 23);
			this.commandsListBox.Name = "commandsListBox";
			this.commandsListBox.Size = new System.Drawing.Size(532, 394);
			this.commandsListBox.TabIndex = 0;
			// 
			// frmMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(765, 450);
			this.Controls.Add(this.createNewButton);
			this.Controls.Add(this.removeButton);
			this.Controls.Add(this.modifyButton);
			this.Controls.Add(this.runButton);
			this.Controls.Add(this.commandsGroupBox);
			this.Name = "frmMain";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = " Commander";
			this.commandsGroupBox.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox commandsGroupBox;
		private System.Windows.Forms.Button runButton;
		private System.Windows.Forms.Button modifyButton;
		private System.Windows.Forms.Button removeButton;
		private System.Windows.Forms.Button createNewButton;
		private System.Windows.Forms.ListBox commandsListBox;
	}
}

