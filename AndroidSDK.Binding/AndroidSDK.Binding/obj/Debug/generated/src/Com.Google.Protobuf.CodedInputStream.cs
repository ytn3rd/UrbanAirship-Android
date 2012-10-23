using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Protobuf {

	[global::Android.Runtime.Register ("com/google/protobuf/CodedInputStream", DoNotGenerateAcw=true)]
	public sealed partial class CodedInputStream : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/protobuf/CodedInputStream", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (CodedInputStream); }
		}

		internal CodedInputStream (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_getBytesUntilLimit;
		public int BytesUntilLimit {
			[Register ("getBytesUntilLimit", "()I", "GetGetBytesUntilLimitHandler")]
			get {
				if (id_getBytesUntilLimit == IntPtr.Zero)
					id_getBytesUntilLimit = JNIEnv.GetMethodID (class_ref, "getBytesUntilLimit", "()I");
				return JNIEnv.CallIntMethod  (Handle, id_getBytesUntilLimit);
			}
		}

		static IntPtr id_isAtEnd;
		public bool IsAtEnd {
			[Register ("isAtEnd", "()Z", "GetIsAtEndHandler")]
			get {
				if (id_isAtEnd == IntPtr.Zero)
					id_isAtEnd = JNIEnv.GetMethodID (class_ref, "isAtEnd", "()Z");
				return JNIEnv.CallBooleanMethod  (Handle, id_isAtEnd);
			}
		}

		static IntPtr id_getTotalBytesRead;
		public int TotalBytesRead {
			[Register ("getTotalBytesRead", "()I", "GetGetTotalBytesReadHandler")]
			get {
				if (id_getTotalBytesRead == IntPtr.Zero)
					id_getTotalBytesRead = JNIEnv.GetMethodID (class_ref, "getTotalBytesRead", "()I");
				return JNIEnv.CallIntMethod  (Handle, id_getTotalBytesRead);
			}
		}

		static IntPtr id_checkLastTagWas_I;
		[Register ("checkLastTagWas", "(I)V", "")]
		public void CheckLastTagWas (int p0)
		{
			if (id_checkLastTagWas_I == IntPtr.Zero)
				id_checkLastTagWas_I = JNIEnv.GetMethodID (class_ref, "checkLastTagWas", "(I)V");
			JNIEnv.CallVoidMethod  (Handle, id_checkLastTagWas_I, new JValue (p0));
		}

		static IntPtr id_decodeZigZag32_I;
		[Register ("decodeZigZag32", "(I)I", "")]
		public static int DecodeZigZag32 (int p0)
		{
			if (id_decodeZigZag32_I == IntPtr.Zero)
				id_decodeZigZag32_I = JNIEnv.GetStaticMethodID (class_ref, "decodeZigZag32", "(I)I");
			return JNIEnv.CallStaticIntMethod  (class_ref, id_decodeZigZag32_I, new JValue (p0));
		}

		static IntPtr id_decodeZigZag64_J;
		[Register ("decodeZigZag64", "(J)J", "")]
		public static long DecodeZigZag64 (long p0)
		{
			if (id_decodeZigZag64_J == IntPtr.Zero)
				id_decodeZigZag64_J = JNIEnv.GetStaticMethodID (class_ref, "decodeZigZag64", "(J)J");
			return JNIEnv.CallStaticLongMethod  (class_ref, id_decodeZigZag64_J, new JValue (p0));
		}

		static IntPtr id_newInstance_arrayB;
		[Register ("newInstance", "([B)Lcom/google/protobuf/CodedInputStream;", "")]
		public static global::Com.Google.Protobuf.CodedInputStream NewInstance (byte[] p0)
		{
			if (id_newInstance_arrayB == IntPtr.Zero)
				id_newInstance_arrayB = JNIEnv.GetStaticMethodID (class_ref, "newInstance", "([B)Lcom/google/protobuf/CodedInputStream;");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			global::Com.Google.Protobuf.CodedInputStream __ret = Java.Lang.Object.GetObject<global::Com.Google.Protobuf.CodedInputStream> (JNIEnv.CallStaticObjectMethod  (class_ref, id_newInstance_arrayB, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			return __ret;
		}

		static IntPtr id_newInstance_arrayBII;
		[Register ("newInstance", "([BII)Lcom/google/protobuf/CodedInputStream;", "")]
		public static global::Com.Google.Protobuf.CodedInputStream NewInstance (byte[] p0, int p1, int p2)
		{
			if (id_newInstance_arrayBII == IntPtr.Zero)
				id_newInstance_arrayBII = JNIEnv.GetStaticMethodID (class_ref, "newInstance", "([BII)Lcom/google/protobuf/CodedInputStream;");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			global::Com.Google.Protobuf.CodedInputStream __ret = Java.Lang.Object.GetObject<global::Com.Google.Protobuf.CodedInputStream> (JNIEnv.CallStaticObjectMethod  (class_ref, id_newInstance_arrayBII, new JValue (native_p0), new JValue (p1), new JValue (p2)), JniHandleOwnership.TransferLocalRef);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			return __ret;
		}

		static IntPtr id_newInstance_Ljava_io_InputStream_;
		[Register ("newInstance", "(Ljava/io/InputStream;)Lcom/google/protobuf/CodedInputStream;", "")]
		public static global::Com.Google.Protobuf.CodedInputStream NewInstance (global::System.IO.Stream p0)
		{
			if (id_newInstance_Ljava_io_InputStream_ == IntPtr.Zero)
				id_newInstance_Ljava_io_InputStream_ = JNIEnv.GetStaticMethodID (class_ref, "newInstance", "(Ljava/io/InputStream;)Lcom/google/protobuf/CodedInputStream;");
			IntPtr native_p0 = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (p0);
			global::Com.Google.Protobuf.CodedInputStream __ret = Java.Lang.Object.GetObject<global::Com.Google.Protobuf.CodedInputStream> (JNIEnv.CallStaticObjectMethod  (class_ref, id_newInstance_Ljava_io_InputStream_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static IntPtr id_popLimit_I;
		[Register ("popLimit", "(I)V", "")]
		public void PopLimit (int p0)
		{
			if (id_popLimit_I == IntPtr.Zero)
				id_popLimit_I = JNIEnv.GetMethodID (class_ref, "popLimit", "(I)V");
			JNIEnv.CallVoidMethod  (Handle, id_popLimit_I, new JValue (p0));
		}

		static IntPtr id_pushLimit_I;
		[Register ("pushLimit", "(I)I", "")]
		public int PushLimit (int p0)
		{
			if (id_pushLimit_I == IntPtr.Zero)
				id_pushLimit_I = JNIEnv.GetMethodID (class_ref, "pushLimit", "(I)I");
			return JNIEnv.CallIntMethod  (Handle, id_pushLimit_I, new JValue (p0));
		}

		static IntPtr id_readBool;
		[Register ("readBool", "()Z", "")]
		public bool ReadBool ()
		{
			if (id_readBool == IntPtr.Zero)
				id_readBool = JNIEnv.GetMethodID (class_ref, "readBool", "()Z");
			return JNIEnv.CallBooleanMethod  (Handle, id_readBool);
		}

		static IntPtr id_readBytes;
		[Register ("readBytes", "()Lcom/google/protobuf/ByteString;", "")]
		public global::Com.Google.Protobuf.ByteString ReadBytes ()
		{
			if (id_readBytes == IntPtr.Zero)
				id_readBytes = JNIEnv.GetMethodID (class_ref, "readBytes", "()Lcom/google/protobuf/ByteString;");
			return Java.Lang.Object.GetObject<global::Com.Google.Protobuf.ByteString> (JNIEnv.CallObjectMethod  (Handle, id_readBytes), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_readDouble;
		[Register ("readDouble", "()D", "")]
		public double ReadDouble ()
		{
			if (id_readDouble == IntPtr.Zero)
				id_readDouble = JNIEnv.GetMethodID (class_ref, "readDouble", "()D");
			return JNIEnv.CallDoubleMethod  (Handle, id_readDouble);
		}

		static IntPtr id_readEnum;
		[Register ("readEnum", "()I", "")]
		public int ReadEnum ()
		{
			if (id_readEnum == IntPtr.Zero)
				id_readEnum = JNIEnv.GetMethodID (class_ref, "readEnum", "()I");
			return JNIEnv.CallIntMethod  (Handle, id_readEnum);
		}

		static IntPtr id_readFixed32;
		[Register ("readFixed32", "()I", "")]
		public int ReadFixed32 ()
		{
			if (id_readFixed32 == IntPtr.Zero)
				id_readFixed32 = JNIEnv.GetMethodID (class_ref, "readFixed32", "()I");
			return JNIEnv.CallIntMethod  (Handle, id_readFixed32);
		}

		static IntPtr id_readFixed64;
		[Register ("readFixed64", "()J", "")]
		public long ReadFixed64 ()
		{
			if (id_readFixed64 == IntPtr.Zero)
				id_readFixed64 = JNIEnv.GetMethodID (class_ref, "readFixed64", "()J");
			return JNIEnv.CallLongMethod  (Handle, id_readFixed64);
		}

		static IntPtr id_readFloat;
		[Register ("readFloat", "()F", "")]
		public float ReadFloat ()
		{
			if (id_readFloat == IntPtr.Zero)
				id_readFloat = JNIEnv.GetMethodID (class_ref, "readFloat", "()F");
			return JNIEnv.CallFloatMethod  (Handle, id_readFloat);
		}

		static IntPtr id_readGroup_ILcom_google_protobuf_MessageLite_Builder_Lcom_google_protobuf_ExtensionRegistryLite_;
		[Register ("readGroup", "(ILcom/google/protobuf/MessageLite$Builder;Lcom/google/protobuf/ExtensionRegistryLite;)V", "")]
		public void ReadGroup (int p0, global::Com.Google.Protobuf.IMessageLiteBuilder p1, global::Com.Google.Protobuf.ExtensionRegistryLite p2)
		{
			if (id_readGroup_ILcom_google_protobuf_MessageLite_Builder_Lcom_google_protobuf_ExtensionRegistryLite_ == IntPtr.Zero)
				id_readGroup_ILcom_google_protobuf_MessageLite_Builder_Lcom_google_protobuf_ExtensionRegistryLite_ = JNIEnv.GetMethodID (class_ref, "readGroup", "(ILcom/google/protobuf/MessageLite$Builder;Lcom/google/protobuf/ExtensionRegistryLite;)V");
			JNIEnv.CallVoidMethod  (Handle, id_readGroup_ILcom_google_protobuf_MessageLite_Builder_Lcom_google_protobuf_ExtensionRegistryLite_, new JValue (p0), new JValue (p1), new JValue (p2));
		}

		static IntPtr id_readInt32;
		[Register ("readInt32", "()I", "")]
		public int ReadInt32 ()
		{
			if (id_readInt32 == IntPtr.Zero)
				id_readInt32 = JNIEnv.GetMethodID (class_ref, "readInt32", "()I");
			return JNIEnv.CallIntMethod  (Handle, id_readInt32);
		}

		static IntPtr id_readInt64;
		[Register ("readInt64", "()J", "")]
		public long ReadInt64 ()
		{
			if (id_readInt64 == IntPtr.Zero)
				id_readInt64 = JNIEnv.GetMethodID (class_ref, "readInt64", "()J");
			return JNIEnv.CallLongMethod  (Handle, id_readInt64);
		}

		static IntPtr id_readMessage_Lcom_google_protobuf_MessageLite_Builder_Lcom_google_protobuf_ExtensionRegistryLite_;
		[Register ("readMessage", "(Lcom/google/protobuf/MessageLite$Builder;Lcom/google/protobuf/ExtensionRegistryLite;)V", "")]
		public void ReadMessage (global::Com.Google.Protobuf.IMessageLiteBuilder p0, global::Com.Google.Protobuf.ExtensionRegistryLite p1)
		{
			if (id_readMessage_Lcom_google_protobuf_MessageLite_Builder_Lcom_google_protobuf_ExtensionRegistryLite_ == IntPtr.Zero)
				id_readMessage_Lcom_google_protobuf_MessageLite_Builder_Lcom_google_protobuf_ExtensionRegistryLite_ = JNIEnv.GetMethodID (class_ref, "readMessage", "(Lcom/google/protobuf/MessageLite$Builder;Lcom/google/protobuf/ExtensionRegistryLite;)V");
			JNIEnv.CallVoidMethod  (Handle, id_readMessage_Lcom_google_protobuf_MessageLite_Builder_Lcom_google_protobuf_ExtensionRegistryLite_, new JValue (p0), new JValue (p1));
		}

		static IntPtr id_readRawByte;
		[Register ("readRawByte", "()B", "")]
		public sbyte ReadRawByte ()
		{
			if (id_readRawByte == IntPtr.Zero)
				id_readRawByte = JNIEnv.GetMethodID (class_ref, "readRawByte", "()B");
			return JNIEnv.CallByteMethod  (Handle, id_readRawByte);
		}

		static IntPtr id_readRawBytes_I;
		[Register ("readRawBytes", "(I)[B", "")]
		public byte[] ReadRawBytes (int p0)
		{
			if (id_readRawBytes_I == IntPtr.Zero)
				id_readRawBytes_I = JNIEnv.GetMethodID (class_ref, "readRawBytes", "(I)[B");
			return (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_readRawBytes_I, new JValue (p0)), JniHandleOwnership.TransferLocalRef, typeof (byte));
		}

		static IntPtr id_readRawLittleEndian32;
		[Register ("readRawLittleEndian32", "()I", "")]
		public int ReadRawLittleEndian32 ()
		{
			if (id_readRawLittleEndian32 == IntPtr.Zero)
				id_readRawLittleEndian32 = JNIEnv.GetMethodID (class_ref, "readRawLittleEndian32", "()I");
			return JNIEnv.CallIntMethod  (Handle, id_readRawLittleEndian32);
		}

		static IntPtr id_readRawLittleEndian64;
		[Register ("readRawLittleEndian64", "()J", "")]
		public long ReadRawLittleEndian64 ()
		{
			if (id_readRawLittleEndian64 == IntPtr.Zero)
				id_readRawLittleEndian64 = JNIEnv.GetMethodID (class_ref, "readRawLittleEndian64", "()J");
			return JNIEnv.CallLongMethod  (Handle, id_readRawLittleEndian64);
		}

		static IntPtr id_readRawVarint32;
		[Register ("readRawVarint32", "()I", "")]
		public int ReadRawVarint32 ()
		{
			if (id_readRawVarint32 == IntPtr.Zero)
				id_readRawVarint32 = JNIEnv.GetMethodID (class_ref, "readRawVarint32", "()I");
			return JNIEnv.CallIntMethod  (Handle, id_readRawVarint32);
		}

		static IntPtr id_readRawVarint64;
		[Register ("readRawVarint64", "()J", "")]
		public long ReadRawVarint64 ()
		{
			if (id_readRawVarint64 == IntPtr.Zero)
				id_readRawVarint64 = JNIEnv.GetMethodID (class_ref, "readRawVarint64", "()J");
			return JNIEnv.CallLongMethod  (Handle, id_readRawVarint64);
		}

		static IntPtr id_readSFixed32;
		[Register ("readSFixed32", "()I", "")]
		public int ReadSFixed32 ()
		{
			if (id_readSFixed32 == IntPtr.Zero)
				id_readSFixed32 = JNIEnv.GetMethodID (class_ref, "readSFixed32", "()I");
			return JNIEnv.CallIntMethod  (Handle, id_readSFixed32);
		}

		static IntPtr id_readSFixed64;
		[Register ("readSFixed64", "()J", "")]
		public long ReadSFixed64 ()
		{
			if (id_readSFixed64 == IntPtr.Zero)
				id_readSFixed64 = JNIEnv.GetMethodID (class_ref, "readSFixed64", "()J");
			return JNIEnv.CallLongMethod  (Handle, id_readSFixed64);
		}

		static IntPtr id_readSInt32;
		[Register ("readSInt32", "()I", "")]
		public int ReadSInt32 ()
		{
			if (id_readSInt32 == IntPtr.Zero)
				id_readSInt32 = JNIEnv.GetMethodID (class_ref, "readSInt32", "()I");
			return JNIEnv.CallIntMethod  (Handle, id_readSInt32);
		}

		static IntPtr id_readSInt64;
		[Register ("readSInt64", "()J", "")]
		public long ReadSInt64 ()
		{
			if (id_readSInt64 == IntPtr.Zero)
				id_readSInt64 = JNIEnv.GetMethodID (class_ref, "readSInt64", "()J");
			return JNIEnv.CallLongMethod  (Handle, id_readSInt64);
		}

		static IntPtr id_readString;
		[Register ("readString", "()Ljava/lang/String;", "")]
		public string ReadString ()
		{
			if (id_readString == IntPtr.Zero)
				id_readString = JNIEnv.GetMethodID (class_ref, "readString", "()Ljava/lang/String;");
			return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_readString), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_readTag;
		[Register ("readTag", "()I", "")]
		public int ReadTag ()
		{
			if (id_readTag == IntPtr.Zero)
				id_readTag = JNIEnv.GetMethodID (class_ref, "readTag", "()I");
			return JNIEnv.CallIntMethod  (Handle, id_readTag);
		}

		static IntPtr id_readUInt32;
		[Register ("readUInt32", "()I", "")]
		public int ReadUInt32 ()
		{
			if (id_readUInt32 == IntPtr.Zero)
				id_readUInt32 = JNIEnv.GetMethodID (class_ref, "readUInt32", "()I");
			return JNIEnv.CallIntMethod  (Handle, id_readUInt32);
		}

		static IntPtr id_readUInt64;
		[Register ("readUInt64", "()J", "")]
		public long ReadUInt64 ()
		{
			if (id_readUInt64 == IntPtr.Zero)
				id_readUInt64 = JNIEnv.GetMethodID (class_ref, "readUInt64", "()J");
			return JNIEnv.CallLongMethod  (Handle, id_readUInt64);
		}

		static IntPtr id_readUnknownGroup_ILcom_google_protobuf_MessageLite_Builder_;
		[Register ("readUnknownGroup", "(ILcom/google/protobuf/MessageLite$Builder;)V", "")]
		public void ReadUnknownGroup (int p0, global::Com.Google.Protobuf.IMessageLiteBuilder p1)
		{
			if (id_readUnknownGroup_ILcom_google_protobuf_MessageLite_Builder_ == IntPtr.Zero)
				id_readUnknownGroup_ILcom_google_protobuf_MessageLite_Builder_ = JNIEnv.GetMethodID (class_ref, "readUnknownGroup", "(ILcom/google/protobuf/MessageLite$Builder;)V");
			JNIEnv.CallVoidMethod  (Handle, id_readUnknownGroup_ILcom_google_protobuf_MessageLite_Builder_, new JValue (p0), new JValue (p1));
		}

		static IntPtr id_resetSizeCounter;
		[Register ("resetSizeCounter", "()V", "")]
		public void ResetSizeCounter ()
		{
			if (id_resetSizeCounter == IntPtr.Zero)
				id_resetSizeCounter = JNIEnv.GetMethodID (class_ref, "resetSizeCounter", "()V");
			JNIEnv.CallVoidMethod  (Handle, id_resetSizeCounter);
		}

		static IntPtr id_setRecursionLimit_I;
		[Register ("setRecursionLimit", "(I)I", "")]
		public int SetRecursionLimit (int p0)
		{
			if (id_setRecursionLimit_I == IntPtr.Zero)
				id_setRecursionLimit_I = JNIEnv.GetMethodID (class_ref, "setRecursionLimit", "(I)I");
			return JNIEnv.CallIntMethod  (Handle, id_setRecursionLimit_I, new JValue (p0));
		}

		static IntPtr id_setSizeLimit_I;
		[Register ("setSizeLimit", "(I)I", "")]
		public int SetSizeLimit (int p0)
		{
			if (id_setSizeLimit_I == IntPtr.Zero)
				id_setSizeLimit_I = JNIEnv.GetMethodID (class_ref, "setSizeLimit", "(I)I");
			return JNIEnv.CallIntMethod  (Handle, id_setSizeLimit_I, new JValue (p0));
		}

		static IntPtr id_skipField_I;
		[Register ("skipField", "(I)Z", "")]
		public bool SkipField (int p0)
		{
			if (id_skipField_I == IntPtr.Zero)
				id_skipField_I = JNIEnv.GetMethodID (class_ref, "skipField", "(I)Z");
			return JNIEnv.CallBooleanMethod  (Handle, id_skipField_I, new JValue (p0));
		}

		static IntPtr id_skipMessage;
		[Register ("skipMessage", "()V", "")]
		public void SkipMessage ()
		{
			if (id_skipMessage == IntPtr.Zero)
				id_skipMessage = JNIEnv.GetMethodID (class_ref, "skipMessage", "()V");
			JNIEnv.CallVoidMethod  (Handle, id_skipMessage);
		}

		static IntPtr id_skipRawBytes_I;
		[Register ("skipRawBytes", "(I)V", "")]
		public void SkipRawBytes (int p0)
		{
			if (id_skipRawBytes_I == IntPtr.Zero)
				id_skipRawBytes_I = JNIEnv.GetMethodID (class_ref, "skipRawBytes", "(I)V");
			JNIEnv.CallVoidMethod  (Handle, id_skipRawBytes_I, new JValue (p0));
		}

	}
}
