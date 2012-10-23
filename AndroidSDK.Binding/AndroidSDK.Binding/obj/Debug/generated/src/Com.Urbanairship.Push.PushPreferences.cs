using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Urbanairship.Push {

	[global::Android.Runtime.Register ("com/urbanairship/push/PushPreferences", DoNotGenerateAcw=true)]
	public partial class PushPreferences : global::Com.Urbanairship.Preferences {

		[global::Android.Runtime.Register ("com/urbanairship/push/PushPreferences$QuietTime", DoNotGenerateAcw=true)]
		public sealed partial class QuietTime : global::Java.Lang.Object {


			[Register ("ENABLED")]
			public const string Enabled = (string) "com.urbanairship.push.QuietTime.ENABLED";

			[Register ("END_HOUR_KEY")]
			public const string EndHourKey = (string) "com.urbanairship.push.QuietTime.END_HOUR";

			[Register ("END_MIN_KEY")]
			public const string EndMinKey = (string) "com.urbanairship.push.QuietTime.END_MINUTE";

			[Register ("NOT_SET_VAL")]
			public const int NotSetVal = (int) -1;

			[Register ("START_HOUR_KEY")]
			public const string StartHourKey = (string) "com.urbanairship.push.QuietTime.START_HOUR";

			[Register ("START_MIN_KEY")]
			public const string StartMinKey = (string) "com.urbanairship.push.QuietTime.START_MINUTE";
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/urbanairship/push/PushPreferences$QuietTime", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (QuietTime); }
			}

			internal QuietTime (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/urbanairship/push/PushPreferences", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (PushPreferences); }
		}

		protected PushPreferences (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		[Register (".ctor", "()V", "")]
		public PushPreferences () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (PushPreferences)) {
				SetHandle (global::Android.Runtime.JNIEnv.CreateInstance (GetType (), "()V"), JniHandleOwnership.TransferLocalRef);
				return;
			}

			if (id_ctor == IntPtr.Zero)
				id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
			SetHandle (JNIEnv.NewObject (class_ref, id_ctor), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_getAlias;
#pragma warning disable 0169
		static Delegate GetGetAliasHandler ()
		{
			if (cb_getAlias == null)
				cb_getAlias = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAlias);
			return cb_getAlias;
		}

		static IntPtr n_GetAlias (IntPtr jnienv, IntPtr native__this)
		{
			PushPreferences __this = Java.Lang.Object.GetObject<PushPreferences> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Alias);
		}
#pragma warning restore 0169

		static Delegate cb_setAlias_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetAlias_Ljava_lang_String_Handler ()
		{
			if (cb_setAlias_Ljava_lang_String_ == null)
				cb_setAlias_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetAlias_Ljava_lang_String_);
			return cb_setAlias_Ljava_lang_String_;
		}

		static void n_SetAlias_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			PushPreferences __this = Java.Lang.Object.GetObject<PushPreferences> (native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Alias = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getAlias;
		static IntPtr id_setAlias_Ljava_lang_String_;
		public virtual string Alias {
			[Register ("getAlias", "()Ljava/lang/String;", "GetGetAliasHandler")]
			get {
				if (id_getAlias == IntPtr.Zero)
					id_getAlias = JNIEnv.GetMethodID (class_ref, "getAlias", "()Ljava/lang/String;");

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getAlias), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getAlias), JniHandleOwnership.TransferLocalRef);
			}
			[Register ("setAlias", "(Ljava/lang/String;)V", "GetSetAlias_Ljava_lang_String_Handler")]
			set {
				if (id_setAlias_Ljava_lang_String_ == IntPtr.Zero)
					id_setAlias_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setAlias", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setAlias_Ljava_lang_String_, new JValue (native_value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_setAlias_Ljava_lang_String_, new JValue (native_value));
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static Delegate cb_getAppVersionCode;
#pragma warning disable 0169
		static Delegate GetGetAppVersionCodeHandler ()
		{
			if (cb_getAppVersionCode == null)
				cb_getAppVersionCode = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetAppVersionCode);
			return cb_getAppVersionCode;
		}

		static int n_GetAppVersionCode (IntPtr jnienv, IntPtr native__this)
		{
			PushPreferences __this = Java.Lang.Object.GetObject<PushPreferences> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.AppVersionCode;
		}
