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
			Button testBtn = FindViewById<Button> (Resource.Id.Test);
			//NumberPicker elongation = FindViewById<NumberPicker> (Resource.Id.numberPickerElong);
		exitBtn.Click += delegate {
			System.Environment.Exit(0);
		};		
			testBtn.Click += delegate {
				StartActivity(typeof(TheResults));
			};		
		resultsBtn.Click += delegate {
				String[] values=new String[12];
				/*for(int i=0;i<values.Length;i++){
					values[i]Int32.ToString(i*15);
				}
				*/

				for(int i=0;i<values.Length;i++){
					values[i] = values[i*15].ToString();
				}

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
							//imageOutput.setImageResource (R.drawable.waxingcrest45rising);
							aModel.CalculatedOutput = "waxingcrest45rising";
							break;
						case 2:
							//imageOutput.setImageResource (R.drawable.waxingcrest45ineast);
							aModel.CalculatedOutput = "waxingcrest45ineast";
							break;
						case 3:
							//imageOutput.setImageResource (R.drawable.waxingcrest45highsky);
							aModel.CalculatedOutput = "waxingcrest45highsky";
							break;
						case 4:
							//imageOutput.setImageResource (R.drawable.waxingcrest45inwest);
							aModel.CalculatedOutput = "waxingcrest45inwest";
							break;
						case 5:
							//imageOutput.setImageResource (R.drawable.waxingcrest45setting);
							aModel.CalculatedOutput = "waxingcrest45setting";
							break;
						case 6:
							//imageOutput.setImageResource (R.drawable.waxingcrest45lowwest);
							aModel.CalculatedOutput = "waxingcrest45lowwest";
							break;
						case 7:
							//imageOutput.setImageResource (R.drawable.waxingcrest45lowsky);
							aModel.CalculatedOutput = "waxingcrest45lowsky";
							break;
						case 8:
							//imageOutput.setImageResource (R.drawable.waxingcrest45loweast);
							aModel.CalculatedOutput = "waxingcrest45loweast";
							break;
						}
					}
					//else if (elongation == 90) {
					//else if(string.Equals(elongation, "90", StringComparison.OrdinalIgnoreCase)){
					else if(string.Equals(elongation, "90")){
						switch (convertedAppear) {
						case 1:
							//imageOutput.setImageResource (R.drawable.firstquarter90rising);
							aModel.CalculatedOutput = "waxingcrest45rising";
							break;
						case 2:
							//imageOutput.setImageResource (R.drawable.firstquarter90ineast);
							aModel.CalculatedOutput = "waxingcrest45rising";
							break;
						case 3:
							//imageOutput.setImageResource (R.drawable.firstquarter90highsky);
							aModel.CalculatedOutput = "waxingcrest45rising";
							break;
						case 4:
							//imageOutput.setImageResource (R.drawable.firstquarter90inwest);
							aModel.CalculatedOutput = "waxingcrest45rising";
							break;
						case 5:
							//imageOutput.setImageResource (R.drawable.firstquarter90setting);
							aModel.CalculatedOutput = "waxingcrest45rising";
							break;
						case 6:
							//imageOutput.setImageResource (R.drawable.firstquarter90lowwest);
							aModel.CalculatedOutput = "waxingcrest45rising";
							break;
						case 7:
							//imageOutput.setImageResource (R.drawable.firstquarter90lowsky);
							aModel.CalculatedOutput = "waxingcrest45rising";
							break;
						case 8:
							//imageOutput.setImageResource (R.drawable.firstquarter90loweast);
							aModel.CalculatedOutput = "waxingcrest45rising";
							break;
						}
					} 
					//else if (elongation == 135) {
					//else if(string.Equals(elongation, "135", StringComparison.OrdinalIgnoreCase)){
					else if(string.Equals(elongation, "135")){
						switch (convertedAppear) {
						case 1:
							//imageOutput.setImageResource (R.drawable.waxinggibbous135rising);
							aModel.CalculatedOutput = "waxingcrest45rising";
							break;
						case 2:
							//imageOutput.setImageResource (R.drawable.waxinggibbous135ineast);
							aModel.CalculatedOutput = "waxingcrest45rising";
							break;
						case 3:
							//imageOutput.setImageResource (R.drawable.waxinggibbous135highsky);
							aModel.CalculatedOutput = "waxingcrest45rising";
							break;
						case 4:
							//imageOutput.setImageResource (R.drawable.waxinggibbous135inwest);
							aModel.CalculatedOutput = "waxingcrest45rising";
							break;
						case 5:
							//imageOutput.setImageResource (R.drawable.waxinggibbous135setting);
							aModel.CalculatedOutput = "waxingcrest45rising";
							break;
						case 6:
							//imageOutput.setImageResource (R.drawable.waxinggibbous135lowwest);
							aModel.CalculatedOutput = "waxingcrest45rising";
							break;
						case 7:
							//imageOutput.setImageResource (R.drawable.waxinggibbous135lowsky);
							aModel.CalculatedOutput = "waxingcrest45rising";
							break;
						case 8:
							//imageOutput.setImageResource (R.drawable.waxinggibbous135loweast);
							aModel.CalculatedOutput = "waxingcrest45rising";
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
							//imageOutput.setImageResource (R.drawable.wanningcrest45rising);
							aModel.CalculatedOutput = "waxingcrest45rising";
							break;
						case 2:
							//imageOutput.setImageResource (R.drawable.wanningcrest45ineast);
							aModel.CalculatedOutput = "waxingcrest45rising";
							break;
						case 3:
							//imageOutput.setImageResource (R.drawable.wanningcrest45highsky);
							aModel.CalculatedOutput = "waxingcrest45rising";
							break;
						case 4:
							//imageOutput.setImageResource (R.drawable.wanningcrest45inwest);
							aModel.CalculatedOutput = "waxingcrest45rising";
							break;
						case 5:
							//imageOutput.setImageResource (R.drawable.wanningcrest45setting);
							aModel.CalculatedOutput = "waxingcrest45rising";
							break;
						case 6:
							//imageOutput.setImageResource (R.drawable.wanningcrest45lowwest);
							aModel.CalculatedOutput = "waxingcrest45rising";
							break;
						case 7:
							//imageOutput.setImageResource (R.drawable.wanningcrest45lowsky);
							aModel.CalculatedOutput = "waxingcrest45rising";
							break;
						case 8:
							//imageOutput.setImageResource (R.drawable.wanningcrest45loweast);
							aModel.CalculatedOutput = "waxingcrest45rising";
							break;
						}
					} 
					//else if (elongation == 90) {
					//if(string.Equals(elongation, "90", StringComparison.OrdinalIgnoreCase)){
					if(string.Equals(elongation, "90")){
						switch (convertedAppear) {
						case 1:
							//imageOutput.setImageResource (R.drawable.thirdquarter90rising);
							aModel.CalculatedOutput = "waxingcrest45rising";
							break;
						case 2:
							//imageOutput.setImageResource (R.drawable.thirdquarter90ineast);
							aModel.CalculatedOutput = "waxingcrest45rising";
							break;
						case 3:
							//imageOutput.setImageResource (R.drawable.thirdquarter90highsky);
							aModel.CalculatedOutput = "waxingcrest45rising";
							break;
						case 4:
							//imageOutput.setImageResource (R.drawable.thirdquarter90inwest);
							aModel.CalculatedOutput = "waxingcrest45rising";
							break;
						case 5:
							//imageOutput.setImageResource (R.drawable.thirdquarter90setting);
							aModel.CalculatedOutput = "waxingcrest45rising";
							break;
						case 6:
							//imageOutput.setImageResource (R.drawable.thirdquarter90lowwest);
							aModel.CalculatedOutput = "waxingcrest45rising";
							break;
						case 7:
							//imageOutput.setImageResource (R.drawable.thirdquarter90lowsky);
							aModel.CalculatedOutput = "waxingcrest45rising";
							break;
						case 8:
							//imageOutput.setImageResource (R.drawable.thirdquarter90loweast);
							aModel.CalculatedOutput = "waxingcrest45rising";
							break;
						}
					} 
					//else if (elongation == 135) {
					//if(string.Equals(elongation, "135", StringComparison.OrdinalIgnoreCase)){
					if(string.Equals(elongation, "135")){
						switch (convertedAppear) {
						case 1:
							//imageOutput.setImageResource (R.drawable.wanninggibbous135rising);
							aModel.CalculatedOutput = "waxingcrest45rising";
							break;
						case 2:
							//imageOutput.setImageResource (R.drawable.wanninggibbous135ineast);
							aModel.CalculatedOutput = "waxingcrest45rising";
							break;
						case 3:
							//imageOutput.setImageResource (R.drawable.wanninggibbous135highsky);
							aModel.CalculatedOutput = "waxingcrest45rising";
							break;
						case 4:
							//imageOutput.setImageResource (R.drawable.wanninggibbous135inwest);
							aModel.CalculatedOutput = "waxingcrest45rising";
							break;
						case 5:
							//imageOutput.setImageResource (R.drawable.wanninggibbous135setting);
							aModel.CalculatedOutput = "waxingcrest45rising";
							break;
						case 6:
							//imageOutput.setImageResource (R.drawable.wanninggibbous135lowwest);
							aModel.CalculatedOutput = "waxingcrest45rising";
							break;
						case 7:
							//imageOutput.setImageResource (R.drawable.wanninggibbous135lowsky);
							aModel.CalculatedOutput = "waxingcrest45rising";
							break;
						case 8:
							//imageOutput.setImageResource (R.drawable.wanninggibbous135loweast);
							aModel.CalculatedOutput = "waxingcrest45rising";
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
							//imageOutput.setImageResource (R.drawable.newmoon0rising);
							//aModel.CalculatedOutput = "waxingcrest45rising";
							//aModel.CalculatedOutput(Resources.GetDrawable(1));
							aModel.CalculatedOutput = "waxingcrest45rising";
							break;
						case 2:
							//imageOutput.setImageResource (R.drawable.newmoon0ineast);
							aModel.CalculatedOutput = "waxingcrest45rising";
							break;
						case 3:
							//imageOutput.setImageResource (R.drawable.newmoon0highsky);
							aModel.CalculatedOutput = "waxingcrest45rising";
							break;
						case 4:
							//imageOutput.setImageResource (R.drawable.newmoon0inwest);
							aModel.CalculatedOutput = "waxingcrest45rising";
							break;
						case 5:
							//imageOutput.setImageResource (R.drawable.newmoon0setting);
							aModel.CalculatedOutput = "waxingcrest45rising";
							break;
						case 6:
							//imageOutput.setImageResource (R.drawable.newmoon0lowwest);
							aModel.CalculatedOutput = "waxingcrest45rising";
							break;
						case 7:
							//imageOutput.setImageResource (R.drawable.newmoon0lowsky);
							aModel.CalculatedOutput = "waxingcrest45rising";
							break;
						case 8:
							//imageOutput.setImageResource (R.drawable.newmoon0loweast);
							aModel.CalculatedOutput = "waxingcrest45rising";
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
							//imageOutput.setImageResource (R.drawable.fullmoon180rising);
							aModel.CalculatedOutput = "waxingcrest45rising";
							break;
						case 2:
							//imageOutput.setImageResource (R.drawable.fullmoon180ineast);
							aModel.CalculatedOutput = "waxingcrest45rising";
							break;
						case 3:
							//imageOutput.setImageResource (R.drawable.fullmoon180highsky);
							aModel.CalculatedOutput = "waxingcrest45rising";
							break;
						case 4:
							//imageOutput.setImageResource (R.drawable.fullmoon180inwest);
							aModel.CalculatedOutput = "waxingcrest45rising";
							break;
						case 5:
							//imageOutput.setImageResource (R.drawable.fullmoon180setting);
							aModel.CalculatedOutput = "waxingcrest45rising";
							break;
						case 6:
							//imageOutput.setImageResource (R.drawable.fullmoon180lowwest);
							aModel.CalculatedOutput = "waxingcrest45rising";
							break;
						case 7:
							//imageOutput.setImageResource (R.drawable.fullmoon180lowsky);
							aModel.CalculatedOutput = "waxingcrest45rising";
							break;
						case 8:
							//imageOutput.setImageResource (R.drawable.fullmoon180loweast);
							aModel.CalculatedOutput = "waxingcrest45rising";
							break;
						}
					}
				}
				StartActivity(typeof(TheResults));
				};

	

		}
	}
}

