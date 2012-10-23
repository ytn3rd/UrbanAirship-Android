using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Urbanairship.Analytics {

	[global::Android.Runtime.Register ("com/urbanairship/analytics/Analytics", DoNotGenerateAcw=true)]
	public partial class Analytics : global::Java.Lang.Object {


		[Register ("ACTION_ANALYTICS_START")]
		public const string ActionAnalyticsStart = (string) "com.urbanairship.analytics.START";

		static IntPtr ACTION_APP_BACKGROUND_jfieldId;

		[Register ("ACTION_APP_BACKGROUND")]
		public static string ActionAppBackground {
			get {
				if (ACTION_APP_BACKGROUND_jfieldId == IntPtr.Zero)
					ACTION_APP_BACKGROUND_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ACTION_APP_BACKGROUND", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ACTION_APP_BACKGROUND_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (ACTION_APP_BACKGROUND_jfieldId == IntPtr.Zero)
					ACTION_APP_BACKGROUND_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ACTION_APP_BACKGROUND", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				JNIEnv.SetStaticField (class_ref, ACTION_APP_BACKGROUND_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr ACTION_APP_FOREGROUND_jfieldId;

		[Register ("ACTION_APP_FOREGROUND")]
		public static string ActionAppForeground {
			get {
				if (ACTION_APP_FOREGROUND_jfieldId == IntPtr.Zero)
					ACTION_APP_FOREGROUND_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ACTION_APP_FOREGROUND", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ACTION_APP_FOREGROUND_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (ACTION_APP_FOREGROUND_jfieldId == IntPtr.Zero)
					ACTION_APP_FOREGROUND_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ACTION_APP_FOREGROUND", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				JNIEnv.SetStaticField (class_ref, ACTION_APP_FOREGROUND_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}
		[global::Android.Runtime.Register ("com/urbanairship/analytics/Analytics$AddEventTask", DoNotGenerateAcw=true)]
		public partial class AddEventTask : global::Android.OS.AsyncTask {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/urbanairship/analytics/Analytics$AddEventTask", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (AddEventTask); }
			}

			protected AddEventTask (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static Delegate cb_doInBackground_arrayLjava_lang_Object_;
#pragma warning disable 0169
			static Delegate GetDoInBackground_arrayLjava_lang_Object_Handler ()
			{
				if (cb_doInBackground_arrayLjava_lang_Object_ == null)
					cb_doInBackground_arrayLjava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_DoInBackground_arrayLjava_lang_Object_);
				return cb_doInBackground_arrayLjava_lang_Object_;
			}

			static IntPtr n_DoInBackground_arrayLjava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				AddEventTask __this = Java.Lang.Object.GetObject<AddEventTask> (native__this, JniHandleOwnership.DoNotTransfer);
				Java.Lang.Object[] p0 = (Java.Lang.Object[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (Java.Lang.Object));
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.DoInBackground (p0));
				if (p0 != null)
					JNIEnv.CopyArray (p0, native_p0);
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_doInBackground_arrayLjava_lang_Object_;
			[Register ("doInBackground", "([Ljava/lang/Object;)Ljava/lang/Object;", "GetDoInBackground_arrayLjava_lang_Object_Handler")]
			protected override global::Java.Lang.Object DoInBackground (global::Java.Lang.Object[] p0)
			{
				if (id_doInBackground_arrayLjava_lang_Object_ == IntPtr.Zero)
					id_doInBackground_arrayLjava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "doInBackground", "([Ljava/lang/Object;)Ljava/lang/Object;");
				IntPtr native_p0 = JNIEnv.NewArray (p0);

				global::Java.Lang.Object __ret;
				if (GetType () == ThresholdType)
					__ret = Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod  (Handle, id_doInBackground_arrayLjava_lang_Object_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
				else
					__ret = Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_doInBackground_arrayLjava_lang_Object_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				return __ret;
			}

		}

		[global::Android.Runtime.Register ("com/urbanairship/analytics/Analytics$Session", DoNotGenerateAcw=true)]
		public partial class Session : global::Java.Lang.Object {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/urbanairship/analytics/Analytics$Session", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Session); }
			}

			protected Session (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lcom_urbanairship_analytics_Analytics_;
			[Register (".ctor", "(Lcom/urbanairship/analytics/Analytics;)V", "")]
			public Session (global::Com.Urbanairship.Analytics.Analytics __self) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				if (GetType () != typeof (Session)) {
					SetHandle (global::Android.Runtime.JNIEnv.CreateInstance (GetType (), "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";)V", new JValue (__self)), JniHandleOwnership.TransferLocalRef);
					return;
				}

				if (id_ctor_Lcom_urbanairship_analytics_Analytics_ == IntPtr.Zero)
					id_ctor_Lcom_urbanairship_analytics_Analytics_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/urbanairship/analytics/Analytics;)V");
				SetHandle (JNIEnv.NewObject (class_ref, id_ctor_Lcom_urbanairship_analytics_Analytics_, new JValue (__self)), JniHandleOwnership.TransferLocalRef);
			}

			static Delegate cb_getId;
#pragma warning disable 0169
			static Delegate GetGetIdHandler ()
			{
				if (cb_getId == null)
					cb_getId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetId);
				return cb_getId;
			}

			static IntPtr n_GetId (IntPtr jnienv, IntPtr native__this)
			{
				Session __this = Java.Lang.Object.GetObject<Session> (native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.Id);
			}
#pragma warning restore 0169

			static IntPtr id_getId;
			public virtual string Id {
				[Register ("getId", "()Ljava/lang/String;", "GetGetIdHandler")]
				get {
					if (id_getId == IntPtr.Zero)
						id_getId = JNIEnv.GetMethodID (class_ref, "getId", "()Ljava/lang/String;");

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getId), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getId), JniHandleOwnership.TransferLocalRef);
				}
			}

			static Delegate cb_log;
#pragma warning disable 0169
			static Delegate GetLogHandler ()
			{
				if (cb_log == null)
					cb_log = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Log);
				return cb_log;
			}

			static void n_Log (IntPtr jnienv, IntPtr native__this)
			{
				Session __this = Java.Lang.Object.GetObject<Session> (native__this, JniHandleOwnership.DoNotTransfer);
				__this.Log ();
			}
