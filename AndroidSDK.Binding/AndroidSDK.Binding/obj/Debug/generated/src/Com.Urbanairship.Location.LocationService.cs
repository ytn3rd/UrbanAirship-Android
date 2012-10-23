using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Urbanairship.Location {

	[global::Android.Runtime.Register ("com/urbanairship/location/LocationService", DoNotGenerateAcw=true)]
	public partial class LocationService : global::Android.App.Service {


		[Register ("ACTION_START")]
		public const string ActionStart = (string) "com.urbanairship.location.START";

		[Register ("ACTION_STOP")]
		public const string ActionStop = (string) "com.urbanairship.location.STOP";

		static IntPtr LOCATION_CHANGED_jfieldId;

		[Register ("LOCATION_CHANGED")]
		public static string LocationChanged {
			get {
				if (LOCATION_CHANGED_jfieldId == IntPtr.Zero)
					LOCATION_CHANGED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "LOCATION_CHANGED", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, LOCATION_CHANGED_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (LOCATION_CHANGED_jfieldId == IntPtr.Zero)
					LOCATION_CHANGED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "LOCATION_CHANGED", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				JNIEnv.SetStaticField (class_ref, LOCATION_CHANGED_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		[Register ("REQUESTED_ACCURACY_KEY")]
		public const string RequestedAccuracyKey = (string) "com.urbanairship.location.REQUESTED_ACCURACY";

		static IntPtr SINGLE_LOCATION_CHANGED_jfieldId;

		[Register ("SINGLE_LOCATION_CHANGED")]
		public static string SingleLocationChanged {
			get {
				if (SINGLE_LOCATION_CHANGED_jfieldId == IntPtr.Zero)
					SINGLE_LOCATION_CHANGED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SINGLE_LOCATION_CHANGED", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SINGLE_LOCATION_CHANGED_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (SINGLE_LOCATION_CHANGED_jfieldId == IntPtr.Zero)
					SINGLE_LOCATION_CHANGED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SINGLE_LOCATION_CHANGED", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				JNIEnv.SetStaticField (class_ref, SINGLE_LOCATION_CHANGED_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}
		[global::Android.Runtime.Register ("com/urbanairship/location/LocationService$ProviderListener", DoNotGenerateAcw=true)]
		public partial class ProviderListener : global::Java.Lang.Object, global::Android.Locations.ILocationListener {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/urbanairship/location/LocationService$ProviderListener", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (ProviderListener); }
			}

			protected ProviderListener (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static Delegate cb_onLocationChanged_Landroid_location_Location_;
#pragma warning disable 0169
			static Delegate GetOnLocationChanged_Landroid_location_Location_Handler ()
			{
				if (cb_onLocationChanged_Landroid_location_Location_ == null)
					cb_onLocationChanged_Landroid_location_Location_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnLocationChanged_Landroid_location_Location_);
				return cb_onLocationChanged_Landroid_location_Location_;
			}

			static void n_OnLocationChanged_Landroid_location_Location_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				ProviderListener __this = Java.Lang.Object.GetObject<ProviderListener> (native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Locations.Location p0 = Java.Lang.Object.GetObject<global::Android.Locations.Location> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnLocationChanged (p0);
			}
#pragma warning restore 0169

			static IntPtr id_onLocationChanged_Landroid_location_Location_;
			[Register ("onLocationChanged", "(Landroid/location/Location;)V", "GetOnLocationChanged_Landroid_location_Location_Handler")]
			public virtual void OnLocationChanged (global::Android.Locations.Location p0)
			{
				if (id_onLocationChanged_Landroid_location_Location_ == IntPtr.Zero)
					id_onLocationChanged_Landroid_location_Location_ = JNIEnv.GetMethodID (class_ref, "onLocationChanged", "(Landroid/location/Location;)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onLocationChanged_Landroid_location_Location_, new JValue (p0));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_onLocationChanged_Landroid_location_Location_, new JValue (p0));
			}

			static Delegate cb_onProviderDisabled_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetOnProviderDisabled_Ljava_lang_String_Handler ()
			{
				if (cb_onProviderDisabled_Ljava_lang_String_ == null)
					cb_onProviderDisabled_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnProviderDisabled_Ljava_lang_String_);
				return cb_onProviderDisabled_Ljava_lang_String_;
			}

			static void n_OnProviderDisabled_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				ProviderListener __this = Java.Lang.Object.GetObject<ProviderListener> (native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnProviderDisabled (p0);
			}
#pragma warning restore 0169

			static IntPtr id_onProviderDisabled_Ljava_lang_String_;
			[Register ("onProviderDisabled", "(Ljava/lang/String;)V", "GetOnProviderDisabled_Ljava_lang_String_Handler")]
			public virtual void OnProviderDisabled (string p0)
			{
				if (id_onProviderDisabled_Ljava_lang_String_ == IntPtr.Zero)
					id_onProviderDisabled_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onProviderDisabled", "(Ljava/lang/String;)V");
				IntPtr native_p0 = JNIEnv.NewString (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onProviderDisabled_Ljava_lang_String_, new JValue (native_p0));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_onProviderDisabled_Ljava_lang_String_, new JValue (native_p0));
				JNIEnv.DeleteLocalRef (native_p0);
			}

			static Delegate cb_onProviderEnabled_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetOnProviderEnabled_Ljava_lang_String_Handler ()
			{
				if (cb_onProviderEnabled_Ljava_lang_String_ == null)
					cb_onProviderEnabled_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnProviderEnabled_Ljava_lang_String_);
				return cb_onProviderEnabled_Ljava_lang_String_;
			}

			static void n_OnProviderEnabled_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				ProviderListener __this = Java.Lang.Object.GetObject<ProviderListener> (native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnProviderEnabled (p0);
			}
#pragma warning restore 0169

			static IntPtr id_onProviderEnabled_Ljava_lang_String_;
			[Register ("onProviderEnabled", "(Ljava/lang/String;)V", "GetOnProviderEnabled_Ljava_lang_String_Handler")]
			public virtual void OnProviderEnabled (string p0)
			{
				if (id_onProviderEnabled_Ljava_lang_String_ == IntPtr.Zero)
					id_onProviderEnabled_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onProviderEnabled", "(Ljava/lang/String;)V");
				IntPtr native_p0 = JNIEnv.NewString (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onProviderEnabled_Ljava_lang_String_, new JValue (native_p0));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_onProviderEnabled_Ljava_lang_String_, new JValue (native_p0));
				JNIEnv.DeleteLocalRef (native_p0);
			}

			static Delegate cb_onStatusChanged_Ljava_lang_String_ILandroid_os_Bundle_;
#pragma warning disable 0169
			static Delegate GetOnStatusChanged_Ljava_lang_String_ILandroid_os_Bundle_Handler ()
			{
				if (cb_onStatusChanged_Ljava_lang_String_ILandroid_os_Bundle_ == null)
					cb_onStatusChanged_Ljava_lang_String_ILandroid_os_Bundle_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int, IntPtr>) n_OnStatusChanged_Ljava_lang_String_ILandroid_os_Bundle_);
				return cb_onStatusChanged_Ljava_lang_String_ILandroid_os_Bundle_;
			}

			static void n_OnStatusChanged_Ljava_lang_String_ILandroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int native_p1, IntPtr native_p2)
			{
				ProviderListener __this = Java.Lang.Object.GetObject<ProviderListener> (native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Android.Locations.Availability p1 = (global::Android.Locations.Availability) native_p1;
				global::Android.OS.Bundle p2 = Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p2, JniHandleOwnership.DoNotTransfer);
				__this.OnStatusChanged (p0, p1, p2);
			}
#pragma warning restore 0169

			static IntPtr id_onStatusChanged_Ljava_lang_String_ILandroid_os_Bundle_;
			[Register ("onStatusChanged", "(Ljava/lang/String;ILandroid/os/Bundle;)V", "GetOnStatusChanged_Ljava_lang_String_ILandroid_os_Bundle_Handler")]
			public virtual void OnStatusChanged (string p0, global::Android.Locations.Availability p1, global::Android.OS.Bundle p2)
			{
				if (id_onStatusChanged_Ljava_lang_String_ILandroid_os_Bundle_ == IntPtr.Zero)
					id_onStatusChanged_Ljava_lang_String_ILandroid_os_Bundle_ = JNIEnv.GetMethodID (class_ref, "onStatusChanged", "(Ljava/lang/String;ILandroid/os/Bundle;)V");
				IntPtr native_p0 = JNIEnv.NewString (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onStatusChanged_Ljava_lang_String_ILandroid_os_Bundle_, new JValue (native_p0), new JValue ((int) p1), new JValue (p2));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_onStatusChanged_Ljava_lang_String_ILandroid_os_Bundle_, new JValue (native_p0), new JValue ((int) p1), new JValue (p2));
				JNIEnv.DeleteLocalRef (native_p0);
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/urbanairship/location/LocationService", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (LocationService); }
		}

		protected LocationService (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		[Register (".ctor", "()V", "")]
		public LocationService () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (LocationService)) {
				SetHandle (global::Android.Runtime.JNIEnv.CreateInstance (GetType (), "()V"), JniHandleOwnership.TransferLocalRef);
				return;
			}

			if (id_ctor == IntPtr.Zero)
				id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
			SetHandle (JNIEnv.NewObject (class_ref, id_ctor), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_onBind_Landroid_content_Intent_;
#pragma warning disable 0169
		static Delegate GetOnBind_Landroid_content_Intent_Handler ()
		{
			if (cb_onBind_Landroid_content_Intent_ == null)
				cb_onBind_Landroid_content_Intent_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnBind_Landroid_content_Intent_);
			return cb_onBind_Landroid_content_Intent_;
		}

		static IntPtr n_OnBind_Landroid_content_Intent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			LocationService __this = Java.Lang.Object.GetObject<LocationService> (native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Intent p0 = Java.Lang.Object.GetObject<global::Android.Content.Intent> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.OnBind (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_onBind_Landroid_content_Intent_;
		[Register ("onBind", "(Landroid/content/Intent;)Landroid/os/IBinder;", "GetOnBind_Landroid_content_Intent_Handler")]
		public override global::Android.OS.IBinder OnBind (global::Android.Content.Intent p0)
		{
			if (id_onBind_Landroid_content_Intent_ == IntPtr.Zero)
				id_onBind_Landroid_content_Intent_ = JNIEnv.GetMethodID (class_ref, "onBind", "(Landroid/content/Intent;)Landroid/os/IBinder;");

			global::Android.OS.IBinder __ret;
			if (GetType () == ThresholdType)
				__ret = Java.Lang.Object.GetObject<global::Android.OS.IBinder> (JNIEnv.CallObjectMethod  (Handle, id_onBind_Landroid_content_Intent_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = Java.Lang.Object.GetObject<global::Android.OS.IBinder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_onBind_Landroid_content_Intent_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

	}
}
