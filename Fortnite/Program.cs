using Castle.MicroKernel;
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
				}
				text = text + text2 + " ";
			}
			Console.WriteLine("Welcome to AppleFN! Welcome " + str);
		// APPLEFN  LEAKS LOL
		 // I NAMED IT TO APPLE FN BC WHY NOT
			Console.WriteLine("Disabling Anti-Cheat!");
			Console.WriteLine("Injecting Dll!");
			Console.WriteLine("Launching Fortnite!");
			Process.Start("FortniteClient-Win64-Shipping.exe", text);
			Process[] processes = Process.GetProcesses();
		
			
			{
					Console.WriteLine("Fortnite Launched!");
					break;
				}
			}
			Console.Read();

			
		}
	}
	}
