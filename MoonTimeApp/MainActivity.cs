using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Android.Media;

namespace MoonTimeApp
{
	[Activity (Label = "MoonTimeApp", MainLauncher = true, Icon = "@drawable/icon")]
	public class MainActivity : Activity
	{


		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.Main);

			// Get our button from the layout resource,
			// and attach an event to it
			Button mainProgramArea = FindViewById<Button> (Resource.Id.mainProgramButton);
			Button button2 = FindViewById<Button> (Resource.Id.btnExit1);
			//button.Click += delegate {
			//	button.Text = string.Format ("{0} clicks!", count++);
			mainProgramArea.Click +=delegate {
				//var intent= new Intent(this, typeof(Calc));
				//StartActivity(intent);
				StartActivity(typeof(Calc));

			};
			button2.Click += delegate {
				//System.exit(0);
				System.Environment.Exit(0);
			};
			//VideoView videoView1 = (VideoView)FindViewById(Resource.Id.videoView1);
			//Uri uri = Uri.Parse("android.resource://"+getPackageName()+"/"+Resource.Raw.android);
		
			//videoView1.SetVideoURI (Android);
			//videoView1.IsPlaying ();
			//videoView1.setVideoURI(uri);
			//videoView1.start();  
			/*
			MediaPlayer mediaPlayer;
		
			base.OnCreate (bundle);

			SetContentView (Resource.Layout.Main);

			var videoView = (VideoView)FindViewById<VideoView> (Resource.Id.videoView1);
			ISurfaceHolder holder = videoView.Holder;
			//holder.SetType (SurfaceType.PushBuffers);
			//holder.AddCallback();


			var descriptor = Assets.OpenFd("android.m4v");
			mediaPlayer = new MediaPlayer ();
			mediaPlayer.SetDataSource(descriptor.FileDescriptor, descriptor.StartOffset, descriptor.Length);
			mediaPlayer.Prepare();
			mediaPlayer.Looping = true;
			mediaPlayer.Start();
			*/

		
			//mediaPlayer.setDataSource(this, uri);

			// Create a new TextView and set it as our view
			//var tv = new  (this);
		//ar tv = new VideoView (this);
			// Read the contents of our asset
			//string content;

		}
	}
}
