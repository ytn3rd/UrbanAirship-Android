using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Urbanairship.Iap.Marketinterface {

	[global::Android.Runtime.Register ("com/urbanairship/iap/marketinterface/ResponseHandler", DoNotGenerateAcw=true)]
	public partial class ResponseHandler : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/urbanairship/iap/marketinterface/ResponseHandler", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ResponseHandler); }
		}

		protected ResponseHandler (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		[Register (".ctor", "()V", "")]
		public ResponseHandler () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (ResponseHandler)) {
				SetHandle (global::Android.Runtime.JNIEnv.CreateInstance (GetType (), "()V"), JniHandleOwnership.TransferLocalRef);
				return;
			}

			if (id_ctor == IntPtr.Zero)
				id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
			SetHandle (JNIEnv.NewObject (class_ref, id_ctor), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_buyPageIntentResponse_Landroid_app_Activity_Landroid_app_PendingIntent_Landroid_content_Intent_;
		[Register ("buyPageIntentResponse", "(Landroid/app/Activity;Landroid/app/PendingIntent;Landroid/content/Intent;)V", "")]
		public static void BuyPageIntentResponse (global::Android.App.Activity p0, global::Android.App.PendingIntent p1, global::Android.Content.Intent p2)
		{
			if (id_buyPageIntentResponse_Landroid_app_Activity_Landroid_app_PendingIntent_Landroid_content_Intent_ == IntPtr.Zero)
				id_buyPageIntentResponse_Landroid_app_Activity_Landroid_app_PendingIntent_Landroid_content_Intent_ = JNIEnv.GetStaticMethodID (class_ref, "buyPageIntentResponse", "(Landroid/app/Activity;Landroid/app/PendingIntent;Landroid/content/Intent;)V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_buyPageIntentResponse_Landroid_app_Activity_Landroid_app_PendingIntent_Landroid_content_Intent_, new JValue (p0), new JValue (p1), new JValue (p2));
		}

		static IntPtr id_checkBillingSupportedResponse_Z;
		[Register ("checkBillingSupportedResponse", "(Z)V", "")]
		public static void CheckBillingSupportedResponse (bool p0)
		{
			if (id_checkBillingSupportedResponse_Z == IntPtr.Zero)
				id_checkBillingSupportedResponse_Z = JNIEnv.GetStaticMethodID (class_ref, "checkBillingSupportedResponse", "(Z)V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_checkBillingSupportedResponse_Z, new JValue (p0));
		}

		static IntPtr id_purchaseResponse_Lcom_urbanairship_iap_marketinterface_Consts_PurchaseState_Ljava_lang_String_Ljava_lang_String_JLjava_lang_String_Ljava_lang_String_;
		[Register ("purchaseResponse", "(Lcom/urbanairship/iap/marketinterface/Consts$PurchaseState;Ljava/lang/String;Ljava/lang/String;JLjava/lang/String;Ljava/lang/String;)V", "")]
		public static void PurchaseResponse (global::Com.Urbanairship.Iap.Marketinterface.Consts.PurchaseState p0, string p1, string p2, long p3, string p4, string p5)
		{
			if (id_purchaseResponse_Lcom_urbanairship_iap_marketinterface_Consts_PurchaseState_Ljava_lang_String_Ljava_lang_String_JLjava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_purchaseResponse_Lcom_urbanairship_iap_marketinterface_Consts_PurchaseState_Ljava_lang_String_Ljava_lang_String_JLjava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "purchaseResponse", "(Lcom/urbanairship/iap/marketinterface/Consts$PurchaseState;Ljava/lang/String;Ljava/lang/String;JLjava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p4 = JNIEnv.NewString (p4);
			IntPtr native_p5 = JNIEnv.NewString (p5);
			JNIEnv.CallStaticVoidMethod  (class_ref, id_purchaseResponse_Lcom_urbanairship_iap_marketinterface_Consts_PurchaseState_Ljava_lang_String_Ljava_lang_String_JLjava_lang_String_Ljava_lang_String_, new JValue (p0), new JValue (native_p1), new JValue (native_p2), new JValue (p3), new JValue (native_p4), new JValue (native_p5));
			JNIEnv.DeleteLocalRef (native_p1);
			JNIEnv.DeleteLocalRef (native_p2);
			JNIEnv.DeleteLocalRef (native_p4);
			JNIEnv.DeleteLocalRef (native_p5);
		}

		static IntPtr id_register_Lcom_urbanairship_iap_MarketListener_;
		[Register ("register", "(Lcom/urbanairship/iap/MarketListener;)V", "")]
		public static void Register (global::Com.Urbanairship.Iap.MarketListener p0)
		{
			if (id_register_Lcom_urbanairship_iap_MarketListener_ == IntPtr.Zero)
				id_register_Lcom_urbanairship_iap_MarketListener_ = JNIEnv.GetStaticMethodID (class_ref, "register", "(Lcom/urbanairship/iap/MarketListener;)V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_register_Lcom_urbanairship_iap_MarketListener_, new JValue (p0));
		}

		static IntPtr id_unregister_Lcom_urbanairship_iap_MarketListener_;
		[Register ("unregister", "(Lcom/urbanairship/iap/MarketListener;)V", "")]
		public static void Unregister (global::Com.Urbanairship.Iap.MarketListener p0)
		{
			if (id_unregister_Lcom_urbanairship_iap_MarketListener_ == IntPtr.Zero)
				id_unregister_Lcom_urbanairship_iap_MarketListener_ = JNIEnv.GetStaticMethodID (class_ref, "unregister", "(Lcom/urbanairship/iap/MarketListener;)V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_unregister_Lcom_urbanairship_iap_MarketListener_, new JValue (p0));
		}

	}
}
