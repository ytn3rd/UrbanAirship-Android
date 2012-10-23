using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Urbanairship.Iap {

	[Register ("com/urbanairship/iap/PurchaseNotificationBuilder", "", "Com.Urbanairship.Iap.IPurchaseNotificationBuilderInvoker")]
	public partial interface IPurchaseNotificationBuilder : IJavaObject {

		[Register ("buildNotification", "(Lcom/urbanairship/iap/PurchaseNotificationInfo;)Landroid/app/Notification;", "GetBuildNotification_Lcom_urbanairship_iap_PurchaseNotificationInfo_Handler:Com.Urbanairship.Iap.IPurchaseNotificationBuilderInvoker, AndroidSDK.Binding")]
		global::Android.App.Notification BuildNotification (global::Com.Urbanairship.Iap.PurchaseNotificationInfo p0);

	}

	[global::Android.Runtime.Register ("com/urbanairship/iap/PurchaseNotificationBuilder", DoNotGenerateAcw=true)]
	internal class IPurchaseNotificationBuilderInvoker : Java.Lang.Object, IPurchaseNotificationBuilder {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/urbanairship/iap/PurchaseNotificationBuilder");
		IntPtr class_ref;

		public static IPurchaseNotificationBuilder GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IPurchaseNotificationBuilder> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.urbanairship.iap.PurchaseNotificationBuilder"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IPurchaseNotificationBuilderInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (IPurchaseNotificationBuilderInvoker); }
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
			IPurchaseNotificationBuilder __this = Java.Lang.Object.GetObject<IPurchaseNotificationBuilder> (native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Urbanairship.Iap.PurchaseNotificationInfo p0 = Java.Lang.Object.GetObject<global::Com.Urbanairship.Iap.PurchaseNotificationInfo> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.BuildNotification (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_buildNotification_Lcom_urbanairship_iap_PurchaseNotificationInfo_;
		public global::Android.App.Notification BuildNotification (global::Com.Urbanairship.Iap.PurchaseNotificationInfo p0)
		{
			if (id_buildNotification_Lcom_urbanairship_iap_PurchaseNotificationInfo_ == IntPtr.Zero)
				id_buildNotification_Lcom_urbanairship_iap_PurchaseNotificationInfo_ = JNIEnv.GetMethodID (class_ref, "buildNotification", "(Lcom/urbanairship/iap/PurchaseNotificationInfo;)Landroid/app/Notification;");
			global::Android.App.Notification __ret = Java.Lang.Object.GetObject<global::Android.App.Notification> (JNIEnv.CallObjectMethod (Handle, id_buildNotification_Lcom_urbanairship_iap_PurchaseNotificationInfo_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

	}

}
