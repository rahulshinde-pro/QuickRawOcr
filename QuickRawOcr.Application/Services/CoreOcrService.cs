using QuickRawOcr.ApplicationLogic.Common;
using QuickRawOcr.ApplicationLogic.DTOs;
using QuickRawOcr.ApplicationLogic.Interfaces;
using Tesseract;

namespace QuickRawOcr.ApplicationLogic.Services
{
	public class CoreOcrService : ICoreOcrService
	{
		private TesseractEngine _tesseractEngine;
		private TesseractOutput _output;

        public CoreOcrService()
        {
			_output = new TesseractOutput();
			try
			{
				_tesseractEngine = new TesseractEngine(AppConstants.TessDataDirectory, AppConstants.Language.eng.ToString(), EngineMode.Default);
			}
			catch (Exception ex)
			{
				AddAsOutputError(ex);
			}
		}

		public TesseractOutput GetFullPageOcr(string filePath)
		{
			try
			{
				Pix image = Pix.LoadFromFile(filePath);
				GetOcrFromPix(image);
			}
			catch (Exception ex)
			{
				AddAsOutputError(ex);
			}

			return _output;
		}

		private void GetOcrFromPix(Pix pix)
		{
			try
			{
				if (_tesseractEngine != null)
				{
					var page = _tesseractEngine.Process(pix);
					if (page != null)
					{
						_output.OutputText = page.GetText();
						_output.IsSuccess = true;
						page.Dispose();
					}
					pix.Dispose();
				}
				else
				{
					_output.IsSuccess = false;
					_output.Error += "Error: " + "_tesseractEngine was not initialized." + Environment.NewLine;
				}
			}
			catch (Exception ex)
			{
				AddAsOutputError(ex);
			}
		}

		private void AddAsOutputError(Exception ex)
		{
			_output.IsSuccess = false;
			_output.Error += "Error: " + ex.Message + Environment.NewLine + "StackTrace: " + ex.StackTrace + Environment.NewLine;
		}
	}
}
