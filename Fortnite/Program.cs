﻿using Castle.MicroKernel;
using System;
using System.Diagnostics;
using System.Net;
using System.Windows.Forms;

namespace Fortnite
{
	// Token: 0x02000002 RID: 2
	internal class Program
	{
        private static string tempPath;

        // Token: 0x06000001 RID: 1 RVA: 0x00002048 File Offset: 0x00000248
        private static void Main(string[] args)
		{
			Console.Title = "Made by Feqoz And Applefruit";
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
			Console.WriteLine("Welcome to AppleFN! Welcome " + str);
			Console.WriteLine("Disabling Anti-Cheat!");
			Console.WriteLine("Injecting Dll!");
			Console.WriteLine("Launching Fortnite!");
			Process.Start("FortniteClient-Win64-Shipping.exe", text);
			Process[] processes = Process.GetProcesses();
			foreach (Process process in processes)
			{
				bool flag3 = process.ProcessName.Contains("FortniteClient-Win64-Shipping");
				
				bool flag4 = flag3;
				if (flag4)
					MessageBox.Show("Click Ok To Inject AppleFN!");
				
			
			{
					Console.WriteLine("Fortnite Launched!");
					break;
				}
			}
			Console.Read();

			
		}
	}
	}
