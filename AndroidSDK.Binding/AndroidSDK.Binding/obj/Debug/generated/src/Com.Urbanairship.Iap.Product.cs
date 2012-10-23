using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Urbanairship.Iap {

	[global::Android.Runtime.Register ("com/urbanairship/iap/Product", DoNotGenerateAcw=true)]
	public partial class Product : global::Java.Lang.Object {

		[global::Android.Runtime.Register ("com/urbanairship/iap/Product$ProductObservable", DoNotGenerateAcw=true)]
		public partial class ProductObservable : global::Java.Util.Observable {

			protected ProductObservable (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		}

		[global::Android.Runtime.Register ("com/urbanairship/iap/Product$Status", DoNotGenerateAcw=true)]
		public sealed partial class Status : global::Java.Lang.Enum {


			static IntPtr DOWNLOADING_jfieldId;

			[Register ("DOWNLOADING")]
			public static global::Com.Urbanairship.Iap.Product.Status Downloading {
				get {
					if (DOWNLOADING_jfieldId == IntPtr.Zero)
						DOWNLOADING_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DOWNLOADING", "Lcom/urbanairship/iap/Product$Status;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, DOWNLOADING_jfieldId);
					return Java.Lang.Object.GetObject<global::Com.Urbanairship.Iap.Product.Status> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (DOWNLOADING_jfieldId == IntPtr.Zero)
						DOWNLOADING_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DOWNLOADING", "Lcom/urbanairship/iap/Product$Status;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, DOWNLOADING_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr INSTALLED_jfieldId;

			[Register ("INSTALLED")]
			public static global::Com.Urbanairship.Iap.Product.Status Installed {
				get {
					if (INSTALLED_jfieldId == IntPtr.Zero)
						INSTALLED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "INSTALLED", "Lcom/urbanairship/iap/Product$Status;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, INSTALLED_jfieldId);
					return Java.Lang.Object.GetObject<global::Com.Urbanairship.Iap.Product.Status> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (INSTALLED_jfieldId == IntPtr.Zero)
						INSTALLED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "INSTALLED", "Lcom/urbanairship/iap/Product$Status;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, INSTALLED_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr PURCHASED_jfieldId;

			[Register ("PURCHASED")]
			public static global::Com.Urbanairship.Iap.Product.Status Purchased {
				get {
					if (PURCHASED_jfieldId == IntPtr.Zero)
						PURCHASED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PURCHASED", "Lcom/urbanairship/iap/Product$Status;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, PURCHASED_jfieldId);
					return Java.Lang.Object.GetObject<global::Com.Urbanairship.Iap.Product.Status> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (PURCHASED_jfieldId == IntPtr.Zero)
						PURCHASED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PURCHASED", "Lcom/urbanairship/iap/Product$Status;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, PURCHASED_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr UNPURCHASED_jfieldId;

			[Register ("UNPURCHASED")]
			public static global::Com.Urbanairship.Iap.Product.Status Unpurchased {
				get {
					if (UNPURCHASED_jfieldId == IntPtr.Zero)
						UNPURCHASED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "UNPURCHASED", "Lcom/urbanairship/iap/Product$Status;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, UNPURCHASED_jfieldId);
					return Java.Lang.Object.GetObject<global::Com.Urbanairship.Iap.Product.Status> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (UNPURCHASED_jfieldId == IntPtr.Zero)
						UNPURCHASED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "UNPURCHASED", "Lcom/urbanairship/iap/Product$Status;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, UNPURCHASED_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr UPDATE_jfieldId;

			[Register ("UPDATE")]
			public static global::Com.Urbanairship.Iap.Product.Status Update {
				get {
					if (UPDATE_jfieldId == IntPtr.Zero)
						UPDATE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "UPDATE", "Lcom/urbanairship/iap/Product$Status;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, UPDATE_jfieldId);
					return Java.Lang.Object.GetObject<global::Com.Urbanairship.Iap.Product.Status> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (UPDATE_jfieldId == IntPtr.Zero)
						UPDATE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "UPDATE", "Lcom/urbanairship/iap/Product$Status;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, UPDATE_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr WAITING_jfieldId;

			[Register ("WAITING")]
			public static global::Com.Urbanairship.Iap.Product.Status Waiting {
				get {
					if (WAITING_jfieldId == IntPtr.Zero)
						WAITING_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "WAITING", "Lcom/urbanairship/iap/Product$Status;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, WAITING_jfieldId);
					return Java.Lang.Object.GetObject<global::Com.Urbanairship.Iap.Product.Status> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (WAITING_jfieldId == IntPtr.Zero)
						WAITING_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "WAITING", "Lcom/urbanairship/iap/Product$Status;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, WAITING_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/urbanairship/iap/Product$Status", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Status); }
			}

			internal Status (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_valueOf_Ljava_lang_String_;
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/urbanairship/iap/Product$Status;", "")]
			public static global::Com.Urbanairship.Iap.Product.Status ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/urbanairship/iap/Product$Status;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				global::Com.Urbanairship.Iap.Product.Status __ret = Java.Lang.Object.GetObject<global::Com.Urbanairship.Iap.Product.Status> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
				JNIEnv.DeleteLocalRef (native_p0);
				return __ret;
			}

			static IntPtr id_values;
			[Register ("values", "()[Lcom/urbanairship/iap/Product$Status;", "")]
			public static global::Com.Urbanairship.Iap.Product.Status[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/urbanairship/iap/Product$Status;");
				return (Com.Urbanairship.Iap.Product.Status[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Urbanairship.Iap.Product.Status));
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/urbanairship/iap/Product", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Product); }
		}

		protected Product (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_getDescription;
#pragma warning disable 0169
		static Delegate GetGetDescriptionHandler ()
		{
			if (cb_getDescription == null)
				cb_getDescription = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDescription);
			return cb_getDescription;
		}

		static IntPtr n_GetDescription (IntPtr jnienv, IntPtr native__this)
		{
			Product __this = Java.Lang.Object.GetObject<Product> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Description);
		}
#pragma warning restore 0169

		static IntPtr id_getDescription;
		public virtual string Description {
			[Register ("getDescription", "()Ljava/lang/String;", "GetGetDescriptionHandler")]
			get {
				if (id_getDescription == IntPtr.Zero)
					id_getDescription = JNIEnv.GetMethodID (class_ref, "getDescription", "()Ljava/lang/String;");

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getDescription), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getDescription), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getDownloadPath;
#pragma warning disable 0169
		static Delegate GetGetDownloadPathHandler ()
		{
			if (cb_getDownloadPath == null)
				cb_getDownloadPath = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDownloadPath);
			return cb_getDownloadPath;
		}

		static IntPtr n_GetDownloadPath (IntPtr jnienv, IntPtr native__this)
		{
			Product __this = Java.Lang.Object.GetObject<Product> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.DownloadPath);
		}
#pragma warning restore 0169

		static IntPtr id_getDownloadPath;
		public virtual global::Java.IO.File DownloadPath {
			[Register ("getDownloadPath", "()Ljava/io/File;", "GetGetDownloadPathHandler")]
			get {
				if (id_getDownloadPath == IntPtr.Zero)
					id_getDownloadPath = JNIEnv.GetMethodID (class_ref, "getDownloadPath", "()Ljava/io/File;");

				if (GetType () == ThresholdType)
					return Java.Lang.Object.GetObject<global::Java.IO.File> (JNIEnv.CallObjectMethod  (Handle, id_getDownloadPath), JniHandleOwnership.TransferLocalRef);
				else
					return Java.Lang.Object.GetObject<global::Java.IO.File> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getDownloadPath), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getDownloadURLString;
#pragma warning disable 0169
		static Delegate GetGetDownloadURLStringHandler ()
		{
			if (cb_getDownloadURLString == null)
				cb_getDownloadURLString = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDownloadURLString);
			return cb_getDownloadURLString;
		}

		static IntPtr n_GetDownloadURLString (IntPtr jnienv, IntPtr native__this)
		{
			Product __this = Java.Lang.Object.GetObject<Product> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.DownloadURLString);
		}
#pragma warning restore 0169

		static IntPtr id_getDownloadURLString;
		public virtual string DownloadURLString {
			[Register ("getDownloadURLString", "()Ljava/lang/String;", "GetGetDownloadURLStringHandler")]
			get {
				if (id_getDownloadURLString == IntPtr.Zero)
					id_getDownloadURLString = JNIEnv.GetMethodID (class_ref, "getDownloadURLString", "()Ljava/lang/String;");

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getDownloadURLString), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getDownloadURLString), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getFileSize;
#pragma warning disable 0169
		static Delegate GetGetFileSizeHandler ()
		{
			if (cb_getFileSize == null)
				cb_getFileSize = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double>) n_GetFileSize);
			return cb_getFileSize;
		}

		static double n_GetFileSize (IntPtr jnienv, IntPtr native__this)
		{
			Product __this = Java.Lang.Object.GetObject<Product> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.FileSize;
		}
#pragma warning restore 0169

		static IntPtr id_getFileSize;
		public virtual double FileSize {
			[Register ("getFileSize", "()D", "GetGetFileSizeHandler")]
			get {
				if (id_getFileSize == IntPtr.Zero)
					id_getFileSize = JNIEnv.GetMethodID (class_ref, "getFileSize", "()D");

				if (GetType () == ThresholdType)
					return JNIEnv.CallDoubleMethod  (Handle, id_getFileSize);
				else
					return JNIEnv.CallNonvirtualDoubleMethod  (Handle, ThresholdClass, id_getFileSize);
			}
		}

		static Delegate cb_getHumanReadableFileSize;
#pragma warning disable 0169
		static Delegate GetGetHumanReadableFileSizeHandler ()
		{
			if (cb_getHumanReadableFileSize == null)
				cb_getHumanReadableFileSize = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetHumanReadableFileSize);
			return cb_getHumanReadableFileSize;
		}

		static IntPtr n_GetHumanReadableFileSize (IntPtr jnienv, IntPtr native__this)
		{
			Product __this = Java.Lang.Object.GetObject<Product> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.HumanReadableFileSize);
		}
#pragma warning restore 0169

		static IntPtr id_getHumanReadableFileSize;
		public virtual string HumanReadableFileSize {
			[Register ("getHumanReadableFileSize", "()Ljava/lang/String;", "GetGetHumanReadableFileSizeHandler")]
			get {
				if (id_getHumanReadableFileSize == IntPtr.Zero)
					id_getHumanReadableFileSize = JNIEnv.GetMethodID (class_ref, "getHumanReadableFileSize", "()Ljava/lang/String;");

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getHumanReadableFileSize), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getHumanReadableFileSize), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getIconURLString;
#pragma warning disable 0169
		static Delegate GetGetIconURLStringHandler ()
		{
			if (cb_getIconURLString == null)
				cb_getIconURLString = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetIconURLString);
			return cb_getIconURLString;
		}

		static IntPtr n_GetIconURLString (IntPtr jnienv, IntPtr native__this)
		{
			Product __this = Java.Lang.Object.GetObject<Product> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.IconURLString);
		}
#pragma warning restore 0169

		static IntPtr id_getIconURLString;
		public virtual string IconURLString {
			[Register ("getIconURLString", "()Ljava/lang/String;", "GetGetIconURLStringHandler")]
			get {
				if (id_getIconURLString == IntPtr.Zero)
					id_getIconURLString = JNIEnv.GetMethodID (class_ref, "getIconURLString", "()Ljava/lang/String;");

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getIconURLString), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getIconURLString), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getIdentifier;
#pragma warning disable 0169
		static Delegate GetGetIdentifierHandler ()
		{
			if (cb_getIdentifier == null)
				cb_getIdentifier = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetIdentifier);
			return cb_getIdentifier;
		}

		static IntPtr n_GetIdentifier (IntPtr jnienv, IntPtr native__this)
		{
			Product __this = Java.Lang.Object.GetObject<Product> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Identifier);
		}
