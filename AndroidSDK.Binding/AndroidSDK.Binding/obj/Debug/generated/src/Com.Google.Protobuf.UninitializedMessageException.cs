using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Protobuf {

	[global::Android.Runtime.Register ("com/google/protobuf/UninitializedMessageException", DoNotGenerateAcw=true)]
	public partial class UninitializedMessageException : global::Java.Lang.RuntimeException {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/protobuf/UninitializedMessageException", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (UninitializedMessageException); }
		}

		protected UninitializedMessageException (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_google_protobuf_MessageLite_;
		[Register (".ctor", "(Lcom/google/protobuf/MessageLite;)V", "")]
		public UninitializedMessageException (global::Com.Google.Protobuf.IMessageLite p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (UninitializedMessageException)) {
				SetHandle (global::Android.Runtime.JNIEnv.CreateInstance (GetType (), "(Lcom/google/protobuf/MessageLite;)V", new JValue (p0)), JniHandleOwnership.TransferLocalRef);
				return;
			}

			if (id_ctor_Lcom_google_protobuf_MessageLite_ == IntPtr.Zero)
				id_ctor_Lcom_google_protobuf_MessageLite_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/google/protobuf/MessageLite;)V");
			SetHandle (JNIEnv.NewObject (class_ref, id_ctor_Lcom_google_protobuf_MessageLite_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_ctor_Ljava_util_List_;
		[Register (".ctor", "(Ljava/util/List;)V", "")]
		public UninitializedMessageException (global::System.Collections.Generic.IList<string> p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (p0);;
			if (GetType () != typeof (UninitializedMessageException)) {
				SetHandle (global::Android.Runtime.JNIEnv.CreateInstance (GetType (), "(Ljava/util/List;)V", new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
				JNIEnv.DeleteLocalRef (native_p0);
				return;
			}

			if (id_ctor_Ljava_util_List_ == IntPtr.Zero)
				id_ctor_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/util/List;)V");
			SetHandle (JNIEnv.NewObject (class_ref, id_ctor_Ljava_util_List_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_getMissingFields;
#pragma warning disable 0169
		static Delegate GetGetMissingFieldsHandler ()
		{
			if (cb_getMissingFields == null)
				cb_getMissingFields = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMissingFields);
			return cb_getMissingFields;
		}

		static IntPtr n_GetMissingFields (IntPtr jnienv, IntPtr native__this)
		{
			UninitializedMessageException __this = Java.Lang.Object.GetObject<UninitializedMessageException> (native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<string>.ToLocalJniHandle (__this.MissingFields);
		}
#pragma warning restore 0169

		static IntPtr id_getMissingFields;
		public virtual global::System.Collections.Generic.IList<string> MissingFields {
			[Register ("getMissingFields", "()Ljava/util/List;", "GetGetMissingFieldsHandler")]
			get {
				if (id_getMissingFields == IntPtr.Zero)
					id_getMissingFields = JNIEnv.GetMethodID (class_ref, "getMissingFields", "()Ljava/util/List;");

				if (GetType () == ThresholdType)
					return global::Android.Runtime.JavaList<string>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_getMissingFields), JniHandleOwnership.TransferLocalRef);
				else
					return global::Android.Runtime.JavaList<string>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getMissingFields), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_asInvalidProtocolBufferException;
#pragma warning disable 0169
		static Delegate GetAsInvalidProtocolBufferExceptionHandler ()
		{
			if (cb_asInvalidProtocolBufferException == null)
				cb_asInvalidProtocolBufferException = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_AsInvalidProtocolBufferException);
			return cb_asInvalidProtocolBufferException;
		}

		static IntPtr n_AsInvalidProtocolBufferException (IntPtr jnienv, IntPtr native__this)
		{
			UninitializedMessageException __this = Java.Lang.Object.GetObject<UninitializedMessageException> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AsInvalidProtocolBufferException ());
		}
#pragma warning restore 0169

		static IntPtr id_asInvalidProtocolBufferException;
		[Register ("asInvalidProtocolBufferException", "()Lcom/google/protobuf/InvalidProtocolBufferException;", "GetAsInvalidProtocolBufferExceptionHandler")]
		public virtual global::Com.Google.Protobuf.InvalidProtocolBufferException AsInvalidProtocolBufferException ()
		{
			if (id_asInvalidProtocolBufferException == IntPtr.Zero)
				id_asInvalidProtocolBufferException = JNIEnv.GetMethodID (class_ref, "asInvalidProtocolBufferException", "()Lcom/google/protobuf/InvalidProtocolBufferException;");

			if (GetType () == ThresholdType)
				return Java.Lang.Object.GetObject<global::Com.Google.Protobuf.InvalidProtocolBufferException> (JNIEnv.CallObjectMethod  (Handle, id_asInvalidProtocolBufferException), JniHandleOwnership.TransferLocalRef);
			else
				return Java.Lang.Object.GetObject<global::Com.Google.Protobuf.InvalidProtocolBufferException> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_asInvalidProtocolBufferException), JniHandleOwnership.TransferLocalRef);
		}

	}
}
