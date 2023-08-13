namespace RoutePlanner;
using Mapsui.UI.Maui;
using Microsoft.Maui.Controls;

public partial class MainPage : ContentPage
{

	public MainPage()
	{
		InitializeComponent();

		MapControl mapControl = new MapControl();
		mapControl.Map?.Layers.Add(Mapsui.Tiling.OpenStreetMap.CreateTileLayer());

		Grid grid = new Grid
		{
			ColumnDefinitions =
			{
				new ColumnDefinition { Width = new GridLength(100, GridUnitType.Absolute) },
				new ColumnDefinition { Width = new GridLength(2, GridUnitType.Star) }
			},
			RowDefinitions =
			{
				new RowDefinition { Height = new GridLength(400, GridUnitType.Absolute)}
			}

		};

		grid.Add(new ScrollView()
			{
				Content = new VerticalStackLayout()
				{
					Spacing = 20,
					Children =
							{
								new Label(){Text="Hello"},
								new Label(){Text="Hello2"}
							}
				}
			}, 0, 0);
		grid.Add(mapControl, 1, 0);

		Content = grid;

	}

}

