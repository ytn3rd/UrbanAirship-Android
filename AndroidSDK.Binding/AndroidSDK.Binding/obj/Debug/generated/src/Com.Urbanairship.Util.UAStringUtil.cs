using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Urbanairship.Util {

	[global::Android.Runtime.Register ("com/urbanairship/util/UAStringUtil", DoNotGenerateAcw=true)]
	public abstract partial class UAStringUtil : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/urbanairship/util/UAStringUtil", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (UAStringUtil); }
		}

		protected UAStringUtil (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		[Register (".ctor", "()V", "")]
		public UAStringUtil () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (UAStringUtil)) {
				SetHandle (global::Android.Runtime.JNIEnv.CreateInstance (GetType (), "()V"), JniHandleOwnership.TransferLocalRef);
				return;
			}

			if (id_ctor == IntPtr.Zero)
				id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
			SetHandle (JNIEnv.NewObject (class_ref, id_ctor), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_equals_Ljava_lang_String_Ljava_lang_String_;
		[Register ("equals", "(Ljava/lang/String;Ljava/lang/String;)Z", "")]
		public static bool Equals (string p0, string p1)
		{
			if (id_equals_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_equals_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "equals", "(Ljava/lang/String;Ljava/lang/String;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_equals_Ljava_lang_String_Ljava_lang_String_, new JValue (native_p0), new JValue (native_p1));
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			return __ret;
		}

		static IntPtr id_isEmpty_Ljava_lang_String_;
		[Register ("isEmpty", "(Ljava/lang/String;)Z", "")]
		public static bool IsEmpty (string p0)
		{
			if (id_isEmpty_Ljava_lang_String_ == IntPtr.Zero)
				id_isEmpty_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "isEmpty", "(Ljava/lang/String;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_isEmpty_Ljava_lang_String_, new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static IntPtr id_join_Ljava_util_Collection_Ljava_lang_String_;
		[Register ("join", "(Ljava/util/Collection;Ljava/lang/String;)Ljava/lang/String;", "")]
		public static string Join (global::System.Collections.ICollection p0, string p1)
		{
			if (id_join_Ljava_util_Collection_Ljava_lang_String_ == IntPtr.Zero)
				id_join_Ljava_util_Collection_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "join", "(Ljava/util/Collection;Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = global::Android.Runtime.JavaCollection.ToLocalJniHandle (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_join_Ljava_util_Collection_Ljava_lang_String_, new JValue (native_p0), new JValue (native_p1)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			return __ret;
		}

		static IntPtr id_repeat_Ljava_lang_String_ILjava_lang_String_;
		[Register ("repeat", "(Ljava/lang/String;ILjava/lang/String;)Ljava/lang/String;", "")]
		public static string Repeat (string p0, int p1, string p2)
		{
			if (id_repeat_Ljava_lang_String_ILjava_lang_String_ == IntPtr.Zero)
				id_repeat_Ljava_lang_String_ILjava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "repeat", "(Ljava/lang/String;ILjava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_repeat_Ljava_lang_String_ILjava_lang_String_, new JValue (native_p0), new JValue (p1), new JValue (native_p2)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p2);
			return __ret;
		}

	}

	[global::Android.Runtime.Register ("com/urbanairship/util/UAStringUtil", DoNotGenerateAcw=true)]
	internal partial class UAStringUtilInvoker : UAStringUtil {

		public UAStringUtilInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (UAStringUtilInvoker); }
		}

	}

}
