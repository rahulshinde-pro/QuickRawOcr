using QuickRawOcr.ApplicationLogic.DTOs;
using QuickRawOcr.ApplicationLogic.Interfaces;

namespace QuickRawOcr.ApplicationLogic.Services
{
	public class OcrService : IOcrService
	{
		public OcrService() { }

		public OcrOutput GetFullOcrText(OcrInput ocrInput)
		{
			OcrOutput ocrOutput = new OcrOutput();
			ocrOutput.BasicBitmap = new System.Drawing.Bitmap(ocrInput.FilePath);

			// TODO create one core OCR server and get ocr text for the respective image

			return ocrOutput;
		}
	}
}