#pragma warning restore 0169

		static Delegate cb_setAppVersionCode_I;
#pragma warning disable 0169
		static Delegate GetSetAppVersionCode_IHandler ()
		{
			if (cb_setAppVersionCode_I == null)
				cb_setAppVersionCode_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetAppVersionCode_I);
			return cb_setAppVersionCode_I;
		}

		static void n_SetAppVersionCode_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			PushPreferences __this = Java.Lang.Object.GetObject<PushPreferences> (native__this, JniHandleOwnership.DoNotTransfer);
			__this.AppVersionCode = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getAppVersionCode;
		static IntPtr id_setAppVersionCode_I;
		public virtual int AppVersionCode {
			[Register ("getAppVersionCode", "()I", "GetGetAppVersionCodeHandler")]
			get {
				if (id_getAppVersionCode == IntPtr.Zero)
					id_getAppVersionCode = JNIEnv.GetMethodID (class_ref, "getAppVersionCode", "()I");

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_getAppVersionCode);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, id_getAppVersionCode);
			}
			[Register ("setAppVersionCode", "(I)V", "GetSetAppVersionCode_IHandler")]
			set {
				if (id_setAppVersionCode_I == IntPtr.Zero)
					id_setAppVersionCode_I = JNIEnv.GetMethodID (class_ref, "setAppVersionCode", "(I)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setAppVersionCode_I, new JValue (value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_setAppVersionCode_I, new JValue (value));
			}
		}

		static Delegate cb_getDeviceId;
#pragma warning disable 0169
		static Delegate GetGetDeviceIdHandler ()
		{
			if (cb_getDeviceId == null)
				cb_getDeviceId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDeviceId);
			return cb_getDeviceId;
		}

		static IntPtr n_GetDeviceId (IntPtr jnienv, IntPtr native__this)
		{
			PushPreferences __this = Java.Lang.Object.GetObject<PushPreferences> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.DeviceId);
		}
#pragma warning restore 0169

		static Delegate cb_setDeviceId_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetDeviceId_Ljava_lang_String_Handler ()
		{
			if (cb_setDeviceId_Ljava_lang_String_ == null)
				cb_setDeviceId_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetDeviceId_Ljava_lang_String_);
			return cb_setDeviceId_Ljava_lang_String_;
		}

		static void n_SetDeviceId_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			PushPreferences __this = Java.Lang.Object.GetObject<PushPreferences> (native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.DeviceId = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getDeviceId;
		static IntPtr id_setDeviceId_Ljava_lang_String_;
		public virtual string DeviceId {
			[Register ("getDeviceId", "()Ljava/lang/String;", "GetGetDeviceIdHandler")]
			get {
				if (id_getDeviceId == IntPtr.Zero)
					id_getDeviceId = JNIEnv.GetMethodID (class_ref, "getDeviceId", "()Ljava/lang/String;");

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getDeviceId), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getDeviceId), JniHandleOwnership.TransferLocalRef);
			}
			[Register ("setDeviceId", "(Ljava/lang/String;)V", "GetSetDeviceId_Ljava_lang_String_Handler")]
			set {
				if (id_setDeviceId_Ljava_lang_String_ == IntPtr.Zero)
					id_setDeviceId_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setDeviceId", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setDeviceId_Ljava_lang_String_, new JValue (native_value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_setDeviceId_Ljava_lang_String_, new JValue (native_value));
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static Delegate cb_getGcmId;
#pragma warning disable 0169
		static Delegate GetGetGcmIdHandler ()
		{
			if (cb_getGcmId == null)
				cb_getGcmId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetGcmId);
			return cb_getGcmId;
		}

		static IntPtr n_GetGcmId (IntPtr jnienv, IntPtr native__this)
		{
			PushPreferences __this = Java.Lang.Object.GetObject<PushPreferences> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.GcmId);
		}
