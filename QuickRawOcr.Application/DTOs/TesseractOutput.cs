using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickRawOcr.ApplicationLogic.DTOs
{
	public class TesseractOutput
	{
		public bool IsSuccess { get; set; }
		public string OutputText { get; set; }
		public string Error {  get; set; }
	}
}
