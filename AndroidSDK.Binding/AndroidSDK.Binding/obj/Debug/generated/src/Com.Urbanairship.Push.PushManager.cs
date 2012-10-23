using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Urbanairship.Push {

	[global::Android.Runtime.Register ("com/urbanairship/push/PushManager", DoNotGenerateAcw=true)]
	public partial class PushManager : global::Java.Lang.Object {


		[Register ("ACTION_GCM_DELETED_MESSAGES")]
		public const string ActionGcmDeletedMessages = (string) "com.urbanairship.push.ACTION_GCM_DELETED_MESSAGES";

		[Register ("ACTION_NOTIFICATION_OPENED")]
		public const string ActionNotificationOpened = (string) "com.urbanairship.push.NOTIFICATION_OPENED";

		[Register ("ACTION_NOTIFICATION_OPENED_PROXY")]
		public const string ActionNotificationOpenedProxy = (string) "com.urbanairship.push.NOTIFICATION_OPENED_PROXY";

		[Register ("ACTION_PUSH_RECEIVED")]
		public const string ActionPushReceived = (string) "com.urbanairship.push.PUSH_RECEIVED";

		[Register ("ACTION_REGISTRATION_FINISHED")]
		public const string ActionRegistrationFinished = (string) "com.urbanairship.push.REGISTRATION_FINISHED";

		[Register ("EXTRA_ALERT")]
		public const string ExtraAlert = (string) "com.urbanairship.push.ALERT";

		[Register ("EXTRA_APID")]
		public const string ExtraApid = (string) "com.urbanairship.push.APID";

		[Register ("EXTRA_EXPIRATION")]
		public const string ExtraExpiration = (string) "com.urbanairship.push.EXPIRATION";

		[Register ("EXTRA_GCM_MESSAGE_TYPE")]
		public const string ExtraGcmMessageType = (string) "message_type";

		[Register ("EXTRA_GCM_REGISTRATION_ID")]
		public const string ExtraGcmRegistrationId = (string) "com.urbanairship.push.GCM_REGISTRATION_ID";

		[Register ("EXTRA_GCM_TOTAL_DELETED")]
		public const string ExtraGcmTotalDeleted = (string) "total_deleted";

		[Register ("EXTRA_NOTIFICATION_ID")]
		public const string ExtraNotificationId = (string) "com.urbanairship.push.NOTIFICATION_ID";

		[Register ("EXTRA_PUSH_ID")]
		public const string ExtraPushId = (string) "com.urbanairship.push.PUSH_ID";

		[Register ("EXTRA_REGISTRATION_ERROR")]
		public const string ExtraRegistrationError = (string) "com.urbanairship.push.REGISTRATION_ERROR";

		[Register ("EXTRA_REGISTRATION_VALID")]
		public const string ExtraRegistrationValid = (string) "com.urbanairship.push.REGISTRATION_VALID";

		[Register ("EXTRA_STRING_EXTRA")]
		[Obsolete ("deprecated")]
		public const string ExtraStringExtra = (string) "com.urbanairship.push.STRING_EXTRA";

		[Register ("GCM_DELETED_MESSAGES_VALUE")]
		public const string GcmDeletedMessagesValue = (string) "deleted_messages";
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/urbanairship/push/PushManager", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (PushManager); }
		}

		protected PushManager (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

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
			PushManager __this = Java.Lang.Object.GetObject<PushManager> (native__this, JniHandleOwnership.DoNotTransfer);
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
			PushManager __this = Java.Lang.Object.GetObject<PushManager> (native__this, JniHandleOwnership.DoNotTransfer);
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

		static Delegate cb_getAPID;
#pragma warning disable 0169
		static Delegate GetGetAPIDHandler ()
		{
			if (cb_getAPID == null)
				cb_getAPID = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAPID);
			return cb_getAPID;
		}

		static IntPtr n_GetAPID (IntPtr jnienv, IntPtr native__this)
		{
			PushManager __this = Java.Lang.Object.GetObject<PushManager> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.APID);
		}
