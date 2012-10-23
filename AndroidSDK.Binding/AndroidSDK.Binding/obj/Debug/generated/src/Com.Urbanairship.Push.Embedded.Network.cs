using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Urbanairship.Push.Embedded {

	[global::Android.Runtime.Register ("com/urbanairship/push/embedded/Network", DoNotGenerateAcw=true)]
	public partial class Network : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/urbanairship/push/embedded/Network", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Network); }
		}

		protected Network (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		[Register (".ctor", "()V", "")]
		public Network () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (Network)) {
				SetHandle (global::Android.Runtime.JNIEnv.CreateInstance (GetType (), "()V"), JniHandleOwnership.TransferLocalRef);
				return;
			}

			if (id_ctor == IntPtr.Zero)
				id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
			SetHandle (JNIEnv.NewObject (class_ref, id_ctor), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_getActiveIPAddress;
		public static string ActiveIPAddress {
			[Register ("getActiveIPAddress", "()Ljava/lang/String;", "GetGetActiveIPAddressHandler")]
			get {
				if (id_getActiveIPAddress == IntPtr.Zero)
					id_getActiveIPAddress = JNIEnv.GetStaticMethodID (class_ref, "getActiveIPAddress", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getActiveIPAddress), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_isConnected;
		public static bool IsConnected {
			[Register ("isConnected", "()Z", "GetIsConnectedHandler")]
			get {
				if (id_isConnected == IntPtr.Zero)
					id_isConnected = JNIEnv.GetStaticMethodID (class_ref, "isConnected", "()Z");
				return JNIEnv.CallStaticBooleanMethod  (class_ref, id_isConnected);
			}
		}

		static IntPtr id_typeName;
		[Register ("typeName", "()Ljava/lang/String;", "")]
		public static string TypeName ()
		{
			if (id_typeName == IntPtr.Zero)
				id_typeName = JNIEnv.GetStaticMethodID (class_ref, "typeName", "()Ljava/lang/String;");
			return JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_typeName), JniHandleOwnership.TransferLocalRef);
		}

	}
}
