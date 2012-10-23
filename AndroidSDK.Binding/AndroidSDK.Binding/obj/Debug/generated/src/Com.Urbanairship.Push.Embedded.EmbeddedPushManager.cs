using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Urbanairship.Push.Embedded {

	[global::Android.Runtime.Register ("com/urbanairship/push/embedded/EmbeddedPushManager", DoNotGenerateAcw=true)]
	public partial class EmbeddedPushManager : global::Java.Lang.Object {


		static IntPtr instance_jfieldId;

		[Register ("instance")]
		public static global::Com.Urbanairship.Push.Embedded.EmbeddedPushManager Instance {
			get {
				if (instance_jfieldId == IntPtr.Zero)
					instance_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "instance", "Lcom/urbanairship/push/embedded/EmbeddedPushManager;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, instance_jfieldId);
				return Java.Lang.Object.GetObject<global::Com.Urbanairship.Push.Embedded.EmbeddedPushManager> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (instance_jfieldId == IntPtr.Zero)
					instance_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "instance", "Lcom/urbanairship/push/embedded/EmbeddedPushManager;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, instance_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		[Register ("version")]
		public const string Version = (string) "4.0.0";
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/urbanairship/push/embedded/EmbeddedPushManager", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (EmbeddedPushManager); }
		}

		protected EmbeddedPushManager (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_getExtraApidRegistrationsDisabled;
#pragma warning disable 0169
		static Delegate GetGetExtraApidRegistrationsDisabledHandler ()
		{
			if (cb_getExtraApidRegistrationsDisabled == null)
				cb_getExtraApidRegistrationsDisabled = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_GetExtraApidRegistrationsDisabled);
			return cb_getExtraApidRegistrationsDisabled;
		}

		static bool n_GetExtraApidRegistrationsDisabled (IntPtr jnienv, IntPtr native__this)
		{
			EmbeddedPushManager __this = Java.Lang.Object.GetObject<EmbeddedPushManager> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ExtraApidRegistrationsDisabled;
		}
#pragma warning restore 0169

		static Delegate cb_setExtraApidRegistrationsDisabled_Z;
#pragma warning disable 0169
		static Delegate GetSetExtraApidRegistrationsDisabled_ZHandler ()
		{
			if (cb_setExtraApidRegistrationsDisabled_Z == null)
				cb_setExtraApidRegistrationsDisabled_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetExtraApidRegistrationsDisabled_Z);
			return cb_setExtraApidRegistrationsDisabled_Z;
		}

		static void n_SetExtraApidRegistrationsDisabled_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			EmbeddedPushManager __this = Java.Lang.Object.GetObject<EmbeddedPushManager> (native__this, JniHandleOwnership.DoNotTransfer);
			__this.ExtraApidRegistrationsDisabled = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getExtraApidRegistrationsDisabled;
		static IntPtr id_setExtraApidRegistrationsDisabled_Z;
		public virtual bool ExtraApidRegistrationsDisabled {
			[Register ("getExtraApidRegistrationsDisabled", "()Z", "GetGetExtraApidRegistrationsDisabledHandler")]
			get {
				if (id_getExtraApidRegistrationsDisabled == IntPtr.Zero)
					id_getExtraApidRegistrationsDisabled = JNIEnv.GetMethodID (class_ref, "getExtraApidRegistrationsDisabled", "()Z");

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_getExtraApidRegistrationsDisabled);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, id_getExtraApidRegistrationsDisabled);
			}
			[Register ("setExtraApidRegistrationsDisabled", "(Z)V", "GetSetExtraApidRegistrationsDisabled_ZHandler")]
			set {
				if (id_setExtraApidRegistrationsDisabled_Z == IntPtr.Zero)
					id_setExtraApidRegistrationsDisabled_Z = JNIEnv.GetMethodID (class_ref, "setExtraApidRegistrationsDisabled", "(Z)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setExtraApidRegistrationsDisabled_Z, new JValue (value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_setExtraApidRegistrationsDisabled_Z, new JValue (value));
			}
		}

		static Delegate cb_isInHoldingPattern;
#pragma warning disable 0169
		static Delegate GetIsInHoldingPatternHandler ()
		{
			if (cb_isInHoldingPattern == null)
				cb_isInHoldingPattern = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsInHoldingPattern);
			return cb_isInHoldingPattern;
		}

		static bool n_IsInHoldingPattern (IntPtr jnienv, IntPtr native__this)
		{
			EmbeddedPushManager __this = Java.Lang.Object.GetObject<EmbeddedPushManager> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsInHoldingPattern;
		}