#pragma warning restore 0169

		static IntPtr id_getAPID;
		public virtual string APID {
			[Register ("getAPID", "()Ljava/lang/String;", "GetGetAPIDHandler")]
			get {
				if (id_getAPID == IntPtr.Zero)
					id_getAPID = JNIEnv.GetMethodID (class_ref, "getAPID", "()Ljava/lang/String;");

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getAPID), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getAPID), JniHandleOwnership.TransferLocalRef);
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
			PushManager __this = Java.Lang.Object.GetObject<PushManager> (native__this, JniHandleOwnership.DoNotTransfer);
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
			PushManager __this = Java.Lang.Object.GetObject<PushManager> (native__this, JniHandleOwnership.DoNotTransfer);
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

		static Delegate cb_getIntentReceiver;
#pragma warning disable 0169
		static Delegate GetGetIntentReceiverHandler ()
		{
			if (cb_getIntentReceiver == null)
				cb_getIntentReceiver = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetIntentReceiver);
			return cb_getIntentReceiver;
		}

		static IntPtr n_GetIntentReceiver (IntPtr jnienv, IntPtr native__this)
		{
			PushManager __this = Java.Lang.Object.GetObject<PushManager> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.IntentReceiver);
		}
#pragma warning restore 0169

		static Delegate cb_setIntentReceiver_Ljava_lang_Class_;
#pragma warning disable 0169
		static Delegate GetSetIntentReceiver_Ljava_lang_Class_Handler ()
		{
			if (cb_setIntentReceiver_Ljava_lang_Class_ == null)
				cb_setIntentReceiver_Ljava_lang_Class_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetIntentReceiver_Ljava_lang_Class_);
			return cb_setIntentReceiver_Ljava_lang_Class_;
		}

		static void n_SetIntentReceiver_Ljava_lang_Class_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			PushManager __this = Java.Lang.Object.GetObject<PushManager> (native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Class p0 = Java.Lang.Object.GetObject<global::Java.Lang.Class> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.IntentReceiver = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getIntentReceiver;
		static IntPtr id_setIntentReceiver_Ljava_lang_Class_;
		public virtual global::Java.Lang.Class IntentReceiver {
			[Register ("getIntentReceiver", "()Ljava/lang/Class;", "GetGetIntentReceiverHandler")]
			get {
				if (id_getIntentReceiver == IntPtr.Zero)
					id_getIntentReceiver = JNIEnv.GetMethodID (class_ref, "getIntentReceiver", "()Ljava/lang/Class;");

				if (GetType () == ThresholdType)
					return Java.Lang.Object.GetObject<global::Java.Lang.Class> (JNIEnv.CallObjectMethod  (Handle, id_getIntentReceiver), JniHandleOwnership.TransferLocalRef);
				else
					return Java.Lang.Object.GetObject<global::Java.Lang.Class> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getIntentReceiver), JniHandleOwnership.TransferLocalRef);
			}
			[Register ("setIntentReceiver", "(Ljava/lang/Class;)V", "GetSetIntentReceiver_Ljava_lang_Class_Handler")]
			set {
				if (id_setIntentReceiver_Ljava_lang_Class_ == IntPtr.Zero)
					id_setIntentReceiver_Ljava_lang_Class_ = JNIEnv.GetMethodID (class_ref, "setIntentReceiver", "(Ljava/lang/Class;)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setIntentReceiver_Ljava_lang_Class_, new JValue (value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_setIntentReceiver_Ljava_lang_Class_, new JValue (value));
			}
		}

		static Delegate cb_getNotificationBuilder;
#pragma warning disable 0169
		static Delegate GetGetNotificationBuilderHandler ()
		{
			if (cb_getNotificationBuilder == null)
				cb_getNotificationBuilder = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetNotificationBuilder);
			return cb_getNotificationBuilder;
		}

		static IntPtr n_GetNotificationBuilder (IntPtr jnienv, IntPtr native__this)
		{
			PushManager __this = Java.Lang.Object.GetObject<PushManager> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.NotificationBuilder);
		}
#pragma warning restore 0169

		static Delegate cb_setNotificationBuilder_Lcom_urbanairship_push_PushNotificationBuilder_;
