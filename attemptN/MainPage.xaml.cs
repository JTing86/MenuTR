using Xamarin.Forms;

//using System;

namespace attemptN
{
    public partial class MainPage : ContentPage
    {
        /*
        public MainPage()

        {
            InitializeComponent();
            //add events here!
            Button button = new Button
            {
                Text = "Navigate!",
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center
            };
            button.Clicked += async (sender, args) =>
            {
                await Navigation.PushAsync(new homePage());
            };
            Content = button;
        }
            */
        public MainPage()
        {
            InitializeComponent();

            CameraButton.Clicked += CameraButton_Clicked;
        }

        private async void CameraButton_Clicked(object sender, EventArgs e)
        {
            var photo = await Plugin.Media.CrossMedia.Current.TakePhotoAsync(new Plugin.Media.Abstractions.StoreCameraMediaOptions() { });

            if (photo != null)
                PhotoImage.Source = ImageSource.FromStream(() => { return photo.GetStream(); });
        }
    }
}