#pragma warning restore 0169

		static Delegate cb_setGcmId_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetGcmId_Ljava_lang_String_Handler ()
		{
			if (cb_setGcmId_Ljava_lang_String_ == null)
				cb_setGcmId_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetGcmId_Ljava_lang_String_);
			return cb_setGcmId_Ljava_lang_String_;
		}

		static void n_SetGcmId_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			PushPreferences __this = Java.Lang.Object.GetObject<PushPreferences> (native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.GcmId = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getGcmId;
		static IntPtr id_setGcmId_Ljava_lang_String_;
		public virtual string GcmId {
			[Register ("getGcmId", "()Ljava/lang/String;", "GetGetGcmIdHandler")]
			get {
				if (id_getGcmId == IntPtr.Zero)
					id_getGcmId = JNIEnv.GetMethodID (class_ref, "getGcmId", "()Ljava/lang/String;");

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getGcmId), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getGcmId), JniHandleOwnership.TransferLocalRef);
			}
			[Register ("setGcmId", "(Ljava/lang/String;)V", "GetSetGcmId_Ljava_lang_String_Handler")]
			set {
				if (id_setGcmId_Ljava_lang_String_ == IntPtr.Zero)
					id_setGcmId_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setGcmId", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setGcmId_Ljava_lang_String_, new JValue (native_value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_setGcmId_Ljava_lang_String_, new JValue (native_value));
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static Delegate cb_isInQuietTime;
#pragma warning disable 0169
		static Delegate GetIsInQuietTimeHandler ()
		{
			if (cb_isInQuietTime == null)
				cb_isInQuietTime = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsInQuietTime);
			return cb_isInQuietTime;
		}

		static bool n_IsInQuietTime (IntPtr jnienv, IntPtr native__this)
		{
			PushPreferences __this = Java.Lang.Object.GetObject<PushPreferences> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsInQuietTime;
		}
#pragma warning restore 0169

		static IntPtr id_isInQuietTime;
		public virtual bool IsInQuietTime {
			[Register ("isInQuietTime", "()Z", "GetIsInQuietTimeHandler")]
			get {
				if (id_isInQuietTime == IntPtr.Zero)
					id_isInQuietTime = JNIEnv.GetMethodID (class_ref, "isInQuietTime", "()Z");

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_isInQuietTime);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, id_isInQuietTime);
			}
		}

		static Delegate cb_isPushEnabled;
#pragma warning disable 0169
		static Delegate GetIsPushEnabledHandler ()
		{
			if (cb_isPushEnabled == null)
				cb_isPushEnabled = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsPushEnabled);
			return cb_isPushEnabled;
		}

		static bool n_IsPushEnabled (IntPtr jnienv, IntPtr native__this)
		{
			PushPreferences __this = Java.Lang.Object.GetObject<PushPreferences> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsPushEnabled;
		}
#pragma warning restore 0169

		static IntPtr id_isPushEnabled;
		public virtual bool IsPushEnabled {
			[Register ("isPushEnabled", "()Z", "GetIsPushEnabledHandler")]
			get {
				if (id_isPushEnabled == IntPtr.Zero)
					id_isPushEnabled = JNIEnv.GetMethodID (class_ref, "isPushEnabled", "()Z");

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_isPushEnabled);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, id_isPushEnabled);
			}
		}

		static Delegate cb_getPushId;
#pragma warning disable 0169
		static Delegate GetGetPushIdHandler ()
		{
			if (cb_getPushId == null)
				cb_getPushId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPushId);
			return cb_getPushId;
		}

		static IntPtr n_GetPushId (IntPtr jnienv, IntPtr native__this)
		{
			PushPreferences __this = Java.Lang.Object.GetObject<PushPreferences> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.PushId);
		}
