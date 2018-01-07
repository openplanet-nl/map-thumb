using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OPMapThumb
{
	static class Program
	{
		public static string StartLoadFile;

		[STAThread]
		static void Main(string[] args)
		{
			if (args.Length > 0) {
				StartLoadFile = args[0];
			}

			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new FormMain());
		}
	}
}