#pragma warning restore 0169

		static IntPtr id_getIdentifier;
		public virtual string Identifier {
			[Register ("getIdentifier", "()Ljava/lang/String;", "GetGetIdentifierHandler")]
			get {
				if (id_getIdentifier == IntPtr.Zero)
					id_getIdentifier = JNIEnv.GetMethodID (class_ref, "getIdentifier", "()Ljava/lang/String;");

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getIdentifier), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getIdentifier), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_isFree;
#pragma warning disable 0169
		static Delegate GetIsFreeHandler ()
		{
			if (cb_isFree == null)
				cb_isFree = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsFree);
			return cb_isFree;
		}

		static bool n_IsFree (IntPtr jnienv, IntPtr native__this)
		{
			Product __this = Java.Lang.Object.GetObject<Product> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsFree;
		}
#pragma warning restore 0169

		static IntPtr id_isFree;
		public virtual bool IsFree {
			[Register ("isFree", "()Z", "GetIsFreeHandler")]
			get {
				if (id_isFree == IntPtr.Zero)
					id_isFree = JNIEnv.GetMethodID (class_ref, "isFree", "()Z");

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_isFree);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, id_isFree);
			}
		}

		static Delegate cb_getPreviewURLString;
#pragma warning disable 0169
		static Delegate GetGetPreviewURLStringHandler ()
		{
			if (cb_getPreviewURLString == null)
				cb_getPreviewURLString = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPreviewURLString);
			return cb_getPreviewURLString;
		}

		static IntPtr n_GetPreviewURLString (IntPtr jnienv, IntPtr native__this)
		{
			Product __this = Java.Lang.Object.GetObject<Product> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.PreviewURLString);
		}
