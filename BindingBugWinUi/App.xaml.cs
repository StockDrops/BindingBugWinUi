using BindingBugWinUi.Views;
using Microsoft.Maui;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Controls.PlatformConfiguration.WindowsSpecific;
using Application = Microsoft.Maui.Controls.Application;

namespace BindingBugWinUi
{
	public partial class App : Application
	{
		public App()
		{
			InitializeComponent();
			var showBug = true; //change this to false to see the normal behavior
			if(showBug)
				MainPage = new DesktopShell();
			else
				MainPage = new NormalPage();
			
		}
	}
}
