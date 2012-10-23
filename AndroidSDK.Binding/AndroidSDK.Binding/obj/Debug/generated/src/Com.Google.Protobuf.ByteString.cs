using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Protobuf {

	[global::Android.Runtime.Register ("com/google/protobuf/ByteString", DoNotGenerateAcw=true)]
	public sealed partial class ByteString : global::Java.Lang.Object {


		static IntPtr EMPTY_jfieldId;

		[Register ("EMPTY")]
		public static global::Com.Google.Protobuf.ByteString Empty {
			get {
				if (EMPTY_jfieldId == IntPtr.Zero)
					EMPTY_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "EMPTY", "Lcom/google/protobuf/ByteString;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, EMPTY_jfieldId);
				return Java.Lang.Object.GetObject<global::Com.Google.Protobuf.ByteString> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (EMPTY_jfieldId == IntPtr.Zero)
					EMPTY_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "EMPTY", "Lcom/google/protobuf/ByteString;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, EMPTY_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}
		[global::Android.Runtime.Register ("com/google/protobuf/ByteString$CodedBuilder", DoNotGenerateAcw=true)]
		public sealed partial class CodedBuilder : global::Java.Lang.Object {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/google/protobuf/ByteString$CodedBuilder", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (CodedBuilder); }
			}

			internal CodedBuilder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_getCodedOutput;
			public global::Com.Google.Protobuf.CodedOutputStream CodedOutput {
				[Register ("getCodedOutput", "()Lcom/google/protobuf/CodedOutputStream;", "GetGetCodedOutputHandler")]
				get {
					if (id_getCodedOutput == IntPtr.Zero)
						id_getCodedOutput = JNIEnv.GetMethodID (class_ref, "getCodedOutput", "()Lcom/google/protobuf/CodedOutputStream;");
					return Java.Lang.Object.GetObject<global::Com.Google.Protobuf.CodedOutputStream> (JNIEnv.CallObjectMethod  (Handle, id_getCodedOutput), JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr id_build;
			[Register ("build", "()Lcom/google/protobuf/ByteString;", "")]
			public global::Com.Google.Protobuf.ByteString Build ()
			{
				if (id_build == IntPtr.Zero)
					id_build = JNIEnv.GetMethodID (class_ref, "build", "()Lcom/google/protobuf/ByteString;");
				return Java.Lang.Object.GetObject<global::Com.Google.Protobuf.ByteString> (JNIEnv.CallObjectMethod  (Handle, id_build), JniHandleOwnership.TransferLocalRef);
			}

		}

		[global::Android.Runtime.Register ("com/google/protobuf/ByteString$Output", DoNotGenerateAcw=true)]
		public sealed partial class Output : global::Java.IO.FilterOutputStream {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/google/protobuf/ByteString$Output", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Output); }
			}

			internal Output (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_toByteString;
			[Register ("toByteString", "()Lcom/google/protobuf/ByteString;", "")]
			public global::Com.Google.Protobuf.ByteString ToByteString ()
			{
				if (id_toByteString == IntPtr.Zero)
					id_toByteString = JNIEnv.GetMethodID (class_ref, "toByteString", "()Lcom/google/protobuf/ByteString;");
				return Java.Lang.Object.GetObject<global::Com.Google.Protobuf.ByteString> (JNIEnv.CallObjectMethod  (Handle, id_toByteString), JniHandleOwnership.TransferLocalRef);
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/protobuf/ByteString", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ByteString); }
		}

		internal ByteString (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_isEmpty;
		public bool IsEmpty {
			[Register ("isEmpty", "()Z", "GetIsEmptyHandler")]
			get {
				if (id_isEmpty == IntPtr.Zero)
					id_isEmpty = JNIEnv.GetMethodID (class_ref, "isEmpty", "()Z");
				return JNIEnv.CallBooleanMethod  (Handle, id_isEmpty);
			}
		}

		static IntPtr id_asReadOnlyByteBuffer;
		[Register ("asReadOnlyByteBuffer", "()Ljava/nio/ByteBuffer;", "")]
		public global::Java.Nio.ByteBuffer AsReadOnlyByteBuffer ()
		{
			if (id_asReadOnlyByteBuffer == IntPtr.Zero)
				id_asReadOnlyByteBuffer = JNIEnv.GetMethodID (class_ref, "asReadOnlyByteBuffer", "()Ljava/nio/ByteBuffer;");
			return Java.Lang.Object.GetObject<global::Java.Nio.ByteBuffer> (JNIEnv.CallObjectMethod  (Handle, id_asReadOnlyByteBuffer), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_byteAt_I;
		[Register ("byteAt", "(I)B", "")]
		public sbyte ByteAt (int p0)
		{
			if (id_byteAt_I == IntPtr.Zero)
				id_byteAt_I = JNIEnv.GetMethodID (class_ref, "byteAt", "(I)B");
			return JNIEnv.CallByteMethod  (Handle, id_byteAt_I, new JValue (p0));
		}

		static IntPtr id_copyFrom_arrayB;
		[Register ("copyFrom", "([B)Lcom/google/protobuf/ByteString;", "")]
		public static global::Com.Google.Protobuf.ByteString CopyFrom (byte[] p0)
		{
			if (id_copyFrom_arrayB == IntPtr.Zero)
				id_copyFrom_arrayB = JNIEnv.GetStaticMethodID (class_ref, "copyFrom", "([B)Lcom/google/protobuf/ByteString;");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			global::Com.Google.Protobuf.ByteString __ret = Java.Lang.Object.GetObject<global::Com.Google.Protobuf.ByteString> (JNIEnv.CallStaticObjectMethod  (class_ref, id_copyFrom_arrayB, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			return __ret;
		}

		static IntPtr id_copyFrom_arrayBII;
		[Register ("copyFrom", "([BII)Lcom/google/protobuf/ByteString;", "")]
		public static global::Com.Google.Protobuf.ByteString CopyFrom (byte[] p0, int p1, int p2)
		{
			if (id_copyFrom_arrayBII == IntPtr.Zero)
				id_copyFrom_arrayBII = JNIEnv.GetStaticMethodID (class_ref, "copyFrom", "([BII)Lcom/google/protobuf/ByteString;");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			global::Com.Google.Protobuf.ByteString __ret = Java.Lang.Object.GetObject<global::Com.Google.Protobuf.ByteString> (JNIEnv.CallStaticObjectMethod  (class_ref, id_copyFrom_arrayBII, new JValue (native_p0), new JValue (p1), new JValue (p2)), JniHandleOwnership.TransferLocalRef);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			return __ret;
		}

		static IntPtr id_copyFrom_Ljava_lang_String_Ljava_lang_String_;
		[Register ("copyFrom", "(Ljava/lang/String;Ljava/lang/String;)Lcom/google/protobuf/ByteString;", "")]
		public static global::Com.Google.Protobuf.ByteString CopyFrom (string p0, string p1)
		{
			if (id_copyFrom_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_copyFrom_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "copyFrom", "(Ljava/lang/String;Ljava/lang/String;)Lcom/google/protobuf/ByteString;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			global::Com.Google.Protobuf.ByteString __ret = Java.Lang.Object.GetObject<global::Com.Google.Protobuf.ByteString> (JNIEnv.CallStaticObjectMethod  (class_ref, id_copyFrom_Ljava_lang_String_Ljava_lang_String_, new JValue (native_p0), new JValue (native_p1)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			return __ret;
		}

		static IntPtr id_copyFrom_Ljava_nio_ByteBuffer_;
		[Register ("copyFrom", "(Ljava/nio/ByteBuffer;)Lcom/google/protobuf/ByteString;", "")]
		public static global::Com.Google.Protobuf.ByteString CopyFrom (global::Java.Nio.ByteBuffer p0)
		{
			if (id_copyFrom_Ljava_nio_ByteBuffer_ == IntPtr.Zero)
				id_copyFrom_Ljava_nio_ByteBuffer_ = JNIEnv.GetStaticMethodID (class_ref, "copyFrom", "(Ljava/nio/ByteBuffer;)Lcom/google/protobuf/ByteString;");
			global::Com.Google.Protobuf.ByteString __ret = Java.Lang.Object.GetObject<global::Com.Google.Protobuf.ByteString> (JNIEnv.CallStaticObjectMethod  (class_ref, id_copyFrom_Ljava_nio_ByteBuffer_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_copyFrom_Ljava_nio_ByteBuffer_I;
		[Register ("copyFrom", "(Ljava/nio/ByteBuffer;I)Lcom/google/protobuf/ByteString;", "")]
		public static global::Com.Google.Protobuf.ByteString CopyFrom (global::Java.Nio.ByteBuffer p0, int p1)
		{
			if (id_copyFrom_Ljava_nio_ByteBuffer_I == IntPtr.Zero)
				id_copyFrom_Ljava_nio_ByteBuffer_I = JNIEnv.GetStaticMethodID (class_ref, "copyFrom", "(Ljava/nio/ByteBuffer;I)Lcom/google/protobuf/ByteString;");
			global::Com.Google.Protobuf.ByteString __ret = Java.Lang.Object.GetObject<global::Com.Google.Protobuf.ByteString> (JNIEnv.CallStaticObjectMethod  (class_ref, id_copyFrom_Ljava_nio_ByteBuffer_I, new JValue (p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_copyFrom_Ljava_util_List_;
		[Register ("copyFrom", "(Ljava/util/List;)Lcom/google/protobuf/ByteString;", "")]
		public static global::Com.Google.Protobuf.ByteString CopyFrom (global::System.Collections.Generic.IList<global::Com.Google.Protobuf.ByteString> p0)
		{
			if (id_copyFrom_Ljava_util_List_ == IntPtr.Zero)
				id_copyFrom_Ljava_util_List_ = JNIEnv.GetStaticMethodID (class_ref, "copyFrom", "(Ljava/util/List;)Lcom/google/protobuf/ByteString;");
			IntPtr native_p0 = global::Android.Runtime.JavaList<global::Com.Google.Protobuf.ByteString>.ToLocalJniHandle (p0);
			global::Com.Google.Protobuf.ByteString __ret = Java.Lang.Object.GetObject<global::Com.Google.Protobuf.ByteString> (JNIEnv.CallStaticObjectMethod  (class_ref, id_copyFrom_Ljava_util_List_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static IntPtr id_copyFromUtf8_Ljava_lang_String_;
		[Register ("copyFromUtf8", "(Ljava/lang/String;)Lcom/google/protobuf/ByteString;", "")]
		public static global::Com.Google.Protobuf.ByteString CopyFromUtf8 (string p0)
		{
			if (id_copyFromUtf8_Ljava_lang_String_ == IntPtr.Zero)
				id_copyFromUtf8_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "copyFromUtf8", "(Ljava/lang/String;)Lcom/google/protobuf/ByteString;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			global::Com.Google.Protobuf.ByteString __ret = Java.Lang.Object.GetObject<global::Com.Google.Protobuf.ByteString> (JNIEnv.CallStaticObjectMethod  (class_ref, id_copyFromUtf8_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static IntPtr id_copyTo_arrayBI;
		[Register ("copyTo", "([BI)V", "")]
		public void CopyTo (byte[] p0, int p1)
		{
			if (id_copyTo_arrayBI == IntPtr.Zero)
				id_copyTo_arrayBI = JNIEnv.GetMethodID (class_ref, "copyTo", "([BI)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			JNIEnv.CallVoidMethod  (Handle, id_copyTo_arrayBI, new JValue (native_p0), new JValue (p1));
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_copyTo_arrayBIII;
		[Register ("copyTo", "([BIII)V", "")]
		public void CopyTo (byte[] p0, int p1, int p2, int p3)
		{
			if (id_copyTo_arrayBIII == IntPtr.Zero)
				id_copyTo_arrayBIII = JNIEnv.GetMethodID (class_ref, "copyTo", "([BIII)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			JNIEnv.CallVoidMethod  (Handle, id_copyTo_arrayBIII, new JValue (native_p0), new JValue (p1), new JValue (p2), new JValue (p3));
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_newCodedInput;
		[Register ("newCodedInput", "()Lcom/google/protobuf/CodedInputStream;", "")]
		public global::Com.Google.Protobuf.CodedInputStream NewCodedInput ()
		{
			if (id_newCodedInput == IntPtr.Zero)
				id_newCodedInput = JNIEnv.GetMethodID (class_ref, "newCodedInput", "()Lcom/google/protobuf/CodedInputStream;");
			return Java.Lang.Object.GetObject<global::Com.Google.Protobuf.CodedInputStream> (JNIEnv.CallObjectMethod  (Handle, id_newCodedInput), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_newInput;
		[Register ("newInput", "()Ljava/io/InputStream;", "")]
		public global::System.IO.Stream NewInput ()
		{
			if (id_newInput == IntPtr.Zero)
				id_newInput = JNIEnv.GetMethodID (class_ref, "newInput", "()Ljava/io/InputStream;");
			return global::Android.Runtime.InputStreamInvoker.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_newInput), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_newOutput;
		[Register ("newOutput", "()Lcom/google/protobuf/ByteString$Output;", "")]
		public static global::Com.Google.Protobuf.ByteString.Output NewOutput ()
		{
			if (id_newOutput == IntPtr.Zero)
				id_newOutput = JNIEnv.GetStaticMethodID (class_ref, "newOutput", "()Lcom/google/protobuf/ByteString$Output;");
			return Java.Lang.Object.GetObject<global::Com.Google.Protobuf.ByteString.Output> (JNIEnv.CallStaticObjectMethod  (class_ref, id_newOutput), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_newOutput_I;
		[Register ("newOutput", "(I)Lcom/google/protobuf/ByteString$Output;", "")]
		public static global::Com.Google.Protobuf.ByteString.Output NewOutput (int p0)
		{
			if (id_newOutput_I == IntPtr.Zero)
				id_newOutput_I = JNIEnv.GetStaticMethodID (class_ref, "newOutput", "(I)Lcom/google/protobuf/ByteString$Output;");
			return Java.Lang.Object.GetObject<global::Com.Google.Protobuf.ByteString.Output> (JNIEnv.CallStaticObjectMethod  (class_ref, id_newOutput_I, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_size;
		[Register ("size", "()I", "")]
		public int Size ()
		{
			if (id_size == IntPtr.Zero)
				id_size = JNIEnv.GetMethodID (class_ref, "size", "()I");
			return JNIEnv.CallIntMethod  (Handle, id_size);
		}

		static IntPtr id_toByteArray;
		[Register ("toByteArray", "()[B", "")]
		public byte[] ToByteArray ()
		{
			if (id_toByteArray == IntPtr.Zero)
				id_toByteArray = JNIEnv.GetMethodID (class_ref, "toByteArray", "()[B");
			return (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_toByteArray), JniHandleOwnership.TransferLocalRef, typeof (byte));
		}

		static IntPtr id_toString_Ljava_lang_String_;
		[Register ("toString", "(Ljava/lang/String;)Ljava/lang/String;", "")]
		public string ToString (string p0)
		{
			if (id_toString_Ljava_lang_String_ == IntPtr.Zero)
				id_toString_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "toString", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			string __ret = JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_toString_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static IntPtr id_toStringUtf8;
		[Register ("toStringUtf8", "()Ljava/lang/String;", "")]
		public string ToStringUtf8 ()
		{
			if (id_toStringUtf8 == IntPtr.Zero)
				id_toStringUtf8 = JNIEnv.GetMethodID (class_ref, "toStringUtf8", "()Ljava/lang/String;");
			return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_toStringUtf8), JniHandleOwnership.TransferLocalRef);
		}

	}
}
