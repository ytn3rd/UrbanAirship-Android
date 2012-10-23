using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Urbanairship.Iap {

	[global::Android.Runtime.Register ("com/urbanairship/iap/DownloadManager", DoNotGenerateAcw=true)]
	public partial class DownloadManager : global::Java.Lang.Object {

		[global::Android.Runtime.Register ("com/urbanairship/iap/DownloadManager$InventoryObserver", DoNotGenerateAcw=true)]
		public partial class InventoryObserver : global::Java.Lang.Object, global::Java.Util.IObserver {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/urbanairship/iap/DownloadManager$InventoryObserver", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (InventoryObserver); }
			}

			protected InventoryObserver (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static Delegate cb_update_Ljava_util_Observable_Ljava_lang_Object_;
#pragma warning disable 0169
			static Delegate GetUpdate_Ljava_util_Observable_Ljava_lang_Object_Handler ()
			{
				if (cb_update_Ljava_util_Observable_Ljava_lang_Object_ == null)
					cb_update_Ljava_util_Observable_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_Update_Ljava_util_Observable_Ljava_lang_Object_);
				return cb_update_Ljava_util_Observable_Ljava_lang_Object_;
			}

			static void n_Update_Ljava_util_Observable_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				InventoryObserver __this = Java.Lang.Object.GetObject<InventoryObserver> (native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Util.Observable p0 = Java.Lang.Object.GetObject<global::Java.Util.Observable> (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Object p1 = Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p1, JniHandleOwnership.DoNotTransfer);
				__this.Update (p0, p1);
			}
#pragma warning restore 0169

			static IntPtr id_update_Ljava_util_Observable_Ljava_lang_Object_;
			[Register ("update", "(Ljava/util/Observable;Ljava/lang/Object;)V", "GetUpdate_Ljava_util_Observable_Ljava_lang_Object_Handler")]
			public virtual void Update (global::Java.Util.Observable p0, global::Java.Lang.Object p1)
			{
				if (id_update_Ljava_util_Observable_Ljava_lang_Object_ == IntPtr.Zero)
					id_update_Ljava_util_Observable_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "update", "(Ljava/util/Observable;Ljava/lang/Object;)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_update_Ljava_util_Observable_Ljava_lang_Object_, new JValue (p0), new JValue (p1));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_update_Ljava_util_Observable_Ljava_lang_Object_, new JValue (p0), new JValue (p1));
			}

		}

		[global::Android.Runtime.Register ("com/urbanairship/iap/DownloadManager$UnzipDelegate", DoNotGenerateAcw=true)]
		public partial class UnzipDelegate : global::Com.Urbanairship.Util.UnzipperTask.Delegate {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/urbanairship/iap/DownloadManager$UnzipDelegate", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (UnzipDelegate); }
			}

			protected UnzipDelegate (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lcom_urbanairship_iap_DownloadManager_Lcom_urbanairship_iap_Product_Ljava_io_File_;
			[Register (".ctor", "(Lcom/urbanairship/iap/DownloadManager;Lcom/urbanairship/iap/Product;Ljava/io/File;)V", "")]
			public UnzipDelegate (global::Com.Urbanairship.Iap.DownloadManager __self, global::Com.Urbanairship.Iap.Product p1, global::Java.IO.File p2) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				if (GetType () != typeof (UnzipDelegate)) {
					SetHandle (global::Android.Runtime.JNIEnv.CreateInstance (GetType (), "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";Lcom/urbanairship/iap/Product;Ljava/io/File;)V", new JValue (__self), new JValue (p1), new JValue (p2)), JniHandleOwnership.TransferLocalRef);
					return;
				}

				if (id_ctor_Lcom_urbanairship_iap_DownloadManager_Lcom_urbanairship_iap_Product_Ljava_io_File_ == IntPtr.Zero)
					id_ctor_Lcom_urbanairship_iap_DownloadManager_Lcom_urbanairship_iap_Product_Ljava_io_File_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/urbanairship/iap/DownloadManager;Lcom/urbanairship/iap/Product;Ljava/io/File;)V");
				SetHandle (JNIEnv.NewObject (class_ref, id_ctor_Lcom_urbanairship_iap_DownloadManager_Lcom_urbanairship_iap_Product_Ljava_io_File_, new JValue (__self), new JValue (p1), new JValue (p2)), JniHandleOwnership.TransferLocalRef);
			}

			static Delegate cb_onFail_Ljava_lang_Exception_;
#pragma warning disable 0169
			static Delegate GetOnFail_Ljava_lang_Exception_Handler ()
			{
				if (cb_onFail_Ljava_lang_Exception_ == null)
					cb_onFail_Ljava_lang_Exception_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnFail_Ljava_lang_Exception_);
				return cb_onFail_Ljava_lang_Exception_;
			}

			static void n_OnFail_Ljava_lang_Exception_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				UnzipDelegate __this = Java.Lang.Object.GetObject<UnzipDelegate> (native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Exception p0 = Java.Lang.Object.GetObject<global::Java.Lang.Exception> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnFail (p0);
			}
