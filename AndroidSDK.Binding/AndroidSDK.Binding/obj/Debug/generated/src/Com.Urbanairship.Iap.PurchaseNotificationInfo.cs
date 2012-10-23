using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Urbanairship.Iap {

	[global::Android.Runtime.Register ("com/urbanairship/iap/PurchaseNotificationInfo", DoNotGenerateAcw=true)]
	public partial class PurchaseNotificationInfo : global::Java.Lang.Object {

		[global::Android.Runtime.Register ("com/urbanairship/iap/PurchaseNotificationInfo$NotificationType", DoNotGenerateAcw=true)]
		public sealed partial class NotificationType : global::Java.Lang.Enum {


			static IntPtr DECOMPRESSING_jfieldId;

			[Register ("DECOMPRESSING")]
			public static global::Com.Urbanairship.Iap.PurchaseNotificationInfo.NotificationType Decompressing {
				get {
					if (DECOMPRESSING_jfieldId == IntPtr.Zero)
						DECOMPRESSING_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DECOMPRESSING", "Lcom/urbanairship/iap/PurchaseNotificationInfo$NotificationType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, DECOMPRESSING_jfieldId);
					return Java.Lang.Object.GetObject<global::Com.Urbanairship.Iap.PurchaseNotificationInfo.NotificationType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (DECOMPRESSING_jfieldId == IntPtr.Zero)
						DECOMPRESSING_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DECOMPRESSING", "Lcom/urbanairship/iap/PurchaseNotificationInfo$NotificationType;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, DECOMPRESSING_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr DECOMPRESS_FAILED_jfieldId;

			[Register ("DECOMPRESS_FAILED")]
			public static global::Com.Urbanairship.Iap.PurchaseNotificationInfo.NotificationType DecompressFailed {
				get {
					if (DECOMPRESS_FAILED_jfieldId == IntPtr.Zero)
						DECOMPRESS_FAILED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DECOMPRESS_FAILED", "Lcom/urbanairship/iap/PurchaseNotificationInfo$NotificationType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, DECOMPRESS_FAILED_jfieldId);
					return Java.Lang.Object.GetObject<global::Com.Urbanairship.Iap.PurchaseNotificationInfo.NotificationType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (DECOMPRESS_FAILED_jfieldId == IntPtr.Zero)
						DECOMPRESS_FAILED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DECOMPRESS_FAILED", "Lcom/urbanairship/iap/PurchaseNotificationInfo$NotificationType;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, DECOMPRESS_FAILED_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr DOWNLOADING_jfieldId;

			[Register ("DOWNLOADING")]
			public static global::Com.Urbanairship.Iap.PurchaseNotificationInfo.NotificationType Downloading {
				get {
					if (DOWNLOADING_jfieldId == IntPtr.Zero)
						DOWNLOADING_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DOWNLOADING", "Lcom/urbanairship/iap/PurchaseNotificationInfo$NotificationType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, DOWNLOADING_jfieldId);
					return Java.Lang.Object.GetObject<global::Com.Urbanairship.Iap.PurchaseNotificationInfo.NotificationType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (DOWNLOADING_jfieldId == IntPtr.Zero)
						DOWNLOADING_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DOWNLOADING", "Lcom/urbanairship/iap/PurchaseNotificationInfo$NotificationType;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, DOWNLOADING_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr DOWNLOAD_FAILED_jfieldId;

			[Register ("DOWNLOAD_FAILED")]
			public static global::Com.Urbanairship.Iap.PurchaseNotificationInfo.NotificationType DownloadFailed {
				get {
					if (DOWNLOAD_FAILED_jfieldId == IntPtr.Zero)
						DOWNLOAD_FAILED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DOWNLOAD_FAILED", "Lcom/urbanairship/iap/PurchaseNotificationInfo$NotificationType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, DOWNLOAD_FAILED_jfieldId);
					return Java.Lang.Object.GetObject<global::Com.Urbanairship.Iap.PurchaseNotificationInfo.NotificationType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (DOWNLOAD_FAILED_jfieldId == IntPtr.Zero)
						DOWNLOAD_FAILED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DOWNLOAD_FAILED", "Lcom/urbanairship/iap/PurchaseNotificationInfo$NotificationType;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, DOWNLOAD_FAILED_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr INSTALL_SUCCESSFUL_jfieldId;

			[Register ("INSTALL_SUCCESSFUL")]
			public static global::Com.Urbanairship.Iap.PurchaseNotificationInfo.NotificationType InstallSuccessful {
				get {
					if (INSTALL_SUCCESSFUL_jfieldId == IntPtr.Zero)
						INSTALL_SUCCESSFUL_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "INSTALL_SUCCESSFUL", "Lcom/urbanairship/iap/PurchaseNotificationInfo$NotificationType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, INSTALL_SUCCESSFUL_jfieldId);
					return Java.Lang.Object.GetObject<global::Com.Urbanairship.Iap.PurchaseNotificationInfo.NotificationType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (INSTALL_SUCCESSFUL_jfieldId == IntPtr.Zero)
						INSTALL_SUCCESSFUL_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "INSTALL_SUCCESSFUL", "Lcom/urbanairship/iap/PurchaseNotificationInfo$NotificationType;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, INSTALL_SUCCESSFUL_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr VERIFYING_RECEIPT_jfieldId;

			[Register ("VERIFYING_RECEIPT")]
			public static global::Com.Urbanairship.Iap.PurchaseNotificationInfo.NotificationType VerifyingReceipt {
				get {
					if (VERIFYING_RECEIPT_jfieldId == IntPtr.Zero)
						VERIFYING_RECEIPT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VERIFYING_RECEIPT", "Lcom/urbanairship/iap/PurchaseNotificationInfo$NotificationType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VERIFYING_RECEIPT_jfieldId);
					return Java.Lang.Object.GetObject<global::Com.Urbanairship.Iap.PurchaseNotificationInfo.NotificationType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (VERIFYING_RECEIPT_jfieldId == IntPtr.Zero)
						VERIFYING_RECEIPT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VERIFYING_RECEIPT", "Lcom/urbanairship/iap/PurchaseNotificationInfo$NotificationType;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, VERIFYING_RECEIPT_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/urbanairship/iap/PurchaseNotificationInfo$NotificationType", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (NotificationType); }
			}

			internal NotificationType (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_valueOf_Ljava_lang_String_;
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/urbanairship/iap/PurchaseNotificationInfo$NotificationType;", "")]
			public static global::Com.Urbanairship.Iap.PurchaseNotificationInfo.NotificationType ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/urbanairship/iap/PurchaseNotificationInfo$NotificationType;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				global::Com.Urbanairship.Iap.PurchaseNotificationInfo.NotificationType __ret = Java.Lang.Object.GetObject<global::Com.Urbanairship.Iap.PurchaseNotificationInfo.NotificationType> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
				JNIEnv.DeleteLocalRef (native_p0);
				return __ret;
			}

			static IntPtr id_values;
			[Register ("values", "()[Lcom/urbanairship/iap/PurchaseNotificationInfo$NotificationType;", "")]
			public static global::Com.Urbanairship.Iap.PurchaseNotificationInfo.NotificationType[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/urbanairship/iap/PurchaseNotificationInfo$NotificationType;");
				return (Com.Urbanairship.Iap.PurchaseNotificationInfo.NotificationType[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Urbanairship.Iap.PurchaseNotificationInfo.NotificationType));
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/urbanairship/iap/PurchaseNotificationInfo", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (PurchaseNotificationInfo); }
		}

		protected PurchaseNotificationInfo (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_urbanairship_iap_PurchaseNotificationInfo_NotificationType_Ljava_lang_String_Ljava_lang_String_;
		[Register (".ctor", "(Lcom/urbanairship/iap/PurchaseNotificationInfo$NotificationType;Ljava/lang/String;Ljava/lang/String;)V", "")]
		public PurchaseNotificationInfo (global::Com.Urbanairship.Iap.PurchaseNotificationInfo.NotificationType p0, string p1, string p2) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p1 = JNIEnv.NewString (p1);;
			IntPtr native_p2 = JNIEnv.NewString (p2);;
			if (GetType () != typeof (PurchaseNotificationInfo)) {
				SetHandle (global::Android.Runtime.JNIEnv.CreateInstance (GetType (), "(Lcom/urbanairship/iap/PurchaseNotificationInfo$NotificationType;Ljava/lang/String;Ljava/lang/String;)V", new JValue (p0), new JValue (native_p1), new JValue (native_p2)), JniHandleOwnership.TransferLocalRef);
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
				return;
			}

			if (id_ctor_Lcom_urbanairship_iap_PurchaseNotificationInfo_NotificationType_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_ctor_Lcom_urbanairship_iap_PurchaseNotificationInfo_NotificationType_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/urbanairship/iap/PurchaseNotificationInfo$NotificationType;Ljava/lang/String;Ljava/lang/String;)V");
			SetHandle (JNIEnv.NewObject (class_ref, id_ctor_Lcom_urbanairship_iap_PurchaseNotificationInfo_NotificationType_Ljava_lang_String_Ljava_lang_String_, new JValue (p0), new JValue (native_p1), new JValue (native_p2)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p1);
			JNIEnv.DeleteLocalRef (native_p2);
		}

		static Delegate cb_getFlags;
#pragma warning disable 0169
		static Delegate GetGetFlagsHandler ()
		{
			if (cb_getFlags == null)
				cb_getFlags = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetFlags);
			return cb_getFlags;
		}

		static int n_GetFlags (IntPtr jnienv, IntPtr native__this)
		{
			PurchaseNotificationInfo __this = Java.Lang.Object.GetObject<PurchaseNotificationInfo> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Flags;
		}
#pragma warning restore 0169

		static Delegate cb_setFlags_I;
#pragma warning disable 0169
		static Delegate GetSetFlags_IHandler ()
		{
			if (cb_setFlags_I == null)
				cb_setFlags_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetFlags_I);
			return cb_setFlags_I;
		}

		static void n_SetFlags_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			PurchaseNotificationInfo __this = Java.Lang.Object.GetObject<PurchaseNotificationInfo> (native__this, JniHandleOwnership.DoNotTransfer);
			__this.Flags = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getFlags;
		static IntPtr id_setFlags_I;
		public virtual int Flags {
			[Register ("getFlags", "()I", "GetGetFlagsHandler")]
			get {
				if (id_getFlags == IntPtr.Zero)
					id_getFlags = JNIEnv.GetMethodID (class_ref, "getFlags", "()I");

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_getFlags);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, id_getFlags);
			}
			[Register ("setFlags", "(I)V", "GetSetFlags_IHandler")]
			set {
				if (id_setFlags_I == IntPtr.Zero)
					id_setFlags_I = JNIEnv.GetMethodID (class_ref, "setFlags", "(I)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setFlags_I, new JValue (value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_setFlags_I, new JValue (value));
			}
		}

		static Delegate cb_getNotificationId;
#pragma warning disable 0169
		static Delegate GetGetNotificationIdHandler ()
		{
			if (cb_getNotificationId == null)
				cb_getNotificationId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetNotificationId);
			return cb_getNotificationId;
		}

		static int n_GetNotificationId (IntPtr jnienv, IntPtr native__this)
		{
			PurchaseNotificationInfo __this = Java.Lang.Object.GetObject<PurchaseNotificationInfo> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.NotificationId;
		}
#pragma warning restore 0169

		static Delegate cb_setNotificationId_I;
#pragma warning disable 0169
		static Delegate GetSetNotificationId_IHandler ()
		{
			if (cb_setNotificationId_I == null)
				cb_setNotificationId_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetNotificationId_I);
			return cb_setNotificationId_I;
		}

		static void n_SetNotificationId_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			PurchaseNotificationInfo __this = Java.Lang.Object.GetObject<PurchaseNotificationInfo> (native__this, JniHandleOwnership.DoNotTransfer);
			__this.NotificationId = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getNotificationId;
		static IntPtr id_setNotificationId_I;
		public virtual int NotificationId {
			[Register ("getNotificationId", "()I", "GetGetNotificationIdHandler")]
			get {
				if (id_getNotificationId == IntPtr.Zero)
					id_getNotificationId = JNIEnv.GetMethodID (class_ref, "getNotificationId", "()I");

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_getNotificationId);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, id_getNotificationId);
			}
			[Register ("setNotificationId", "(I)V", "GetSetNotificationId_IHandler")]
			set {
				if (id_setNotificationId_I == IntPtr.Zero)
					id_setNotificationId_I = JNIEnv.GetMethodID (class_ref, "setNotificationId", "(I)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setNotificationId_I, new JValue (value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_setNotificationId_I, new JValue (value));
			}
		}

		static Delegate cb_getProductId;
#pragma warning disable 0169
		static Delegate GetGetProductIdHandler ()
		{
			if (cb_getProductId == null)
				cb_getProductId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetProductId);
			return cb_getProductId;
		}

		static IntPtr n_GetProductId (IntPtr jnienv, IntPtr native__this)
		{
			PurchaseNotificationInfo __this = Java.Lang.Object.GetObject<PurchaseNotificationInfo> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ProductId);
		}
#pragma warning restore 0169

		static Delegate cb_setProductId_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetProductId_Ljava_lang_String_Handler ()
		{
			if (cb_setProductId_Ljava_lang_String_ == null)
				cb_setProductId_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetProductId_Ljava_lang_String_);
			return cb_setProductId_Ljava_lang_String_;
		}

		static void n_SetProductId_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			PurchaseNotificationInfo __this = Java.Lang.Object.GetObject<PurchaseNotificationInfo> (native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ProductId = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getProductId;
		static IntPtr id_setProductId_Ljava_lang_String_;
		public virtual string ProductId {
			[Register ("getProductId", "()Ljava/lang/String;", "GetGetProductIdHandler")]
			get {
				if (id_getProductId == IntPtr.Zero)
					id_getProductId = JNIEnv.GetMethodID (class_ref, "getProductId", "()Ljava/lang/String;");

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getProductId), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getProductId), JniHandleOwnership.TransferLocalRef);
			}
			[Register ("setProductId", "(Ljava/lang/String;)V", "GetSetProductId_Ljava_lang_String_Handler")]
			set {
				if (id_setProductId_Ljava_lang_String_ == IntPtr.Zero)
					id_setProductId_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setProductId", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setProductId_Ljava_lang_String_, new JValue (native_value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_setProductId_Ljava_lang_String_, new JValue (native_value));
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static Delegate cb_getProductName;
#pragma warning disable 0169
		static Delegate GetGetProductNameHandler ()
		{
			if (cb_getProductName == null)
				cb_getProductName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetProductName);
			return cb_getProductName;
		}

		static IntPtr n_GetProductName (IntPtr jnienv, IntPtr native__this)
		{
			PurchaseNotificationInfo __this = Java.Lang.Object.GetObject<PurchaseNotificationInfo> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ProductName);
		}