#pragma warning restore 0169

		static IntPtr id_getPushId;
		public virtual string PushId {
			[Register ("getPushId", "()Ljava/lang/String;", "GetGetPushIdHandler")]
			get {
				if (id_getPushId == IntPtr.Zero)
					id_getPushId = JNIEnv.GetMethodID (class_ref, "getPushId", "()Ljava/lang/String;");

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getPushId), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getPushId), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getPushSecret;
#pragma warning disable 0169
		static Delegate GetGetPushSecretHandler ()
		{
			if (cb_getPushSecret == null)
				cb_getPushSecret = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPushSecret);
			return cb_getPushSecret;
		}

		static IntPtr n_GetPushSecret (IntPtr jnienv, IntPtr native__this)
		{
			PushPreferences __this = Java.Lang.Object.GetObject<PushPreferences> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.PushSecret);
		}
#pragma warning restore 0169

		static IntPtr id_getPushSecret;
		public virtual string PushSecret {
			[Register ("getPushSecret", "()Ljava/lang/String;", "GetGetPushSecretHandler")]
			get {
				if (id_getPushSecret == IntPtr.Zero)
					id_getPushSecret = JNIEnv.GetMethodID (class_ref, "getPushSecret", "()Ljava/lang/String;");

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getPushSecret), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getPushSecret), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_isQuietTimeEnabled;
#pragma warning disable 0169
		static Delegate GetIsQuietTimeEnabledHandler ()
		{
			if (cb_isQuietTimeEnabled == null)
				cb_isQuietTimeEnabled = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsQuietTimeEnabled);
			return cb_isQuietTimeEnabled;
		}

		static bool n_IsQuietTimeEnabled (IntPtr jnienv, IntPtr native__this)
		{
			PushPreferences __this = Java.Lang.Object.GetObject<PushPreferences> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.QuietTimeEnabled;
		}
#pragma warning restore 0169

		static Delegate cb_setQuietTimeEnabled_Z;
#pragma warning disable 0169
		static Delegate GetSetQuietTimeEnabled_ZHandler ()
		{
			if (cb_setQuietTimeEnabled_Z == null)
				cb_setQuietTimeEnabled_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetQuietTimeEnabled_Z);
			return cb_setQuietTimeEnabled_Z;
		}

		static void n_SetQuietTimeEnabled_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			PushPreferences __this = Java.Lang.Object.GetObject<PushPreferences> (native__this, JniHandleOwnership.DoNotTransfer);
			__this.QuietTimeEnabled = p0;
		}
#pragma warning restore 0169

		static IntPtr id_isQuietTimeEnabled;
		static IntPtr id_setQuietTimeEnabled_Z;
		public virtual bool QuietTimeEnabled {
			[Register ("isQuietTimeEnabled", "()Z", "GetIsQuietTimeEnabledHandler")]
			get {
				if (id_isQuietTimeEnabled == IntPtr.Zero)
					id_isQuietTimeEnabled = JNIEnv.GetMethodID (class_ref, "isQuietTimeEnabled", "()Z");

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_isQuietTimeEnabled);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, id_isQuietTimeEnabled);
			}
			[Register ("setQuietTimeEnabled", "(Z)V", "GetSetQuietTimeEnabled_ZHandler")]
			set {
				if (id_setQuietTimeEnabled_Z == IntPtr.Zero)
					id_setQuietTimeEnabled_Z = JNIEnv.GetMethodID (class_ref, "setQuietTimeEnabled", "(Z)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setQuietTimeEnabled_Z, new JValue (value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_setQuietTimeEnabled_Z, new JValue (value));
			}
		}

		static Delegate cb_getRetryAfter;
#pragma warning disable 0169
		static Delegate GetGetRetryAfterHandler ()
		{
			if (cb_getRetryAfter == null)
				cb_getRetryAfter = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetRetryAfter);
			return cb_getRetryAfter;
		}

		static long n_GetRetryAfter (IntPtr jnienv, IntPtr native__this)
		{
			PushPreferences __this = Java.Lang.Object.GetObject<PushPreferences> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.RetryAfter;
		}
#pragma warning restore 0169

		static Delegate cb_setRetryAfter_J;
