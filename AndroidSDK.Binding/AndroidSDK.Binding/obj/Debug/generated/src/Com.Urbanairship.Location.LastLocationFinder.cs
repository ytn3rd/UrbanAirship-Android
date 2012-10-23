using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Urbanairship.Location {

	[global::Android.Runtime.Register ("com/urbanairship/location/LastLocationFinder", DoNotGenerateAcw=true)]
	public partial class LastLocationFinder : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/urbanairship/location/LastLocationFinder", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (LastLocationFinder); }
		}

		protected LastLocationFinder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_;
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public LastLocationFinder (global::Android.Content.Context p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (LastLocationFinder)) {
				SetHandle (global::Android.Runtime.JNIEnv.CreateInstance (GetType (), "(Landroid/content/Context;)V", new JValue (p0)), JniHandleOwnership.TransferLocalRef);
				return;
			}

			if (id_ctor_Landroid_content_Context_ == IntPtr.Zero)
				id_ctor_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;)V");
			SetHandle (JNIEnv.NewObject (class_ref, id_ctor_Landroid_content_Context_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_getLastBestLocation_IJ;
#pragma warning disable 0169
		static Delegate GetGetLastBestLocation_IJHandler ()
		{
			if (cb_getLastBestLocation_IJ == null)
				cb_getLastBestLocation_IJ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, long, IntPtr>) n_GetLastBestLocation_IJ);
			return cb_getLastBestLocation_IJ;
		}

		static IntPtr n_GetLastBestLocation_IJ (IntPtr jnienv, IntPtr native__this, int p0, long p1)
		{
			LastLocationFinder __this = Java.Lang.Object.GetObject<LastLocationFinder> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetLastBestLocation (p0, p1));
		}
#pragma warning restore 0169

		static IntPtr id_getLastBestLocation_IJ;
		[Register ("getLastBestLocation", "(IJ)Landroid/location/Location;", "GetGetLastBestLocation_IJHandler")]
		public virtual global::Android.Locations.Location GetLastBestLocation (int p0, long p1)
		{
			if (id_getLastBestLocation_IJ == IntPtr.Zero)
				id_getLastBestLocation_IJ = JNIEnv.GetMethodID (class_ref, "getLastBestLocation", "(IJ)Landroid/location/Location;");

			if (GetType () == ThresholdType)
				return Java.Lang.Object.GetObject<global::Android.Locations.Location> (JNIEnv.CallObjectMethod  (Handle, id_getLastBestLocation_IJ, new JValue (p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
			else
				return Java.Lang.Object.GetObject<global::Android.Locations.Location> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getLastBestLocation_IJ, new JValue (p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
		}

	}
}
