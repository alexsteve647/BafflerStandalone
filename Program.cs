using System;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace BafflerStandalone
{
	internal static class Program
	{
		[STAThread]
		private static void Main()
		{
			AppDomain.CurrentDomain.AssemblyResolve += delegate(object sender, ResolveEventArgs args)
			{
				string name = "BafflerStandalone.System.Data.SQLite.dll";
				string name2 = new AssemblyName(args.Name).Name;
				if (!(name2 == "System.Data.SQLite"))
				{
					if (!(name2 == "System.Data.SQLite.dll"))
					{
						goto IL_E0;
					}
				}
				try
				{
					try
					{
						if (!File.Exists("System.Data.SQLite.dll"))
						{
							using (Stream manifestResourceStream = Assembly.GetExecutingAssembly().GetManifestResourceStream(name))
							{
								byte[] array = new byte[manifestResourceStream.Length];
								manifestResourceStream.Read(array, 0, array.Length);
								using (FileStream fileStream = new FileStream("System.Data.SQLite.dll", FileMode.Create))
								{
									fileStream.Write(array, 0, array.Length);
									fileStream.Close();
								}
								manifestResourceStream.Close();
							}
						}
					}
					catch (Exception ex)
					{
						MessageBox.Show(ex.Message + "\n" + ex.StackTrace);
					}
					goto IL_155;
				}
				finally
				{
					MessageBox.Show("Please run the application again!");
					Environment.Exit(0);
				}
				IL_E0:
				name = "BafflerStandalone." + name2 + ".dll";
				try
				{
					using (Stream manifestResourceStream2 = Assembly.GetExecutingAssembly().GetManifestResourceStream(name))
					{
						byte[] array2 = new byte[manifestResourceStream2.Length];
						manifestResourceStream2.Read(array2, 0, array2.Length);
						return Assembly.Load(array2);
					}
				}
				catch (Exception ex2)
				{
					MessageBox.Show(ex2.Message + "\n" + ex2.StackTrace);
				}
				IL_155:
				return null;
			};
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new MainForm());
		}
	}
}