#pragma warning restore 0169

		static Delegate cb_setProductName_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetProductName_Ljava_lang_String_Handler ()
		{
			if (cb_setProductName_Ljava_lang_String_ == null)
				cb_setProductName_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetProductName_Ljava_lang_String_);
			return cb_setProductName_Ljava_lang_String_;
		}

		static void n_SetProductName_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			PurchaseNotificationInfo __this = Java.Lang.Object.GetObject<PurchaseNotificationInfo> (native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ProductName = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getProductName;
		static IntPtr id_setProductName_Ljava_lang_String_;
		public virtual string ProductName {
			[Register ("getProductName", "()Ljava/lang/String;", "GetGetProductNameHandler")]
			get {
				if (id_getProductName == IntPtr.Zero)
					id_getProductName = JNIEnv.GetMethodID (class_ref, "getProductName", "()Ljava/lang/String;");

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getProductName), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getProductName), JniHandleOwnership.TransferLocalRef);
			}
			[Register ("setProductName", "(Ljava/lang/String;)V", "GetSetProductName_Ljava_lang_String_Handler")]
			set {
				if (id_setProductName_Ljava_lang_String_ == IntPtr.Zero)
					id_setProductName_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setProductName", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setProductName_Ljava_lang_String_, new JValue (native_value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_setProductName_Ljava_lang_String_, new JValue (native_value));
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static Delegate cb_getProgress;
#pragma warning disable 0169
		static Delegate GetGetProgressHandler ()
		{
			if (cb_getProgress == null)
				cb_getProgress = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetProgress);
			return cb_getProgress;
		}

		static int n_GetProgress (IntPtr jnienv, IntPtr native__this)
		{
			PurchaseNotificationInfo __this = Java.Lang.Object.GetObject<PurchaseNotificationInfo> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Progress;
		}
