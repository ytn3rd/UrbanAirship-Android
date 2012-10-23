using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Urbanairship.Util {

	[global::Android.Runtime.Register ("com/urbanairship/util/Base64", DoNotGenerateAcw=true)]
	public partial class Base64 : global::Java.Lang.Object {


		[Register ("DONT_GUNZIP")]
		public const int DontGunzip = (int) 4;

		[Register ("DO_BREAK_LINES")]
		public const int DoBreakLines = (int) 8;

		[Register ("GZIP")]
		public const int Gzip = (int) 2;

		[Register ("NO_OPTIONS")]
		public const int NoOptions = (int) 0;

		[Register ("ORDERED")]
		public const int Ordered = (int) 32;

		[Register ("URL_SAFE")]
		public const int UrlSafe = (int) 16;
		[global::Android.Runtime.Register ("com/urbanairship/util/Base64$InputStream", DoNotGenerateAcw=true)]
		public partial class InputStream : global::Java.IO.FilterInputStream {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/urbanairship/util/Base64$InputStream", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (InputStream); }
			}

			protected InputStream (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Ljava_io_InputStream_;
			[Register (".ctor", "(Ljava/io/InputStream;)V", "")]
			public InputStream (global::System.IO.Stream p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				IntPtr native_p0 = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (p0);;
				if (GetType () != typeof (InputStream)) {
					SetHandle (global::Android.Runtime.JNIEnv.CreateInstance (GetType (), "(Ljava/io/InputStream;)V", new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
					JNIEnv.DeleteLocalRef (native_p0);
					return;
				}

				if (id_ctor_Ljava_io_InputStream_ == IntPtr.Zero)
					id_ctor_Ljava_io_InputStream_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/io/InputStream;)V");
				SetHandle (JNIEnv.NewObject (class_ref, id_ctor_Ljava_io_InputStream_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
				JNIEnv.DeleteLocalRef (native_p0);
			}

			static IntPtr id_ctor_Ljava_io_InputStream_I;
			[Register (".ctor", "(Ljava/io/InputStream;I)V", "")]
			public InputStream (global::System.IO.Stream p0, int p1) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				IntPtr native_p0 = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (p0);;
				if (GetType () != typeof (InputStream)) {
					SetHandle (global::Android.Runtime.JNIEnv.CreateInstance (GetType (), "(Ljava/io/InputStream;I)V", new JValue (native_p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
					JNIEnv.DeleteLocalRef (native_p0);
					return;
				}

				if (id_ctor_Ljava_io_InputStream_I == IntPtr.Zero)
					id_ctor_Ljava_io_InputStream_I = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/io/InputStream;I)V");
				SetHandle (JNIEnv.NewObject (class_ref, id_ctor_Ljava_io_InputStream_I, new JValue (native_p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
				JNIEnv.DeleteLocalRef (native_p0);
			}

		}

		[global::Android.Runtime.Register ("com/urbanairship/util/Base64$OutputStream", DoNotGenerateAcw=true)]
		public partial class OutputStream : global::Java.IO.FilterOutputStream {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/urbanairship/util/Base64$OutputStream", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (OutputStream); }
			}

			protected OutputStream (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Ljava_io_OutputStream_I;
			[Register (".ctor", "(Ljava/io/OutputStream;I)V", "")]
			public OutputStream (global::System.IO.Stream p0, int p1) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				IntPtr native_p0 = global::Android.Runtime.OutputStreamAdapter.ToLocalJniHandle (p0);;
				if (GetType () != typeof (OutputStream)) {
					SetHandle (global::Android.Runtime.JNIEnv.CreateInstance (GetType (), "(Ljava/io/OutputStream;I)V", new JValue (native_p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
					JNIEnv.DeleteLocalRef (native_p0);
					return;
				}

				if (id_ctor_Ljava_io_OutputStream_I == IntPtr.Zero)
					id_ctor_Ljava_io_OutputStream_I = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/io/OutputStream;I)V");
				SetHandle (JNIEnv.NewObject (class_ref, id_ctor_Ljava_io_OutputStream_I, new JValue (native_p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
				JNIEnv.DeleteLocalRef (native_p0);
			}

			static IntPtr id_ctor_Ljava_io_OutputStream_;
			[Register (".ctor", "(Ljava/io/OutputStream;)V", "")]
			public OutputStream (global::System.IO.Stream p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				IntPtr native_p0 = global::Android.Runtime.OutputStreamAdapter.ToLocalJniHandle (p0);;
				if (GetType () != typeof (OutputStream)) {
					SetHandle (global::Android.Runtime.JNIEnv.CreateInstance (GetType (), "(Ljava/io/OutputStream;)V", new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
					JNIEnv.DeleteLocalRef (native_p0);
					return;
				}

				if (id_ctor_Ljava_io_OutputStream_ == IntPtr.Zero)
					id_ctor_Ljava_io_OutputStream_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/io/OutputStream;)V");
				SetHandle (JNIEnv.NewObject (class_ref, id_ctor_Ljava_io_OutputStream_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
				JNIEnv.DeleteLocalRef (native_p0);
			}

			static Delegate cb_flushBase64;
#pragma warning disable 0169
			static Delegate GetFlushBase64Handler ()
			{
				if (cb_flushBase64 == null)
					cb_flushBase64 = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_FlushBase64);
				return cb_flushBase64;
			}

			static void n_FlushBase64 (IntPtr jnienv, IntPtr native__this)
			{
				OutputStream __this = Java.Lang.Object.GetObject<OutputStream> (native__this, JniHandleOwnership.DoNotTransfer);
				__this.FlushBase64 ();
			}
#pragma warning restore 0169

			static IntPtr id_flushBase64;
			[Register ("flushBase64", "()V", "GetFlushBase64Handler")]
			public virtual void FlushBase64 ()
			{
				if (id_flushBase64 == IntPtr.Zero)
					id_flushBase64 = JNIEnv.GetMethodID (class_ref, "flushBase64", "()V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_flushBase64);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_flushBase64);
			}

			static Delegate cb_resumeEncoding;
#pragma warning disable 0169
			static Delegate GetResumeEncodingHandler ()
			{
				if (cb_resumeEncoding == null)
					cb_resumeEncoding = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ResumeEncoding);
				return cb_resumeEncoding;
			}

			static void n_ResumeEncoding (IntPtr jnienv, IntPtr native__this)
			{
				OutputStream __this = Java.Lang.Object.GetObject<OutputStream> (native__this, JniHandleOwnership.DoNotTransfer);
				__this.ResumeEncoding ();
			}
#pragma warning restore 0169

			static IntPtr id_resumeEncoding;
			[Register ("resumeEncoding", "()V", "GetResumeEncodingHandler")]
			public virtual void ResumeEncoding ()
			{
				if (id_resumeEncoding == IntPtr.Zero)
					id_resumeEncoding = JNIEnv.GetMethodID (class_ref, "resumeEncoding", "()V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_resumeEncoding);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_resumeEncoding);
			}

			static Delegate cb_suspendEncoding;
#pragma warning disable 0169
			static Delegate GetSuspendEncodingHandler ()
			{
				if (cb_suspendEncoding == null)
					cb_suspendEncoding = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_SuspendEncoding);
				return cb_suspendEncoding;
			}

			static void n_SuspendEncoding (IntPtr jnienv, IntPtr native__this)
			{
				OutputStream __this = Java.Lang.Object.GetObject<OutputStream> (native__this, JniHandleOwnership.DoNotTransfer);
				__this.SuspendEncoding ();
			}
#pragma warning restore 0169

			static IntPtr id_suspendEncoding;
			[Register ("suspendEncoding", "()V", "GetSuspendEncodingHandler")]
			public virtual void SuspendEncoding ()
			{
				if (id_suspendEncoding == IntPtr.Zero)
					id_suspendEncoding = JNIEnv.GetMethodID (class_ref, "suspendEncoding", "()V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_suspendEncoding);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_suspendEncoding);
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/urbanairship/util/Base64", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Base64); }
		}

		protected Base64 (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_decode_arrayB;
		[Register ("decode", "([B)[B", "")]
		public static byte[] Decode (byte[] p0)
		{
			if (id_decode_arrayB == IntPtr.Zero)
				id_decode_arrayB = JNIEnv.GetStaticMethodID (class_ref, "decode", "([B)[B");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			byte[] __ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_decode_arrayB, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef, typeof (byte));
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			return __ret;
		}

		static IntPtr id_decode_arrayBIII;
		[Register ("decode", "([BIII)[B", "")]
		public static byte[] Decode (byte[] p0, int p1, int p2, int p3)
		{
			if (id_decode_arrayBIII == IntPtr.Zero)
				id_decode_arrayBIII = JNIEnv.GetStaticMethodID (class_ref, "decode", "([BIII)[B");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			byte[] __ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_decode_arrayBIII, new JValue (native_p0), new JValue (p1), new JValue (p2), new JValue (p3)), JniHandleOwnership.TransferLocalRef, typeof (byte));
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			return __ret;
		}

		static IntPtr id_decode_Ljava_lang_String_;
		[Register ("decode", "(Ljava/lang/String;)[B", "")]
		public static byte[] Decode (string p0)
		{
			if (id_decode_Ljava_lang_String_ == IntPtr.Zero)
				id_decode_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "decode", "(Ljava/lang/String;)[B");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			byte[] __ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_decode_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef, typeof (byte));
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static IntPtr id_decode_Ljava_lang_String_I;
		[Register ("decode", "(Ljava/lang/String;I)[B", "")]
		public static byte[] Decode (string p0, int p1)
		{
			if (id_decode_Ljava_lang_String_I == IntPtr.Zero)
				id_decode_Ljava_lang_String_I = JNIEnv.GetStaticMethodID (class_ref, "decode", "(Ljava/lang/String;I)[B");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			byte[] __ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_decode_Ljava_lang_String_I, new JValue (native_p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef, typeof (byte));
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static IntPtr id_decodeFileToFile_Ljava_lang_String_Ljava_lang_String_;
		[Register ("decodeFileToFile", "(Ljava/lang/String;Ljava/lang/String;)V", "")]
		public static void DecodeFileToFile (string p0, string p1)
		{
			if (id_decodeFileToFile_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_decodeFileToFile_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "decodeFileToFile", "(Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JNIEnv.CallStaticVoidMethod  (class_ref, id_decodeFileToFile_Ljava_lang_String_Ljava_lang_String_, new JValue (native_p0), new JValue (native_p1));
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static IntPtr id_decodeFromFile_Ljava_lang_String_;
		[Register ("decodeFromFile", "(Ljava/lang/String;)[B", "")]
		public static byte[] DecodeFromFile (string p0)
		{
			if (id_decodeFromFile_Ljava_lang_String_ == IntPtr.Zero)
				id_decodeFromFile_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "decodeFromFile", "(Ljava/lang/String;)[B");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			byte[] __ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_decodeFromFile_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef, typeof (byte));
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static IntPtr id_decodeToFile_Ljava_lang_String_Ljava_lang_String_;
		[Register ("decodeToFile", "(Ljava/lang/String;Ljava/lang/String;)V", "")]
		public static void DecodeToFile (string p0, string p1)
		{
			if (id_decodeToFile_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_decodeToFile_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "decodeToFile", "(Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JNIEnv.CallStaticVoidMethod  (class_ref, id_decodeToFile_Ljava_lang_String_Ljava_lang_String_, new JValue (native_p0), new JValue (native_p1));
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static IntPtr id_decodeToObject_Ljava_lang_String_;
		[Register ("decodeToObject", "(Ljava/lang/String;)Ljava/lang/Object;", "")]
		public static global::Java.Lang.Object DecodeToObject (string p0)
		{
			if (id_decodeToObject_Ljava_lang_String_ == IntPtr.Zero)
				id_decodeToObject_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "decodeToObject", "(Ljava/lang/String;)Ljava/lang/Object;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			global::Java.Lang.Object __ret = Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallStaticObjectMethod  (class_ref, id_decodeToObject_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static IntPtr id_decodeToObject_Ljava_lang_String_ILjava_lang_ClassLoader_;
		[Register ("decodeToObject", "(Ljava/lang/String;ILjava/lang/ClassLoader;)Ljava/lang/Object;", "")]
		public static global::Java.Lang.Object DecodeToObject (string p0, int p1, global::Java.Lang.ClassLoader p2)
		{
			if (id_decodeToObject_Ljava_lang_String_ILjava_lang_ClassLoader_ == IntPtr.Zero)
				id_decodeToObject_Ljava_lang_String_ILjava_lang_ClassLoader_ = JNIEnv.GetStaticMethodID (class_ref, "decodeToObject", "(Ljava/lang/String;ILjava/lang/ClassLoader;)Ljava/lang/Object;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			global::Java.Lang.Object __ret = Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallStaticObjectMethod  (class_ref, id_decodeToObject_Ljava_lang_String_ILjava_lang_ClassLoader_, new JValue (native_p0), new JValue (p1), new JValue (p2)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static IntPtr id_encode_Ljava_nio_ByteBuffer_Ljava_nio_ByteBuffer_;
		[Register ("encode", "(Ljava/nio/ByteBuffer;Ljava/nio/ByteBuffer;)V", "")]
		public static void Encode (global::Java.Nio.ByteBuffer p0, global::Java.Nio.ByteBuffer p1)
		{
			if (id_encode_Ljava_nio_ByteBuffer_Ljava_nio_ByteBuffer_ == IntPtr.Zero)
				id_encode_Ljava_nio_ByteBuffer_Ljava_nio_ByteBuffer_ = JNIEnv.GetStaticMethodID (class_ref, "encode", "(Ljava/nio/ByteBuffer;Ljava/nio/ByteBuffer;)V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_encode_Ljava_nio_ByteBuffer_Ljava_nio_ByteBuffer_, new JValue (p0), new JValue (p1));
		}

		static IntPtr id_encode_Ljava_nio_ByteBuffer_Ljava_nio_CharBuffer_;
		[Register ("encode", "(Ljava/nio/ByteBuffer;Ljava/nio/CharBuffer;)V", "")]
		public static void Encode (global::Java.Nio.ByteBuffer p0, global::Java.Nio.CharBuffer p1)
		{
			if (id_encode_Ljava_nio_ByteBuffer_Ljava_nio_CharBuffer_ == IntPtr.Zero)
				id_encode_Ljava_nio_ByteBuffer_Ljava_nio_CharBuffer_ = JNIEnv.GetStaticMethodID (class_ref, "encode", "(Ljava/nio/ByteBuffer;Ljava/nio/CharBuffer;)V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_encode_Ljava_nio_ByteBuffer_Ljava_nio_CharBuffer_, new JValue (p0), new JValue (p1));
		}

		static IntPtr id_encodeBytes_arrayB;
		[Register ("encodeBytes", "([B)Ljava/lang/String;", "")]
		public static string EncodeBytes (byte[] p0)
		{
			if (id_encodeBytes_arrayB == IntPtr.Zero)
				id_encodeBytes_arrayB = JNIEnv.GetStaticMethodID (class_ref, "encodeBytes", "([B)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_encodeBytes_arrayB, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			return __ret;
		}

		static IntPtr id_encodeBytes_arrayBI;
		[Register ("encodeBytes", "([BI)Ljava/lang/String;", "")]
		public static string EncodeBytes (byte[] p0, int p1)
		{
			if (id_encodeBytes_arrayBI == IntPtr.Zero)
				id_encodeBytes_arrayBI = JNIEnv.GetStaticMethodID (class_ref, "encodeBytes", "([BI)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_encodeBytes_arrayBI, new JValue (native_p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			return __ret;
		}

		static IntPtr id_encodeBytes_arrayBII;
		[Register ("encodeBytes", "([BII)Ljava/lang/String;", "")]
		public static string EncodeBytes (byte[] p0, int p1, int p2)
		{
			if (id_encodeBytes_arrayBII == IntPtr.Zero)
				id_encodeBytes_arrayBII = JNIEnv.GetStaticMethodID (class_ref, "encodeBytes", "([BII)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_encodeBytes_arrayBII, new JValue (native_p0), new JValue (p1), new JValue (p2)), JniHandleOwnership.TransferLocalRef);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			return __ret;
		}

		static IntPtr id_encodeBytes_arrayBIII;
		[Register ("encodeBytes", "([BIII)Ljava/lang/String;", "")]
		public static string EncodeBytes (byte[] p0, int p1, int p2, int p3)
		{
			if (id_encodeBytes_arrayBIII == IntPtr.Zero)
				id_encodeBytes_arrayBIII = JNIEnv.GetStaticMethodID (class_ref, "encodeBytes", "([BIII)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_encodeBytes_arrayBIII, new JValue (native_p0), new JValue (p1), new JValue (p2), new JValue (p3)), JniHandleOwnership.TransferLocalRef);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			return __ret;
		}

		static IntPtr id_encodeBytesToBytes_arrayB;
		[Register ("encodeBytesToBytes", "([B)[B", "")]
		public static byte[] EncodeBytesToBytes (byte[] p0)
		{
			if (id_encodeBytesToBytes_arrayB == IntPtr.Zero)
				id_encodeBytesToBytes_arrayB = JNIEnv.GetStaticMethodID (class_ref, "encodeBytesToBytes", "([B)[B");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			byte[] __ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_encodeBytesToBytes_arrayB, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef, typeof (byte));
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			return __ret;
		}

		static IntPtr id_encodeBytesToBytes_arrayBIII;
		[Register ("encodeBytesToBytes", "([BIII)[B", "")]
		public static byte[] EncodeBytesToBytes (byte[] p0, int p1, int p2, int p3)
		{
			if (id_encodeBytesToBytes_arrayBIII == IntPtr.Zero)
				id_encodeBytesToBytes_arrayBIII = JNIEnv.GetStaticMethodID (class_ref, "encodeBytesToBytes", "([BIII)[B");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			byte[] __ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_encodeBytesToBytes_arrayBIII, new JValue (native_p0), new JValue (p1), new JValue (p2), new JValue (p3)), JniHandleOwnership.TransferLocalRef, typeof (byte));
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			return __ret;
		}

		static IntPtr id_encodeFileToFile_Ljava_lang_String_Ljava_lang_String_;
		[Register ("encodeFileToFile", "(Ljava/lang/String;Ljava/lang/String;)V", "")]
		public static void EncodeFileToFile (string p0, string p1)
		{
			if (id_encodeFileToFile_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_encodeFileToFile_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "encodeFileToFile", "(Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JNIEnv.CallStaticVoidMethod  (class_ref, id_encodeFileToFile_Ljava_lang_String_Ljava_lang_String_, new JValue (native_p0), new JValue (native_p1));
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static IntPtr id_encodeFromFile_Ljava_lang_String_;
		[Register ("encodeFromFile", "(Ljava/lang/String;)Ljava/lang/String;", "")]
		public static string EncodeFromFile (string p0)
		{
			if (id_encodeFromFile_Ljava_lang_String_ == IntPtr.Zero)
				id_encodeFromFile_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "encodeFromFile", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_encodeFromFile_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static IntPtr id_encodeObject_Ljava_io_Serializable_;
		[Register ("encodeObject", "(Ljava/io/Serializable;)Ljava/lang/String;", "")]
		public static string EncodeObject (global::Java.IO.ISerializable p0)
		{
			if (id_encodeObject_Ljava_io_Serializable_ == IntPtr.Zero)
				id_encodeObject_Ljava_io_Serializable_ = JNIEnv.GetStaticMethodID (class_ref, "encodeObject", "(Ljava/io/Serializable;)Ljava/lang/String;");
			string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_encodeObject_Ljava_io_Serializable_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_encodeObject_Ljava_io_Serializable_I;
		[Register ("encodeObject", "(Ljava/io/Serializable;I)Ljava/lang/String;", "")]
		public static string EncodeObject (global::Java.IO.ISerializable p0, int p1)
		{
			if (id_encodeObject_Ljava_io_Serializable_I == IntPtr.Zero)
				id_encodeObject_Ljava_io_Serializable_I = JNIEnv.GetStaticMethodID (class_ref, "encodeObject", "(Ljava/io/Serializable;I)Ljava/lang/String;");
			string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_encodeObject_Ljava_io_Serializable_I, new JValue (p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_encodeToFile_arrayBLjava_lang_String_;
		[Register ("encodeToFile", "([BLjava/lang/String;)V", "")]
		public static void EncodeToFile (byte[] p0, string p1)
		{
			if (id_encodeToFile_arrayBLjava_lang_String_ == IntPtr.Zero)
				id_encodeToFile_arrayBLjava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "encodeToFile", "([BLjava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JNIEnv.CallStaticVoidMethod  (class_ref, id_encodeToFile_arrayBLjava_lang_String_, new JValue (native_p0), new JValue (native_p1));
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			JNIEnv.DeleteLocalRef (native_p1);
		}

	}
}
