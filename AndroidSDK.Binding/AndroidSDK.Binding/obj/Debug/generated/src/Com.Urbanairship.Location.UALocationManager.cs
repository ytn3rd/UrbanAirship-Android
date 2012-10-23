using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Urbanairship.Location {

	[global::Android.Runtime.Register ("com/urbanairship/location/UALocationManager", DoNotGenerateAcw=true)]
	public partial class UALocationManager : global::Java.Lang.Object {


		static IntPtr ACTION_LOCATION_SERVICE_BOUND_jfieldId;

		[Register ("ACTION_LOCATION_SERVICE_BOUND")]
		public static string ActionLocationServiceBound {
			get {
				if (ACTION_LOCATION_SERVICE_BOUND_jfieldId == IntPtr.Zero)
					ACTION_LOCATION_SERVICE_BOUND_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ACTION_LOCATION_SERVICE_BOUND", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ACTION_LOCATION_SERVICE_BOUND_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (ACTION_LOCATION_SERVICE_BOUND_jfieldId == IntPtr.Zero)
					ACTION_LOCATION_SERVICE_BOUND_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ACTION_LOCATION_SERVICE_BOUND", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				JNIEnv.SetStaticField (class_ref, ACTION_LOCATION_SERVICE_BOUND_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr ACTION_LOCATION_SERVICE_UNBOUND_jfieldId;

		[Register ("ACTION_LOCATION_SERVICE_UNBOUND")]
		public static string ActionLocationServiceUnbound {
			get {
				if (ACTION_LOCATION_SERVICE_UNBOUND_jfieldId == IntPtr.Zero)
					ACTION_LOCATION_SERVICE_UNBOUND_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ACTION_LOCATION_SERVICE_UNBOUND", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ACTION_LOCATION_SERVICE_UNBOUND_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (ACTION_LOCATION_SERVICE_UNBOUND_jfieldId == IntPtr.Zero)
					ACTION_LOCATION_SERVICE_UNBOUND_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ACTION_LOCATION_SERVICE_UNBOUND", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				JNIEnv.SetStaticField (class_ref, ACTION_LOCATION_SERVICE_UNBOUND_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr ACTION_LOCATION_UPDATE_jfieldId;

		[Register ("ACTION_LOCATION_UPDATE")]
		public static string ActionLocationUpdate {
			get {
				if (ACTION_LOCATION_UPDATE_jfieldId == IntPtr.Zero)
					ACTION_LOCATION_UPDATE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ACTION_LOCATION_UPDATE", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ACTION_LOCATION_UPDATE_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (ACTION_LOCATION_UPDATE_jfieldId == IntPtr.Zero)
					ACTION_LOCATION_UPDATE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ACTION_LOCATION_UPDATE", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				JNIEnv.SetStaticField (class_ref, ACTION_LOCATION_UPDATE_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		[Register ("LOCATION_KEY")]
		public const string LocationKey = (string) "com.urbanairship.location.LOCATION";
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/urbanairship/location/UALocationManager", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (UALocationManager); }
		}

		protected UALocationManager (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_getBestProvider;
#pragma warning disable 0169
		static Delegate GetGetBestProviderHandler ()
		{
			if (cb_getBestProvider == null)
				cb_getBestProvider = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetBestProvider);
			return cb_getBestProvider;
		}

		static IntPtr n_GetBestProvider (IntPtr jnienv, IntPtr native__this)
		{
			UALocationManager __this = Java.Lang.Object.GetObject<UALocationManager> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.BestProvider);
		}
#pragma warning restore 0169

		static IntPtr id_getBestProvider;
		public virtual string BestProvider {
			[Register ("getBestProvider", "()Ljava/lang/String;", "GetGetBestProviderHandler")]
			get {
				if (id_getBestProvider == IntPtr.Zero)
					id_getBestProvider = JNIEnv.GetMethodID (class_ref, "getBestProvider", "()Ljava/lang/String;");

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getBestProvider), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getBestProvider), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getCriteria;
#pragma warning disable 0169
		static Delegate GetGetCriteriaHandler ()
		{
			if (cb_getCriteria == null)
				cb_getCriteria = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCriteria);
			return cb_getCriteria;
		}

		static IntPtr n_GetCriteria (IntPtr jnienv, IntPtr native__this)
		{
			UALocationManager __this = Java.Lang.Object.GetObject<UALocationManager> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Criteria);
		}
#pragma warning restore 0169

		static IntPtr id_getCriteria;
		public virtual global::Android.Locations.Criteria Criteria {
			[Register ("getCriteria", "()Landroid/location/Criteria;", "GetGetCriteriaHandler")]
			get {
				if (id_getCriteria == IntPtr.Zero)
					id_getCriteria = JNIEnv.GetMethodID (class_ref, "getCriteria", "()Landroid/location/Criteria;");

				if (GetType () == ThresholdType)
					return Java.Lang.Object.GetObject<global::Android.Locations.Criteria> (JNIEnv.CallObjectMethod  (Handle, id_getCriteria), JniHandleOwnership.TransferLocalRef);
				else
					return Java.Lang.Object.GetObject<global::Android.Locations.Criteria> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getCriteria), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getCurrentProvider;
#pragma warning disable 0169
		static Delegate GetGetCurrentProviderHandler ()
		{
			if (cb_getCurrentProvider == null)
				cb_getCurrentProvider = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCurrentProvider);
			return cb_getCurrentProvider;
		}

		static IntPtr n_GetCurrentProvider (IntPtr jnienv, IntPtr native__this)
		{
			UALocationManager __this = Java.Lang.Object.GetObject<UALocationManager> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.CurrentProvider);
		}
#pragma warning restore 0169

		static IntPtr id_getCurrentProvider;
		public virtual string CurrentProvider {
			[Register ("getCurrentProvider", "()Ljava/lang/String;", "GetGetCurrentProviderHandler")]
			get {
				if (id_getCurrentProvider == IntPtr.Zero)
					id_getCurrentProvider = JNIEnv.GetMethodID (class_ref, "getCurrentProvider", "()Ljava/lang/String;");

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getCurrentProvider), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getCurrentProvider), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_isServiceBound;
		public static bool IsServiceBound {
			[Register ("isServiceBound", "()Z", "GetIsServiceBoundHandler")]
			get {
				if (id_isServiceBound == IntPtr.Zero)
					id_isServiceBound = JNIEnv.GetStaticMethodID (class_ref, "isServiceBound", "()Z");
				return JNIEnv.CallStaticBooleanMethod  (class_ref, id_isServiceBound);
			}
		}

		static Delegate cb_getLocation;
#pragma warning disable 0169
		static Delegate GetGetLocationHandler ()
		{
			if (cb_getLocation == null)
				cb_getLocation = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetLocation);
			return cb_getLocation;
		}

		static IntPtr n_GetLocation (IntPtr jnienv, IntPtr native__this)
		{
			UALocationManager __this = Java.Lang.Object.GetObject<UALocationManager> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Location);
		}
#pragma warning restore 0169

		static IntPtr id_getLocation;
		public virtual global::Android.Locations.Location Location {
			[Register ("getLocation", "()Landroid/location/Location;", "GetGetLocationHandler")]
			get {
				if (id_getLocation == IntPtr.Zero)
					id_getLocation = JNIEnv.GetMethodID (class_ref, "getLocation", "()Landroid/location/Location;");

				if (GetType () == ThresholdType)
					return Java.Lang.Object.GetObject<global::Android.Locations.Location> (JNIEnv.CallObjectMethod  (Handle, id_getLocation), JniHandleOwnership.TransferLocalRef);
				else
					return Java.Lang.Object.GetObject<global::Android.Locations.Location> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getLocation), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getPreferences;
#pragma warning disable 0169
		static Delegate GetGetPreferencesHandler ()
		{
			if (cb_getPreferences == null)
				cb_getPreferences = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPreferences);
			return cb_getPreferences;
		}

		static IntPtr n_GetPreferences (IntPtr jnienv, IntPtr native__this)
		{
			UALocationManager __this = Java.Lang.Object.GetObject<UALocationManager> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Preferences);
		}