#pragma warning restore 0169

		static IntPtr id_isInHoldingPattern;
		public virtual bool IsInHoldingPattern {
			[Register ("isInHoldingPattern", "()Z", "GetIsInHoldingPatternHandler")]
			get {
				if (id_isInHoldingPattern == IntPtr.Zero)
					id_isInHoldingPattern = JNIEnv.GetMethodID (class_ref, "isInHoldingPattern", "()Z");

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_isInHoldingPattern);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, id_isInHoldingPattern);
			}
		}

		static Delegate cb_clearConnection;
#pragma warning disable 0169
		static Delegate GetClearConnectionHandler ()
		{
			if (cb_clearConnection == null)
				cb_clearConnection = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ClearConnection);
			return cb_clearConnection;
		}

		static void n_ClearConnection (IntPtr jnienv, IntPtr native__this)
		{
			EmbeddedPushManager __this = Java.Lang.Object.GetObject<EmbeddedPushManager> (native__this, JniHandleOwnership.DoNotTransfer);
			__this.ClearConnection ();
		}
#pragma warning restore 0169

		static IntPtr id_clearConnection;
		[Register ("clearConnection", "()V", "GetClearConnectionHandler")]
		public virtual void ClearConnection ()
		{
			if (id_clearConnection == IntPtr.Zero)
				id_clearConnection = JNIEnv.GetMethodID (class_ref, "clearConnection", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_clearConnection);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_clearConnection);
		}

		static IntPtr id_deliverPush_Lcom_urbanairship_push_proto_Messages_PushNotification_;
		[Register ("deliverPush", "(Lcom/urbanairship/push/proto/Messages$PushNotification;)V", "")]
		public static void DeliverPush (global::Com.Urbanairship.Push.Proto.Messages.PushNotification p0)
		{
			if (id_deliverPush_Lcom_urbanairship_push_proto_Messages_PushNotification_ == IntPtr.Zero)
				id_deliverPush_Lcom_urbanairship_push_proto_Messages_PushNotification_ = JNIEnv.GetStaticMethodID (class_ref, "deliverPush", "(Lcom/urbanairship/push/proto/Messages$PushNotification;)V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_deliverPush_Lcom_urbanairship_push_proto_Messages_PushNotification_, new JValue (p0));
		}

		static IntPtr id_init_Landroid_content_Context_Ljava_lang_String_;
		[Register ("init", "(Landroid/content/Context;Ljava/lang/String;)Z", "")]
		public static bool Init (global::Android.Content.Context p0, string p1)
		{
			if (id_init_Landroid_content_Context_Ljava_lang_String_ == IntPtr.Zero)
				id_init_Landroid_content_Context_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "init", "(Landroid/content/Context;Ljava/lang/String;)Z");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_init_Landroid_content_Context_Ljava_lang_String_, new JValue (p0), new JValue (native_p1));
			JNIEnv.DeleteLocalRef (native_p1);
			return __ret;
		}

		static Delegate cb_resetStuckConnection;
#pragma warning disable 0169
		static Delegate GetResetStuckConnectionHandler ()
		{
			if (cb_resetStuckConnection == null)
				cb_resetStuckConnection = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ResetStuckConnection);
			return cb_resetStuckConnection;
		}

		static void n_ResetStuckConnection (IntPtr jnienv, IntPtr native__this)
		{
			EmbeddedPushManager __this = Java.Lang.Object.GetObject<EmbeddedPushManager> (native__this, JniHandleOwnership.DoNotTransfer);
			__this.ResetStuckConnection ();
		}
