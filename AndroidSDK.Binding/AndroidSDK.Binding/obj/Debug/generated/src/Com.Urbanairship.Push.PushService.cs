using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Urbanairship.Push {

	[global::Android.Runtime.Register ("com/urbanairship/push/PushService", DoNotGenerateAcw=true)]
	public partial class PushService : global::Android.App.Service {


		[Register ("ACTION_HEARTBEAT")]
		public const string ActionHeartbeat = (string) "com.urbanairship.push.HEARTBEAT";

		[Register ("ACTION_START")]
		public const string ActionStart = (string) "com.urbanairship.push.START";

		[Register ("ACTION_STOP")]
		public const string ActionStop = (string) "com.urbanairship.push.STOP";

		static IntPtr started_jfieldId;

		[Register ("started")]
		public bool Started {
			get {
				if (started_jfieldId == IntPtr.Zero)
					started_jfieldId = JNIEnv.GetFieldID (class_ref, "started", "Z");
				return JNIEnv.GetBooleanField (Handle, started_jfieldId);
			}
			set {
				if (started_jfieldId == IntPtr.Zero)
					started_jfieldId = JNIEnv.GetFieldID (class_ref, "started", "Z");
				JNIEnv.SetField (Handle, started_jfieldId, value);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/urbanairship/push/PushService", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (PushService); }
		}

		protected PushService (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		[Register (".ctor", "()V", "")]
		public PushService () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (PushService)) {
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
			PushService __this = Java.Lang.Object.GetObject<PushService> (native__this, JniHandleOwnership.DoNotTransfer);
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
