using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Urbanairship.Restclient {

	[global::Android.Runtime.Register ("com/urbanairship/restclient/Response", DoNotGenerateAcw=true)]
	public partial class Response : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/urbanairship/restclient/Response", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Response); }
		}

		protected Response (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_body;
#pragma warning disable 0169
		static Delegate GetBodyHandler ()
		{
			if (cb_body == null)
				cb_body = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Body);
			return cb_body;
		}

		static IntPtr n_Body (IntPtr jnienv, IntPtr native__this)
		{
			Response __this = Java.Lang.Object.GetObject<Response> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Body ());
		}
#pragma warning restore 0169

		static IntPtr id_body;
		[Register ("body", "()Ljava/lang/String;", "GetBodyHandler")]
		public virtual string Body ()
		{
			if (id_body == IntPtr.Zero)
				id_body = JNIEnv.GetMethodID (class_ref, "body", "()Ljava/lang/String;");

			if (GetType () == ThresholdType)
				return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_body), JniHandleOwnership.TransferLocalRef);
			else
				return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_body), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_contentType;
#pragma warning disable 0169
		static Delegate GetContentTypeHandler ()
		{
			if (cb_contentType == null)
				cb_contentType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_ContentType);
			return cb_contentType;
		}

		static IntPtr n_ContentType (IntPtr jnienv, IntPtr native__this)
		{
			Response __this = Java.Lang.Object.GetObject<Response> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ContentType ());
		}
#pragma warning restore 0169

		static IntPtr id_contentType;
		[Register ("contentType", "()Ljava/lang/String;", "GetContentTypeHandler")]
		public virtual string ContentType ()
		{
			if (id_contentType == IntPtr.Zero)
				id_contentType = JNIEnv.GetMethodID (class_ref, "contentType", "()Ljava/lang/String;");

			if (GetType () == ThresholdType)
				return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_contentType), JniHandleOwnership.TransferLocalRef);
			else
				return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_contentType), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_length;
#pragma warning disable 0169
		static Delegate GetLengthHandler ()
		{
			if (cb_length == null)
				cb_length = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_Length);
			return cb_length;
		}

		static long n_Length (IntPtr jnienv, IntPtr native__this)
		{
			Response __this = Java.Lang.Object.GetObject<Response> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Length ();
		}
#pragma warning restore 0169

		static IntPtr id_length;
		[Register ("length", "()J", "GetLengthHandler")]
		public virtual long Length ()
		{
			if (id_length == IntPtr.Zero)
				id_length = JNIEnv.GetMethodID (class_ref, "length", "()J");

			if (GetType () == ThresholdType)
				return JNIEnv.CallLongMethod  (Handle, id_length);
			else
				return JNIEnv.CallNonvirtualLongMethod  (Handle, ThresholdClass, id_length);
		}

		static Delegate cb_rawBody;
#pragma warning disable 0169
		static Delegate GetRawBodyHandler ()
		{
			if (cb_rawBody == null)
				cb_rawBody = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_RawBody);
			return cb_rawBody;
		}

		static IntPtr n_RawBody (IntPtr jnienv, IntPtr native__this)
		{
			Response __this = Java.Lang.Object.GetObject<Response> (native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (__this.RawBody ());
		}
#pragma warning restore 0169

		static IntPtr id_rawBody;
		[Register ("rawBody", "()Ljava/io/InputStream;", "GetRawBodyHandler")]
		public virtual global::System.IO.Stream RawBody ()
		{
			if (id_rawBody == IntPtr.Zero)
				id_rawBody = JNIEnv.GetMethodID (class_ref, "rawBody", "()Ljava/io/InputStream;");

			if (GetType () == ThresholdType)
				return global::Android.Runtime.InputStreamInvoker.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_rawBody), JniHandleOwnership.TransferLocalRef);
			else
				return global::Android.Runtime.InputStreamInvoker.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_rawBody), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_reason;
#pragma warning disable 0169
		static Delegate GetReasonHandler ()
		{
			if (cb_reason == null)
				cb_reason = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Reason);
			return cb_reason;
		}

		static IntPtr n_Reason (IntPtr jnienv, IntPtr native__this)
		{
			Response __this = Java.Lang.Object.GetObject<Response> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Reason ());
		}
#pragma warning restore 0169

		static IntPtr id_reason;
		[Register ("reason", "()Ljava/lang/String;", "GetReasonHandler")]
		public virtual string Reason ()
		{
			if (id_reason == IntPtr.Zero)
				id_reason = JNIEnv.GetMethodID (class_ref, "reason", "()Ljava/lang/String;");

			if (GetType () == ThresholdType)
				return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_reason), JniHandleOwnership.TransferLocalRef);
			else
				return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_reason), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_status;
#pragma warning disable 0169
		static Delegate GetStatusHandler ()
		{
			if (cb_status == null)
				cb_status = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_Status);
			return cb_status;
		}

		static int n_Status (IntPtr jnienv, IntPtr native__this)
		{
			Response __this = Java.Lang.Object.GetObject<Response> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Status ();
		}
#pragma warning restore 0169

		static IntPtr id_status;
		[Register ("status", "()I", "GetStatusHandler")]
		public virtual int Status ()
		{
			if (id_status == IntPtr.Zero)
				id_status = JNIEnv.GetMethodID (class_ref, "status", "()I");

			if (GetType () == ThresholdType)
				return JNIEnv.CallIntMethod  (Handle, id_status);
			else
				return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, id_status);
		}

	}
}