#pragma warning restore 0169

		static IntPtr id_getPreviewURLString;
		public virtual string PreviewURLString {
			[Register ("getPreviewURLString", "()Ljava/lang/String;", "GetGetPreviewURLStringHandler")]
			get {
				if (id_getPreviewURLString == IntPtr.Zero)
					id_getPreviewURLString = JNIEnv.GetMethodID (class_ref, "getPreviewURLString", "()Ljava/lang/String;");

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getPreviewURLString), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getPreviewURLString), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getPrice;
#pragma warning disable 0169
		static Delegate GetGetPriceHandler ()
		{
			if (cb_getPrice == null)
				cb_getPrice = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPrice);
			return cb_getPrice;
		}

		static IntPtr n_GetPrice (IntPtr jnienv, IntPtr native__this)
		{
			Product __this = Java.Lang.Object.GetObject<Product> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Price);
		}
#pragma warning restore 0169

		static IntPtr id_getPrice;
		public virtual string Price {
			[Register ("getPrice", "()Ljava/lang/String;", "GetGetPriceHandler")]
			get {
				if (id_getPrice == IntPtr.Zero)
					id_getPrice = JNIEnv.GetMethodID (class_ref, "getPrice", "()Ljava/lang/String;");

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getPrice), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getPrice), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getRevision;
#pragma warning disable 0169
		static Delegate GetGetRevisionHandler ()
		{
			if (cb_getRevision == null)
				cb_getRevision = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetRevision);
			return cb_getRevision;
		}

		static int n_GetRevision (IntPtr jnienv, IntPtr native__this)
		{
			Product __this = Java.Lang.Object.GetObject<Product> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Revision;
		}