#pragma warning restore 0169

		static Delegate cb_setProgress_I;
#pragma warning disable 0169
		static Delegate GetSetProgress_IHandler ()
		{
			if (cb_setProgress_I == null)
				cb_setProgress_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetProgress_I);
			return cb_setProgress_I;
		}

		static void n_SetProgress_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			PurchaseNotificationInfo __this = Java.Lang.Object.GetObject<PurchaseNotificationInfo> (native__this, JniHandleOwnership.DoNotTransfer);
			__this.Progress = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getProgress;
		static IntPtr id_setProgress_I;
		public virtual int Progress {
			[Register ("getProgress", "()I", "GetGetProgressHandler")]
			get {
				if (id_getProgress == IntPtr.Zero)
					id_getProgress = JNIEnv.GetMethodID (class_ref, "getProgress", "()I");

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_getProgress);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, id_getProgress);
			}
			[Register ("setProgress", "(I)V", "GetSetProgress_IHandler")]
			set {
				if (id_setProgress_I == IntPtr.Zero)
					id_setProgress_I = JNIEnv.GetMethodID (class_ref, "setProgress", "(I)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setProgress_I, new JValue (value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_setProgress_I, new JValue (value));
			}
		}

		static Delegate cb_getTimestamp;
#pragma warning disable 0169
		static Delegate GetGetTimestampHandler ()
		{
			if (cb_getTimestamp == null)
				cb_getTimestamp = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetTimestamp);
			return cb_getTimestamp;
		}

		static long n_GetTimestamp (IntPtr jnienv, IntPtr native__this)
		{
			PurchaseNotificationInfo __this = Java.Lang.Object.GetObject<PurchaseNotificationInfo> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Timestamp;
		}
