using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Urbanairship.Restclient {

	[global::Android.Runtime.Register ("com/urbanairship/restclient/RequestQueue", DoNotGenerateAcw=true)]
	public partial class RequestQueue : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/urbanairship/restclient/RequestQueue", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (RequestQueue); }
		}

		protected RequestQueue (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		[Register (".ctor", "()V", "")]
		public RequestQueue () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (RequestQueue)) {
				SetHandle (global::Android.Runtime.JNIEnv.CreateInstance (GetType (), "()V"), JniHandleOwnership.TransferLocalRef);
				return;
			}

			if (id_ctor == IntPtr.Zero)
				id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
			SetHandle (JNIEnv.NewObject (class_ref, id_ctor), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_getMaxConcurrentRequests;
#pragma warning disable 0169
		static Delegate GetGetMaxConcurrentRequestsHandler ()
		{
			if (cb_getMaxConcurrentRequests == null)
				cb_getMaxConcurrentRequests = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetMaxConcurrentRequests);
			return cb_getMaxConcurrentRequests;
		}

		static int n_GetMaxConcurrentRequests (IntPtr jnienv, IntPtr native__this)
		{
			RequestQueue __this = Java.Lang.Object.GetObject<RequestQueue> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MaxConcurrentRequests;
		}
#pragma warning restore 0169

		static Delegate cb_setMaxConcurrentRequests_I;
#pragma warning disable 0169
		static Delegate GetSetMaxConcurrentRequests_IHandler ()
		{
			if (cb_setMaxConcurrentRequests_I == null)
				cb_setMaxConcurrentRequests_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetMaxConcurrentRequests_I);
			return cb_setMaxConcurrentRequests_I;
		}

		static void n_SetMaxConcurrentRequests_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			RequestQueue __this = Java.Lang.Object.GetObject<RequestQueue> (native__this, JniHandleOwnership.DoNotTransfer);
			__this.MaxConcurrentRequests = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getMaxConcurrentRequests;
		static IntPtr id_setMaxConcurrentRequests_I;
		public virtual int MaxConcurrentRequests {
			[Register ("getMaxConcurrentRequests", "()I", "GetGetMaxConcurrentRequestsHandler")]
			get {
				if (id_getMaxConcurrentRequests == IntPtr.Zero)
					id_getMaxConcurrentRequests = JNIEnv.GetMethodID (class_ref, "getMaxConcurrentRequests", "()I");

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_getMaxConcurrentRequests);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, id_getMaxConcurrentRequests);
			}
			[Register ("setMaxConcurrentRequests", "(I)V", "GetSetMaxConcurrentRequests_IHandler")]
			set {
				if (id_setMaxConcurrentRequests_I == IntPtr.Zero)
					id_setMaxConcurrentRequests_I = JNIEnv.GetMethodID (class_ref, "setMaxConcurrentRequests", "(I)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setMaxConcurrentRequests_I, new JValue (value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_setMaxConcurrentRequests_I, new JValue (value));
			}
		}

	}
}
