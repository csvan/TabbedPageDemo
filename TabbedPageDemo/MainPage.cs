using System;
using Xamarin.Forms;
using System.Collections.Generic;
using System.Diagnostics;

namespace TabbedPageDemo
{
	public class MainPage: TabbedPage
	{
		static MainPage singleton;

		public static MainPage GetInstance ()
		{
			if (singleton == null) {
				singleton = new MainPage ();
			}
			return singleton;
		}

		MainPage ()
		{

			Title = "MyNavPage";

			ItemsSource = new List<String> {
				"Locality",
				"Nearby",
				"Sundays",
				"About"
			};

			PropertyChanged += (object sender, System.ComponentModel.PropertyChangedEventArgs e) => {
				if (e.PropertyName.Equals ("SelectedItem")) {
					Debug.WriteLine (SelectedItem);
				}
			};
		}
	}
}

