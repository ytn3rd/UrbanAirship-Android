using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Urbanairship.Push.Proto {

	[global::Android.Runtime.Register ("com/urbanairship/push/proto/Rpc", DoNotGenerateAcw=true)]
	public sealed partial class Rpc : global::Java.Lang.Object {

		[global::Android.Runtime.Register ("com/urbanairship/push/proto/Rpc$Request", DoNotGenerateAcw=true)]
		public sealed partial class Request : global::Com.Google.Protobuf.GeneratedMessageLite {


			[Register ("BODY_FIELD_NUMBER")]
			public const int BodyFieldNumber = (int) 2;

			[Register ("METHOD_ID_FIELD_NUMBER")]
			public const int MethodIdFieldNumber = (int) 1;

			[Register ("REQUEST_ID_FIELD_NUMBER")]
			public const int RequestIdFieldNumber = (int) 3;
			[global::Android.Runtime.Register ("com/urbanairship/push/proto/Rpc$Request$Builder", DoNotGenerateAcw=true)]
			public new sealed partial class Builder : global::Com.Google.Protobuf.GeneratedMessageLite.Builder {

				internal static IntPtr java_class_handle;
				internal static IntPtr class_ref {
					get {
						return JNIEnv.FindClass ("com/urbanairship/push/proto/Rpc$Request$Builder", ref java_class_handle);
					}
				}

				protected override IntPtr ThresholdClass {
					get { return class_ref; }
				}

				protected override global::System.Type ThresholdType {
					get { return typeof (Builder); }
				}

				internal Builder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

				static IntPtr id_getBody;
				public global::Com.Google.Protobuf.ByteString Body {
					[Register ("getBody", "()Lcom/google/protobuf/ByteString;", "GetGetBodyHandler")]
					get {
						if (id_getBody == IntPtr.Zero)
							id_getBody = JNIEnv.GetMethodID (class_ref, "getBody", "()Lcom/google/protobuf/ByteString;");
						return Java.Lang.Object.GetObject<global::Com.Google.Protobuf.ByteString> (JNIEnv.CallObjectMethod  (Handle, id_getBody), JniHandleOwnership.TransferLocalRef);
					}
				}

				static IntPtr id_getDefaultInstanceForType;
				public override global::Com.Urbanairship.Push.Proto.Rpc.Request DefaultInstanceForType {
					[Register ("getDefaultInstanceForType", "()Lcom/urbanairship/push/proto/Rpc$Request;", "GetGetDefaultInstanceForTypeHandler")]
					get {
						if (id_getDefaultInstanceForType == IntPtr.Zero)
							id_getDefaultInstanceForType = JNIEnv.GetMethodID (class_ref, "getDefaultInstanceForType", "()Lcom/urbanairship/push/proto/Rpc$Request;");
						return Java.Lang.Object.GetObject<global::Com.Urbanairship.Push.Proto.Rpc.Request> (JNIEnv.CallObjectMethod  (Handle, id_getDefaultInstanceForType), JniHandleOwnership.TransferLocalRef);
					}
				}

				static IntPtr id_hasBody;
				public bool HasBody {
					[Register ("hasBody", "()Z", "GetHasBodyHandler")]
					get {
						if (id_hasBody == IntPtr.Zero)
							id_hasBody = JNIEnv.GetMethodID (class_ref, "hasBody", "()Z");
						return JNIEnv.CallBooleanMethod  (Handle, id_hasBody);
					}
				}

				static IntPtr id_hasMethodId;
				public bool HasMethodId {
					[Register ("hasMethodId", "()Z", "GetHasMethodIdHandler")]
					get {
						if (id_hasMethodId == IntPtr.Zero)
							id_hasMethodId = JNIEnv.GetMethodID (class_ref, "hasMethodId", "()Z");
						return JNIEnv.CallBooleanMethod  (Handle, id_hasMethodId);
					}
				}

				static IntPtr id_hasRequestId;
				public bool HasRequestId {
					[Register ("hasRequestId", "()Z", "GetHasRequestIdHandler")]
					get {
						if (id_hasRequestId == IntPtr.Zero)
							id_hasRequestId = JNIEnv.GetMethodID (class_ref, "hasRequestId", "()Z");
						return JNIEnv.CallBooleanMethod  (Handle, id_hasRequestId);
					}
				}

				static IntPtr id_isInitialized;
				public override bool IsInitialized {
					[Register ("isInitialized", "()Z", "GetIsInitializedHandler")]
					get {
						if (id_isInitialized == IntPtr.Zero)
							id_isInitialized = JNIEnv.GetMethodID (class_ref, "isInitialized", "()Z");
						return JNIEnv.CallBooleanMethod  (Handle, id_isInitialized);
					}
				}

				static IntPtr id_getMethodId;
				public global::Com.Urbanairship.Push.Proto.Messages.AirshipMethod MethodId {
					[Register ("getMethodId", "()Lcom/urbanairship/push/proto/Messages$AirshipMethod;", "GetGetMethodIdHandler")]
					get {
						if (id_getMethodId == IntPtr.Zero)
							id_getMethodId = JNIEnv.GetMethodID (class_ref, "getMethodId", "()Lcom/urbanairship/push/proto/Messages$AirshipMethod;");
						return Java.Lang.Object.GetObject<global::Com.Urbanairship.Push.Proto.Messages.AirshipMethod> (JNIEnv.CallObjectMethod  (Handle, id_getMethodId), JniHandleOwnership.TransferLocalRef);
					}
				}

				static IntPtr id_getRequestId;
				public string RequestId {
					[Register ("getRequestId", "()Ljava/lang/String;", "GetGetRequestIdHandler")]
					get {
						if (id_getRequestId == IntPtr.Zero)
							id_getRequestId = JNIEnv.GetMethodID (class_ref, "getRequestId", "()Ljava/lang/String;");
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getRequestId), JniHandleOwnership.TransferLocalRef);
					}
				}

				static IntPtr id_build;
				[Register ("build", "()Lcom/urbanairship/push/proto/Rpc$Request;", "")]
				public global::Com.Urbanairship.Push.Proto.Rpc.Request Build ()
				{
					if (id_build == IntPtr.Zero)
						id_build = JNIEnv.GetMethodID (class_ref, "build", "()Lcom/urbanairship/push/proto/Rpc$Request;");
					return Java.Lang.Object.GetObject<global::Com.Urbanairship.Push.Proto.Rpc.Request> (JNIEnv.CallObjectMethod  (Handle, id_build), JniHandleOwnership.TransferLocalRef);
				}

				static IntPtr id_buildPartial;
				[Register ("buildPartial", "()Lcom/urbanairship/push/proto/Rpc$Request;", "")]
				public global::Com.Urbanairship.Push.Proto.Rpc.Request BuildPartial ()
				{
					if (id_buildPartial == IntPtr.Zero)
						id_buildPartial = JNIEnv.GetMethodID (class_ref, "buildPartial", "()Lcom/urbanairship/push/proto/Rpc$Request;");
					return Java.Lang.Object.GetObject<global::Com.Urbanairship.Push.Proto.Rpc.Request> (JNIEnv.CallObjectMethod  (Handle, id_buildPartial), JniHandleOwnership.TransferLocalRef);
				}

				static IntPtr id_clear;
				[Register ("clear", "()Lcom/urbanairship/push/proto/Rpc$Request$Builder;", "")]
				public global::Com.Urbanairship.Push.Proto.Rpc.Request.Builder Clear ()
				{
					if (id_clear == IntPtr.Zero)
						id_clear = JNIEnv.GetMethodID (class_ref, "clear", "()Lcom/urbanairship/push/proto/Rpc$Request$Builder;");
					return Java.Lang.Object.GetObject<global::Com.Urbanairship.Push.Proto.Rpc.Request.Builder> (JNIEnv.CallObjectMethod  (Handle, id_clear), JniHandleOwnership.TransferLocalRef);
				}

				static IntPtr id_clearBody;
				[Register ("clearBody", "()Lcom/urbanairship/push/proto/Rpc$Request$Builder;", "")]
				public global::Com.Urbanairship.Push.Proto.Rpc.Request.Builder ClearBody ()
				{
					if (id_clearBody == IntPtr.Zero)
						id_clearBody = JNIEnv.GetMethodID (class_ref, "clearBody", "()Lcom/urbanairship/push/proto/Rpc$Request$Builder;");
					return Java.Lang.Object.GetObject<global::Com.Urbanairship.Push.Proto.Rpc.Request.Builder> (JNIEnv.CallObjectMethod  (Handle, id_clearBody), JniHandleOwnership.TransferLocalRef);
				}

				static IntPtr id_clearMethodId;
				[Register ("clearMethodId", "()Lcom/urbanairship/push/proto/Rpc$Request$Builder;", "")]
				public global::Com.Urbanairship.Push.Proto.Rpc.Request.Builder ClearMethodId ()
				{
					if (id_clearMethodId == IntPtr.Zero)
						id_clearMethodId = JNIEnv.GetMethodID (class_ref, "clearMethodId", "()Lcom/urbanairship/push/proto/Rpc$Request$Builder;");
					return Java.Lang.Object.GetObject<global::Com.Urbanairship.Push.Proto.Rpc.Request.Builder> (JNIEnv.CallObjectMethod  (Handle, id_clearMethodId), JniHandleOwnership.TransferLocalRef);
				}

				static IntPtr id_clearRequestId;
				[Register ("clearRequestId", "()Lcom/urbanairship/push/proto/Rpc$Request$Builder;", "")]
				public global::Com.Urbanairship.Push.Proto.Rpc.Request.Builder ClearRequestId ()
				{
					if (id_clearRequestId == IntPtr.Zero)
						id_clearRequestId = JNIEnv.GetMethodID (class_ref, "clearRequestId", "()Lcom/urbanairship/push/proto/Rpc$Request$Builder;");
					return Java.Lang.Object.GetObject<global::Com.Urbanairship.Push.Proto.Rpc.Request.Builder> (JNIEnv.CallObjectMethod  (Handle, id_clearRequestId), JniHandleOwnership.TransferLocalRef);
				}

				static IntPtr id_internalGetResult;
				[Register ("internalGetResult", "()Lcom/urbanairship/push/proto/Rpc$Request;", "")]
				protected override global::Com.Urbanairship.Push.Proto.Rpc.Request InternalGetResult ()
				{
					if (id_internalGetResult == IntPtr.Zero)
						id_internalGetResult = JNIEnv.GetMethodID (class_ref, "internalGetResult", "()Lcom/urbanairship/push/proto/Rpc$Request;");
					return Java.Lang.Object.GetObject<global::Com.Urbanairship.Push.Proto.Rpc.Request> (JNIEnv.CallObjectMethod  (Handle, id_internalGetResult), JniHandleOwnership.TransferLocalRef);
				}

				static IntPtr id_mergeFrom_Lcom_google_protobuf_CodedInputStream_Lcom_google_protobuf_ExtensionRegistryLite_;
				[Register ("mergeFrom", "(Lcom/google/protobuf/CodedInputStream;Lcom/google/protobuf/ExtensionRegistryLite;)Lcom/urbanairship/push/proto/Rpc$Request$Builder;", "")]
				public override global::Com.Urbanairship.Push.Proto.Rpc.Request.Builder MergeFrom (global::Com.Google.Protobuf.CodedInputStream p0, global::Com.Google.Protobuf.ExtensionRegistryLite p1)
				{
					if (id_mergeFrom_Lcom_google_protobuf_CodedInputStream_Lcom_google_protobuf_ExtensionRegistryLite_ == IntPtr.Zero)
						id_mergeFrom_Lcom_google_protobuf_CodedInputStream_Lcom_google_protobuf_ExtensionRegistryLite_ = JNIEnv.GetMethodID (class_ref, "mergeFrom", "(Lcom/google/protobuf/CodedInputStream;Lcom/google/protobuf/ExtensionRegistryLite;)Lcom/urbanairship/push/proto/Rpc$Request$Builder;");
					global::Com.Urbanairship.Push.Proto.Rpc.Request.Builder __ret = Java.Lang.Object.GetObject<global::Com.Urbanairship.Push.Proto.Rpc.Request.Builder> (JNIEnv.CallObjectMethod  (Handle, id_mergeFrom_Lcom_google_protobuf_CodedInputStream_Lcom_google_protobuf_ExtensionRegistryLite_, new JValue (p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
					return __ret;
				}

				static IntPtr id_mergeFrom_Lcom_google_protobuf_GeneratedMessageLite_;
				[Register ("mergeFrom", "(Lcom/google/protobuf/GeneratedMessageLite;)Lcom/google/protobuf/GeneratedMessageLite$Builder;", "")]
				public global::Com.Google.Protobuf.GeneratedMessageLite.Builder MergeFrom (global::Com.Google.Protobuf.GeneratedMessageLite p0)
				{
					if (id_mergeFrom_Lcom_google_protobuf_GeneratedMessageLite_ == IntPtr.Zero)
						id_mergeFrom_Lcom_google_protobuf_GeneratedMessageLite_ = JNIEnv.GetMethodID (class_ref, "mergeFrom", "(Lcom/google/protobuf/GeneratedMessageLite;)Lcom/google/protobuf/GeneratedMessageLite$Builder;");
					global::Com.Google.Protobuf.GeneratedMessageLite.Builder __ret = Java.Lang.Object.GetObject<global::Com.Google.Protobuf.GeneratedMessageLite.Builder> (JNIEnv.CallObjectMethod  (Handle, id_mergeFrom_Lcom_google_protobuf_GeneratedMessageLite_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
					return __ret;
				}

				static IntPtr id_mergeFrom_Lcom_urbanairship_push_proto_Rpc_Request_;
				[Register ("mergeFrom", "(Lcom/urbanairship/push/proto/Rpc$Request;)Lcom/urbanairship/push/proto/Rpc$Request$Builder;", "")]
				public global::Com.Urbanairship.Push.Proto.Rpc.Request.Builder MergeFrom (global::Com.Urbanairship.Push.Proto.Rpc.Request p0)
				{
					if (id_mergeFrom_Lcom_urbanairship_push_proto_Rpc_Request_ == IntPtr.Zero)
						id_mergeFrom_Lcom_urbanairship_push_proto_Rpc_Request_ = JNIEnv.GetMethodID (class_ref, "mergeFrom", "(Lcom/urbanairship/push/proto/Rpc$Request;)Lcom/urbanairship/push/proto/Rpc$Request$Builder;");
					global::Com.Urbanairship.Push.Proto.Rpc.Request.Builder __ret = Java.Lang.Object.GetObject<global::Com.Urbanairship.Push.Proto.Rpc.Request.Builder> (JNIEnv.CallObjectMethod  (Handle, id_mergeFrom_Lcom_urbanairship_push_proto_Rpc_Request_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
					return __ret;
				}

				static IntPtr id_setBody_Lcom_google_protobuf_ByteString_;
				[Register ("setBody", "(Lcom/google/protobuf/ByteString;)Lcom/urbanairship/push/proto/Rpc$Request$Builder;", "")]
				public global::Com.Urbanairship.Push.Proto.Rpc.Request.Builder SetBody (global::Com.Google.Protobuf.ByteString p0)
				{
					if (id_setBody_Lcom_google_protobuf_ByteString_ == IntPtr.Zero)
						id_setBody_Lcom_google_protobuf_ByteString_ = JNIEnv.GetMethodID (class_ref, "setBody", "(Lcom/google/protobuf/ByteString;)Lcom/urbanairship/push/proto/Rpc$Request$Builder;");
					global::Com.Urbanairship.Push.Proto.Rpc.Request.Builder __ret = Java.Lang.Object.GetObject<global::Com.Urbanairship.Push.Proto.Rpc.Request.Builder> (JNIEnv.CallObjectMethod  (Handle, id_setBody_Lcom_google_protobuf_ByteString_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
					return __ret;
				}

				static IntPtr id_setMethodId_Lcom_urbanairship_push_proto_Messages_AirshipMethod_;
				[Register ("setMethodId", "(Lcom/urbanairship/push/proto/Messages$AirshipMethod;)Lcom/urbanairship/push/proto/Rpc$Request$Builder;", "")]
				public global::Com.Urbanairship.Push.Proto.Rpc.Request.Builder SetMethodId (global::Com.Urbanairship.Push.Proto.Messages.AirshipMethod p0)
				{
					if (id_setMethodId_Lcom_urbanairship_push_proto_Messages_AirshipMethod_ == IntPtr.Zero)
						id_setMethodId_Lcom_urbanairship_push_proto_Messages_AirshipMethod_ = JNIEnv.GetMethodID (class_ref, "setMethodId", "(Lcom/urbanairship/push/proto/Messages$AirshipMethod;)Lcom/urbanairship/push/proto/Rpc$Request$Builder;");
					global::Com.Urbanairship.Push.Proto.Rpc.Request.Builder __ret = Java.Lang.Object.GetObject<global::Com.Urbanairship.Push.Proto.Rpc.Request.Builder> (JNIEnv.CallObjectMethod  (Handle, id_setMethodId_Lcom_urbanairship_push_proto_Messages_AirshipMethod_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
					return __ret;
				}

				static IntPtr id_setRequestId_Ljava_lang_String_;
				[Register ("setRequestId", "(Ljava/lang/String;)Lcom/urbanairship/push/proto/Rpc$Request$Builder;", "")]
				public global::Com.Urbanairship.Push.Proto.Rpc.Request.Builder SetRequestId (string p0)
				{
					if (id_setRequestId_Ljava_lang_String_ == IntPtr.Zero)
						id_setRequestId_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setRequestId", "(Ljava/lang/String;)Lcom/urbanairship/push/proto/Rpc$Request$Builder;");
					IntPtr native_p0 = JNIEnv.NewString (p0);
					global::Com.Urbanairship.Push.Proto.Rpc.Request.Builder __ret = Java.Lang.Object.GetObject<global::Com.Urbanairship.Push.Proto.Rpc.Request.Builder> (JNIEnv.CallObjectMethod  (Handle, id_setRequestId_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
					JNIEnv.DeleteLocalRef (native_p0);
					return __ret;
				}

			}

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/urbanairship/push/proto/Rpc$Request", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Request); }
			}

			internal Request (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_getBody;
			public global::Com.Google.Protobuf.ByteString Body {
				[Register ("getBody", "()Lcom/google/protobuf/ByteString;", "GetGetBodyHandler")]
				get {
					if (id_getBody == IntPtr.Zero)
						id_getBody = JNIEnv.GetMethodID (class_ref, "getBody", "()Lcom/google/protobuf/ByteString;");
					return Java.Lang.Object.GetObject<global::Com.Google.Protobuf.ByteString> (JNIEnv.CallObjectMethod  (Handle, id_getBody), JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr id_getDefaultInstance;
			public static global::Com.Urbanairship.Push.Proto.Rpc.Request DefaultInstance {
				[Register ("getDefaultInstance", "()Lcom/urbanairship/push/proto/Rpc$Request;", "GetGetDefaultInstanceHandler")]
				get {
					if (id_getDefaultInstance == IntPtr.Zero)
						id_getDefaultInstance = JNIEnv.GetStaticMethodID (class_ref, "getDefaultInstance", "()Lcom/urbanairship/push/proto/Rpc$Request;");
					return Java.Lang.Object.GetObject<global::Com.Urbanairship.Push.Proto.Rpc.Request> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getDefaultInstance), JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr id_getDefaultInstanceForType;
			public override global::Com.Urbanairship.Push.Proto.Rpc.Request DefaultInstanceForType {
				[Register ("getDefaultInstanceForType", "()Lcom/urbanairship/push/proto/Rpc$Request;", "GetGetDefaultInstanceForTypeHandler")]
				get {
					if (id_getDefaultInstanceForType == IntPtr.Zero)
						id_getDefaultInstanceForType = JNIEnv.GetMethodID (class_ref, "getDefaultInstanceForType", "()Lcom/urbanairship/push/proto/Rpc$Request;");
					return Java.Lang.Object.GetObject<global::Com.Urbanairship.Push.Proto.Rpc.Request> (JNIEnv.CallObjectMethod  (Handle, id_getDefaultInstanceForType), JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr id_hasBody;
			public bool HasBody {
				[Register ("hasBody", "()Z", "GetHasBodyHandler")]
				get {
					if (id_hasBody == IntPtr.Zero)
						id_hasBody = JNIEnv.GetMethodID (class_ref, "hasBody", "()Z");
					return JNIEnv.CallBooleanMethod  (Handle, id_hasBody);
				}
			}

			static IntPtr id_hasMethodId;
			public bool HasMethodId {
				[Register ("hasMethodId", "()Z", "GetHasMethodIdHandler")]
				get {
					if (id_hasMethodId == IntPtr.Zero)
						id_hasMethodId = JNIEnv.GetMethodID (class_ref, "hasMethodId", "()Z");
					return JNIEnv.CallBooleanMethod  (Handle, id_hasMethodId);
				}
			}

			static IntPtr id_hasRequestId;
			public bool HasRequestId {
				[Register ("hasRequestId", "()Z", "GetHasRequestIdHandler")]
				get {
					if (id_hasRequestId == IntPtr.Zero)
						id_hasRequestId = JNIEnv.GetMethodID (class_ref, "hasRequestId", "()Z");
					return JNIEnv.CallBooleanMethod  (Handle, id_hasRequestId);
				}
			}

			static IntPtr id_isInitialized;
			public override bool IsInitialized {
				[Register ("isInitialized", "()Z", "GetIsInitializedHandler")]
				get {
					if (id_isInitialized == IntPtr.Zero)
						id_isInitialized = JNIEnv.GetMethodID (class_ref, "isInitialized", "()Z");
					return JNIEnv.CallBooleanMethod  (Handle, id_isInitialized);
				}
			}

			static IntPtr id_getMethodId;
			public global::Com.Urbanairship.Push.Proto.Messages.AirshipMethod MethodId {
				[Register ("getMethodId", "()Lcom/urbanairship/push/proto/Messages$AirshipMethod;", "GetGetMethodIdHandler")]
				get {
					if (id_getMethodId == IntPtr.Zero)
						id_getMethodId = JNIEnv.GetMethodID (class_ref, "getMethodId", "()Lcom/urbanairship/push/proto/Messages$AirshipMethod;");
					return Java.Lang.Object.GetObject<global::Com.Urbanairship.Push.Proto.Messages.AirshipMethod> (JNIEnv.CallObjectMethod  (Handle, id_getMethodId), JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr id_getRequestId;
			public string RequestId {
				[Register ("getRequestId", "()Ljava/lang/String;", "GetGetRequestIdHandler")]
				get {
					if (id_getRequestId == IntPtr.Zero)
						id_getRequestId = JNIEnv.GetMethodID (class_ref, "getRequestId", "()Ljava/lang/String;");
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getRequestId), JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr id_getSerializedSize;
			public override int SerializedSize {
				[Register ("getSerializedSize", "()I", "GetGetSerializedSizeHandler")]
				get {
					if (id_getSerializedSize == IntPtr.Zero)
						id_getSerializedSize = JNIEnv.GetMethodID (class_ref, "getSerializedSize", "()I");
					return JNIEnv.CallIntMethod  (Handle, id_getSerializedSize);
				}
			}

			static IntPtr id_newBuilder;
			[Register ("newBuilder", "()Lcom/urbanairship/push/proto/Rpc$Request$Builder;", "")]
			public static global::Com.Urbanairship.Push.Proto.Rpc.Request.Builder NewBuilder ()
			{
				if (id_newBuilder == IntPtr.Zero)
					id_newBuilder = JNIEnv.GetStaticMethodID (class_ref, "newBuilder", "()Lcom/urbanairship/push/proto/Rpc$Request$Builder;");
				return Java.Lang.Object.GetObject<global::Com.Urbanairship.Push.Proto.Rpc.Request.Builder> (JNIEnv.CallStaticObjectMethod  (class_ref, id_newBuilder), JniHandleOwnership.TransferLocalRef);
			}

			static IntPtr id_newBuilder_Lcom_urbanairship_push_proto_Rpc_Request_;
			[Register ("newBuilder", "(Lcom/urbanairship/push/proto/Rpc$Request;)Lcom/urbanairship/push/proto/Rpc$Request$Builder;", "")]
			public static global::Com.Urbanairship.Push.Proto.Rpc.Request.Builder NewBuilder (global::Com.Urbanairship.Push.Proto.Rpc.Request p0)
			{
				if (id_newBuilder_Lcom_urbanairship_push_proto_Rpc_Request_ == IntPtr.Zero)
					id_newBuilder_Lcom_urbanairship_push_proto_Rpc_Request_ = JNIEnv.GetStaticMethodID (class_ref, "newBuilder", "(Lcom/urbanairship/push/proto/Rpc$Request;)Lcom/urbanairship/push/proto/Rpc$Request$Builder;");
				global::Com.Urbanairship.Push.Proto.Rpc.Request.Builder __ret = Java.Lang.Object.GetObject<global::Com.Urbanairship.Push.Proto.Rpc.Request.Builder> (JNIEnv.CallStaticObjectMethod  (class_ref, id_newBuilder_Lcom_urbanairship_push_proto_Rpc_Request_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
				return __ret;
			}

			static IntPtr id_newBuilderForType;
			[Register ("newBuilderForType", "()Lcom/urbanairship/push/proto/Rpc$Request$Builder;", "")]
			public global::Com.Urbanairship.Push.Proto.Rpc.Request.Builder NewBuilderForType ()
			{
				if (id_newBuilderForType == IntPtr.Zero)
					id_newBuilderForType = JNIEnv.GetMethodID (class_ref, "newBuilderForType", "()Lcom/urbanairship/push/proto/Rpc$Request$Builder;");
				return Java.Lang.Object.GetObject<global::Com.Urbanairship.Push.Proto.Rpc.Request.Builder> (JNIEnv.CallObjectMethod  (Handle, id_newBuilderForType), JniHandleOwnership.TransferLocalRef);
			}

			static IntPtr id_parseDelimitedFrom_Ljava_io_InputStream_;
			[Register ("parseDelimitedFrom", "(Ljava/io/InputStream;)Lcom/urbanairship/push/proto/Rpc$Request;", "")]
			public static global::Com.Urbanairship.Push.Proto.Rpc.Request ParseDelimitedFrom (global::System.IO.Stream p0)
			{
				if (id_parseDelimitedFrom_Ljava_io_InputStream_ == IntPtr.Zero)
					id_parseDelimitedFrom_Ljava_io_InputStream_ = JNIEnv.GetStaticMethodID (class_ref, "parseDelimitedFrom", "(Ljava/io/InputStream;)Lcom/urbanairship/push/proto/Rpc$Request;");
				IntPtr native_p0 = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (p0);
				global::Com.Urbanairship.Push.Proto.Rpc.Request __ret = Java.Lang.Object.GetObject<global::Com.Urbanairship.Push.Proto.Rpc.Request> (JNIEnv.CallStaticObjectMethod  (class_ref, id_parseDelimitedFrom_Ljava_io_InputStream_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
				JNIEnv.DeleteLocalRef (native_p0);
				return __ret;
			}

			static IntPtr id_parseDelimitedFrom_Ljava_io_InputStream_Lcom_google_protobuf_ExtensionRegistryLite_;
			[Register ("parseDelimitedFrom", "(Ljava/io/InputStream;Lcom/google/protobuf/ExtensionRegistryLite;)Lcom/urbanairship/push/proto/Rpc$Request;", "")]
			public static global::Com.Urbanairship.Push.Proto.Rpc.Request ParseDelimitedFrom (global::System.IO.Stream p0, global::Com.Google.Protobuf.ExtensionRegistryLite p1)
			{
				if (id_parseDelimitedFrom_Ljava_io_InputStream_Lcom_google_protobuf_ExtensionRegistryLite_ == IntPtr.Zero)
					id_parseDelimitedFrom_Ljava_io_InputStream_Lcom_google_protobuf_ExtensionRegistryLite_ = JNIEnv.GetStaticMethodID (class_ref, "parseDelimitedFrom", "(Ljava/io/InputStream;Lcom/google/protobuf/ExtensionRegistryLite;)Lcom/urbanairship/push/proto/Rpc$Request;");
				IntPtr native_p0 = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (p0);
				global::Com.Urbanairship.Push.Proto.Rpc.Request __ret = Java.Lang.Object.GetObject<global::Com.Urbanairship.Push.Proto.Rpc.Request> (JNIEnv.CallStaticObjectMethod  (class_ref, id_parseDelimitedFrom_Ljava_io_InputStream_Lcom_google_protobuf_ExtensionRegistryLite_, new JValue (native_p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
				JNIEnv.DeleteLocalRef (native_p0);
				return __ret;
			}

			static IntPtr id_parseFrom_arrayB;
			[Register ("parseFrom", "([B)Lcom/urbanairship/push/proto/Rpc$Request;", "")]
			public static global::Com.Urbanairship.Push.Proto.Rpc.Request ParseFrom (byte[] p0)
			{
				if (id_parseFrom_arrayB == IntPtr.Zero)
					id_parseFrom_arrayB = JNIEnv.GetStaticMethodID (class_ref, "parseFrom", "([B)Lcom/urbanairship/push/proto/Rpc$Request;");
				IntPtr native_p0 = JNIEnv.NewArray (p0);
				global::Com.Urbanairship.Push.Proto.Rpc.Request __ret = Java.Lang.Object.GetObject<global::Com.Urbanairship.Push.Proto.Rpc.Request> (JNIEnv.CallStaticObjectMethod  (class_ref, id_parseFrom_arrayB, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				return __ret;
			}

			static IntPtr id_parseFrom_arrayBLcom_google_protobuf_ExtensionRegistryLite_;
			[Register ("parseFrom", "([BLcom/google/protobuf/ExtensionRegistryLite;)Lcom/urbanairship/push/proto/Rpc$Request;", "")]
			public static global::Com.Urbanairship.Push.Proto.Rpc.Request ParseFrom (byte[] p0, global::Com.Google.Protobuf.ExtensionRegistryLite p1)
			{
				if (id_parseFrom_arrayBLcom_google_protobuf_ExtensionRegistryLite_ == IntPtr.Zero)
					id_parseFrom_arrayBLcom_google_protobuf_ExtensionRegistryLite_ = JNIEnv.GetStaticMethodID (class_ref, "parseFrom", "([BLcom/google/protobuf/ExtensionRegistryLite;)Lcom/urbanairship/push/proto/Rpc$Request;");
				IntPtr native_p0 = JNIEnv.NewArray (p0);
				global::Com.Urbanairship.Push.Proto.Rpc.Request __ret = Java.Lang.Object.GetObject<global::Com.Urbanairship.Push.Proto.Rpc.Request> (JNIEnv.CallStaticObjectMethod  (class_ref, id_parseFrom_arrayBLcom_google_protobuf_ExtensionRegistryLite_, new JValue (native_p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				return __ret;
			}

			static IntPtr id_parseFrom_Lcom_google_protobuf_ByteString_;
			[Register ("parseFrom", "(Lcom/google/protobuf/ByteString;)Lcom/urbanairship/push/proto/Rpc$Request;", "")]
			public static global::Com.Urbanairship.Push.Proto.Rpc.Request ParseFrom (global::Com.Google.Protobuf.ByteString p0)
			{
				if (id_parseFrom_Lcom_google_protobuf_ByteString_ == IntPtr.Zero)
					id_parseFrom_Lcom_google_protobuf_ByteString_ = JNIEnv.GetStaticMethodID (class_ref, "parseFrom", "(Lcom/google/protobuf/ByteString;)Lcom/urbanairship/push/proto/Rpc$Request;");
				global::Com.Urbanairship.Push.Proto.Rpc.Request __ret = Java.Lang.Object.GetObject<global::Com.Urbanairship.Push.Proto.Rpc.Request> (JNIEnv.CallStaticObjectMethod  (class_ref, id_parseFrom_Lcom_google_protobuf_ByteString_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
				return __ret;
			}

			static IntPtr id_parseFrom_Lcom_google_protobuf_ByteString_Lcom_google_protobuf_ExtensionRegistryLite_;
			[Register ("parseFrom", "(Lcom/google/protobuf/ByteString;Lcom/google/protobuf/ExtensionRegistryLite;)Lcom/urbanairship/push/proto/Rpc$Request;", "")]
			public static global::Com.Urbanairship.Push.Proto.Rpc.Request ParseFrom (global::Com.Google.Protobuf.ByteString p0, global::Com.Google.Protobuf.ExtensionRegistryLite p1)
			{
				if (id_parseFrom_Lcom_google_protobuf_ByteString_Lcom_google_protobuf_ExtensionRegistryLite_ == IntPtr.Zero)
					id_parseFrom_Lcom_google_protobuf_ByteString_Lcom_google_protobuf_ExtensionRegistryLite_ = JNIEnv.GetStaticMethodID (class_ref, "parseFrom", "(Lcom/google/protobuf/ByteString;Lcom/google/protobuf/ExtensionRegistryLite;)Lcom/urbanairship/push/proto/Rpc$Request;");
				global::Com.Urbanairship.Push.Proto.Rpc.Request __ret = Java.Lang.Object.GetObject<global::Com.Urbanairship.Push.Proto.Rpc.Request> (JNIEnv.CallStaticObjectMethod  (class_ref, id_parseFrom_Lcom_google_protobuf_ByteString_Lcom_google_protobuf_ExtensionRegistryLite_, new JValue (p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
				return __ret;
			}

			static IntPtr id_parseFrom_Lcom_google_protobuf_CodedInputStream_;
			[Register ("parseFrom", "(Lcom/google/protobuf/CodedInputStream;)Lcom/urbanairship/push/proto/Rpc$Request;", "")]
			public static global::Com.Urbanairship.Push.Proto.Rpc.Request ParseFrom (global::Com.Google.Protobuf.CodedInputStream p0)
			{
				if (id_parseFrom_Lcom_google_protobuf_CodedInputStream_ == IntPtr.Zero)
					id_parseFrom_Lcom_google_protobuf_CodedInputStream_ = JNIEnv.GetStaticMethodID (class_ref, "parseFrom", "(Lcom/google/protobuf/CodedInputStream;)Lcom/urbanairship/push/proto/Rpc$Request;");
				global::Com.Urbanairship.Push.Proto.Rpc.Request __ret = Java.Lang.Object.GetObject<global::Com.Urbanairship.Push.Proto.Rpc.Request> (JNIEnv.CallStaticObjectMethod  (class_ref, id_parseFrom_Lcom_google_protobuf_CodedInputStream_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
				return __ret;
			}

			static IntPtr id_parseFrom_Lcom_google_protobuf_CodedInputStream_Lcom_google_protobuf_ExtensionRegistryLite_;
			[Register ("parseFrom", "(Lcom/google/protobuf/CodedInputStream;Lcom/google/protobuf/ExtensionRegistryLite;)Lcom/urbanairship/push/proto/Rpc$Request;", "")]
			public static global::Com.Urbanairship.Push.Proto.Rpc.Request ParseFrom (global::Com.Google.Protobuf.CodedInputStream p0, global::Com.Google.Protobuf.ExtensionRegistryLite p1)
			{
				if (id_parseFrom_Lcom_google_protobuf_CodedInputStream_Lcom_google_protobuf_ExtensionRegistryLite_ == IntPtr.Zero)
					id_parseFrom_Lcom_google_protobuf_CodedInputStream_Lcom_google_protobuf_ExtensionRegistryLite_ = JNIEnv.GetStaticMethodID (class_ref, "parseFrom", "(Lcom/google/protobuf/CodedInputStream;Lcom/google/protobuf/ExtensionRegistryLite;)Lcom/urbanairship/push/proto/Rpc$Request;");
				global::Com.Urbanairship.Push.Proto.Rpc.Request __ret = Java.Lang.Object.GetObject<global::Com.Urbanairship.Push.Proto.Rpc.Request> (JNIEnv.CallStaticObjectMethod  (class_ref, id_parseFrom_Lcom_google_protobuf_CodedInputStream_Lcom_google_protobuf_ExtensionRegistryLite_, new JValue (p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
				return __ret;
			}

			static IntPtr id_parseFrom_Ljava_io_InputStream_;
			[Register ("parseFrom", "(Ljava/io/InputStream;)Lcom/urbanairship/push/proto/Rpc$Request;", "")]
			public static global::Com.Urbanairship.Push.Proto.Rpc.Request ParseFrom (global::System.IO.Stream p0)
			{
				if (id_parseFrom_Ljava_io_InputStream_ == IntPtr.Zero)
					id_parseFrom_Ljava_io_InputStream_ = JNIEnv.GetStaticMethodID (class_ref, "parseFrom", "(Ljava/io/InputStream;)Lcom/urbanairship/push/proto/Rpc$Request;");
				IntPtr native_p0 = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (p0);
				global::Com.Urbanairship.Push.Proto.Rpc.Request __ret = Java.Lang.Object.GetObject<global::Com.Urbanairship.Push.Proto.Rpc.Request> (JNIEnv.CallStaticObjectMethod  (class_ref, id_parseFrom_Ljava_io_InputStream_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
				JNIEnv.DeleteLocalRef (native_p0);
				return __ret;
			}

			static IntPtr id_parseFrom_Ljava_io_InputStream_Lcom_google_protobuf_ExtensionRegistryLite_;
			[Register ("parseFrom", "(Ljava/io/InputStream;Lcom/google/protobuf/ExtensionRegistryLite;)Lcom/urbanairship/push/proto/Rpc$Request;", "")]
			public static global::Com.Urbanairship.Push.Proto.Rpc.Request ParseFrom (global::System.IO.Stream p0, global::Com.Google.Protobuf.ExtensionRegistryLite p1)
			{
				if (id_parseFrom_Ljava_io_InputStream_Lcom_google_protobuf_ExtensionRegistryLite_ == IntPtr.Zero)
					id_parseFrom_Ljava_io_InputStream_Lcom_google_protobuf_ExtensionRegistryLite_ = JNIEnv.GetStaticMethodID (class_ref, "parseFrom", "(Ljava/io/InputStream;Lcom/google/protobuf/ExtensionRegistryLite;)Lcom/urbanairship/push/proto/Rpc$Request;");
				IntPtr native_p0 = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (p0);
				global::Com.Urbanairship.Push.Proto.Rpc.Request __ret = Java.Lang.Object.GetObject<global::Com.Urbanairship.Push.Proto.Rpc.Request> (JNIEnv.CallStaticObjectMethod  (class_ref, id_parseFrom_Ljava_io_InputStream_Lcom_google_protobuf_ExtensionRegistryLite_, new JValue (native_p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
				JNIEnv.DeleteLocalRef (native_p0);
				return __ret;
			}

			static IntPtr id_toBuilder;
			[Register ("toBuilder", "()Lcom/urbanairship/push/proto/Rpc$Request$Builder;", "")]
			public global::Com.Urbanairship.Push.Proto.Rpc.Request.Builder ToBuilder ()
			{
				if (id_toBuilder == IntPtr.Zero)
					id_toBuilder = JNIEnv.GetMethodID (class_ref, "toBuilder", "()Lcom/urbanairship/push/proto/Rpc$Request$Builder;");
				return Java.Lang.Object.GetObject<global::Com.Urbanairship.Push.Proto.Rpc.Request.Builder> (JNIEnv.CallObjectMethod  (Handle, id_toBuilder), JniHandleOwnership.TransferLocalRef);
			}

			static IntPtr id_writeTo_Lcom_google_protobuf_CodedOutputStream_;
			[Register ("writeTo", "(Lcom/google/protobuf/CodedOutputStream;)V", "")]
			public override void WriteTo (global::Com.Google.Protobuf.CodedOutputStream p0)
			{
				if (id_writeTo_Lcom_google_protobuf_CodedOutputStream_ == IntPtr.Zero)
					id_writeTo_Lcom_google_protobuf_CodedOutputStream_ = JNIEnv.GetMethodID (class_ref, "writeTo", "(Lcom/google/protobuf/CodedOutputStream;)V");
				JNIEnv.CallVoidMethod  (Handle, id_writeTo_Lcom_google_protobuf_CodedOutputStream_, new JValue (p0));
			}

		}

		[global::Android.Runtime.Register ("com/urbanairship/push/proto/Rpc$Response", DoNotGenerateAcw=true)]
		public sealed partial class Response : global::Com.Google.Protobuf.GeneratedMessageLite {


			[Register ("BODY_FIELD_NUMBER")]
			public const int BodyFieldNumber = (int) 2;

			[Register ("REQUEST_ID_FIELD_NUMBER")]
			public const int RequestIdFieldNumber = (int) 3;

			[Register ("STATUS_FIELD_NUMBER")]
			public const int StatusFieldNumber = (int) 1;
			[global::Android.Runtime.Register ("com/urbanairship/push/proto/Rpc$Response$Builder", DoNotGenerateAcw=true)]
			public new sealed partial class Builder : global::Com.Google.Protobuf.GeneratedMessageLite.Builder {

				internal static IntPtr java_class_handle;
				internal static IntPtr class_ref {
					get {
						return JNIEnv.FindClass ("com/urbanairship/push/proto/Rpc$Response$Builder", ref java_class_handle);
					}
				}

				protected override IntPtr ThresholdClass {
					get { return class_ref; }
				}

				protected override global::System.Type ThresholdType {
					get { return typeof (Builder); }
				}

				internal Builder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

				static IntPtr id_getBody;
				public global::Com.Google.Protobuf.ByteString Body {
					[Register ("getBody", "()Lcom/google/protobuf/ByteString;", "GetGetBodyHandler")]
					get {
						if (id_getBody == IntPtr.Zero)
							id_getBody = JNIEnv.GetMethodID (class_ref, "getBody", "()Lcom/google/protobuf/ByteString;");
						return Java.Lang.Object.GetObject<global::Com.Google.Protobuf.ByteString> (JNIEnv.CallObjectMethod  (Handle, id_getBody), JniHandleOwnership.TransferLocalRef);
					}
				}

				static IntPtr id_getDefaultInstanceForType;
				public override global::Com.Urbanairship.Push.Proto.Rpc.Response DefaultInstanceForType {
					[Register ("getDefaultInstanceForType", "()Lcom/urbanairship/push/proto/Rpc$Response;", "GetGetDefaultInstanceForTypeHandler")]
					get {
						if (id_getDefaultInstanceForType == IntPtr.Zero)
							id_getDefaultInstanceForType = JNIEnv.GetMethodID (class_ref, "getDefaultInstanceForType", "()Lcom/urbanairship/push/proto/Rpc$Response;");
						return Java.Lang.Object.GetObject<global::Com.Urbanairship.Push.Proto.Rpc.Response> (JNIEnv.CallObjectMethod  (Handle, id_getDefaultInstanceForType), JniHandleOwnership.TransferLocalRef);
					}
				}

				static IntPtr id_hasBody;
				public bool HasBody {
					[Register ("hasBody", "()Z", "GetHasBodyHandler")]
					get {
						if (id_hasBody == IntPtr.Zero)
							id_hasBody = JNIEnv.GetMethodID (class_ref, "hasBody", "()Z");
						return JNIEnv.CallBooleanMethod  (Handle, id_hasBody);
					}
				}

				static IntPtr id_hasRequestId;
				public bool HasRequestId {
					[Register ("hasRequestId", "()Z", "GetHasRequestIdHandler")]
					get {
						if (id_hasRequestId == IntPtr.Zero)
							id_hasRequestId = JNIEnv.GetMethodID (class_ref, "hasRequestId", "()Z");
						return JNIEnv.CallBooleanMethod  (Handle, id_hasRequestId);
					}
				}

				static IntPtr id_hasStatus;
				public bool HasStatus {
					[Register ("hasStatus", "()Z", "GetHasStatusHandler")]
					get {
						if (id_hasStatus == IntPtr.Zero)
							id_hasStatus = JNIEnv.GetMethodID (class_ref, "hasStatus", "()Z");
						return JNIEnv.CallBooleanMethod  (Handle, id_hasStatus);
					}
				}

				static IntPtr id_isInitialized;
				public override bool IsInitialized {
					[Register ("isInitialized", "()Z", "GetIsInitializedHandler")]
					get {
						if (id_isInitialized == IntPtr.Zero)
							id_isInitialized = JNIEnv.GetMethodID (class_ref, "isInitialized", "()Z");
						return JNIEnv.CallBooleanMethod  (Handle, id_isInitialized);
					}
				}

				static IntPtr id_getRequestId;
				public string RequestId {
					[Register ("getRequestId", "()Ljava/lang/String;", "GetGetRequestIdHandler")]
					get {
						if (id_getRequestId == IntPtr.Zero)
							id_getRequestId = JNIEnv.GetMethodID (class_ref, "getRequestId", "()Ljava/lang/String;");
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getRequestId), JniHandleOwnership.TransferLocalRef);
					}
				}

				static IntPtr id_getStatus;
				public global::Com.Urbanairship.Push.Proto.Rpc.Status Status {
					[Register ("getStatus", "()Lcom/urbanairship/push/proto/Rpc$Status;", "GetGetStatusHandler")]
					get {
						if (id_getStatus == IntPtr.Zero)
							id_getStatus = JNIEnv.GetMethodID (class_ref, "getStatus", "()Lcom/urbanairship/push/proto/Rpc$Status;");
						return Java.Lang.Object.GetObject<global::Com.Urbanairship.Push.Proto.Rpc.Status> (JNIEnv.CallObjectMethod  (Handle, id_getStatus), JniHandleOwnership.TransferLocalRef);
					}
				}

				static IntPtr id_build;
				[Register ("build", "()Lcom/urbanairship/push/proto/Rpc$Response;", "")]
				public global::Com.Urbanairship.Push.Proto.Rpc.Response Build ()
				{
					if (id_build == IntPtr.Zero)
						id_build = JNIEnv.GetMethodID (class_ref, "build", "()Lcom/urbanairship/push/proto/Rpc$Response;");
					return Java.Lang.Object.GetObject<global::Com.Urbanairship.Push.Proto.Rpc.Response> (JNIEnv.CallObjectMethod  (Handle, id_build), JniHandleOwnership.TransferLocalRef);
				}

				static IntPtr id_buildPartial;
				[Register ("buildPartial", "()Lcom/urbanairship/push/proto/Rpc$Response;", "")]
				public global::Com.Urbanairship.Push.Proto.Rpc.Response BuildPartial ()
				{
					if (id_buildPartial == IntPtr.Zero)
						id_buildPartial = JNIEnv.GetMethodID (class_ref, "buildPartial", "()Lcom/urbanairship/push/proto/Rpc$Response;");
					return Java.Lang.Object.GetObject<global::Com.Urbanairship.Push.Proto.Rpc.Response> (JNIEnv.CallObjectMethod  (Handle, id_buildPartial), JniHandleOwnership.TransferLocalRef);
				}

				static IntPtr id_clear;
				[Register ("clear", "()Lcom/urbanairship/push/proto/Rpc$Response$Builder;", "")]
				public global::Com.Urbanairship.Push.Proto.Rpc.Response.Builder Clear ()
				{
					if (id_clear == IntPtr.Zero)
						id_clear = JNIEnv.GetMethodID (class_ref, "clear", "()Lcom/urbanairship/push/proto/Rpc$Response$Builder;");
					return Java.Lang.Object.GetObject<global::Com.Urbanairship.Push.Proto.Rpc.Response.Builder> (JNIEnv.CallObjectMethod  (Handle, id_clear), JniHandleOwnership.TransferLocalRef);
				}

				static IntPtr id_clearBody;
				[Register ("clearBody", "()Lcom/urbanairship/push/proto/Rpc$Response$Builder;", "")]
				public global::Com.Urbanairship.Push.Proto.Rpc.Response.Builder ClearBody ()
				{
					if (id_clearBody == IntPtr.Zero)
						id_clearBody = JNIEnv.GetMethodID (class_ref, "clearBody", "()Lcom/urbanairship/push/proto/Rpc$Response$Builder;");
					return Java.Lang.Object.GetObject<global::Com.Urbanairship.Push.Proto.Rpc.Response.Builder> (JNIEnv.CallObjectMethod  (Handle, id_clearBody), JniHandleOwnership.TransferLocalRef);
				}

				static IntPtr id_clearRequestId;
				[Register ("clearRequestId", "()Lcom/urbanairship/push/proto/Rpc$Response$Builder;", "")]
				public global::Com.Urbanairship.Push.Proto.Rpc.Response.Builder ClearRequestId ()
				{
					if (id_clearRequestId == IntPtr.Zero)
						id_clearRequestId = JNIEnv.GetMethodID (class_ref, "clearRequestId", "()Lcom/urbanairship/push/proto/Rpc$Response$Builder;");
					return Java.Lang.Object.GetObject<global::Com.Urbanairship.Push.Proto.Rpc.Response.Builder> (JNIEnv.CallObjectMethod  (Handle, id_clearRequestId), JniHandleOwnership.TransferLocalRef);
				}

				static IntPtr id_clearStatus;
				[Register ("clearStatus", "()Lcom/urbanairship/push/proto/Rpc$Response$Builder;", "")]
				public global::Com.Urbanairship.Push.Proto.Rpc.Response.Builder ClearStatus ()
				{
					if (id_clearStatus == IntPtr.Zero)
						id_clearStatus = JNIEnv.GetMethodID (class_ref, "clearStatus", "()Lcom/urbanairship/push/proto/Rpc$Response$Builder;");
					return Java.Lang.Object.GetObject<global::Com.Urbanairship.Push.Proto.Rpc.Response.Builder> (JNIEnv.CallObjectMethod  (Handle, id_clearStatus), JniHandleOwnership.TransferLocalRef);
				}

				static IntPtr id_internalGetResult;
				[Register ("internalGetResult", "()Lcom/urbanairship/push/proto/Rpc$Response;", "")]
				protected override global::Com.Urbanairship.Push.Proto.Rpc.Response InternalGetResult ()
				{
					if (id_internalGetResult == IntPtr.Zero)
						id_internalGetResult = JNIEnv.GetMethodID (class_ref, "internalGetResult", "()Lcom/urbanairship/push/proto/Rpc$Response;");
					return Java.Lang.Object.GetObject<global::Com.Urbanairship.Push.Proto.Rpc.Response> (JNIEnv.CallObjectMethod  (Handle, id_internalGetResult), JniHandleOwnership.TransferLocalRef);
				}

				static IntPtr id_mergeFrom_Lcom_google_protobuf_CodedInputStream_Lcom_google_protobuf_ExtensionRegistryLite_;
				[Register ("mergeFrom", "(Lcom/google/protobuf/CodedInputStream;Lcom/google/protobuf/ExtensionRegistryLite;)Lcom/urbanairship/push/proto/Rpc$Response$Builder;", "")]
				public override global::Com.Urbanairship.Push.Proto.Rpc.Response.Builder MergeFrom (global::Com.Google.Protobuf.CodedInputStream p0, global::Com.Google.Protobuf.ExtensionRegistryLite p1)
				{
					if (id_mergeFrom_Lcom_google_protobuf_CodedInputStream_Lcom_google_protobuf_ExtensionRegistryLite_ == IntPtr.Zero)
						id_mergeFrom_Lcom_google_protobuf_CodedInputStream_Lcom_google_protobuf_ExtensionRegistryLite_ = JNIEnv.GetMethodID (class_ref, "mergeFrom", "(Lcom/google/protobuf/CodedInputStream;Lcom/google/protobuf/ExtensionRegistryLite;)Lcom/urbanairship/push/proto/Rpc$Response$Builder;");
					global::Com.Urbanairship.Push.Proto.Rpc.Response.Builder __ret = Java.Lang.Object.GetObject<global::Com.Urbanairship.Push.Proto.Rpc.Response.Builder> (JNIEnv.CallObjectMethod  (Handle, id_mergeFrom_Lcom_google_protobuf_CodedInputStream_Lcom_google_protobuf_ExtensionRegistryLite_, new JValue (p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
					return __ret;
				}

				static IntPtr id_mergeFrom_Lcom_google_protobuf_GeneratedMessageLite_;
				[Register ("mergeFrom", "(Lcom/google/protobuf/GeneratedMessageLite;)Lcom/google/protobuf/GeneratedMessageLite$Builder;", "")]
				public global::Com.Google.Protobuf.GeneratedMessageLite.Builder MergeFrom (global::Com.Google.Protobuf.GeneratedMessageLite p0)
				{
					if (id_mergeFrom_Lcom_google_protobuf_GeneratedMessageLite_ == IntPtr.Zero)
						id_mergeFrom_Lcom_google_protobuf_GeneratedMessageLite_ = JNIEnv.GetMethodID (class_ref, "mergeFrom", "(Lcom/google/protobuf/GeneratedMessageLite;)Lcom/google/protobuf/GeneratedMessageLite$Builder;");
					global::Com.Google.Protobuf.GeneratedMessageLite.Builder __ret = Java.Lang.Object.GetObject<global::Com.Google.Protobuf.GeneratedMessageLite.Builder> (JNIEnv.CallObjectMethod  (Handle, id_mergeFrom_Lcom_google_protobuf_GeneratedMessageLite_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
					return __ret;
				}

				static IntPtr id_mergeFrom_Lcom_urbanairship_push_proto_Rpc_Response_;
				[Register ("mergeFrom", "(Lcom/urbanairship/push/proto/Rpc$Response;)Lcom/urbanairship/push/proto/Rpc$Response$Builder;", "")]
				public global::Com.Urbanairship.Push.Proto.Rpc.Response.Builder MergeFrom (global::Com.Urbanairship.Push.Proto.Rpc.Response p0)
				{
					if (id_mergeFrom_Lcom_urbanairship_push_proto_Rpc_Response_ == IntPtr.Zero)
						id_mergeFrom_Lcom_urbanairship_push_proto_Rpc_Response_ = JNIEnv.GetMethodID (class_ref, "mergeFrom", "(Lcom/urbanairship/push/proto/Rpc$Response;)Lcom/urbanairship/push/proto/Rpc$Response$Builder;");
					global::Com.Urbanairship.Push.Proto.Rpc.Response.Builder __ret = Java.Lang.Object.GetObject<global::Com.Urbanairship.Push.Proto.Rpc.Response.Builder> (JNIEnv.CallObjectMethod  (Handle, id_mergeFrom_Lcom_urbanairship_push_proto_Rpc_Response_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
					return __ret;
				}

				static IntPtr id_setBody_Lcom_google_protobuf_ByteString_;
				[Register ("setBody", "(Lcom/google/protobuf/ByteString;)Lcom/urbanairship/push/proto/Rpc$Response$Builder;", "")]
				public global::Com.Urbanairship.Push.Proto.Rpc.Response.Builder SetBody (global::Com.Google.Protobuf.ByteString p0)
				{
					if (id_setBody_Lcom_google_protobuf_ByteString_ == IntPtr.Zero)
						id_setBody_Lcom_google_protobuf_ByteString_ = JNIEnv.GetMethodID (class_ref, "setBody", "(Lcom/google/protobuf/ByteString;)Lcom/urbanairship/push/proto/Rpc$Response$Builder;");
					global::Com.Urbanairship.Push.Proto.Rpc.Response.Builder __ret = Java.Lang.Object.GetObject<global::Com.Urbanairship.Push.Proto.Rpc.Response.Builder> (JNIEnv.CallObjectMethod  (Handle, id_setBody_Lcom_google_protobuf_ByteString_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
					return __ret;
				}

				static IntPtr id_setRequestId_Ljava_lang_String_;
				[Register ("setRequestId", "(Ljava/lang/String;)Lcom/urbanairship/push/proto/Rpc$Response$Builder;", "")]
				public global::Com.Urbanairship.Push.Proto.Rpc.Response.Builder SetRequestId (string p0)
				{
					if (id_setRequestId_Ljava_lang_String_ == IntPtr.Zero)
						id_setRequestId_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setRequestId", "(Ljava/lang/String;)Lcom/urbanairship/push/proto/Rpc$Response$Builder;");
					IntPtr native_p0 = JNIEnv.NewString (p0);
					global::Com.Urbanairship.Push.Proto.Rpc.Response.Builder __ret = Java.Lang.Object.GetObject<global::Com.Urbanairship.Push.Proto.Rpc.Response.Builder> (JNIEnv.CallObjectMethod  (Handle, id_setRequestId_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
					JNIEnv.DeleteLocalRef (native_p0);
					return __ret;
				}

				static IntPtr id_setStatus_Lcom_urbanairship_push_proto_Rpc_Status_;
				[Register ("setStatus", "(Lcom/urbanairship/push/proto/Rpc$Status;)Lcom/urbanairship/push/proto/Rpc$Response$Builder;", "")]
				public global::Com.Urbanairship.Push.Proto.Rpc.Response.Builder SetStatus (global::Com.Urbanairship.Push.Proto.Rpc.Status p0)
				{
					if (id_setStatus_Lcom_urbanairship_push_proto_Rpc_Status_ == IntPtr.Zero)
						id_setStatus_Lcom_urbanairship_push_proto_Rpc_Status_ = JNIEnv.GetMethodID (class_ref, "setStatus", "(Lcom/urbanairship/push/proto/Rpc$Status;)Lcom/urbanairship/push/proto/Rpc$Response$Builder;");
					global::Com.Urbanairship.Push.Proto.Rpc.Response.Builder __ret = Java.Lang.Object.GetObject<global::Com.Urbanairship.Push.Proto.Rpc.Response.Builder> (JNIEnv.CallObjectMethod  (Handle, id_setStatus_Lcom_urbanairship_push_proto_Rpc_Status_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
					return __ret;
				}

			}

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/urbanairship/push/proto/Rpc$Response", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Response); }
			}

			internal Response (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_getBody;
			public global::Com.Google.Protobuf.ByteString Body {
				[Register ("getBody", "()Lcom/google/protobuf/ByteString;", "GetGetBodyHandler")]
				get {
					if (id_getBody == IntPtr.Zero)
						id_getBody = JNIEnv.GetMethodID (class_ref, "getBody", "()Lcom/google/protobuf/ByteString;");
					return Java.Lang.Object.GetObject<global::Com.Google.Protobuf.ByteString> (JNIEnv.CallObjectMethod  (Handle, id_getBody), JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr id_getDefaultInstance;
			public static global::Com.Urbanairship.Push.Proto.Rpc.Response DefaultInstance {
				[Register ("getDefaultInstance", "()Lcom/urbanairship/push/proto/Rpc$Response;", "GetGetDefaultInstanceHandler")]
				get {
					if (id_getDefaultInstance == IntPtr.Zero)
						id_getDefaultInstance = JNIEnv.GetStaticMethodID (class_ref, "getDefaultInstance", "()Lcom/urbanairship/push/proto/Rpc$Response;");
					return Java.Lang.Object.GetObject<global::Com.Urbanairship.Push.Proto.Rpc.Response> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getDefaultInstance), JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr id_getDefaultInstanceForType;
			public override global::Com.Urbanairship.Push.Proto.Rpc.Response DefaultInstanceForType {
				[Register ("getDefaultInstanceForType", "()Lcom/urbanairship/push/proto/Rpc$Response;", "GetGetDefaultInstanceForTypeHandler")]
				get {
					if (id_getDefaultInstanceForType == IntPtr.Zero)
						id_getDefaultInstanceForType = JNIEnv.GetMethodID (class_ref, "getDefaultInstanceForType", "()Lcom/urbanairship/push/proto/Rpc$Response;");
					return Java.Lang.Object.GetObject<global::Com.Urbanairship.Push.Proto.Rpc.Response> (JNIEnv.CallObjectMethod  (Handle, id_getDefaultInstanceForType), JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr id_hasBody;
			public bool HasBody {
				[Register ("hasBody", "()Z", "GetHasBodyHandler")]
				get {
					if (id_hasBody == IntPtr.Zero)
						id_hasBody = JNIEnv.GetMethodID (class_ref, "hasBody", "()Z");
					return JNIEnv.CallBooleanMethod  (Handle, id_hasBody);
				}
			}

			static IntPtr id_hasRequestId;
			public bool HasRequestId {
				[Register ("hasRequestId", "()Z", "GetHasRequestIdHandler")]
				get {
					if (id_hasRequestId == IntPtr.Zero)
						id_hasRequestId = JNIEnv.GetMethodID (class_ref, "hasRequestId", "()Z");
					return JNIEnv.CallBooleanMethod  (Handle, id_hasRequestId);
				}
			}

			static IntPtr id_hasStatus;
			public bool HasStatus {
				[Register ("hasStatus", "()Z", "GetHasStatusHandler")]
				get {
					if (id_hasStatus == IntPtr.Zero)
						id_hasStatus = JNIEnv.GetMethodID (class_ref, "hasStatus", "()Z");
					return JNIEnv.CallBooleanMethod  (Handle, id_hasStatus);
				}
			}

			static IntPtr id_isInitialized;
			public override bool IsInitialized {
				[Register ("isInitialized", "()Z", "GetIsInitializedHandler")]
				get {
					if (id_isInitialized == IntPtr.Zero)
						id_isInitialized = JNIEnv.GetMethodID (class_ref, "isInitialized", "()Z");
					return JNIEnv.CallBooleanMethod  (Handle, id_isInitialized);
				}
			}

			static IntPtr id_getRequestId;
			public string RequestId {
				[Register ("getRequestId", "()Ljava/lang/String;", "GetGetRequestIdHandler")]
				get {
					if (id_getRequestId == IntPtr.Zero)
						id_getRequestId = JNIEnv.GetMethodID (class_ref, "getRequestId", "()Ljava/lang/String;");
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getRequestId), JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr id_getSerializedSize;
			public override int SerializedSize {
				[Register ("getSerializedSize", "()I", "GetGetSerializedSizeHandler")]
				get {
					if (id_getSerializedSize == IntPtr.Zero)
						id_getSerializedSize = JNIEnv.GetMethodID (class_ref, "getSerializedSize", "()I");
					return JNIEnv.CallIntMethod  (Handle, id_getSerializedSize);
				}
			}

			static IntPtr id_getStatus;
			public global::Com.Urbanairship.Push.Proto.Rpc.Status Status {
				[Register ("getStatus", "()Lcom/urbanairship/push/proto/Rpc$Status;", "GetGetStatusHandler")]
				get {
					if (id_getStatus == IntPtr.Zero)
						id_getStatus = JNIEnv.GetMethodID (class_ref, "getStatus", "()Lcom/urbanairship/push/proto/Rpc$Status;");
					return Java.Lang.Object.GetObject<global::Com.Urbanairship.Push.Proto.Rpc.Status> (JNIEnv.CallObjectMethod  (Handle, id_getStatus), JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr id_newBuilder;
			[Register ("newBuilder", "()Lcom/urbanairship/push/proto/Rpc$Response$Builder;", "")]
			public static global::Com.Urbanairship.Push.Proto.Rpc.Response.Builder NewBuilder ()
			{
				if (id_newBuilder == IntPtr.Zero)
					id_newBuilder = JNIEnv.GetStaticMethodID (class_ref, "newBuilder", "()Lcom/urbanairship/push/proto/Rpc$Response$Builder;");
				return Java.Lang.Object.GetObject<global::Com.Urbanairship.Push.Proto.Rpc.Response.Builder> (JNIEnv.CallStaticObjectMethod  (class_ref, id_newBuilder), JniHandleOwnership.TransferLocalRef);
			}

			static IntPtr id_newBuilder_Lcom_urbanairship_push_proto_Rpc_Response_;
			[Register ("newBuilder", "(Lcom/urbanairship/push/proto/Rpc$Response;)Lcom/urbanairship/push/proto/Rpc$Response$Builder;", "")]
			public static global::Com.Urbanairship.Push.Proto.Rpc.Response.Builder NewBuilder (global::Com.Urbanairship.Push.Proto.Rpc.Response p0)
			{
				if (id_newBuilder_Lcom_urbanairship_push_proto_Rpc_Response_ == IntPtr.Zero)
					id_newBuilder_Lcom_urbanairship_push_proto_Rpc_Response_ = JNIEnv.GetStaticMethodID (class_ref, "newBuilder", "(Lcom/urbanairship/push/proto/Rpc$Response;)Lcom/urbanairship/push/proto/Rpc$Response$Builder;");
				global::Com.Urbanairship.Push.Proto.Rpc.Response.Builder __ret = Java.Lang.Object.GetObject<global::Com.Urbanairship.Push.Proto.Rpc.Response.Builder> (JNIEnv.CallStaticObjectMethod  (class_ref, id_newBuilder_Lcom_urbanairship_push_proto_Rpc_Response_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
				return __ret;
			}

			static IntPtr id_newBuilderForType;
			[Register ("newBuilderForType", "()Lcom/urbanairship/push/proto/Rpc$Response$Builder;", "")]
			public global::Com.Urbanairship.Push.Proto.Rpc.Response.Builder NewBuilderForType ()
			{
				if (id_newBuilderForType == IntPtr.Zero)
					id_newBuilderForType = JNIEnv.GetMethodID (class_ref, "newBuilderForType", "()Lcom/urbanairship/push/proto/Rpc$Response$Builder;");
				return Java.Lang.Object.GetObject<global::Com.Urbanairship.Push.Proto.Rpc.Response.Builder> (JNIEnv.CallObjectMethod  (Handle, id_newBuilderForType), JniHandleOwnership.TransferLocalRef);
			}

			static IntPtr id_parseDelimitedFrom_Ljava_io_InputStream_;
			[Register ("parseDelimitedFrom", "(Ljava/io/InputStream;)Lcom/urbanairship/push/proto/Rpc$Response;", "")]
			public static global::Com.Urbanairship.Push.Proto.Rpc.Response ParseDelimitedFrom (global::System.IO.Stream p0)
			{
				if (id_parseDelimitedFrom_Ljava_io_InputStream_ == IntPtr.Zero)
					id_parseDelimitedFrom_Ljava_io_InputStream_ = JNIEnv.GetStaticMethodID (class_ref, "parseDelimitedFrom", "(Ljava/io/InputStream;)Lcom/urbanairship/push/proto/Rpc$Response;");
				IntPtr native_p0 = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (p0);
				global::Com.Urbanairship.Push.Proto.Rpc.Response __ret = Java.Lang.Object.GetObject<global::Com.Urbanairship.Push.Proto.Rpc.Response> (JNIEnv.CallStaticObjectMethod  (class_ref, id_parseDelimitedFrom_Ljava_io_InputStream_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
				JNIEnv.DeleteLocalRef (native_p0);
				return __ret;
			}

			static IntPtr id_parseDelimitedFrom_Ljava_io_InputStream_Lcom_google_protobuf_ExtensionRegistryLite_;
			[Register ("parseDelimitedFrom", "(Ljava/io/InputStream;Lcom/google/protobuf/ExtensionRegistryLite;)Lcom/urbanairship/push/proto/Rpc$Response;", "")]
			public static global::Com.Urbanairship.Push.Proto.Rpc.Response ParseDelimitedFrom (global::System.IO.Stream p0, global::Com.Google.Protobuf.ExtensionRegistryLite p1)
			{
				if (id_parseDelimitedFrom_Ljava_io_InputStream_Lcom_google_protobuf_ExtensionRegistryLite_ == IntPtr.Zero)
					id_parseDelimitedFrom_Ljava_io_InputStream_Lcom_google_protobuf_ExtensionRegistryLite_ = JNIEnv.GetStaticMethodID (class_ref, "parseDelimitedFrom", "(Ljava/io/InputStream;Lcom/google/protobuf/ExtensionRegistryLite;)Lcom/urbanairship/push/proto/Rpc$Response;");
				IntPtr native_p0 = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (p0);
				global::Com.Urbanairship.Push.Proto.Rpc.Response __ret = Java.Lang.Object.GetObject<global::Com.Urbanairship.Push.Proto.Rpc.Response> (JNIEnv.CallStaticObjectMethod  (class_ref, id_parseDelimitedFrom_Ljava_io_InputStream_Lcom_google_protobuf_ExtensionRegistryLite_, new JValue (native_p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
				JNIEnv.DeleteLocalRef (native_p0);
				return __ret;
			}

			static IntPtr id_parseFrom_arrayB;
			[Register ("parseFrom", "([B)Lcom/urbanairship/push/proto/Rpc$Response;", "")]
			public static global::Com.Urbanairship.Push.Proto.Rpc.Response ParseFrom (byte[] p0)
			{
				if (id_parseFrom_arrayB == IntPtr.Zero)
					id_parseFrom_arrayB = JNIEnv.GetStaticMethodID (class_ref, "parseFrom", "([B)Lcom/urbanairship/push/proto/Rpc$Response;");
				IntPtr native_p0 = JNIEnv.NewArray (p0);
				global::Com.Urbanairship.Push.Proto.Rpc.Response __ret = Java.Lang.Object.GetObject<global::Com.Urbanairship.Push.Proto.Rpc.Response> (JNIEnv.CallStaticObjectMethod  (class_ref, id_parseFrom_arrayB, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				return __ret;
			}

			static IntPtr id_parseFrom_arrayBLcom_google_protobuf_ExtensionRegistryLite_;
			[Register ("parseFrom", "([BLcom/google/protobuf/ExtensionRegistryLite;)Lcom/urbanairship/push/proto/Rpc$Response;", "")]
			public static global::Com.Urbanairship.Push.Proto.Rpc.Response ParseFrom (byte[] p0, global::Com.Google.Protobuf.ExtensionRegistryLite p1)
			{
				if (id_parseFrom_arrayBLcom_google_protobuf_ExtensionRegistryLite_ == IntPtr.Zero)
					id_parseFrom_arrayBLcom_google_protobuf_ExtensionRegistryLite_ = JNIEnv.GetStaticMethodID (class_ref, "parseFrom", "([BLcom/google/protobuf/ExtensionRegistryLite;)Lcom/urbanairship/push/proto/Rpc$Response;");
				IntPtr native_p0 = JNIEnv.NewArray (p0);
				global::Com.Urbanairship.Push.Proto.Rpc.Response __ret = Java.Lang.Object.GetObject<global::Com.Urbanairship.Push.Proto.Rpc.Response> (JNIEnv.CallStaticObjectMethod  (class_ref, id_parseFrom_arrayBLcom_google_protobuf_ExtensionRegistryLite_, new JValue (native_p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				return __ret;
			}

			static IntPtr id_parseFrom_Lcom_google_protobuf_ByteString_;
			[Register ("parseFrom", "(Lcom/google/protobuf/ByteString;)Lcom/urbanairship/push/proto/Rpc$Response;", "")]
			public static global::Com.Urbanairship.Push.Proto.Rpc.Response ParseFrom (global::Com.Google.Protobuf.ByteString p0)
			{
				if (id_parseFrom_Lcom_google_protobuf_ByteString_ == IntPtr.Zero)
					id_parseFrom_Lcom_google_protobuf_ByteString_ = JNIEnv.GetStaticMethodID (class_ref, "parseFrom", "(Lcom/google/protobuf/ByteString;)Lcom/urbanairship/push/proto/Rpc$Response;");
				global::Com.Urbanairship.Push.Proto.Rpc.Response __ret = Java.Lang.Object.GetObject<global::Com.Urbanairship.Push.Proto.Rpc.Response> (JNIEnv.CallStaticObjectMethod  (class_ref, id_parseFrom_Lcom_google_protobuf_ByteString_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
				return __ret;
			}

			static IntPtr id_parseFrom_Lcom_google_protobuf_ByteString_Lcom_google_protobuf_ExtensionRegistryLite_;
			[Register ("parseFrom", "(Lcom/google/protobuf/ByteString;Lcom/google/protobuf/ExtensionRegistryLite;)Lcom/urbanairship/push/proto/Rpc$Response;", "")]
			public static global::Com.Urbanairship.Push.Proto.Rpc.Response ParseFrom (global::Com.Google.Protobuf.ByteString p0, global::Com.Google.Protobuf.ExtensionRegistryLite p1)
			{
				if (id_parseFrom_Lcom_google_protobuf_ByteString_Lcom_google_protobuf_ExtensionRegistryLite_ == IntPtr.Zero)
					id_parseFrom_Lcom_google_protobuf_ByteString_Lcom_google_protobuf_ExtensionRegistryLite_ = JNIEnv.GetStaticMethodID (class_ref, "parseFrom", "(Lcom/google/protobuf/ByteString;Lcom/google/protobuf/ExtensionRegistryLite;)Lcom/urbanairship/push/proto/Rpc$Response;");
				global::Com.Urbanairship.Push.Proto.Rpc.Response __ret = Java.Lang.Object.GetObject<global::Com.Urbanairship.Push.Proto.Rpc.Response> (JNIEnv.CallStaticObjectMethod  (class_ref, id_parseFrom_Lcom_google_protobuf_ByteString_Lcom_google_protobuf_ExtensionRegistryLite_, new JValue (p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
				return __ret;
			}

			static IntPtr id_parseFrom_Lcom_google_protobuf_CodedInputStream_;
			[Register ("parseFrom", "(Lcom/google/protobuf/CodedInputStream;)Lcom/urbanairship/push/proto/Rpc$Response;", "")]
			public static global::Com.Urbanairship.Push.Proto.Rpc.Response ParseFrom (global::Com.Google.Protobuf.CodedInputStream p0)
			{
				if (id_parseFrom_Lcom_google_protobuf_CodedInputStream_ == IntPtr.Zero)
					id_parseFrom_Lcom_google_protobuf_CodedInputStream_ = JNIEnv.GetStaticMethodID (class_ref, "parseFrom", "(Lcom/google/protobuf/CodedInputStream;)Lcom/urbanairship/push/proto/Rpc$Response;");
				global::Com.Urbanairship.Push.Proto.Rpc.Response __ret = Java.Lang.Object.GetObject<global::Com.Urbanairship.Push.Proto.Rpc.Response> (JNIEnv.CallStaticObjectMethod  (class_ref, id_parseFrom_Lcom_google_protobuf_CodedInputStream_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
				return __ret;
			}

			static IntPtr id_parseFrom_Lcom_google_protobuf_CodedInputStream_Lcom_google_protobuf_ExtensionRegistryLite_;
			[Register ("parseFrom", "(Lcom/google/protobuf/CodedInputStream;Lcom/google/protobuf/ExtensionRegistryLite;)Lcom/urbanairship/push/proto/Rpc$Response;", "")]
			public static global::Com.Urbanairship.Push.Proto.Rpc.Response ParseFrom (global::Com.Google.Protobuf.CodedInputStream p0, global::Com.Google.Protobuf.ExtensionRegistryLite p1)
			{
				if (id_parseFrom_Lcom_google_protobuf_CodedInputStream_Lcom_google_protobuf_ExtensionRegistryLite_ == IntPtr.Zero)
					id_parseFrom_Lcom_google_protobuf_CodedInputStream_Lcom_google_protobuf_ExtensionRegistryLite_ = JNIEnv.GetStaticMethodID (class_ref, "parseFrom", "(Lcom/google/protobuf/CodedInputStream;Lcom/google/protobuf/ExtensionRegistryLite;)Lcom/urbanairship/push/proto/Rpc$Response;");
				global::Com.Urbanairship.Push.Proto.Rpc.Response __ret = Java.Lang.Object.GetObject<global::Com.Urbanairship.Push.Proto.Rpc.Response> (JNIEnv.CallStaticObjectMethod  (class_ref, id_parseFrom_Lcom_google_protobuf_CodedInputStream_Lcom_google_protobuf_ExtensionRegistryLite_, new JValue (p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
				return __ret;
			}

			static IntPtr id_parseFrom_Ljava_io_InputStream_;
			[Register ("parseFrom", "(Ljava/io/InputStream;)Lcom/urbanairship/push/proto/Rpc$Response;", "")]
			public static global::Com.Urbanairship.Push.Proto.Rpc.Response ParseFrom (global::System.IO.Stream p0)
			{
				if (id_parseFrom_Ljava_io_InputStream_ == IntPtr.Zero)
					id_parseFrom_Ljava_io_InputStream_ = JNIEnv.GetStaticMethodID (class_ref, "parseFrom", "(Ljava/io/InputStream;)Lcom/urbanairship/push/proto/Rpc$Response;");
				IntPtr native_p0 = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (p0);
				global::Com.Urbanairship.Push.Proto.Rpc.Response __ret = Java.Lang.Object.GetObject<global::Com.Urbanairship.Push.Proto.Rpc.Response> (JNIEnv.CallStaticObjectMethod  (class_ref, id_parseFrom_Ljava_io_InputStream_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
				JNIEnv.DeleteLocalRef (native_p0);
				return __ret;
			}

			static IntPtr id_parseFrom_Ljava_io_InputStream_Lcom_google_protobuf_ExtensionRegistryLite_;
			[Register ("parseFrom", "(Ljava/io/InputStream;Lcom/google/protobuf/ExtensionRegistryLite;)Lcom/urbanairship/push/proto/Rpc$Response;", "")]
			public static global::Com.Urbanairship.Push.Proto.Rpc.Response ParseFrom (global::System.IO.Stream p0, global::Com.Google.Protobuf.ExtensionRegistryLite p1)
			{
				if (id_parseFrom_Ljava_io_InputStream_Lcom_google_protobuf_ExtensionRegistryLite_ == IntPtr.Zero)
					id_parseFrom_Ljava_io_InputStream_Lcom_google_protobuf_ExtensionRegistryLite_ = JNIEnv.GetStaticMethodID (class_ref, "parseFrom", "(Ljava/io/InputStream;Lcom/google/protobuf/ExtensionRegistryLite;)Lcom/urbanairship/push/proto/Rpc$Response;");
				IntPtr native_p0 = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (p0);
				global::Com.Urbanairship.Push.Proto.Rpc.Response __ret = Java.Lang.Object.GetObject<global::Com.Urbanairship.Push.Proto.Rpc.Response> (JNIEnv.CallStaticObjectMethod  (class_ref, id_parseFrom_Ljava_io_InputStream_Lcom_google_protobuf_ExtensionRegistryLite_, new JValue (native_p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
				JNIEnv.DeleteLocalRef (native_p0);
				return __ret;
			}

			static IntPtr id_toBuilder;
			[Register ("toBuilder", "()Lcom/urbanairship/push/proto/Rpc$Response$Builder;", "")]
			public global::Com.Urbanairship.Push.Proto.Rpc.Response.Builder ToBuilder ()
			{
				if (id_toBuilder == IntPtr.Zero)
					id_toBuilder = JNIEnv.GetMethodID (class_ref, "toBuilder", "()Lcom/urbanairship/push/proto/Rpc$Response$Builder;");
				return Java.Lang.Object.GetObject<global::Com.Urbanairship.Push.Proto.Rpc.Response.Builder> (JNIEnv.CallObjectMethod  (Handle, id_toBuilder), JniHandleOwnership.TransferLocalRef);
			}

			static IntPtr id_writeTo_Lcom_google_protobuf_CodedOutputStream_;
			[Register ("writeTo", "(Lcom/google/protobuf/CodedOutputStream;)V", "")]
			public override void WriteTo (global::Com.Google.Protobuf.CodedOutputStream p0)
			{
				if (id_writeTo_Lcom_google_protobuf_CodedOutputStream_ == IntPtr.Zero)
					id_writeTo_Lcom_google_protobuf_CodedOutputStream_ = JNIEnv.GetMethodID (class_ref, "writeTo", "(Lcom/google/protobuf/CodedOutputStream;)V");
				JNIEnv.CallVoidMethod  (Handle, id_writeTo_Lcom_google_protobuf_CodedOutputStream_, new JValue (p0));
			}

		}

		[global::Android.Runtime.Register ("com/urbanairship/push/proto/Rpc$Status", DoNotGenerateAcw=true)]
		public sealed partial class Status : global::Java.Lang.Enum, global::Com.Google.Protobuf.Internal.IEnumLite {


			static IntPtr BAD_REQUEST_jfieldId;

			[Register ("BAD_REQUEST")]
			public static global::Com.Urbanairship.Push.Proto.Rpc.Status BadRequest {
				get {
					if (BAD_REQUEST_jfieldId == IntPtr.Zero)
						BAD_REQUEST_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "BAD_REQUEST", "Lcom/urbanairship/push/proto/Rpc$Status;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, BAD_REQUEST_jfieldId);
					return Java.Lang.Object.GetObject<global::Com.Urbanairship.Push.Proto.Rpc.Status> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (BAD_REQUEST_jfieldId == IntPtr.Zero)
						BAD_REQUEST_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "BAD_REQUEST", "Lcom/urbanairship/push/proto/Rpc$Status;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, BAD_REQUEST_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr METHOD_NOT_FOUND_jfieldId;

			[Register ("METHOD_NOT_FOUND")]
			public static global::Com.Urbanairship.Push.Proto.Rpc.Status MethodNotFound {
				get {
					if (METHOD_NOT_FOUND_jfieldId == IntPtr.Zero)
						METHOD_NOT_FOUND_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "METHOD_NOT_FOUND", "Lcom/urbanairship/push/proto/Rpc$Status;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, METHOD_NOT_FOUND_jfieldId);
					return Java.Lang.Object.GetObject<global::Com.Urbanairship.Push.Proto.Rpc.Status> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (METHOD_NOT_FOUND_jfieldId == IntPtr.Zero)
						METHOD_NOT_FOUND_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "METHOD_NOT_FOUND", "Lcom/urbanairship/push/proto/Rpc$Status;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, METHOD_NOT_FOUND_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr OK_jfieldId;

			[Register ("OK")]
			public static global::Com.Urbanairship.Push.Proto.Rpc.Status Ok {
				get {
					if (OK_jfieldId == IntPtr.Zero)
						OK_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "OK", "Lcom/urbanairship/push/proto/Rpc$Status;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, OK_jfieldId);
					return Java.Lang.Object.GetObject<global::Com.Urbanairship.Push.Proto.Rpc.Status> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (OK_jfieldId == IntPtr.Zero)
						OK_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "OK", "Lcom/urbanairship/push/proto/Rpc$Status;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, OK_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr RPC_ERROR_jfieldId;

			[Register ("RPC_ERROR")]
			public static global::Com.Urbanairship.Push.Proto.Rpc.Status RpcError {
				get {
					if (RPC_ERROR_jfieldId == IntPtr.Zero)
						RPC_ERROR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "RPC_ERROR", "Lcom/urbanairship/push/proto/Rpc$Status;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, RPC_ERROR_jfieldId);
					return Java.Lang.Object.GetObject<global::Com.Urbanairship.Push.Proto.Rpc.Status> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (RPC_ERROR_jfieldId == IntPtr.Zero)
						RPC_ERROR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "RPC_ERROR", "Lcom/urbanairship/push/proto/Rpc$Status;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, RPC_ERROR_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr TIMEOUT_jfieldId;

			[Register ("TIMEOUT")]
			public static global::Com.Urbanairship.Push.Proto.Rpc.Status Timeout {
				get {
					if (TIMEOUT_jfieldId == IntPtr.Zero)
						TIMEOUT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TIMEOUT", "Lcom/urbanairship/push/proto/Rpc$Status;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TIMEOUT_jfieldId);
					return Java.Lang.Object.GetObject<global::Com.Urbanairship.Push.Proto.Rpc.Status> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (TIMEOUT_jfieldId == IntPtr.Zero)
						TIMEOUT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TIMEOUT", "Lcom/urbanairship/push/proto/Rpc$Status;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, TIMEOUT_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/urbanairship/push/proto/Rpc$Status", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Status); }
			}

			internal Status (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_getNumber;
			public int Number {
				[Register ("getNumber", "()I", "GetGetNumberHandler")]
				get {
					if (id_getNumber == IntPtr.Zero)
						id_getNumber = JNIEnv.GetMethodID (class_ref, "getNumber", "()I");
					return JNIEnv.CallIntMethod  (Handle, id_getNumber);
				}
			}

			static IntPtr id_internalGetValueMap;
			[Register ("internalGetValueMap", "()Lcom/google/protobuf/Internal$EnumLiteMap;", "")]
			public static global::Com.Google.Protobuf.Internal.IEnumLiteMap InternalGetValueMap ()
			{
				if (id_internalGetValueMap == IntPtr.Zero)
					id_internalGetValueMap = JNIEnv.GetStaticMethodID (class_ref, "internalGetValueMap", "()Lcom/google/protobuf/Internal$EnumLiteMap;");
				return Java.Lang.Object.GetObject<global::Com.Google.Protobuf.Internal.IEnumLiteMap> (JNIEnv.CallStaticObjectMethod  (class_ref, id_internalGetValueMap), JniHandleOwnership.TransferLocalRef);
			}

			static IntPtr id_valueOf_I;
			[Register ("valueOf", "(I)Lcom/urbanairship/push/proto/Rpc$Status;", "")]
			public static global::Com.Urbanairship.Push.Proto.Rpc.Status ValueOf (int p0)
			{
				if (id_valueOf_I == IntPtr.Zero)
					id_valueOf_I = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(I)Lcom/urbanairship/push/proto/Rpc$Status;");
				return Java.Lang.Object.GetObject<global::Com.Urbanairship.Push.Proto.Rpc.Status> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_I, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			}

			static IntPtr id_valueOf_Ljava_lang_String_;
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/urbanairship/push/proto/Rpc$Status;", "")]
			public static global::Com.Urbanairship.Push.Proto.Rpc.Status ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/urbanairship/push/proto/Rpc$Status;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				global::Com.Urbanairship.Push.Proto.Rpc.Status __ret = Java.Lang.Object.GetObject<global::Com.Urbanairship.Push.Proto.Rpc.Status> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
				JNIEnv.DeleteLocalRef (native_p0);
				return __ret;
			}

			static IntPtr id_values;
			[Register ("values", "()[Lcom/urbanairship/push/proto/Rpc$Status;", "")]
			public static global::Com.Urbanairship.Push.Proto.Rpc.Status[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/urbanairship/push/proto/Rpc$Status;");
				return (Com.Urbanairship.Push.Proto.Rpc.Status[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Urbanairship.Push.Proto.Rpc.Status));
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/urbanairship/push/proto/Rpc", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Rpc); }
		}

		internal Rpc (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_internalForceInit;
		[Register ("internalForceInit", "()V", "")]
		public static void InternalForceInit ()
		{
			if (id_internalForceInit == IntPtr.Zero)
				id_internalForceInit = JNIEnv.GetStaticMethodID (class_ref, "internalForceInit", "()V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_internalForceInit);
		}

		static IntPtr id_registerAllExtensions_Lcom_google_protobuf_ExtensionRegistryLite_;
		[Register ("registerAllExtensions", "(Lcom/google/protobuf/ExtensionRegistryLite;)V", "")]
		public static void RegisterAllExtensions (global::Com.Google.Protobuf.ExtensionRegistryLite p0)
		{
			if (id_registerAllExtensions_Lcom_google_protobuf_ExtensionRegistryLite_ == IntPtr.Zero)
				id_registerAllExtensions_Lcom_google_protobuf_ExtensionRegistryLite_ = JNIEnv.GetStaticMethodID (class_ref, "registerAllExtensions", "(Lcom/google/protobuf/ExtensionRegistryLite;)V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_registerAllExtensions_Lcom_google_protobuf_ExtensionRegistryLite_, new JValue (p0));
		}

	}
}