#pragma warning disable 0169
		static Delegate GetSetNotificationBuilder_Lcom_urbanairship_push_PushNotificationBuilder_Handler ()
		{
			if (cb_setNotificationBuilder_Lcom_urbanairship_push_PushNotificationBuilder_ == null)
				cb_setNotificationBuilder_Lcom_urbanairship_push_PushNotificationBuilder_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetNotificationBuilder_Lcom_urbanairship_push_PushNotificationBuilder_);
			return cb_setNotificationBuilder_Lcom_urbanairship_push_PushNotificationBuilder_;
		}

		static void n_SetNotificationBuilder_Lcom_urbanairship_push_PushNotificationBuilder_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			PushManager __this = Java.Lang.Object.GetObject<PushManager> (native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Urbanairship.Push.IPushNotificationBuilder p0 = Java.Lang.Object.GetObject<global::Com.Urbanairship.Push.IPushNotificationBuilder> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.NotificationBuilder = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getNotificationBuilder;
		static IntPtr id_setNotificationBuilder_Lcom_urbanairship_push_PushNotificationBuilder_;
		public virtual global::Com.Urbanairship.Push.IPushNotificationBuilder NotificationBuilder {
			[Register ("getNotificationBuilder", "()Lcom/urbanairship/push/PushNotificationBuilder;", "GetGetNotificationBuilderHandler")]
			get {
				if (id_getNotificationBuilder == IntPtr.Zero)
					id_getNotificationBuilder = JNIEnv.GetMethodID (class_ref, "getNotificationBuilder", "()Lcom/urbanairship/push/PushNotificationBuilder;");

				if (GetType () == ThresholdType)
					return Java.Lang.Object.GetObject<global::Com.Urbanairship.Push.IPushNotificationBuilder> (JNIEnv.CallObjectMethod  (Handle, id_getNotificationBuilder), JniHandleOwnership.TransferLocalRef);
				else
					return Java.Lang.Object.GetObject<global::Com.Urbanairship.Push.IPushNotificationBuilder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getNotificationBuilder), JniHandleOwnership.TransferLocalRef);
			}
			[Register ("setNotificationBuilder", "(Lcom/urbanairship/push/PushNotificationBuilder;)V", "GetSetNotificationBuilder_Lcom_urbanairship_push_PushNotificationBuilder_Handler")]
			set {
				if (id_setNotificationBuilder_Lcom_urbanairship_push_PushNotificationBuilder_ == IntPtr.Zero)
					id_setNotificationBuilder_Lcom_urbanairship_push_PushNotificationBuilder_ = JNIEnv.GetMethodID (class_ref, "setNotificationBuilder", "(Lcom/urbanairship/push/PushNotificationBuilder;)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setNotificationBuilder_Lcom_urbanairship_push_PushNotificationBuilder_, new JValue (value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_setNotificationBuilder_Lcom_urbanairship_push_PushNotificationBuilder_, new JValue (value));
			}
		}

		static Delegate cb_getPreferences;
#pragma warning disable 0169
		static Delegate GetGetPreferencesHandler ()
		{
			if (cb_getPreferences == null)
				cb_getPreferences = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPreferences);
			return cb_getPreferences;
		}

		static IntPtr n_GetPreferences (IntPtr jnienv, IntPtr native__this)
		{
			PushManager __this = Java.Lang.Object.GetObject<PushManager> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Preferences);
		}
