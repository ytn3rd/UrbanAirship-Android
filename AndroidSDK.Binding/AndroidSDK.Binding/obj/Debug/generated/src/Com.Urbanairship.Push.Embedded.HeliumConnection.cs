using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Urbanairship.Push.Embedded {

	[global::Android.Runtime.Register ("com/urbanairship/push/embedded/HeliumConnection", DoNotGenerateAcw=true)]
	public partial class HeliumConnection : global::Java.Lang.Thread {


		[Register ("CONNECTION_TIMEOUT")]
		public const int ConnectionTimeout = (int) 60000;
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/urbanairship/push/embedded/HeliumConnection", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (HeliumConnection); }
		}

		protected HeliumConnection (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_urbanairship_push_embedded_EmbeddedPushManager_Lcom_urbanairship_push_embedded_BoxOfficeClient_;
		[Register (".ctor", "(Lcom/urbanairship/push/embedded/EmbeddedPushManager;Lcom/urbanairship/push/embedded/BoxOfficeClient;)V", "")]
		public HeliumConnection (global::Com.Urbanairship.Push.Embedded.EmbeddedPushManager p0, global::Com.Urbanairship.Push.Embedded.BoxOfficeClient p1) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (HeliumConnection)) {
				SetHandle (global::Android.Runtime.JNIEnv.CreateInstance (GetType (), "(Lcom/urbanairship/push/embedded/EmbeddedPushManager;Lcom/urbanairship/push/embedded/BoxOfficeClient;)V", new JValue (p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
				return;
			}

			if (id_ctor_Lcom_urbanairship_push_embedded_EmbeddedPushManager_Lcom_urbanairship_push_embedded_BoxOfficeClient_ == IntPtr.Zero)
				id_ctor_Lcom_urbanairship_push_embedded_EmbeddedPushManager_Lcom_urbanairship_push_embedded_BoxOfficeClient_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/urbanairship/push/embedded/EmbeddedPushManager;Lcom/urbanairship/push/embedded/BoxOfficeClient;)V");
			SetHandle (JNIEnv.NewObject (class_ref, id_ctor_Lcom_urbanairship_push_embedded_EmbeddedPushManager_Lcom_urbanairship_push_embedded_BoxOfficeClient_, new JValue (p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_isConnected;
#pragma warning disable 0169
		static Delegate GetIsConnectedHandler ()
		{
			if (cb_isConnected == null)
				cb_isConnected = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsConnected);
			return cb_isConnected;
		}

		static bool n_IsConnected (IntPtr jnienv, IntPtr native__this)
		{
			HeliumConnection __this = Java.Lang.Object.GetObject<HeliumConnection> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsConnected;
		}
#pragma warning restore 0169

		static IntPtr id_isConnected;
		public virtual bool IsConnected {
			[Register ("isConnected", "()Z", "GetIsConnectedHandler")]
			get {
				if (id_isConnected == IntPtr.Zero)
					id_isConnected = JNIEnv.GetMethodID (class_ref, "isConnected", "()Z");

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_isConnected);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, id_isConnected);
			}
		}

		static Delegate cb_isRunning;
#pragma warning disable 0169
		static Delegate GetIsRunningHandler ()
		{
			if (cb_isRunning == null)
				cb_isRunning = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsRunning);
			return cb_isRunning;
		}

		static bool n_IsRunning (IntPtr jnienv, IntPtr native__this)
		{
			HeliumConnection __this = Java.Lang.Object.GetObject<HeliumConnection> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsRunning;
		}
#pragma warning restore 0169

		static IntPtr id_isRunning;
		public virtual bool IsRunning {
			[Register ("isRunning", "()Z", "GetIsRunningHandler")]
			get {
				if (id_isRunning == IntPtr.Zero)
					id_isRunning = JNIEnv.GetMethodID (class_ref, "isRunning", "()Z");

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_isRunning);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, id_isRunning);
			}
		}

		static Delegate cb_isSocketStale;
#pragma warning disable 0169
		static Delegate GetIsSocketStaleHandler ()
		{
			if (cb_isSocketStale == null)
				cb_isSocketStale = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsSocketStale);
			return cb_isSocketStale;
		}

		static bool n_IsSocketStale (IntPtr jnienv, IntPtr native__this)
		{
			HeliumConnection __this = Java.Lang.Object.GetObject<HeliumConnection> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsSocketStale;
		}
