using GestaoDePedidosMaui.Pages;

namespace GestaoDePedidosMaui;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		//MainPage = new NavigationPage(new MainPage());      
		MainPage = new AppShell();

        Microsoft.Maui.Handlers.EntryHandler.Mapper.AppendToMapping(nameof(EntrySemBorda), (handler, view) => 
		{

#if __IOS__
            handler.PlatformView.BackgroundColor = UIKit.UIColor.Clear;
				handler.PlatformView.BorderStyle = UIKit.UITextBorderStyle.None;
#elif __WINDOWS__
				handler.PlatformView.Background = new Windows.UI.Xaml.Media.SolidColorBrush(Windows.UI.Colors.Transparent);
#endif
        });
	}
}