#pragma warning restore 0169

		static IntPtr id_resetStuckConnection;
		[Register ("resetStuckConnection", "()V", "GetResetStuckConnectionHandler")]
		public virtual void ResetStuckConnection ()
		{
			if (id_resetStuckConnection == IntPtr.Zero)
				id_resetStuckConnection = JNIEnv.GetMethodID (class_ref, "resetStuckConnection", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_resetStuckConnection);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_resetStuckConnection);
		}

		static IntPtr id_sendRegistrationResponse_Z;
		[Register ("sendRegistrationResponse", "(Z)V", "")]
		protected static void SendRegistrationResponse (bool p0)
		{
			if (id_sendRegistrationResponse_Z == IntPtr.Zero)
				id_sendRegistrationResponse_Z = JNIEnv.GetStaticMethodID (class_ref, "sendRegistrationResponse", "(Z)V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_sendRegistrationResponse_Z, new JValue (p0));
		}

		static Delegate cb_setHoldingPattern_J;
#pragma warning disable 0169
		static Delegate GetSetHoldingPattern_JHandler ()
		{
			if (cb_setHoldingPattern_J == null)
				cb_setHoldingPattern_J = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, bool>) n_SetHoldingPattern_J);
			return cb_setHoldingPattern_J;
		}

		static bool n_SetHoldingPattern_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			EmbeddedPushManager __this = Java.Lang.Object.GetObject<EmbeddedPushManager> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SetHoldingPattern (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setHoldingPattern_J;
		[Register ("setHoldingPattern", "(J)Z", "GetSetHoldingPattern_JHandler")]
		public virtual bool SetHoldingPattern (long p0)
		{
			if (id_setHoldingPattern_J == IntPtr.Zero)
				id_setHoldingPattern_J = JNIEnv.GetMethodID (class_ref, "setHoldingPattern", "(J)Z");

			if (GetType () == ThresholdType)
				return JNIEnv.CallBooleanMethod  (Handle, id_setHoldingPattern_J, new JValue (p0));
			else
				return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, id_setHoldingPattern_J, new JValue (p0));
		}

		static Delegate cb_setIPAddress_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetIPAddress_Ljava_lang_String_Handler ()
		{
			if (cb_setIPAddress_Ljava_lang_String_ == null)
				cb_setIPAddress_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetIPAddress_Ljava_lang_String_);
			return cb_setIPAddress_Ljava_lang_String_;
		}

		static void n_SetIPAddress_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			EmbeddedPushManager __this = Java.Lang.Object.GetObject<EmbeddedPushManager> (native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetIPAddress (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setIPAddress_Ljava_lang_String_;
		[Register ("setIPAddress", "(Ljava/lang/String;)V", "GetSetIPAddress_Ljava_lang_String_Handler")]
		public virtual void SetIPAddress (string p0)
		{
			if (id_setIPAddress_Ljava_lang_String_ == IntPtr.Zero)
				id_setIPAddress_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setIPAddress", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setIPAddress_Ljava_lang_String_, new JValue (native_p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_setIPAddress_Ljava_lang_String_, new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static IntPtr id_shared;
		[Register ("shared", "()Lcom/urbanairship/push/embedded/EmbeddedPushManager;", "")]
		public static global::Com.Urbanairship.Push.Embedded.EmbeddedPushManager Shared ()
		{
			if (id_shared == IntPtr.Zero)
				id_shared = JNIEnv.GetStaticMethodID (class_ref, "shared", "()Lcom/urbanairship/push/embedded/EmbeddedPushManager;");
			return Java.Lang.Object.GetObject<global::Com.Urbanairship.Push.Embedded.EmbeddedPushManager> (JNIEnv.CallStaticObjectMethod  (class_ref, id_shared), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_stop;
		[Register ("stop", "()V", "")]
		public static void Stop ()
		{
			if (id_stop == IntPtr.Zero)
				id_stop = JNIEnv.GetStaticMethodID (class_ref, "stop", "()V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_stop);
		}

		static Delegate cb_stopHeartBeat;
#pragma warning disable 0169
		static Delegate GetStopHeartBeatHandler ()
		{
			if (cb_stopHeartBeat == null)
				cb_stopHeartBeat = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_StopHeartBeat);
			return cb_stopHeartBeat;
		}

		static void n_StopHeartBeat (IntPtr jnienv, IntPtr native__this)
		{
			EmbeddedPushManager __this = Java.Lang.Object.GetObject<EmbeddedPushManager> (native__this, JniHandleOwnership.DoNotTransfer);
			__this.StopHeartBeat ();
		}
#pragma warning restore 0169

		static IntPtr id_stopHeartBeat;
		[Register ("stopHeartBeat", "()V", "GetStopHeartBeatHandler")]
		public virtual void StopHeartBeat ()
		{
			if (id_stopHeartBeat == IntPtr.Zero)
				id_stopHeartBeat = JNIEnv.GetMethodID (class_ref, "stopHeartBeat", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_stopHeartBeat);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_stopHeartBeat);
		}

		static Delegate cb_teardown;
#pragma warning disable 0169
		static Delegate GetTeardownHandler ()
		{
			if (cb_teardown == null)
				cb_teardown = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Teardown);
			return cb_teardown;
		}

		static void n_Teardown (IntPtr jnienv, IntPtr native__this)
		{
			EmbeddedPushManager __this = Java.Lang.Object.GetObject<EmbeddedPushManager> (native__this, JniHandleOwnership.DoNotTransfer);
			__this.Teardown ();
		}
#pragma warning restore 0169

		static IntPtr id_teardown;
		[Register ("teardown", "()V", "GetTeardownHandler")]
		public virtual void Teardown ()
		{
			if (id_teardown == IntPtr.Zero)
				id_teardown = JNIEnv.GetMethodID (class_ref, "teardown", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_teardown);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_teardown);
		}

	}
}
