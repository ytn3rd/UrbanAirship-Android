using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Urbanairship.Iap.Marketinterface {

	[global::Android.Runtime.Register ("com/urbanairship/iap/marketinterface/Security", DoNotGenerateAcw=true)]
	public partial class Security : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/urbanairship/iap/marketinterface/Security", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Security); }
		}

		protected Security (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		[Register (".ctor", "()V", "")]
		public Security () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (Security)) {
				SetHandle (global::Android.Runtime.JNIEnv.CreateInstance (GetType (), "()V"), JniHandleOwnership.TransferLocalRef);
				return;
			}

			if (id_ctor == IntPtr.Zero)
				id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
			SetHandle (JNIEnv.NewObject (class_ref, id_ctor), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_generateNonce;
		[Register ("generateNonce", "()J", "")]
		public static long GenerateNonce ()
		{
			if (id_generateNonce == IntPtr.Zero)
				id_generateNonce = JNIEnv.GetStaticMethodID (class_ref, "generateNonce", "()J");
			return JNIEnv.CallStaticLongMethod  (class_ref, id_generateNonce);
		}

		static IntPtr id_isNonceKnown_J;
		[Register ("isNonceKnown", "(J)Z", "")]
		public static bool IsNonceKnown (long p0)
		{
			if (id_isNonceKnown_J == IntPtr.Zero)
				id_isNonceKnown_J = JNIEnv.GetStaticMethodID (class_ref, "isNonceKnown", "(J)Z");
			return JNIEnv.CallStaticBooleanMethod  (class_ref, id_isNonceKnown_J, new JValue (p0));
		}

		static IntPtr id_removeNonce_J;
		[Register ("removeNonce", "(J)V", "")]
		public static void RemoveNonce (long p0)
		{
			if (id_removeNonce_J == IntPtr.Zero)
				id_removeNonce_J = JNIEnv.GetStaticMethodID (class_ref, "removeNonce", "(J)V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_removeNonce_J, new JValue (p0));
		}

	}
}
