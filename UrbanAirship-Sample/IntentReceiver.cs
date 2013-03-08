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

using Com.Urbanairship;
using Com.Urbanairship.Push;

namespace UrbanAirshipSample
{

    [BroadcastReceiver]
    public class IntentReceiver : BroadcastReceiver
    {
        private static String logTag = "PushSample: ";

        public override void OnReceive(Context context, Intent intent)
        {
            Console.WriteLine("PushSample: " + intent.ToString());
            string action = intent.Action;

            if (action == PushManager.ActionPushReceived)
            {
                int id = intent.GetIntExtra(PushManager.ExtraNotificationId, 0);

                Console.WriteLine(logTag + "Received push notification. Alert: " + intent.GetStringExtra(PushManager.ExtraAlert) + " [NotificationID=" + id + "]");

                LogPushExtras(intent);
            }
            else if (action == PushManager.ActionNotificationOpened)
            {

                Console.WriteLine(logTag + "User clicked notification. Message: " + intent.GetStringExtra(PushManager.ExtraAlert));

                LogPushExtras(intent);

                Intent launch = new Intent(Intent.ActionMain);
                // Repleace MainActivity with what you want your app to launchw when the user tapps teh activity.
                launch.SetClass(UAirship.Shared().ApplicationContext, typeof(Activity1));
                launch.SetFlags(ActivityFlags.NewTask);

                UAirship.Shared().ApplicationContext.StartActivity(launch);
            }
            else if (action == PushManager.ActionRegistrationFinished)
            {
                Console.WriteLine(logTag + "Registration complete. APID:" + intent.GetStringExtra(PushManager.ExtraApid) + ". Valid: " + intent.GetBooleanExtra(PushManager.ExtraRegistrationValid, false));
            }
        }




        private void LogPushExtras(Intent intent)
        {
            ICollection<string> keys = intent.Extras.KeySet();
            List<string> ignoredKeys = new List<string>() {
				"collapse_key",						//GCM collapse key
				"from",								//GCM sender
				PushManager.ExtraNotificationId,	//int id of generated notification (ACTION_PUSH_RECEIVED only)
				PushManager.ExtraPushId,			//internal UA push id
				PushManager.ExtraAlert				//ignore alert
			};

            foreach (string key in keys)
            {
                if (ignoredKeys.Contains(key))
                {
                    continue;
                }
                Console.WriteLine(logTag + "Push Notification Extra: [" + key + " : " + intent.GetStringExtra(key) + "]");
            }
        }
    }
}