#pragma warning restore 0169

			static IntPtr id_log;
			[Register ("log", "()V", "GetLogHandler")]
			public virtual void Log ()
			{
				if (id_log == IntPtr.Zero)
					id_log = JNIEnv.GetMethodID (class_ref, "log", "()V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_log);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_log);
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/urbanairship/analytics/Analytics", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Analytics); }
		}

		protected Analytics (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		[Register (".ctor", "()V", "")]
		public Analytics () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (Analytics)) {
				SetHandle (global::Android.Runtime.JNIEnv.CreateInstance (GetType (), "()V"), JniHandleOwnership.TransferLocalRef);
				return;
			}

			if (id_ctor == IntPtr.Zero)
				id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
			SetHandle (JNIEnv.NewObject (class_ref, id_ctor), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_getConversionPushId;
#pragma warning disable 0169
		static Delegate GetGetConversionPushIdHandler ()
		{
			if (cb_getConversionPushId == null)
				cb_getConversionPushId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetConversionPushId);
			return cb_getConversionPushId;
		}

		static IntPtr n_GetConversionPushId (IntPtr jnienv, IntPtr native__this)
		{
			Analytics __this = Java.Lang.Object.GetObject<Analytics> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ConversionPushId);
		}
#pragma warning restore 0169

		static Delegate cb_setConversionPushId_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetConversionPushId_Ljava_lang_String_Handler ()
		{
			if (cb_setConversionPushId_Ljava_lang_String_ == null)
				cb_setConversionPushId_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetConversionPushId_Ljava_lang_String_);
			return cb_setConversionPushId_Ljava_lang_String_;
		}

		static void n_SetConversionPushId_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			Analytics __this = Java.Lang.Object.GetObject<Analytics> (native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ConversionPushId = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getConversionPushId;
		static IntPtr id_setConversionPushId_Ljava_lang_String_;
		public virtual string ConversionPushId {
			[Register ("getConversionPushId", "()Ljava/lang/String;", "GetGetConversionPushIdHandler")]
			get {
				if (id_getConversionPushId == IntPtr.Zero)
					id_getConversionPushId = JNIEnv.GetMethodID (class_ref, "getConversionPushId", "()Ljava/lang/String;");

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getConversionPushId), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getConversionPushId), JniHandleOwnership.TransferLocalRef);
			}
			[Register ("setConversionPushId", "(Ljava/lang/String;)V", "GetSetConversionPushId_Ljava_lang_String_Handler")]
			set {
				if (id_setConversionPushId_Ljava_lang_String_ == IntPtr.Zero)
					id_setConversionPushId_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setConversionPushId", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setConversionPushId_Ljava_lang_String_, new JValue (native_value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_setConversionPushId_Ljava_lang_String_, new JValue (native_value));
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr id_getHashedDeviceId;
		public static string HashedDeviceId {
			[Register ("getHashedDeviceId", "()Ljava/lang/String;", "GetGetHashedDeviceIdHandler")]
			get {
				if (id_getHashedDeviceId == IntPtr.Zero)
					id_getHashedDeviceId = JNIEnv.GetStaticMethodID (class_ref, "getHashedDeviceId", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getHashedDeviceId), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_isAppInForeground;
#pragma warning disable 0169
		static Delegate GetIsAppInForegroundHandler ()
		{
			if (cb_isAppInForeground == null)
				cb_isAppInForeground = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsAppInForeground);
			return cb_isAppInForeground;
		}

		static bool n_IsAppInForeground (IntPtr jnienv, IntPtr native__this)
		{
			Analytics __this = Java.Lang.Object.GetObject<Analytics> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsAppInForeground;
		}
#pragma warning restore 0169

		static IntPtr id_isAppInForeground;
		public virtual bool IsAppInForeground {
			[Register ("isAppInForeground", "()Z", "GetIsAppInForegroundHandler")]
			get {
				if (id_isAppInForeground == IntPtr.Zero)
					id_isAppInForeground = JNIEnv.GetMethodID (class_ref, "isAppInForeground", "()Z");

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_isAppInForeground);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, id_isAppInForeground);
			}
		}

		static Delegate cb_activityStarted_Landroid_app_Activity_;