#pragma warning restore 0169

		static IntPtr id_getPreferences;
		public virtual global::Com.Urbanairship.Push.PushPreferences Preferences {
			[Register ("getPreferences", "()Lcom/urbanairship/push/PushPreferences;", "GetGetPreferencesHandler")]
			get {
				if (id_getPreferences == IntPtr.Zero)
					id_getPreferences = JNIEnv.GetMethodID (class_ref, "getPreferences", "()Lcom/urbanairship/push/PushPreferences;");

				if (GetType () == ThresholdType)
					return Java.Lang.Object.GetObject<global::Com.Urbanairship.Push.PushPreferences> (JNIEnv.CallObjectMethod  (Handle, id_getPreferences), JniHandleOwnership.TransferLocalRef);
				else
					return Java.Lang.Object.GetObject<global::Com.Urbanairship.Push.PushPreferences> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getPreferences), JniHandleOwnership.TransferLocalRef);
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
			PushManager __this = Java.Lang.Object.GetObject<PushManager> (native__this, JniHandleOwnership.DoNotTransfer);
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
			PushManager __this = Java.Lang.Object.GetObject<PushManager> (native__this, JniHandleOwnership.DoNotTransfer);
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

		static IntPtr id_deliverPush_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_;
		[Register ("deliverPush", "(Ljava/lang/String;Ljava/lang/String;Ljava/util/Map;)V", "")]
		public static void DeliverPush (string p0, string p1, global::System.Collections.Generic.IDictionary<string, string> p2)
		{
			if (id_deliverPush_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_ == IntPtr.Zero)
				id_deliverPush_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_ = JNIEnv.GetStaticMethodID (class_ref, "deliverPush", "(Ljava/lang/String;Ljava/lang/String;Ljava/util/Map;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (p2);
			JNIEnv.CallStaticVoidMethod  (class_ref, id_deliverPush_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_, new JValue (native_p0), new JValue (native_p1), new JValue (native_p2));
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			JNIEnv.DeleteLocalRef (native_p2);
		}

		static IntPtr id_disablePush;
		[Register ("disablePush", "()V", "")]
		public static void DisablePush ()
		{
			if (id_disablePush == IntPtr.Zero)
				id_disablePush = JNIEnv.GetStaticMethodID (class_ref, "disablePush", "()V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_disablePush);
		}

		static IntPtr id_enablePush;
		[Register ("enablePush", "()V", "")]
		public static void EnablePush ()
		{
			if (id_enablePush == IntPtr.Zero)
				id_enablePush = JNIEnv.GetStaticMethodID (class_ref, "enablePush", "()V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_enablePush);
		}

		static Delegate cb_gcmRegistrationFailed_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGcmRegistrationFailed_Ljava_lang_String_Handler ()
		{
			if (cb_gcmRegistrationFailed_Ljava_lang_String_ == null)
				cb_gcmRegistrationFailed_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_GcmRegistrationFailed_Ljava_lang_String_);
			return cb_gcmRegistrationFailed_Ljava_lang_String_;
		}

		static void n_GcmRegistrationFailed_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			PushManager __this = Java.Lang.Object.GetObject<PushManager> (native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.GcmRegistrationFailed (p0);
		}
#pragma warning restore 0169

		static IntPtr id_gcmRegistrationFailed_Ljava_lang_String_;
		[Register ("gcmRegistrationFailed", "(Ljava/lang/String;)V", "GetGcmRegistrationFailed_Ljava_lang_String_Handler")]
		public virtual void GcmRegistrationFailed (string p0)
		{
			if (id_gcmRegistrationFailed_Ljava_lang_String_ == IntPtr.Zero)
				id_gcmRegistrationFailed_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "gcmRegistrationFailed", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_gcmRegistrationFailed_Ljava_lang_String_, new JValue (native_p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_gcmRegistrationFailed_Ljava_lang_String_, new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_gcmRegistrationResponseReceived_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGcmRegistrationResponseReceived_Ljava_lang_String_Handler ()
		{
			if (cb_gcmRegistrationResponseReceived_Ljava_lang_String_ == null)
				cb_gcmRegistrationResponseReceived_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_GcmRegistrationResponseReceived_Ljava_lang_String_);
			return cb_gcmRegistrationResponseReceived_Ljava_lang_String_;
		}

		static void n_GcmRegistrationResponseReceived_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			PushManager __this = Java.Lang.Object.GetObject<PushManager> (native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.GcmRegistrationResponseReceived (p0);
		}
#pragma warning restore 0169

		static IntPtr id_gcmRegistrationResponseReceived_Ljava_lang_String_;
		[Register ("gcmRegistrationResponseReceived", "(Ljava/lang/String;)V", "GetGcmRegistrationResponseReceived_Ljava_lang_String_Handler")]
		public virtual void GcmRegistrationResponseReceived (string p0)
		{
			if (id_gcmRegistrationResponseReceived_Ljava_lang_String_ == IntPtr.Zero)
				id_gcmRegistrationResponseReceived_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "gcmRegistrationResponseReceived", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_gcmRegistrationResponseReceived_Ljava_lang_String_, new JValue (native_p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_gcmRegistrationResponseReceived_Ljava_lang_String_, new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_heliumRegistrationResponseReceived_Z;
#pragma warning disable 0169
		static Delegate GetHeliumRegistrationResponseReceived_ZHandler ()
		{
			if (cb_heliumRegistrationResponseReceived_Z == null)
				cb_heliumRegistrationResponseReceived_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_HeliumRegistrationResponseReceived_Z);
			return cb_heliumRegistrationResponseReceived_Z;
		}

		static void n_HeliumRegistrationResponseReceived_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			PushManager __this = Java.Lang.Object.GetObject<PushManager> (native__this, JniHandleOwnership.DoNotTransfer);
			__this.HeliumRegistrationResponseReceived (p0);
		}
#pragma warning restore 0169

		static IntPtr id_heliumRegistrationResponseReceived_Z;
		[Register ("heliumRegistrationResponseReceived", "(Z)V", "GetHeliumRegistrationResponseReceived_ZHandler")]
		public virtual void HeliumRegistrationResponseReceived (bool p0)
		{
			if (id_heliumRegistrationResponseReceived_Z == IntPtr.Zero)
				id_heliumRegistrationResponseReceived_Z = JNIEnv.GetMethodID (class_ref, "heliumRegistrationResponseReceived", "(Z)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_heliumRegistrationResponseReceived_Z, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_heliumRegistrationResponseReceived_Z, new JValue (p0));
		}

		static IntPtr id_init;
		[Register ("init", "()V", "")]
		public static void Init ()
		{
			if (id_init == IntPtr.Zero)
				id_init = JNIEnv.GetStaticMethodID (class_ref, "init", "()V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_init);
		}

		static Delegate cb_sendRegistrationFinishedBroadcast_Z;
#pragma warning disable 0169
		static Delegate GetSendRegistrationFinishedBroadcast_ZHandler ()
		{
			if (cb_sendRegistrationFinishedBroadcast_Z == null)
				cb_sendRegistrationFinishedBroadcast_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SendRegistrationFinishedBroadcast_Z);
			return cb_sendRegistrationFinishedBroadcast_Z;
		}

		static void n_SendRegistrationFinishedBroadcast_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			PushManager __this = Java.Lang.Object.GetObject<PushManager> (native__this, JniHandleOwnership.DoNotTransfer);
			__this.SendRegistrationFinishedBroadcast (p0);
		}
#pragma warning restore 0169

		static IntPtr id_sendRegistrationFinishedBroadcast_Z;
		[Register ("sendRegistrationFinishedBroadcast", "(Z)V", "GetSendRegistrationFinishedBroadcast_ZHandler")]
		public virtual void SendRegistrationFinishedBroadcast (bool p0)
		{
			if (id_sendRegistrationFinishedBroadcast_Z == IntPtr.Zero)
				id_sendRegistrationFinishedBroadcast_Z = JNIEnv.GetMethodID (class_ref, "sendRegistrationFinishedBroadcast", "(Z)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_sendRegistrationFinishedBroadcast_Z, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_sendRegistrationFinishedBroadcast_Z, new JValue (p0));
		}

		static Delegate cb_setAliasAndTags_Ljava_lang_String_Ljava_util_Set_;
#pragma warning disable 0169
		static Delegate GetSetAliasAndTags_Ljava_lang_String_Ljava_util_Set_Handler ()
		{
			if (cb_setAliasAndTags_Ljava_lang_String_Ljava_util_Set_ == null)
				cb_setAliasAndTags_Ljava_lang_String_Ljava_util_Set_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetAliasAndTags_Ljava_lang_String_Ljava_util_Set_);
			return cb_setAliasAndTags_Ljava_lang_String_Ljava_util_Set_;
		}

		static void n_SetAliasAndTags_Ljava_lang_String_Ljava_util_Set_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			PushManager __this = Java.Lang.Object.GetObject<PushManager> (native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			System.Collections.Generic.ICollection<string> p1 = global::Android.Runtime.JavaSet<string>.FromJniHandle (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.SetAliasAndTags (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_setAliasAndTags_Ljava_lang_String_Ljava_util_Set_;
		[Register ("setAliasAndTags", "(Ljava/lang/String;Ljava/util/Set;)V", "GetSetAliasAndTags_Ljava_lang_String_Ljava_util_Set_Handler")]
		public virtual void SetAliasAndTags (string p0, global::System.Collections.Generic.ICollection<string> p1)
		{
			if (id_setAliasAndTags_Ljava_lang_String_Ljava_util_Set_ == IntPtr.Zero)
				id_setAliasAndTags_Ljava_lang_String_Ljava_util_Set_ = JNIEnv.GetMethodID (class_ref, "setAliasAndTags", "(Ljava/lang/String;Ljava/util/Set;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = global::Android.Runtime.JavaSet<string>.ToLocalJniHandle (p1);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setAliasAndTags_Ljava_lang_String_Ljava_util_Set_, new JValue (native_p0), new JValue (native_p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_setAliasAndTags_Ljava_lang_String_Ljava_util_Set_, new JValue (native_p0), new JValue (native_p1));
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static IntPtr id_shared;
		[Register ("shared", "()Lcom/urbanairship/push/PushManager;", "")]
		public static global::Com.Urbanairship.Push.PushManager Shared ()
		{
			if (id_shared == IntPtr.Zero)
				id_shared = JNIEnv.GetStaticMethodID (class_ref, "shared", "()Lcom/urbanairship/push/PushManager;");
			return Java.Lang.Object.GetObject<global::Com.Urbanairship.Push.PushManager> (JNIEnv.CallStaticObjectMethod  (class_ref, id_shared), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_startService;
		[Register ("startService", "()V", "")]
		public static void StartService ()
		{
			if (id_startService == IntPtr.Zero)
				id_startService = JNIEnv.GetStaticMethodID (class_ref, "startService", "()V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_startService);
		}

		static IntPtr id_stopService;
		[Register ("stopService", "()V", "")]
		public static void StopService ()
		{
			if (id_stopService == IntPtr.Zero)
				id_stopService = JNIEnv.GetStaticMethodID (class_ref, "stopService", "()V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_stopService);
		}

		static Delegate cb_updateApidIfNecessary;
#pragma warning disable 0169
		static Delegate GetUpdateApidIfNecessaryHandler ()
		{
			if (cb_updateApidIfNecessary == null)
				cb_updateApidIfNecessary = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_UpdateApidIfNecessary);
			return cb_updateApidIfNecessary;
		}

		static void n_UpdateApidIfNecessary (IntPtr jnienv, IntPtr native__this)
		{
			PushManager __this = Java.Lang.Object.GetObject<PushManager> (native__this, JniHandleOwnership.DoNotTransfer);
			__this.UpdateApidIfNecessary ();
		}
#pragma warning restore 0169

		static IntPtr id_updateApidIfNecessary;
		[Register ("updateApidIfNecessary", "()V", "GetUpdateApidIfNecessaryHandler")]
		public virtual void UpdateApidIfNecessary ()
		{
			if (id_updateApidIfNecessary == IntPtr.Zero)
				id_updateApidIfNecessary = JNIEnv.GetMethodID (class_ref, "updateApidIfNecessary", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_updateApidIfNecessary);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_updateApidIfNecessary);
		}

		static IntPtr id_validateManifest;
		[Register ("validateManifest", "()V", "")]
		public static void ValidateManifest ()
		{
			if (id_validateManifest == IntPtr.Zero)
				id_validateManifest = JNIEnv.GetStaticMethodID (class_ref, "validateManifest", "()V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_validateManifest);
		}

	}
}
