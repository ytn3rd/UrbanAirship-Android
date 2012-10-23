using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Urbanairship.Iap {

	[global::Android.Runtime.Register ("com/urbanairship/iap/IAPEventListener", DoNotGenerateAcw=true)]
	public abstract partial class IAPEventListener : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/urbanairship/iap/IAPEventListener", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IAPEventListener); }
		}

		protected IAPEventListener (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		[Register (".ctor", "()V", "")]
		public IAPEventListener () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (IAPEventListener)) {
				SetHandle (global::Android.Runtime.JNIEnv.CreateInstance (GetType (), "()V"), JniHandleOwnership.TransferLocalRef);
				return;
			}

			if (id_ctor == IntPtr.Zero)
				id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
			SetHandle (JNIEnv.NewObject (class_ref, id_ctor), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_billingSupported_Z;
#pragma warning disable 0169
		static Delegate GetBillingSupported_ZHandler ()
		{
			if (cb_billingSupported_Z == null)
				cb_billingSupported_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_BillingSupported_Z);
			return cb_billingSupported_Z;
		}

		static void n_BillingSupported_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			IAPEventListener __this = Java.Lang.Object.GetObject<IAPEventListener> (native__this, JniHandleOwnership.DoNotTransfer);
			__this.BillingSupported (p0);
		}
#pragma warning restore 0169

		[Register ("billingSupported", "(Z)V", "GetBillingSupported_ZHandler")]
		public abstract void BillingSupported (bool p0);

		static Delegate cb_downloadFailed_Lcom_urbanairship_iap_Product_;
#pragma warning disable 0169
		static Delegate GetDownloadFailed_Lcom_urbanairship_iap_Product_Handler ()
		{
			if (cb_downloadFailed_Lcom_urbanairship_iap_Product_ == null)
				cb_downloadFailed_Lcom_urbanairship_iap_Product_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_DownloadFailed_Lcom_urbanairship_iap_Product_);
			return cb_downloadFailed_Lcom_urbanairship_iap_Product_;
		}

		static void n_DownloadFailed_Lcom_urbanairship_iap_Product_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			IAPEventListener __this = Java.Lang.Object.GetObject<IAPEventListener> (native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Urbanairship.Iap.Product p0 = Java.Lang.Object.GetObject<global::Com.Urbanairship.Iap.Product> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.DownloadFailed (p0);
		}
#pragma warning restore 0169

		[Register ("downloadFailed", "(Lcom/urbanairship/iap/Product;)V", "GetDownloadFailed_Lcom_urbanairship_iap_Product_Handler")]
		public abstract void DownloadFailed (global::Com.Urbanairship.Iap.Product p0);

		static Delegate cb_downloadProgress_Lcom_urbanairship_iap_Product_I;
#pragma warning disable 0169
		static Delegate GetDownloadProgress_Lcom_urbanairship_iap_Product_IHandler ()
		{
			if (cb_downloadProgress_Lcom_urbanairship_iap_Product_I == null)
				cb_downloadProgress_Lcom_urbanairship_iap_Product_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_DownloadProgress_Lcom_urbanairship_iap_Product_I);
			return cb_downloadProgress_Lcom_urbanairship_iap_Product_I;
		}

		static void n_DownloadProgress_Lcom_urbanairship_iap_Product_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			IAPEventListener __this = Java.Lang.Object.GetObject<IAPEventListener> (native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Urbanairship.Iap.Product p0 = Java.Lang.Object.GetObject<global::Com.Urbanairship.Iap.Product> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.DownloadProgress (p0, p1);
		}
#pragma warning restore 0169

		[Register ("downloadProgress", "(Lcom/urbanairship/iap/Product;I)V", "GetDownloadProgress_Lcom_urbanairship_iap_Product_IHandler")]
		public abstract void DownloadProgress (global::Com.Urbanairship.Iap.Product p0, int p1);

		static Delegate cb_downloadStarted_Lcom_urbanairship_iap_Product_I;
#pragma warning disable 0169
		static Delegate GetDownloadStarted_Lcom_urbanairship_iap_Product_IHandler ()
		{
			if (cb_downloadStarted_Lcom_urbanairship_iap_Product_I == null)
				cb_downloadStarted_Lcom_urbanairship_iap_Product_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_DownloadStarted_Lcom_urbanairship_iap_Product_I);
			return cb_downloadStarted_Lcom_urbanairship_iap_Product_I;
		}

		static void n_DownloadStarted_Lcom_urbanairship_iap_Product_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			IAPEventListener __this = Java.Lang.Object.GetObject<IAPEventListener> (native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Urbanairship.Iap.Product p0 = Java.Lang.Object.GetObject<global::Com.Urbanairship.Iap.Product> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.DownloadStarted (p0, p1);
		}