#pragma warning restore 0169

		static Delegate cb_setTimestamp_J;
#pragma warning disable 0169
		static Delegate GetSetTimestamp_JHandler ()
		{
			if (cb_setTimestamp_J == null)
				cb_setTimestamp_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_SetTimestamp_J);
			return cb_setTimestamp_J;
		}

		static void n_SetTimestamp_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			PurchaseNotificationInfo __this = Java.Lang.Object.GetObject<PurchaseNotificationInfo> (native__this, JniHandleOwnership.DoNotTransfer);
			__this.Timestamp = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getTimestamp;
		static IntPtr id_setTimestamp_J;
		public virtual long Timestamp {
			[Register ("getTimestamp", "()J", "GetGetTimestampHandler")]
			get {
				if (id_getTimestamp == IntPtr.Zero)
					id_getTimestamp = JNIEnv.GetMethodID (class_ref, "getTimestamp", "()J");

				if (GetType () == ThresholdType)
					return JNIEnv.CallLongMethod  (Handle, id_getTimestamp);
				else
					return JNIEnv.CallNonvirtualLongMethod  (Handle, ThresholdClass, id_getTimestamp);
			}
			[Register ("setTimestamp", "(J)V", "GetSetTimestamp_JHandler")]
			set {
				if (id_setTimestamp_J == IntPtr.Zero)
					id_setTimestamp_J = JNIEnv.GetMethodID (class_ref, "setTimestamp", "(J)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setTimestamp_J, new JValue (value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_setTimestamp_J, new JValue (value));
			}
		}

		static Delegate cb_getNotificationType;
#pragma warning disable 0169
		static Delegate GetGetNotificationTypeHandler ()
		{
			if (cb_getNotificationType == null)
				cb_getNotificationType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetNotificationType);
			return cb_getNotificationType;
		}

		static IntPtr n_GetNotificationType (IntPtr jnienv, IntPtr native__this)
		{
			PurchaseNotificationInfo __this = Java.Lang.Object.GetObject<PurchaseNotificationInfo> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetNotificationType ());
		}
