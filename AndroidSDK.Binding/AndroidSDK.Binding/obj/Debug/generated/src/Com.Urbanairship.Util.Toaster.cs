using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Urbanairship.Util {

	[global::Android.Runtime.Register ("com/urbanairship/util/Toaster", DoNotGenerateAcw=true)]
	public partial class Toaster : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/urbanairship/util/Toaster", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Toaster); }
		}

		protected Toaster (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		[Register (".ctor", "()V", "")]
		public Toaster () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (Toaster)) {
				SetHandle (global::Android.Runtime.JNIEnv.CreateInstance (GetType (), "()V"), JniHandleOwnership.TransferLocalRef);
				return;
			}

			if (id_ctor == IntPtr.Zero)
				id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
			SetHandle (JNIEnv.NewObject (class_ref, id_ctor), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_longerToast_Ljava_lang_String_;
		[Register ("longerToast", "(Ljava/lang/String;)V", "")]
		public static void LongerToast (string p0)
		{
			if (id_longerToast_Ljava_lang_String_ == IntPtr.Zero)
				id_longerToast_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "longerToast", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JNIEnv.CallStaticVoidMethod  (class_ref, id_longerToast_Ljava_lang_String_, new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static IntPtr id_simpleToast_Ljava_lang_String_;
		[Register ("simpleToast", "(Ljava/lang/String;)V", "")]
		public static void SimpleToast (string p0)
		{
			if (id_simpleToast_Ljava_lang_String_ == IntPtr.Zero)
				id_simpleToast_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "simpleToast", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JNIEnv.CallStaticVoidMethod  (class_ref, id_simpleToast_Ljava_lang_String_, new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static IntPtr id_toast_Ljava_lang_String_I;
		[Register ("toast", "(Ljava/lang/String;I)V", "")]
		public static void Toast (string p0, int p1)
		{
			if (id_toast_Ljava_lang_String_I == IntPtr.Zero)
				id_toast_Ljava_lang_String_I = JNIEnv.GetStaticMethodID (class_ref, "toast", "(Ljava/lang/String;I)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JNIEnv.CallStaticVoidMethod  (class_ref, id_toast_Ljava_lang_String_I, new JValue (native_p0), new JValue (p1));
			JNIEnv.DeleteLocalRef (native_p0);
		}

	}
}