#pragma warning restore 0169

		[Register ("downloadStarted", "(Lcom/urbanairship/iap/Product;I)V", "GetDownloadStarted_Lcom_urbanairship_iap_Product_IHandler")]
		public abstract void DownloadStarted (global::Com.Urbanairship.Iap.Product p0, int p1);

		static Delegate cb_downloadSuccessful_Lcom_urbanairship_iap_Product_;
#pragma warning disable 0169
		static Delegate GetDownloadSuccessful_Lcom_urbanairship_iap_Product_Handler ()
		{
			if (cb_downloadSuccessful_Lcom_urbanairship_iap_Product_ == null)
				cb_downloadSuccessful_Lcom_urbanairship_iap_Product_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_DownloadSuccessful_Lcom_urbanairship_iap_Product_);
			return cb_downloadSuccessful_Lcom_urbanairship_iap_Product_;
		}

		static void n_DownloadSuccessful_Lcom_urbanairship_iap_Product_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			IAPEventListener __this = Java.Lang.Object.GetObject<IAPEventListener> (native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Urbanairship.Iap.Product p0 = Java.Lang.Object.GetObject<global::Com.Urbanairship.Iap.Product> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.DownloadSuccessful (p0);
		}
#pragma warning restore 0169

		[Register ("downloadSuccessful", "(Lcom/urbanairship/iap/Product;)V", "GetDownloadSuccessful_Lcom_urbanairship_iap_Product_Handler")]
		public abstract void DownloadSuccessful (global::Com.Urbanairship.Iap.Product p0);

		static Delegate cb_marketUnavailable_Lcom_urbanairship_iap_Product_;
#pragma warning disable 0169
		static Delegate GetMarketUnavailable_Lcom_urbanairship_iap_Product_Handler ()
		{
			if (cb_marketUnavailable_Lcom_urbanairship_iap_Product_ == null)
				cb_marketUnavailable_Lcom_urbanairship_iap_Product_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_MarketUnavailable_Lcom_urbanairship_iap_Product_);
			return cb_marketUnavailable_Lcom_urbanairship_iap_Product_;
		}

		static void n_MarketUnavailable_Lcom_urbanairship_iap_Product_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			IAPEventListener __this = Java.Lang.Object.GetObject<IAPEventListener> (native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Urbanairship.Iap.Product p0 = Java.Lang.Object.GetObject<global::Com.Urbanairship.Iap.Product> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.MarketUnavailable (p0);
		}
#pragma warning restore 0169

		[Register ("marketUnavailable", "(Lcom/urbanairship/iap/Product;)V", "GetMarketUnavailable_Lcom_urbanairship_iap_Product_Handler")]
		public abstract void MarketUnavailable (global::Com.Urbanairship.Iap.Product p0);

		static Delegate cb_restoreStarted;
#pragma warning disable 0169
		static Delegate GetRestoreStartedHandler ()
		{
			if (cb_restoreStarted == null)
				cb_restoreStarted = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_RestoreStarted);
			return cb_restoreStarted;
		}

		static void n_RestoreStarted (IntPtr jnienv, IntPtr native__this)
		{
			IAPEventListener __this = Java.Lang.Object.GetObject<IAPEventListener> (native__this, JniHandleOwnership.DoNotTransfer);
			__this.RestoreStarted ();
		}
