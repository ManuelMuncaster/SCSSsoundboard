using Xamarin.Forms;
using System;

namespace SCSSsoundboard
{
	public partial class SCSSsoundboardPage : ContentPage
	{
		public SCSSsoundboardPage()
		{
			InitializeComponent();
			//grid.BackgroundColor = Color.Green;
		}

		public void booker1_Clicked (object sender, EventArgs args)
		{
			DependencyService.Get<IAudio>().PlayAudioFile("Booker_1.mp3");
		}
		public void booker2_Clicked(object sender, EventArgs args)
		{
			DependencyService.Get<IAudio>().PlayAudioFile("Booker_2.mp3");
		}
		public void bannerman1_Clicked(object sender, EventArgs args)
		{
			DependencyService.Get<IAudio>().PlayAudioFile("Bannerman1.mp3");
		}
	}
}
