using System;

using Xamarin.Forms;

namespace StdControlsXamarinForm
{
	public class App : Application
	{
		public App ()
		{
			Label lbl_name = new Label {
				Text = "This is Label",
				//VerticalOptions=
			};
			Image img = new Image {
				Source="Default.png",
				HeightRequest=200,
				WidthRequest=200
			};
			Button btn_click = new Button {
				Text = "Click here"
			};
			// The root page of your application
			MainPage = new ContentPage {
				Content = new StackLayout {
					VerticalOptions = LayoutOptions.Center,
					Children = {
						lbl_name, img,btn_click
					}
				}
			};
			btn_click.Clicked += (sender, e) => {
				lbl_name.Text="Button Clicked";
			};
		
		}

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}

