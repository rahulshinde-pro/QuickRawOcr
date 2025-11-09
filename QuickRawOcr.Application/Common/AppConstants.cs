using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickRawOcr.ApplicationLogic.Common
{
	public static class AppConstants
	{
		public static readonly string ProjectRoot = GetProjectRoot();
		public static readonly string TessDataDirectory = Path.Combine(ProjectRoot, "TessData");

		public enum Language
		{
			eng = 0,
			deu = 1
		}

		private static string GetProjectRoot()
		{
			// Go up 3 levels from bin/Debug/netX.Y/
			string baseDir = AppContext.BaseDirectory;
			DirectoryInfo dir = new DirectoryInfo(baseDir);
			for (int i = 0; i < 3; i++)
				dir = dir.Parent ?? dir;

			return dir.FullName;
		}
	}
}
