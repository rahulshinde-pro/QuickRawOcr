using QuickRawOcr.ApplicationLogic.DTOs;
using QuickRawOcr.ApplicationLogic.Interfaces;

namespace QuickRawOcr.ApplicationLogic.Services
{
	public class OcrService : IOcrService
	{
		private ICoreOcrService _coreOcrService;
		public OcrService()
		{
			_coreOcrService = new CoreOcrService();
		}

		public OcrOutput GetFullOcrText(OcrInput ocrInput)
		{
			OcrOutput ocrOutput = new OcrOutput();
			ocrOutput.BasicBitmap = new System.Drawing.Bitmap(ocrInput.FilePath);

			TesseractOutput tesseractOutput = _coreOcrService.GetFullPageOcr(ocrInput.FilePath);
			ocrOutput.IsSuccess = tesseractOutput.IsSuccess;
			ocrOutput.FullPageText = tesseractOutput.OutputText;
			ocrOutput.Error = tesseractOutput.Error;

			return ocrOutput;
		}
	}
}