#pragma warning restore 0169

			static IntPtr id_onFail_Ljava_lang_Exception_;
			[Register ("onFail", "(Ljava/lang/Exception;)V", "GetOnFail_Ljava_lang_Exception_Handler")]
			public override void OnFail (global::Java.Lang.Exception p0)
			{
				if (id_onFail_Ljava_lang_Exception_ == IntPtr.Zero)
					id_onFail_Ljava_lang_Exception_ = JNIEnv.GetMethodID (class_ref, "onFail", "(Ljava/lang/Exception;)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onFail_Ljava_lang_Exception_, new JValue (p0));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_onFail_Ljava_lang_Exception_, new JValue (p0));
			}

			static Delegate cb_onProgressUpdate_I;
#pragma warning disable 0169
			static Delegate GetOnProgressUpdate_IHandler ()
			{
				if (cb_onProgressUpdate_I == null)
					cb_onProgressUpdate_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_OnProgressUpdate_I);
				return cb_onProgressUpdate_I;
			}

			static void n_OnProgressUpdate_I (IntPtr jnienv, IntPtr native__this, int p0)
			{
				UnzipDelegate __this = Java.Lang.Object.GetObject<UnzipDelegate> (native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnProgressUpdate (p0);
			}
#pragma warning restore 0169

			static IntPtr id_onProgressUpdate_I;
			[Register ("onProgressUpdate", "(I)V", "GetOnProgressUpdate_IHandler")]
			public override void OnProgressUpdate (int p0)
			{
				if (id_onProgressUpdate_I == IntPtr.Zero)
					id_onProgressUpdate_I = JNIEnv.GetMethodID (class_ref, "onProgressUpdate", "(I)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onProgressUpdate_I, new JValue (p0));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_onProgressUpdate_I, new JValue (p0));
			}

			static Delegate cb_onSuccess;
#pragma warning disable 0169
			static Delegate GetOnSuccessHandler ()
			{
				if (cb_onSuccess == null)
					cb_onSuccess = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnSuccess);
				return cb_onSuccess;
			}

			static void n_OnSuccess (IntPtr jnienv, IntPtr native__this)
			{
				UnzipDelegate __this = Java.Lang.Object.GetObject<UnzipDelegate> (native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnSuccess ();
			}
#pragma warning restore 0169

			static IntPtr id_onSuccess;
			[Register ("onSuccess", "()V", "GetOnSuccessHandler")]
			public override void OnSuccess ()
			{
				if (id_onSuccess == IntPtr.Zero)
					id_onSuccess = JNIEnv.GetMethodID (class_ref, "onSuccess", "()V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onSuccess);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_onSuccess);
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/urbanairship/iap/DownloadManager", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (DownloadManager); }
		}

		protected DownloadManager (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_downloadIfValid_Lcom_urbanairship_iap_Product_;
#pragma warning disable 0169
		static Delegate GetDownloadIfValid_Lcom_urbanairship_iap_Product_Handler ()
		{
			if (cb_downloadIfValid_Lcom_urbanairship_iap_Product_ == null)
				cb_downloadIfValid_Lcom_urbanairship_iap_Product_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_DownloadIfValid_Lcom_urbanairship_iap_Product_);
			return cb_downloadIfValid_Lcom_urbanairship_iap_Product_;
		}

		static void n_DownloadIfValid_Lcom_urbanairship_iap_Product_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			DownloadManager __this = Java.Lang.Object.GetObject<DownloadManager> (native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Urbanairship.Iap.Product p0 = Java.Lang.Object.GetObject<global::Com.Urbanairship.Iap.Product> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.DownloadIfValid (p0);
		}
#pragma warning restore 0169

		static IntPtr id_downloadIfValid_Lcom_urbanairship_iap_Product_;
		[Register ("downloadIfValid", "(Lcom/urbanairship/iap/Product;)V", "GetDownloadIfValid_Lcom_urbanairship_iap_Product_Handler")]
		public virtual void DownloadIfValid (global::Com.Urbanairship.Iap.Product p0)
		{
			if (id_downloadIfValid_Lcom_urbanairship_iap_Product_ == IntPtr.Zero)
				id_downloadIfValid_Lcom_urbanairship_iap_Product_ = JNIEnv.GetMethodID (class_ref, "downloadIfValid", "(Lcom/urbanairship/iap/Product;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_downloadIfValid_Lcom_urbanairship_iap_Product_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_downloadIfValid_Lcom_urbanairship_iap_Product_, new JValue (p0));
		}

		static Delegate cb_hasPendingProduct_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetHasPendingProduct_Ljava_lang_String_Handler ()
		{
			if (cb_hasPendingProduct_Ljava_lang_String_ == null)
				cb_hasPendingProduct_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_HasPendingProduct_Ljava_lang_String_);
			return cb_hasPendingProduct_Ljava_lang_String_;
		}

		static bool n_HasPendingProduct_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			DownloadManager __this = Java.Lang.Object.GetObject<DownloadManager> (native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.HasPendingProduct (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_hasPendingProduct_Ljava_lang_String_;
		[Register ("hasPendingProduct", "(Ljava/lang/String;)Z", "GetHasPendingProduct_Ljava_lang_String_Handler")]
		public virtual bool HasPendingProduct (string p0)
		{
			if (id_hasPendingProduct_Ljava_lang_String_ == IntPtr.Zero)
				id_hasPendingProduct_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "hasPendingProduct", "(Ljava/lang/String;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			bool __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallBooleanMethod  (Handle, id_hasPendingProduct_Ljava_lang_String_, new JValue (native_p0));
			else
				__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, id_hasPendingProduct_Ljava_lang_String_, new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

	}
}
