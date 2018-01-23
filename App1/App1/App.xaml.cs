using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;

namespace App1
{
	public partial class App : Application
	{
		public App ()
		{
			InitializeComponent();

			MainPage = new App1.MainPage();
		}

		protected override void OnStart ()
        {
            AppCenter.Start("ios=ed188bb0-0319-41e7-88a5-8e4b93450f38;" + "uwp={ed188bb0-0319-41e7-88a5-8e4b93450f38};" +
                               "android={ed188bb0-0319-41e7-88a5-8e4b93450f38}",
                               typeof(Analytics), typeof(Crashes));
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
