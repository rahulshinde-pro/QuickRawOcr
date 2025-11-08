using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media.Imaging;

namespace QuickRawOcr.UI.WPF
{
	public class WpfImageOperations
	{
		public UIElement GetImage(Bitmap basicBitmap)
		{
			BitmapSource bitmapSource = ConvertBitmapToBitmapSource(basicBitmap);
			var image = new System.Windows.Controls.Image
			{
				Source = bitmapSource,
				Margin = new Thickness(5),
				Stretch = System.Windows.Media.Stretch.Uniform
			};

			return image;
		}

		private BitmapSource ConvertBitmapToBitmapSource(Bitmap basicBitmap)
		{
			var hBitmap = basicBitmap.GetHbitmap();

			return System.Windows.Interop.Imaging.CreateBitmapSourceFromHBitmap(
				hBitmap,
				IntPtr.Zero,
				Int32Rect.Empty,
				BitmapSizeOptions.FromEmptyOptions());
		}
	}
}
