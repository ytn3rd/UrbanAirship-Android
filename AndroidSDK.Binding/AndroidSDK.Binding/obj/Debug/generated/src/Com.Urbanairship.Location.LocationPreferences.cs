using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Urbanairship.Location {

	[global::Android.Runtime.Register ("com/urbanairship/location/LocationPreferences", DoNotGenerateAcw=true)]
	public partial class LocationPreferences : global::Com.Urbanairship.Preferences {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/urbanairship/location/LocationPreferences", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (LocationPreferences); }
		}

		protected LocationPreferences (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		[Register (".ctor", "()V", "")]
		public LocationPreferences () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (LocationPreferences)) {
				SetHandle (global::Android.Runtime.JNIEnv.CreateInstance (GetType (), "()V"), JniHandleOwnership.TransferLocalRef);
				return;
			}

			if (id_ctor == IntPtr.Zero)
				id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
			SetHandle (JNIEnv.NewObject (class_ref, id_ctor), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_isBackgroundLocationEnabled;
#pragma warning disable 0169
		static Delegate GetIsBackgroundLocationEnabledHandler ()
		{
			if (cb_isBackgroundLocationEnabled == null)
				cb_isBackgroundLocationEnabled = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsBackgroundLocationEnabled);
			return cb_isBackgroundLocationEnabled;
		}

		static bool n_IsBackgroundLocationEnabled (IntPtr jnienv, IntPtr native__this)
		{
			LocationPreferences __this = Java.Lang.Object.GetObject<LocationPreferences> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsBackgroundLocationEnabled;
		}
#pragma warning restore 0169

		static IntPtr id_isBackgroundLocationEnabled;
		public virtual bool IsBackgroundLocationEnabled {
			[Register ("isBackgroundLocationEnabled", "()Z", "GetIsBackgroundLocationEnabledHandler")]
			get {
				if (id_isBackgroundLocationEnabled == IntPtr.Zero)
					id_isBackgroundLocationEnabled = JNIEnv.GetMethodID (class_ref, "isBackgroundLocationEnabled", "()Z");

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_isBackgroundLocationEnabled);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, id_isBackgroundLocationEnabled);
			}
		}

		static Delegate cb_isLocationEnabled;
#pragma warning disable 0169
		static Delegate GetIsLocationEnabledHandler ()
		{
			if (cb_isLocationEnabled == null)
				cb_isLocationEnabled = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsLocationEnabled);
			return cb_isLocationEnabled;
		}

		static bool n_IsLocationEnabled (IntPtr jnienv, IntPtr native__this)
		{
			LocationPreferences __this = Java.Lang.Object.GetObject<LocationPreferences> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsLocationEnabled;
		}
#pragma warning restore 0169

		static IntPtr id_isLocationEnabled;
		public virtual bool IsLocationEnabled {
			[Register ("isLocationEnabled", "()Z", "GetIsLocationEnabledHandler")]
			get {
				if (id_isLocationEnabled == IntPtr.Zero)
					id_isLocationEnabled = JNIEnv.GetMethodID (class_ref, "isLocationEnabled", "()Z");

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_isLocationEnabled);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, id_isLocationEnabled);
			}
		}

	}
}
