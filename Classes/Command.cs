using System;
using System.Management.Automation;

namespace Commander.Classes
{
	public class Command
	{
		public string Name { get; set; }
		public string Cmd { get; set; }

		public Command(string name = "New Command", string cmd = "")
		{
			this.Name = name;
			this.Cmd = cmd;
		}

		public Command()
		{
			this.Name = "";
			this.Cmd = "";
		}

		public void Run()
		{
			//PowerShell.Create().AddScript(Cmd).Invoke();
			System.Diagnostics.Process process = new System.Diagnostics.Process();
			System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
			startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
			startInfo.FileName = "cmd.exe";
			startInfo.Arguments = "/C " + Cmd;
			process.StartInfo = startInfo;
			process.Start();
		}
	}
}
