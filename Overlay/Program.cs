/*
 * Created by SharpDevelop.
 * User: Xtry333
 * Date: 2016-07-07
 * Time: 14:59
 * 
 */
using System;
using System.Windows.Forms;

namespace Overlay
{
	/// <summary>
	/// Class with program entry point.
	/// </summary>
	internal sealed class Program
	{
		/// <summary>
		/// Program entry point.
		/// </summary>
		[STAThread]
		private static void Main(string[] args)
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new MainForm());
		}
		
	}
}