#pragma warning disable 0169
		static Delegate GetSetRetryAfter_JHandler ()
		{
			if (cb_setRetryAfter_J == null)
				cb_setRetryAfter_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_SetRetryAfter_J);
			return cb_setRetryAfter_J;
		}

		static void n_SetRetryAfter_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			PushPreferences __this = Java.Lang.Object.GetObject<PushPreferences> (native__this, JniHandleOwnership.DoNotTransfer);
			__this.RetryAfter = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getRetryAfter;
		static IntPtr id_setRetryAfter_J;
		public virtual long RetryAfter {
			[Register ("getRetryAfter", "()J", "GetGetRetryAfterHandler")]
			get {
				if (id_getRetryAfter == IntPtr.Zero)
					id_getRetryAfter = JNIEnv.GetMethodID (class_ref, "getRetryAfter", "()J");

				if (GetType () == ThresholdType)
					return JNIEnv.CallLongMethod  (Handle, id_getRetryAfter);
				else
					return JNIEnv.CallNonvirtualLongMethod  (Handle, ThresholdClass, id_getRetryAfter);
			}
			[Register ("setRetryAfter", "(J)V", "GetSetRetryAfter_JHandler")]
			set {
				if (id_setRetryAfter_J == IntPtr.Zero)
					id_setRetryAfter_J = JNIEnv.GetMethodID (class_ref, "setRetryAfter", "(J)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setRetryAfter_J, new JValue (value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_setRetryAfter_J, new JValue (value));
			}
		}

		static Delegate cb_isSoundEnabled;
#pragma warning disable 0169
		static Delegate GetIsSoundEnabledHandler ()
		{
			if (cb_isSoundEnabled == null)
				cb_isSoundEnabled = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsSoundEnabled);
			return cb_isSoundEnabled;
		}

		static bool n_IsSoundEnabled (IntPtr jnienv, IntPtr native__this)
		{
			PushPreferences __this = Java.Lang.Object.GetObject<PushPreferences> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SoundEnabled;
		}
#pragma warning restore 0169

		static Delegate cb_setSoundEnabled_Z;
#pragma warning disable 0169
		static Delegate GetSetSoundEnabled_ZHandler ()
		{
			if (cb_setSoundEnabled_Z == null)
				cb_setSoundEnabled_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetSoundEnabled_Z);
			return cb_setSoundEnabled_Z;
		}

		static void n_SetSoundEnabled_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			PushPreferences __this = Java.Lang.Object.GetObject<PushPreferences> (native__this, JniHandleOwnership.DoNotTransfer);
			__this.SoundEnabled = p0;
		}
#pragma warning restore 0169

		static IntPtr id_isSoundEnabled;
		static IntPtr id_setSoundEnabled_Z;
		public virtual bool SoundEnabled {
			[Register ("isSoundEnabled", "()Z", "GetIsSoundEnabledHandler")]
			get {
				if (id_isSoundEnabled == IntPtr.Zero)
					id_isSoundEnabled = JNIEnv.GetMethodID (class_ref, "isSoundEnabled", "()Z");

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_isSoundEnabled);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, id_isSoundEnabled);
			}
			[Register ("setSoundEnabled", "(Z)V", "GetSetSoundEnabled_ZHandler")]
			set {
				if (id_setSoundEnabled_Z == IntPtr.Zero)
					id_setSoundEnabled_Z = JNIEnv.GetMethodID (class_ref, "setSoundEnabled", "(Z)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setSoundEnabled_Z, new JValue (value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_setSoundEnabled_Z, new JValue (value));
			}
		}

		static Delegate cb_getTags;