#pragma warning restore 0169

		[Register ("restoreStarted", "()V", "GetRestoreStartedHandler")]
		public abstract void RestoreStarted ();

	}

	[global::Android.Runtime.Register ("com/urbanairship/iap/IAPEventListener", DoNotGenerateAcw=true)]
	internal partial class IAPEventListenerInvoker : IAPEventListener {

		public IAPEventListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (IAPEventListenerInvoker); }
		}

		static IntPtr id_billingSupported_Z;
		[Register ("billingSupported", "(Z)V", "GetBillingSupported_ZHandler")]
		public override void BillingSupported (bool p0)
		{
			if (id_billingSupported_Z == IntPtr.Zero)
				id_billingSupported_Z = JNIEnv.GetMethodID (class_ref, "billingSupported", "(Z)V");
			JNIEnv.CallVoidMethod  (Handle, id_billingSupported_Z, new JValue (p0));
		}

		static IntPtr id_downloadFailed_Lcom_urbanairship_iap_Product_;
		[Register ("downloadFailed", "(Lcom/urbanairship/iap/Product;)V", "GetDownloadFailed_Lcom_urbanairship_iap_Product_Handler")]
		public override void DownloadFailed (global::Com.Urbanairship.Iap.Product p0)
		{
			if (id_downloadFailed_Lcom_urbanairship_iap_Product_ == IntPtr.Zero)
				id_downloadFailed_Lcom_urbanairship_iap_Product_ = JNIEnv.GetMethodID (class_ref, "downloadFailed", "(Lcom/urbanairship/iap/Product;)V");
			JNIEnv.CallVoidMethod  (Handle, id_downloadFailed_Lcom_urbanairship_iap_Product_, new JValue (p0));
		}

		static IntPtr id_downloadProgress_Lcom_urbanairship_iap_Product_I;
		[Register ("downloadProgress", "(Lcom/urbanairship/iap/Product;I)V", "GetDownloadProgress_Lcom_urbanairship_iap_Product_IHandler")]
		public override void DownloadProgress (global::Com.Urbanairship.Iap.Product p0, int p1)
		{
			if (id_downloadProgress_Lcom_urbanairship_iap_Product_I == IntPtr.Zero)
				id_downloadProgress_Lcom_urbanairship_iap_Product_I = JNIEnv.GetMethodID (class_ref, "downloadProgress", "(Lcom/urbanairship/iap/Product;I)V");
			JNIEnv.CallVoidMethod  (Handle, id_downloadProgress_Lcom_urbanairship_iap_Product_I, new JValue (p0), new JValue (p1));
		}

		static IntPtr id_downloadStarted_Lcom_urbanairship_iap_Product_I;
		[Register ("downloadStarted", "(Lcom/urbanairship/iap/Product;I)V", "GetDownloadStarted_Lcom_urbanairship_iap_Product_IHandler")]
		public override void DownloadStarted (global::Com.Urbanairship.Iap.Product p0, int p1)
		{
			if (id_downloadStarted_Lcom_urbanairship_iap_Product_I == IntPtr.Zero)
				id_downloadStarted_Lcom_urbanairship_iap_Product_I = JNIEnv.GetMethodID (class_ref, "downloadStarted", "(Lcom/urbanairship/iap/Product;I)V");
			JNIEnv.CallVoidMethod  (Handle, id_downloadStarted_Lcom_urbanairship_iap_Product_I, new JValue (p0), new JValue (p1));
		}

		static IntPtr id_downloadSuccessful_Lcom_urbanairship_iap_Product_;
		[Register ("downloadSuccessful", "(Lcom/urbanairship/iap/Product;)V", "GetDownloadSuccessful_Lcom_urbanairship_iap_Product_Handler")]
		public override void DownloadSuccessful (global::Com.Urbanairship.Iap.Product p0)
		{
			if (id_downloadSuccessful_Lcom_urbanairship_iap_Product_ == IntPtr.Zero)
				id_downloadSuccessful_Lcom_urbanairship_iap_Product_ = JNIEnv.GetMethodID (class_ref, "downloadSuccessful", "(Lcom/urbanairship/iap/Product;)V");
			JNIEnv.CallVoidMethod  (Handle, id_downloadSuccessful_Lcom_urbanairship_iap_Product_, new JValue (p0));
		}

		static IntPtr id_marketUnavailable_Lcom_urbanairship_iap_Product_;
		[Register ("marketUnavailable", "(Lcom/urbanairship/iap/Product;)V", "GetMarketUnavailable_Lcom_urbanairship_iap_Product_Handler")]
		public override void MarketUnavailable (global::Com.Urbanairship.Iap.Product p0)
		{
			if (id_marketUnavailable_Lcom_urbanairship_iap_Product_ == IntPtr.Zero)
				id_marketUnavailable_Lcom_urbanairship_iap_Product_ = JNIEnv.GetMethodID (class_ref, "marketUnavailable", "(Lcom/urbanairship/iap/Product;)V");
			JNIEnv.CallVoidMethod  (Handle, id_marketUnavailable_Lcom_urbanairship_iap_Product_, new JValue (p0));
		}

		static IntPtr id_restoreStarted;
		[Register ("restoreStarted", "()V", "GetRestoreStartedHandler")]
		public override void RestoreStarted ()
		{
			if (id_restoreStarted == IntPtr.Zero)
				id_restoreStarted = JNIEnv.GetMethodID (class_ref, "restoreStarted", "()V");
			JNIEnv.CallVoidMethod  (Handle, id_restoreStarted);
		}

	}

}
