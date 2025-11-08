using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickRawOcr.ApplicationLogic.DTOs
{
	public class OcrInput
	{
		public OcrInput(string filePath)
		{
			FilePath = filePath;
		}

		public string FilePath { get; set; }
		public string FileName { get; set; }
	}
}
