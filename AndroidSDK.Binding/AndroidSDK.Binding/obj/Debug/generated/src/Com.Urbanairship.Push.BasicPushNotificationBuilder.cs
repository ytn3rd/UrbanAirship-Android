using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Urbanairship.Push {

	[global::Android.Runtime.Register ("com/urbanairship/push/BasicPushNotificationBuilder", DoNotGenerateAcw=true)]
	public partial class BasicPushNotificationBuilder : global::Java.Lang.Object, global::Com.Urbanairship.Push.IPushNotificationBuilder {


		static IntPtr appName_jfieldId;

		[Register ("appName")]
		public string AppName {
			get {
				if (appName_jfieldId == IntPtr.Zero)
					appName_jfieldId = JNIEnv.GetFieldID (class_ref, "appName", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, appName_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (appName_jfieldId == IntPtr.Zero)
					appName_jfieldId = JNIEnv.GetFieldID (class_ref, "appName", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				JNIEnv.SetField (Handle, appName_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr constantNotificationId_jfieldId;

		[Register ("constantNotificationId")]
		public int ConstantNotificationId {
			get {
				if (constantNotificationId_jfieldId == IntPtr.Zero)
					constantNotificationId_jfieldId = JNIEnv.GetFieldID (class_ref, "constantNotificationId", "I");
				return JNIEnv.GetIntField (Handle, constantNotificationId_jfieldId);
			}
			set {
				if (constantNotificationId_jfieldId == IntPtr.Zero)
					constantNotificationId_jfieldId = JNIEnv.GetFieldID (class_ref, "constantNotificationId", "I");
				JNIEnv.SetField (Handle, constantNotificationId_jfieldId, value);
			}
		}

		static IntPtr iconDrawableId_jfieldId;

		[Register ("iconDrawableId")]
		public int IconDrawableId {
			get {
				if (iconDrawableId_jfieldId == IntPtr.Zero)
					iconDrawableId_jfieldId = JNIEnv.GetFieldID (class_ref, "iconDrawableId", "I");
				return JNIEnv.GetIntField (Handle, iconDrawableId_jfieldId);
			}
			set {
				if (iconDrawableId_jfieldId == IntPtr.Zero)
					iconDrawableId_jfieldId = JNIEnv.GetFieldID (class_ref, "iconDrawableId", "I");
				JNIEnv.SetField (Handle, iconDrawableId_jfieldId, value);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/urbanairship/push/BasicPushNotificationBuilder", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BasicPushNotificationBuilder); }
		}

		protected BasicPushNotificationBuilder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		[Register (".ctor", "()V", "")]
		public BasicPushNotificationBuilder () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (BasicPushNotificationBuilder)) {
				SetHandle (global::Android.Runtime.JNIEnv.CreateInstance (GetType (), "()V"), JniHandleOwnership.TransferLocalRef);
				return;
			}

			if (id_ctor == IntPtr.Zero)
				id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
			SetHandle (JNIEnv.NewObject (class_ref, id_ctor), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_buildNotification_Ljava_lang_String_Ljava_util_Map_;
#pragma warning disable 0169
		static Delegate GetBuildNotification_Ljava_lang_String_Ljava_util_Map_Handler ()
		{
			if (cb_buildNotification_Ljava_lang_String_Ljava_util_Map_ == null)
				cb_buildNotification_Ljava_lang_String_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_BuildNotification_Ljava_lang_String_Ljava_util_Map_);
			return cb_buildNotification_Ljava_lang_String_Ljava_util_Map_;
		}

		static IntPtr n_BuildNotification_Ljava_lang_String_Ljava_util_Map_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			BasicPushNotificationBuilder __this = Java.Lang.Object.GetObject<BasicPushNotificationBuilder> (native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			System.Collections.Generic.IDictionary<string, string> p1 = global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.BuildNotification (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_buildNotification_Ljava_lang_String_Ljava_util_Map_;
		[Register ("buildNotification", "(Ljava/lang/String;Ljava/util/Map;)Landroid/app/Notification;", "GetBuildNotification_Ljava_lang_String_Ljava_util_Map_Handler")]
		public virtual global::Android.App.Notification BuildNotification (string p0, global::System.Collections.Generic.IDictionary<string, string> p1)
		{
			if (id_buildNotification_Ljava_lang_String_Ljava_util_Map_ == IntPtr.Zero)
				id_buildNotification_Ljava_lang_String_Ljava_util_Map_ = JNIEnv.GetMethodID (class_ref, "buildNotification", "(Ljava/lang/String;Ljava/util/Map;)Landroid/app/Notification;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (p1);

			global::Android.App.Notification __ret;
			if (GetType () == ThresholdType)
				__ret = Java.Lang.Object.GetObject<global::Android.App.Notification> (JNIEnv.CallObjectMethod  (Handle, id_buildNotification_Ljava_lang_String_Ljava_util_Map_, new JValue (native_p0), new JValue (native_p1)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = Java.Lang.Object.GetObject<global::Android.App.Notification> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_buildNotification_Ljava_lang_String_Ljava_util_Map_, new JValue (native_p0), new JValue (native_p1)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			return __ret;
		}

		static Delegate cb_getNextId_Ljava_lang_String_Ljava_util_Map_;
#pragma warning disable 0169
		static Delegate GetGetNextId_Ljava_lang_String_Ljava_util_Map_Handler ()
		{
			if (cb_getNextId_Ljava_lang_String_Ljava_util_Map_ == null)
				cb_getNextId_Ljava_lang_String_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, int>) n_GetNextId_Ljava_lang_String_Ljava_util_Map_);
			return cb_getNextId_Ljava_lang_String_Ljava_util_Map_;
		}

		static int n_GetNextId_Ljava_lang_String_Ljava_util_Map_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			BasicPushNotificationBuilder __this = Java.Lang.Object.GetObject<BasicPushNotificationBuilder> (native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			System.Collections.Generic.IDictionary<string, string> p1 = global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (native_p1, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.GetNextId (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getNextId_Ljava_lang_String_Ljava_util_Map_;
		[Register ("getNextId", "(Ljava/lang/String;Ljava/util/Map;)I", "GetGetNextId_Ljava_lang_String_Ljava_util_Map_Handler")]
		public virtual int GetNextId (string p0, global::System.Collections.Generic.IDictionary<string, string> p1)
		{
			if (id_getNextId_Ljava_lang_String_Ljava_util_Map_ == IntPtr.Zero)
				id_getNextId_Ljava_lang_String_Ljava_util_Map_ = JNIEnv.GetMethodID (class_ref, "getNextId", "(Ljava/lang/String;Ljava/util/Map;)I");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (p1);

			int __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallIntMethod  (Handle, id_getNextId_Ljava_lang_String_Ljava_util_Map_, new JValue (native_p0), new JValue (native_p1));
			else
				__ret = JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, id_getNextId_Ljava_lang_String_Ljava_util_Map_, new JValue (native_p0), new JValue (native_p1));
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			return __ret;
		}

	}
}