#pragma warning restore 0169

		static IntPtr id_getRevision;
		public virtual int Revision {
			[Register ("getRevision", "()I", "GetGetRevisionHandler")]
			get {
				if (id_getRevision == IntPtr.Zero)
					id_getRevision = JNIEnv.GetMethodID (class_ref, "getRevision", "()I");

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_getRevision);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, id_getRevision);
			}
		}

		static Delegate cb_getTitle;
#pragma warning disable 0169
		static Delegate GetGetTitleHandler ()
		{
			if (cb_getTitle == null)
				cb_getTitle = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTitle);
			return cb_getTitle;
		}

		static IntPtr n_GetTitle (IntPtr jnienv, IntPtr native__this)
		{
			Product __this = Java.Lang.Object.GetObject<Product> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Title);
		}
#pragma warning restore 0169

		static IntPtr id_getTitle;
		public virtual string Title {
			[Register ("getTitle", "()Ljava/lang/String;", "GetGetTitleHandler")]
			get {
				if (id_getTitle == IntPtr.Zero)
					id_getTitle = JNIEnv.GetMethodID (class_ref, "getTitle", "()Ljava/lang/String;");

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getTitle), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getTitle), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_addObserver_Ljava_util_Observer_;
#pragma warning disable 0169
		static Delegate GetAddObserver_Ljava_util_Observer_Handler ()
		{
			if (cb_addObserver_Ljava_util_Observer_ == null)
				cb_addObserver_Ljava_util_Observer_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_AddObserver_Ljava_util_Observer_);
			return cb_addObserver_Ljava_util_Observer_;
		}

		static void n_AddObserver_Ljava_util_Observer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			Product __this = Java.Lang.Object.GetObject<Product> (native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Util.IObserver p0 = Java.Lang.Object.GetObject<global::Java.Util.IObserver> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AddObserver (p0);
		}
