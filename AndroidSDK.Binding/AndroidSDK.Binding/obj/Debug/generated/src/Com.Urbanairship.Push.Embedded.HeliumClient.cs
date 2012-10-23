using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Urbanairship.Push.Embedded {

	[global::Android.Runtime.Register ("com/urbanairship/push/embedded/HeliumClient", DoNotGenerateAcw=true)]
	public partial class HeliumClient : global::Java.Lang.Object {

		[global::Android.Runtime.Register ("com/urbanairship/push/embedded/HeliumClient$HeliumException", DoNotGenerateAcw=true)]
		public partial class HeliumException : global::Java.Lang.Exception {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/urbanairship/push/embedded/HeliumClient$HeliumException", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (HeliumException); }
			}

			protected HeliumException (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lcom_urbanairship_push_embedded_HeliumClient_Ljava_lang_String_;
			[Register (".ctor", "(Lcom/urbanairship/push/embedded/HeliumClient;Ljava/lang/String;)V", "")]
			public HeliumException (global::Com.Urbanairship.Push.Embedded.HeliumClient __self, string p1) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				IntPtr native_p1 = JNIEnv.NewString (p1);;
				if (GetType () != typeof (HeliumException)) {
					SetHandle (global::Android.Runtime.JNIEnv.CreateInstance (GetType (), "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";Ljava/lang/String;)V", new JValue (__self), new JValue (native_p1)), JniHandleOwnership.TransferLocalRef);
					JNIEnv.DeleteLocalRef (native_p1);
					return;
				}

				if (id_ctor_Lcom_urbanairship_push_embedded_HeliumClient_Ljava_lang_String_ == IntPtr.Zero)
					id_ctor_Lcom_urbanairship_push_embedded_HeliumClient_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/urbanairship/push/embedded/HeliumClient;Ljava/lang/String;)V");
				SetHandle (JNIEnv.NewObject (class_ref, id_ctor_Lcom_urbanairship_push_embedded_HeliumClient_Ljava_lang_String_, new JValue (__self), new JValue (native_p1)), JniHandleOwnership.TransferLocalRef);
				JNIEnv.DeleteLocalRef (native_p1);
			}

		}

		[global::Android.Runtime.Register ("com/urbanairship/push/embedded/HeliumClient$HeliumInvalidPackageException", DoNotGenerateAcw=true)]
		public partial class HeliumInvalidPackageException : global::Com.Urbanairship.Push.Embedded.HeliumClient.HeliumException {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/urbanairship/push/embedded/HeliumClient$HeliumInvalidPackageException", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (HeliumInvalidPackageException); }
			}

			protected HeliumInvalidPackageException (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lcom_urbanairship_push_embedded_HeliumClient_Ljava_lang_String_;
			[Register (".ctor", "(Lcom/urbanairship/push/embedded/HeliumClient;Ljava/lang/String;)V", "")]
			public HeliumInvalidPackageException (global::Com.Urbanairship.Push.Embedded.HeliumClient __self, string p1) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				IntPtr native_p1 = JNIEnv.NewString (p1);;
				if (GetType () != typeof (HeliumInvalidPackageException)) {
					SetHandle (global::Android.Runtime.JNIEnv.CreateInstance (GetType (), "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";Ljava/lang/String;)V", new JValue (__self), new JValue (native_p1)), JniHandleOwnership.TransferLocalRef);
					JNIEnv.DeleteLocalRef (native_p1);
					return;
				}

				if (id_ctor_Lcom_urbanairship_push_embedded_HeliumClient_Ljava_lang_String_ == IntPtr.Zero)
					id_ctor_Lcom_urbanairship_push_embedded_HeliumClient_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/urbanairship/push/embedded/HeliumClient;Ljava/lang/String;)V");
				SetHandle (JNIEnv.NewObject (class_ref, id_ctor_Lcom_urbanairship_push_embedded_HeliumClient_Ljava_lang_String_, new JValue (__self), new JValue (native_p1)), JniHandleOwnership.TransferLocalRef);
				JNIEnv.DeleteLocalRef (native_p1);
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/urbanairship/push/embedded/HeliumClient", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (HeliumClient); }
		}

		protected HeliumClient (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_net_Socket_Lcom_urbanairship_push_embedded_BoxOfficeClient_;
		[Register (".ctor", "(Ljava/net/Socket;Lcom/urbanairship/push/embedded/BoxOfficeClient;)V", "")]
		public HeliumClient (global::Java.Net.Socket p0, global::Com.Urbanairship.Push.Embedded.BoxOfficeClient p1) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (HeliumClient)) {
				SetHandle (global::Android.Runtime.JNIEnv.CreateInstance (GetType (), "(Ljava/net/Socket;Lcom/urbanairship/push/embedded/BoxOfficeClient;)V", new JValue (p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
				return;
			}

			if (id_ctor_Ljava_net_Socket_Lcom_urbanairship_push_embedded_BoxOfficeClient_ == IntPtr.Zero)
				id_ctor_Ljava_net_Socket_Lcom_urbanairship_push_embedded_BoxOfficeClient_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/net/Socket;Lcom/urbanairship/push/embedded/BoxOfficeClient;)V");
			SetHandle (JNIEnv.NewObject (class_ref, id_ctor_Ljava_net_Socket_Lcom_urbanairship_push_embedded_BoxOfficeClient_, new JValue (p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_readResponse;
#pragma warning disable 0169
		static Delegate GetReadResponseHandler ()
		{
			if (cb_readResponse == null)
				cb_readResponse = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ReadResponse);
			return cb_readResponse;
		}

		static void n_ReadResponse (IntPtr jnienv, IntPtr native__this)
		{
			HeliumClient __this = Java.Lang.Object.GetObject<HeliumClient> (native__this, JniHandleOwnership.DoNotTransfer);
			__this.ReadResponse ();
		}
#pragma warning restore 0169

		static IntPtr id_readResponse;
		[Register ("readResponse", "()V", "GetReadResponseHandler")]
		protected virtual void ReadResponse ()
		{
			if (id_readResponse == IntPtr.Zero)
				id_readResponse = JNIEnv.GetMethodID (class_ref, "readResponse", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_readResponse);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_readResponse);
		}

		static Delegate cb_register;
#pragma warning disable 0169
		static Delegate GetRegisterHandler ()
		{
			if (cb_register == null)
				cb_register = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Register);
			return cb_register;
		}

		static void n_Register (IntPtr jnienv, IntPtr native__this)
		{
			HeliumClient __this = Java.Lang.Object.GetObject<HeliumClient> (native__this, JniHandleOwnership.DoNotTransfer);
			__this.Register ();
		}
#pragma warning restore 0169

		static IntPtr id_register;
		[Register ("register", "()V", "GetRegisterHandler")]
		protected virtual void Register ()
		{
			if (id_register == IntPtr.Zero)
				id_register = JNIEnv.GetMethodID (class_ref, "register", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_register);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_register);
		}

	}
}
