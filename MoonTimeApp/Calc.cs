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
using Android.Content.Res;


namespace MoonTimeApp
{
	[Activity (Label = "Calc")]	

	public class Calc : Activity
	{
		Model aModel;
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);
			// Create your application here
			SetContentView (Resource.Layout.App);
			Button resultsBtn = FindViewById<Button> (Resource.Id.btnCalcResults);
			Button exitBtn = FindViewById<Button> (Resource.Id.btnExit2);
			//ImageView res = FindViewById<ImageView> (Resource.Id.pic);
			//NumberPicker elongation = FindViewById<NumberPicker> (Resource.Id.numberPickerElong);

		exitBtn.Click += delegate {
			System.Environment.Exit(0);
		};		
		
		resultsBtn.Click += delegate {

				String[] values=new String[12];
				/*for(int i=0;i<values.Length;i++){
					values[i]Int32.ToString(i*15);
				}
				*/
				//var res = FindViewById<ImageView> (Resource.Id.pic);
				for(int i=0;i<values.Length;i++){
					values[i] = values[i*15].ToString();
				}
				var imageView = FindViewById<ImageView> (Resource.Id.pic);
				RadioButton Eastern = FindViewById<RadioButton> (Resource.Id.radioButtonEast);
				RadioButton Western = FindViewById<RadioButton> (Resource.Id.radioButtonWest);
				RadioButton FullM = FindViewById<RadioButton> (Resource.Id.radioButtonFullMoon);
				RadioButton NewM = FindViewById<RadioButton> (Resource.Id.radioButtonNewMoon);
				EditText theAppearance = FindViewById<EditText> (Resource.Id.editAppearance);
				EditText elongation = FindViewById<EditText> (Resource.Id.numberPickerElong);
				aModel = new Model();

				int convertedAppear = 0;
				string Appear = theAppearance.Text.Any().ToString();
				//string Appear = theAppearance.Text.ToString();
				if(string.Equals(Appear,"rising",  StringComparison.OrdinalIgnoreCase)){
					convertedAppear = 1;
				}
				else if (string.Equals(Appear, "ineast", StringComparison.OrdinalIgnoreCase)){
					convertedAppear = 2;
				} 
				else if (string.Equals(Appear, "highsky", StringComparison.OrdinalIgnoreCase)){
					convertedAppear = 3;
				} 
				else if (string.Equals(Appear, "inwest", StringComparison.OrdinalIgnoreCase)){
					convertedAppear = 4;
				} 
				else if (string.Equals(Appear, "setting", StringComparison.OrdinalIgnoreCase)){
					convertedAppear = 5;
				} 
				else if (string.Equals(Appear, "lowwest", StringComparison.OrdinalIgnoreCase)){
					convertedAppear = 6;
				} 
				else if (string.Equals(Appear, "lowsky", StringComparison.OrdinalIgnoreCase)){
					convertedAppear = 7;
				} 
				else {
					convertedAppear = 8;
				}
			
				if (Eastern.Checked) {
					//if (elongation.Equals.) {
					//if(int.Equals(elongation, 45, StringComparison.OrdinalIgnoreCase)){
					if(string.Equals(elongation, "45")){
						switch (convertedAppear) {
						case 1:
							//aModel.CalculatedOutput = "waxingcrest45ineast";
							imageView.SetImageResource (Resource.Drawable.waxingcrest45rising);
							break;
						case 2:
							//aModel.CalculatedOutput = "waxingcrest45ineast";
							imageView.SetImageResource (Resource.Drawable.waxingcrest45ineast);
							break;
						case 3:
							//aModel.CalculatedOutput = "waxingcrest45highsky";
							imageView.SetImageResource (Resource.Drawable.waxingcrest45highsky);
							break;
						case 4:			
							//aModel.CalculatedOutput = "waxingcrest45inwest";
							imageView.SetImageResource (Resource.Drawable.waxingcrest45inwest);
							break;
						case 5:		
							//aModel.CalculatedOutput = "waxingcrest45setting";
							imageView.SetImageResource (Resource.Drawable.waxingcrest45setting);
							break;
						case 6:
							//aModel.CalculatedOutput = "waxingcrest45lowwest";
							imageView.SetImageResource (Resource.Drawable.waxingcrest45lowwest);
							break;
						case 7:		
							//aModel.CalculatedOutput = "waxingcrest45lowsky";
							imageView.SetImageResource (Resource.Drawable.waxingcrest45lowsky);
							break;
						case 8:
							//aModel.CalculatedOutput = "waxingcrest45loweast";
							imageView.SetImageResource (Resource.Drawable.waxingcrest45loweast);
							break;
						}
					}
					//else if (elongation == 90) {
					//else if(string.Equals(elongation, "90", StringComparison.OrdinalIgnoreCase)){
					else if(string.Equals(elongation, "90")){
						switch (convertedAppear) {
						case 1:
							//aModel.CalculatedOutput = "firstquarter90rising";
							imageView.SetImageResource (Resource.Drawable.firstquarter90rising);
							break;
						case 2:
							//aModel.CalculatedOutput = "firstquarter90ineast";
							imageView.SetImageResource (Resource.Drawable.firstquarter90ineast);
							break;
						case 3:
							//aModel.CalculatedOutput = "firstquarter90highsky";
							imageView.SetImageResource (Resource.Drawable.firstquarter90highsky);
							break;
						case 4:
							//aModel.CalculatedOutput = "firstquarter90inwest";
							imageView.SetImageResource (Resource.Drawable.firstquarter90inwest);
							break;
						case 5:
							//aModel.CalculatedOutput = "firstquarter90setting";
							imageView.SetImageResource (Resource.Drawable.firstquarter90setting);
							break;
						case 6:
							//aModel.CalculatedOutput = "firstquarter90lowwest";
							imageView.SetImageResource (Resource.Drawable.firstquarter90lowwest);
							break;
						case 7:
							//aModel.CalculatedOutput = "firstquarter90lowsky";
							imageView.SetImageResource (Resource.Drawable.firstquarter90lowsky);
							break;
						case 8:
							//aModel.CalculatedOutput = "firstquarter90loweast";
							imageView.SetImageResource (Resource.Drawable.firstquarter90loweast);
							break;
						}
					} 
					//else if (elongation == 135) {
					//else if(string.Equals(elongation, "135", StringComparison.OrdinalIgnoreCase)){
					else if(string.Equals(elongation, "135")){
						switch (convertedAppear) {
						case 1:
							//aModel.CalculatedOutput = "waxinggibbous135rising";
							imageView.SetImageResource (Resource.Drawable.waxinggibbous135rising);
							break;
						case 2:
							//aModel.CalculatedOutput = "waxinggibbous135ineast";
							imageView.SetImageResource (Resource.Drawable.waxinggibbous135ineast);
							break;
						case 3:
							//aModel.CalculatedOutput = "waxinggibbous135highsky";
							imageView.SetImageResource (Resource.Drawable.waxinggibbous135highsky);
							break;
						case 4:
							//aModel.CalculatedOutput = "waxinggibbous135inwest";
							imageView.SetImageResource (Resource.Drawable.waxinggibbous135inwest);
							break;
						case 5:
							//aModel.CalculatedOutput = "waxinggibbous135setting";
							imageView.SetImageResource (Resource.Drawable.waxinggibbous135setting);
							break;
						case 6:
							//aModel.CalculatedOutput = "waxinggibbous135lowwest";
							imageView.SetImageResource (Resource.Drawable.waxinggibbous135lowwest);
							break;
						case 7:
							//aModel.CalculatedOutput = "waxinggibbous135lowsky";
							imageView.SetImageResource (Resource.Drawable.waxinggibbous135lowsky);
							break;
						case 8:
							//aModel.CalculatedOutput = "waxinggibbous135loweast";
							imageView.SetImageResource (Resource.Drawable.waxinggibbous135loweast);
							break;
						}
					}
				} 
				else if (Western.Checked) {
					//if (elongation == 45) {
					//if(string.Equals(elongation, "45", StringComparison.OrdinalIgnoreCase)){
					if(string.Equals(elongation, "45")){
						switch (convertedAppear) {
						case 1:
							//aModel.CalculatedOutput = "wanningcrest45rising";
							imageView.SetImageResource (Resource.Drawable.wanningcrest45rising);
							break;
						case 2:
							//aModel.CalculatedOutput = "wanningcrest45ineast";
							imageView.SetImageResource (Resource.Drawable.wanningcrest45ineast);
							break;
						case 3:
							//aModel.CalculatedOutput = "wanningcrest45highsky";
							imageView.SetImageResource (Resource.Drawable.wanningcrest45highsky);
							break;
						case 4:
							//aModel.CalculatedOutput = "wanningcrest45inwest";
							imageView.SetImageResource (Resource.Drawable.wanningcrest45inwest);
							break;
						case 5:
							//aModel.CalculatedOutput = "wanningcrest45setting";
							imageView.SetImageResource (Resource.Drawable.wanningcrest45setting);
							break;
						case 6:
							//aModel.CalculatedOutput = "wanningcrest45lowwest";
							imageView.SetImageResource (Resource.Drawable.wanningcrest45lowwest);
							break;
						case 7:
							//aModel.CalculatedOutput = "wanningcrest45lowsky";
							imageView.SetImageResource (Resource.Drawable.wanningcrest45lowsky);
							break;
						case 8:
							//aModel.CalculatedOutput = "wanningcrest45loweast";
							imageView.SetImageResource (Resource.Drawable.wanningcrest45loweast);
							break;
						}
					} 
					//else if (elongation == 90) {
					//if(string.Equals(elongation, "90", StringComparison.OrdinalIgnoreCase)){
					if(string.Equals(elongation, "90")){
						switch (convertedAppear) {
						case 1:
							//aModel.CalculatedOutput = "thirdquarter90rising";
							imageView.SetImageResource (Resource.Drawable.thirdquarter90rising);
							break;
						case 2:
							//aModel.CalculatedOutput = "thirdquarter90ineast";
							imageView.SetImageResource (Resource.Drawable.thirdquarter90ineast);
							break;
						case 3:
							//aModel.CalculatedOutput = "thirdquarter90highsky";
							imageView.SetImageResource (Resource.Drawable.thirdquarter90highsky);
							break;
						case 4:
							//aModel.CalculatedOutput = "thirdquarter90inwest";
							imageView.SetImageResource (Resource.Drawable.thirdquarter90inwest);
							break;
						case 5:
							//aModel.CalculatedOutput = "thirdquarter90setting";
							imageView.SetImageResource (Resource.Drawable.thirdquarter90setting);
							break;
						case 6:
							//aModel.CalculatedOutput = "thirdquarter90lowwest";
							imageView.SetImageResource (Resource.Drawable.thirdquarter90lowwest);
							break;
						case 7:
							//aModel.CalculatedOutput = "thirdquarter90lowsky";
							imageView.SetImageResource (Resource.Drawable.thirdquarter90lowsky);
							break;
						case 8:
							//aModel.CalculatedOutput = "thirdquarter90loweast";
							imageView.SetImageResource (Resource.Drawable.thirdquarter90loweast);
							break;
						}
					} 
					//else if (elongation == 135) {
					//if(string.Equals(elongation, "135", StringComparison.OrdinalIgnoreCase)){
					if(string.Equals(elongation, "135")){
						switch (convertedAppear) {
						case 1:
							//aModel.CalculatedOutput = "wanninggibbous135rising";
							imageView.SetImageResource (Resource.Drawable.wanninggibbous135rising);
							break;
						case 2:
							//aModel.CalculatedOutput = "wanninggibbous135ineast";
							imageView.SetImageResource (Resource.Drawable.wanninggibbous135ineast);
							break;
						case 3:
							//aModel.CalculatedOutput = "wanninggibbous135highsky";
							imageView.SetImageResource (Resource.Drawable.wanninggibbous135highsky);
							break;
						case 4:
							//aModel.CalculatedOutput = "wanninggibbous135inwest";
							imageView.SetImageResource (Resource.Drawable.wanninggibbous135inwest);
							break;
						case 5:
							//aModel.CalculatedOutput = "wanninggibbous135setting";
							imageView.SetImageResource (Resource.Drawable.wanninggibbous135setting);
							break;
						case 6:
							//aModel.CalculatedOutput = "wanninggibbous135lowwest";
							imageView.SetImageResource (Resource.Drawable.wanninggibbous135lowwest);
							break;
						case 7:
							//aModel.CalculatedOutput = "wanninggibbous135lowsky";
							imageView.SetImageResource (Resource.Drawable.wanninggibbous135lowsky);
							break;
						case 8:
							//aModel.CalculatedOutput = "wanninggibbous135loweast)";
							imageView.SetImageResource (Resource.Drawable.wanninggibbous135loweast);
							break;
						}
					}		
				} 
				else if (NewM.Checked) {
					//if (elongation == 0) {
					//if(string.Equals(elongation, "0", StringComparison.OrdinalIgnoreCase)){
					if(string.Equals(elongation, "0")){
						switch (convertedAppear) {
						case 1:
							//aModel.CalculatedOutput = "newmoon0rising";
							imageView.SetImageResource (Resource.Drawable.newmoon0rising);
							break;
						case 2:
							//aModel.CalculatedOutput = "newmoon0ineast";
							imageView.SetImageResource (Resource.Drawable.newmoon0ineast);
							break;
						case 3:
							//aModel.CalculatedOutput = "newmoon0highsky";
							imageView.SetImageResource (Resource.Drawable.newmoon0highsky);
							break;
						case 4:
							//aModel.CalculatedOutput = "newmoon0inwest";
							imageView.SetImageResource (Resource.Drawable.newmoon0inwest);
							break;
						case 5:
							//aModel.CalculatedOutput = "newmoon0setting";
							imageView.SetImageResource (Resource.Drawable.newmoon0setting);
							break;
						case 6:
							//aModel.CalculatedOutput = "newmoon0lowwest";
							imageView.SetImageResource (Resource.Drawable.newmoon0lowwest);
							break;
						case 7:
							//aModel.CalculatedOutput = "newmoon0lowsky";
							imageView.SetImageResource (Resource.Drawable.newmoon0lowsky);
							break;
						case 8:
							//aModel.CalculatedOutput = "newmoon0loweast";
							imageView.SetImageResource (Resource.Drawable.newmoon0loweast);
							break;
						}
					}
				} 
				else if (FullM.Checked) {
					//if (elongation == 180) {
					//if(string.Equals(elongation, "180", StringComparison.OrdinalIgnoreCase)){
					if(string.Equals(elongation, "180")){
						switch (convertedAppear) {
						case 1:
							//aModel.CalculatedOutput = "fullmoon180rising";
							imageView.SetImageResource (Resource.Drawable.fullmoon180rising);
							break;
						case 2:
							//aModel.CalculatedOutput = "fullmoon180ineast";
							imageView.SetImageResource (Resource.Drawable.waxingcrest45rising);
							break;
						case 3:
							//aModel.CalculatedOutput = "fullmoon180highsky";
							imageView.SetImageResource (Resource.Drawable.fullmoon180highsky);
							break;
						case 4:
							//aModel.CalculatedOutput = "fullmoon180inwest";
							imageView.SetImageResource (Resource.Drawable.fullmoon180inwest);
							break;
						case 5:
							//aModel.CalculatedOutput = "fullmoon180setting";
							imageView.SetImageResource (Resource.Drawable.fullmoon180setting);
							break;
						case 6:
							//aModel.CalculatedOutput = "fullmoon180lowwest";
							imageView.SetImageResource (Resource.Drawable.fullmoon180lowwest);
							break;
						case 7:
							//aModel.CalculatedOutput = "fullmoon180lowsky";
							imageView.SetImageResource (Resource.Drawable.waxingcrest45rising);
							break;
						case 8:
							//aModel.CalculatedOutput = "fullmoon180loweast";
							imageView.SetImageResource (Resource.Drawable.fullmoon180loweast);
							break;
						}
					}
				}
				};

	

		}
	}
}

