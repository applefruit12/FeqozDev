using System;
using System.Diagnostics;

namespace Fortnite
{
	// Token: 0x02000002 RID: 2
	internal class Program
	{
		// Token: 0x06000001 RID: 1 RVA: 0x00002048 File Offset: 0x00000248
		private static void Main(string[] args)
		{
			Console.Title = "Made by !Sky - GD use code Sky";
			string str = string.Empty;
			string text = string.Empty;
			foreach (string text2 in args)
			{
				bool flag = text2.Contains("-epicusername=");
				bool flag2 = flag;
				if (flag2)
				{
					str = text2.Replace("-epicusername=", "");
				}
				text = text + text2 + " ";
			}
			Console.WriteLine("[Project Cloud] Welcome to Project Cloud, " + str);
			Console.WriteLine("[Project Cloud] Disabling Anti-Cheat!");
            Console.WriteLine("[Project Cloud] Injecting Dll!");
            Console.WriteLine("[Project Cloud] Launching Fortnite!");
			Process.Start("FortniteClient-Win64-Shipping.exe", text);
			Process[] processes = Process.GetProcesses();
			foreach (Process process in processes)
			{
				bool flag3 = process.ProcessName.Contains("FortniteClient-Win64-Shipping");
				bool flag4 = flag3;
				if (flag4)
				{
					Console.WriteLine("[Project Cloud] Fortnite Launched!");
					break;
				}
			}
			Console.Read();
		}
	}
}