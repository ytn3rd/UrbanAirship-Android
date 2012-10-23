using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Urbanairship.Iap {

	[global::Android.Runtime.Register ("com/urbanairship/iap/Inventory", DoNotGenerateAcw=true)]
	public partial class Inventory : global::Java.Lang.Object {

		[global::Android.Runtime.Register ("com/urbanairship/iap/Inventory$FilterType", DoNotGenerateAcw=true)]
		public sealed partial class FilterType : global::Java.Lang.Enum {


			static IntPtr ALL_jfieldId;

			[Register ("ALL")]
			public static global::Com.Urbanairship.Iap.Inventory.FilterType All {
				get {
					if (ALL_jfieldId == IntPtr.Zero)
						ALL_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ALL", "Lcom/urbanairship/iap/Inventory$FilterType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ALL_jfieldId);
					return Java.Lang.Object.GetObject<global::Com.Urbanairship.Iap.Inventory.FilterType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (ALL_jfieldId == IntPtr.Zero)
						ALL_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ALL", "Lcom/urbanairship/iap/Inventory$FilterType;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, ALL_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr INSTALLED_jfieldId;

			[Register ("INSTALLED")]
			public static global::Com.Urbanairship.Iap.Inventory.FilterType Installed {
				get {
					if (INSTALLED_jfieldId == IntPtr.Zero)
						INSTALLED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "INSTALLED", "Lcom/urbanairship/iap/Inventory$FilterType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, INSTALLED_jfieldId);
					return Java.Lang.Object.GetObject<global::Com.Urbanairship.Iap.Inventory.FilterType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (INSTALLED_jfieldId == IntPtr.Zero)
						INSTALLED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "INSTALLED", "Lcom/urbanairship/iap/Inventory$FilterType;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, INSTALLED_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr UPDATED_jfieldId;

			[Register ("UPDATED")]
			public static global::Com.Urbanairship.Iap.Inventory.FilterType Updated {
				get {
					if (UPDATED_jfieldId == IntPtr.Zero)
						UPDATED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "UPDATED", "Lcom/urbanairship/iap/Inventory$FilterType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, UPDATED_jfieldId);
					return Java.Lang.Object.GetObject<global::Com.Urbanairship.Iap.Inventory.FilterType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (UPDATED_jfieldId == IntPtr.Zero)
						UPDATED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "UPDATED", "Lcom/urbanairship/iap/Inventory$FilterType;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, UPDATED_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/urbanairship/iap/Inventory$FilterType", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (FilterType); }
			}

			internal FilterType (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_valueOf_Ljava_lang_String_;
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/urbanairship/iap/Inventory$FilterType;", "")]
			public static global::Com.Urbanairship.Iap.Inventory.FilterType ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/urbanairship/iap/Inventory$FilterType;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				global::Com.Urbanairship.Iap.Inventory.FilterType __ret = Java.Lang.Object.GetObject<global::Com.Urbanairship.Iap.Inventory.FilterType> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
				JNIEnv.DeleteLocalRef (native_p0);
				return __ret;
			}

			static IntPtr id_values;
			[Register ("values", "()[Lcom/urbanairship/iap/Inventory$FilterType;", "")]
			public static global::Com.Urbanairship.Iap.Inventory.FilterType[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/urbanairship/iap/Inventory$FilterType;");
				return (Com.Urbanairship.Iap.Inventory.FilterType[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Urbanairship.Iap.Inventory.FilterType));
			}

		}

		[global::Android.Runtime.Register ("com/urbanairship/iap/Inventory$InventoryObservable", DoNotGenerateAcw=true)]
		public partial class InventoryObservable : global::Java.Util.Observable {

			protected InventoryObservable (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		}

		[global::Android.Runtime.Register ("com/urbanairship/iap/Inventory$Status", DoNotGenerateAcw=true)]
		public sealed partial class Status : global::Java.Lang.Enum {


			static IntPtr DOWNLOADING_jfieldId;

			[Register ("DOWNLOADING")]
			public static global::Com.Urbanairship.Iap.Inventory.Status Downloading {
				get {
					if (DOWNLOADING_jfieldId == IntPtr.Zero)
						DOWNLOADING_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DOWNLOADING", "Lcom/urbanairship/iap/Inventory$Status;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, DOWNLOADING_jfieldId);
					return Java.Lang.Object.GetObject<global::Com.Urbanairship.Iap.Inventory.Status> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (DOWNLOADING_jfieldId == IntPtr.Zero)
						DOWNLOADING_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DOWNLOADING", "Lcom/urbanairship/iap/Inventory$Status;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, DOWNLOADING_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr EMPTY_jfieldId;

			[Register ("EMPTY")]
			public static global::Com.Urbanairship.Iap.Inventory.Status Empty {
				get {
					if (EMPTY_jfieldId == IntPtr.Zero)
						EMPTY_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "EMPTY", "Lcom/urbanairship/iap/Inventory$Status;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, EMPTY_jfieldId);
					return Java.Lang.Object.GetObject<global::Com.Urbanairship.Iap.Inventory.Status> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (EMPTY_jfieldId == IntPtr.Zero)
						EMPTY_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "EMPTY", "Lcom/urbanairship/iap/Inventory$Status;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, EMPTY_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr FAILED_jfieldId;

			[Register ("FAILED")]
			public static global::Com.Urbanairship.Iap.Inventory.Status Failed {
				get {
					if (FAILED_jfieldId == IntPtr.Zero)
						FAILED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "FAILED", "Lcom/urbanairship/iap/Inventory$Status;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, FAILED_jfieldId);
					return Java.Lang.Object.GetObject<global::Com.Urbanairship.Iap.Inventory.Status> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (FAILED_jfieldId == IntPtr.Zero)
						FAILED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "FAILED", "Lcom/urbanairship/iap/Inventory$Status;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, FAILED_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr INITIALIZED_jfieldId;

			[Register ("INITIALIZED")]
			public static global::Com.Urbanairship.Iap.Inventory.Status Initialized {
				get {
					if (INITIALIZED_jfieldId == IntPtr.Zero)
						INITIALIZED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "INITIALIZED", "Lcom/urbanairship/iap/Inventory$Status;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, INITIALIZED_jfieldId);
					return Java.Lang.Object.GetObject<global::Com.Urbanairship.Iap.Inventory.Status> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (INITIALIZED_jfieldId == IntPtr.Zero)
						INITIALIZED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "INITIALIZED", "Lcom/urbanairship/iap/Inventory$Status;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, INITIALIZED_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr LOADED_jfieldId;

			[Register ("LOADED")]
			public static global::Com.Urbanairship.Iap.Inventory.Status Loaded {
				get {
					if (LOADED_jfieldId == IntPtr.Zero)
						LOADED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "LOADED", "Lcom/urbanairship/iap/Inventory$Status;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, LOADED_jfieldId);
					return Java.Lang.Object.GetObject<global::Com.Urbanairship.Iap.Inventory.Status> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (LOADED_jfieldId == IntPtr.Zero)
						LOADED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "LOADED", "Lcom/urbanairship/iap/Inventory$Status;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, LOADED_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/urbanairship/iap/Inventory$Status", ref java_class_handle);
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
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/urbanairship/iap/Inventory$Status;", "")]
			public static global::Com.Urbanairship.Iap.Inventory.Status ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/urbanairship/iap/Inventory$Status;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				global::Com.Urbanairship.Iap.Inventory.Status __ret = Java.Lang.Object.GetObject<global::Com.Urbanairship.Iap.Inventory.Status> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
				JNIEnv.DeleteLocalRef (native_p0);
				return __ret;
			}

			static IntPtr id_values;
			[Register ("values", "()[Lcom/urbanairship/iap/Inventory$Status;", "")]
			public static global::Com.Urbanairship.Iap.Inventory.Status[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/urbanairship/iap/Inventory$Status;");
				return (Com.Urbanairship.Iap.Inventory.Status[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Urbanairship.Iap.Inventory.Status));
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/urbanairship/iap/Inventory", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Inventory); }
		}

		protected Inventory (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

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
			Inventory __this = Java.Lang.Object.GetObject<Inventory> (native__this, JniHandleOwnership.DoNotTransfer);
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
			Inventory __this = Java.Lang.Object.GetObject<Inventory> (native__this, JniHandleOwnership.DoNotTransfer);
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

		static Delegate cb_getProduct_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetProduct_Ljava_lang_String_Handler ()
		{
			if (cb_getProduct_Ljava_lang_String_ == null)
				cb_getProduct_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetProduct_Ljava_lang_String_);
			return cb_getProduct_Ljava_lang_String_;
		}

		static IntPtr n_GetProduct_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			Inventory __this = Java.Lang.Object.GetObject<Inventory> (native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetProduct (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getProduct_Ljava_lang_String_;
		[Register ("getProduct", "(Ljava/lang/String;)Lcom/urbanairship/iap/Product;", "GetGetProduct_Ljava_lang_String_Handler")]
		public virtual global::Com.Urbanairship.Iap.Product GetProduct (string p0)
		{
			if (id_getProduct_Ljava_lang_String_ == IntPtr.Zero)
				id_getProduct_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getProduct", "(Ljava/lang/String;)Lcom/urbanairship/iap/Product;");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			global::Com.Urbanairship.Iap.Product __ret;
			if (GetType () == ThresholdType)
				__ret = Java.Lang.Object.GetObject<global::Com.Urbanairship.Iap.Product> (JNIEnv.CallObjectMethod  (Handle, id_getProduct_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = Java.Lang.Object.GetObject<global::Com.Urbanairship.Iap.Product> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getProduct_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_getProducts_Lcom_urbanairship_iap_Inventory_FilterType_;
#pragma warning disable 0169
		static Delegate GetGetProducts_Lcom_urbanairship_iap_Inventory_FilterType_Handler ()
		{
			if (cb_getProducts_Lcom_urbanairship_iap_Inventory_FilterType_ == null)
				cb_getProducts_Lcom_urbanairship_iap_Inventory_FilterType_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetProducts_Lcom_urbanairship_iap_Inventory_FilterType_);
			return cb_getProducts_Lcom_urbanairship_iap_Inventory_FilterType_;
		}

		static IntPtr n_GetProducts_Lcom_urbanairship_iap_Inventory_FilterType_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			Inventory __this = Java.Lang.Object.GetObject<Inventory> (native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Urbanairship.Iap.Inventory.FilterType p0 = Java.Lang.Object.GetObject<global::Com.Urbanairship.Iap.Inventory.FilterType> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.JavaList<global::Com.Urbanairship.Iap.Product>.ToLocalJniHandle (__this.GetProducts (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getProducts_Lcom_urbanairship_iap_Inventory_FilterType_;
		[Register ("getProducts", "(Lcom/urbanairship/iap/Inventory$FilterType;)Ljava/util/List;", "GetGetProducts_Lcom_urbanairship_iap_Inventory_FilterType_Handler")]
		public virtual global::System.Collections.Generic.IList<global::Com.Urbanairship.Iap.Product> GetProducts (global::Com.Urbanairship.Iap.Inventory.FilterType p0)
		{
			if (id_getProducts_Lcom_urbanairship_iap_Inventory_FilterType_ == IntPtr.Zero)
				id_getProducts_Lcom_urbanairship_iap_Inventory_FilterType_ = JNIEnv.GetMethodID (class_ref, "getProducts", "(Lcom/urbanairship/iap/Inventory$FilterType;)Ljava/util/List;");

			global::System.Collections.Generic.IList<global::Com.Urbanairship.Iap.Product> __ret;
			if (GetType () == ThresholdType)
				__ret = global::Android.Runtime.JavaList<global::Com.Urbanairship.Iap.Product>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_getProducts_Lcom_urbanairship_iap_Inventory_FilterType_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Android.Runtime.JavaList<global::Com.Urbanairship.Iap.Product>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getProducts_Lcom_urbanairship_iap_Inventory_FilterType_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
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
			Inventory __this = Java.Lang.Object.GetObject<Inventory> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetStatus ());
		}
#pragma warning restore 0169

		static IntPtr id_getStatus;
		[Register ("getStatus", "()Lcom/urbanairship/iap/Inventory$Status;", "GetGetStatusHandler")]
		public virtual global::Com.Urbanairship.Iap.Inventory.Status GetStatus ()
		{
			if (id_getStatus == IntPtr.Zero)
				id_getStatus = JNIEnv.GetMethodID (class_ref, "getStatus", "()Lcom/urbanairship/iap/Inventory$Status;");

			if (GetType () == ThresholdType)
				return Java.Lang.Object.GetObject<global::Com.Urbanairship.Iap.Inventory.Status> (JNIEnv.CallObjectMethod  (Handle, id_getStatus), JniHandleOwnership.TransferLocalRef);
			else
				return Java.Lang.Object.GetObject<global::Com.Urbanairship.Iap.Inventory.Status> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getStatus), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_hasProduct_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetHasProduct_Ljava_lang_String_Handler ()
		{
			if (cb_hasProduct_Ljava_lang_String_ == null)
				cb_hasProduct_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_HasProduct_Ljava_lang_String_);
			return cb_hasProduct_Ljava_lang_String_;
		}

		static bool n_HasProduct_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			Inventory __this = Java.Lang.Object.GetObject<Inventory> (native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.HasProduct (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_hasProduct_Ljava_lang_String_;
		[Register ("hasProduct", "(Ljava/lang/String;)Z", "GetHasProduct_Ljava_lang_String_Handler")]
		public virtual bool HasProduct (string p0)
		{
			if (id_hasProduct_Ljava_lang_String_ == IntPtr.Zero)
				id_hasProduct_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "hasProduct", "(Ljava/lang/String;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			bool __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallBooleanMethod  (Handle, id_hasProduct_Ljava_lang_String_, new JValue (native_p0));
			else
				__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, id_hasProduct_Ljava_lang_String_, new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_load;
#pragma warning disable 0169
		static Delegate GetLoadHandler ()
		{
			if (cb_load == null)
				cb_load = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Load);
			return cb_load;
		}

		static void n_Load (IntPtr jnienv, IntPtr native__this)
		{
			Inventory __this = Java.Lang.Object.GetObject<Inventory> (native__this, JniHandleOwnership.DoNotTransfer);
			__this.Load ();
		}
#pragma warning restore 0169

		static IntPtr id_load;
		[Register ("load", "()V", "GetLoadHandler")]
		public virtual void Load ()
		{
			if (id_load == IntPtr.Zero)
				id_load = JNIEnv.GetMethodID (class_ref, "load", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_load);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_load);
		}

		static Delegate cb_purchase_Landroid_app_Activity_Lcom_urbanairship_iap_Product_;
#pragma warning disable 0169
		static Delegate GetPurchase_Landroid_app_Activity_Lcom_urbanairship_iap_Product_Handler ()
		{
			if (cb_purchase_Landroid_app_Activity_Lcom_urbanairship_iap_Product_ == null)
				cb_purchase_Landroid_app_Activity_Lcom_urbanairship_iap_Product_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_Purchase_Landroid_app_Activity_Lcom_urbanairship_iap_Product_);
			return cb_purchase_Landroid_app_Activity_Lcom_urbanairship_iap_Product_;
		}

		static void n_Purchase_Landroid_app_Activity_Lcom_urbanairship_iap_Product_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			Inventory __this = Java.Lang.Object.GetObject<Inventory> (native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.App.Activity p0 = Java.Lang.Object.GetObject<global::Android.App.Activity> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Urbanairship.Iap.Product p1 = Java.Lang.Object.GetObject<global::Com.Urbanairship.Iap.Product> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Purchase (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_purchase_Landroid_app_Activity_Lcom_urbanairship_iap_Product_;
		[Register ("purchase", "(Landroid/app/Activity;Lcom/urbanairship/iap/Product;)V", "GetPurchase_Landroid_app_Activity_Lcom_urbanairship_iap_Product_Handler")]
		public virtual void Purchase (global::Android.App.Activity p0, global::Com.Urbanairship.Iap.Product p1)
		{
			if (id_purchase_Landroid_app_Activity_Lcom_urbanairship_iap_Product_ == IntPtr.Zero)
				id_purchase_Landroid_app_Activity_Lcom_urbanairship_iap_Product_ = JNIEnv.GetMethodID (class_ref, "purchase", "(Landroid/app/Activity;Lcom/urbanairship/iap/Product;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_purchase_Landroid_app_Activity_Lcom_urbanairship_iap_Product_, new JValue (p0), new JValue (p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_purchase_Landroid_app_Activity_Lcom_urbanairship_iap_Product_, new JValue (p0), new JValue (p1));
		}

		static Delegate cb_size_Lcom_urbanairship_iap_Inventory_FilterType_;
#pragma warning disable 0169
		static Delegate GetSize_Lcom_urbanairship_iap_Inventory_FilterType_Handler ()
		{
			if (cb_size_Lcom_urbanairship_iap_Inventory_FilterType_ == null)
				cb_size_Lcom_urbanairship_iap_Inventory_FilterType_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int>) n_Size_Lcom_urbanairship_iap_Inventory_FilterType_);
			return cb_size_Lcom_urbanairship_iap_Inventory_FilterType_;
		}

		static int n_Size_Lcom_urbanairship_iap_Inventory_FilterType_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			Inventory __this = Java.Lang.Object.GetObject<Inventory> (native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Urbanairship.Iap.Inventory.FilterType p0 = Java.Lang.Object.GetObject<global::Com.Urbanairship.Iap.Inventory.FilterType> (native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.Size (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_size_Lcom_urbanairship_iap_Inventory_FilterType_;
		[Register ("size", "(Lcom/urbanairship/iap/Inventory$FilterType;)I", "GetSize_Lcom_urbanairship_iap_Inventory_FilterType_Handler")]
		public virtual int Size (global::Com.Urbanairship.Iap.Inventory.FilterType p0)
		{
			if (id_size_Lcom_urbanairship_iap_Inventory_FilterType_ == IntPtr.Zero)
				id_size_Lcom_urbanairship_iap_Inventory_FilterType_ = JNIEnv.GetMethodID (class_ref, "size", "(Lcom/urbanairship/iap/Inventory$FilterType;)I");

			int __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallIntMethod  (Handle, id_size_Lcom_urbanairship_iap_Inventory_FilterType_, new JValue (p0));
			else
				__ret = JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, id_size_Lcom_urbanairship_iap_Inventory_FilterType_, new JValue (p0));
			return __ret;
		}

	}
}
