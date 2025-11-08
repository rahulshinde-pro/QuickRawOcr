using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickRawOcr.ApplicationLogic.DTOs
{
	public class OcrOutput
	{
		public string FullPageText { get; set; }
		public Bitmap BasicBitmap { get; set; }
	}
}
