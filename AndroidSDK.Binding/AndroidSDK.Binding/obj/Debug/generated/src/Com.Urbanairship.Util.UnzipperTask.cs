using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Urbanairship.Util {

	[global::Android.Runtime.Register ("com/urbanairship/util/UnzipperTask", DoNotGenerateAcw=true)]
	public partial class UnzipperTask : global::Android.OS.AsyncTask {

		[global::Android.Runtime.Register ("com/urbanairship/util/UnzipperTask$Delegate", DoNotGenerateAcw=true)]
		public abstract partial class Delegate : global::Java.Lang.Object {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/urbanairship/util/UnzipperTask$Delegate", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Delegate); }
			}

			protected Delegate (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor;
			[Register (".ctor", "()V", "")]
			public Delegate () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				if (GetType () != typeof (Delegate)) {
					SetHandle (global::Android.Runtime.JNIEnv.CreateInstance (GetType (), "()V"), JniHandleOwnership.TransferLocalRef);
					return;
				}

				if (id_ctor == IntPtr.Zero)
					id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
				SetHandle (JNIEnv.NewObject (class_ref, id_ctor), JniHandleOwnership.TransferLocalRef);
			}

			static Delegate cb_onFail_Ljava_lang_Exception_;
#pragma warning disable 0169
			static Delegate GetOnFail_Ljava_lang_Exception_Handler ()
			{
				if (cb_onFail_Ljava_lang_Exception_ == null)
					cb_onFail_Ljava_lang_Exception_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnFail_Ljava_lang_Exception_);
				return cb_onFail_Ljava_lang_Exception_;
			}

			static void n_OnFail_Ljava_lang_Exception_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				Delegate __this = Java.Lang.Object.GetObject<Delegate> (native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Exception p0 = Java.Lang.Object.GetObject<global::Java.Lang.Exception> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnFail (p0);
			}
#pragma warning restore 0169

			[Register ("onFail", "(Ljava/lang/Exception;)V", "GetOnFail_Ljava_lang_Exception_Handler")]
			public abstract void OnFail (global::Java.Lang.Exception p0);

			static Delegate cb_onProgressUpdate_I;
#pragma warning disable 0169
			static Delegate GetOnProgressUpdate_IHandler ()
			{
				if (cb_onProgressUpdate_I == null)
					cb_onProgressUpdate_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_OnProgressUpdate_I);
				return cb_onProgressUpdate_I;
			}

			static void n_OnProgressUpdate_I (IntPtr jnienv, IntPtr native__this, int p0)
			{
				Delegate __this = Java.Lang.Object.GetObject<Delegate> (native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnProgressUpdate (p0);
			}
#pragma warning restore 0169

			[Register ("onProgressUpdate", "(I)V", "GetOnProgressUpdate_IHandler")]
			public abstract void OnProgressUpdate (int p0);

			static Delegate cb_onSuccess;
#pragma warning disable 0169
			static Delegate GetOnSuccessHandler ()
			{
				if (cb_onSuccess == null)
					cb_onSuccess = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnSuccess);
				return cb_onSuccess;
			}

			static void n_OnSuccess (IntPtr jnienv, IntPtr native__this)
			{
				Delegate __this = Java.Lang.Object.GetObject<Delegate> (native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnSuccess ();
			}
#pragma warning restore 0169

			[Register ("onSuccess", "()V", "GetOnSuccessHandler")]
			public abstract void OnSuccess ();

		}

		[global::Android.Runtime.Register ("com/urbanairship/util/UnzipperTask$Delegate", DoNotGenerateAcw=true)]
		internal partial class DelegateInvoker : Delegate {

			public DelegateInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

			protected override global::System.Type ThresholdType {
				get { return typeof (DelegateInvoker); }
			}

			static IntPtr id_onFail_Ljava_lang_Exception_;
			[Register ("onFail", "(Ljava/lang/Exception;)V", "GetOnFail_Ljava_lang_Exception_Handler")]
			public override void OnFail (global::Java.Lang.Exception p0)
			{
				if (id_onFail_Ljava_lang_Exception_ == IntPtr.Zero)
					id_onFail_Ljava_lang_Exception_ = JNIEnv.GetMethodID (class_ref, "onFail", "(Ljava/lang/Exception;)V");
				JNIEnv.CallVoidMethod  (Handle, id_onFail_Ljava_lang_Exception_, new JValue (p0));
			}

			static IntPtr id_onProgressUpdate_I;
			[Register ("onProgressUpdate", "(I)V", "GetOnProgressUpdate_IHandler")]
			public override void OnProgressUpdate (int p0)
			{
				if (id_onProgressUpdate_I == IntPtr.Zero)
					id_onProgressUpdate_I = JNIEnv.GetMethodID (class_ref, "onProgressUpdate", "(I)V");
				JNIEnv.CallVoidMethod  (Handle, id_onProgressUpdate_I, new JValue (p0));
			}

			static IntPtr id_onSuccess;
			[Register ("onSuccess", "()V", "GetOnSuccessHandler")]
			public override void OnSuccess ()
			{
				if (id_onSuccess == IntPtr.Zero)
					id_onSuccess = JNIEnv.GetMethodID (class_ref, "onSuccess", "()V");
				JNIEnv.CallVoidMethod  (Handle, id_onSuccess);
			}

		}


		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/urbanairship/util/UnzipperTask", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (UnzipperTask); }
		}

		protected UnzipperTask (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		[Register (".ctor", "()V", "")]
		public UnzipperTask () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (UnzipperTask)) {
				SetHandle (global::Android.Runtime.JNIEnv.CreateInstance (GetType (), "()V"), JniHandleOwnership.TransferLocalRef);
				return;
			}

			if (id_ctor == IntPtr.Zero)
				id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
			SetHandle (JNIEnv.NewObject (class_ref, id_ctor), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_doInBackground_arrayLjava_io_File_;
#pragma warning disable 0169
		static Delegate GetDoInBackground_arrayLjava_io_File_Handler ()
		{
			if (cb_doInBackground_arrayLjava_io_File_ == null)
				cb_doInBackground_arrayLjava_io_File_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_DoInBackground_arrayLjava_io_File_);
			return cb_doInBackground_arrayLjava_io_File_;
		}

		static IntPtr n_DoInBackground_arrayLjava_io_File_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			UnzipperTask __this = Java.Lang.Object.GetObject<UnzipperTask> (native__this, JniHandleOwnership.DoNotTransfer);
			Java.IO.File[] p0 = (Java.IO.File[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (Java.IO.File));
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.DoInBackground (p0));
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_doInBackground_arrayLjava_io_File_;
		[Register ("doInBackground", "([Ljava/io/File;)Ljava/lang/Exception;", "GetDoInBackground_arrayLjava_io_File_Handler")]
		protected virtual global::Java.Lang.Exception DoInBackground (params global:: Java.IO.File[] p0)
		{
			if (id_doInBackground_arrayLjava_io_File_ == IntPtr.Zero)
				id_doInBackground_arrayLjava_io_File_ = JNIEnv.GetMethodID (class_ref, "doInBackground", "([Ljava/io/File;)Ljava/lang/Exception;");
			IntPtr native_p0 = JNIEnv.NewArray (p0);

			global::Java.Lang.Exception __ret;
			if (GetType () == ThresholdType)
				__ret = Java.Lang.Object.GetObject<global::Java.Lang.Exception> (JNIEnv.CallObjectMethod  (Handle, id_doInBackground_arrayLjava_io_File_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = Java.Lang.Object.GetObject<global::Java.Lang.Exception> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_doInBackground_arrayLjava_io_File_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			return __ret;
		}

		static Delegate cb_doInBackground_arrayLjava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetDoInBackground_arrayLjava_lang_Object_Handler ()
		{
			if (cb_doInBackground_arrayLjava_lang_Object_ == null)
				cb_doInBackground_arrayLjava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_DoInBackground_arrayLjava_lang_Object_);
			return cb_doInBackground_arrayLjava_lang_Object_;
		}

		static IntPtr n_DoInBackground_arrayLjava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			UnzipperTask __this = Java.Lang.Object.GetObject<UnzipperTask> (native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object[] p0 = (Java.Lang.Object[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (Java.Lang.Object));
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.DoInBackground (p0));
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_doInBackground_arrayLjava_lang_Object_;
		[Register ("doInBackground", "([Ljava/lang/Object;)Ljava/lang/Object;", "GetDoInBackground_arrayLjava_lang_Object_Handler")]
		protected override global::Java.Lang.Object DoInBackground (global::Java.Lang.Object[] p0)
		{
			if (id_doInBackground_arrayLjava_lang_Object_ == IntPtr.Zero)
				id_doInBackground_arrayLjava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "doInBackground", "([Ljava/lang/Object;)Ljava/lang/Object;");
			IntPtr native_p0 = JNIEnv.NewArray (p0);

			global::Java.Lang.Object __ret;
			if (GetType () == ThresholdType)
				__ret = Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod  (Handle, id_doInBackground_arrayLjava_lang_Object_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_doInBackground_arrayLjava_lang_Object_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			return __ret;
		}

		static Delegate cb_onPostExecute_Ljava_lang_Exception_;
#pragma warning disable 0169
		static Delegate GetOnPostExecute_Ljava_lang_Exception_Handler ()
		{
			if (cb_onPostExecute_Ljava_lang_Exception_ == null)
				cb_onPostExecute_Ljava_lang_Exception_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnPostExecute_Ljava_lang_Exception_);
			return cb_onPostExecute_Ljava_lang_Exception_;
		}

		static void n_OnPostExecute_Ljava_lang_Exception_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			UnzipperTask __this = Java.Lang.Object.GetObject<UnzipperTask> (native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Exception p0 = Java.Lang.Object.GetObject<global::Java.Lang.Exception> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnPostExecute (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onPostExecute_Ljava_lang_Exception_;
		[Register ("onPostExecute", "(Ljava/lang/Exception;)V", "GetOnPostExecute_Ljava_lang_Exception_Handler")]
		protected virtual void OnPostExecute (global::Java.Lang.Exception p0)
		{
			if (id_onPostExecute_Ljava_lang_Exception_ == IntPtr.Zero)
				id_onPostExecute_Ljava_lang_Exception_ = JNIEnv.GetMethodID (class_ref, "onPostExecute", "(Ljava/lang/Exception;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_onPostExecute_Ljava_lang_Exception_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_onPostExecute_Ljava_lang_Exception_, new JValue (p0));
		}

		static Delegate cb_onProgressUpdate_arrayLjava_lang_Integer_;
#pragma warning disable 0169
		static Delegate GetOnProgressUpdate_arrayLjava_lang_Integer_Handler ()
		{
			if (cb_onProgressUpdate_arrayLjava_lang_Integer_ == null)
				cb_onProgressUpdate_arrayLjava_lang_Integer_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnProgressUpdate_arrayLjava_lang_Integer_);
			return cb_onProgressUpdate_arrayLjava_lang_Integer_;
		}

		static void n_OnProgressUpdate_arrayLjava_lang_Integer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			UnzipperTask __this = Java.Lang.Object.GetObject<UnzipperTask> (native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Integer[] p0 = (Java.Lang.Integer[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (Java.Lang.Integer));
			__this.OnProgressUpdate (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		static IntPtr id_onProgressUpdate_arrayLjava_lang_Integer_;
		[Register ("onProgressUpdate", "([Ljava/lang/Integer;)V", "GetOnProgressUpdate_arrayLjava_lang_Integer_Handler")]
		protected virtual void OnProgressUpdate (params global:: Java.Lang.Integer[] p0)
		{
			if (id_onProgressUpdate_arrayLjava_lang_Integer_ == IntPtr.Zero)
				id_onProgressUpdate_arrayLjava_lang_Integer_ = JNIEnv.GetMethodID (class_ref, "onProgressUpdate", "([Ljava/lang/Integer;)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_onProgressUpdate_arrayLjava_lang_Integer_, new JValue (native_p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_onProgressUpdate_arrayLjava_lang_Integer_, new JValue (native_p0));
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_setDelegate_Lcom_urbanairship_util_UnzipperTask_Delegate_;
#pragma warning disable 0169
		static Delegate GetSetDelegate_Lcom_urbanairship_util_UnzipperTask_Delegate_Handler ()
		{
			if (cb_setDelegate_Lcom_urbanairship_util_UnzipperTask_Delegate_ == null)
				cb_setDelegate_Lcom_urbanairship_util_UnzipperTask_Delegate_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetDelegate_Lcom_urbanairship_util_UnzipperTask_Delegate_);
			return cb_setDelegate_Lcom_urbanairship_util_UnzipperTask_Delegate_;
		}

		static void n_SetDelegate_Lcom_urbanairship_util_UnzipperTask_Delegate_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			UnzipperTask __this = Java.Lang.Object.GetObject<UnzipperTask> (native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Urbanairship.Util.UnzipperTask.Delegate p0 = Java.Lang.Object.GetObject<global::Com.Urbanairship.Util.UnzipperTask.Delegate> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetDelegate (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setDelegate_Lcom_urbanairship_util_UnzipperTask_Delegate_;
		[Register ("setDelegate", "(Lcom/urbanairship/util/UnzipperTask$Delegate;)V", "GetSetDelegate_Lcom_urbanairship_util_UnzipperTask_Delegate_Handler")]
		public virtual void SetDelegate (global::Com.Urbanairship.Util.UnzipperTask.Delegate p0)
		{
			if (id_setDelegate_Lcom_urbanairship_util_UnzipperTask_Delegate_ == IntPtr.Zero)
				id_setDelegate_Lcom_urbanairship_util_UnzipperTask_Delegate_ = JNIEnv.GetMethodID (class_ref, "setDelegate", "(Lcom/urbanairship/util/UnzipperTask$Delegate;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setDelegate_Lcom_urbanairship_util_UnzipperTask_Delegate_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_setDelegate_Lcom_urbanairship_util_UnzipperTask_Delegate_, new JValue (p0));
		}

	}
}
