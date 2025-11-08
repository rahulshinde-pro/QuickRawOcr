using QuickRawOcr.ApplicationLogic.DTOs;
using QuickRawOcr.ApplicationLogic.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickRawOcr.ApplicationLogic.Services
{
	public class FileService : IFileService
	{
		public OpenFileDialogDetail FileDialogDetail { get; set; }

		public OpenFileDialogDetail SetOpenFileDialogDetail(OpenFileDialogDetail openFileDialogDetail)
		{
			FileDialogDetail = openFileDialogDetail;
			FileDialogDetail.DialogTitle = "Select a file";
			FileDialogDetail.Filter = "Image files (*.PNG)|*.PNG|All files (*.*)|*.*";
			FileDialogDetail.Multiselect = false;

			return FileDialogDetail;
		}
	}
}