#pragma warning disable 0169
		static Delegate GetActivityStarted_Landroid_app_Activity_Handler ()
		{
			if (cb_activityStarted_Landroid_app_Activity_ == null)
				cb_activityStarted_Landroid_app_Activity_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_ActivityStarted_Landroid_app_Activity_);
			return cb_activityStarted_Landroid_app_Activity_;
		}

		static void n_ActivityStarted_Landroid_app_Activity_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			Analytics __this = Java.Lang.Object.GetObject<Analytics> (native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.App.Activity p0 = Java.Lang.Object.GetObject<global::Android.App.Activity> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ActivityStarted (p0);
		}
#pragma warning restore 0169

		static IntPtr id_activityStarted_Landroid_app_Activity_;
		[Register ("activityStarted", "(Landroid/app/Activity;)V", "GetActivityStarted_Landroid_app_Activity_Handler")]
		public virtual void ActivityStarted (global::Android.App.Activity p0)
		{
			if (id_activityStarted_Landroid_app_Activity_ == IntPtr.Zero)
				id_activityStarted_Landroid_app_Activity_ = JNIEnv.GetMethodID (class_ref, "activityStarted", "(Landroid/app/Activity;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_activityStarted_Landroid_app_Activity_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_activityStarted_Landroid_app_Activity_, new JValue (p0));
		}

		static Delegate cb_activityStopped_Landroid_app_Activity_;
#pragma warning disable 0169
		static Delegate GetActivityStopped_Landroid_app_Activity_Handler ()
		{
			if (cb_activityStopped_Landroid_app_Activity_ == null)
				cb_activityStopped_Landroid_app_Activity_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_ActivityStopped_Landroid_app_Activity_);
			return cb_activityStopped_Landroid_app_Activity_;
		}

		static void n_ActivityStopped_Landroid_app_Activity_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			Analytics __this = Java.Lang.Object.GetObject<Analytics> (native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.App.Activity p0 = Java.Lang.Object.GetObject<global::Android.App.Activity> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ActivityStopped (p0);
		}