#pragma warning restore 0169

		static IntPtr id_getPreferences;
		public virtual global::Com.Urbanairship.Location.LocationPreferences Preferences {
			[Register ("getPreferences", "()Lcom/urbanairship/location/LocationPreferences;", "GetGetPreferencesHandler")]
			get {
				if (id_getPreferences == IntPtr.Zero)
					id_getPreferences = JNIEnv.GetMethodID (class_ref, "getPreferences", "()Lcom/urbanairship/location/LocationPreferences;");

				if (GetType () == ThresholdType)
					return Java.Lang.Object.GetObject<global::Com.Urbanairship.Location.LocationPreferences> (JNIEnv.CallObjectMethod  (Handle, id_getPreferences), JniHandleOwnership.TransferLocalRef);
				else
					return Java.Lang.Object.GetObject<global::Com.Urbanairship.Location.LocationPreferences> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getPreferences), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_bindService;
		[Register ("bindService", "()V", "")]
		public static void BindService ()
		{
			if (id_bindService == IntPtr.Zero)
				id_bindService = JNIEnv.GetStaticMethodID (class_ref, "bindService", "()V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_bindService);
		}

		static IntPtr id_disableBackgroundLocation;
		[Register ("disableBackgroundLocation", "()V", "")]
		public static void DisableBackgroundLocation ()
		{
			if (id_disableBackgroundLocation == IntPtr.Zero)
				id_disableBackgroundLocation = JNIEnv.GetStaticMethodID (class_ref, "disableBackgroundLocation", "()V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_disableBackgroundLocation);
		}

		static IntPtr id_disableLocation;
		[Register ("disableLocation", "()V", "")]
		public static void DisableLocation ()
		{
			if (id_disableLocation == IntPtr.Zero)
				id_disableLocation = JNIEnv.GetStaticMethodID (class_ref, "disableLocation", "()V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_disableLocation);
		}

		static IntPtr id_enableBackgroundLocation;
		[Register ("enableBackgroundLocation", "()V", "")]
		public static void EnableBackgroundLocation ()
		{
			if (id_enableBackgroundLocation == IntPtr.Zero)
				id_enableBackgroundLocation = JNIEnv.GetStaticMethodID (class_ref, "enableBackgroundLocation", "()V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_enableBackgroundLocation);
		}

		static IntPtr id_enableLocation;
		[Register ("enableLocation", "()V", "")]
		public static void EnableLocation ()
		{
			if (id_enableLocation == IntPtr.Zero)
				id_enableLocation = JNIEnv.GetStaticMethodID (class_ref, "enableLocation", "()V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_enableLocation);
		}

		static IntPtr id_init;
		[Register ("init", "()V", "")]
		public static void Init ()
		{
			if (id_init == IntPtr.Zero)
				id_init = JNIEnv.GetStaticMethodID (class_ref, "init", "()V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_init);
		}

		static Delegate cb_recordCurrentLocation;
#pragma warning disable 0169
		static Delegate GetRecordCurrentLocationHandler ()
		{
			if (cb_recordCurrentLocation == null)
				cb_recordCurrentLocation = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_RecordCurrentLocation);
			return cb_recordCurrentLocation;
		}

		static void n_RecordCurrentLocation (IntPtr jnienv, IntPtr native__this)
		{
			UALocationManager __this = Java.Lang.Object.GetObject<UALocationManager> (native__this, JniHandleOwnership.DoNotTransfer);
			__this.RecordCurrentLocation ();
		}
#pragma warning restore 0169

		static IntPtr id_recordCurrentLocation;
		[Register ("recordCurrentLocation", "()V", "GetRecordCurrentLocationHandler")]
		public virtual void RecordCurrentLocation ()
		{
			if (id_recordCurrentLocation == IntPtr.Zero)
				id_recordCurrentLocation = JNIEnv.GetMethodID (class_ref, "recordCurrentLocation", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_recordCurrentLocation);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_recordCurrentLocation);
		}

		static Delegate cb_recordCurrentLocation_Landroid_location_Criteria_;
#pragma warning disable 0169
		static Delegate GetRecordCurrentLocation_Landroid_location_Criteria_Handler ()
		{
			if (cb_recordCurrentLocation_Landroid_location_Criteria_ == null)
				cb_recordCurrentLocation_Landroid_location_Criteria_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_RecordCurrentLocation_Landroid_location_Criteria_);
			return cb_recordCurrentLocation_Landroid_location_Criteria_;
		}

		static void n_RecordCurrentLocation_Landroid_location_Criteria_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			UALocationManager __this = Java.Lang.Object.GetObject<UALocationManager> (native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Locations.Criteria p0 = Java.Lang.Object.GetObject<global::Android.Locations.Criteria> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RecordCurrentLocation (p0);
		}
#pragma warning restore 0169

		static IntPtr id_recordCurrentLocation_Landroid_location_Criteria_;
		[Register ("recordCurrentLocation", "(Landroid/location/Criteria;)V", "GetRecordCurrentLocation_Landroid_location_Criteria_Handler")]
		public virtual void RecordCurrentLocation (global::Android.Locations.Criteria p0)
		{
			if (id_recordCurrentLocation_Landroid_location_Criteria_ == IntPtr.Zero)
				id_recordCurrentLocation_Landroid_location_Criteria_ = JNIEnv.GetMethodID (class_ref, "recordCurrentLocation", "(Landroid/location/Criteria;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_recordCurrentLocation_Landroid_location_Criteria_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_recordCurrentLocation_Landroid_location_Criteria_, new JValue (p0));
		}

		static Delegate cb_recordLocation_Landroid_location_Location_;
#pragma warning disable 0169
		static Delegate GetRecordLocation_Landroid_location_Location_Handler ()
		{
			if (cb_recordLocation_Landroid_location_Location_ == null)
				cb_recordLocation_Landroid_location_Location_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_RecordLocation_Landroid_location_Location_);
			return cb_recordLocation_Landroid_location_Location_;
		}

		static void n_RecordLocation_Landroid_location_Location_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			UALocationManager __this = Java.Lang.Object.GetObject<UALocationManager> (native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Locations.Location p0 = Java.Lang.Object.GetObject<global::Android.Locations.Location> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RecordLocation (p0);
		}
#pragma warning restore 0169

		static IntPtr id_recordLocation_Landroid_location_Location_;
		[Register ("recordLocation", "(Landroid/location/Location;)V", "GetRecordLocation_Landroid_location_Location_Handler")]
		public virtual void RecordLocation (global::Android.Locations.Location p0)
		{
			if (id_recordLocation_Landroid_location_Location_ == IntPtr.Zero)
				id_recordLocation_Landroid_location_Location_ = JNIEnv.GetMethodID (class_ref, "recordLocation", "(Landroid/location/Location;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_recordLocation_Landroid_location_Location_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_recordLocation_Landroid_location_Location_, new JValue (p0));
		}

		static Delegate cb_recordLocation_Landroid_location_Location_II;
#pragma warning disable 0169
		static Delegate GetRecordLocation_Landroid_location_Location_IIHandler ()
		{
			if (cb_recordLocation_Landroid_location_Location_II == null)
				cb_recordLocation_Landroid_location_Location_II = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int, int>) n_RecordLocation_Landroid_location_Location_II);
			return cb_recordLocation_Landroid_location_Location_II;
		}

		static void n_RecordLocation_Landroid_location_Location_II (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, int p2)
		{
			UALocationManager __this = Java.Lang.Object.GetObject<UALocationManager> (native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Locations.Location p0 = Java.Lang.Object.GetObject<global::Android.Locations.Location> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RecordLocation (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_recordLocation_Landroid_location_Location_II;
		[Register ("recordLocation", "(Landroid/location/Location;II)V", "GetRecordLocation_Landroid_location_Location_IIHandler")]
		public virtual void RecordLocation (global::Android.Locations.Location p0, int p1, int p2)
		{
			if (id_recordLocation_Landroid_location_Location_II == IntPtr.Zero)
				id_recordLocation_Landroid_location_Location_II = JNIEnv.GetMethodID (class_ref, "recordLocation", "(Landroid/location/Location;II)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_recordLocation_Landroid_location_Location_II, new JValue (p0), new JValue (p1), new JValue (p2));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_recordLocation_Landroid_location_Location_II, new JValue (p0), new JValue (p1), new JValue (p2));
		}

		static Delegate cb_resetProviders_Landroid_location_Criteria_;
#pragma warning disable 0169
		static Delegate GetResetProviders_Landroid_location_Criteria_Handler ()
		{
			if (cb_resetProviders_Landroid_location_Criteria_ == null)
				cb_resetProviders_Landroid_location_Criteria_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_ResetProviders_Landroid_location_Criteria_);
			return cb_resetProviders_Landroid_location_Criteria_;
		}

		static void n_ResetProviders_Landroid_location_Criteria_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			UALocationManager __this = Java.Lang.Object.GetObject<UALocationManager> (native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Locations.Criteria p0 = Java.Lang.Object.GetObject<global::Android.Locations.Criteria> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ResetProviders (p0);
		}
#pragma warning restore 0169

		static IntPtr id_resetProviders_Landroid_location_Criteria_;
		[Register ("resetProviders", "(Landroid/location/Criteria;)V", "GetResetProviders_Landroid_location_Criteria_Handler")]
		public virtual void ResetProviders (global::Android.Locations.Criteria p0)
		{
			if (id_resetProviders_Landroid_location_Criteria_ == IntPtr.Zero)
				id_resetProviders_Landroid_location_Criteria_ = JNIEnv.GetMethodID (class_ref, "resetProviders", "(Landroid/location/Criteria;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_resetProviders_Landroid_location_Criteria_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_resetProviders_Landroid_location_Criteria_, new JValue (p0));
		}

		static IntPtr id_shared;
		[Register ("shared", "()Lcom/urbanairship/location/UALocationManager;", "")]
		public static global::Com.Urbanairship.Location.UALocationManager Shared ()
		{
			if (id_shared == IntPtr.Zero)
				id_shared = JNIEnv.GetStaticMethodID (class_ref, "shared", "()Lcom/urbanairship/location/UALocationManager;");
			return Java.Lang.Object.GetObject<global::Com.Urbanairship.Location.UALocationManager> (JNIEnv.CallStaticObjectMethod  (class_ref, id_shared), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_unbindService;
		[Register ("unbindService", "()V", "")]
		public static void UnbindService ()
		{
			if (id_unbindService == IntPtr.Zero)
				id_unbindService = JNIEnv.GetStaticMethodID (class_ref, "unbindService", "()V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_unbindService);
		}

	}
}
