using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Urbanairship.Iap.Marketinterface {

	[global::Android.Runtime.Register ("com/urbanairship/iap/marketinterface/AbstractMarketListener", DoNotGenerateAcw=true)]
	public abstract partial class AbstractMarketListener : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/urbanairship/iap/marketinterface/AbstractMarketListener", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AbstractMarketListener); }
		}

		protected AbstractMarketListener (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_os_Handler_;
		[Register (".ctor", "(Landroid/os/Handler;)V", "")]
		public AbstractMarketListener (global::Android.OS.Handler p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (AbstractMarketListener)) {
				SetHandle (global::Android.Runtime.JNIEnv.CreateInstance (GetType (), "(Landroid/os/Handler;)V", new JValue (p0)), JniHandleOwnership.TransferLocalRef);
				return;
			}

			if (id_ctor_Landroid_os_Handler_ == IntPtr.Zero)
				id_ctor_Landroid_os_Handler_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/os/Handler;)V");
			SetHandle (JNIEnv.NewObject (class_ref, id_ctor_Landroid_os_Handler_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_onBillingSupported_Z;
#pragma warning disable 0169
		static Delegate GetOnBillingSupported_ZHandler ()
		{
			if (cb_onBillingSupported_Z == null)
				cb_onBillingSupported_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_OnBillingSupported_Z);
			return cb_onBillingSupported_Z;
		}

		static void n_OnBillingSupported_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			AbstractMarketListener __this = Java.Lang.Object.GetObject<AbstractMarketListener> (native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnBillingSupported (p0);
		}
#pragma warning restore 0169

		[Register ("onBillingSupported", "(Z)V", "GetOnBillingSupported_ZHandler")]
		public abstract void OnBillingSupported (bool p0);

		static Delegate cb_onPurchaseStateChange_Lcom_urbanairship_iap_marketinterface_Consts_PurchaseState_Ljava_lang_String_IJLjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOnPurchaseStateChange_Lcom_urbanairship_iap_marketinterface_Consts_PurchaseState_Ljava_lang_String_IJLjava_lang_String_Handler ()
		{
			if (cb_onPurchaseStateChange_Lcom_urbanairship_iap_marketinterface_Consts_PurchaseState_Ljava_lang_String_IJLjava_lang_String_ == null)
				cb_onPurchaseStateChange_Lcom_urbanairship_iap_marketinterface_Consts_PurchaseState_Ljava_lang_String_IJLjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, int, long, IntPtr>) n_OnPurchaseStateChange_Lcom_urbanairship_iap_marketinterface_Consts_PurchaseState_Ljava_lang_String_IJLjava_lang_String_);
			return cb_onPurchaseStateChange_Lcom_urbanairship_iap_marketinterface_Consts_PurchaseState_Ljava_lang_String_IJLjava_lang_String_;
		}

		static void n_OnPurchaseStateChange_Lcom_urbanairship_iap_marketinterface_Consts_PurchaseState_Ljava_lang_String_IJLjava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, int p2, long p3, IntPtr native_p4)
		{
			AbstractMarketListener __this = Java.Lang.Object.GetObject<AbstractMarketListener> (native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Urbanairship.Iap.Marketinterface.Consts.PurchaseState p0 = Java.Lang.Object.GetObject<global::Com.Urbanairship.Iap.Marketinterface.Consts.PurchaseState> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string p4 = JNIEnv.GetString (native_p4, JniHandleOwnership.DoNotTransfer);
			__this.OnPurchaseStateChange (p0, p1, p2, p3, p4);
		}
#pragma warning restore 0169

		[Register ("onPurchaseStateChange", "(Lcom/urbanairship/iap/marketinterface/Consts$PurchaseState;Ljava/lang/String;IJLjava/lang/String;)V", "GetOnPurchaseStateChange_Lcom_urbanairship_iap_marketinterface_Consts_PurchaseState_Ljava_lang_String_IJLjava_lang_String_Handler")]
		public abstract void OnPurchaseStateChange (global::Com.Urbanairship.Iap.Marketinterface.Consts.PurchaseState p0, string p1, int p2, long p3, string p4);

		static Delegate cb_postPurchaseStateChange_Lcom_urbanairship_iap_marketinterface_Consts_PurchaseState_Ljava_lang_String_IJLjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetPostPurchaseStateChange_Lcom_urbanairship_iap_marketinterface_Consts_PurchaseState_Ljava_lang_String_IJLjava_lang_String_Handler ()
		{
			if (cb_postPurchaseStateChange_Lcom_urbanairship_iap_marketinterface_Consts_PurchaseState_Ljava_lang_String_IJLjava_lang_String_ == null)
				cb_postPurchaseStateChange_Lcom_urbanairship_iap_marketinterface_Consts_PurchaseState_Ljava_lang_String_IJLjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, int, long, IntPtr>) n_PostPurchaseStateChange_Lcom_urbanairship_iap_marketinterface_Consts_PurchaseState_Ljava_lang_String_IJLjava_lang_String_);
			return cb_postPurchaseStateChange_Lcom_urbanairship_iap_marketinterface_Consts_PurchaseState_Ljava_lang_String_IJLjava_lang_String_;
		}

		static void n_PostPurchaseStateChange_Lcom_urbanairship_iap_marketinterface_Consts_PurchaseState_Ljava_lang_String_IJLjava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, int p2, long p3, IntPtr native_p4)
		{
			AbstractMarketListener __this = Java.Lang.Object.GetObject<AbstractMarketListener> (native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Urbanairship.Iap.Marketinterface.Consts.PurchaseState p0 = Java.Lang.Object.GetObject<global::Com.Urbanairship.Iap.Marketinterface.Consts.PurchaseState> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string p4 = JNIEnv.GetString (native_p4, JniHandleOwnership.DoNotTransfer);
			__this.PostPurchaseStateChange (p0, p1, p2, p3, p4);
		}
#pragma warning restore 0169

		static IntPtr id_postPurchaseStateChange_Lcom_urbanairship_iap_marketinterface_Consts_PurchaseState_Ljava_lang_String_IJLjava_lang_String_;
		[Register ("postPurchaseStateChange", "(Lcom/urbanairship/iap/marketinterface/Consts$PurchaseState;Ljava/lang/String;IJLjava/lang/String;)V", "GetPostPurchaseStateChange_Lcom_urbanairship_iap_marketinterface_Consts_PurchaseState_Ljava_lang_String_IJLjava_lang_String_Handler")]
		public virtual void PostPurchaseStateChange (global::Com.Urbanairship.Iap.Marketinterface.Consts.PurchaseState p0, string p1, int p2, long p3, string p4)
		{
			if (id_postPurchaseStateChange_Lcom_urbanairship_iap_marketinterface_Consts_PurchaseState_Ljava_lang_String_IJLjava_lang_String_ == IntPtr.Zero)
				id_postPurchaseStateChange_Lcom_urbanairship_iap_marketinterface_Consts_PurchaseState_Ljava_lang_String_IJLjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "postPurchaseStateChange", "(Lcom/urbanairship/iap/marketinterface/Consts$PurchaseState;Ljava/lang/String;IJLjava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p4 = JNIEnv.NewString (p4);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_postPurchaseStateChange_Lcom_urbanairship_iap_marketinterface_Consts_PurchaseState_Ljava_lang_String_IJLjava_lang_String_, new JValue (p0), new JValue (native_p1), new JValue (p2), new JValue (p3), new JValue (native_p4));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_postPurchaseStateChange_Lcom_urbanairship_iap_marketinterface_Consts_PurchaseState_Ljava_lang_String_IJLjava_lang_String_, new JValue (p0), new JValue (native_p1), new JValue (p2), new JValue (p3), new JValue (native_p4));
			JNIEnv.DeleteLocalRef (native_p1);
			JNIEnv.DeleteLocalRef (native_p4);
		}

		static Delegate cb_startBuyPageActivity_Landroid_app_Activity_Landroid_app_PendingIntent_Landroid_content_Intent_;
#pragma warning disable 0169
		static Delegate GetStartBuyPageActivity_Landroid_app_Activity_Landroid_app_PendingIntent_Landroid_content_Intent_Handler ()
		{
			if (cb_startBuyPageActivity_Landroid_app_Activity_Landroid_app_PendingIntent_Landroid_content_Intent_ == null)
				cb_startBuyPageActivity_Landroid_app_Activity_Landroid_app_PendingIntent_Landroid_content_Intent_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_StartBuyPageActivity_Landroid_app_Activity_Landroid_app_PendingIntent_Landroid_content_Intent_);
			return cb_startBuyPageActivity_Landroid_app_Activity_Landroid_app_PendingIntent_Landroid_content_Intent_;
		}

		static void n_StartBuyPageActivity_Landroid_app_Activity_Landroid_app_PendingIntent_Landroid_content_Intent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			AbstractMarketListener __this = Java.Lang.Object.GetObject<AbstractMarketListener> (native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.App.Activity p0 = Java.Lang.Object.GetObject<global::Android.App.Activity> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.App.PendingIntent p1 = Java.Lang.Object.GetObject<global::Android.App.PendingIntent> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Intent p2 = Java.Lang.Object.GetObject<global::Android.Content.Intent> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.StartBuyPageActivity (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_startBuyPageActivity_Landroid_app_Activity_Landroid_app_PendingIntent_Landroid_content_Intent_;
		[Register ("startBuyPageActivity", "(Landroid/app/Activity;Landroid/app/PendingIntent;Landroid/content/Intent;)V", "GetStartBuyPageActivity_Landroid_app_Activity_Landroid_app_PendingIntent_Landroid_content_Intent_Handler")]
		public virtual void StartBuyPageActivity (global::Android.App.Activity p0, global::Android.App.PendingIntent p1, global::Android.Content.Intent p2)
		{
			if (id_startBuyPageActivity_Landroid_app_Activity_Landroid_app_PendingIntent_Landroid_content_Intent_ == IntPtr.Zero)
				id_startBuyPageActivity_Landroid_app_Activity_Landroid_app_PendingIntent_Landroid_content_Intent_ = JNIEnv.GetMethodID (class_ref, "startBuyPageActivity", "(Landroid/app/Activity;Landroid/app/PendingIntent;Landroid/content/Intent;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_startBuyPageActivity_Landroid_app_Activity_Landroid_app_PendingIntent_Landroid_content_Intent_, new JValue (p0), new JValue (p1), new JValue (p2));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_startBuyPageActivity_Landroid_app_Activity_Landroid_app_PendingIntent_Landroid_content_Intent_, new JValue (p0), new JValue (p1), new JValue (p2));
		}

	}

	[global::Android.Runtime.Register ("com/urbanairship/iap/marketinterface/AbstractMarketListener", DoNotGenerateAcw=true)]
	internal partial class AbstractMarketListenerInvoker : AbstractMarketListener {

		public AbstractMarketListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (AbstractMarketListenerInvoker); }
		}

		static IntPtr id_onBillingSupported_Z;
		[Register ("onBillingSupported", "(Z)V", "GetOnBillingSupported_ZHandler")]
		public override void OnBillingSupported (bool p0)
		{
			if (id_onBillingSupported_Z == IntPtr.Zero)
				id_onBillingSupported_Z = JNIEnv.GetMethodID (class_ref, "onBillingSupported", "(Z)V");
			JNIEnv.CallVoidMethod  (Handle, id_onBillingSupported_Z, new JValue (p0));
		}

		static IntPtr id_onPurchaseStateChange_Lcom_urbanairship_iap_marketinterface_Consts_PurchaseState_Ljava_lang_String_IJLjava_lang_String_;
		[Register ("onPurchaseStateChange", "(Lcom/urbanairship/iap/marketinterface/Consts$PurchaseState;Ljava/lang/String;IJLjava/lang/String;)V", "GetOnPurchaseStateChange_Lcom_urbanairship_iap_marketinterface_Consts_PurchaseState_Ljava_lang_String_IJLjava_lang_String_Handler")]
		public override void OnPurchaseStateChange (global::Com.Urbanairship.Iap.Marketinterface.Consts.PurchaseState p0, string p1, int p2, long p3, string p4)
		{
			if (id_onPurchaseStateChange_Lcom_urbanairship_iap_marketinterface_Consts_PurchaseState_Ljava_lang_String_IJLjava_lang_String_ == IntPtr.Zero)
				id_onPurchaseStateChange_Lcom_urbanairship_iap_marketinterface_Consts_PurchaseState_Ljava_lang_String_IJLjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onPurchaseStateChange", "(Lcom/urbanairship/iap/marketinterface/Consts$PurchaseState;Ljava/lang/String;IJLjava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p4 = JNIEnv.NewString (p4);
			JNIEnv.CallVoidMethod  (Handle, id_onPurchaseStateChange_Lcom_urbanairship_iap_marketinterface_Consts_PurchaseState_Ljava_lang_String_IJLjava_lang_String_, new JValue (p0), new JValue (native_p1), new JValue (p2), new JValue (p3), new JValue (native_p4));
			JNIEnv.DeleteLocalRef (native_p1);
			JNIEnv.DeleteLocalRef (native_p4);
		}

	}

}
