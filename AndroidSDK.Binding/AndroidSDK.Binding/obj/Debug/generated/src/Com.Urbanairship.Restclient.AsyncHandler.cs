using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Urbanairship.Restclient {

	[global::Android.Runtime.Register ("com/urbanairship/restclient/AsyncHandler", DoNotGenerateAcw=true)]
	public abstract partial class AsyncHandler : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/urbanairship/restclient/AsyncHandler", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AsyncHandler); }
		}

		protected AsyncHandler (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		[Register (".ctor", "()V", "")]
		public AsyncHandler () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (AsyncHandler)) {
				SetHandle (global::Android.Runtime.JNIEnv.CreateInstance (GetType (), "()V"), JniHandleOwnership.TransferLocalRef);
				return;
			}

			if (id_ctor == IntPtr.Zero)
				id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
			SetHandle (JNIEnv.NewObject (class_ref, id_ctor), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_onComplete_Lcom_urbanairship_restclient_Response_;
#pragma warning disable 0169
		static Delegate GetOnComplete_Lcom_urbanairship_restclient_Response_Handler ()
		{
			if (cb_onComplete_Lcom_urbanairship_restclient_Response_ == null)
				cb_onComplete_Lcom_urbanairship_restclient_Response_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnComplete_Lcom_urbanairship_restclient_Response_);
			return cb_onComplete_Lcom_urbanairship_restclient_Response_;
		}

		static void n_OnComplete_Lcom_urbanairship_restclient_Response_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			AsyncHandler __this = Java.Lang.Object.GetObject<AsyncHandler> (native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Urbanairship.Restclient.Response p0 = Java.Lang.Object.GetObject<global::Com.Urbanairship.Restclient.Response> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnComplete (p0);
		}
#pragma warning restore 0169

		[Register ("onComplete", "(Lcom/urbanairship/restclient/Response;)V", "GetOnComplete_Lcom_urbanairship_restclient_Response_Handler")]
		public abstract void OnComplete (global::Com.Urbanairship.Restclient.Response p0);

		static Delegate cb_onData_Ljava_io_OutputStream_;
#pragma warning disable 0169
		static Delegate GetOnData_Ljava_io_OutputStream_Handler ()
		{
			if (cb_onData_Ljava_io_OutputStream_ == null)
				cb_onData_Ljava_io_OutputStream_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnData_Ljava_io_OutputStream_);
			return cb_onData_Ljava_io_OutputStream_;
		}

		static void n_OnData_Ljava_io_OutputStream_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			AsyncHandler __this = Java.Lang.Object.GetObject<AsyncHandler> (native__this, JniHandleOwnership.DoNotTransfer);
			System.IO.Stream p0 = global::Android.Runtime.OutputStreamInvoker.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnData (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onData_Ljava_io_OutputStream_;
		[Register ("onData", "(Ljava/io/OutputStream;)V", "GetOnData_Ljava_io_OutputStream_Handler")]
		public virtual void OnData (global::System.IO.Stream p0)
		{
			if (id_onData_Ljava_io_OutputStream_ == IntPtr.Zero)
				id_onData_Ljava_io_OutputStream_ = JNIEnv.GetMethodID (class_ref, "onData", "(Ljava/io/OutputStream;)V");
			IntPtr native_p0 = global::Android.Runtime.OutputStreamAdapter.ToLocalJniHandle (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_onData_Ljava_io_OutputStream_, new JValue (native_p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_onData_Ljava_io_OutputStream_, new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_onError_Ljava_lang_Exception_;
#pragma warning disable 0169
		static Delegate GetOnError_Ljava_lang_Exception_Handler ()
		{
			if (cb_onError_Ljava_lang_Exception_ == null)
				cb_onError_Ljava_lang_Exception_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnError_Ljava_lang_Exception_);
			return cb_onError_Ljava_lang_Exception_;
		}

		static void n_OnError_Ljava_lang_Exception_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			AsyncHandler __this = Java.Lang.Object.GetObject<AsyncHandler> (native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Exception p0 = Java.Lang.Object.GetObject<global::Java.Lang.Exception> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnError (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onError_Ljava_lang_Exception_;
		[Register ("onError", "(Ljava/lang/Exception;)V", "GetOnError_Ljava_lang_Exception_Handler")]
		public virtual void OnError (global::Java.Lang.Exception p0)
		{
			if (id_onError_Ljava_lang_Exception_ == IntPtr.Zero)
				id_onError_Ljava_lang_Exception_ = JNIEnv.GetMethodID (class_ref, "onError", "(Ljava/lang/Exception;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_onError_Ljava_lang_Exception_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_onError_Ljava_lang_Exception_, new JValue (p0));
		}

		static Delegate cb_onProgress_I;
#pragma warning disable 0169
		static Delegate GetOnProgress_IHandler ()
		{
			if (cb_onProgress_I == null)
				cb_onProgress_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_OnProgress_I);
			return cb_onProgress_I;
		}

		static void n_OnProgress_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			AsyncHandler __this = Java.Lang.Object.GetObject<AsyncHandler> (native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnProgress (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onProgress_I;
		[Register ("onProgress", "(I)V", "GetOnProgress_IHandler")]
		public virtual void OnProgress (int p0)
		{
			if (id_onProgress_I == IntPtr.Zero)
				id_onProgress_I = JNIEnv.GetMethodID (class_ref, "onProgress", "(I)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_onProgress_I, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_onProgress_I, new JValue (p0));
		}

	}

	[global::Android.Runtime.Register ("com/urbanairship/restclient/AsyncHandler", DoNotGenerateAcw=true)]
	internal partial class AsyncHandlerInvoker : AsyncHandler {

		public AsyncHandlerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (AsyncHandlerInvoker); }
		}

		static IntPtr id_onComplete_Lcom_urbanairship_restclient_Response_;
		[Register ("onComplete", "(Lcom/urbanairship/restclient/Response;)V", "GetOnComplete_Lcom_urbanairship_restclient_Response_Handler")]
		public override void OnComplete (global::Com.Urbanairship.Restclient.Response p0)
		{
			if (id_onComplete_Lcom_urbanairship_restclient_Response_ == IntPtr.Zero)
				id_onComplete_Lcom_urbanairship_restclient_Response_ = JNIEnv.GetMethodID (class_ref, "onComplete", "(Lcom/urbanairship/restclient/Response;)V");
			JNIEnv.CallVoidMethod  (Handle, id_onComplete_Lcom_urbanairship_restclient_Response_, new JValue (p0));
		}

	}

}
