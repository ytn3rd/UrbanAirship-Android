using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Urbanairship.Push {

	[Register ("com/urbanairship/push/PushNotificationBuilder", "", "Com.Urbanairship.Push.IPushNotificationBuilderInvoker")]
	public partial interface IPushNotificationBuilder : IJavaObject {

		[Register ("buildNotification", "(Ljava/lang/String;Ljava/util/Map;)Landroid/app/Notification;", "GetBuildNotification_Ljava_lang_String_Ljava_util_Map_Handler:Com.Urbanairship.Push.IPushNotificationBuilderInvoker, AndroidSDK.Binding")]
		global::Android.App.Notification BuildNotification (string p0, global::System.Collections.Generic.IDictionary<string, string> p1);

		[Register ("getNextId", "(Ljava/lang/String;Ljava/util/Map;)I", "GetGetNextId_Ljava_lang_String_Ljava_util_Map_Handler:Com.Urbanairship.Push.IPushNotificationBuilderInvoker, AndroidSDK.Binding")]
		int GetNextId (string p0, global::System.Collections.Generic.IDictionary<string, string> p1);

	}

	[global::Android.Runtime.Register ("com/urbanairship/push/PushNotificationBuilder", DoNotGenerateAcw=true)]
	internal class IPushNotificationBuilderInvoker : Java.Lang.Object, IPushNotificationBuilder {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/urbanairship/push/PushNotificationBuilder");
		IntPtr class_ref;

		public static IPushNotificationBuilder GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IPushNotificationBuilder> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.urbanairship.push.PushNotificationBuilder"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IPushNotificationBuilderInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (IPushNotificationBuilderInvoker); }
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
			IPushNotificationBuilder __this = Java.Lang.Object.GetObject<IPushNotificationBuilder> (native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			System.Collections.Generic.IDictionary<string, string> p1 = global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.BuildNotification (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_buildNotification_Ljava_lang_String_Ljava_util_Map_;
		public global::Android.App.Notification BuildNotification (string p0, global::System.Collections.Generic.IDictionary<string, string> p1)
		{
			if (id_buildNotification_Ljava_lang_String_Ljava_util_Map_ == IntPtr.Zero)
				id_buildNotification_Ljava_lang_String_Ljava_util_Map_ = JNIEnv.GetMethodID (class_ref, "buildNotification", "(Ljava/lang/String;Ljava/util/Map;)Landroid/app/Notification;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (p1);
			global::Android.App.Notification __ret = Java.Lang.Object.GetObject<global::Android.App.Notification> (JNIEnv.CallObjectMethod (Handle, id_buildNotification_Ljava_lang_String_Ljava_util_Map_, new JValue (native_p0), new JValue (native_p1)), JniHandleOwnership.TransferLocalRef);
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
			IPushNotificationBuilder __this = Java.Lang.Object.GetObject<IPushNotificationBuilder> (native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			System.Collections.Generic.IDictionary<string, string> p1 = global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (native_p1, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.GetNextId (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getNextId_Ljava_lang_String_Ljava_util_Map_;
		public int GetNextId (string p0, global::System.Collections.Generic.IDictionary<string, string> p1)
		{
			if (id_getNextId_Ljava_lang_String_Ljava_util_Map_ == IntPtr.Zero)
				id_getNextId_Ljava_lang_String_Ljava_util_Map_ = JNIEnv.GetMethodID (class_ref, "getNextId", "(Ljava/lang/String;Ljava/util/Map;)I");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (p1);
			int __ret = JNIEnv.CallIntMethod (Handle, id_getNextId_Ljava_lang_String_Ljava_util_Map_, new JValue (native_p0), new JValue (native_p1));
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			return __ret;
		}

	}

}
