using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Urbanairship.Iap.Marketinterface {

	[global::Android.Runtime.Register ("com/urbanairship/iap/marketinterface/Consts", DoNotGenerateAcw=true)]
	public partial class Consts : global::Java.Lang.Object {


		[Register ("ACTION_CONFIRM_NOTIFICATION")]
		public const string ActionConfirmNotification = (string) "com.example.dungeons.CONFIRM_NOTIFICATION";

		[Register ("ACTION_GET_PURCHASE_INFORMATION")]
		public const string ActionGetPurchaseInformation = (string) "com.example.dungeons.GET_PURCHASE_INFORMATION";

		[Register ("ACTION_NOTIFY")]
		public const string ActionNotify = (string) "com.android.vending.billing.IN_APP_NOTIFY";

		[Register ("ACTION_PURCHASE_STATE_CHANGED")]
		public const string ActionPurchaseStateChanged = (string) "com.android.vending.billing.PURCHASE_STATE_CHANGED";

		[Register ("ACTION_RESPONSE_CODE")]
		public const string ActionResponseCode = (string) "com.android.vending.billing.RESPONSE_CODE";

		[Register ("ACTION_RESTORE_TRANSACTIONS")]
		public const string ActionRestoreTransactions = (string) "com.example.dungeons.RESTORE_TRANSACTIONS";

		[Register ("BILLING_REQUEST_API_VERSION")]
		public const string BillingRequestApiVersion = (string) "API_VERSION";

		[Register ("BILLING_REQUEST_DEVELOPER_PAYLOAD")]
		public const string BillingRequestDeveloperPayload = (string) "DEVELOPER_PAYLOAD";

		[Register ("BILLING_REQUEST_ITEM_ID")]
		public const string BillingRequestItemId = (string) "ITEM_ID";

		[Register ("BILLING_REQUEST_METHOD")]
		public const string BillingRequestMethod = (string) "BILLING_REQUEST";

		[Register ("BILLING_REQUEST_NONCE")]
		public const string BillingRequestNonce = (string) "NONCE";

		[Register ("BILLING_REQUEST_NOTIFY_IDS")]
		public const string BillingRequestNotifyIds = (string) "NOTIFY_IDS";

		[Register ("BILLING_REQUEST_PACKAGE_NAME")]
		public const string BillingRequestPackageName = (string) "PACKAGE_NAME";

		static IntPtr BILLING_RESPONSE_INVALID_REQUEST_ID_jfieldId;

		[Register ("BILLING_RESPONSE_INVALID_REQUEST_ID")]
		public static long BillingResponseInvalidRequestId {
			get {
				if (BILLING_RESPONSE_INVALID_REQUEST_ID_jfieldId == IntPtr.Zero)
					BILLING_RESPONSE_INVALID_REQUEST_ID_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "BILLING_RESPONSE_INVALID_REQUEST_ID", "J");
				return JNIEnv.GetStaticLongField (class_ref, BILLING_RESPONSE_INVALID_REQUEST_ID_jfieldId);
			}
			set {
				if (BILLING_RESPONSE_INVALID_REQUEST_ID_jfieldId == IntPtr.Zero)
					BILLING_RESPONSE_INVALID_REQUEST_ID_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "BILLING_RESPONSE_INVALID_REQUEST_ID", "J");
				JNIEnv.SetStaticField (class_ref, BILLING_RESPONSE_INVALID_REQUEST_ID_jfieldId, value);
			}
		}

		[Register ("BILLING_RESPONSE_PURCHASE_INTENT")]
		public const string BillingResponsePurchaseIntent = (string) "PURCHASE_INTENT";

		[Register ("BILLING_RESPONSE_REQUEST_ID")]
		public const string BillingResponseRequestId = (string) "REQUEST_ID";

		[Register ("BILLING_RESPONSE_RESPONSE_CODE")]
		public const string BillingResponseResponseCode = (string) "RESPONSE_CODE";

		[Register ("DEBUG")]
		public const bool Debug = (bool) false;

		[Register ("INAPP_REQUEST_ID")]
		public const string InappRequestId = (string) "request_id";

		[Register ("INAPP_RESPONSE_CODE")]
		public const string InappResponseCode = (string) "response_code";

		[Register ("INAPP_SIGNATURE")]
		public const string InappSignature = (string) "inapp_signature";

		[Register ("INAPP_SIGNED_DATA")]
		public const string InappSignedData = (string) "inapp_signed_data";

		[Register ("MARKET_BILLING_SERVICE_ACTION")]
		public const string MarketBillingServiceAction = (string) "com.android.vending.billing.MarketBillingService.BIND";

		[Register ("NOTIFICATION_ID")]
		public const string NotificationId = (string) "notification_id";
		[global::Android.Runtime.Register ("com/urbanairship/iap/marketinterface/Consts$PurchaseState", DoNotGenerateAcw=true)]
		public sealed partial class PurchaseState : global::Java.Lang.Enum {


			static IntPtr CANCELED_jfieldId;

			[Register ("CANCELED")]
			public static global::Com.Urbanairship.Iap.Marketinterface.Consts.PurchaseState Canceled {
				get {
					if (CANCELED_jfieldId == IntPtr.Zero)
						CANCELED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CANCELED", "Lcom/urbanairship/iap/marketinterface/Consts$PurchaseState;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CANCELED_jfieldId);
					return Java.Lang.Object.GetObject<global::Com.Urbanairship.Iap.Marketinterface.Consts.PurchaseState> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (CANCELED_jfieldId == IntPtr.Zero)
						CANCELED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CANCELED", "Lcom/urbanairship/iap/marketinterface/Consts$PurchaseState;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, CANCELED_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr PURCHASED_jfieldId;

			[Register ("PURCHASED")]
			public static global::Com.Urbanairship.Iap.Marketinterface.Consts.PurchaseState Purchased {
				get {
					if (PURCHASED_jfieldId == IntPtr.Zero)
						PURCHASED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PURCHASED", "Lcom/urbanairship/iap/marketinterface/Consts$PurchaseState;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, PURCHASED_jfieldId);
					return Java.Lang.Object.GetObject<global::Com.Urbanairship.Iap.Marketinterface.Consts.PurchaseState> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (PURCHASED_jfieldId == IntPtr.Zero)
						PURCHASED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PURCHASED", "Lcom/urbanairship/iap/marketinterface/Consts$PurchaseState;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, PURCHASED_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr REFUNDED_jfieldId;

			[Register ("REFUNDED")]
			public static global::Com.Urbanairship.Iap.Marketinterface.Consts.PurchaseState Refunded {
				get {
					if (REFUNDED_jfieldId == IntPtr.Zero)
						REFUNDED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "REFUNDED", "Lcom/urbanairship/iap/marketinterface/Consts$PurchaseState;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, REFUNDED_jfieldId);
					return Java.Lang.Object.GetObject<global::Com.Urbanairship.Iap.Marketinterface.Consts.PurchaseState> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (REFUNDED_jfieldId == IntPtr.Zero)
						REFUNDED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "REFUNDED", "Lcom/urbanairship/iap/marketinterface/Consts$PurchaseState;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, REFUNDED_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/urbanairship/iap/marketinterface/Consts$PurchaseState", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (PurchaseState); }
			}

			internal PurchaseState (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_valueOf_I;
			[Register ("valueOf", "(I)Lcom/urbanairship/iap/marketinterface/Consts$PurchaseState;", "")]
			public static global::Com.Urbanairship.Iap.Marketinterface.Consts.PurchaseState ValueOf (int p0)
			{
				if (id_valueOf_I == IntPtr.Zero)
					id_valueOf_I = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(I)Lcom/urbanairship/iap/marketinterface/Consts$PurchaseState;");
				return Java.Lang.Object.GetObject<global::Com.Urbanairship.Iap.Marketinterface.Consts.PurchaseState> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_I, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			}

			static IntPtr id_valueOf_Ljava_lang_String_;
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/urbanairship/iap/marketinterface/Consts$PurchaseState;", "")]
			public static global::Com.Urbanairship.Iap.Marketinterface.Consts.PurchaseState ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/urbanairship/iap/marketinterface/Consts$PurchaseState;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				global::Com.Urbanairship.Iap.Marketinterface.Consts.PurchaseState __ret = Java.Lang.Object.GetObject<global::Com.Urbanairship.Iap.Marketinterface.Consts.PurchaseState> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
				JNIEnv.DeleteLocalRef (native_p0);
				return __ret;
			}

			static IntPtr id_values;
			[Register ("values", "()[Lcom/urbanairship/iap/marketinterface/Consts$PurchaseState;", "")]
			public static global::Com.Urbanairship.Iap.Marketinterface.Consts.PurchaseState[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/urbanairship/iap/marketinterface/Consts$PurchaseState;");
				return (Com.Urbanairship.Iap.Marketinterface.Consts.PurchaseState[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Urbanairship.Iap.Marketinterface.Consts.PurchaseState));
			}

		}

		[global::Android.Runtime.Register ("com/urbanairship/iap/marketinterface/Consts$ResponseCode", DoNotGenerateAcw=true)]
		public sealed partial class ResponseCode : global::Java.Lang.Enum {


			static IntPtr RESULT_BILLING_UNAVAILABLE_jfieldId;

			[Register ("RESULT_BILLING_UNAVAILABLE")]
			public static global::Com.Urbanairship.Iap.Marketinterface.Consts.ResponseCode ResultBillingUnavailable {
				get {
					if (RESULT_BILLING_UNAVAILABLE_jfieldId == IntPtr.Zero)
						RESULT_BILLING_UNAVAILABLE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "RESULT_BILLING_UNAVAILABLE", "Lcom/urbanairship/iap/marketinterface/Consts$ResponseCode;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, RESULT_BILLING_UNAVAILABLE_jfieldId);
					return Java.Lang.Object.GetObject<global::Com.Urbanairship.Iap.Marketinterface.Consts.ResponseCode> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (RESULT_BILLING_UNAVAILABLE_jfieldId == IntPtr.Zero)
						RESULT_BILLING_UNAVAILABLE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "RESULT_BILLING_UNAVAILABLE", "Lcom/urbanairship/iap/marketinterface/Consts$ResponseCode;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, RESULT_BILLING_UNAVAILABLE_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr RESULT_DEVELOPER_ERROR_jfieldId;

			[Register ("RESULT_DEVELOPER_ERROR")]
			public static global::Com.Urbanairship.Iap.Marketinterface.Consts.ResponseCode ResultDeveloperError {
				get {
					if (RESULT_DEVELOPER_ERROR_jfieldId == IntPtr.Zero)
						RESULT_DEVELOPER_ERROR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "RESULT_DEVELOPER_ERROR", "Lcom/urbanairship/iap/marketinterface/Consts$ResponseCode;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, RESULT_DEVELOPER_ERROR_jfieldId);
					return Java.Lang.Object.GetObject<global::Com.Urbanairship.Iap.Marketinterface.Consts.ResponseCode> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (RESULT_DEVELOPER_ERROR_jfieldId == IntPtr.Zero)
						RESULT_DEVELOPER_ERROR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "RESULT_DEVELOPER_ERROR", "Lcom/urbanairship/iap/marketinterface/Consts$ResponseCode;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, RESULT_DEVELOPER_ERROR_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr RESULT_ERROR_jfieldId;

			[Register ("RESULT_ERROR")]
			public static global::Com.Urbanairship.Iap.Marketinterface.Consts.ResponseCode ResultError {
				get {
					if (RESULT_ERROR_jfieldId == IntPtr.Zero)
						RESULT_ERROR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "RESULT_ERROR", "Lcom/urbanairship/iap/marketinterface/Consts$ResponseCode;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, RESULT_ERROR_jfieldId);
					return Java.Lang.Object.GetObject<global::Com.Urbanairship.Iap.Marketinterface.Consts.ResponseCode> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (RESULT_ERROR_jfieldId == IntPtr.Zero)
						RESULT_ERROR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "RESULT_ERROR", "Lcom/urbanairship/iap/marketinterface/Consts$ResponseCode;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, RESULT_ERROR_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr RESULT_ITEM_UNAVAILABLE_jfieldId;

			[Register ("RESULT_ITEM_UNAVAILABLE")]
			public static global::Com.Urbanairship.Iap.Marketinterface.Consts.ResponseCode ResultItemUnavailable {
				get {
					if (RESULT_ITEM_UNAVAILABLE_jfieldId == IntPtr.Zero)
						RESULT_ITEM_UNAVAILABLE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "RESULT_ITEM_UNAVAILABLE", "Lcom/urbanairship/iap/marketinterface/Consts$ResponseCode;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, RESULT_ITEM_UNAVAILABLE_jfieldId);
					return Java.Lang.Object.GetObject<global::Com.Urbanairship.Iap.Marketinterface.Consts.ResponseCode> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (RESULT_ITEM_UNAVAILABLE_jfieldId == IntPtr.Zero)
						RESULT_ITEM_UNAVAILABLE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "RESULT_ITEM_UNAVAILABLE", "Lcom/urbanairship/iap/marketinterface/Consts$ResponseCode;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, RESULT_ITEM_UNAVAILABLE_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr RESULT_OK_jfieldId;

			[Register ("RESULT_OK")]
			public static global::Com.Urbanairship.Iap.Marketinterface.Consts.ResponseCode ResultOk {
				get {
					if (RESULT_OK_jfieldId == IntPtr.Zero)
						RESULT_OK_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "RESULT_OK", "Lcom/urbanairship/iap/marketinterface/Consts$ResponseCode;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, RESULT_OK_jfieldId);
					return Java.Lang.Object.GetObject<global::Com.Urbanairship.Iap.Marketinterface.Consts.ResponseCode> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (RESULT_OK_jfieldId == IntPtr.Zero)
						RESULT_OK_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "RESULT_OK", "Lcom/urbanairship/iap/marketinterface/Consts$ResponseCode;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, RESULT_OK_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr RESULT_SERVICE_UNAVAILABLE_jfieldId;

			[Register ("RESULT_SERVICE_UNAVAILABLE")]
			public static global::Com.Urbanairship.Iap.Marketinterface.Consts.ResponseCode ResultServiceUnavailable {
				get {
					if (RESULT_SERVICE_UNAVAILABLE_jfieldId == IntPtr.Zero)
						RESULT_SERVICE_UNAVAILABLE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "RESULT_SERVICE_UNAVAILABLE", "Lcom/urbanairship/iap/marketinterface/Consts$ResponseCode;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, RESULT_SERVICE_UNAVAILABLE_jfieldId);
					return Java.Lang.Object.GetObject<global::Com.Urbanairship.Iap.Marketinterface.Consts.ResponseCode> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (RESULT_SERVICE_UNAVAILABLE_jfieldId == IntPtr.Zero)
						RESULT_SERVICE_UNAVAILABLE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "RESULT_SERVICE_UNAVAILABLE", "Lcom/urbanairship/iap/marketinterface/Consts$ResponseCode;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, RESULT_SERVICE_UNAVAILABLE_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr RESULT_USER_CANCELED_jfieldId;

			[Register ("RESULT_USER_CANCELED")]
			public static global::Com.Urbanairship.Iap.Marketinterface.Consts.ResponseCode ResultUserCanceled {
				get {
					if (RESULT_USER_CANCELED_jfieldId == IntPtr.Zero)
						RESULT_USER_CANCELED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "RESULT_USER_CANCELED", "Lcom/urbanairship/iap/marketinterface/Consts$ResponseCode;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, RESULT_USER_CANCELED_jfieldId);
					return Java.Lang.Object.GetObject<global::Com.Urbanairship.Iap.Marketinterface.Consts.ResponseCode> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (RESULT_USER_CANCELED_jfieldId == IntPtr.Zero)
						RESULT_USER_CANCELED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "RESULT_USER_CANCELED", "Lcom/urbanairship/iap/marketinterface/Consts$ResponseCode;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, RESULT_USER_CANCELED_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/urbanairship/iap/marketinterface/Consts$ResponseCode", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (ResponseCode); }
			}

			internal ResponseCode (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_valueOf_I;
			[Register ("valueOf", "(I)Lcom/urbanairship/iap/marketinterface/Consts$ResponseCode;", "")]
			public static global::Com.Urbanairship.Iap.Marketinterface.Consts.ResponseCode ValueOf (int p0)
			{
				if (id_valueOf_I == IntPtr.Zero)
					id_valueOf_I = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(I)Lcom/urbanairship/iap/marketinterface/Consts$ResponseCode;");
				return Java.Lang.Object.GetObject<global::Com.Urbanairship.Iap.Marketinterface.Consts.ResponseCode> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_I, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			}

			static IntPtr id_valueOf_Ljava_lang_String_;
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/urbanairship/iap/marketinterface/Consts$ResponseCode;", "")]
			public static global::Com.Urbanairship.Iap.Marketinterface.Consts.ResponseCode ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/urbanairship/iap/marketinterface/Consts$ResponseCode;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				global::Com.Urbanairship.Iap.Marketinterface.Consts.ResponseCode __ret = Java.Lang.Object.GetObject<global::Com.Urbanairship.Iap.Marketinterface.Consts.ResponseCode> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
				JNIEnv.DeleteLocalRef (native_p0);
				return __ret;
			}

			static IntPtr id_values;
			[Register ("values", "()[Lcom/urbanairship/iap/marketinterface/Consts$ResponseCode;", "")]
			public static global::Com.Urbanairship.Iap.Marketinterface.Consts.ResponseCode[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/urbanairship/iap/marketinterface/Consts$ResponseCode;");
				return (Com.Urbanairship.Iap.Marketinterface.Consts.ResponseCode[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Urbanairship.Iap.Marketinterface.Consts.ResponseCode));
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/urbanairship/iap/marketinterface/Consts", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Consts); }
		}

		protected Consts (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		[Register (".ctor", "()V", "")]
		public Consts () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (Consts)) {
				SetHandle (global::Android.Runtime.JNIEnv.CreateInstance (GetType (), "()V"), JniHandleOwnership.TransferLocalRef);
				return;
			}

			if (id_ctor == IntPtr.Zero)
				id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
			SetHandle (JNIEnv.NewObject (class_ref, id_ctor), JniHandleOwnership.TransferLocalRef);
		}

	}
}
