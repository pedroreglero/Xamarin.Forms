using Android.Util;
using Android.Widget;

namespace Microsoft.Maui
{
	public static class LabelExtensions
	{
		public static void UpdateText(this TextView textView, ILabel label)
		{
			textView.Text = label.Text;
		}

		public static void UpdateTextColor(this TextView textView, ILabel label, Color defaultColor)
		{
			Color textColor = label.TextColor;

			if (textColor.IsDefault)
			{
				textView.SetTextColor(defaultColor.ToNative());
			}
			else
			{
				textView.SetTextColor(textColor.ToNative());
			}
		}

		public static void UpdateFont(this TextView textView, ILabel label, IFontManager fontManager)
		{
			var font = label.GetFont();

			var tf = fontManager.GetTypeface(font);
			textView.Typeface = tf;

			var sp = fontManager.GetScaledPixel(font);
			textView.SetTextSize(ComplexUnitType.Sp, sp);
		}
	}
}