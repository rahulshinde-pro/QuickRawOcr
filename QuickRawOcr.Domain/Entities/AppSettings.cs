using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickRawOcr.Domain.Entities
{
	public class AppSettings
	{
		public DomainConstants.ExportFileFormat ExportFormat {  get; set; }
		public string ExportDirectory { get; set; }
	}
}