#pragma warning disable 0169
		static Delegate GetGetTagsHandler ()
		{
			if (cb_getTags == null)
				cb_getTags = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTags);
			return cb_getTags;
		}

		static IntPtr n_GetTags (IntPtr jnienv, IntPtr native__this)
		{
			PushPreferences __this = Java.Lang.Object.GetObject<PushPreferences> (native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaSet<string>.ToLocalJniHandle (__this.Tags);
		}
#pragma warning restore 0169

		static Delegate cb_setTags_Ljava_util_Set_;
#pragma warning disable 0169
		static Delegate GetSetTags_Ljava_util_Set_Handler ()
		{
			if (cb_setTags_Ljava_util_Set_ == null)
				cb_setTags_Ljava_util_Set_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetTags_Ljava_util_Set_);
			return cb_setTags_Ljava_util_Set_;
		}

		static void n_SetTags_Ljava_util_Set_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			PushPreferences __this = Java.Lang.Object.GetObject<PushPreferences> (native__this, JniHandleOwnership.DoNotTransfer);
			System.Collections.Generic.ICollection<string> p0 = global::Android.Runtime.JavaSet<string>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Tags = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getTags;
		static IntPtr id_setTags_Ljava_util_Set_;
		public virtual global::System.Collections.Generic.ICollection<string> Tags {
			[Register ("getTags", "()Ljava/util/Set;", "GetGetTagsHandler")]
			get {
				if (id_getTags == IntPtr.Zero)
					id_getTags = JNIEnv.GetMethodID (class_ref, "getTags", "()Ljava/util/Set;");

				if (GetType () == ThresholdType)
					return global::Android.Runtime.JavaSet<string>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_getTags), JniHandleOwnership.TransferLocalRef);
				else
					return global::Android.Runtime.JavaSet<string>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getTags), JniHandleOwnership.TransferLocalRef);
			}
			[Register ("setTags", "(Ljava/util/Set;)V", "GetSetTags_Ljava_util_Set_Handler")]
			set {
				if (id_setTags_Ljava_util_Set_ == IntPtr.Zero)
					id_setTags_Ljava_util_Set_ = JNIEnv.GetMethodID (class_ref, "setTags", "(Ljava/util/Set;)V");
				IntPtr native_value = global::Android.Runtime.JavaSet<string>.ToLocalJniHandle (value);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setTags_Ljava_util_Set_, new JValue (native_value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_setTags_Ljava_util_Set_, new JValue (native_value));
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static Delegate cb_isVibrateEnabled;
#pragma warning disable 0169
		static Delegate GetIsVibrateEnabledHandler ()
		{
			if (cb_isVibrateEnabled == null)
				cb_isVibrateEnabled = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsVibrateEnabled);
			return cb_isVibrateEnabled;
		}

		static bool n_IsVibrateEnabled (IntPtr jnienv, IntPtr native__this)
		{
			PushPreferences __this = Java.Lang.Object.GetObject<PushPreferences> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.VibrateEnabled;
		}
#pragma warning restore 0169

		static Delegate cb_setVibrateEnabled_Z;
#pragma warning disable 0169
		static Delegate GetSetVibrateEnabled_ZHandler ()
		{
			if (cb_setVibrateEnabled_Z == null)
				cb_setVibrateEnabled_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetVibrateEnabled_Z);
			return cb_setVibrateEnabled_Z;
		}

		static void n_SetVibrateEnabled_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			PushPreferences __this = Java.Lang.Object.GetObject<PushPreferences> (native__this, JniHandleOwnership.DoNotTransfer);
			__this.VibrateEnabled = p0;
		}
#pragma warning restore 0169

		static IntPtr id_isVibrateEnabled;
		static IntPtr id_setVibrateEnabled_Z;
		public virtual bool VibrateEnabled {
			[Register ("isVibrateEnabled", "()Z", "GetIsVibrateEnabledHandler")]
			get {
				if (id_isVibrateEnabled == IntPtr.Zero)
					id_isVibrateEnabled = JNIEnv.GetMethodID (class_ref, "isVibrateEnabled", "()Z");

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_isVibrateEnabled);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, id_isVibrateEnabled);
			}
			[Register ("setVibrateEnabled", "(Z)V", "GetSetVibrateEnabled_ZHandler")]
			set {
				if (id_setVibrateEnabled_Z == IntPtr.Zero)
					id_setVibrateEnabled_Z = JNIEnv.GetMethodID (class_ref, "setVibrateEnabled", "(Z)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setVibrateEnabled_Z, new JValue (value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_setVibrateEnabled_Z, new JValue (value));
			}
		}

		static Delegate cb_isWifiWakeEnabled;
