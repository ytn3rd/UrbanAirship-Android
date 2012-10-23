using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Urbanairship.Iap {

	[global::Android.Runtime.Register ("com/urbanairship/iap/BasicPurchaseNotificationBuilder", DoNotGenerateAcw=true)]
	public partial class BasicPurchaseNotificationBuilder : global::Java.Lang.Object, global::Com.Urbanairship.Iap.IPurchaseNotificationBuilder {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/urbanairship/iap/BasicPurchaseNotificationBuilder", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BasicPurchaseNotificationBuilder); }
		}

		protected BasicPurchaseNotificationBuilder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		[Register (".ctor", "()V", "")]
		public BasicPurchaseNotificationBuilder () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (BasicPurchaseNotificationBuilder)) {
				SetHandle (global::Android.Runtime.JNIEnv.CreateInstance (GetType (), "()V"), JniHandleOwnership.TransferLocalRef);
				return;
			}

			if (id_ctor == IntPtr.Zero)
				id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
			SetHandle (JNIEnv.NewObject (class_ref, id_ctor), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_buildNotification_Lcom_urbanairship_iap_PurchaseNotificationInfo_;
#pragma warning disable 0169
		static Delegate GetBuildNotification_Lcom_urbanairship_iap_PurchaseNotificationInfo_Handler ()
		{
			if (cb_buildNotification_Lcom_urbanairship_iap_PurchaseNotificationInfo_ == null)
				cb_buildNotification_Lcom_urbanairship_iap_PurchaseNotificationInfo_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_BuildNotification_Lcom_urbanairship_iap_PurchaseNotificationInfo_);
			return cb_buildNotification_Lcom_urbanairship_iap_PurchaseNotificationInfo_;
		}

		static IntPtr n_BuildNotification_Lcom_urbanairship_iap_PurchaseNotificationInfo_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			BasicPurchaseNotificationBuilder __this = Java.Lang.Object.GetObject<BasicPurchaseNotificationBuilder> (native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Urbanairship.Iap.PurchaseNotificationInfo p0 = Java.Lang.Object.GetObject<global::Com.Urbanairship.Iap.PurchaseNotificationInfo> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.BuildNotification (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_buildNotification_Lcom_urbanairship_iap_PurchaseNotificationInfo_;
		[Register ("buildNotification", "(Lcom/urbanairship/iap/PurchaseNotificationInfo;)Landroid/app/Notification;", "GetBuildNotification_Lcom_urbanairship_iap_PurchaseNotificationInfo_Handler")]
		public virtual global::Android.App.Notification BuildNotification (global::Com.Urbanairship.Iap.PurchaseNotificationInfo p0)
		{
			if (id_buildNotification_Lcom_urbanairship_iap_PurchaseNotificationInfo_ == IntPtr.Zero)
				id_buildNotification_Lcom_urbanairship_iap_PurchaseNotificationInfo_ = JNIEnv.GetMethodID (class_ref, "buildNotification", "(Lcom/urbanairship/iap/PurchaseNotificationInfo;)Landroid/app/Notification;");

			global::Android.App.Notification __ret;
			if (GetType () == ThresholdType)
				__ret = Java.Lang.Object.GetObject<global::Android.App.Notification> (JNIEnv.CallObjectMethod  (Handle, id_buildNotification_Lcom_urbanairship_iap_PurchaseNotificationInfo_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = Java.Lang.Object.GetObject<global::Android.App.Notification> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_buildNotification_Lcom_urbanairship_iap_PurchaseNotificationInfo_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_getNotificationMessage_Lcom_urbanairship_iap_PurchaseNotificationInfo_;
#pragma warning disable 0169
		static Delegate GetGetNotificationMessage_Lcom_urbanairship_iap_PurchaseNotificationInfo_Handler ()
		{
			if (cb_getNotificationMessage_Lcom_urbanairship_iap_PurchaseNotificationInfo_ == null)
				cb_getNotificationMessage_Lcom_urbanairship_iap_PurchaseNotificationInfo_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetNotificationMessage_Lcom_urbanairship_iap_PurchaseNotificationInfo_);
			return cb_getNotificationMessage_Lcom_urbanairship_iap_PurchaseNotificationInfo_;
		}

		static IntPtr n_GetNotificationMessage_Lcom_urbanairship_iap_PurchaseNotificationInfo_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			BasicPurchaseNotificationBuilder __this = Java.Lang.Object.GetObject<BasicPurchaseNotificationBuilder> (native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Urbanairship.Iap.PurchaseNotificationInfo p0 = Java.Lang.Object.GetObject<global::Com.Urbanairship.Iap.PurchaseNotificationInfo> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GetNotificationMessage (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getNotificationMessage_Lcom_urbanairship_iap_PurchaseNotificationInfo_;
		[Register ("getNotificationMessage", "(Lcom/urbanairship/iap/PurchaseNotificationInfo;)Ljava/lang/String;", "GetGetNotificationMessage_Lcom_urbanairship_iap_PurchaseNotificationInfo_Handler")]
		protected virtual string GetNotificationMessage (global::Com.Urbanairship.Iap.PurchaseNotificationInfo p0)
		{
			if (id_getNotificationMessage_Lcom_urbanairship_iap_PurchaseNotificationInfo_ == IntPtr.Zero)
				id_getNotificationMessage_Lcom_urbanairship_iap_PurchaseNotificationInfo_ = JNIEnv.GetMethodID (class_ref, "getNotificationMessage", "(Lcom/urbanairship/iap/PurchaseNotificationInfo;)Ljava/lang/String;");

			string __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getNotificationMessage_Lcom_urbanairship_iap_PurchaseNotificationInfo_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getNotificationMessage_Lcom_urbanairship_iap_PurchaseNotificationInfo_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

	}
}
