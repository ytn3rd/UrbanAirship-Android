using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Com.Urbanairship.Push;
using Com.Urbanairship;


namespace UrbanAirshipSample
{
  
	[Activity (Label = "UrbanAirship-Sample", MainLauncher = true)]
	public class Activity1 : Activity
	{
		int count = 1;

		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.Main);

			// Get our button from the layout resource,
			// and attach an event to it
			Button button = FindViewById<Button> (Resource.Id.myButton);
			
			button.Click += delegate {
				button.Text = string.Format ("{0} clicks!", count++);
			};


            // Begin UA stuff.
            AirshipConfigOptions options = new AirshipConfigOptions();
            options.GcmSender = "<PUT GCM SENDER ID HERE>";
            //options.PushServiceEnabled = true;
            //options.DevelopmentAppKey = "";
            //options.DevelopmentAppSecret = "";
            options.ProductionAppKey = "<PUT KEY HERE>";
            options.ProductionAppSecret = "<PUT SECRET HERE>";
            options.InProduction = true; //determines which app key to use


            UAirship.TakeOff(this.Application, options);

            PushManager.Shared().IntentReceiver = new IntentReceiver().Class;


            PushPreferences prefs = PushManager.Shared().Preferences;
            prefs.SoundEnabled = true;      // enable/disable sound when a push is received
            prefs.VibrateEnabled = true;    // enable/disable vibrate on receive


            BasicPushNotificationBuilder nb = new BasicPushNotificationBuilder();
            nb.IconDrawableId = Resource.Drawable.Icon;
            //nb.ConstantNotificationId = 0;
            PushManager.Shared().NotificationBuilder = nb;

            // Not 100% sure, but this may not need to be called on every launch.
            PushManager.EnablePush();
		}
	}
}


