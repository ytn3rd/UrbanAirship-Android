using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Urbanairship {

	[global::Android.Runtime.Register ("com/urbanairship/Logger", DoNotGenerateAcw=true)]
	public partial class Logger : global::Java.Lang.Object {


		static IntPtr TAG_jfieldId;

		[Register ("TAG")]
		public static string Tag {
			get {
				if (TAG_jfieldId == IntPtr.Zero)
					TAG_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TAG", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TAG_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (TAG_jfieldId == IntPtr.Zero)
					TAG_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TAG", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				JNIEnv.SetStaticField (class_ref, TAG_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr logLevel_jfieldId;

		[Register ("logLevel")]
		public static int LogLevel {
			get {
				if (logLevel_jfieldId == IntPtr.Zero)
					logLevel_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "logLevel", "I");
				return JNIEnv.GetStaticIntField (class_ref, logLevel_jfieldId);
			}
			set {
				if (logLevel_jfieldId == IntPtr.Zero)
					logLevel_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "logLevel", "I");
				JNIEnv.SetStaticField (class_ref, logLevel_jfieldId, value);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/urbanairship/Logger", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Logger); }
		}

		protected Logger (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_debug_Ljava_lang_String_;
		[Register ("debug", "(Ljava/lang/String;)V", "")]
		public static void Debug (string p0)
		{
			if (id_debug_Ljava_lang_String_ == IntPtr.Zero)
				id_debug_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "debug", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JNIEnv.CallStaticVoidMethod  (class_ref, id_debug_Ljava_lang_String_, new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static IntPtr id_error_Ljava_lang_String_;
		[Register ("error", "(Ljava/lang/String;)V", "")]
		public static void Error (string p0)
		{
			if (id_error_Ljava_lang_String_ == IntPtr.Zero)
				id_error_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "error", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JNIEnv.CallStaticVoidMethod  (class_ref, id_error_Ljava_lang_String_, new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static IntPtr id_error_Ljava_lang_String_Ljava_lang_Throwable_;
		[Register ("error", "(Ljava/lang/String;Ljava/lang/Throwable;)V", "")]
		public static void Error (string p0, global::Java.Lang.Throwable p1)
		{
			if (id_error_Ljava_lang_String_Ljava_lang_Throwable_ == IntPtr.Zero)
				id_error_Ljava_lang_String_Ljava_lang_Throwable_ = JNIEnv.GetStaticMethodID (class_ref, "error", "(Ljava/lang/String;Ljava/lang/Throwable;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JNIEnv.CallStaticVoidMethod  (class_ref, id_error_Ljava_lang_String_Ljava_lang_Throwable_, new JValue (native_p0), new JValue (p1));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static IntPtr id_error_Ljava_lang_Throwable_;
		[Register ("error", "(Ljava/lang/Throwable;)V", "")]
		public static void Error (global::Java.Lang.Throwable p0)
		{
			if (id_error_Ljava_lang_Throwable_ == IntPtr.Zero)
				id_error_Ljava_lang_Throwable_ = JNIEnv.GetStaticMethodID (class_ref, "error", "(Ljava/lang/Throwable;)V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_error_Ljava_lang_Throwable_, new JValue (p0));
		}

		static IntPtr id_info_Ljava_lang_String_;
		[Register ("info", "(Ljava/lang/String;)V", "")]
		public static void Info (string p0)
		{
			if (id_info_Ljava_lang_String_ == IntPtr.Zero)
				id_info_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "info", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JNIEnv.CallStaticVoidMethod  (class_ref, id_info_Ljava_lang_String_, new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static IntPtr id_info_Ljava_lang_String_Ljava_lang_Throwable_;
		[Register ("info", "(Ljava/lang/String;Ljava/lang/Throwable;)V", "")]
		public static void Info (string p0, global::Java.Lang.Throwable p1)
		{
			if (id_info_Ljava_lang_String_Ljava_lang_Throwable_ == IntPtr.Zero)
				id_info_Ljava_lang_String_Ljava_lang_Throwable_ = JNIEnv.GetStaticMethodID (class_ref, "info", "(Ljava/lang/String;Ljava/lang/Throwable;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JNIEnv.CallStaticVoidMethod  (class_ref, id_info_Ljava_lang_String_Ljava_lang_Throwable_, new JValue (native_p0), new JValue (p1));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static IntPtr id_verbose_Ljava_lang_String_;
		[Register ("verbose", "(Ljava/lang/String;)V", "")]
		public static void Verbose (string p0)
		{
			if (id_verbose_Ljava_lang_String_ == IntPtr.Zero)
				id_verbose_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "verbose", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JNIEnv.CallStaticVoidMethod  (class_ref, id_verbose_Ljava_lang_String_, new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static IntPtr id_warn_Ljava_lang_String_;
		[Register ("warn", "(Ljava/lang/String;)V", "")]
		public static void Warn (string p0)
		{
			if (id_warn_Ljava_lang_String_ == IntPtr.Zero)
				id_warn_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "warn", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JNIEnv.CallStaticVoidMethod  (class_ref, id_warn_Ljava_lang_String_, new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static IntPtr id_warn_Ljava_lang_String_Ljava_lang_Throwable_;
		[Register ("warn", "(Ljava/lang/String;Ljava/lang/Throwable;)V", "")]
		public static void Warn (string p0, global::Java.Lang.Throwable p1)
		{
			if (id_warn_Ljava_lang_String_Ljava_lang_Throwable_ == IntPtr.Zero)
				id_warn_Ljava_lang_String_Ljava_lang_Throwable_ = JNIEnv.GetStaticMethodID (class_ref, "warn", "(Ljava/lang/String;Ljava/lang/Throwable;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JNIEnv.CallStaticVoidMethod  (class_ref, id_warn_Ljava_lang_String_Ljava_lang_Throwable_, new JValue (native_p0), new JValue (p1));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static IntPtr id_warn_Ljava_lang_Throwable_;
		[Register ("warn", "(Ljava/lang/Throwable;)V", "")]
		public static void Warn (global::Java.Lang.Throwable p0)
		{
			if (id_warn_Ljava_lang_Throwable_ == IntPtr.Zero)
				id_warn_Ljava_lang_Throwable_ = JNIEnv.GetStaticMethodID (class_ref, "warn", "(Ljava/lang/Throwable;)V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_warn_Ljava_lang_Throwable_, new JValue (p0));
		}

	}
}