#pragma warning disable 0169
		static Delegate GetIsWifiWakeEnabledHandler ()
		{
			if (cb_isWifiWakeEnabled == null)
				cb_isWifiWakeEnabled = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsWifiWakeEnabled);
			return cb_isWifiWakeEnabled;
		}

		static bool n_IsWifiWakeEnabled (IntPtr jnienv, IntPtr native__this)
		{
			PushPreferences __this = Java.Lang.Object.GetObject<PushPreferences> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.WifiWakeEnabled;
		}
#pragma warning restore 0169

		static Delegate cb_setWifiWakeEnabled_Z;
#pragma warning disable 0169
		static Delegate GetSetWifiWakeEnabled_ZHandler ()
		{
			if (cb_setWifiWakeEnabled_Z == null)
				cb_setWifiWakeEnabled_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetWifiWakeEnabled_Z);
			return cb_setWifiWakeEnabled_Z;
		}

		static void n_SetWifiWakeEnabled_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			PushPreferences __this = Java.Lang.Object.GetObject<PushPreferences> (native__this, JniHandleOwnership.DoNotTransfer);
			__this.WifiWakeEnabled = p0;
		}
#pragma warning restore 0169

		static IntPtr id_isWifiWakeEnabled;
		static IntPtr id_setWifiWakeEnabled_Z;
		public virtual bool WifiWakeEnabled {
			[Register ("isWifiWakeEnabled", "()Z", "GetIsWifiWakeEnabledHandler")]
			get {
				if (id_isWifiWakeEnabled == IntPtr.Zero)
					id_isWifiWakeEnabled = JNIEnv.GetMethodID (class_ref, "isWifiWakeEnabled", "()Z");

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_isWifiWakeEnabled);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, id_isWifiWakeEnabled);
			}
			[Register ("setWifiWakeEnabled", "(Z)V", "GetSetWifiWakeEnabled_ZHandler")]
			set {
				if (id_setWifiWakeEnabled_Z == IntPtr.Zero)
					id_setWifiWakeEnabled_Z = JNIEnv.GetMethodID (class_ref, "setWifiWakeEnabled", "(Z)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setWifiWakeEnabled_Z, new JValue (value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_setWifiWakeEnabled_Z, new JValue (value));
			}
		}

		static Delegate cb_getQuietTimeInterval;
#pragma warning disable 0169
		static Delegate GetGetQuietTimeIntervalHandler ()
		{
			if (cb_getQuietTimeInterval == null)
				cb_getQuietTimeInterval = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetQuietTimeInterval);
			return cb_getQuietTimeInterval;
		}

		static IntPtr n_GetQuietTimeInterval (IntPtr jnienv, IntPtr native__this)
		{
			PushPreferences __this = Java.Lang.Object.GetObject<PushPreferences> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetQuietTimeInterval ());
		}
