using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Urbanairship.Iap {

	[global::Android.Runtime.Register ("com/urbanairship/iap/IAPManager", DoNotGenerateAcw=true)]
	public sealed partial class IAPManager : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/urbanairship/iap/IAPManager", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IAPManager); }
		}

		internal IAPManager (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_getAppIcon;
		public int AppIcon {
			[Register ("getAppIcon", "()I", "GetGetAppIconHandler")]
			get {
				if (id_getAppIcon == IntPtr.Zero)
					id_getAppIcon = JNIEnv.GetMethodID (class_ref, "getAppIcon", "()I");
				return JNIEnv.CallIntMethod  (Handle, id_getAppIcon);
			}
		}

		static IntPtr id_getAppName;
		public string AppName {
			[Register ("getAppName", "()Ljava/lang/String;", "GetGetAppNameHandler")]
			get {
				if (id_getAppName == IntPtr.Zero)
					id_getAppName = JNIEnv.GetMethodID (class_ref, "getAppName", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getAppName), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_getDownloadPath;
		static IntPtr id_setDownloadPath_Ljava_lang_String_;
		public string DownloadPath {
			[Register ("getDownloadPath", "()Ljava/lang/String;", "GetGetDownloadPathHandler")]
			get {
				if (id_getDownloadPath == IntPtr.Zero)
					id_getDownloadPath = JNIEnv.GetMethodID (class_ref, "getDownloadPath", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getDownloadPath), JniHandleOwnership.TransferLocalRef);
			}
			[Register ("setDownloadPath", "(Ljava/lang/String;)V", "GetSetDownloadPath_Ljava_lang_String_Handler")]
			set {
				if (id_setDownloadPath_Ljava_lang_String_ == IntPtr.Zero)
					id_setDownloadPath_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setDownloadPath", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				JNIEnv.CallVoidMethod  (Handle, id_setDownloadPath_Ljava_lang_String_, new JValue (native_value));
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr id_getEventListener;
		static IntPtr id_setEventListener_Lcom_urbanairship_iap_IAPEventListener_;
		public global::Com.Urbanairship.Iap.IAPEventListener EventListener {
			[Register ("getEventListener", "()Lcom/urbanairship/iap/IAPEventListener;", "GetGetEventListenerHandler")]
			get {
				if (id_getEventListener == IntPtr.Zero)
					id_getEventListener = JNIEnv.GetMethodID (class_ref, "getEventListener", "()Lcom/urbanairship/iap/IAPEventListener;");
				return Java.Lang.Object.GetObject<global::Com.Urbanairship.Iap.IAPEventListener> (JNIEnv.CallObjectMethod  (Handle, id_getEventListener), JniHandleOwnership.TransferLocalRef);
			}
			[Register ("setEventListener", "(Lcom/urbanairship/iap/IAPEventListener;)V", "GetSetEventListener_Lcom_urbanairship_iap_IAPEventListener_Handler")]
			set {
				if (id_setEventListener_Lcom_urbanairship_iap_IAPEventListener_ == IntPtr.Zero)
					id_setEventListener_Lcom_urbanairship_iap_IAPEventListener_ = JNIEnv.GetMethodID (class_ref, "setEventListener", "(Lcom/urbanairship/iap/IAPEventListener;)V");
				JNIEnv.CallVoidMethod  (Handle, id_setEventListener_Lcom_urbanairship_iap_IAPEventListener_, new JValue (value));
			}
		}

		static IntPtr id_getInventory;
		public global::Com.Urbanairship.Iap.Inventory Inventory {
			[Register ("getInventory", "()Lcom/urbanairship/iap/Inventory;", "GetGetInventoryHandler")]
			get {
				if (id_getInventory == IntPtr.Zero)
					id_getInventory = JNIEnv.GetMethodID (class_ref, "getInventory", "()Lcom/urbanairship/iap/Inventory;");
				return Java.Lang.Object.GetObject<global::Com.Urbanairship.Iap.Inventory> (JNIEnv.CallObjectMethod  (Handle, id_getInventory), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_isBillingSupported;
		public static bool IsBillingSupported {
			[Register ("isBillingSupported", "()Z", "GetIsBillingSupportedHandler")]
			get {
				if (id_isBillingSupported == IntPtr.Zero)
					id_isBillingSupported = JNIEnv.GetStaticMethodID (class_ref, "isBillingSupported", "()Z");
				return JNIEnv.CallStaticBooleanMethod  (class_ref, id_isBillingSupported);
			}
		}

		static IntPtr id_getNotificationBuilder;
		static IntPtr id_setNotificationBuilder_Lcom_urbanairship_iap_PurchaseNotificationBuilder_;
		public global::Com.Urbanairship.Iap.IPurchaseNotificationBuilder NotificationBuilder {
			[Register ("getNotificationBuilder", "()Lcom/urbanairship/iap/PurchaseNotificationBuilder;", "GetGetNotificationBuilderHandler")]
			get {
				if (id_getNotificationBuilder == IntPtr.Zero)
					id_getNotificationBuilder = JNIEnv.GetMethodID (class_ref, "getNotificationBuilder", "()Lcom/urbanairship/iap/PurchaseNotificationBuilder;");
				return Java.Lang.Object.GetObject<global::Com.Urbanairship.Iap.IPurchaseNotificationBuilder> (JNIEnv.CallObjectMethod  (Handle, id_getNotificationBuilder), JniHandleOwnership.TransferLocalRef);
			}
			[Register ("setNotificationBuilder", "(Lcom/urbanairship/iap/PurchaseNotificationBuilder;)V", "GetSetNotificationBuilder_Lcom_urbanairship_iap_PurchaseNotificationBuilder_Handler")]
			set {
				if (id_setNotificationBuilder_Lcom_urbanairship_iap_PurchaseNotificationBuilder_ == IntPtr.Zero)
					id_setNotificationBuilder_Lcom_urbanairship_iap_PurchaseNotificationBuilder_ = JNIEnv.GetMethodID (class_ref, "setNotificationBuilder", "(Lcom/urbanairship/iap/PurchaseNotificationBuilder;)V");
				JNIEnv.CallVoidMethod  (Handle, id_setNotificationBuilder_Lcom_urbanairship_iap_PurchaseNotificationBuilder_, new JValue (value));
			}
		}

		static IntPtr id_getTempPath;
		static IntPtr id_setTempPath_Ljava_lang_String_;
		public string TempPath {
			[Register ("getTempPath", "()Ljava/lang/String;", "GetGetTempPathHandler")]
			get {
				if (id_getTempPath == IntPtr.Zero)
					id_getTempPath = JNIEnv.GetMethodID (class_ref, "getTempPath", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getTempPath), JniHandleOwnership.TransferLocalRef);
			}
			[Register ("setTempPath", "(Ljava/lang/String;)V", "GetSetTempPath_Ljava_lang_String_Handler")]
			set {
				if (id_setTempPath_Ljava_lang_String_ == IntPtr.Zero)
					id_setTempPath_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setTempPath", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				JNIEnv.CallVoidMethod  (Handle, id_setTempPath_Ljava_lang_String_, new JValue (native_value));
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr id_init;
		[Register ("init", "()V", "")]
		public static void Init ()
		{
			if (id_init == IntPtr.Zero)
				id_init = JNIEnv.GetStaticMethodID (class_ref, "init", "()V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_init);
		}

		static IntPtr id_restoreTransactions;
		[Register ("restoreTransactions", "()V", "")]
		public void RestoreTransactions ()
		{
			if (id_restoreTransactions == IntPtr.Zero)
				id_restoreTransactions = JNIEnv.GetMethodID (class_ref, "restoreTransactions", "()V");
			JNIEnv.CallVoidMethod  (Handle, id_restoreTransactions);
		}

		static IntPtr id_shared;
		[Register ("shared", "()Lcom/urbanairship/iap/IAPManager;", "")]
		public static global::Com.Urbanairship.Iap.IAPManager Shared ()
		{
			if (id_shared == IntPtr.Zero)
				id_shared = JNIEnv.GetStaticMethodID (class_ref, "shared", "()Lcom/urbanairship/iap/IAPManager;");
			return Java.Lang.Object.GetObject<global::Com.Urbanairship.Iap.IAPManager> (JNIEnv.CallStaticObjectMethod  (class_ref, id_shared), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_tearDown;
		[Register ("tearDown", "()V", "")]
		public static void TearDown ()
		{
			if (id_tearDown == IntPtr.Zero)
				id_tearDown = JNIEnv.GetStaticMethodID (class_ref, "tearDown", "()V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_tearDown);
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