#pragma warning restore 0169

		static IntPtr id_isSocketStale;
		public virtual bool IsSocketStale {
			[Register ("isSocketStale", "()Z", "GetIsSocketStaleHandler")]
			get {
				if (id_isSocketStale == IntPtr.Zero)
					id_isSocketStale = JNIEnv.GetMethodID (class_ref, "isSocketStale", "()Z");

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_isSocketStale);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, id_isSocketStale);
			}
		}

		static Delegate cb_getRetryInterval;
#pragma warning disable 0169
		static Delegate GetGetRetryIntervalHandler ()
		{
			if (cb_getRetryInterval == null)
				cb_getRetryInterval = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetRetryInterval);
			return cb_getRetryInterval;
		}

		static long n_GetRetryInterval (IntPtr jnienv, IntPtr native__this)
		{
			HeliumConnection __this = Java.Lang.Object.GetObject<HeliumConnection> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.RetryInterval;
		}
#pragma warning restore 0169

		static Delegate cb_setRetryInterval_J;
#pragma warning disable 0169
		static Delegate GetSetRetryInterval_JHandler ()
		{
			if (cb_setRetryInterval_J == null)
				cb_setRetryInterval_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_SetRetryInterval_J);
			return cb_setRetryInterval_J;
		}

		static void n_SetRetryInterval_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			HeliumConnection __this = Java.Lang.Object.GetObject<HeliumConnection> (native__this, JniHandleOwnership.DoNotTransfer);
			__this.RetryInterval = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getRetryInterval;
		static IntPtr id_setRetryInterval_J;
		public virtual long RetryInterval {
			[Register ("getRetryInterval", "()J", "GetGetRetryIntervalHandler")]
			get {
				if (id_getRetryInterval == IntPtr.Zero)
					id_getRetryInterval = JNIEnv.GetMethodID (class_ref, "getRetryInterval", "()J");

				if (GetType () == ThresholdType)
					return JNIEnv.CallLongMethod  (Handle, id_getRetryInterval);
				else
					return JNIEnv.CallNonvirtualLongMethod  (Handle, ThresholdClass, id_getRetryInterval);
			}
			[Register ("setRetryInterval", "(J)V", "GetSetRetryInterval_JHandler")]
			set {
				if (id_setRetryInterval_J == IntPtr.Zero)
					id_setRetryInterval_J = JNIEnv.GetMethodID (class_ref, "setRetryInterval", "(J)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setRetryInterval_J, new JValue (value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_setRetryInterval_J, new JValue (value));
			}
		}

		static Delegate cb_abort;
#pragma warning disable 0169
		static Delegate GetAbortHandler ()
		{
			if (cb_abort == null)
				cb_abort = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Abort);
			return cb_abort;
		}

		static void n_Abort (IntPtr jnienv, IntPtr native__this)
		{
			HeliumConnection __this = Java.Lang.Object.GetObject<HeliumConnection> (native__this, JniHandleOwnership.DoNotTransfer);
			__this.Abort ();
		}
#pragma warning restore 0169

		static IntPtr id_abort;
		[Register ("abort", "()V", "GetAbortHandler")]
		public virtual void Abort ()
		{
			if (id_abort == IntPtr.Zero)
				id_abort = JNIEnv.GetMethodID (class_ref, "abort", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_abort);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_abort);
		}

		static Delegate cb_resetStaleConnection;
#pragma warning disable 0169
		static Delegate GetResetStaleConnectionHandler ()
		{
			if (cb_resetStaleConnection == null)
				cb_resetStaleConnection = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ResetStaleConnection);
			return cb_resetStaleConnection;
		}

		static void n_ResetStaleConnection (IntPtr jnienv, IntPtr native__this)
		{
			HeliumConnection __this = Java.Lang.Object.GetObject<HeliumConnection> (native__this, JniHandleOwnership.DoNotTransfer);
			__this.ResetStaleConnection ();
		}
#pragma warning restore 0169

		static IntPtr id_resetStaleConnection;
		[Register ("resetStaleConnection", "()V", "GetResetStaleConnectionHandler")]
		public virtual void ResetStaleConnection ()
		{
			if (id_resetStaleConnection == IntPtr.Zero)
				id_resetStaleConnection = JNIEnv.GetMethodID (class_ref, "resetStaleConnection", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_resetStaleConnection);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_resetStaleConnection);
		}

	}
}
