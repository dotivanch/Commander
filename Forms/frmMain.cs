using Commander.Classes;
using Commander.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace Commander
{
	public partial class frmMain : Form
	{
		private List<Command> commandList = new List<Command>();

		public frmMain()
		{
			InitializeComponent();
			CreateConfigurationFile();
			LoadCommandList();
		}

		private void createNewButton_Click(object sender, EventArgs e)
		{
			frmCreateNew createNew = new frmCreateNew();
			createNew.Visible = true;
			createNew.OnCreate += CreateNew_OnCreate;
		}

		private void runButton_Click(object sender, EventArgs e)
		{
			if (commandsListBox.SelectedItem != null)
			{
				Command cmd = commandList.Find(m => m.Name == commandsListBox.SelectedItem.ToString());
				cmd?.Run();
			}
		}

		private void CreateNew_OnCreate(Command cmd)
		{
			commandList.Add(cmd);
			RefreshCommandGroupList();
			SaveCommandList();
		}

		private void RefreshCommandGroupList()
		{
			commandsListBox.Items.Clear();
			commandList.ForEach(cmd =>
			{
				commandsListBox.Items.Add(cmd.Name);
			});
		}

		private void CreateConfigurationFile()
		{
			string file = "configuration.xml";
			if (!File.Exists(file))
			{
				File.Create(file);
			}
		}

		private void SaveCommandList()
		{
			string file = "configuration.xml";

			FileStream outFile = File.OpenWrite(file);
			XmlSerializer formatter = new XmlSerializer(commandList.GetType());
			formatter.Serialize(outFile, commandList);
			outFile.Close();
		}

		private void LoadCommandList()
		{
			string file = "configuration.xml";
			FileStream inFile = null;
			try
			{
				XmlSerializer formatter = new XmlSerializer(commandList.GetType());
				inFile = File.OpenRead(file);
				byte[] buffer = new byte[inFile.Length];
				inFile.Read(buffer, 0, (int)inFile.Length);
				MemoryStream stream = new MemoryStream(buffer);
				commandList = (List<Command>)formatter.Deserialize(stream);
				RefreshCommandGroupList();
			}
			catch (Exception e)
			{
				MessageBox.Show("Error", "Error while loading configuration files:\n" + e.Message + "\n" + e.StackTrace);
				inFile?.Close();
			}
		}
	}
}
