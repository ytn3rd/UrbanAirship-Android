using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Urbanairship.Iap {

	[global::Android.Runtime.Register ("com/urbanairship/iap/MarketListener", DoNotGenerateAcw=true)]
	public partial class MarketListener : global::Com.Urbanairship.Iap.Marketinterface.AbstractMarketListener {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/urbanairship/iap/MarketListener", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MarketListener); }
		}

		protected MarketListener (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_os_Handler_;
		[Register (".ctor", "(Landroid/os/Handler;)V", "")]
		public MarketListener (global::Android.OS.Handler p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (MarketListener)) {
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
			MarketListener __this = Java.Lang.Object.GetObject<MarketListener> (native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnBillingSupported (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onBillingSupported_Z;
		[Register ("onBillingSupported", "(Z)V", "GetOnBillingSupported_ZHandler")]
		public override void OnBillingSupported (bool p0)
		{
			if (id_onBillingSupported_Z == IntPtr.Zero)
				id_onBillingSupported_Z = JNIEnv.GetMethodID (class_ref, "onBillingSupported", "(Z)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_onBillingSupported_Z, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_onBillingSupported_Z, new JValue (p0));
		}

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
			MarketListener __this = Java.Lang.Object.GetObject<MarketListener> (native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Urbanairship.Iap.Marketinterface.Consts.PurchaseState p0 = Java.Lang.Object.GetObject<global::Com.Urbanairship.Iap.Marketinterface.Consts.PurchaseState> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string p4 = JNIEnv.GetString (native_p4, JniHandleOwnership.DoNotTransfer);
			__this.OnPurchaseStateChange (p0, p1, p2, p3, p4);
		}
#pragma warning restore 0169

		static IntPtr id_onPurchaseStateChange_Lcom_urbanairship_iap_marketinterface_Consts_PurchaseState_Ljava_lang_String_IJLjava_lang_String_;
		[Register ("onPurchaseStateChange", "(Lcom/urbanairship/iap/marketinterface/Consts$PurchaseState;Ljava/lang/String;IJLjava/lang/String;)V", "GetOnPurchaseStateChange_Lcom_urbanairship_iap_marketinterface_Consts_PurchaseState_Ljava_lang_String_IJLjava_lang_String_Handler")]
		public override void OnPurchaseStateChange (global::Com.Urbanairship.Iap.Marketinterface.Consts.PurchaseState p0, string p1, int p2, long p3, string p4)
		{
			if (id_onPurchaseStateChange_Lcom_urbanairship_iap_marketinterface_Consts_PurchaseState_Ljava_lang_String_IJLjava_lang_String_ == IntPtr.Zero)
				id_onPurchaseStateChange_Lcom_urbanairship_iap_marketinterface_Consts_PurchaseState_Ljava_lang_String_IJLjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onPurchaseStateChange", "(Lcom/urbanairship/iap/marketinterface/Consts$PurchaseState;Ljava/lang/String;IJLjava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p4 = JNIEnv.NewString (p4);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_onPurchaseStateChange_Lcom_urbanairship_iap_marketinterface_Consts_PurchaseState_Ljava_lang_String_IJLjava_lang_String_, new JValue (p0), new JValue (native_p1), new JValue (p2), new JValue (p3), new JValue (native_p4));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_onPurchaseStateChange_Lcom_urbanairship_iap_marketinterface_Consts_PurchaseState_Ljava_lang_String_IJLjava_lang_String_, new JValue (p0), new JValue (native_p1), new JValue (p2), new JValue (p3), new JValue (native_p4));
			JNIEnv.DeleteLocalRef (native_p1);
			JNIEnv.DeleteLocalRef (native_p4);
		}

		static Delegate cb_onPurchaseStateChange_Lcom_urbanairship_iap_marketinterface_Consts_PurchaseState_Ljava_lang_String_Ljava_lang_String_JLjava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOnPurchaseStateChange_Lcom_urbanairship_iap_marketinterface_Consts_PurchaseState_Ljava_lang_String_Ljava_lang_String_JLjava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_onPurchaseStateChange_Lcom_urbanairship_iap_marketinterface_Consts_PurchaseState_Ljava_lang_String_Ljava_lang_String_JLjava_lang_String_Ljava_lang_String_ == null)
				cb_onPurchaseStateChange_Lcom_urbanairship_iap_marketinterface_Consts_PurchaseState_Ljava_lang_String_Ljava_lang_String_JLjava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, long, IntPtr, IntPtr>) n_OnPurchaseStateChange_Lcom_urbanairship_iap_marketinterface_Consts_PurchaseState_Ljava_lang_String_Ljava_lang_String_JLjava_lang_String_Ljava_lang_String_);
			return cb_onPurchaseStateChange_Lcom_urbanairship_iap_marketinterface_Consts_PurchaseState_Ljava_lang_String_Ljava_lang_String_JLjava_lang_String_Ljava_lang_String_;
		}

		static void n_OnPurchaseStateChange_Lcom_urbanairship_iap_marketinterface_Consts_PurchaseState_Ljava_lang_String_Ljava_lang_String_JLjava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, long p3, IntPtr native_p4, IntPtr native_p5)
		{
			MarketListener __this = Java.Lang.Object.GetObject<MarketListener> (native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Urbanairship.Iap.Marketinterface.Consts.PurchaseState p0 = Java.Lang.Object.GetObject<global::Com.Urbanairship.Iap.Marketinterface.Consts.PurchaseState> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			string p4 = JNIEnv.GetString (native_p4, JniHandleOwnership.DoNotTransfer);
			string p5 = JNIEnv.GetString (native_p5, JniHandleOwnership.DoNotTransfer);
			__this.OnPurchaseStateChange (p0, p1, p2, p3, p4, p5);
		}
#pragma warning restore 0169

		static IntPtr id_onPurchaseStateChange_Lcom_urbanairship_iap_marketinterface_Consts_PurchaseState_Ljava_lang_String_Ljava_lang_String_JLjava_lang_String_Ljava_lang_String_;
		[Register ("onPurchaseStateChange", "(Lcom/urbanairship/iap/marketinterface/Consts$PurchaseState;Ljava/lang/String;Ljava/lang/String;JLjava/lang/String;Ljava/lang/String;)V", "GetOnPurchaseStateChange_Lcom_urbanairship_iap_marketinterface_Consts_PurchaseState_Ljava_lang_String_Ljava_lang_String_JLjava_lang_String_Ljava_lang_String_Handler")]
		public virtual void OnPurchaseStateChange (global::Com.Urbanairship.Iap.Marketinterface.Consts.PurchaseState p0, string p1, string p2, long p3, string p4, string p5)
		{
			if (id_onPurchaseStateChange_Lcom_urbanairship_iap_marketinterface_Consts_PurchaseState_Ljava_lang_String_Ljava_lang_String_JLjava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_onPurchaseStateChange_Lcom_urbanairship_iap_marketinterface_Consts_PurchaseState_Ljava_lang_String_Ljava_lang_String_JLjava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onPurchaseStateChange", "(Lcom/urbanairship/iap/marketinterface/Consts$PurchaseState;Ljava/lang/String;Ljava/lang/String;JLjava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p4 = JNIEnv.NewString (p4);
			IntPtr native_p5 = JNIEnv.NewString (p5);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_onPurchaseStateChange_Lcom_urbanairship_iap_marketinterface_Consts_PurchaseState_Ljava_lang_String_Ljava_lang_String_JLjava_lang_String_Ljava_lang_String_, new JValue (p0), new JValue (native_p1), new JValue (native_p2), new JValue (p3), new JValue (native_p4), new JValue (native_p5));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_onPurchaseStateChange_Lcom_urbanairship_iap_marketinterface_Consts_PurchaseState_Ljava_lang_String_Ljava_lang_String_JLjava_lang_String_Ljava_lang_String_, new JValue (p0), new JValue (native_p1), new JValue (native_p2), new JValue (p3), new JValue (native_p4), new JValue (native_p5));
			JNIEnv.DeleteLocalRef (native_p1);
			JNIEnv.DeleteLocalRef (native_p2);
			JNIEnv.DeleteLocalRef (native_p4);
			JNIEnv.DeleteLocalRef (native_p5);
		}

	}
}