#pragma warning restore 0169

		static IntPtr id_addObserver_Ljava_util_Observer_;
		[Register ("addObserver", "(Ljava/util/Observer;)V", "GetAddObserver_Ljava_util_Observer_Handler")]
		public virtual void AddObserver (global::Java.Util.IObserver p0)
		{
			if (id_addObserver_Ljava_util_Observer_ == IntPtr.Zero)
				id_addObserver_Ljava_util_Observer_ = JNIEnv.GetMethodID (class_ref, "addObserver", "(Ljava/util/Observer;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_addObserver_Ljava_util_Observer_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_addObserver_Ljava_util_Observer_, new JValue (p0));
		}

		static Delegate cb_compareTo_Lcom_urbanairship_iap_Product_;
#pragma warning disable 0169
		static Delegate GetCompareTo_Lcom_urbanairship_iap_Product_Handler ()
		{
			if (cb_compareTo_Lcom_urbanairship_iap_Product_ == null)
				cb_compareTo_Lcom_urbanairship_iap_Product_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int>) n_CompareTo_Lcom_urbanairship_iap_Product_);
			return cb_compareTo_Lcom_urbanairship_iap_Product_;
		}

		static int n_CompareTo_Lcom_urbanairship_iap_Product_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			Product __this = Java.Lang.Object.GetObject<Product> (native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Urbanairship.Iap.Product p0 = Java.Lang.Object.GetObject<global::Com.Urbanairship.Iap.Product> (native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.CompareTo (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_compareTo_Lcom_urbanairship_iap_Product_;
		[Register ("compareTo", "(Lcom/urbanairship/iap/Product;)I", "GetCompareTo_Lcom_urbanairship_iap_Product_Handler")]
		public virtual int CompareTo (global::Com.Urbanairship.Iap.Product p0)
		{
			if (id_compareTo_Lcom_urbanairship_iap_Product_ == IntPtr.Zero)
				id_compareTo_Lcom_urbanairship_iap_Product_ = JNIEnv.GetMethodID (class_ref, "compareTo", "(Lcom/urbanairship/iap/Product;)I");

			int __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallIntMethod  (Handle, id_compareTo_Lcom_urbanairship_iap_Product_, new JValue (p0));
			else
				__ret = JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, id_compareTo_Lcom_urbanairship_iap_Product_, new JValue (p0));
			return __ret;
		}

		static Delegate cb_deleteObserver_Ljava_util_Observer_;
#pragma warning disable 0169
		static Delegate GetDeleteObserver_Ljava_util_Observer_Handler ()
		{
			if (cb_deleteObserver_Ljava_util_Observer_ == null)
				cb_deleteObserver_Ljava_util_Observer_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_DeleteObserver_Ljava_util_Observer_);
			return cb_deleteObserver_Ljava_util_Observer_;
		}

		static void n_DeleteObserver_Ljava_util_Observer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			Product __this = Java.Lang.Object.GetObject<Product> (native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Util.IObserver p0 = Java.Lang.Object.GetObject<global::Java.Util.IObserver> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.DeleteObserver (p0);
		}
#pragma warning restore 0169

		static IntPtr id_deleteObserver_Ljava_util_Observer_;
		[Register ("deleteObserver", "(Ljava/util/Observer;)V", "GetDeleteObserver_Ljava_util_Observer_Handler")]
		public virtual void DeleteObserver (global::Java.Util.IObserver p0)
		{
			if (id_deleteObserver_Ljava_util_Observer_ == IntPtr.Zero)
				id_deleteObserver_Ljava_util_Observer_ = JNIEnv.GetMethodID (class_ref, "deleteObserver", "(Ljava/util/Observer;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_deleteObserver_Ljava_util_Observer_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_deleteObserver_Ljava_util_Observer_, new JValue (p0));
		}

		static Delegate cb_getStatus;
#pragma warning disable 0169
		static Delegate GetGetStatusHandler ()
		{
			if (cb_getStatus == null)
				cb_getStatus = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetStatus);
			return cb_getStatus;
		}

		static IntPtr n_GetStatus (IntPtr jnienv, IntPtr native__this)
		{
			Product __this = Java.Lang.Object.GetObject<Product> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetStatus ());
		}
#pragma warning restore 0169

		static IntPtr id_getStatus;
		[Register ("getStatus", "()Lcom/urbanairship/iap/Product$Status;", "GetGetStatusHandler")]
		public virtual global::Com.Urbanairship.Iap.Product.Status GetStatus ()
		{
			if (id_getStatus == IntPtr.Zero)
				id_getStatus = JNIEnv.GetMethodID (class_ref, "getStatus", "()Lcom/urbanairship/iap/Product$Status;");

			if (GetType () == ThresholdType)
				return Java.Lang.Object.GetObject<global::Com.Urbanairship.Iap.Product.Status> (JNIEnv.CallObjectMethod  (Handle, id_getStatus), JniHandleOwnership.TransferLocalRef);
			else
				return Java.Lang.Object.GetObject<global::Com.Urbanairship.Iap.Product.Status> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getStatus), JniHandleOwnership.TransferLocalRef);
		}

	}
}
