using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace HomeWork4Part2
{
	public partial class MainPage : ContentPage
	{
		List<string> phraseList = new List<string>();
		public MainPage ()
		{
			InitializeComponent ();

			phraseList.Add("I want to seeSharp");
			phraseList.Add("Im starting to like Xamarin");
			phraseList.Add("But I still like Xcode better");
			phraseList.Add("but xamarin I can build in three platform at the same time");


		}
		async void OnClickedRandom(object sender, EventArgs e){
			var random = new Random();
			displayLabel.Text = this.phraseList [random.Next (0, 3)];
		}
	}
}

