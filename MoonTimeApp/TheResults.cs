using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace MoonTimeApp
{
	[Activity (Label = "TheResults")]			
	public class TheResults : Activity
	{
		Model aModel;
		protected override void OnCreate (Bundle bundle)
		{
			aModel = new Model();
			base.OnCreate (bundle);
			SetContentView (Resource.Layout.FinalResults);
			Button exit3Button = FindViewById<Button> (Resource.Id.btnExit3);
			Button restart = FindViewById<Button> (Resource.Id.btnReturn);
			TextView displayResults = FindViewById<TextView> (Resource.Id.yourComputedResults);
			//ImageView theEndResult = FindViewById<ImageView> (Resource.Id.finalImageResult);
			// Create your application here	

		
			//theEndResult.setImageResource(Resource.drawable.);
			//	displayResults.Text = aModel.CalculatedOutput.ToString();


		restart.Click +=delegate {
				var intent= new Intent(this, typeof(MainActivity));
			StartActivity(intent);
		};

		exit3Button.Click +=delegate {
			System.Environment.Exit(0);
		};

		}
	}
}