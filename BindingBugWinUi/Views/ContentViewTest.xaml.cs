using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Essentials;
using Microsoft.Toolkit.Mvvm.Input;

namespace BindingBugWinUi.Views
{

    public partial class ContentViewTest : ContentPage, INotifyPropertyChanged
    {
        int count = 0;
        public int Count
        {
            get => count;
            set => SetProperty<int>(ref count, value);
        }
        private string labelText = "not empty";
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
        public ContentViewTest()
        {
            InitializeComponent();
            BindingContext = this;

        }
        private void OnCounterClicked(object sender, EventArgs e)
        {
            //LabelText = "hi0";
            ++Count;
            //CounterLabel2.Text = $"Current count: {count++}";
            //LabelText = $"The new count is {Count}";
            //LabelText = "The new count is {Count}"; //this line of code saves the day...
        }
    }
}