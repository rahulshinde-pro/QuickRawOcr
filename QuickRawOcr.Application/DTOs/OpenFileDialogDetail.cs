using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickRawOcr.ApplicationLogic.DTOs
{
	public class OpenFileDialogDetail
	{
		public string DialogTitle { get; set; }
		public string Filter { get; set; }
		public bool Multiselect { get; set; }
		public string SelectedFile { get; set; }
	}
}