#pragma warning restore 0169

		static IntPtr id_getNotificationType;
		[Register ("getNotificationType", "()Lcom/urbanairship/iap/PurchaseNotificationInfo$NotificationType;", "GetGetNotificationTypeHandler")]
		public virtual global::Com.Urbanairship.Iap.PurchaseNotificationInfo.NotificationType GetNotificationType ()
		{
			if (id_getNotificationType == IntPtr.Zero)
				id_getNotificationType = JNIEnv.GetMethodID (class_ref, "getNotificationType", "()Lcom/urbanairship/iap/PurchaseNotificationInfo$NotificationType;");

			if (GetType () == ThresholdType)
				return Java.Lang.Object.GetObject<global::Com.Urbanairship.Iap.PurchaseNotificationInfo.NotificationType> (JNIEnv.CallObjectMethod  (Handle, id_getNotificationType), JniHandleOwnership.TransferLocalRef);
			else
				return Java.Lang.Object.GetObject<global::Com.Urbanairship.Iap.PurchaseNotificationInfo.NotificationType> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getNotificationType), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_setNotificationType_Lcom_urbanairship_iap_PurchaseNotificationInfo_NotificationType_;
#pragma warning disable 0169
		static Delegate GetSetNotificationType_Lcom_urbanairship_iap_PurchaseNotificationInfo_NotificationType_Handler ()
		{
			if (cb_setNotificationType_Lcom_urbanairship_iap_PurchaseNotificationInfo_NotificationType_ == null)
				cb_setNotificationType_Lcom_urbanairship_iap_PurchaseNotificationInfo_NotificationType_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetNotificationType_Lcom_urbanairship_iap_PurchaseNotificationInfo_NotificationType_);
			return cb_setNotificationType_Lcom_urbanairship_iap_PurchaseNotificationInfo_NotificationType_;
		}

		static void n_SetNotificationType_Lcom_urbanairship_iap_PurchaseNotificationInfo_NotificationType_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			PurchaseNotificationInfo __this = Java.Lang.Object.GetObject<PurchaseNotificationInfo> (native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Urbanairship.Iap.PurchaseNotificationInfo.NotificationType p0 = Java.Lang.Object.GetObject<global::Com.Urbanairship.Iap.PurchaseNotificationInfo.NotificationType> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetNotificationType (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setNotificationType_Lcom_urbanairship_iap_PurchaseNotificationInfo_NotificationType_;
		[Register ("setNotificationType", "(Lcom/urbanairship/iap/PurchaseNotificationInfo$NotificationType;)V", "GetSetNotificationType_Lcom_urbanairship_iap_PurchaseNotificationInfo_NotificationType_Handler")]
		public virtual void SetNotificationType (global::Com.Urbanairship.Iap.PurchaseNotificationInfo.NotificationType p0)
		{
			if (id_setNotificationType_Lcom_urbanairship_iap_PurchaseNotificationInfo_NotificationType_ == IntPtr.Zero)
				id_setNotificationType_Lcom_urbanairship_iap_PurchaseNotificationInfo_NotificationType_ = JNIEnv.GetMethodID (class_ref, "setNotificationType", "(Lcom/urbanairship/iap/PurchaseNotificationInfo$NotificationType;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setNotificationType_Lcom_urbanairship_iap_PurchaseNotificationInfo_NotificationType_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_setNotificationType_Lcom_urbanairship_iap_PurchaseNotificationInfo_NotificationType_, new JValue (p0));
		}

	}
}
