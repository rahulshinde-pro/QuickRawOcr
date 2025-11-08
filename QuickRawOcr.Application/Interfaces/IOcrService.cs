using QuickRawOcr.ApplicationLogic.DTOs;

namespace QuickRawOcr.ApplicationLogic.Interfaces
{
	public interface IOcrService
	{
		OcrOutput GetFullOcrText(OcrInput ocrInput);
	}
}
