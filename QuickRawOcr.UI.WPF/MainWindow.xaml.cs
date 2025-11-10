using Microsoft.Win32;
using QuickRawOcr.ApplicationLogic.DTOs;
using QuickRawOcr.ApplicationLogic.Interfaces;
using QuickRawOcr.ApplicationLogic.Services;
using System.Windows;

namespace QuickRawOcr.UI.WPF
{
	/// <summary>
	/// Windows Application UI, to use and handle Tesseract OCR output
	/// </summary>
	public partial class MainWindow : Window
	{
		private IOcrService _ocrService;
		private IFileService _fileService;
		private WpfImageOperations _imageOperations;

		public MainWindow()
		{
			InitializeComponent();
			_ocrService = new OcrService();
			_fileService = new FileService();
			_imageOperations = new WpfImageOperations();
		}

		private void btnImport_Click(object sender, RoutedEventArgs e)
		{
			try
			{
				OpenFileDialogDetail openFileDialogDetail = new OpenFileDialogDetail();
				_fileService.SetOpenFileDialogDetail(openFileDialogDetail);
				OpenFileDialog openFileDialog = new OpenFileDialog
				{
					Title = openFileDialogDetail.DialogTitle,
					Filter = openFileDialogDetail.Filter,
					Multiselect = openFileDialogDetail.Multiselect
				};

				openFileDialog.ShowDialog();
				if (openFileDialog.FileName != string.Empty)
				{
					OcrInput ocrInput = new OcrInput(openFileDialog.FileName);

					ImagePanel.Children.Clear();
					txtFullText.Text = string.Empty;

					OcrOutput ocrOutput = _ocrService.GetFullOcrText(ocrInput);
					if (ocrOutput.IsSuccess)
					{
						var wpfImage = _imageOperations.GetImage(ocrOutput.BasicBitmap);
						ImagePanel.Children.Add(wpfImage);
						txtFullText.Text = ocrOutput.FullPageText;
					}
					else
					{
						MessageBox.Show(ocrOutput.Error);
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message + Environment.NewLine + ex.StackTrace);
			}
		}
    }
}