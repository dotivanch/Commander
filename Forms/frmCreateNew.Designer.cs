
namespace Commander.Forms
{
	partial class frmCreateNew
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.createButton = new System.Windows.Forms.Button();
			this.nameTextBox = new System.Windows.Forms.TextBox();
			this.cmdTextBox = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(13, 13);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 15);
			this.label1.TabIndex = 0;
			this.label1.Text = "Command name:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(13, 42);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(67, 15);
			this.label2.TabIndex = 1;
			this.label2.Text = "Command:";
			// 
			// createButton
			// 
			this.createButton.Location = new System.Drawing.Point(302, 39);
			this.createButton.Name = "createButton";
			this.createButton.Size = new System.Drawing.Size(100, 41);
			this.createButton.TabIndex = 2;
			this.createButton.Text = "Create";
			this.createButton.UseVisualStyleBackColor = true;
			this.createButton.Click += new System.EventHandler(this.createButton_Click);
			// 
			// nameTextBox
			// 
			this.nameTextBox.Location = new System.Drawing.Point(119, 10);
			this.nameTextBox.Name = "nameTextBox";
			this.nameTextBox.Size = new System.Drawing.Size(179, 23);
			this.nameTextBox.TabIndex = 3;
			// 
			// cmdTextBox
			// 
			this.cmdTextBox.Location = new System.Drawing.Point(86, 39);
			this.cmdTextBox.Multiline = true;
			this.cmdTextBox.Name = "cmdTextBox";
			this.cmdTextBox.Size = new System.Drawing.Size(212, 84);
			this.cmdTextBox.TabIndex = 4;
			// 
			// frmCreateNew
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(414, 133);
			this.Controls.Add(this.cmdTextBox);
			this.Controls.Add(this.nameTextBox);
			this.Controls.Add(this.createButton);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "frmCreateNew";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Create New";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button createButton;
		private System.Windows.Forms.TextBox nameTextBox;
		private System.Windows.Forms.TextBox cmdTextBox;
	}
}