#pragma warning restore 0169

		static IntPtr id_getQuietTimeInterval;
		[Register ("getQuietTimeInterval", "()[Ljava/util/Date;", "GetGetQuietTimeIntervalHandler")]
		public virtual global::Java.Util.Date[] GetQuietTimeInterval ()
		{
			if (id_getQuietTimeInterval == IntPtr.Zero)
				id_getQuietTimeInterval = JNIEnv.GetMethodID (class_ref, "getQuietTimeInterval", "()[Ljava/util/Date;");

			if (GetType () == ThresholdType)
				return (Java.Util.Date[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_getQuietTimeInterval), JniHandleOwnership.TransferLocalRef, typeof (global::Java.Util.Date));
			else
				return (Java.Util.Date[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getQuietTimeInterval), JniHandleOwnership.TransferLocalRef, typeof (global::Java.Util.Date));
		}

		static Delegate cb_setPushId_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetPushId_Ljava_lang_String_Handler ()
		{
			if (cb_setPushId_Ljava_lang_String_ == null)
				cb_setPushId_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_SetPushId_Ljava_lang_String_);
			return cb_setPushId_Ljava_lang_String_;
		}

		static bool n_SetPushId_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			PushPreferences __this = Java.Lang.Object.GetObject<PushPreferences> (native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.SetPushId (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_setPushId_Ljava_lang_String_;
		[Register ("setPushId", "(Ljava/lang/String;)Z", "GetSetPushId_Ljava_lang_String_Handler")]
		public virtual bool SetPushId (string p0)
		{
			if (id_setPushId_Ljava_lang_String_ == IntPtr.Zero)
				id_setPushId_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setPushId", "(Ljava/lang/String;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			bool __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallBooleanMethod  (Handle, id_setPushId_Ljava_lang_String_, new JValue (native_p0));
			else
				__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, id_setPushId_Ljava_lang_String_, new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_setPushSecret_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetPushSecret_Ljava_lang_String_Handler ()
		{
			if (cb_setPushSecret_Ljava_lang_String_ == null)
				cb_setPushSecret_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_SetPushSecret_Ljava_lang_String_);
			return cb_setPushSecret_Ljava_lang_String_;
		}

		static bool n_SetPushSecret_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			PushPreferences __this = Java.Lang.Object.GetObject<PushPreferences> (native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.SetPushSecret (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_setPushSecret_Ljava_lang_String_;
		[Register ("setPushSecret", "(Ljava/lang/String;)Z", "GetSetPushSecret_Ljava_lang_String_Handler")]
		public virtual bool SetPushSecret (string p0)
		{
			if (id_setPushSecret_Ljava_lang_String_ == IntPtr.Zero)
				id_setPushSecret_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setPushSecret", "(Ljava/lang/String;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			bool __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallBooleanMethod  (Handle, id_setPushSecret_Ljava_lang_String_, new JValue (native_p0));
			else
				__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, id_setPushSecret_Ljava_lang_String_, new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_setQuietTimeInterval_Ljava_util_Date_Ljava_util_Date_;
#pragma warning disable 0169
		static Delegate GetSetQuietTimeInterval_Ljava_util_Date_Ljava_util_Date_Handler ()
		{
			if (cb_setQuietTimeInterval_Ljava_util_Date_Ljava_util_Date_ == null)
				cb_setQuietTimeInterval_Ljava_util_Date_Ljava_util_Date_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetQuietTimeInterval_Ljava_util_Date_Ljava_util_Date_);
			return cb_setQuietTimeInterval_Ljava_util_Date_Ljava_util_Date_;
		}

		static void n_SetQuietTimeInterval_Ljava_util_Date_Ljava_util_Date_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			PushPreferences __this = Java.Lang.Object.GetObject<PushPreferences> (native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Util.Date p0 = Java.Lang.Object.GetObject<global::Java.Util.Date> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Util.Date p1 = Java.Lang.Object.GetObject<global::Java.Util.Date> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.SetQuietTimeInterval (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_setQuietTimeInterval_Ljava_util_Date_Ljava_util_Date_;
		[Register ("setQuietTimeInterval", "(Ljava/util/Date;Ljava/util/Date;)V", "GetSetQuietTimeInterval_Ljava_util_Date_Ljava_util_Date_Handler")]
		public virtual void SetQuietTimeInterval (global::Java.Util.Date p0, global::Java.Util.Date p1)
		{
			if (id_setQuietTimeInterval_Ljava_util_Date_Ljava_util_Date_ == IntPtr.Zero)
				id_setQuietTimeInterval_Ljava_util_Date_Ljava_util_Date_ = JNIEnv.GetMethodID (class_ref, "setQuietTimeInterval", "(Ljava/util/Date;Ljava/util/Date;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setQuietTimeInterval_Ljava_util_Date_Ljava_util_Date_, new JValue (p0), new JValue (p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_setQuietTimeInterval_Ljava_util_Date_Ljava_util_Date_, new JValue (p0), new JValue (p1));
		}

	}
}