#pragma warning restore 0169

		static IntPtr id_activityStopped_Landroid_app_Activity_;
		[Register ("activityStopped", "(Landroid/app/Activity;)V", "GetActivityStopped_Landroid_app_Activity_Handler")]
		public virtual void ActivityStopped (global::Android.App.Activity p0)
		{
			if (id_activityStopped_Landroid_app_Activity_ == IntPtr.Zero)
				id_activityStopped_Landroid_app_Activity_ = JNIEnv.GetMethodID (class_ref, "activityStopped", "(Landroid/app/Activity;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_activityStopped_Landroid_app_Activity_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_activityStopped_Landroid_app_Activity_, new JValue (p0));
		}

		static Delegate cb_addEvent_Lcom_urbanairship_analytics_Event_;
#pragma warning disable 0169
		static Delegate GetAddEvent_Lcom_urbanairship_analytics_Event_Handler ()
		{
			if (cb_addEvent_Lcom_urbanairship_analytics_Event_ == null)
				cb_addEvent_Lcom_urbanairship_analytics_Event_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_AddEvent_Lcom_urbanairship_analytics_Event_);
			return cb_addEvent_Lcom_urbanairship_analytics_Event_;
		}

		static void n_AddEvent_Lcom_urbanairship_analytics_Event_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			Analytics __this = Java.Lang.Object.GetObject<Analytics> (native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Urbanairship.Analytics.Event p0 = Java.Lang.Object.GetObject<global::Com.Urbanairship.Analytics.Event> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AddEvent (p0);
		}
#pragma warning restore 0169

		static IntPtr id_addEvent_Lcom_urbanairship_analytics_Event_;
		[Register ("addEvent", "(Lcom/urbanairship/analytics/Event;)V", "GetAddEvent_Lcom_urbanairship_analytics_Event_Handler")]
		public virtual void AddEvent (global::Com.Urbanairship.Analytics.Event p0)
		{
			if (id_addEvent_Lcom_urbanairship_analytics_Event_ == IntPtr.Zero)
				id_addEvent_Lcom_urbanairship_analytics_Event_ = JNIEnv.GetMethodID (class_ref, "addEvent", "(Lcom/urbanairship/analytics/Event;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_addEvent_Lcom_urbanairship_analytics_Event_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_addEvent_Lcom_urbanairship_analytics_Event_, new JValue (p0));
		}

		static Delegate cb_startUploadingIfNecessary;
#pragma warning disable 0169
		static Delegate GetStartUploadingIfNecessaryHandler ()
		{
			if (cb_startUploadingIfNecessary == null)
				cb_startUploadingIfNecessary = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_StartUploadingIfNecessary);
			return cb_startUploadingIfNecessary;
		}

		static void n_StartUploadingIfNecessary (IntPtr jnienv, IntPtr native__this)
		{
			Analytics __this = Java.Lang.Object.GetObject<Analytics> (native__this, JniHandleOwnership.DoNotTransfer);
			__this.StartUploadingIfNecessary ();
		}
#pragma warning restore 0169

		static IntPtr id_startUploadingIfNecessary;
		[Register ("startUploadingIfNecessary", "()V", "GetStartUploadingIfNecessaryHandler")]
		public virtual void StartUploadingIfNecessary ()
		{
			if (id_startUploadingIfNecessary == IntPtr.Zero)
				id_startUploadingIfNecessary = JNIEnv.GetMethodID (class_ref, "startUploadingIfNecessary", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_startUploadingIfNecessary);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_startUploadingIfNecessary);
		}

	}
}
