using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Essentials;

namespace BindingBugWinUi.Views
{
	public partial class TabbedPageExample : TabbedPage, INotifyPropertyChanged
	{
		public TabbedPageExample()
		{
			InitializeComponent();
			BindingContext = this;
		}

	}
}
