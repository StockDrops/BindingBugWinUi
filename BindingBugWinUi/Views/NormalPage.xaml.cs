using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Essentials;

namespace BindingBugWinUi.Views
{
	public partial class NormalPage : ContentPage, INotifyPropertyChanged
	{
		int count = 0;
		public int Count
        {
			get => count;
			set => SetProperty(ref count, value);
        }
		private string labelText = "Welcome to .NET Multi-platform App UI";
		public string LabelText
        {
			get => labelText;
			set => SetProperty(ref labelText, value);
        }
		public new event PropertyChangedEventHandler PropertyChanged;
		private void SetProperty<T>(ref T storage, T value, [CallerMemberName] string propertyName = null)
		{
			if (Equals(storage, value))
			{
				return;
			}

			storage = value;
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
		}

		public NormalPage()
		{
			InitializeComponent();
			BindingContext = this;
		}

		private void OnCounterClicked(object sender, EventArgs e)
		{
			Count++;
			//CounterLabel.Text = $"Current count: {count}";
			LabelText = $"The new count is {Count}";
			//SemanticScreenReader.Announce(CounterLabel.Text);
		}
	}
}
