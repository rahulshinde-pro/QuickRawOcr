using QuickRawOcr.ApplicationLogic.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickRawOcr.ApplicationLogic.Interfaces
{
	public interface IFileService
	{
		OpenFileDialogDetail SetOpenFileDialogDetail(OpenFileDialogDetail openFileDialogDetail);
	}
}
