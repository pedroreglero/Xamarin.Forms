namespace Microsoft.Maui.Handlers
{
	public partial class LabelHandler
	{
		public static PropertyMapper<ILabel, LabelHandler> LabelMapper = new PropertyMapper<ILabel, LabelHandler>(ViewHandler.ViewMapper)
		{
			[nameof(ILabel.TextColor)] = MapTextColor,
			[nameof(ILabel.Text)] = MapText,
			[nameof(ILabel.FontFamily)] = MapFontFamily,
		};

		public LabelHandler() : base(LabelMapper)
		{

		}

		public LabelHandler(PropertyMapper mapper) : base(mapper ?? LabelMapper)
		{

		}
	}
}