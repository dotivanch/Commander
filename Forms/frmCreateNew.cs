using Commander.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Commander.Forms
{
	public delegate void CreateNewHandler(Command cmd);
	public partial class frmCreateNew : Form
	{
		public event CreateNewHandler OnCreate;

		public frmCreateNew()
		{
			InitializeComponent();
		}

		private void createButton_Click(object sender, EventArgs e)
		{
			OnCreate?.Invoke(new Command(nameTextBox.Text, cmdTextBox.Text));
			this.Close();
		}
	}
}
