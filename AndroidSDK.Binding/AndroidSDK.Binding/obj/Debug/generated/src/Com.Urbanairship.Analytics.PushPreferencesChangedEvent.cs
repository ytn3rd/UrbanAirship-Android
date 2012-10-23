using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Urbanairship.Analytics {

	[global::Android.Runtime.Register ("com/urbanairship/analytics/PushPreferencesChangedEvent", DoNotGenerateAcw=true)]
	public partial class PushPreferencesChangedEvent : global::Com.Urbanairship.Analytics.Event {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/urbanairship/analytics/PushPreferencesChangedEvent", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (PushPreferencesChangedEvent); }
		}

		protected PushPreferencesChangedEvent (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		[Register (".ctor", "()V", "")]
		public PushPreferencesChangedEvent () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (PushPreferencesChangedEvent)) {
				SetHandle (global::Android.Runtime.JNIEnv.CreateInstance (GetType (), "()V"), JniHandleOwnership.TransferLocalRef);
				return;
			}

			if (id_ctor == IntPtr.Zero)
				id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
			SetHandle (JNIEnv.NewObject (class_ref, id_ctor), JniHandleOwnership.TransferLocalRef);
		}

	}
}
