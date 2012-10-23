using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Urbanairship.Push.Proto {

	[global::Android.Runtime.Register ("com/urbanairship/push/proto/Messages", DoNotGenerateAcw=true)]
	public sealed partial class Messages : global::Java.Lang.Object {

		[global::Android.Runtime.Register ("com/urbanairship/push/proto/Messages$AirshipMethod", DoNotGenerateAcw=true)]
		public sealed partial class AirshipMethod : global::Java.Lang.Enum, global::Com.Google.Protobuf.Internal.IEnumLite {


			static IntPtr DEVICE_CONNECT_jfieldId;

			[Register ("DEVICE_CONNECT")]
			public static global::Com.Urbanairship.Push.Proto.Messages.AirshipMethod DeviceConnect {
				get {
					if (DEVICE_CONNECT_jfieldId == IntPtr.Zero)
						DEVICE_CONNECT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DEVICE_CONNECT", "Lcom/urbanairship/push/proto/Messages$AirshipMethod;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, DEVICE_CONNECT_jfieldId);
					return Java.Lang.Object.GetObject<global::Com.Urbanairship.Push.Proto.Messages.AirshipMethod> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (DEVICE_CONNECT_jfieldId == IntPtr.Zero)
						DEVICE_CONNECT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DEVICE_CONNECT", "Lcom/urbanairship/push/proto/Messages$AirshipMethod;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, DEVICE_CONNECT_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr ECHO_jfieldId;

			[Register ("ECHO")]
			public static global::Com.Urbanairship.Push.Proto.Messages.AirshipMethod Echo {
				get {
					if (ECHO_jfieldId == IntPtr.Zero)
						ECHO_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ECHO", "Lcom/urbanairship/push/proto/Messages$AirshipMethod;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ECHO_jfieldId);
					return Java.Lang.Object.GetObject<global::Com.Urbanairship.Push.Proto.Messages.AirshipMethod> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (ECHO_jfieldId == IntPtr.Zero)
						ECHO_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ECHO", "Lcom/urbanairship/push/proto/Messages$AirshipMethod;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, ECHO_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr HELLO_jfieldId;

			[Register ("HELLO")]
			public static global::Com.Urbanairship.Push.Proto.Messages.AirshipMethod Hello {
				get {
					if (HELLO_jfieldId == IntPtr.Zero)
						HELLO_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "HELLO", "Lcom/urbanairship/push/proto/Messages$AirshipMethod;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, HELLO_jfieldId);
					return Java.Lang.Object.GetObject<global::Com.Urbanairship.Push.Proto.Messages.AirshipMethod> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (HELLO_jfieldId == IntPtr.Zero)
						HELLO_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "HELLO", "Lcom/urbanairship/push/proto/Messages$AirshipMethod;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, HELLO_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr PUSH_NOTIFICATION_jfieldId;

			[Register ("PUSH_NOTIFICATION")]
			public static global::Com.Urbanairship.Push.Proto.Messages.AirshipMethod PushNotification {
				get {
					if (PUSH_NOTIFICATION_jfieldId == IntPtr.Zero)
						PUSH_NOTIFICATION_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PUSH_NOTIFICATION", "Lcom/urbanairship/push/proto/Messages$AirshipMethod;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, PUSH_NOTIFICATION_jfieldId);
					return Java.Lang.Object.GetObject<global::Com.Urbanairship.Push.Proto.Messages.AirshipMethod> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (PUSH_NOTIFICATION_jfieldId == IntPtr.Zero)
						PUSH_NOTIFICATION_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PUSH_NOTIFICATION", "Lcom/urbanairship/push/proto/Messages$AirshipMethod;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, PUSH_NOTIFICATION_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr REGISTER_jfieldId;

			[Register ("REGISTER")]
			public static global::Com.Urbanairship.Push.Proto.Messages.AirshipMethod Register {
				get {
					if (REGISTER_jfieldId == IntPtr.Zero)
						REGISTER_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "REGISTER", "Lcom/urbanairship/push/proto/Messages$AirshipMethod;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, REGISTER_jfieldId);
					return Java.Lang.Object.GetObject<global::Com.Urbanairship.Push.Proto.Messages.AirshipMethod> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (REGISTER_jfieldId == IntPtr.Zero)
						REGISTER_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "REGISTER", "Lcom/urbanairship/push/proto/Messages$AirshipMethod;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, REGISTER_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/urbanairship/push/proto/Messages$AirshipMethod", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (AirshipMethod); }
			}

			internal AirshipMethod (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

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
			[Register ("valueOf", "(I)Lcom/urbanairship/push/proto/Messages$AirshipMethod;", "")]
			public static global::Com.Urbanairship.Push.Proto.Messages.AirshipMethod ValueOf (int p0)
			{
				if (id_valueOf_I == IntPtr.Zero)
					id_valueOf_I = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(I)Lcom/urbanairship/push/proto/Messages$AirshipMethod;");
				return Java.Lang.Object.GetObject<global::Com.Urbanairship.Push.Proto.Messages.AirshipMethod> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_I, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			}

			static IntPtr id_valueOf_Ljava_lang_String_;
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/urbanairship/push/proto/Messages$AirshipMethod;", "")]
			public static global::Com.Urbanairship.Push.Proto.Messages.AirshipMethod ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/urbanairship/push/proto/Messages$AirshipMethod;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				global::Com.Urbanairship.Push.Proto.Messages.AirshipMethod __ret = Java.Lang.Object.GetObject<global::Com.Urbanairship.Push.Proto.Messages.AirshipMethod> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
				JNIEnv.DeleteLocalRef (native_p0);
				return __ret;
			}

			static IntPtr id_values;
			[Register ("values", "()[Lcom/urbanairship/push/proto/Messages$AirshipMethod;", "")]
			public static global::Com.Urbanairship.Push.Proto.Messages.AirshipMethod[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/urbanairship/push/proto/Messages$AirshipMethod;");
				return (Com.Urbanairship.Push.Proto.Messages.AirshipMethod[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Urbanairship.Push.Proto.Messages.AirshipMethod));
			}

		}

		[global::Android.Runtime.Register ("com/urbanairship/push/proto/Messages$DeviceConnect", DoNotGenerateAcw=true)]
		public sealed partial class DeviceConnect : global::Com.Google.Protobuf.GeneratedMessageLite {


			[Register ("DEVICE_ID_FIELD_NUMBER")]
			public const int DeviceIdFieldNumber = (int) 1;
			[global::Android.Runtime.Register ("com/urbanairship/push/proto/Messages$DeviceConnect$Builder", DoNotGenerateAcw=true)]
			public new sealed partial class Builder : global::Com.Google.Protobuf.GeneratedMessageLite.Builder {

				internal static IntPtr java_class_handle;
				internal static IntPtr class_ref {
					get {
						return JNIEnv.FindClass ("com/urbanairship/push/proto/Messages$DeviceConnect$Builder", ref java_class_handle);
					}
				}

				protected override IntPtr ThresholdClass {
					get { return class_ref; }
				}

				protected override global::System.Type ThresholdType {
					get { return typeof (Builder); }
				}

				internal Builder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

				static IntPtr id_getDefaultInstanceForType;
				public override global::Com.Urbanairship.Push.Proto.Messages.DeviceConnect DefaultInstanceForType {
					[Register ("getDefaultInstanceForType", "()Lcom/urbanairship/push/proto/Messages$DeviceConnect;", "GetGetDefaultInstanceForTypeHandler")]
					get {
						if (id_getDefaultInstanceForType == IntPtr.Zero)
							id_getDefaultInstanceForType = JNIEnv.GetMethodID (class_ref, "getDefaultInstanceForType", "()Lcom/urbanairship/push/proto/Messages$DeviceConnect;");
						return Java.Lang.Object.GetObject<global::Com.Urbanairship.Push.Proto.Messages.DeviceConnect> (JNIEnv.CallObjectMethod  (Handle, id_getDefaultInstanceForType), JniHandleOwnership.TransferLocalRef);
					}
				}

				static IntPtr id_getDeviceId;
				public string DeviceId {
					[Register ("getDeviceId", "()Ljava/lang/String;", "GetGetDeviceIdHandler")]
					get {
						if (id_getDeviceId == IntPtr.Zero)
							id_getDeviceId = JNIEnv.GetMethodID (class_ref, "getDeviceId", "()Ljava/lang/String;");
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getDeviceId), JniHandleOwnership.TransferLocalRef);
					}
				}

				static IntPtr id_hasDeviceId;
				public bool HasDeviceId {
					[Register ("hasDeviceId", "()Z", "GetHasDeviceIdHandler")]
					get {
						if (id_hasDeviceId == IntPtr.Zero)
							id_hasDeviceId = JNIEnv.GetMethodID (class_ref, "hasDeviceId", "()Z");
						return JNIEnv.CallBooleanMethod  (Handle, id_hasDeviceId);
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

				static IntPtr id_build;
				[Register ("build", "()Lcom/urbanairship/push/proto/Messages$DeviceConnect;", "")]
				public global::Com.Urbanairship.Push.Proto.Messages.DeviceConnect Build ()
				{
					if (id_build == IntPtr.Zero)
						id_build = JNIEnv.GetMethodID (class_ref, "build", "()Lcom/urbanairship/push/proto/Messages$DeviceConnect;");
					return Java.Lang.Object.GetObject<global::Com.Urbanairship.Push.Proto.Messages.DeviceConnect> (JNIEnv.CallObjectMethod  (Handle, id_build), JniHandleOwnership.TransferLocalRef);
				}

				static IntPtr id_buildPartial;
				[Register ("buildPartial", "()Lcom/urbanairship/push/proto/Messages$DeviceConnect;", "")]
				public global::Com.Urbanairship.Push.Proto.Messages.DeviceConnect BuildPartial ()
				{
					if (id_buildPartial == IntPtr.Zero)
						id_buildPartial = JNIEnv.GetMethodID (class_ref, "buildPartial", "()Lcom/urbanairship/push/proto/Messages$DeviceConnect;");
					return Java.Lang.Object.GetObject<global::Com.Urbanairship.Push.Proto.Messages.DeviceConnect> (JNIEnv.CallObjectMethod  (Handle, id_buildPartial), JniHandleOwnership.TransferLocalRef);
				}

				static IntPtr id_clear;
				[Register ("clear", "()Lcom/urbanairship/push/proto/Messages$DeviceConnect$Builder;", "")]
				public global::Com.Urbanairship.Push.Proto.Messages.DeviceConnect.Builder Clear ()
				{
					if (id_clear == IntPtr.Zero)
						id_clear = JNIEnv.GetMethodID (class_ref, "clear", "()Lcom/urbanairship/push/proto/Messages$DeviceConnect$Builder;");
					return Java.Lang.Object.GetObject<global::Com.Urbanairship.Push.Proto.Messages.DeviceConnect.Builder> (JNIEnv.CallObjectMethod  (Handle, id_clear), JniHandleOwnership.TransferLocalRef);
				}

				static IntPtr id_clearDeviceId;
				[Register ("clearDeviceId", "()Lcom/urbanairship/push/proto/Messages$DeviceConnect$Builder;", "")]
				public global::Com.Urbanairship.Push.Proto.Messages.DeviceConnect.Builder ClearDeviceId ()
				{
					if (id_clearDeviceId == IntPtr.Zero)
						id_clearDeviceId = JNIEnv.GetMethodID (class_ref, "clearDeviceId", "()Lcom/urbanairship/push/proto/Messages$DeviceConnect$Builder;");
					return Java.Lang.Object.GetObject<global::Com.Urbanairship.Push.Proto.Messages.DeviceConnect.Builder> (JNIEnv.CallObjectMethod  (Handle, id_clearDeviceId), JniHandleOwnership.TransferLocalRef);
				}

				static IntPtr id_internalGetResult;
				[Register ("internalGetResult", "()Lcom/urbanairship/push/proto/Messages$DeviceConnect;", "")]
				protected override global::Com.Urbanairship.Push.Proto.Messages.DeviceConnect InternalGetResult ()
				{
					if (id_internalGetResult == IntPtr.Zero)
						id_internalGetResult = JNIEnv.GetMethodID (class_ref, "internalGetResult", "()Lcom/urbanairship/push/proto/Messages$DeviceConnect;");
					return Java.Lang.Object.GetObject<global::Com.Urbanairship.Push.Proto.Messages.DeviceConnect> (JNIEnv.CallObjectMethod  (Handle, id_internalGetResult), JniHandleOwnership.TransferLocalRef);
				}

				static IntPtr id_mergeFrom_Lcom_google_protobuf_CodedInputStream_Lcom_google_protobuf_ExtensionRegistryLite_;
				[Register ("mergeFrom", "(Lcom/google/protobuf/CodedInputStream;Lcom/google/protobuf/ExtensionRegistryLite;)Lcom/urbanairship/push/proto/Messages$DeviceConnect$Builder;", "")]
				public override global::Com.Urbanairship.Push.Proto.Messages.DeviceConnect.Builder MergeFrom (global::Com.Google.Protobuf.CodedInputStream p0, global::Com.Google.Protobuf.ExtensionRegistryLite p1)
				{
					if (id_mergeFrom_Lcom_google_protobuf_CodedInputStream_Lcom_google_protobuf_ExtensionRegistryLite_ == IntPtr.Zero)
						id_mergeFrom_Lcom_google_protobuf_CodedInputStream_Lcom_google_protobuf_ExtensionRegistryLite_ = JNIEnv.GetMethodID (class_ref, "mergeFrom", "(Lcom/google/protobuf/CodedInputStream;Lcom/google/protobuf/ExtensionRegistryLite;)Lcom/urbanairship/push/proto/Messages$DeviceConnect$Builder;");
					global::Com.Urbanairship.Push.Proto.Messages.DeviceConnect.Builder __ret = Java.Lang.Object.GetObject<global::Com.Urbanairship.Push.Proto.Messages.DeviceConnect.Builder> (JNIEnv.CallObjectMethod  (Handle, id_mergeFrom_Lcom_google_protobuf_CodedInputStream_Lcom_google_protobuf_ExtensionRegistryLite_, new JValue (p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
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

				static IntPtr id_mergeFrom_Lcom_urbanairship_push_proto_Messages_DeviceConnect_;
				[Register ("mergeFrom", "(Lcom/urbanairship/push/proto/Messages$DeviceConnect;)Lcom/urbanairship/push/proto/Messages$DeviceConnect$Builder;", "")]
				public global::Com.Urbanairship.Push.Proto.Messages.DeviceConnect.Builder MergeFrom (global::Com.Urbanairship.Push.Proto.Messages.DeviceConnect p0)
				{
					if (id_mergeFrom_Lcom_urbanairship_push_proto_Messages_DeviceConnect_ == IntPtr.Zero)
						id_mergeFrom_Lcom_urbanairship_push_proto_Messages_DeviceConnect_ = JNIEnv.GetMethodID (class_ref, "mergeFrom", "(Lcom/urbanairship/push/proto/Messages$DeviceConnect;)Lcom/urbanairship/push/proto/Messages$DeviceConnect$Builder;");
					global::Com.Urbanairship.Push.Proto.Messages.DeviceConnect.Builder __ret = Java.Lang.Object.GetObject<global::Com.Urbanairship.Push.Proto.Messages.DeviceConnect.Builder> (JNIEnv.CallObjectMethod  (Handle, id_mergeFrom_Lcom_urbanairship_push_proto_Messages_DeviceConnect_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
					return __ret;
				}

				static IntPtr id_setDeviceId_Ljava_lang_String_;
				[Register ("setDeviceId", "(Ljava/lang/String;)Lcom/urbanairship/push/proto/Messages$DeviceConnect$Builder;", "")]
				public global::Com.Urbanairship.Push.Proto.Messages.DeviceConnect.Builder SetDeviceId (string p0)
				{
					if (id_setDeviceId_Ljava_lang_String_ == IntPtr.Zero)
						id_setDeviceId_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setDeviceId", "(Ljava/lang/String;)Lcom/urbanairship/push/proto/Messages$DeviceConnect$Builder;");
					IntPtr native_p0 = JNIEnv.NewString (p0);
					global::Com.Urbanairship.Push.Proto.Messages.DeviceConnect.Builder __ret = Java.Lang.Object.GetObject<global::Com.Urbanairship.Push.Proto.Messages.DeviceConnect.Builder> (JNIEnv.CallObjectMethod  (Handle, id_setDeviceId_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
					JNIEnv.DeleteLocalRef (native_p0);
					return __ret;
				}

			}

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/urbanairship/push/proto/Messages$DeviceConnect", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (DeviceConnect); }
			}

			internal DeviceConnect (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_getDefaultInstance;
			public static global::Com.Urbanairship.Push.Proto.Messages.DeviceConnect DefaultInstance {
				[Register ("getDefaultInstance", "()Lcom/urbanairship/push/proto/Messages$DeviceConnect;", "GetGetDefaultInstanceHandler")]
				get {
					if (id_getDefaultInstance == IntPtr.Zero)
						id_getDefaultInstance = JNIEnv.GetStaticMethodID (class_ref, "getDefaultInstance", "()Lcom/urbanairship/push/proto/Messages$DeviceConnect;");
					return Java.Lang.Object.GetObject<global::Com.Urbanairship.Push.Proto.Messages.DeviceConnect> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getDefaultInstance), JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr id_getDefaultInstanceForType;
			public override global::Com.Urbanairship.Push.Proto.Messages.DeviceConnect DefaultInstanceForType {
				[Register ("getDefaultInstanceForType", "()Lcom/urbanairship/push/proto/Messages$DeviceConnect;", "GetGetDefaultInstanceForTypeHandler")]
				get {
					if (id_getDefaultInstanceForType == IntPtr.Zero)
						id_getDefaultInstanceForType = JNIEnv.GetMethodID (class_ref, "getDefaultInstanceForType", "()Lcom/urbanairship/push/proto/Messages$DeviceConnect;");
					return Java.Lang.Object.GetObject<global::Com.Urbanairship.Push.Proto.Messages.DeviceConnect> (JNIEnv.CallObjectMethod  (Handle, id_getDefaultInstanceForType), JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr id_getDeviceId;
			public string DeviceId {
				[Register ("getDeviceId", "()Ljava/lang/String;", "GetGetDeviceIdHandler")]
				get {
					if (id_getDeviceId == IntPtr.Zero)
						id_getDeviceId = JNIEnv.GetMethodID (class_ref, "getDeviceId", "()Ljava/lang/String;");
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getDeviceId), JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr id_hasDeviceId;
			public bool HasDeviceId {
				[Register ("hasDeviceId", "()Z", "GetHasDeviceIdHandler")]
				get {
					if (id_hasDeviceId == IntPtr.Zero)
						id_hasDeviceId = JNIEnv.GetMethodID (class_ref, "hasDeviceId", "()Z");
					return JNIEnv.CallBooleanMethod  (Handle, id_hasDeviceId);
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
			[Register ("newBuilder", "()Lcom/urbanairship/push/proto/Messages$DeviceConnect$Builder;", "")]
			public static global::Com.Urbanairship.Push.Proto.Messages.DeviceConnect.Builder NewBuilder ()
			{
				if (id_newBuilder == IntPtr.Zero)
					id_newBuilder = JNIEnv.GetStaticMethodID (class_ref, "newBuilder", "()Lcom/urbanairship/push/proto/Messages$DeviceConnect$Builder;");
				return Java.Lang.Object.GetObject<global::Com.Urbanairship.Push.Proto.Messages.DeviceConnect.Builder> (JNIEnv.CallStaticObjectMethod  (class_ref, id_newBuilder), JniHandleOwnership.TransferLocalRef);
			}

			static IntPtr id_newBuilder_Lcom_urbanairship_push_proto_Messages_DeviceConnect_;
			[Register ("newBuilder", "(Lcom/urbanairship/push/proto/Messages$DeviceConnect;)Lcom/urbanairship/push/proto/Messages$DeviceConnect$Builder;", "")]
			public static global::Com.Urbanairship.Push.Proto.Messages.DeviceConnect.Builder NewBuilder (global::Com.Urbanairship.Push.Proto.Messages.DeviceConnect p0)
			{
				if (id_newBuilder_Lcom_urbanairship_push_proto_Messages_DeviceConnect_ == IntPtr.Zero)
					id_newBuilder_Lcom_urbanairship_push_proto_Messages_DeviceConnect_ = JNIEnv.GetStaticMethodID (class_ref, "newBuilder", "(Lcom/urbanairship/push/proto/Messages$DeviceConnect;)Lcom/urbanairship/push/proto/Messages$DeviceConnect$Builder;");
				global::Com.Urbanairship.Push.Proto.Messages.DeviceConnect.Builder __ret = Java.Lang.Object.GetObject<global::Com.Urbanairship.Push.Proto.Messages.DeviceConnect.Builder> (JNIEnv.CallStaticObjectMethod  (class_ref, id_newBuilder_Lcom_urbanairship_push_proto_Messages_DeviceConnect_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
				return __ret;
			}

			static IntPtr id_newBuilderForType;
			[Register ("newBuilderForType", "()Lcom/urbanairship/push/proto/Messages$DeviceConnect$Builder;", "")]
			public global::Com.Urbanairship.Push.Proto.Messages.DeviceConnect.Builder NewBuilderForType ()
			{
				if (id_newBuilderForType == IntPtr.Zero)
					id_newBuilderForType = JNIEnv.GetMethodID (class_ref, "newBuilderForType", "()Lcom/urbanairship/push/proto/Messages$DeviceConnect$Builder;");
				return Java.Lang.Object.GetObject<global::Com.Urbanairship.Push.Proto.Messages.DeviceConnect.Builder> (JNIEnv.CallObjectMethod  (Handle, id_newBuilderForType), JniHandleOwnership.TransferLocalRef);
			}

			static IntPtr id_parseDelimitedFrom_Ljava_io_InputStream_;
			[Register ("parseDelimitedFrom", "(Ljava/io/InputStream;)Lcom/urbanairship/push/proto/Messages$DeviceConnect;", "")]
			public static global::Com.Urbanairship.Push.Proto.Messages.DeviceConnect ParseDelimitedFrom (global::System.IO.Stream p0)
			{
				if (id_parseDelimitedFrom_Ljava_io_InputStream_ == IntPtr.Zero)
					id_parseDelimitedFrom_Ljava_io_InputStream_ = JNIEnv.GetStaticMethodID (class_ref, "parseDelimitedFrom", "(Ljava/io/InputStream;)Lcom/urbanairship/push/proto/Messages$DeviceConnect;");
				IntPtr native_p0 = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (p0);
				global::Com.Urbanairship.Push.Proto.Messages.DeviceConnect __ret = Java.Lang.Object.GetObject<global::Com.Urbanairship.Push.Proto.Messages.DeviceConnect> (JNIEnv.CallStaticObjectMethod  (class_ref, id_parseDelimitedFrom_Ljava_io_InputStream_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
				JNIEnv.DeleteLocalRef (native_p0);
				return __ret;
			}

			static IntPtr id_parseDelimitedFrom_Ljava_io_InputStream_Lcom_google_protobuf_ExtensionRegistryLite_;
			[Register ("parseDelimitedFrom", "(Ljava/io/InputStream;Lcom/google/protobuf/ExtensionRegistryLite;)Lcom/urbanairship/push/proto/Messages$DeviceConnect;", "")]
			public static global::Com.Urbanairship.Push.Proto.Messages.DeviceConnect ParseDelimitedFrom (global::System.IO.Stream p0, global::Com.Google.Protobuf.ExtensionRegistryLite p1)
			{
				if (id_parseDelimitedFrom_Ljava_io_InputStream_Lcom_google_protobuf_ExtensionRegistryLite_ == IntPtr.Zero)
					id_parseDelimitedFrom_Ljava_io_InputStream_Lcom_google_protobuf_ExtensionRegistryLite_ = JNIEnv.GetStaticMethodID (class_ref, "parseDelimitedFrom", "(Ljava/io/InputStream;Lcom/google/protobuf/ExtensionRegistryLite;)Lcom/urbanairship/push/proto/Messages$DeviceConnect;");
				IntPtr native_p0 = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (p0);
				global::Com.Urbanairship.Push.Proto.Messages.DeviceConnect __ret = Java.Lang.Object.GetObject<global::Com.Urbanairship.Push.Proto.Messages.DeviceConnect> (JNIEnv.CallStaticObjectMethod  (class_ref, id_parseDelimitedFrom_Ljava_io_InputStream_Lcom_google_protobuf_ExtensionRegistryLite_, new JValue (native_p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
				JNIEnv.DeleteLocalRef (native_p0);
				return __ret;
			}

			static IntPtr id_parseFrom_arrayB;
			[Register ("parseFrom", "([B)Lcom/urbanairship/push/proto/Messages$DeviceConnect;", "")]
			public static global::Com.Urbanairship.Push.Proto.Messages.DeviceConnect ParseFrom (byte[] p0)
			{
				if (id_parseFrom_arrayB == IntPtr.Zero)
					id_parseFrom_arrayB = JNIEnv.GetStaticMethodID (class_ref, "parseFrom", "([B)Lcom/urbanairship/push/proto/Messages$DeviceConnect;");
				IntPtr native_p0 = JNIEnv.NewArray (p0);
				global::Com.Urbanairship.Push.Proto.Messages.DeviceConnect __ret = Java.Lang.Object.GetObject<global::Com.Urbanairship.Push.Proto.Messages.DeviceConnect> (JNIEnv.CallStaticObjectMethod  (class_ref, id_parseFrom_arrayB, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				return __ret;
			}

			static IntPtr id_parseFrom_arrayBLcom_google_protobuf_ExtensionRegistryLite_;
			[Register ("parseFrom", "([BLcom/google/protobuf/ExtensionRegistryLite;)Lcom/urbanairship/push/proto/Messages$DeviceConnect;", "")]
			public static global::Com.Urbanairship.Push.Proto.Messages.DeviceConnect ParseFrom (byte[] p0, global::Com.Google.Protobuf.ExtensionRegistryLite p1)
			{
				if (id_parseFrom_arrayBLcom_google_protobuf_ExtensionRegistryLite_ == IntPtr.Zero)
					id_parseFrom_arrayBLcom_google_protobuf_ExtensionRegistryLite_ = JNIEnv.GetStaticMethodID (class_ref, "parseFrom", "([BLcom/google/protobuf/ExtensionRegistryLite;)Lcom/urbanairship/push/proto/Messages$DeviceConnect;");
				IntPtr native_p0 = JNIEnv.NewArray (p0);
				global::Com.Urbanairship.Push.Proto.Messages.DeviceConnect __ret = Java.Lang.Object.GetObject<global::Com.Urbanairship.Push.Proto.Messages.DeviceConnect> (JNIEnv.CallStaticObjectMethod  (class_ref, id_parseFrom_arrayBLcom_google_protobuf_ExtensionRegistryLite_, new JValue (native_p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				return __ret;
			}

			static IntPtr id_parseFrom_Lcom_google_protobuf_ByteString_;
			[Register ("parseFrom", "(Lcom/google/protobuf/ByteString;)Lcom/urbanairship/push/proto/Messages$DeviceConnect;", "")]
			public static global::Com.Urbanairship.Push.Proto.Messages.DeviceConnect ParseFrom (global::Com.Google.Protobuf.ByteString p0)
			{
				if (id_parseFrom_Lcom_google_protobuf_ByteString_ == IntPtr.Zero)
					id_parseFrom_Lcom_google_protobuf_ByteString_ = JNIEnv.GetStaticMethodID (class_ref, "parseFrom", "(Lcom/google/protobuf/ByteString;)Lcom/urbanairship/push/proto/Messages$DeviceConnect;");
				global::Com.Urbanairship.Push.Proto.Messages.DeviceConnect __ret = Java.Lang.Object.GetObject<global::Com.Urbanairship.Push.Proto.Messages.DeviceConnect> (JNIEnv.CallStaticObjectMethod  (class_ref, id_parseFrom_Lcom_google_protobuf_ByteString_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
				return __ret;
			}

			static IntPtr id_parseFrom_Lcom_google_protobuf_ByteString_Lcom_google_protobuf_ExtensionRegistryLite_;
			[Register ("parseFrom", "(Lcom/google/protobuf/ByteString;Lcom/google/protobuf/ExtensionRegistryLite;)Lcom/urbanairship/push/proto/Messages$DeviceConnect;", "")]
			public static global::Com.Urbanairship.Push.Proto.Messages.DeviceConnect ParseFrom (global::Com.Google.Protobuf.ByteString p0, global::Com.Google.Protobuf.ExtensionRegistryLite p1)
			{
				if (id_parseFrom_Lcom_google_protobuf_ByteString_Lcom_google_protobuf_ExtensionRegistryLite_ == IntPtr.Zero)
					id_parseFrom_Lcom_google_protobuf_ByteString_Lcom_google_protobuf_ExtensionRegistryLite_ = JNIEnv.GetStaticMethodID (class_ref, "parseFrom", "(Lcom/google/protobuf/ByteString;Lcom/google/protobuf/ExtensionRegistryLite;)Lcom/urbanairship/push/proto/Messages$DeviceConnect;");
				global::Com.Urbanairship.Push.Proto.Messages.DeviceConnect __ret = Java.Lang.Object.GetObject<global::Com.Urbanairship.Push.Proto.Messages.DeviceConnect> (JNIEnv.CallStaticObjectMethod  (class_ref, id_parseFrom_Lcom_google_protobuf_ByteString_Lcom_google_protobuf_ExtensionRegistryLite_, new JValue (p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
				return __ret;
			}

			static IntPtr id_parseFrom_Lcom_google_protobuf_CodedInputStream_;
			[Register ("parseFrom", "(Lcom/google/protobuf/CodedInputStream;)Lcom/urbanairship/push/proto/Messages$DeviceConnect;", "")]
			public static global::Com.Urbanairship.Push.Proto.Messages.DeviceConnect ParseFrom (global::Com.Google.Protobuf.CodedInputStream p0)
			{
				if (id_parseFrom_Lcom_google_protobuf_CodedInputStream_ == IntPtr.Zero)
					id_parseFrom_Lcom_google_protobuf_CodedInputStream_ = JNIEnv.GetStaticMethodID (class_ref, "parseFrom", "(Lcom/google/protobuf/CodedInputStream;)Lcom/urbanairship/push/proto/Messages$DeviceConnect;");
				global::Com.Urbanairship.Push.Proto.Messages.DeviceConnect __ret = Java.Lang.Object.GetObject<global::Com.Urbanairship.Push.Proto.Messages.DeviceConnect> (JNIEnv.CallStaticObjectMethod  (class_ref, id_parseFrom_Lcom_google_protobuf_CodedInputStream_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
				return __ret;
			}

			static IntPtr id_parseFrom_Lcom_google_protobuf_CodedInputStream_Lcom_google_protobuf_ExtensionRegistryLite_;
			[Register ("parseFrom", "(Lcom/google/protobuf/CodedInputStream;Lcom/google/protobuf/ExtensionRegistryLite;)Lcom/urbanairship/push/proto/Messages$DeviceConnect;", "")]
			public static global::Com.Urbanairship.Push.Proto.Messages.DeviceConnect ParseFrom (global::Com.Google.Protobuf.CodedInputStream p0, global::Com.Google.Protobuf.ExtensionRegistryLite p1)
			{
				if (id_parseFrom_Lcom_google_protobuf_CodedInputStream_Lcom_google_protobuf_ExtensionRegistryLite_ == IntPtr.Zero)
					id_parseFrom_Lcom_google_protobuf_CodedInputStream_Lcom_google_protobuf_ExtensionRegistryLite_ = JNIEnv.GetStaticMethodID (class_ref, "parseFrom", "(Lcom/google/protobuf/CodedInputStream;Lcom/google/protobuf/ExtensionRegistryLite;)Lcom/urbanairship/push/proto/Messages$DeviceConnect;");
				global::Com.Urbanairship.Push.Proto.Messages.DeviceConnect __ret = Java.Lang.Object.GetObject<global::Com.Urbanairship.Push.Proto.Messages.DeviceConnect> (JNIEnv.CallStaticObjectMethod  (class_ref, id_parseFrom_Lcom_google_protobuf_CodedInputStream_Lcom_google_protobuf_ExtensionRegistryLite_, new JValue (p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
				return __ret;
			}

			static IntPtr id_parseFrom_Ljava_io_InputStream_;
			[Register ("parseFrom", "(Ljava/io/InputStream;)Lcom/urbanairship/push/proto/Messages$DeviceConnect;", "")]
			public static global::Com.Urbanairship.Push.Proto.Messages.DeviceConnect ParseFrom (global::System.IO.Stream p0)
			{
				if (id_parseFrom_Ljava_io_InputStream_ == IntPtr.Zero)
					id_parseFrom_Ljava_io_InputStream_ = JNIEnv.GetStaticMethodID (class_ref, "parseFrom", "(Ljava/io/InputStream;)Lcom/urbanairship/push/proto/Messages$DeviceConnect;");
				IntPtr native_p0 = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (p0);
				global::Com.Urbanairship.Push.Proto.Messages.DeviceConnect __ret = Java.Lang.Object.GetObject<global::Com.Urbanairship.Push.Proto.Messages.DeviceConnect> (JNIEnv.CallStaticObjectMethod  (class_ref, id_parseFrom_Ljava_io_InputStream_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
				JNIEnv.DeleteLocalRef (native_p0);
				return __ret;
			}

			static IntPtr id_parseFrom_Ljava_io_InputStream_Lcom_google_protobuf_ExtensionRegistryLite_;
			[Register ("parseFrom", "(Ljava/io/InputStream;Lcom/google/protobuf/ExtensionRegistryLite;)Lcom/urbanairship/push/proto/Messages$DeviceConnect;", "")]
			public static global::Com.Urbanairship.Push.Proto.Messages.DeviceConnect ParseFrom (global::System.IO.Stream p0, global::Com.Google.Protobuf.ExtensionRegistryLite p1)
			{
				if (id_parseFrom_Ljava_io_InputStream_Lcom_google_protobuf_ExtensionRegistryLite_ == IntPtr.Zero)
					id_parseFrom_Ljava_io_InputStream_Lcom_google_protobuf_ExtensionRegistryLite_ = JNIEnv.GetStaticMethodID (class_ref, "parseFrom", "(Ljava/io/InputStream;Lcom/google/protobuf/ExtensionRegistryLite;)Lcom/urbanairship/push/proto/Messages$DeviceConnect;");
				IntPtr native_p0 = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (p0);
				global::Com.Urbanairship.Push.Proto.Messages.DeviceConnect __ret = Java.Lang.Object.GetObject<global::Com.Urbanairship.Push.Proto.Messages.DeviceConnect> (JNIEnv.CallStaticObjectMethod  (class_ref, id_parseFrom_Ljava_io_InputStream_Lcom_google_protobuf_ExtensionRegistryLite_, new JValue (native_p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
				JNIEnv.DeleteLocalRef (native_p0);
				return __ret;
			}

			static IntPtr id_toBuilder;
			[Register ("toBuilder", "()Lcom/urbanairship/push/proto/Messages$DeviceConnect$Builder;", "")]
			public global::Com.Urbanairship.Push.Proto.Messages.DeviceConnect.Builder ToBuilder ()
			{
				if (id_toBuilder == IntPtr.Zero)
					id_toBuilder = JNIEnv.GetMethodID (class_ref, "toBuilder", "()Lcom/urbanairship/push/proto/Messages$DeviceConnect$Builder;");
				return Java.Lang.Object.GetObject<global::Com.Urbanairship.Push.Proto.Messages.DeviceConnect.Builder> (JNIEnv.CallObjectMethod  (Handle, id_toBuilder), JniHandleOwnership.TransferLocalRef);
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

		[global::Android.Runtime.Register ("com/urbanairship/push/proto/Messages$Hello", DoNotGenerateAcw=true)]
		public sealed partial class Hello : global::Com.Google.Protobuf.GeneratedMessageLite {


			[Register ("MESSAGE_FIELD_NUMBER")]
			public const int MessageFieldNumber = (int) 1;
			[global::Android.Runtime.Register ("com/urbanairship/push/proto/Messages$Hello$Builder", DoNotGenerateAcw=true)]
			public new sealed partial class Builder : global::Com.Google.Protobuf.GeneratedMessageLite.Builder {

				internal static IntPtr java_class_handle;
				internal static IntPtr class_ref {
					get {
						return JNIEnv.FindClass ("com/urbanairship/push/proto/Messages$Hello$Builder", ref java_class_handle);
					}
				}

				protected override IntPtr ThresholdClass {
					get { return class_ref; }
				}

				protected override global::System.Type ThresholdType {
					get { return typeof (Builder); }
				}

				internal Builder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

				static IntPtr id_getDefaultInstanceForType;
				public override global::Com.Urbanairship.Push.Proto.Messages.Hello DefaultInstanceForType {
					[Register ("getDefaultInstanceForType", "()Lcom/urbanairship/push/proto/Messages$Hello;", "GetGetDefaultInstanceForTypeHandler")]
					get {
						if (id_getDefaultInstanceForType == IntPtr.Zero)
							id_getDefaultInstanceForType = JNIEnv.GetMethodID (class_ref, "getDefaultInstanceForType", "()Lcom/urbanairship/push/proto/Messages$Hello;");
						return Java.Lang.Object.GetObject<global::Com.Urbanairship.Push.Proto.Messages.Hello> (JNIEnv.CallObjectMethod  (Handle, id_getDefaultInstanceForType), JniHandleOwnership.TransferLocalRef);
					}
				}

				static IntPtr id_hasMessage;
				public bool HasMessage {
					[Register ("hasMessage", "()Z", "GetHasMessageHandler")]
					get {
						if (id_hasMessage == IntPtr.Zero)
							id_hasMessage = JNIEnv.GetMethodID (class_ref, "hasMessage", "()Z");
						return JNIEnv.CallBooleanMethod  (Handle, id_hasMessage);
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

				static IntPtr id_getMessage;
				public string Message {
					[Register ("getMessage", "()Ljava/lang/String;", "GetGetMessageHandler")]
					get {
						if (id_getMessage == IntPtr.Zero)
							id_getMessage = JNIEnv.GetMethodID (class_ref, "getMessage", "()Ljava/lang/String;");
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getMessage), JniHandleOwnership.TransferLocalRef);
					}
				}

				static IntPtr id_build;
				[Register ("build", "()Lcom/urbanairship/push/proto/Messages$Hello;", "")]
				public global::Com.Urbanairship.Push.Proto.Messages.Hello Build ()
				{
					if (id_build == IntPtr.Zero)
						id_build = JNIEnv.GetMethodID (class_ref, "build", "()Lcom/urbanairship/push/proto/Messages$Hello;");
					return Java.Lang.Object.GetObject<global::Com.Urbanairship.Push.Proto.Messages.Hello> (JNIEnv.CallObjectMethod  (Handle, id_build), JniHandleOwnership.TransferLocalRef);
				}

				static IntPtr id_buildPartial;
				[Register ("buildPartial", "()Lcom/urbanairship/push/proto/Messages$Hello;", "")]
				public global::Com.Urbanairship.Push.Proto.Messages.Hello BuildPartial ()
				{
					if (id_buildPartial == IntPtr.Zero)
						id_buildPartial = JNIEnv.GetMethodID (class_ref, "buildPartial", "()Lcom/urbanairship/push/proto/Messages$Hello;");
					return Java.Lang.Object.GetObject<global::Com.Urbanairship.Push.Proto.Messages.Hello> (JNIEnv.CallObjectMethod  (Handle, id_buildPartial), JniHandleOwnership.TransferLocalRef);
				}

				static IntPtr id_clear;
				[Register ("clear", "()Lcom/urbanairship/push/proto/Messages$Hello$Builder;", "")]
				public global::Com.Urbanairship.Push.Proto.Messages.Hello.Builder Clear ()
				{
					if (id_clear == IntPtr.Zero)
						id_clear = JNIEnv.GetMethodID (class_ref, "clear", "()Lcom/urbanairship/push/proto/Messages$Hello$Builder;");
					return Java.Lang.Object.GetObject<global::Com.Urbanairship.Push.Proto.Messages.Hello.Builder> (JNIEnv.CallObjectMethod  (Handle, id_clear), JniHandleOwnership.TransferLocalRef);
				}

				static IntPtr id_clearMessage;
				[Register ("clearMessage", "()Lcom/urbanairship/push/proto/Messages$Hello$Builder;", "")]
				public global::Com.Urbanairship.Push.Proto.Messages.Hello.Builder ClearMessage ()
				{
					if (id_clearMessage == IntPtr.Zero)
						id_clearMessage = JNIEnv.GetMethodID (class_ref, "clearMessage", "()Lcom/urbanairship/push/proto/Messages$Hello$Builder;");
					return Java.Lang.Object.GetObject<global::Com.Urbanairship.Push.Proto.Messages.Hello.Builder> (JNIEnv.CallObjectMethod  (Handle, id_clearMessage), JniHandleOwnership.TransferLocalRef);
				}

				static IntPtr id_internalGetResult;
				[Register ("internalGetResult", "()Lcom/urbanairship/push/proto/Messages$Hello;", "")]
				protected override global::Com.Urbanairship.Push.Proto.Messages.Hello InternalGetResult ()
				{
					if (id_internalGetResult == IntPtr.Zero)
						id_internalGetResult = JNIEnv.GetMethodID (class_ref, "internalGetResult", "()Lcom/urbanairship/push/proto/Messages$Hello;");
					return Java.Lang.Object.GetObject<global::Com.Urbanairship.Push.Proto.Messages.Hello> (JNIEnv.CallObjectMethod  (Handle, id_internalGetResult), JniHandleOwnership.TransferLocalRef);
				}

				static IntPtr id_mergeFrom_Lcom_google_protobuf_CodedInputStream_Lcom_google_protobuf_ExtensionRegistryLite_;
				[Register ("mergeFrom", "(Lcom/google/protobuf/CodedInputStream;Lcom/google/protobuf/ExtensionRegistryLite;)Lcom/urbanairship/push/proto/Messages$Hello$Builder;", "")]
				public override global::Com.Urbanairship.Push.Proto.Messages.Hello.Builder MergeFrom (global::Com.Google.Protobuf.CodedInputStream p0, global::Com.Google.Protobuf.ExtensionRegistryLite p1)
				{
					if (id_mergeFrom_Lcom_google_protobuf_CodedInputStream_Lcom_google_protobuf_ExtensionRegistryLite_ == IntPtr.Zero)
						id_mergeFrom_Lcom_google_protobuf_CodedInputStream_Lcom_google_protobuf_ExtensionRegistryLite_ = JNIEnv.GetMethodID (class_ref, "mergeFrom", "(Lcom/google/protobuf/CodedInputStream;Lcom/google/protobuf/ExtensionRegistryLite;)Lcom/urbanairship/push/proto/Messages$Hello$Builder;");
					global::Com.Urbanairship.Push.Proto.Messages.Hello.Builder __ret = Java.Lang.Object.GetObject<global::Com.Urbanairship.Push.Proto.Messages.Hello.Builder> (JNIEnv.CallObjectMethod  (Handle, id_mergeFrom_Lcom_google_protobuf_CodedInputStream_Lcom_google_protobuf_ExtensionRegistryLite_, new JValue (p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
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

				static IntPtr id_mergeFrom_Lcom_urbanairship_push_proto_Messages_Hello_;
				[Register ("mergeFrom", "(Lcom/urbanairship/push/proto/Messages$Hello;)Lcom/urbanairship/push/proto/Messages$Hello$Builder;", "")]
				public global::Com.Urbanairship.Push.Proto.Messages.Hello.Builder MergeFrom (global::Com.Urbanairship.Push.Proto.Messages.Hello p0)
				{
					if (id_mergeFrom_Lcom_urbanairship_push_proto_Messages_Hello_ == IntPtr.Zero)
						id_mergeFrom_Lcom_urbanairship_push_proto_Messages_Hello_ = JNIEnv.GetMethodID (class_ref, "mergeFrom", "(Lcom/urbanairship/push/proto/Messages$Hello;)Lcom/urbanairship/push/proto/Messages$Hello$Builder;");
					global::Com.Urbanairship.Push.Proto.Messages.Hello.Builder __ret = Java.Lang.Object.GetObject<global::Com.Urbanairship.Push.Proto.Messages.Hello.Builder> (JNIEnv.CallObjectMethod  (Handle, id_mergeFrom_Lcom_urbanairship_push_proto_Messages_Hello_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
					return __ret;
				}

				static IntPtr id_setMessage_Ljava_lang_String_;
				[Register ("setMessage", "(Ljava/lang/String;)Lcom/urbanairship/push/proto/Messages$Hello$Builder;", "")]
				public global::Com.Urbanairship.Push.Proto.Messages.Hello.Builder SetMessage (string p0)
				{
					if (id_setMessage_Ljava_lang_String_ == IntPtr.Zero)
						id_setMessage_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setMessage", "(Ljava/lang/String;)Lcom/urbanairship/push/proto/Messages$Hello$Builder;");
					IntPtr native_p0 = JNIEnv.NewString (p0);
					global::Com.Urbanairship.Push.Proto.Messages.Hello.Builder __ret = Java.Lang.Object.GetObject<global::Com.Urbanairship.Push.Proto.Messages.Hello.Builder> (JNIEnv.CallObjectMethod  (Handle, id_setMessage_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
					JNIEnv.DeleteLocalRef (native_p0);
					return __ret;
				}

			}

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/urbanairship/push/proto/Messages$Hello", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Hello); }
			}

			internal Hello (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_getDefaultInstance;
			public static global::Com.Urbanairship.Push.Proto.Messages.Hello DefaultInstance {
				[Register ("getDefaultInstance", "()Lcom/urbanairship/push/proto/Messages$Hello;", "GetGetDefaultInstanceHandler")]
				get {
					if (id_getDefaultInstance == IntPtr.Zero)
						id_getDefaultInstance = JNIEnv.GetStaticMethodID (class_ref, "getDefaultInstance", "()Lcom/urbanairship/push/proto/Messages$Hello;");
					return Java.Lang.Object.GetObject<global::Com.Urbanairship.Push.Proto.Messages.Hello> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getDefaultInstance), JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr id_getDefaultInstanceForType;
			public override global::Com.Urbanairship.Push.Proto.Messages.Hello DefaultInstanceForType {
				[Register ("getDefaultInstanceForType", "()Lcom/urbanairship/push/proto/Messages$Hello;", "GetGetDefaultInstanceForTypeHandler")]
				get {
					if (id_getDefaultInstanceForType == IntPtr.Zero)
						id_getDefaultInstanceForType = JNIEnv.GetMethodID (class_ref, "getDefaultInstanceForType", "()Lcom/urbanairship/push/proto/Messages$Hello;");
					return Java.Lang.Object.GetObject<global::Com.Urbanairship.Push.Proto.Messages.Hello> (JNIEnv.CallObjectMethod  (Handle, id_getDefaultInstanceForType), JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr id_hasMessage;
			public bool HasMessage {
				[Register ("hasMessage", "()Z", "GetHasMessageHandler")]
				get {
					if (id_hasMessage == IntPtr.Zero)
						id_hasMessage = JNIEnv.GetMethodID (class_ref, "hasMessage", "()Z");
					return JNIEnv.CallBooleanMethod  (Handle, id_hasMessage);
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

			static IntPtr id_getMessage;
			public string Message {
				[Register ("getMessage", "()Ljava/lang/String;", "GetGetMessageHandler")]
				get {
					if (id_getMessage == IntPtr.Zero)
						id_getMessage = JNIEnv.GetMethodID (class_ref, "getMessage", "()Ljava/lang/String;");
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getMessage), JniHandleOwnership.TransferLocalRef);
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
			[Register ("newBuilder", "()Lcom/urbanairship/push/proto/Messages$Hello$Builder;", "")]
			public static global::Com.Urbanairship.Push.Proto.Messages.Hello.Builder NewBuilder ()
			{
				if (id_newBuilder == IntPtr.Zero)
					id_newBuilder = JNIEnv.GetStaticMethodID (class_ref, "newBuilder", "()Lcom/urbanairship/push/proto/Messages$Hello$Builder;");
				return Java.Lang.Object.GetObject<global::Com.Urbanairship.Push.Proto.Messages.Hello.Builder> (JNIEnv.CallStaticObjectMethod  (class_ref, id_newBuilder), JniHandleOwnership.TransferLocalRef);
			}

			static IntPtr id_newBuilder_Lcom_urbanairship_push_proto_Messages_Hello_;
			[Register ("newBuilder", "(Lcom/urbanairship/push/proto/Messages$Hello;)Lcom/urbanairship/push/proto/Messages$Hello$Builder;", "")]
			public static global::Com.Urbanairship.Push.Proto.Messages.Hello.Builder NewBuilder (global::Com.Urbanairship.Push.Proto.Messages.Hello p0)
			{
				if (id_newBuilder_Lcom_urbanairship_push_proto_Messages_Hello_ == IntPtr.Zero)
					id_newBuilder_Lcom_urbanairship_push_proto_Messages_Hello_ = JNIEnv.GetStaticMethodID (class_ref, "newBuilder", "(Lcom/urbanairship/push/proto/Messages$Hello;)Lcom/urbanairship/push/proto/Messages$Hello$Builder;");
				global::Com.Urbanairship.Push.Proto.Messages.Hello.Builder __ret = Java.Lang.Object.GetObject<global::Com.Urbanairship.Push.Proto.Messages.Hello.Builder> (JNIEnv.CallStaticObjectMethod  (class_ref, id_newBuilder_Lcom_urbanairship_push_proto_Messages_Hello_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
				return __ret;
			}

			static IntPtr id_newBuilderForType;
			[Register ("newBuilderForType", "()Lcom/urbanairship/push/proto/Messages$Hello$Builder;", "")]
			public global::Com.Urbanairship.Push.Proto.Messages.Hello.Builder NewBuilderForType ()
			{
				if (id_newBuilderForType == IntPtr.Zero)
					id_newBuilderForType = JNIEnv.GetMethodID (class_ref, "newBuilderForType", "()Lcom/urbanairship/push/proto/Messages$Hello$Builder;");
				return Java.Lang.Object.GetObject<global::Com.Urbanairship.Push.Proto.Messages.Hello.Builder> (JNIEnv.CallObjectMethod  (Handle, id_newBuilderForType), JniHandleOwnership.TransferLocalRef);
			}

			static IntPtr id_parseDelimitedFrom_Ljava_io_InputStream_;
			[Register ("parseDelimitedFrom", "(Ljava/io/InputStream;)Lcom/urbanairship/push/proto/Messages$Hello;", "")]
			public static global::Com.Urbanairship.Push.Proto.Messages.Hello ParseDelimitedFrom (global::System.IO.Stream p0)
			{
				if (id_parseDelimitedFrom_Ljava_io_InputStream_ == IntPtr.Zero)
					id_parseDelimitedFrom_Ljava_io_InputStream_ = JNIEnv.GetStaticMethodID (class_ref, "parseDelimitedFrom", "(Ljava/io/InputStream;)Lcom/urbanairship/push/proto/Messages$Hello;");
				IntPtr native_p0 = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (p0);
				global::Com.Urbanairship.Push.Proto.Messages.Hello __ret = Java.Lang.Object.GetObject<global::Com.Urbanairship.Push.Proto.Messages.Hello> (JNIEnv.CallStaticObjectMethod  (class_ref, id_parseDelimitedFrom_Ljava_io_InputStream_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
				JNIEnv.DeleteLocalRef (native_p0);
				return __ret;
			}

			static IntPtr id_parseDelimitedFrom_Ljava_io_InputStream_Lcom_google_protobuf_ExtensionRegistryLite_;
			[Register ("parseDelimitedFrom", "(Ljava/io/InputStream;Lcom/google/protobuf/ExtensionRegistryLite;)Lcom/urbanairship/push/proto/Messages$Hello;", "")]
			public static global::Com.Urbanairship.Push.Proto.Messages.Hello ParseDelimitedFrom (global::System.IO.Stream p0, global::Com.Google.Protobuf.ExtensionRegistryLite p1)
			{
				if (id_parseDelimitedFrom_Ljava_io_InputStream_Lcom_google_protobuf_ExtensionRegistryLite_ == IntPtr.Zero)
					id_parseDelimitedFrom_Ljava_io_InputStream_Lcom_google_protobuf_ExtensionRegistryLite_ = JNIEnv.GetStaticMethodID (class_ref, "parseDelimitedFrom", "(Ljava/io/InputStream;Lcom/google/protobuf/ExtensionRegistryLite;)Lcom/urbanairship/push/proto/Messages$Hello;");
				IntPtr native_p0 = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (p0);
				global::Com.Urbanairship.Push.Proto.Messages.Hello __ret = Java.Lang.Object.GetObject<global::Com.Urbanairship.Push.Proto.Messages.Hello> (JNIEnv.CallStaticObjectMethod  (class_ref, id_parseDelimitedFrom_Ljava_io_InputStream_Lcom_google_protobuf_ExtensionRegistryLite_, new JValue (native_p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
				JNIEnv.DeleteLocalRef (native_p0);
				return __ret;
			}

			static IntPtr id_parseFrom_arrayB;
			[Register ("parseFrom", "([B)Lcom/urbanairship/push/proto/Messages$Hello;", "")]
			public static global::Com.Urbanairship.Push.Proto.Messages.Hello ParseFrom (byte[] p0)
			{
				if (id_parseFrom_arrayB == IntPtr.Zero)
					id_parseFrom_arrayB = JNIEnv.GetStaticMethodID (class_ref, "parseFrom", "([B)Lcom/urbanairship/push/proto/Messages$Hello;");
				IntPtr native_p0 = JNIEnv.NewArray (p0);
				global::Com.Urbanairship.Push.Proto.Messages.Hello __ret = Java.Lang.Object.GetObject<global::Com.Urbanairship.Push.Proto.Messages.Hello> (JNIEnv.CallStaticObjectMethod  (class_ref, id_parseFrom_arrayB, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				return __ret;
			}

			static IntPtr id_parseFrom_arrayBLcom_google_protobuf_ExtensionRegistryLite_;
			[Register ("parseFrom", "([BLcom/google/protobuf/ExtensionRegistryLite;)Lcom/urbanairship/push/proto/Messages$Hello;", "")]
			public static global::Com.Urbanairship.Push.Proto.Messages.Hello ParseFrom (byte[] p0, global::Com.Google.Protobuf.ExtensionRegistryLite p1)
			{
				if (id_parseFrom_arrayBLcom_google_protobuf_ExtensionRegistryLite_ == IntPtr.Zero)
					id_parseFrom_arrayBLcom_google_protobuf_ExtensionRegistryLite_ = JNIEnv.GetStaticMethodID (class_ref, "parseFrom", "([BLcom/google/protobuf/ExtensionRegistryLite;)Lcom/urbanairship/push/proto/Messages$Hello;");
				IntPtr native_p0 = JNIEnv.NewArray (p0);
				global::Com.Urbanairship.Push.Proto.Messages.Hello __ret = Java.Lang.Object.GetObject<global::Com.Urbanairship.Push.Proto.Messages.Hello> (JNIEnv.CallStaticObjectMethod  (class_ref, id_parseFrom_arrayBLcom_google_protobuf_ExtensionRegistryLite_, new JValue (native_p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				return __ret;
			}

			static IntPtr id_parseFrom_Lcom_google_protobuf_ByteString_;
			[Register ("parseFrom", "(Lcom/google/protobuf/ByteString;)Lcom/urbanairship/push/proto/Messages$Hello;", "")]
			public static global::Com.Urbanairship.Push.Proto.Messages.Hello ParseFrom (global::Com.Google.Protobuf.ByteString p0)
			{
				if (id_parseFrom_Lcom_google_protobuf_ByteString_ == IntPtr.Zero)
					id_parseFrom_Lcom_google_protobuf_ByteString_ = JNIEnv.GetStaticMethodID (class_ref, "parseFrom", "(Lcom/google/protobuf/ByteString;)Lcom/urbanairship/push/proto/Messages$Hello;");
				global::Com.Urbanairship.Push.Proto.Messages.Hello __ret = Java.Lang.Object.GetObject<global::Com.Urbanairship.Push.Proto.Messages.Hello> (JNIEnv.CallStaticObjectMethod  (class_ref, id_parseFrom_Lcom_google_protobuf_ByteString_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
				return __ret;
			}

			static IntPtr id_parseFrom_Lcom_google_protobuf_ByteString_Lcom_google_protobuf_ExtensionRegistryLite_;
			[Register ("parseFrom", "(Lcom/google/protobuf/ByteString;Lcom/google/protobuf/ExtensionRegistryLite;)Lcom/urbanairship/push/proto/Messages$Hello;", "")]
			public static global::Com.Urbanairship.Push.Proto.Messages.Hello ParseFrom (global::Com.Google.Protobuf.ByteString p0, global::Com.Google.Protobuf.ExtensionRegistryLite p1)
			{
				if (id_parseFrom_Lcom_google_protobuf_ByteString_Lcom_google_protobuf_ExtensionRegistryLite_ == IntPtr.Zero)
					id_parseFrom_Lcom_google_protobuf_ByteString_Lcom_google_protobuf_ExtensionRegistryLite_ = JNIEnv.GetStaticMethodID (class_ref, "parseFrom", "(Lcom/google/protobuf/ByteString;Lcom/google/protobuf/ExtensionRegistryLite;)Lcom/urbanairship/push/proto/Messages$Hello;");
				global::Com.Urbanairship.Push.Proto.Messages.Hello __ret = Java.Lang.Object.GetObject<global::Com.Urbanairship.Push.Proto.Messages.Hello> (JNIEnv.CallStaticObjectMethod  (class_ref, id_parseFrom_Lcom_google_protobuf_ByteString_Lcom_google_protobuf_ExtensionRegistryLite_, new JValue (p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
				return __ret;
			}

			static IntPtr id_parseFrom_Lcom_google_protobuf_CodedInputStream_;
			[Register ("parseFrom", "(Lcom/google/protobuf/CodedInputStream;)Lcom/urbanairship/push/proto/Messages$Hello;", "")]
			public static global::Com.Urbanairship.Push.Proto.Messages.Hello ParseFrom (global::Com.Google.Protobuf.CodedInputStream p0)
			{
				if (id_parseFrom_Lcom_google_protobuf_CodedInputStream_ == IntPtr.Zero)
					id_parseFrom_Lcom_google_protobuf_CodedInputStream_ = JNIEnv.GetStaticMethodID (class_ref, "parseFrom", "(Lcom/google/protobuf/CodedInputStream;)Lcom/urbanairship/push/proto/Messages$Hello;");
				global::Com.Urbanairship.Push.Proto.Messages.Hello __ret = Java.Lang.Object.GetObject<global::Com.Urbanairship.Push.Proto.Messages.Hello> (JNIEnv.CallStaticObjectMethod  (class_ref, id_parseFrom_Lcom_google_protobuf_CodedInputStream_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
				return __ret;
			}

			static IntPtr id_parseFrom_Lcom_google_protobuf_CodedInputStream_Lcom_google_protobuf_ExtensionRegistryLite_;
			[Register ("parseFrom", "(Lcom/google/protobuf/CodedInputStream;Lcom/google/protobuf/ExtensionRegistryLite;)Lcom/urbanairship/push/proto/Messages$Hello;", "")]
			public static global::Com.Urbanairship.Push.Proto.Messages.Hello ParseFrom (global::Com.Google.Protobuf.CodedInputStream p0, global::Com.Google.Protobuf.ExtensionRegistryLite p1)
			{
				if (id_parseFrom_Lcom_google_protobuf_CodedInputStream_Lcom_google_protobuf_ExtensionRegistryLite_ == IntPtr.Zero)
					id_parseFrom_Lcom_google_protobuf_CodedInputStream_Lcom_google_protobuf_ExtensionRegistryLite_ = JNIEnv.GetStaticMethodID (class_ref, "parseFrom", "(Lcom/google/protobuf/CodedInputStream;Lcom/google/protobuf/ExtensionRegistryLite;)Lcom/urbanairship/push/proto/Messages$Hello;");
				global::Com.Urbanairship.Push.Proto.Messages.Hello __ret = Java.Lang.Object.GetObject<global::Com.Urbanairship.Push.Proto.Messages.Hello> (JNIEnv.CallStaticObjectMethod  (class_ref, id_parseFrom_Lcom_google_protobuf_CodedInputStream_Lcom_google_protobuf_ExtensionRegistryLite_, new JValue (p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
				return __ret;
			}

			static IntPtr id_parseFrom_Ljava_io_InputStream_;
			[Register ("parseFrom", "(Ljava/io/InputStream;)Lcom/urbanairship/push/proto/Messages$Hello;", "")]
			public static global::Com.Urbanairship.Push.Proto.Messages.Hello ParseFrom (global::System.IO.Stream p0)
			{
				if (id_parseFrom_Ljava_io_InputStream_ == IntPtr.Zero)
					id_parseFrom_Ljava_io_InputStream_ = JNIEnv.GetStaticMethodID (class_ref, "parseFrom", "(Ljava/io/InputStream;)Lcom/urbanairship/push/proto/Messages$Hello;");
				IntPtr native_p0 = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (p0);
				global::Com.Urbanairship.Push.Proto.Messages.Hello __ret = Java.Lang.Object.GetObject<global::Com.Urbanairship.Push.Proto.Messages.Hello> (JNIEnv.CallStaticObjectMethod  (class_ref, id_parseFrom_Ljava_io_InputStream_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
				JNIEnv.DeleteLocalRef (native_p0);
				return __ret;
			}

			static IntPtr id_parseFrom_Ljava_io_InputStream_Lcom_google_protobuf_ExtensionRegistryLite_;
			[Register ("parseFrom", "(Ljava/io/InputStream;Lcom/google/protobuf/ExtensionRegistryLite;)Lcom/urbanairship/push/proto/Messages$Hello;", "")]
			public static global::Com.Urbanairship.Push.Proto.Messages.Hello ParseFrom (global::System.IO.Stream p0, global::Com.Google.Protobuf.ExtensionRegistryLite p1)
			{
				if (id_parseFrom_Ljava_io_InputStream_Lcom_google_protobuf_ExtensionRegistryLite_ == IntPtr.Zero)
					id_parseFrom_Ljava_io_InputStream_Lcom_google_protobuf_ExtensionRegistryLite_ = JNIEnv.GetStaticMethodID (class_ref, "parseFrom", "(Ljava/io/InputStream;Lcom/google/protobuf/ExtensionRegistryLite;)Lcom/urbanairship/push/proto/Messages$Hello;");
				IntPtr native_p0 = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (p0);
				global::Com.Urbanairship.Push.Proto.Messages.Hello __ret = Java.Lang.Object.GetObject<global::Com.Urbanairship.Push.Proto.Messages.Hello> (JNIEnv.CallStaticObjectMethod  (class_ref, id_parseFrom_Ljava_io_InputStream_Lcom_google_protobuf_ExtensionRegistryLite_, new JValue (native_p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
				JNIEnv.DeleteLocalRef (native_p0);
				return __ret;
			}

			static IntPtr id_toBuilder;
			[Register ("toBuilder", "()Lcom/urbanairship/push/proto/Messages$Hello$Builder;", "")]
			public global::Com.Urbanairship.Push.Proto.Messages.Hello.Builder ToBuilder ()
			{
				if (id_toBuilder == IntPtr.Zero)
					id_toBuilder = JNIEnv.GetMethodID (class_ref, "toBuilder", "()Lcom/urbanairship/push/proto/Messages$Hello$Builder;");
				return Java.Lang.Object.GetObject<global::Com.Urbanairship.Push.Proto.Messages.Hello.Builder> (JNIEnv.CallObjectMethod  (Handle, id_toBuilder), JniHandleOwnership.TransferLocalRef);
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

		[global::Android.Runtime.Register ("com/urbanairship/push/proto/Messages$KeyValue", DoNotGenerateAcw=true)]
		public sealed partial class KeyValue : global::Com.Google.Protobuf.GeneratedMessageLite {


			[Register ("KEY_FIELD_NUMBER")]
			public const int KeyFieldNumber = (int) 1;

			[Register ("VALUE_FIELD_NUMBER")]
			public const int ValueFieldNumber = (int) 2;
			[global::Android.Runtime.Register ("com/urbanairship/push/proto/Messages$KeyValue$Builder", DoNotGenerateAcw=true)]
			public new sealed partial class Builder : global::Com.Google.Protobuf.GeneratedMessageLite.Builder {

				internal static IntPtr java_class_handle;
				internal static IntPtr class_ref {
					get {
						return JNIEnv.FindClass ("com/urbanairship/push/proto/Messages$KeyValue$Builder", ref java_class_handle);
					}
				}

				protected override IntPtr ThresholdClass {
					get { return class_ref; }
				}

				protected override global::System.Type ThresholdType {
					get { return typeof (Builder); }
				}

				internal Builder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

				static IntPtr id_getDefaultInstanceForType;
				public override global::Com.Urbanairship.Push.Proto.Messages.KeyValue DefaultInstanceForType {
					[Register ("getDefaultInstanceForType", "()Lcom/urbanairship/push/proto/Messages$KeyValue;", "GetGetDefaultInstanceForTypeHandler")]
					get {
						if (id_getDefaultInstanceForType == IntPtr.Zero)
							id_getDefaultInstanceForType = JNIEnv.GetMethodID (class_ref, "getDefaultInstanceForType", "()Lcom/urbanairship/push/proto/Messages$KeyValue;");
						return Java.Lang.Object.GetObject<global::Com.Urbanairship.Push.Proto.Messages.KeyValue> (JNIEnv.CallObjectMethod  (Handle, id_getDefaultInstanceForType), JniHandleOwnership.TransferLocalRef);
					}
				}

				static IntPtr id_hasKey;
				public bool HasKey {
					[Register ("hasKey", "()Z", "GetHasKeyHandler")]
					get {
						if (id_hasKey == IntPtr.Zero)
							id_hasKey = JNIEnv.GetMethodID (class_ref, "hasKey", "()Z");
						return JNIEnv.CallBooleanMethod  (Handle, id_hasKey);
					}
				}

				static IntPtr id_hasValue;
				public bool HasValue {
					[Register ("hasValue", "()Z", "GetHasValueHandler")]
					get {
						if (id_hasValue == IntPtr.Zero)
							id_hasValue = JNIEnv.GetMethodID (class_ref, "hasValue", "()Z");
						return JNIEnv.CallBooleanMethod  (Handle, id_hasValue);
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

				static IntPtr id_getKey;
				public string Key {
					[Register ("getKey", "()Ljava/lang/String;", "GetGetKeyHandler")]
					get {
						if (id_getKey == IntPtr.Zero)
							id_getKey = JNIEnv.GetMethodID (class_ref, "getKey", "()Ljava/lang/String;");
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getKey), JniHandleOwnership.TransferLocalRef);
					}
				}

				static IntPtr id_getValue;
				public string Value {
					[Register ("getValue", "()Ljava/lang/String;", "GetGetValueHandler")]
					get {
						if (id_getValue == IntPtr.Zero)
							id_getValue = JNIEnv.GetMethodID (class_ref, "getValue", "()Ljava/lang/String;");
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getValue), JniHandleOwnership.TransferLocalRef);
					}
				}

				static IntPtr id_build;
				[Register ("build", "()Lcom/urbanairship/push/proto/Messages$KeyValue;", "")]
				public global::Com.Urbanairship.Push.Proto.Messages.KeyValue Build ()
				{
					if (id_build == IntPtr.Zero)
						id_build = JNIEnv.GetMethodID (class_ref, "build", "()Lcom/urbanairship/push/proto/Messages$KeyValue;");
					return Java.Lang.Object.GetObject<global::Com.Urbanairship.Push.Proto.Messages.KeyValue> (JNIEnv.CallObjectMethod  (Handle, id_build), JniHandleOwnership.TransferLocalRef);
				}

				static IntPtr id_buildPartial;
				[Register ("buildPartial", "()Lcom/urbanairship/push/proto/Messages$KeyValue;", "")]
				public global::Com.Urbanairship.Push.Proto.Messages.KeyValue BuildPartial ()
				{
					if (id_buildPartial == IntPtr.Zero)
						id_buildPartial = JNIEnv.GetMethodID (class_ref, "buildPartial", "()Lcom/urbanairship/push/proto/Messages$KeyValue;");
					return Java.Lang.Object.GetObject<global::Com.Urbanairship.Push.Proto.Messages.KeyValue> (JNIEnv.CallObjectMethod  (Handle, id_buildPartial), JniHandleOwnership.TransferLocalRef);
				}

				static IntPtr id_clear;
				[Register ("clear", "()Lcom/urbanairship/push/proto/Messages$KeyValue$Builder;", "")]
				public global::Com.Urbanairship.Push.Proto.Messages.KeyValue.Builder Clear ()
				{
					if (id_clear == IntPtr.Zero)
						id_clear = JNIEnv.GetMethodID (class_ref, "clear", "()Lcom/urbanairship/push/proto/Messages$KeyValue$Builder;");
					return Java.Lang.Object.GetObject<global::Com.Urbanairship.Push.Proto.Messages.KeyValue.Builder> (JNIEnv.CallObjectMethod  (Handle, id_clear), JniHandleOwnership.TransferLocalRef);
				}

				static IntPtr id_clearKey;
				[Register ("clearKey", "()Lcom/urbanairship/push/proto/Messages$KeyValue$Builder;", "")]
				public global::Com.Urbanairship.Push.Proto.Messages.KeyValue.Builder ClearKey ()
				{
					if (id_clearKey == IntPtr.Zero)
						id_clearKey = JNIEnv.GetMethodID (class_ref, "clearKey", "()Lcom/urbanairship/push/proto/Messages$KeyValue$Builder;");
					return Java.Lang.Object.GetObject<global::Com.Urbanairship.Push.Proto.Messages.KeyValue.Builder> (JNIEnv.CallObjectMethod  (Handle, id_clearKey), JniHandleOwnership.TransferLocalRef);
				}

				static IntPtr id_clearValue;
				[Register ("clearValue", "()Lcom/urbanairship/push/proto/Messages$KeyValue$Builder;", "")]
				public global::Com.Urbanairship.Push.Proto.Messages.KeyValue.Builder ClearValue ()
				{
					if (id_clearValue == IntPtr.Zero)
						id_clearValue = JNIEnv.GetMethodID (class_ref, "clearValue", "()Lcom/urbanairship/push/proto/Messages$KeyValue$Builder;");
					return Java.Lang.Object.GetObject<global::Com.Urbanairship.Push.Proto.Messages.KeyValue.Builder> (JNIEnv.CallObjectMethod  (Handle, id_clearValue), JniHandleOwnership.TransferLocalRef);
				}

				static IntPtr id_internalGetResult;
				[Register ("internalGetResult", "()Lcom/urbanairship/push/proto/Messages$KeyValue;", "")]
				protected override global::Com.Urbanairship.Push.Proto.Messages.KeyValue InternalGetResult ()
				{
					if (id_internalGetResult == IntPtr.Zero)
						id_internalGetResult = JNIEnv.GetMethodID (class_ref, "internalGetResult", "()Lcom/urbanairship/push/proto/Messages$KeyValue;");
					return Java.Lang.Object.GetObject<global::Com.Urbanairship.Push.Proto.Messages.KeyValue> (JNIEnv.CallObjectMethod  (Handle, id_internalGetResult), JniHandleOwnership.TransferLocalRef);
				}

				static IntPtr id_mergeFrom_Lcom_google_protobuf_CodedInputStream_Lcom_google_protobuf_ExtensionRegistryLite_;
				[Register ("mergeFrom", "(Lcom/google/protobuf/CodedInputStream;Lcom/google/protobuf/ExtensionRegistryLite;)Lcom/urbanairship/push/proto/Messages$KeyValue$Builder;", "")]
				public override global::Com.Urbanairship.Push.Proto.Messages.KeyValue.Builder MergeFrom (global::Com.Google.Protobuf.CodedInputStream p0, global::Com.Google.Protobuf.ExtensionRegistryLite p1)
				{
					if (id_mergeFrom_Lcom_google_protobuf_CodedInputStream_Lcom_google_protobuf_ExtensionRegistryLite_ == IntPtr.Zero)
						id_mergeFrom_Lcom_google_protobuf_CodedInputStream_Lcom_google_protobuf_ExtensionRegistryLite_ = JNIEnv.GetMethodID (class_ref, "mergeFrom", "(Lcom/google/protobuf/CodedInputStream;Lcom/google/protobuf/ExtensionRegistryLite;)Lcom/urbanairship/push/proto/Messages$KeyValue$Builder;");
					global::Com.Urbanairship.Push.Proto.Messages.KeyValue.Builder __ret = Java.Lang.Object.GetObject<global::Com.Urbanairship.Push.Proto.Messages.KeyValue.Builder> (JNIEnv.CallObjectMethod  (Handle, id_mergeFrom_Lcom_google_protobuf_CodedInputStream_Lcom_google_protobuf_ExtensionRegistryLite_, new JValue (p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
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

				static IntPtr id_mergeFrom_Lcom_urbanairship_push_proto_Messages_KeyValue_;
				[Register ("mergeFrom", "(Lcom/urbanairship/push/proto/Messages$KeyValue;)Lcom/urbanairship/push/proto/Messages$KeyValue$Builder;", "")]
				public global::Com.Urbanairship.Push.Proto.Messages.KeyValue.Builder MergeFrom (global::Com.Urbanairship.Push.Proto.Messages.KeyValue p0)
				{
					if (id_mergeFrom_Lcom_urbanairship_push_proto_Messages_KeyValue_ == IntPtr.Zero)
						id_mergeFrom_Lcom_urbanairship_push_proto_Messages_KeyValue_ = JNIEnv.GetMethodID (class_ref, "mergeFrom", "(Lcom/urbanairship/push/proto/Messages$KeyValue;)Lcom/urbanairship/push/proto/Messages$KeyValue$Builder;");
					global::Com.Urbanairship.Push.Proto.Messages.KeyValue.Builder __ret = Java.Lang.Object.GetObject<global::Com.Urbanairship.Push.Proto.Messages.KeyValue.Builder> (JNIEnv.CallObjectMethod  (Handle, id_mergeFrom_Lcom_urbanairship_push_proto_Messages_KeyValue_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
					return __ret;
				}

				static IntPtr id_setKey_Ljava_lang_String_;
				[Register ("setKey", "(Ljava/lang/String;)Lcom/urbanairship/push/proto/Messages$KeyValue$Builder;", "")]
				public global::Com.Urbanairship.Push.Proto.Messages.KeyValue.Builder SetKey (string p0)
				{
					if (id_setKey_Ljava_lang_String_ == IntPtr.Zero)
						id_setKey_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setKey", "(Ljava/lang/String;)Lcom/urbanairship/push/proto/Messages$KeyValue$Builder;");
					IntPtr native_p0 = JNIEnv.NewString (p0);
					global::Com.Urbanairship.Push.Proto.Messages.KeyValue.Builder __ret = Java.Lang.Object.GetObject<global::Com.Urbanairship.Push.Proto.Messages.KeyValue.Builder> (JNIEnv.CallObjectMethod  (Handle, id_setKey_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
					JNIEnv.DeleteLocalRef (native_p0);
					return __ret;
				}

				static IntPtr id_setValue_Ljava_lang_String_;
				[Register ("setValue", "(Ljava/lang/String;)Lcom/urbanairship/push/proto/Messages$KeyValue$Builder;", "")]
				public global::Com.Urbanairship.Push.Proto.Messages.KeyValue.Builder SetValue (string p0)
				{
					if (id_setValue_Ljava_lang_String_ == IntPtr.Zero)
						id_setValue_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setValue", "(Ljava/lang/String;)Lcom/urbanairship/push/proto/Messages$KeyValue$Builder;");
					IntPtr native_p0 = JNIEnv.NewString (p0);
					global::Com.Urbanairship.Push.Proto.Messages.KeyValue.Builder __ret = Java.Lang.Object.GetObject<global::Com.Urbanairship.Push.Proto.Messages.KeyValue.Builder> (JNIEnv.CallObjectMethod  (Handle, id_setValue_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
					JNIEnv.DeleteLocalRef (native_p0);
					return __ret;
				}

			}

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/urbanairship/push/proto/Messages$KeyValue", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (KeyValue); }
			}

			internal KeyValue (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_getDefaultInstance;
			public static global::Com.Urbanairship.Push.Proto.Messages.KeyValue DefaultInstance {
				[Register ("getDefaultInstance", "()Lcom/urbanairship/push/proto/Messages$KeyValue;", "GetGetDefaultInstanceHandler")]
				get {
					if (id_getDefaultInstance == IntPtr.Zero)
						id_getDefaultInstance = JNIEnv.GetStaticMethodID (class_ref, "getDefaultInstance", "()Lcom/urbanairship/push/proto/Messages$KeyValue;");
					return Java.Lang.Object.GetObject<global::Com.Urbanairship.Push.Proto.Messages.KeyValue> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getDefaultInstance), JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr id_getDefaultInstanceForType;
			public override global::Com.Urbanairship.Push.Proto.Messages.KeyValue DefaultInstanceForType {
				[Register ("getDefaultInstanceForType", "()Lcom/urbanairship/push/proto/Messages$KeyValue;", "GetGetDefaultInstanceForTypeHandler")]
				get {
					if (id_getDefaultInstanceForType == IntPtr.Zero)
						id_getDefaultInstanceForType = JNIEnv.GetMethodID (class_ref, "getDefaultInstanceForType", "()Lcom/urbanairship/push/proto/Messages$KeyValue;");
					return Java.Lang.Object.GetObject<global::Com.Urbanairship.Push.Proto.Messages.KeyValue> (JNIEnv.CallObjectMethod  (Handle, id_getDefaultInstanceForType), JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr id_hasKey;
			public bool HasKey {
				[Register ("hasKey", "()Z", "GetHasKeyHandler")]
				get {
					if (id_hasKey == IntPtr.Zero)
						id_hasKey = JNIEnv.GetMethodID (class_ref, "hasKey", "()Z");
					return JNIEnv.CallBooleanMethod  (Handle, id_hasKey);
				}
			}

			static IntPtr id_hasValue;
			public bool HasValue {
				[Register ("hasValue", "()Z", "GetHasValueHandler")]
				get {
					if (id_hasValue == IntPtr.Zero)
						id_hasValue = JNIEnv.GetMethodID (class_ref, "hasValue", "()Z");
					return JNIEnv.CallBooleanMethod  (Handle, id_hasValue);
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

			static IntPtr id_getKey;
			public string Key {
				[Register ("getKey", "()Ljava/lang/String;", "GetGetKeyHandler")]
				get {
					if (id_getKey == IntPtr.Zero)
						id_getKey = JNIEnv.GetMethodID (class_ref, "getKey", "()Ljava/lang/String;");
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getKey), JniHandleOwnership.TransferLocalRef);
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

			static IntPtr id_getValue;
			public string Value {
				[Register ("getValue", "()Ljava/lang/String;", "GetGetValueHandler")]
				get {
					if (id_getValue == IntPtr.Zero)
						id_getValue = JNIEnv.GetMethodID (class_ref, "getValue", "()Ljava/lang/String;");
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getValue), JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr id_newBuilder;
			[Register ("newBuilder", "()Lcom/urbanairship/push/proto/Messages$KeyValue$Builder;", "")]
			public static global::Com.Urbanairship.Push.Proto.Messages.KeyValue.Builder NewBuilder ()
			{
				if (id_newBuilder == IntPtr.Zero)
					id_newBuilder = JNIEnv.GetStaticMethodID (class_ref, "newBuilder", "()Lcom/urbanairship/push/proto/Messages$KeyValue$Builder;");
				return Java.Lang.Object.GetObject<global::Com.Urbanairship.Push.Proto.Messages.KeyValue.Builder> (JNIEnv.CallStaticObjectMethod  (class_ref, id_newBuilder), JniHandleOwnership.TransferLocalRef);
			}

			static IntPtr id_newBuilder_Lcom_urbanairship_push_proto_Messages_KeyValue_;
			[Register ("newBuilder", "(Lcom/urbanairship/push/proto/Messages$KeyValue;)Lcom/urbanairship/push/proto/Messages$KeyValue$Builder;", "")]
			public static global::Com.Urbanairship.Push.Proto.Messages.KeyValue.Builder NewBuilder (global::Com.Urbanairship.Push.Proto.Messages.KeyValue p0)
			{
				if (id_newBuilder_Lcom_urbanairship_push_proto_Messages_KeyValue_ == IntPtr.Zero)
					id_newBuilder_Lcom_urbanairship_push_proto_Messages_KeyValue_ = JNIEnv.GetStaticMethodID (class_ref, "newBuilder", "(Lcom/urbanairship/push/proto/Messages$KeyValue;)Lcom/urbanairship/push/proto/Messages$KeyValue$Builder;");
				global::Com.Urbanairship.Push.Proto.Messages.KeyValue.Builder __ret = Java.Lang.Object.GetObject<global::Com.Urbanairship.Push.Proto.Messages.KeyValue.Builder> (JNIEnv.CallStaticObjectMethod  (class_ref, id_newBuilder_Lcom_urbanairship_push_proto_Messages_KeyValue_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
				return __ret;
			}

			static IntPtr id_newBuilderForType;
			[Register ("newBuilderForType", "()Lcom/urbanairship/push/proto/Messages$KeyValue$Builder;", "")]
			public global::Com.Urbanairship.Push.Proto.Messages.KeyValue.Builder NewBuilderForType ()
			{
				if (id_newBuilderForType == IntPtr.Zero)
					id_newBuilderForType = JNIEnv.GetMethodID (class_ref, "newBuilderForType", "()Lcom/urbanairship/push/proto/Messages$KeyValue$Builder;");
				return Java.Lang.Object.GetObject<global::Com.Urbanairship.Push.Proto.Messages.KeyValue.Builder> (JNIEnv.CallObjectMethod  (Handle, id_newBuilderForType), JniHandleOwnership.TransferLocalRef);
			}

			static IntPtr id_parseDelimitedFrom_Ljava_io_InputStream_;
			[Register ("parseDelimitedFrom", "(Ljava/io/InputStream;)Lcom/urbanairship/push/proto/Messages$KeyValue;", "")]
			public static global::Com.Urbanairship.Push.Proto.Messages.KeyValue ParseDelimitedFrom (global::System.IO.Stream p0)
			{
				if (id_parseDelimitedFrom_Ljava_io_InputStream_ == IntPtr.Zero)
					id_parseDelimitedFrom_Ljava_io_InputStream_ = JNIEnv.GetStaticMethodID (class_ref, "parseDelimitedFrom", "(Ljava/io/InputStream;)Lcom/urbanairship/push/proto/Messages$KeyValue;");
				IntPtr native_p0 = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (p0);
				global::Com.Urbanairship.Push.Proto.Messages.KeyValue __ret = Java.Lang.Object.GetObject<global::Com.Urbanairship.Push.Proto.Messages.KeyValue> (JNIEnv.CallStaticObjectMethod  (class_ref, id_parseDelimitedFrom_Ljava_io_InputStream_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
				JNIEnv.DeleteLocalRef (native_p0);
				return __ret;
			}

			static IntPtr id_parseDelimitedFrom_Ljava_io_InputStream_Lcom_google_protobuf_ExtensionRegistryLite_;
			[Register ("parseDelimitedFrom", "(Ljava/io/InputStream;Lcom/google/protobuf/ExtensionRegistryLite;)Lcom/urbanairship/push/proto/Messages$KeyValue;", "")]
			public static global::Com.Urbanairship.Push.Proto.Messages.KeyValue ParseDelimitedFrom (global::System.IO.Stream p0, global::Com.Google.Protobuf.ExtensionRegistryLite p1)
			{
				if (id_parseDelimitedFrom_Ljava_io_InputStream_Lcom_google_protobuf_ExtensionRegistryLite_ == IntPtr.Zero)
					id_parseDelimitedFrom_Ljava_io_InputStream_Lcom_google_protobuf_ExtensionRegistryLite_ = JNIEnv.GetStaticMethodID (class_ref, "parseDelimitedFrom", "(Ljava/io/InputStream;Lcom/google/protobuf/ExtensionRegistryLite;)Lcom/urbanairship/push/proto/Messages$KeyValue;");
				IntPtr native_p0 = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (p0);
				global::Com.Urbanairship.Push.Proto.Messages.KeyValue __ret = Java.Lang.Object.GetObject<global::Com.Urbanairship.Push.Proto.Messages.KeyValue> (JNIEnv.CallStaticObjectMethod  (class_ref, id_parseDelimitedFrom_Ljava_io_InputStream_Lcom_google_protobuf_ExtensionRegistryLite_, new JValue (native_p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
				JNIEnv.DeleteLocalRef (native_p0);
				return __ret;
			}

			static IntPtr id_parseFrom_arrayB;
			[Register ("parseFrom", "([B)Lcom/urbanairship/push/proto/Messages$KeyValue;", "")]
			public static global::Com.Urbanairship.Push.Proto.Messages.KeyValue ParseFrom (byte[] p0)
			{
				if (id_parseFrom_arrayB == IntPtr.Zero)
					id_parseFrom_arrayB = JNIEnv.GetStaticMethodID (class_ref, "parseFrom", "([B)Lcom/urbanairship/push/proto/Messages$KeyValue;");
				IntPtr native_p0 = JNIEnv.NewArray (p0);
				global::Com.Urbanairship.Push.Proto.Messages.KeyValue __ret = Java.Lang.Object.GetObject<global::Com.Urbanairship.Push.Proto.Messages.KeyValue> (JNIEnv.CallStaticObjectMethod  (class_ref, id_parseFrom_arrayB, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				return __ret;
			}

			static IntPtr id_parseFrom_arrayBLcom_google_protobuf_ExtensionRegistryLite_;
			[Register ("parseFrom", "([BLcom/google/protobuf/ExtensionRegistryLite;)Lcom/urbanairship/push/proto/Messages$KeyValue;", "")]
			public static global::Com.Urbanairship.Push.Proto.Messages.KeyValue ParseFrom (byte[] p0, global::Com.Google.Protobuf.ExtensionRegistryLite p1)
			{
				if (id_parseFrom_arrayBLcom_google_protobuf_ExtensionRegistryLite_ == IntPtr.Zero)
					id_parseFrom_arrayBLcom_google_protobuf_ExtensionRegistryLite_ = JNIEnv.GetStaticMethodID (class_ref, "parseFrom", "([BLcom/google/protobuf/ExtensionRegistryLite;)Lcom/urbanairship/push/proto/Messages$KeyValue;");
				IntPtr native_p0 = JNIEnv.NewArray (p0);
				global::Com.Urbanairship.Push.Proto.Messages.KeyValue __ret = Java.Lang.Object.GetObject<global::Com.Urbanairship.Push.Proto.Messages.KeyValue> (JNIEnv.CallStaticObjectMethod  (class_ref, id_parseFrom_arrayBLcom_google_protobuf_ExtensionRegistryLite_, new JValue (native_p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				return __ret;
			}

			static IntPtr id_parseFrom_Lcom_google_protobuf_ByteString_;
			[Register ("parseFrom", "(Lcom/google/protobuf/ByteString;)Lcom/urbanairship/push/proto/Messages$KeyValue;", "")]
			public static global::Com.Urbanairship.Push.Proto.Messages.KeyValue ParseFrom (global::Com.Google.Protobuf.ByteString p0)
			{
				if (id_parseFrom_Lcom_google_protobuf_ByteString_ == IntPtr.Zero)
					id_parseFrom_Lcom_google_protobuf_ByteString_ = JNIEnv.GetStaticMethodID (class_ref, "parseFrom", "(Lcom/google/protobuf/ByteString;)Lcom/urbanairship/push/proto/Messages$KeyValue;");
				global::Com.Urbanairship.Push.Proto.Messages.KeyValue __ret = Java.Lang.Object.GetObject<global::Com.Urbanairship.Push.Proto.Messages.KeyValue> (JNIEnv.CallStaticObjectMethod  (class_ref, id_parseFrom_Lcom_google_protobuf_ByteString_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
				return __ret;
			}

			static IntPtr id_parseFrom_Lcom_google_protobuf_ByteString_Lcom_google_protobuf_ExtensionRegistryLite_;
			[Register ("parseFrom", "(Lcom/google/protobuf/ByteString;Lcom/google/protobuf/ExtensionRegistryLite;)Lcom/urbanairship/push/proto/Messages$KeyValue;", "")]
			public static global::Com.Urbanairship.Push.Proto.Messages.KeyValue ParseFrom (global::Com.Google.Protobuf.ByteString p0, global::Com.Google.Protobuf.ExtensionRegistryLite p1)
			{
				if (id_parseFrom_Lcom_google_protobuf_ByteString_Lcom_google_protobuf_ExtensionRegistryLite_ == IntPtr.Zero)
					id_parseFrom_Lcom_google_protobuf_ByteString_Lcom_google_protobuf_ExtensionRegistryLite_ = JNIEnv.GetStaticMethodID (class_ref, "parseFrom", "(Lcom/google/protobuf/ByteString;Lcom/google/protobuf/ExtensionRegistryLite;)Lcom/urbanairship/push/proto/Messages$KeyValue;");
				global::Com.Urbanairship.Push.Proto.Messages.KeyValue __ret = Java.Lang.Object.GetObject<global::Com.Urbanairship.Push.Proto.Messages.KeyValue> (JNIEnv.CallStaticObjectMethod  (class_ref, id_parseFrom_Lcom_google_protobuf_ByteString_Lcom_google_protobuf_ExtensionRegistryLite_, new JValue (p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
				return __ret;
			}

			static IntPtr id_parseFrom_Lcom_google_protobuf_CodedInputStream_;
			[Register ("parseFrom", "(Lcom/google/protobuf/CodedInputStream;)Lcom/urbanairship/push/proto/Messages$KeyValue;", "")]
			public static global::Com.Urbanairship.Push.Proto.Messages.KeyValue ParseFrom (global::Com.Google.Protobuf.CodedInputStream p0)
			{
				if (id_parseFrom_Lcom_google_protobuf_CodedInputStream_ == IntPtr.Zero)
					id_parseFrom_Lcom_google_protobuf_CodedInputStream_ = JNIEnv.GetStaticMethodID (class_ref, "parseFrom", "(Lcom/google/protobuf/CodedInputStream;)Lcom/urbanairship/push/proto/Messages$KeyValue;");
				global::Com.Urbanairship.Push.Proto.Messages.KeyValue __ret = Java.Lang.Object.GetObject<global::Com.Urbanairship.Push.Proto.Messages.KeyValue> (JNIEnv.CallStaticObjectMethod  (class_ref, id_parseFrom_Lcom_google_protobuf_CodedInputStream_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
				return __ret;
			}

			static IntPtr id_parseFrom_Lcom_google_protobuf_CodedInputStream_Lcom_google_protobuf_ExtensionRegistryLite_;
			[Register ("parseFrom", "(Lcom/google/protobuf/CodedInputStream;Lcom/google/protobuf/ExtensionRegistryLite;)Lcom/urbanairship/push/proto/Messages$KeyValue;", "")]
			public static global::Com.Urbanairship.Push.Proto.Messages.KeyValue ParseFrom (global::Com.Google.Protobuf.CodedInputStream p0, global::Com.Google.Protobuf.ExtensionRegistryLite p1)
			{
				if (id_parseFrom_Lcom_google_protobuf_CodedInputStream_Lcom_google_protobuf_ExtensionRegistryLite_ == IntPtr.Zero)
					id_parseFrom_Lcom_google_protobuf_CodedInputStream_Lcom_google_protobuf_ExtensionRegistryLite_ = JNIEnv.GetStaticMethodID (class_ref, "parseFrom", "(Lcom/google/protobuf/CodedInputStream;Lcom/google/protobuf/ExtensionRegistryLite;)Lcom/urbanairship/push/proto/Messages$KeyValue;");
				global::Com.Urbanairship.Push.Proto.Messages.KeyValue __ret = Java.Lang.Object.GetObject<global::Com.Urbanairship.Push.Proto.Messages.KeyValue> (JNIEnv.CallStaticObjectMethod  (class_ref, id_parseFrom_Lcom_google_protobuf_CodedInputStream_Lcom_google_protobuf_ExtensionRegistryLite_, new JValue (p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
				return __ret;
			}

			static IntPtr id_parseFrom_Ljava_io_InputStream_;
			[Register ("parseFrom", "(Ljava/io/InputStream;)Lcom/urbanairship/push/proto/Messages$KeyValue;", "")]
			public static global::Com.Urbanairship.Push.Proto.Messages.KeyValue ParseFrom (global::System.IO.Stream p0)
			{
				if (id_parseFrom_Ljava_io_InputStream_ == IntPtr.Zero)
					id_parseFrom_Ljava_io_InputStream_ = JNIEnv.GetStaticMethodID (class_ref, "parseFrom", "(Ljava/io/InputStream;)Lcom/urbanairship/push/proto/Messages$KeyValue;");
				IntPtr native_p0 = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (p0);
				global::Com.Urbanairship.Push.Proto.Messages.KeyValue __ret = Java.Lang.Object.GetObject<global::Com.Urbanairship.Push.Proto.Messages.KeyValue> (JNIEnv.CallStaticObjectMethod  (class_ref, id_parseFrom_Ljava_io_InputStream_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
				JNIEnv.DeleteLocalRef (native_p0);
				return __ret;
			}

			static IntPtr id_parseFrom_Ljava_io_InputStream_Lcom_google_protobuf_ExtensionRegistryLite_;
			[Register ("parseFrom", "(Ljava/io/InputStream;Lcom/google/protobuf/ExtensionRegistryLite;)Lcom/urbanairship/push/proto/Messages$KeyValue;", "")]
			public static global::Com.Urbanairship.Push.Proto.Messages.KeyValue ParseFrom (global::System.IO.Stream p0, global::Com.Google.Protobuf.ExtensionRegistryLite p1)
			{
				if (id_parseFrom_Ljava_io_InputStream_Lcom_google_protobuf_ExtensionRegistryLite_ == IntPtr.Zero)
					id_parseFrom_Ljava_io_InputStream_Lcom_google_protobuf_ExtensionRegistryLite_ = JNIEnv.GetStaticMethodID (class_ref, "parseFrom", "(Ljava/io/InputStream;Lcom/google/protobuf/ExtensionRegistryLite;)Lcom/urbanairship/push/proto/Messages$KeyValue;");
				IntPtr native_p0 = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (p0);
				global::Com.Urbanairship.Push.Proto.Messages.KeyValue __ret = Java.Lang.Object.GetObject<global::Com.Urbanairship.Push.Proto.Messages.KeyValue> (JNIEnv.CallStaticObjectMethod  (class_ref, id_parseFrom_Ljava_io_InputStream_Lcom_google_protobuf_ExtensionRegistryLite_, new JValue (native_p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
				JNIEnv.DeleteLocalRef (native_p0);
				return __ret;
			}

			static IntPtr id_toBuilder;
			[Register ("toBuilder", "()Lcom/urbanairship/push/proto/Messages$KeyValue$Builder;", "")]
			public global::Com.Urbanairship.Push.Proto.Messages.KeyValue.Builder ToBuilder ()
			{
				if (id_toBuilder == IntPtr.Zero)
					id_toBuilder = JNIEnv.GetMethodID (class_ref, "toBuilder", "()Lcom/urbanairship/push/proto/Messages$KeyValue$Builder;");
				return Java.Lang.Object.GetObject<global::Com.Urbanairship.Push.Proto.Messages.KeyValue.Builder> (JNIEnv.CallObjectMethod  (Handle, id_toBuilder), JniHandleOwnership.TransferLocalRef);
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

		[global::Android.Runtime.Register ("com/urbanairship/push/proto/Messages$OS", DoNotGenerateAcw=true)]
		public sealed partial class OS : global::Java.Lang.Enum, global::Com.Google.Protobuf.Internal.IEnumLite {


			static IntPtr ANDROID_jfieldId;

			[Register ("ANDROID")]
			public static global::Com.Urbanairship.Push.Proto.Messages.OS Android {
				get {
					if (ANDROID_jfieldId == IntPtr.Zero)
						ANDROID_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ANDROID", "Lcom/urbanairship/push/proto/Messages$OS;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ANDROID_jfieldId);
					return Java.Lang.Object.GetObject<global::Com.Urbanairship.Push.Proto.Messages.OS> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (ANDROID_jfieldId == IntPtr.Zero)
						ANDROID_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ANDROID", "Lcom/urbanairship/push/proto/Messages$OS;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, ANDROID_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/urbanairship/push/proto/Messages$OS", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (OS); }
			}

			internal OS (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

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
			[Register ("valueOf", "(I)Lcom/urbanairship/push/proto/Messages$OS;", "")]
			public static global::Com.Urbanairship.Push.Proto.Messages.OS ValueOf (int p0)
			{
				if (id_valueOf_I == IntPtr.Zero)
					id_valueOf_I = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(I)Lcom/urbanairship/push/proto/Messages$OS;");
				return Java.Lang.Object.GetObject<global::Com.Urbanairship.Push.Proto.Messages.OS> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_I, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			}

			static IntPtr id_valueOf_Ljava_lang_String_;
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/urbanairship/push/proto/Messages$OS;", "")]
			public static global::Com.Urbanairship.Push.Proto.Messages.OS ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/urbanairship/push/proto/Messages$OS;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				global::Com.Urbanairship.Push.Proto.Messages.OS __ret = Java.Lang.Object.GetObject<global::Com.Urbanairship.Push.Proto.Messages.OS> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
				JNIEnv.DeleteLocalRef (native_p0);
				return __ret;
			}

			static IntPtr id_values;
			[Register ("values", "()[Lcom/urbanairship/push/proto/Messages$OS;", "")]
			public static global::Com.Urbanairship.Push.Proto.Messages.OS[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/urbanairship/push/proto/Messages$OS;");
				return (Com.Urbanairship.Push.Proto.Messages.OS[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Urbanairship.Push.Proto.Messages.OS));
			}

		}

		[global::Android.Runtime.Register ("com/urbanairship/push/proto/Messages$PushNotification", DoNotGenerateAcw=true)]
		public sealed partial class PushNotification : global::Com.Google.Protobuf.GeneratedMessageLite {


			[Register ("MAP_FIELD_NUMBER")]
			public const int MapFieldNumber = (int) 5;

			[Register ("MESSAGE_FIELD_NUMBER")]
			public const int MessageFieldNumber = (int) 2;

			[Register ("MESSAGE_ID_FIELD_NUMBER")]
			public const int MessageIdFieldNumber = (int) 1;

			[Register ("PACKAGE_NAME_FIELD_NUMBER")]
			public const int PackageNameFieldNumber = (int) 3;

			[Register ("PAYLOAD_FIELD_NUMBER")]
			public const int PayloadFieldNumber = (int) 4;
			[global::Android.Runtime.Register ("com/urbanairship/push/proto/Messages$PushNotification$Builder", DoNotGenerateAcw=true)]
			public new sealed partial class Builder : global::Com.Google.Protobuf.GeneratedMessageLite.Builder {

				internal static IntPtr java_class_handle;
				internal static IntPtr class_ref {
					get {
						return JNIEnv.FindClass ("com/urbanairship/push/proto/Messages$PushNotification$Builder", ref java_class_handle);
					}
				}

				protected override IntPtr ThresholdClass {
					get { return class_ref; }
				}

				protected override global::System.Type ThresholdType {
					get { return typeof (Builder); }
				}

				internal Builder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

				static IntPtr id_getDefaultInstanceForType;
				public override global::Com.Urbanairship.Push.Proto.Messages.PushNotification DefaultInstanceForType {
					[Register ("getDefaultInstanceForType", "()Lcom/urbanairship/push/proto/Messages$PushNotification;", "GetGetDefaultInstanceForTypeHandler")]
					get {
						if (id_getDefaultInstanceForType == IntPtr.Zero)
							id_getDefaultInstanceForType = JNIEnv.GetMethodID (class_ref, "getDefaultInstanceForType", "()Lcom/urbanairship/push/proto/Messages$PushNotification;");
						return Java.Lang.Object.GetObject<global::Com.Urbanairship.Push.Proto.Messages.PushNotification> (JNIEnv.CallObjectMethod  (Handle, id_getDefaultInstanceForType), JniHandleOwnership.TransferLocalRef);
					}
				}

				static IntPtr id_hasMessage;
				public bool HasMessage {
					[Register ("hasMessage", "()Z", "GetHasMessageHandler")]
					get {
						if (id_hasMessage == IntPtr.Zero)
							id_hasMessage = JNIEnv.GetMethodID (class_ref, "hasMessage", "()Z");
						return JNIEnv.CallBooleanMethod  (Handle, id_hasMessage);
					}
				}

				static IntPtr id_hasMessageId;
				public bool HasMessageId {
					[Register ("hasMessageId", "()Z", "GetHasMessageIdHandler")]
					get {
						if (id_hasMessageId == IntPtr.Zero)
							id_hasMessageId = JNIEnv.GetMethodID (class_ref, "hasMessageId", "()Z");
						return JNIEnv.CallBooleanMethod  (Handle, id_hasMessageId);
					}
				}

				static IntPtr id_hasPackageName;
				public bool HasPackageName {
					[Register ("hasPackageName", "()Z", "GetHasPackageNameHandler")]
					get {
						if (id_hasPackageName == IntPtr.Zero)
							id_hasPackageName = JNIEnv.GetMethodID (class_ref, "hasPackageName", "()Z");
						return JNIEnv.CallBooleanMethod  (Handle, id_hasPackageName);
					}
				}

				static IntPtr id_hasPayload;
				public bool HasPayload {
					[Register ("hasPayload", "()Z", "GetHasPayloadHandler")]
					get {
						if (id_hasPayload == IntPtr.Zero)
							id_hasPayload = JNIEnv.GetMethodID (class_ref, "hasPayload", "()Z");
						return JNIEnv.CallBooleanMethod  (Handle, id_hasPayload);
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

				static IntPtr id_getMapCount;
				public int MapCount {
					[Register ("getMapCount", "()I", "GetGetMapCountHandler")]
					get {
						if (id_getMapCount == IntPtr.Zero)
							id_getMapCount = JNIEnv.GetMethodID (class_ref, "getMapCount", "()I");
						return JNIEnv.CallIntMethod  (Handle, id_getMapCount);
					}
				}

				static IntPtr id_getMapList;
				public global::System.Collections.Generic.IList<global::Com.Urbanairship.Push.Proto.Messages.KeyValue> MapList {
					[Register ("getMapList", "()Ljava/util/List;", "GetGetMapListHandler")]
					get {
						if (id_getMapList == IntPtr.Zero)
							id_getMapList = JNIEnv.GetMethodID (class_ref, "getMapList", "()Ljava/util/List;");
						return global::Android.Runtime.JavaList<global::Com.Urbanairship.Push.Proto.Messages.KeyValue>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_getMapList), JniHandleOwnership.TransferLocalRef);
					}
				}

				static IntPtr id_getMessage;
				public string Message {
					[Register ("getMessage", "()Ljava/lang/String;", "GetGetMessageHandler")]
					get {
						if (id_getMessage == IntPtr.Zero)
							id_getMessage = JNIEnv.GetMethodID (class_ref, "getMessage", "()Ljava/lang/String;");
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getMessage), JniHandleOwnership.TransferLocalRef);
					}
				}

				static IntPtr id_getMessageId;
				public string MessageId {
					[Register ("getMessageId", "()Ljava/lang/String;", "GetGetMessageIdHandler")]
					get {
						if (id_getMessageId == IntPtr.Zero)
							id_getMessageId = JNIEnv.GetMethodID (class_ref, "getMessageId", "()Ljava/lang/String;");
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getMessageId), JniHandleOwnership.TransferLocalRef);
					}
				}

				static IntPtr id_getPackageName;
				public string PackageName {
					[Register ("getPackageName", "()Ljava/lang/String;", "GetGetPackageNameHandler")]
					get {
						if (id_getPackageName == IntPtr.Zero)
							id_getPackageName = JNIEnv.GetMethodID (class_ref, "getPackageName", "()Ljava/lang/String;");
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getPackageName), JniHandleOwnership.TransferLocalRef);
					}
				}

				static IntPtr id_getPayload;
				public string Payload {
					[Register ("getPayload", "()Ljava/lang/String;", "GetGetPayloadHandler")]
					get {
						if (id_getPayload == IntPtr.Zero)
							id_getPayload = JNIEnv.GetMethodID (class_ref, "getPayload", "()Ljava/lang/String;");
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getPayload), JniHandleOwnership.TransferLocalRef);
					}
				}

				static IntPtr id_addMap_Lcom_urbanairship_push_proto_Messages_KeyValue_;
				[Register ("addMap", "(Lcom/urbanairship/push/proto/Messages$KeyValue;)Lcom/urbanairship/push/proto/Messages$PushNotification$Builder;", "")]
				public global::Com.Urbanairship.Push.Proto.Messages.PushNotification.Builder AddMap (global::Com.Urbanairship.Push.Proto.Messages.KeyValue p0)
				{
					if (id_addMap_Lcom_urbanairship_push_proto_Messages_KeyValue_ == IntPtr.Zero)
						id_addMap_Lcom_urbanairship_push_proto_Messages_KeyValue_ = JNIEnv.GetMethodID (class_ref, "addMap", "(Lcom/urbanairship/push/proto/Messages$KeyValue;)Lcom/urbanairship/push/proto/Messages$PushNotification$Builder;");
					global::Com.Urbanairship.Push.Proto.Messages.PushNotification.Builder __ret = Java.Lang.Object.GetObject<global::Com.Urbanairship.Push.Proto.Messages.PushNotification.Builder> (JNIEnv.CallObjectMethod  (Handle, id_addMap_Lcom_urbanairship_push_proto_Messages_KeyValue_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
					return __ret;
				}

				static IntPtr id_addMap_Lcom_urbanairship_push_proto_Messages_KeyValue_Builder_;
				[Register ("addMap", "(Lcom/urbanairship/push/proto/Messages$KeyValue$Builder;)Lcom/urbanairship/push/proto/Messages$PushNotification$Builder;", "")]
				public global::Com.Urbanairship.Push.Proto.Messages.PushNotification.Builder AddMap (global::Com.Urbanairship.Push.Proto.Messages.KeyValue.Builder p0)
				{
					if (id_addMap_Lcom_urbanairship_push_proto_Messages_KeyValue_Builder_ == IntPtr.Zero)
						id_addMap_Lcom_urbanairship_push_proto_Messages_KeyValue_Builder_ = JNIEnv.GetMethodID (class_ref, "addMap", "(Lcom/urbanairship/push/proto/Messages$KeyValue$Builder;)Lcom/urbanairship/push/proto/Messages$PushNotification$Builder;");
					global::Com.Urbanairship.Push.Proto.Messages.PushNotification.Builder __ret = Java.Lang.Object.GetObject<global::Com.Urbanairship.Push.Proto.Messages.PushNotification.Builder> (JNIEnv.CallObjectMethod  (Handle, id_addMap_Lcom_urbanairship_push_proto_Messages_KeyValue_Builder_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
					return __ret;
				}

				static IntPtr id_build;
				[Register ("build", "()Lcom/urbanairship/push/proto/Messages$PushNotification;", "")]
				public global::Com.Urbanairship.Push.Proto.Messages.PushNotification Build ()
				{
					if (id_build == IntPtr.Zero)
						id_build = JNIEnv.GetMethodID (class_ref, "build", "()Lcom/urbanairship/push/proto/Messages$PushNotification;");
					return Java.Lang.Object.GetObject<global::Com.Urbanairship.Push.Proto.Messages.PushNotification> (JNIEnv.CallObjectMethod  (Handle, id_build), JniHandleOwnership.TransferLocalRef);
				}

				static IntPtr id_buildPartial;
				[Register ("buildPartial", "()Lcom/urbanairship/push/proto/Messages$PushNotification;", "")]
				public global::Com.Urbanairship.Push.Proto.Messages.PushNotification BuildPartial ()
				{
					if (id_buildPartial == IntPtr.Zero)
						id_buildPartial = JNIEnv.GetMethodID (class_ref, "buildPartial", "()Lcom/urbanairship/push/proto/Messages$PushNotification;");
					return Java.Lang.Object.GetObject<global::Com.Urbanairship.Push.Proto.Messages.PushNotification> (JNIEnv.CallObjectMethod  (Handle, id_buildPartial), JniHandleOwnership.TransferLocalRef);
				}

				static IntPtr id_clear;
				[Register ("clear", "()Lcom/urbanairship/push/proto/Messages$PushNotification$Builder;", "")]
				public global::Com.Urbanairship.Push.Proto.Messages.PushNotification.Builder Clear ()
				{
					if (id_clear == IntPtr.Zero)
						id_clear = JNIEnv.GetMethodID (class_ref, "clear", "()Lcom/urbanairship/push/proto/Messages$PushNotification$Builder;");
					return Java.Lang.Object.GetObject<global::Com.Urbanairship.Push.Proto.Messages.PushNotification.Builder> (JNIEnv.CallObjectMethod  (Handle, id_clear), JniHandleOwnership.TransferLocalRef);
				}

				static IntPtr id_clearMap;
				[Register ("clearMap", "()Lcom/urbanairship/push/proto/Messages$PushNotification$Builder;", "")]
				public global::Com.Urbanairship.Push.Proto.Messages.PushNotification.Builder ClearMap ()
				{
					if (id_clearMap == IntPtr.Zero)
						id_clearMap = JNIEnv.GetMethodID (class_ref, "clearMap", "()Lcom/urbanairship/push/proto/Messages$PushNotification$Builder;");
					return Java.Lang.Object.GetObject<global::Com.Urbanairship.Push.Proto.Messages.PushNotification.Builder> (JNIEnv.CallObjectMethod  (Handle, id_clearMap), JniHandleOwnership.TransferLocalRef);
				}

				static IntPtr id_clearMessage;
				[Register ("clearMessage", "()Lcom/urbanairship/push/proto/Messages$PushNotification$Builder;", "")]
				public global::Com.Urbanairship.Push.Proto.Messages.PushNotification.Builder ClearMessage ()
				{
					if (id_clearMessage == IntPtr.Zero)
						id_clearMessage = JNIEnv.GetMethodID (class_ref, "clearMessage", "()Lcom/urbanairship/push/proto/Messages$PushNotification$Builder;");
					return Java.Lang.Object.GetObject<global::Com.Urbanairship.Push.Proto.Messages.PushNotification.Builder> (JNIEnv.CallObjectMethod  (Handle, id_clearMessage), JniHandleOwnership.TransferLocalRef);
				}

				static IntPtr id_clearMessageId;
				[Register ("clearMessageId", "()Lcom/urbanairship/push/proto/Messages$PushNotification$Builder;", "")]
				public global::Com.Urbanairship.Push.Proto.Messages.PushNotification.Builder ClearMessageId ()
				{
					if (id_clearMessageId == IntPtr.Zero)
						id_clearMessageId = JNIEnv.GetMethodID (class_ref, "clearMessageId", "()Lcom/urbanairship/push/proto/Messages$PushNotification$Builder;");
					return Java.Lang.Object.GetObject<global::Com.Urbanairship.Push.Proto.Messages.PushNotification.Builder> (JNIEnv.CallObjectMethod  (Handle, id_clearMessageId), JniHandleOwnership.TransferLocalRef);
				}

				static IntPtr id_clearPackageName;
				[Register ("clearPackageName", "()Lcom/urbanairship/push/proto/Messages$PushNotification$Builder;", "")]
				public global::Com.Urbanairship.Push.Proto.Messages.PushNotification.Builder ClearPackageName ()
				{
					if (id_clearPackageName == IntPtr.Zero)
						id_clearPackageName = JNIEnv.GetMethodID (class_ref, "clearPackageName", "()Lcom/urbanairship/push/proto/Messages$PushNotification$Builder;");
					return Java.Lang.Object.GetObject<global::Com.Urbanairship.Push.Proto.Messages.PushNotification.Builder> (JNIEnv.CallObjectMethod  (Handle, id_clearPackageName), JniHandleOwnership.TransferLocalRef);
				}

				static IntPtr id_clearPayload;
				[Register ("clearPayload", "()Lcom/urbanairship/push/proto/Messages$PushNotification$Builder;", "")]
				public global::Com.Urbanairship.Push.Proto.Messages.PushNotification.Builder ClearPayload ()
				{
					if (id_clearPayload == IntPtr.Zero)
						id_clearPayload = JNIEnv.GetMethodID (class_ref, "clearPayload", "()Lcom/urbanairship/push/proto/Messages$PushNotification$Builder;");
					return Java.Lang.Object.GetObject<global::Com.Urbanairship.Push.Proto.Messages.PushNotification.Builder> (JNIEnv.CallObjectMethod  (Handle, id_clearPayload), JniHandleOwnership.TransferLocalRef);
				}

				static IntPtr id_getMap_I;
				[Register ("getMap", "(I)Lcom/urbanairship/push/proto/Messages$KeyValue;", "")]
				public global::Com.Urbanairship.Push.Proto.Messages.KeyValue GetMap (int p0)
				{
					if (id_getMap_I == IntPtr.Zero)
						id_getMap_I = JNIEnv.GetMethodID (class_ref, "getMap", "(I)Lcom/urbanairship/push/proto/Messages$KeyValue;");
					return Java.Lang.Object.GetObject<global::Com.Urbanairship.Push.Proto.Messages.KeyValue> (JNIEnv.CallObjectMethod  (Handle, id_getMap_I, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
				}

				static IntPtr id_internalGetResult;
				[Register ("internalGetResult", "()Lcom/urbanairship/push/proto/Messages$PushNotification;", "")]
				protected override global::Com.Urbanairship.Push.Proto.Messages.PushNotification InternalGetResult ()
				{
					if (id_internalGetResult == IntPtr.Zero)
						id_internalGetResult = JNIEnv.GetMethodID (class_ref, "internalGetResult", "()Lcom/urbanairship/push/proto/Messages$PushNotification;");
					return Java.Lang.Object.GetObject<global::Com.Urbanairship.Push.Proto.Messages.PushNotification> (JNIEnv.CallObjectMethod  (Handle, id_internalGetResult), JniHandleOwnership.TransferLocalRef);
				}

				static IntPtr id_mergeFrom_Lcom_google_protobuf_CodedInputStream_Lcom_google_protobuf_ExtensionRegistryLite_;
				[Register ("mergeFrom", "(Lcom/google/protobuf/CodedInputStream;Lcom/google/protobuf/ExtensionRegistryLite;)Lcom/urbanairship/push/proto/Messages$PushNotification$Builder;", "")]
				public override global::Com.Urbanairship.Push.Proto.Messages.PushNotification.Builder MergeFrom (global::Com.Google.Protobuf.CodedInputStream p0, global::Com.Google.Protobuf.ExtensionRegistryLite p1)
				{
					if (id_mergeFrom_Lcom_google_protobuf_CodedInputStream_Lcom_google_protobuf_ExtensionRegistryLite_ == IntPtr.Zero)
						id_mergeFrom_Lcom_google_protobuf_CodedInputStream_Lcom_google_protobuf_ExtensionRegistryLite_ = JNIEnv.GetMethodID (class_ref, "mergeFrom", "(Lcom/google/protobuf/CodedInputStream;Lcom/google/protobuf/ExtensionRegistryLite;)Lcom/urbanairship/push/proto/Messages$PushNotification$Builder;");
					global::Com.Urbanairship.Push.Proto.Messages.PushNotification.Builder __ret = Java.Lang.Object.GetObject<global::Com.Urbanairship.Push.Proto.Messages.PushNotification.Builder> (JNIEnv.CallObjectMethod  (Handle, id_mergeFrom_Lcom_google_protobuf_CodedInputStream_Lcom_google_protobuf_ExtensionRegistryLite_, new JValue (p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
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

				static IntPtr id_mergeFrom_Lcom_urbanairship_push_proto_Messages_PushNotification_;
				[Register ("mergeFrom", "(Lcom/urbanairship/push/proto/Messages$PushNotification;)Lcom/urbanairship/push/proto/Messages$PushNotification$Builder;", "")]
				public global::Com.Urbanairship.Push.Proto.Messages.PushNotification.Builder MergeFrom (global::Com.Urbanairship.Push.Proto.Messages.PushNotification p0)
				{
					if (id_mergeFrom_Lcom_urbanairship_push_proto_Messages_PushNotification_ == IntPtr.Zero)
						id_mergeFrom_Lcom_urbanairship_push_proto_Messages_PushNotification_ = JNIEnv.GetMethodID (class_ref, "mergeFrom", "(Lcom/urbanairship/push/proto/Messages$PushNotification;)Lcom/urbanairship/push/proto/Messages$PushNotification$Builder;");
					global::Com.Urbanairship.Push.Proto.Messages.PushNotification.Builder __ret = Java.Lang.Object.GetObject<global::Com.Urbanairship.Push.Proto.Messages.PushNotification.Builder> (JNIEnv.CallObjectMethod  (Handle, id_mergeFrom_Lcom_urbanairship_push_proto_Messages_PushNotification_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
					return __ret;
				}

				static IntPtr id_setMap_ILcom_urbanairship_push_proto_Messages_KeyValue_;
				[Register ("setMap", "(ILcom/urbanairship/push/proto/Messages$KeyValue;)Lcom/urbanairship/push/proto/Messages$PushNotification$Builder;", "")]
				public global::Com.Urbanairship.Push.Proto.Messages.PushNotification.Builder SetMap (int p0, global::Com.Urbanairship.Push.Proto.Messages.KeyValue p1)
				{
					if (id_setMap_ILcom_urbanairship_push_proto_Messages_KeyValue_ == IntPtr.Zero)
						id_setMap_ILcom_urbanairship_push_proto_Messages_KeyValue_ = JNIEnv.GetMethodID (class_ref, "setMap", "(ILcom/urbanairship/push/proto/Messages$KeyValue;)Lcom/urbanairship/push/proto/Messages$PushNotification$Builder;");
					global::Com.Urbanairship.Push.Proto.Messages.PushNotification.Builder __ret = Java.Lang.Object.GetObject<global::Com.Urbanairship.Push.Proto.Messages.PushNotification.Builder> (JNIEnv.CallObjectMethod  (Handle, id_setMap_ILcom_urbanairship_push_proto_Messages_KeyValue_, new JValue (p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
					return __ret;
				}

				static IntPtr id_setMap_ILcom_urbanairship_push_proto_Messages_KeyValue_Builder_;
				[Register ("setMap", "(ILcom/urbanairship/push/proto/Messages$KeyValue$Builder;)Lcom/urbanairship/push/proto/Messages$PushNotification$Builder;", "")]
				public global::Com.Urbanairship.Push.Proto.Messages.PushNotification.Builder SetMap (int p0, global::Com.Urbanairship.Push.Proto.Messages.KeyValue.Builder p1)
				{
					if (id_setMap_ILcom_urbanairship_push_proto_Messages_KeyValue_Builder_ == IntPtr.Zero)
						id_setMap_ILcom_urbanairship_push_proto_Messages_KeyValue_Builder_ = JNIEnv.GetMethodID (class_ref, "setMap", "(ILcom/urbanairship/push/proto/Messages$KeyValue$Builder;)Lcom/urbanairship/push/proto/Messages$PushNotification$Builder;");
					global::Com.Urbanairship.Push.Proto.Messages.PushNotification.Builder __ret = Java.Lang.Object.GetObject<global::Com.Urbanairship.Push.Proto.Messages.PushNotification.Builder> (JNIEnv.CallObjectMethod  (Handle, id_setMap_ILcom_urbanairship_push_proto_Messages_KeyValue_Builder_, new JValue (p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
					return __ret;
				}

				static IntPtr id_setMessage_Ljava_lang_String_;
				[Register ("setMessage", "(Ljava/lang/String;)Lcom/urbanairship/push/proto/Messages$PushNotification$Builder;", "")]
				public global::Com.Urbanairship.Push.Proto.Messages.PushNotification.Builder SetMessage (string p0)
				{
					if (id_setMessage_Ljava_lang_String_ == IntPtr.Zero)
						id_setMessage_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setMessage", "(Ljava/lang/String;)Lcom/urbanairship/push/proto/Messages$PushNotification$Builder;");
					IntPtr native_p0 = JNIEnv.NewString (p0);
					global::Com.Urbanairship.Push.Proto.Messages.PushNotification.Builder __ret = Java.Lang.Object.GetObject<global::Com.Urbanairship.Push.Proto.Messages.PushNotification.Builder> (JNIEnv.CallObjectMethod  (Handle, id_setMessage_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
					JNIEnv.DeleteLocalRef (native_p0);
					return __ret;
				}

				static IntPtr id_setMessageId_Ljava_lang_String_;
				[Register ("setMessageId", "(Ljava/lang/String;)Lcom/urbanairship/push/proto/Messages$PushNotification$Builder;", "")]
				public global::Com.Urbanairship.Push.Proto.Messages.PushNotification.Builder SetMessageId (string p0)
				{
					if (id_setMessageId_Ljava_lang_String_ == IntPtr.Zero)
						id_setMessageId_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setMessageId", "(Ljava/lang/String;)Lcom/urbanairship/push/proto/Messages$PushNotification$Builder;");
					IntPtr native_p0 = JNIEnv.NewString (p0);
					global::Com.Urbanairship.Push.Proto.Messages.PushNotification.Builder __ret = Java.Lang.Object.GetObject<global::Com.Urbanairship.Push.Proto.Messages.PushNotification.Builder> (JNIEnv.CallObjectMethod  (Handle, id_setMessageId_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
					JNIEnv.DeleteLocalRef (native_p0);
					return __ret;
				}

				static IntPtr id_setPackageName_Ljava_lang_String_;
				[Register ("setPackageName", "(Ljava/lang/String;)Lcom/urbanairship/push/proto/Messages$PushNotification$Builder;", "")]
				public global::Com.Urbanairship.Push.Proto.Messages.PushNotification.Builder SetPackageName (string p0)
				{
					if (id_setPackageName_Ljava_lang_String_ == IntPtr.Zero)
						id_setPackageName_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setPackageName", "(Ljava/lang/String;)Lcom/urbanairship/push/proto/Messages$PushNotification$Builder;");
					IntPtr native_p0 = JNIEnv.NewString (p0);
					global::Com.Urbanairship.Push.Proto.Messages.PushNotification.Builder __ret = Java.Lang.Object.GetObject<global::Com.Urbanairship.Push.Proto.Messages.PushNotification.Builder> (JNIEnv.CallObjectMethod  (Handle, id_setPackageName_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
					JNIEnv.DeleteLocalRef (native_p0);
					return __ret;
				}

				static IntPtr id_setPayload_Ljava_lang_String_;
				[Register ("setPayload", "(Ljava/lang/String;)Lcom/urbanairship/push/proto/Messages$PushNotification$Builder;", "")]
				public global::Com.Urbanairship.Push.Proto.Messages.PushNotification.Builder SetPayload (string p0)
				{
					if (id_setPayload_Ljava_lang_String_ == IntPtr.Zero)
						id_setPayload_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setPayload", "(Ljava/lang/String;)Lcom/urbanairship/push/proto/Messages$PushNotification$Builder;");
					IntPtr native_p0 = JNIEnv.NewString (p0);
					global::Com.Urbanairship.Push.Proto.Messages.PushNotification.Builder __ret = Java.Lang.Object.GetObject<global::Com.Urbanairship.Push.Proto.Messages.PushNotification.Builder> (JNIEnv.CallObjectMethod  (Handle, id_setPayload_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
					JNIEnv.DeleteLocalRef (native_p0);
					return __ret;
				}

			}

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/urbanairship/push/proto/Messages$PushNotification", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (PushNotification); }
			}

			internal PushNotification (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_getDefaultInstance;
			public static global::Com.Urbanairship.Push.Proto.Messages.PushNotification DefaultInstance {
				[Register ("getDefaultInstance", "()Lcom/urbanairship/push/proto/Messages$PushNotification;", "GetGetDefaultInstanceHandler")]
				get {
					if (id_getDefaultInstance == IntPtr.Zero)
						id_getDefaultInstance = JNIEnv.GetStaticMethodID (class_ref, "getDefaultInstance", "()Lcom/urbanairship/push/proto/Messages$PushNotification;");
					return Java.Lang.Object.GetObject<global::Com.Urbanairship.Push.Proto.Messages.PushNotification> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getDefaultInstance), JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr id_getDefaultInstanceForType;
			public override global::Com.Urbanairship.Push.Proto.Messages.PushNotification DefaultInstanceForType {
				[Register ("getDefaultInstanceForType", "()Lcom/urbanairship/push/proto/Messages$PushNotification;", "GetGetDefaultInstanceForTypeHandler")]
				get {
					if (id_getDefaultInstanceForType == IntPtr.Zero)
						id_getDefaultInstanceForType = JNIEnv.GetMethodID (class_ref, "getDefaultInstanceForType", "()Lcom/urbanairship/push/proto/Messages$PushNotification;");
					return Java.Lang.Object.GetObject<global::Com.Urbanairship.Push.Proto.Messages.PushNotification> (JNIEnv.CallObjectMethod  (Handle, id_getDefaultInstanceForType), JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr id_hasMessage;
			public bool HasMessage {
				[Register ("hasMessage", "()Z", "GetHasMessageHandler")]
				get {
					if (id_hasMessage == IntPtr.Zero)
						id_hasMessage = JNIEnv.GetMethodID (class_ref, "hasMessage", "()Z");
					return JNIEnv.CallBooleanMethod  (Handle, id_hasMessage);
				}
			}

			static IntPtr id_hasMessageId;
			public bool HasMessageId {
				[Register ("hasMessageId", "()Z", "GetHasMessageIdHandler")]
				get {
					if (id_hasMessageId == IntPtr.Zero)
						id_hasMessageId = JNIEnv.GetMethodID (class_ref, "hasMessageId", "()Z");
					return JNIEnv.CallBooleanMethod  (Handle, id_hasMessageId);
				}
			}

			static IntPtr id_hasPackageName;
			public bool HasPackageName {
				[Register ("hasPackageName", "()Z", "GetHasPackageNameHandler")]
				get {
					if (id_hasPackageName == IntPtr.Zero)
						id_hasPackageName = JNIEnv.GetMethodID (class_ref, "hasPackageName", "()Z");
					return JNIEnv.CallBooleanMethod  (Handle, id_hasPackageName);
				}
			}

			static IntPtr id_hasPayload;
			public bool HasPayload {
				[Register ("hasPayload", "()Z", "GetHasPayloadHandler")]
				get {
					if (id_hasPayload == IntPtr.Zero)
						id_hasPayload = JNIEnv.GetMethodID (class_ref, "hasPayload", "()Z");
					return JNIEnv.CallBooleanMethod  (Handle, id_hasPayload);
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

			static IntPtr id_getMapCount;
			public int MapCount {
				[Register ("getMapCount", "()I", "GetGetMapCountHandler")]
				get {
					if (id_getMapCount == IntPtr.Zero)
						id_getMapCount = JNIEnv.GetMethodID (class_ref, "getMapCount", "()I");
					return JNIEnv.CallIntMethod  (Handle, id_getMapCount);
				}
			}

			static IntPtr id_getMapList;
			public global::System.Collections.Generic.IList<global::Com.Urbanairship.Push.Proto.Messages.KeyValue> MapList {
				[Register ("getMapList", "()Ljava/util/List;", "GetGetMapListHandler")]
				get {
					if (id_getMapList == IntPtr.Zero)
						id_getMapList = JNIEnv.GetMethodID (class_ref, "getMapList", "()Ljava/util/List;");
					return global::Android.Runtime.JavaList<global::Com.Urbanairship.Push.Proto.Messages.KeyValue>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_getMapList), JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr id_getMessage;
			public string Message {
				[Register ("getMessage", "()Ljava/lang/String;", "GetGetMessageHandler")]
				get {
					if (id_getMessage == IntPtr.Zero)
						id_getMessage = JNIEnv.GetMethodID (class_ref, "getMessage", "()Ljava/lang/String;");
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getMessage), JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr id_getMessageId;
			public string MessageId {
				[Register ("getMessageId", "()Ljava/lang/String;", "GetGetMessageIdHandler")]
				get {
					if (id_getMessageId == IntPtr.Zero)
						id_getMessageId = JNIEnv.GetMethodID (class_ref, "getMessageId", "()Ljava/lang/String;");
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getMessageId), JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr id_getPackageName;
			public string PackageName {
				[Register ("getPackageName", "()Ljava/lang/String;", "GetGetPackageNameHandler")]
				get {
					if (id_getPackageName == IntPtr.Zero)
						id_getPackageName = JNIEnv.GetMethodID (class_ref, "getPackageName", "()Ljava/lang/String;");
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getPackageName), JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr id_getPayload;
			public string Payload {
				[Register ("getPayload", "()Ljava/lang/String;", "GetGetPayloadHandler")]
				get {
					if (id_getPayload == IntPtr.Zero)
						id_getPayload = JNIEnv.GetMethodID (class_ref, "getPayload", "()Ljava/lang/String;");
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getPayload), JniHandleOwnership.TransferLocalRef);
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

			static IntPtr id_getMap_I;
			[Register ("getMap", "(I)Lcom/urbanairship/push/proto/Messages$KeyValue;", "")]
			public global::Com.Urbanairship.Push.Proto.Messages.KeyValue GetMap (int p0)
			{
				if (id_getMap_I == IntPtr.Zero)
					id_getMap_I = JNIEnv.GetMethodID (class_ref, "getMap", "(I)Lcom/urbanairship/push/proto/Messages$KeyValue;");
				return Java.Lang.Object.GetObject<global::Com.Urbanairship.Push.Proto.Messages.KeyValue> (JNIEnv.CallObjectMethod  (Handle, id_getMap_I, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			}

			static IntPtr id_newBuilder;
			[Register ("newBuilder", "()Lcom/urbanairship/push/proto/Messages$PushNotification$Builder;", "")]
			public static global::Com.Urbanairship.Push.Proto.Messages.PushNotification.Builder NewBuilder ()
			{
				if (id_newBuilder == IntPtr.Zero)
					id_newBuilder = JNIEnv.GetStaticMethodID (class_ref, "newBuilder", "()Lcom/urbanairship/push/proto/Messages$PushNotification$Builder;");
				return Java.Lang.Object.GetObject<global::Com.Urbanairship.Push.Proto.Messages.PushNotification.Builder> (JNIEnv.CallStaticObjectMethod  (class_ref, id_newBuilder), JniHandleOwnership.TransferLocalRef);
			}

			static IntPtr id_newBuilder_Lcom_urbanairship_push_proto_Messages_PushNotification_;
			[Register ("newBuilder", "(Lcom/urbanairship/push/proto/Messages$PushNotification;)Lcom/urbanairship/push/proto/Messages$PushNotification$Builder;", "")]
			public static global::Com.Urbanairship.Push.Proto.Messages.PushNotification.Builder NewBuilder (global::Com.Urbanairship.Push.Proto.Messages.PushNotification p0)
			{
				if (id_newBuilder_Lcom_urbanairship_push_proto_Messages_PushNotification_ == IntPtr.Zero)
					id_newBuilder_Lcom_urbanairship_push_proto_Messages_PushNotification_ = JNIEnv.GetStaticMethodID (class_ref, "newBuilder", "(Lcom/urbanairship/push/proto/Messages$PushNotification;)Lcom/urbanairship/push/proto/Messages$PushNotification$Builder;");
				global::Com.Urbanairship.Push.Proto.Messages.PushNotification.Builder __ret = Java.Lang.Object.GetObject<global::Com.Urbanairship.Push.Proto.Messages.PushNotification.Builder> (JNIEnv.CallStaticObjectMethod  (class_ref, id_newBuilder_Lcom_urbanairship_push_proto_Messages_PushNotification_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
				return __ret;
			}

			static IntPtr id_newBuilderForType;
			[Register ("newBuilderForType", "()Lcom/urbanairship/push/proto/Messages$PushNotification$Builder;", "")]
			public global::Com.Urbanairship.Push.Proto.Messages.PushNotification.Builder NewBuilderForType ()
			{
				if (id_newBuilderForType == IntPtr.Zero)
					id_newBuilderForType = JNIEnv.GetMethodID (class_ref, "newBuilderForType", "()Lcom/urbanairship/push/proto/Messages$PushNotification$Builder;");
				return Java.Lang.Object.GetObject<global::Com.Urbanairship.Push.Proto.Messages.PushNotification.Builder> (JNIEnv.CallObjectMethod  (Handle, id_newBuilderForType), JniHandleOwnership.TransferLocalRef);
			}

			static IntPtr id_parseDelimitedFrom_Ljava_io_InputStream_;
			[Register ("parseDelimitedFrom", "(Ljava/io/InputStream;)Lcom/urbanairship/push/proto/Messages$PushNotification;", "")]
			public static global::Com.Urbanairship.Push.Proto.Messages.PushNotification ParseDelimitedFrom (global::System.IO.Stream p0)
			{
				if (id_parseDelimitedFrom_Ljava_io_InputStream_ == IntPtr.Zero)
					id_parseDelimitedFrom_Ljava_io_InputStream_ = JNIEnv.GetStaticMethodID (class_ref, "parseDelimitedFrom", "(Ljava/io/InputStream;)Lcom/urbanairship/push/proto/Messages$PushNotification;");
				IntPtr native_p0 = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (p0);
				global::Com.Urbanairship.Push.Proto.Messages.PushNotification __ret = Java.Lang.Object.GetObject<global::Com.Urbanairship.Push.Proto.Messages.PushNotification> (JNIEnv.CallStaticObjectMethod  (class_ref, id_parseDelimitedFrom_Ljava_io_InputStream_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
				JNIEnv.DeleteLocalRef (native_p0);
				return __ret;
			}

			static IntPtr id_parseDelimitedFrom_Ljava_io_InputStream_Lcom_google_protobuf_ExtensionRegistryLite_;
			[Register ("parseDelimitedFrom", "(Ljava/io/InputStream;Lcom/google/protobuf/ExtensionRegistryLite;)Lcom/urbanairship/push/proto/Messages$PushNotification;", "")]
			public static global::Com.Urbanairship.Push.Proto.Messages.PushNotification ParseDelimitedFrom (global::System.IO.Stream p0, global::Com.Google.Protobuf.ExtensionRegistryLite p1)
			{
				if (id_parseDelimitedFrom_Ljava_io_InputStream_Lcom_google_protobuf_ExtensionRegistryLite_ == IntPtr.Zero)
					id_parseDelimitedFrom_Ljava_io_InputStream_Lcom_google_protobuf_ExtensionRegistryLite_ = JNIEnv.GetStaticMethodID (class_ref, "parseDelimitedFrom", "(Ljava/io/InputStream;Lcom/google/protobuf/ExtensionRegistryLite;)Lcom/urbanairship/push/proto/Messages$PushNotification;");
				IntPtr native_p0 = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (p0);
				global::Com.Urbanairship.Push.Proto.Messages.PushNotification __ret = Java.Lang.Object.GetObject<global::Com.Urbanairship.Push.Proto.Messages.PushNotification> (JNIEnv.CallStaticObjectMethod  (class_ref, id_parseDelimitedFrom_Ljava_io_InputStream_Lcom_google_protobuf_ExtensionRegistryLite_, new JValue (native_p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
				JNIEnv.DeleteLocalRef (native_p0);
				return __ret;
			}

			static IntPtr id_parseFrom_arrayB;
			[Register ("parseFrom", "([B)Lcom/urbanairship/push/proto/Messages$PushNotification;", "")]
			public static global::Com.Urbanairship.Push.Proto.Messages.PushNotification ParseFrom (byte[] p0)
			{
				if (id_parseFrom_arrayB == IntPtr.Zero)
					id_parseFrom_arrayB = JNIEnv.GetStaticMethodID (class_ref, "parseFrom", "([B)Lcom/urbanairship/push/proto/Messages$PushNotification;");
				IntPtr native_p0 = JNIEnv.NewArray (p0);
				global::Com.Urbanairship.Push.Proto.Messages.PushNotification __ret = Java.Lang.Object.GetObject<global::Com.Urbanairship.Push.Proto.Messages.PushNotification> (JNIEnv.CallStaticObjectMethod  (class_ref, id_parseFrom_arrayB, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				return __ret;
			}

			static IntPtr id_parseFrom_arrayBLcom_google_protobuf_ExtensionRegistryLite_;
			[Register ("parseFrom", "([BLcom/google/protobuf/ExtensionRegistryLite;)Lcom/urbanairship/push/proto/Messages$PushNotification;", "")]
			public static global::Com.Urbanairship.Push.Proto.Messages.PushNotification ParseFrom (byte[] p0, global::Com.Google.Protobuf.ExtensionRegistryLite p1)
			{
				if (id_parseFrom_arrayBLcom_google_protobuf_ExtensionRegistryLite_ == IntPtr.Zero)
					id_parseFrom_arrayBLcom_google_protobuf_ExtensionRegistryLite_ = JNIEnv.GetStaticMethodID (class_ref, "parseFrom", "([BLcom/google/protobuf/ExtensionRegistryLite;)Lcom/urbanairship/push/proto/Messages$PushNotification;");
				IntPtr native_p0 = JNIEnv.NewArray (p0);
				global::Com.Urbanairship.Push.Proto.Messages.PushNotification __ret = Java.Lang.Object.GetObject<global::Com.Urbanairship.Push.Proto.Messages.PushNotification> (JNIEnv.CallStaticObjectMethod  (class_ref, id_parseFrom_arrayBLcom_google_protobuf_ExtensionRegistryLite_, new JValue (native_p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				return __ret;
			}

			static IntPtr id_parseFrom_Lcom_google_protobuf_ByteString_;
			[Register ("parseFrom", "(Lcom/google/protobuf/ByteString;)Lcom/urbanairship/push/proto/Messages$PushNotification;", "")]
			public static global::Com.Urbanairship.Push.Proto.Messages.PushNotification ParseFrom (global::Com.Google.Protobuf.ByteString p0)
			{
				if (id_parseFrom_Lcom_google_protobuf_ByteString_ == IntPtr.Zero)
					id_parseFrom_Lcom_google_protobuf_ByteString_ = JNIEnv.GetStaticMethodID (class_ref, "parseFrom", "(Lcom/google/protobuf/ByteString;)Lcom/urbanairship/push/proto/Messages$PushNotification;");
				global::Com.Urbanairship.Push.Proto.Messages.PushNotification __ret = Java.Lang.Object.GetObject<global::Com.Urbanairship.Push.Proto.Messages.PushNotification> (JNIEnv.CallStaticObjectMethod  (class_ref, id_parseFrom_Lcom_google_protobuf_ByteString_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
				return __ret;
			}

			static IntPtr id_parseFrom_Lcom_google_protobuf_ByteString_Lcom_google_protobuf_ExtensionRegistryLite_;
			[Register ("parseFrom", "(Lcom/google/protobuf/ByteString;Lcom/google/protobuf/ExtensionRegistryLite;)Lcom/urbanairship/push/proto/Messages$PushNotification;", "")]
			public static global::Com.Urbanairship.Push.Proto.Messages.PushNotification ParseFrom (global::Com.Google.Protobuf.ByteString p0, global::Com.Google.Protobuf.ExtensionRegistryLite p1)
			{
				if (id_parseFrom_Lcom_google_protobuf_ByteString_Lcom_google_protobuf_ExtensionRegistryLite_ == IntPtr.Zero)
					id_parseFrom_Lcom_google_protobuf_ByteString_Lcom_google_protobuf_ExtensionRegistryLite_ = JNIEnv.GetStaticMethodID (class_ref, "parseFrom", "(Lcom/google/protobuf/ByteString;Lcom/google/protobuf/ExtensionRegistryLite;)Lcom/urbanairship/push/proto/Messages$PushNotification;");
				global::Com.Urbanairship.Push.Proto.Messages.PushNotification __ret = Java.Lang.Object.GetObject<global::Com.Urbanairship.Push.Proto.Messages.PushNotification> (JNIEnv.CallStaticObjectMethod  (class_ref, id_parseFrom_Lcom_google_protobuf_ByteString_Lcom_google_protobuf_ExtensionRegistryLite_, new JValue (p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
				return __ret;
			}

			static IntPtr id_parseFrom_Lcom_google_protobuf_CodedInputStream_;
			[Register ("parseFrom", "(Lcom/google/protobuf/CodedInputStream;)Lcom/urbanairship/push/proto/Messages$PushNotification;", "")]
			public static global::Com.Urbanairship.Push.Proto.Messages.PushNotification ParseFrom (global::Com.Google.Protobuf.CodedInputStream p0)
			{
				if (id_parseFrom_Lcom_google_protobuf_CodedInputStream_ == IntPtr.Zero)
					id_parseFrom_Lcom_google_protobuf_CodedInputStream_ = JNIEnv.GetStaticMethodID (class_ref, "parseFrom", "(Lcom/google/protobuf/CodedInputStream;)Lcom/urbanairship/push/proto/Messages$PushNotification;");
				global::Com.Urbanairship.Push.Proto.Messages.PushNotification __ret = Java.Lang.Object.GetObject<global::Com.Urbanairship.Push.Proto.Messages.PushNotification> (JNIEnv.CallStaticObjectMethod  (class_ref, id_parseFrom_Lcom_google_protobuf_CodedInputStream_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
				return __ret;
			}

			static IntPtr id_parseFrom_Lcom_google_protobuf_CodedInputStream_Lcom_google_protobuf_ExtensionRegistryLite_;
			[Register ("parseFrom", "(Lcom/google/protobuf/CodedInputStream;Lcom/google/protobuf/ExtensionRegistryLite;)Lcom/urbanairship/push/proto/Messages$PushNotification;", "")]
			public static global::Com.Urbanairship.Push.Proto.Messages.PushNotification ParseFrom (global::Com.Google.Protobuf.CodedInputStream p0, global::Com.Google.Protobuf.ExtensionRegistryLite p1)
			{
				if (id_parseFrom_Lcom_google_protobuf_CodedInputStream_Lcom_google_protobuf_ExtensionRegistryLite_ == IntPtr.Zero)
					id_parseFrom_Lcom_google_protobuf_CodedInputStream_Lcom_google_protobuf_ExtensionRegistryLite_ = JNIEnv.GetStaticMethodID (class_ref, "parseFrom", "(Lcom/google/protobuf/CodedInputStream;Lcom/google/protobuf/ExtensionRegistryLite;)Lcom/urbanairship/push/proto/Messages$PushNotification;");
				global::Com.Urbanairship.Push.Proto.Messages.PushNotification __ret = Java.Lang.Object.GetObject<global::Com.Urbanairship.Push.Proto.Messages.PushNotification> (JNIEnv.CallStaticObjectMethod  (class_ref, id_parseFrom_Lcom_google_protobuf_CodedInputStream_Lcom_google_protobuf_ExtensionRegistryLite_, new JValue (p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
				return __ret;
			}

			static IntPtr id_parseFrom_Ljava_io_InputStream_;
			[Register ("parseFrom", "(Ljava/io/InputStream;)Lcom/urbanairship/push/proto/Messages$PushNotification;", "")]
			public static global::Com.Urbanairship.Push.Proto.Messages.PushNotification ParseFrom (global::System.IO.Stream p0)
			{
				if (id_parseFrom_Ljava_io_InputStream_ == IntPtr.Zero)
					id_parseFrom_Ljava_io_InputStream_ = JNIEnv.GetStaticMethodID (class_ref, "parseFrom", "(Ljava/io/InputStream;)Lcom/urbanairship/push/proto/Messages$PushNotification;");
				IntPtr native_p0 = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (p0);
				global::Com.Urbanairship.Push.Proto.Messages.PushNotification __ret = Java.Lang.Object.GetObject<global::Com.Urbanairship.Push.Proto.Messages.PushNotification> (JNIEnv.CallStaticObjectMethod  (class_ref, id_parseFrom_Ljava_io_InputStream_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
				JNIEnv.DeleteLocalRef (native_p0);
				return __ret;
			}

			static IntPtr id_parseFrom_Ljava_io_InputStream_Lcom_google_protobuf_ExtensionRegistryLite_;
			[Register ("parseFrom", "(Ljava/io/InputStream;Lcom/google/protobuf/ExtensionRegistryLite;)Lcom/urbanairship/push/proto/Messages$PushNotification;", "")]
			public static global::Com.Urbanairship.Push.Proto.Messages.PushNotification ParseFrom (global::System.IO.Stream p0, global::Com.Google.Protobuf.ExtensionRegistryLite p1)
			{
				if (id_parseFrom_Ljava_io_InputStream_Lcom_google_protobuf_ExtensionRegistryLite_ == IntPtr.Zero)
					id_parseFrom_Ljava_io_InputStream_Lcom_google_protobuf_ExtensionRegistryLite_ = JNIEnv.GetStaticMethodID (class_ref, "parseFrom", "(Ljava/io/InputStream;Lcom/google/protobuf/ExtensionRegistryLite;)Lcom/urbanairship/push/proto/Messages$PushNotification;");
				IntPtr native_p0 = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (p0);
				global::Com.Urbanairship.Push.Proto.Messages.PushNotification __ret = Java.Lang.Object.GetObject<global::Com.Urbanairship.Push.Proto.Messages.PushNotification> (JNIEnv.CallStaticObjectMethod  (class_ref, id_parseFrom_Ljava_io_InputStream_Lcom_google_protobuf_ExtensionRegistryLite_, new JValue (native_p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
				JNIEnv.DeleteLocalRef (native_p0);
				return __ret;
			}

			static IntPtr id_toBuilder;
			[Register ("toBuilder", "()Lcom/urbanairship/push/proto/Messages$PushNotification$Builder;", "")]
			public global::Com.Urbanairship.Push.Proto.Messages.PushNotification.Builder ToBuilder ()
			{
				if (id_toBuilder == IntPtr.Zero)
					id_toBuilder = JNIEnv.GetMethodID (class_ref, "toBuilder", "()Lcom/urbanairship/push/proto/Messages$PushNotification$Builder;");
				return Java.Lang.Object.GetObject<global::Com.Urbanairship.Push.Proto.Messages.PushNotification.Builder> (JNIEnv.CallObjectMethod  (Handle, id_toBuilder), JniHandleOwnership.TransferLocalRef);
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

		[global::Android.Runtime.Register ("com/urbanairship/push/proto/Messages$Register", DoNotGenerateAcw=true)]
		public sealed partial class Register : global::Com.Google.Protobuf.GeneratedMessageLite {


			[Register ("APID_FIELD_NUMBER")]
			public const int ApidFieldNumber = (int) 1;

			[Register ("OS_FIELD_NUMBER")]
			public const int OsFieldNumber = (int) 2;

			[Register ("OS_VERSION_FIELD_NUMBER")]
			public const int OsVersionFieldNumber = (int) 3;

			[Register ("RELIERS_FIELD_NUMBER")]
			public const int ReliersFieldNumber = (int) 6;

			[Register ("SECRET_FIELD_NUMBER")]
			public const int SecretFieldNumber = (int) 5;

			[Register ("UA_VERSION_FIELD_NUMBER")]
			public const int UaVersionFieldNumber = (int) 4;
			[global::Android.Runtime.Register ("com/urbanairship/push/proto/Messages$Register$Builder", DoNotGenerateAcw=true)]
			public new sealed partial class Builder : global::Com.Google.Protobuf.GeneratedMessageLite.Builder {

				internal static IntPtr java_class_handle;
				internal static IntPtr class_ref {
					get {
						return JNIEnv.FindClass ("com/urbanairship/push/proto/Messages$Register$Builder", ref java_class_handle);
					}
				}

				protected override IntPtr ThresholdClass {
					get { return class_ref; }
				}

				protected override global::System.Type ThresholdType {
					get { return typeof (Builder); }
				}

				internal Builder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

				static IntPtr id_getApid;
				public string Apid {
					[Register ("getApid", "()Ljava/lang/String;", "GetGetApidHandler")]
					get {
						if (id_getApid == IntPtr.Zero)
							id_getApid = JNIEnv.GetMethodID (class_ref, "getApid", "()Ljava/lang/String;");
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getApid), JniHandleOwnership.TransferLocalRef);
					}
				}

				static IntPtr id_getDefaultInstanceForType;
				public override global::Com.Urbanairship.Push.Proto.Messages.Register DefaultInstanceForType {
					[Register ("getDefaultInstanceForType", "()Lcom/urbanairship/push/proto/Messages$Register;", "GetGetDefaultInstanceForTypeHandler")]
					get {
						if (id_getDefaultInstanceForType == IntPtr.Zero)
							id_getDefaultInstanceForType = JNIEnv.GetMethodID (class_ref, "getDefaultInstanceForType", "()Lcom/urbanairship/push/proto/Messages$Register;");
						return Java.Lang.Object.GetObject<global::Com.Urbanairship.Push.Proto.Messages.Register> (JNIEnv.CallObjectMethod  (Handle, id_getDefaultInstanceForType), JniHandleOwnership.TransferLocalRef);
					}
				}

				static IntPtr id_hasApid;
				public bool HasApid {
					[Register ("hasApid", "()Z", "GetHasApidHandler")]
					get {
						if (id_hasApid == IntPtr.Zero)
							id_hasApid = JNIEnv.GetMethodID (class_ref, "hasApid", "()Z");
						return JNIEnv.CallBooleanMethod  (Handle, id_hasApid);
					}
				}

				static IntPtr id_hasOs;
				public bool HasOs {
					[Register ("hasOs", "()Z", "GetHasOsHandler")]
					get {
						if (id_hasOs == IntPtr.Zero)
							id_hasOs = JNIEnv.GetMethodID (class_ref, "hasOs", "()Z");
						return JNIEnv.CallBooleanMethod  (Handle, id_hasOs);
					}
				}

				static IntPtr id_hasOsVersion;
				public bool HasOsVersion {
					[Register ("hasOsVersion", "()Z", "GetHasOsVersionHandler")]
					get {
						if (id_hasOsVersion == IntPtr.Zero)
							id_hasOsVersion = JNIEnv.GetMethodID (class_ref, "hasOsVersion", "()Z");
						return JNIEnv.CallBooleanMethod  (Handle, id_hasOsVersion);
					}
				}

				static IntPtr id_hasSecret;
				public bool HasSecret {
					[Register ("hasSecret", "()Z", "GetHasSecretHandler")]
					get {
						if (id_hasSecret == IntPtr.Zero)
							id_hasSecret = JNIEnv.GetMethodID (class_ref, "hasSecret", "()Z");
						return JNIEnv.CallBooleanMethod  (Handle, id_hasSecret);
					}
				}

				static IntPtr id_hasUaVersion;
				public bool HasUaVersion {
					[Register ("hasUaVersion", "()Z", "GetHasUaVersionHandler")]
					get {
						if (id_hasUaVersion == IntPtr.Zero)
							id_hasUaVersion = JNIEnv.GetMethodID (class_ref, "hasUaVersion", "()Z");
						return JNIEnv.CallBooleanMethod  (Handle, id_hasUaVersion);
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

				static IntPtr id_getOs;
				public global::Com.Urbanairship.Push.Proto.Messages.OS Os {
					[Register ("getOs", "()Lcom/urbanairship/push/proto/Messages$OS;", "GetGetOsHandler")]
					get {
						if (id_getOs == IntPtr.Zero)
							id_getOs = JNIEnv.GetMethodID (class_ref, "getOs", "()Lcom/urbanairship/push/proto/Messages$OS;");
						return Java.Lang.Object.GetObject<global::Com.Urbanairship.Push.Proto.Messages.OS> (JNIEnv.CallObjectMethod  (Handle, id_getOs), JniHandleOwnership.TransferLocalRef);
					}
				}

				static IntPtr id_getOsVersion;
				public string OsVersion {
					[Register ("getOsVersion", "()Ljava/lang/String;", "GetGetOsVersionHandler")]
					get {
						if (id_getOsVersion == IntPtr.Zero)
							id_getOsVersion = JNIEnv.GetMethodID (class_ref, "getOsVersion", "()Ljava/lang/String;");
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getOsVersion), JniHandleOwnership.TransferLocalRef);
					}
				}

				static IntPtr id_getReliersCount;
				public int ReliersCount {
					[Register ("getReliersCount", "()I", "GetGetReliersCountHandler")]
					get {
						if (id_getReliersCount == IntPtr.Zero)
							id_getReliersCount = JNIEnv.GetMethodID (class_ref, "getReliersCount", "()I");
						return JNIEnv.CallIntMethod  (Handle, id_getReliersCount);
					}
				}

				static IntPtr id_getReliersList;
				public global::System.Collections.Generic.IList<global::Com.Urbanairship.Push.Proto.Messages.Relier> ReliersList {
					[Register ("getReliersList", "()Ljava/util/List;", "GetGetReliersListHandler")]
					get {
						if (id_getReliersList == IntPtr.Zero)
							id_getReliersList = JNIEnv.GetMethodID (class_ref, "getReliersList", "()Ljava/util/List;");
						return global::Android.Runtime.JavaList<global::Com.Urbanairship.Push.Proto.Messages.Relier>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_getReliersList), JniHandleOwnership.TransferLocalRef);
					}
				}

				static IntPtr id_getSecret;
				public string Secret {
					[Register ("getSecret", "()Ljava/lang/String;", "GetGetSecretHandler")]
					get {
						if (id_getSecret == IntPtr.Zero)
							id_getSecret = JNIEnv.GetMethodID (class_ref, "getSecret", "()Ljava/lang/String;");
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getSecret), JniHandleOwnership.TransferLocalRef);
					}
				}

				static IntPtr id_getUaVersion;
				public string UaVersion {
					[Register ("getUaVersion", "()Ljava/lang/String;", "GetGetUaVersionHandler")]
					get {
						if (id_getUaVersion == IntPtr.Zero)
							id_getUaVersion = JNIEnv.GetMethodID (class_ref, "getUaVersion", "()Ljava/lang/String;");
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getUaVersion), JniHandleOwnership.TransferLocalRef);
					}
				}

				static IntPtr id_addReliers_Lcom_urbanairship_push_proto_Messages_Relier_;
				[Register ("addReliers", "(Lcom/urbanairship/push/proto/Messages$Relier;)Lcom/urbanairship/push/proto/Messages$Register$Builder;", "")]
				public global::Com.Urbanairship.Push.Proto.Messages.Register.Builder AddReliers (global::Com.Urbanairship.Push.Proto.Messages.Relier p0)
				{
					if (id_addReliers_Lcom_urbanairship_push_proto_Messages_Relier_ == IntPtr.Zero)
						id_addReliers_Lcom_urbanairship_push_proto_Messages_Relier_ = JNIEnv.GetMethodID (class_ref, "addReliers", "(Lcom/urbanairship/push/proto/Messages$Relier;)Lcom/urbanairship/push/proto/Messages$Register$Builder;");
					global::Com.Urbanairship.Push.Proto.Messages.Register.Builder __ret = Java.Lang.Object.GetObject<global::Com.Urbanairship.Push.Proto.Messages.Register.Builder> (JNIEnv.CallObjectMethod  (Handle, id_addReliers_Lcom_urbanairship_push_proto_Messages_Relier_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
					return __ret;
				}

				static IntPtr id_addReliers_Lcom_urbanairship_push_proto_Messages_Relier_Builder_;
				[Register ("addReliers", "(Lcom/urbanairship/push/proto/Messages$Relier$Builder;)Lcom/urbanairship/push/proto/Messages$Register$Builder;", "")]
				public global::Com.Urbanairship.Push.Proto.Messages.Register.Builder AddReliers (global::Com.Urbanairship.Push.Proto.Messages.Relier.Builder p0)
				{
					if (id_addReliers_Lcom_urbanairship_push_proto_Messages_Relier_Builder_ == IntPtr.Zero)
						id_addReliers_Lcom_urbanairship_push_proto_Messages_Relier_Builder_ = JNIEnv.GetMethodID (class_ref, "addReliers", "(Lcom/urbanairship/push/proto/Messages$Relier$Builder;)Lcom/urbanairship/push/proto/Messages$Register$Builder;");
					global::Com.Urbanairship.Push.Proto.Messages.Register.Builder __ret = Java.Lang.Object.GetObject<global::Com.Urbanairship.Push.Proto.Messages.Register.Builder> (JNIEnv.CallObjectMethod  (Handle, id_addReliers_Lcom_urbanairship_push_proto_Messages_Relier_Builder_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
					return __ret;
				}

				static IntPtr id_build;
				[Register ("build", "()Lcom/urbanairship/push/proto/Messages$Register;", "")]
				public global::Com.Urbanairship.Push.Proto.Messages.Register Build ()
				{
					if (id_build == IntPtr.Zero)
						id_build = JNIEnv.GetMethodID (class_ref, "build", "()Lcom/urbanairship/push/proto/Messages$Register;");
					return Java.Lang.Object.GetObject<global::Com.Urbanairship.Push.Proto.Messages.Register> (JNIEnv.CallObjectMethod  (Handle, id_build), JniHandleOwnership.TransferLocalRef);
				}

				static IntPtr id_buildPartial;
				[Register ("buildPartial", "()Lcom/urbanairship/push/proto/Messages$Register;", "")]
				public global::Com.Urbanairship.Push.Proto.Messages.Register BuildPartial ()
				{
					if (id_buildPartial == IntPtr.Zero)
						id_buildPartial = JNIEnv.GetMethodID (class_ref, "buildPartial", "()Lcom/urbanairship/push/proto/Messages$Register;");
					return Java.Lang.Object.GetObject<global::Com.Urbanairship.Push.Proto.Messages.Register> (JNIEnv.CallObjectMethod  (Handle, id_buildPartial), JniHandleOwnership.TransferLocalRef);
				}

				static IntPtr id_clear;
				[Register ("clear", "()Lcom/urbanairship/push/proto/Messages$Register$Builder;", "")]
				public global::Com.Urbanairship.Push.Proto.Messages.Register.Builder Clear ()
				{
					if (id_clear == IntPtr.Zero)
						id_clear = JNIEnv.GetMethodID (class_ref, "clear", "()Lcom/urbanairship/push/proto/Messages$Register$Builder;");
					return Java.Lang.Object.GetObject<global::Com.Urbanairship.Push.Proto.Messages.Register.Builder> (JNIEnv.CallObjectMethod  (Handle, id_clear), JniHandleOwnership.TransferLocalRef);
				}

				static IntPtr id_clearApid;
				[Register ("clearApid", "()Lcom/urbanairship/push/proto/Messages$Register$Builder;", "")]
				public global::Com.Urbanairship.Push.Proto.Messages.Register.Builder ClearApid ()
				{
					if (id_clearApid == IntPtr.Zero)
						id_clearApid = JNIEnv.GetMethodID (class_ref, "clearApid", "()Lcom/urbanairship/push/proto/Messages$Register$Builder;");
					return Java.Lang.Object.GetObject<global::Com.Urbanairship.Push.Proto.Messages.Register.Builder> (JNIEnv.CallObjectMethod  (Handle, id_clearApid), JniHandleOwnership.TransferLocalRef);
				}

				static IntPtr id_clearOs;
				[Register ("clearOs", "()Lcom/urbanairship/push/proto/Messages$Register$Builder;", "")]
				public global::Com.Urbanairship.Push.Proto.Messages.Register.Builder ClearOs ()
				{
					if (id_clearOs == IntPtr.Zero)
						id_clearOs = JNIEnv.GetMethodID (class_ref, "clearOs", "()Lcom/urbanairship/push/proto/Messages$Register$Builder;");
					return Java.Lang.Object.GetObject<global::Com.Urbanairship.Push.Proto.Messages.Register.Builder> (JNIEnv.CallObjectMethod  (Handle, id_clearOs), JniHandleOwnership.TransferLocalRef);
				}

				static IntPtr id_clearOsVersion;
				[Register ("clearOsVersion", "()Lcom/urbanairship/push/proto/Messages$Register$Builder;", "")]
				public global::Com.Urbanairship.Push.Proto.Messages.Register.Builder ClearOsVersion ()
				{
					if (id_clearOsVersion == IntPtr.Zero)
						id_clearOsVersion = JNIEnv.GetMethodID (class_ref, "clearOsVersion", "()Lcom/urbanairship/push/proto/Messages$Register$Builder;");
					return Java.Lang.Object.GetObject<global::Com.Urbanairship.Push.Proto.Messages.Register.Builder> (JNIEnv.CallObjectMethod  (Handle, id_clearOsVersion), JniHandleOwnership.TransferLocalRef);
				}

				static IntPtr id_clearReliers;
				[Register ("clearReliers", "()Lcom/urbanairship/push/proto/Messages$Register$Builder;", "")]
				public global::Com.Urbanairship.Push.Proto.Messages.Register.Builder ClearReliers ()
				{
					if (id_clearReliers == IntPtr.Zero)
						id_clearReliers = JNIEnv.GetMethodID (class_ref, "clearReliers", "()Lcom/urbanairship/push/proto/Messages$Register$Builder;");
					return Java.Lang.Object.GetObject<global::Com.Urbanairship.Push.Proto.Messages.Register.Builder> (JNIEnv.CallObjectMethod  (Handle, id_clearReliers), JniHandleOwnership.TransferLocalRef);
				}

				static IntPtr id_clearSecret;
				[Register ("clearSecret", "()Lcom/urbanairship/push/proto/Messages$Register$Builder;", "")]
				public global::Com.Urbanairship.Push.Proto.Messages.Register.Builder ClearSecret ()
				{
					if (id_clearSecret == IntPtr.Zero)
						id_clearSecret = JNIEnv.GetMethodID (class_ref, "clearSecret", "()Lcom/urbanairship/push/proto/Messages$Register$Builder;");
					return Java.Lang.Object.GetObject<global::Com.Urbanairship.Push.Proto.Messages.Register.Builder> (JNIEnv.CallObjectMethod  (Handle, id_clearSecret), JniHandleOwnership.TransferLocalRef);
				}

				static IntPtr id_clearUaVersion;
				[Register ("clearUaVersion", "()Lcom/urbanairship/push/proto/Messages$Register$Builder;", "")]
				public global::Com.Urbanairship.Push.Proto.Messages.Register.Builder ClearUaVersion ()
				{
					if (id_clearUaVersion == IntPtr.Zero)
						id_clearUaVersion = JNIEnv.GetMethodID (class_ref, "clearUaVersion", "()Lcom/urbanairship/push/proto/Messages$Register$Builder;");
					return Java.Lang.Object.GetObject<global::Com.Urbanairship.Push.Proto.Messages.Register.Builder> (JNIEnv.CallObjectMethod  (Handle, id_clearUaVersion), JniHandleOwnership.TransferLocalRef);
				}

				static IntPtr id_getReliers_I;
				[Register ("getReliers", "(I)Lcom/urbanairship/push/proto/Messages$Relier;", "")]
				public global::Com.Urbanairship.Push.Proto.Messages.Relier GetReliers (int p0)
				{
					if (id_getReliers_I == IntPtr.Zero)
						id_getReliers_I = JNIEnv.GetMethodID (class_ref, "getReliers", "(I)Lcom/urbanairship/push/proto/Messages$Relier;");
					return Java.Lang.Object.GetObject<global::Com.Urbanairship.Push.Proto.Messages.Relier> (JNIEnv.CallObjectMethod  (Handle, id_getReliers_I, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
				}

				static IntPtr id_internalGetResult;
				[Register ("internalGetResult", "()Lcom/urbanairship/push/proto/Messages$Register;", "")]
				protected override global::Com.Urbanairship.Push.Proto.Messages.Register InternalGetResult ()
				{
					if (id_internalGetResult == IntPtr.Zero)
						id_internalGetResult = JNIEnv.GetMethodID (class_ref, "internalGetResult", "()Lcom/urbanairship/push/proto/Messages$Register;");
					return Java.Lang.Object.GetObject<global::Com.Urbanairship.Push.Proto.Messages.Register> (JNIEnv.CallObjectMethod  (Handle, id_internalGetResult), JniHandleOwnership.TransferLocalRef);
				}

				static IntPtr id_mergeFrom_Lcom_google_protobuf_CodedInputStream_Lcom_google_protobuf_ExtensionRegistryLite_;
				[Register ("mergeFrom", "(Lcom/google/protobuf/CodedInputStream;Lcom/google/protobuf/ExtensionRegistryLite;)Lcom/urbanairship/push/proto/Messages$Register$Builder;", "")]
				public override global::Com.Urbanairship.Push.Proto.Messages.Register.Builder MergeFrom (global::Com.Google.Protobuf.CodedInputStream p0, global::Com.Google.Protobuf.ExtensionRegistryLite p1)
				{
					if (id_mergeFrom_Lcom_google_protobuf_CodedInputStream_Lcom_google_protobuf_ExtensionRegistryLite_ == IntPtr.Zero)
						id_mergeFrom_Lcom_google_protobuf_CodedInputStream_Lcom_google_protobuf_ExtensionRegistryLite_ = JNIEnv.GetMethodID (class_ref, "mergeFrom", "(Lcom/google/protobuf/CodedInputStream;Lcom/google/protobuf/ExtensionRegistryLite;)Lcom/urbanairship/push/proto/Messages$Register$Builder;");
					global::Com.Urbanairship.Push.Proto.Messages.Register.Builder __ret = Java.Lang.Object.GetObject<global::Com.Urbanairship.Push.Proto.Messages.Register.Builder> (JNIEnv.CallObjectMethod  (Handle, id_mergeFrom_Lcom_google_protobuf_CodedInputStream_Lcom_google_protobuf_ExtensionRegistryLite_, new JValue (p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
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

				static IntPtr id_mergeFrom_Lcom_urbanairship_push_proto_Messages_Register_;
				[Register ("mergeFrom", "(Lcom/urbanairship/push/proto/Messages$Register;)Lcom/urbanairship/push/proto/Messages$Register$Builder;", "")]
				public global::Com.Urbanairship.Push.Proto.Messages.Register.Builder MergeFrom (global::Com.Urbanairship.Push.Proto.Messages.Register p0)
				{
					if (id_mergeFrom_Lcom_urbanairship_push_proto_Messages_Register_ == IntPtr.Zero)
						id_mergeFrom_Lcom_urbanairship_push_proto_Messages_Register_ = JNIEnv.GetMethodID (class_ref, "mergeFrom", "(Lcom/urbanairship/push/proto/Messages$Register;)Lcom/urbanairship/push/proto/Messages$Register$Builder;");
					global::Com.Urbanairship.Push.Proto.Messages.Register.Builder __ret = Java.Lang.Object.GetObject<global::Com.Urbanairship.Push.Proto.Messages.Register.Builder> (JNIEnv.CallObjectMethod  (Handle, id_mergeFrom_Lcom_urbanairship_push_proto_Messages_Register_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
					return __ret;
				}

				static IntPtr id_setApid_Ljava_lang_String_;
				[Register ("setApid", "(Ljava/lang/String;)Lcom/urbanairship/push/proto/Messages$Register$Builder;", "")]
				public global::Com.Urbanairship.Push.Proto.Messages.Register.Builder SetApid (string p0)
				{
					if (id_setApid_Ljava_lang_String_ == IntPtr.Zero)
						id_setApid_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setApid", "(Ljava/lang/String;)Lcom/urbanairship/push/proto/Messages$Register$Builder;");
					IntPtr native_p0 = JNIEnv.NewString (p0);
					global::Com.Urbanairship.Push.Proto.Messages.Register.Builder __ret = Java.Lang.Object.GetObject<global::Com.Urbanairship.Push.Proto.Messages.Register.Builder> (JNIEnv.CallObjectMethod  (Handle, id_setApid_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
					JNIEnv.DeleteLocalRef (native_p0);
					return __ret;
				}

				static IntPtr id_setOs_Lcom_urbanairship_push_proto_Messages_OS_;
				[Register ("setOs", "(Lcom/urbanairship/push/proto/Messages$OS;)Lcom/urbanairship/push/proto/Messages$Register$Builder;", "")]
				public global::Com.Urbanairship.Push.Proto.Messages.Register.Builder SetOs (global::Com.Urbanairship.Push.Proto.Messages.OS p0)
				{
					if (id_setOs_Lcom_urbanairship_push_proto_Messages_OS_ == IntPtr.Zero)
						id_setOs_Lcom_urbanairship_push_proto_Messages_OS_ = JNIEnv.GetMethodID (class_ref, "setOs", "(Lcom/urbanairship/push/proto/Messages$OS;)Lcom/urbanairship/push/proto/Messages$Register$Builder;");
					global::Com.Urbanairship.Push.Proto.Messages.Register.Builder __ret = Java.Lang.Object.GetObject<global::Com.Urbanairship.Push.Proto.Messages.Register.Builder> (JNIEnv.CallObjectMethod  (Handle, id_setOs_Lcom_urbanairship_push_proto_Messages_OS_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
					return __ret;
				}

				static IntPtr id_setOsVersion_Ljava_lang_String_;
				[Register ("setOsVersion", "(Ljava/lang/String;)Lcom/urbanairship/push/proto/Messages$Register$Builder;", "")]
				public global::Com.Urbanairship.Push.Proto.Messages.Register.Builder SetOsVersion (string p0)
				{
					if (id_setOsVersion_Ljava_lang_String_ == IntPtr.Zero)
						id_setOsVersion_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setOsVersion", "(Ljava/lang/String;)Lcom/urbanairship/push/proto/Messages$Register$Builder;");
					IntPtr native_p0 = JNIEnv.NewString (p0);
					global::Com.Urbanairship.Push.Proto.Messages.Register.Builder __ret = Java.Lang.Object.GetObject<global::Com.Urbanairship.Push.Proto.Messages.Register.Builder> (JNIEnv.CallObjectMethod  (Handle, id_setOsVersion_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
					JNIEnv.DeleteLocalRef (native_p0);
					return __ret;
				}

				static IntPtr id_setReliers_ILcom_urbanairship_push_proto_Messages_Relier_;
				[Register ("setReliers", "(ILcom/urbanairship/push/proto/Messages$Relier;)Lcom/urbanairship/push/proto/Messages$Register$Builder;", "")]
				public global::Com.Urbanairship.Push.Proto.Messages.Register.Builder SetReliers (int p0, global::Com.Urbanairship.Push.Proto.Messages.Relier p1)
				{
					if (id_setReliers_ILcom_urbanairship_push_proto_Messages_Relier_ == IntPtr.Zero)
						id_setReliers_ILcom_urbanairship_push_proto_Messages_Relier_ = JNIEnv.GetMethodID (class_ref, "setReliers", "(ILcom/urbanairship/push/proto/Messages$Relier;)Lcom/urbanairship/push/proto/Messages$Register$Builder;");
					global::Com.Urbanairship.Push.Proto.Messages.Register.Builder __ret = Java.Lang.Object.GetObject<global::Com.Urbanairship.Push.Proto.Messages.Register.Builder> (JNIEnv.CallObjectMethod  (Handle, id_setReliers_ILcom_urbanairship_push_proto_Messages_Relier_, new JValue (p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
					return __ret;
				}

				static IntPtr id_setReliers_ILcom_urbanairship_push_proto_Messages_Relier_Builder_;
				[Register ("setReliers", "(ILcom/urbanairship/push/proto/Messages$Relier$Builder;)Lcom/urbanairship/push/proto/Messages$Register$Builder;", "")]
				public global::Com.Urbanairship.Push.Proto.Messages.Register.Builder SetReliers (int p0, global::Com.Urbanairship.Push.Proto.Messages.Relier.Builder p1)
				{
					if (id_setReliers_ILcom_urbanairship_push_proto_Messages_Relier_Builder_ == IntPtr.Zero)
						id_setReliers_ILcom_urbanairship_push_proto_Messages_Relier_Builder_ = JNIEnv.GetMethodID (class_ref, "setReliers", "(ILcom/urbanairship/push/proto/Messages$Relier$Builder;)Lcom/urbanairship/push/proto/Messages$Register$Builder;");
					global::Com.Urbanairship.Push.Proto.Messages.Register.Builder __ret = Java.Lang.Object.GetObject<global::Com.Urbanairship.Push.Proto.Messages.Register.Builder> (JNIEnv.CallObjectMethod  (Handle, id_setReliers_ILcom_urbanairship_push_proto_Messages_Relier_Builder_, new JValue (p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
					return __ret;
				}

				static IntPtr id_setSecret_Ljava_lang_String_;
				[Register ("setSecret", "(Ljava/lang/String;)Lcom/urbanairship/push/proto/Messages$Register$Builder;", "")]
				public global::Com.Urbanairship.Push.Proto.Messages.Register.Builder SetSecret (string p0)
				{
					if (id_setSecret_Ljava_lang_String_ == IntPtr.Zero)
						id_setSecret_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setSecret", "(Ljava/lang/String;)Lcom/urbanairship/push/proto/Messages$Register$Builder;");
					IntPtr native_p0 = JNIEnv.NewString (p0);
					global::Com.Urbanairship.Push.Proto.Messages.Register.Builder __ret = Java.Lang.Object.GetObject<global::Com.Urbanairship.Push.Proto.Messages.Register.Builder> (JNIEnv.CallObjectMethod  (Handle, id_setSecret_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
					JNIEnv.DeleteLocalRef (native_p0);
					return __ret;
				}

				static IntPtr id_setUaVersion_Ljava_lang_String_;
				[Register ("setUaVersion", "(Ljava/lang/String;)Lcom/urbanairship/push/proto/Messages$Register$Builder;", "")]
				public global::Com.Urbanairship.Push.Proto.Messages.Register.Builder SetUaVersion (string p0)
				{
					if (id_setUaVersion_Ljava_lang_String_ == IntPtr.Zero)
						id_setUaVersion_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setUaVersion", "(Ljava/lang/String;)Lcom/urbanairship/push/proto/Messages$Register$Builder;");
					IntPtr native_p0 = JNIEnv.NewString (p0);
					global::Com.Urbanairship.Push.Proto.Messages.Register.Builder __ret = Java.Lang.Object.GetObject<global::Com.Urbanairship.Push.Proto.Messages.Register.Builder> (JNIEnv.CallObjectMethod  (Handle, id_setUaVersion_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
					JNIEnv.DeleteLocalRef (native_p0);
					return __ret;
				}

			}

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/urbanairship/push/proto/Messages$Register", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Register); }
			}

			internal Register (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_getApid;
			public string Apid {
				[Register ("getApid", "()Ljava/lang/String;", "GetGetApidHandler")]
				get {
					if (id_getApid == IntPtr.Zero)
						id_getApid = JNIEnv.GetMethodID (class_ref, "getApid", "()Ljava/lang/String;");
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getApid), JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr id_getDefaultInstance;
			public static global::Com.Urbanairship.Push.Proto.Messages.Register DefaultInstance {
				[Register ("getDefaultInstance", "()Lcom/urbanairship/push/proto/Messages$Register;", "GetGetDefaultInstanceHandler")]
				get {
					if (id_getDefaultInstance == IntPtr.Zero)
						id_getDefaultInstance = JNIEnv.GetStaticMethodID (class_ref, "getDefaultInstance", "()Lcom/urbanairship/push/proto/Messages$Register;");
					return Java.Lang.Object.GetObject<global::Com.Urbanairship.Push.Proto.Messages.Register> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getDefaultInstance), JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr id_getDefaultInstanceForType;
			public override global::Com.Urbanairship.Push.Proto.Messages.Register DefaultInstanceForType {
				[Register ("getDefaultInstanceForType", "()Lcom/urbanairship/push/proto/Messages$Register;", "GetGetDefaultInstanceForTypeHandler")]
				get {
					if (id_getDefaultInstanceForType == IntPtr.Zero)
						id_getDefaultInstanceForType = JNIEnv.GetMethodID (class_ref, "getDefaultInstanceForType", "()Lcom/urbanairship/push/proto/Messages$Register;");
					return Java.Lang.Object.GetObject<global::Com.Urbanairship.Push.Proto.Messages.Register> (JNIEnv.CallObjectMethod  (Handle, id_getDefaultInstanceForType), JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr id_hasApid;
			public bool HasApid {
				[Register ("hasApid", "()Z", "GetHasApidHandler")]
				get {
					if (id_hasApid == IntPtr.Zero)
						id_hasApid = JNIEnv.GetMethodID (class_ref, "hasApid", "()Z");
					return JNIEnv.CallBooleanMethod  (Handle, id_hasApid);
				}
			}

			static IntPtr id_hasOs;
			public bool HasOs {
				[Register ("hasOs", "()Z", "GetHasOsHandler")]
				get {
					if (id_hasOs == IntPtr.Zero)
						id_hasOs = JNIEnv.GetMethodID (class_ref, "hasOs", "()Z");
					return JNIEnv.CallBooleanMethod  (Handle, id_hasOs);
				}
			}

			static IntPtr id_hasOsVersion;
			public bool HasOsVersion {
				[Register ("hasOsVersion", "()Z", "GetHasOsVersionHandler")]
				get {
					if (id_hasOsVersion == IntPtr.Zero)
						id_hasOsVersion = JNIEnv.GetMethodID (class_ref, "hasOsVersion", "()Z");
					return JNIEnv.CallBooleanMethod  (Handle, id_hasOsVersion);
				}
			}

			static IntPtr id_hasSecret;
			public bool HasSecret {
				[Register ("hasSecret", "()Z", "GetHasSecretHandler")]
				get {
					if (id_hasSecret == IntPtr.Zero)
						id_hasSecret = JNIEnv.GetMethodID (class_ref, "hasSecret", "()Z");
					return JNIEnv.CallBooleanMethod  (Handle, id_hasSecret);
				}
			}

			static IntPtr id_hasUaVersion;
			public bool HasUaVersion {
				[Register ("hasUaVersion", "()Z", "GetHasUaVersionHandler")]
				get {
					if (id_hasUaVersion == IntPtr.Zero)
						id_hasUaVersion = JNIEnv.GetMethodID (class_ref, "hasUaVersion", "()Z");
					return JNIEnv.CallBooleanMethod  (Handle, id_hasUaVersion);
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

			static IntPtr id_getOs;
			public global::Com.Urbanairship.Push.Proto.Messages.OS Os {
				[Register ("getOs", "()Lcom/urbanairship/push/proto/Messages$OS;", "GetGetOsHandler")]
				get {
					if (id_getOs == IntPtr.Zero)
						id_getOs = JNIEnv.GetMethodID (class_ref, "getOs", "()Lcom/urbanairship/push/proto/Messages$OS;");
					return Java.Lang.Object.GetObject<global::Com.Urbanairship.Push.Proto.Messages.OS> (JNIEnv.CallObjectMethod  (Handle, id_getOs), JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr id_getOsVersion;
			public string OsVersion {
				[Register ("getOsVersion", "()Ljava/lang/String;", "GetGetOsVersionHandler")]
				get {
					if (id_getOsVersion == IntPtr.Zero)
						id_getOsVersion = JNIEnv.GetMethodID (class_ref, "getOsVersion", "()Ljava/lang/String;");
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getOsVersion), JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr id_getReliersCount;
			public int ReliersCount {
				[Register ("getReliersCount", "()I", "GetGetReliersCountHandler")]
				get {
					if (id_getReliersCount == IntPtr.Zero)
						id_getReliersCount = JNIEnv.GetMethodID (class_ref, "getReliersCount", "()I");
					return JNIEnv.CallIntMethod  (Handle, id_getReliersCount);
				}
			}

			static IntPtr id_getReliersList;
			public global::System.Collections.Generic.IList<global::Com.Urbanairship.Push.Proto.Messages.Relier> ReliersList {
				[Register ("getReliersList", "()Ljava/util/List;", "GetGetReliersListHandler")]
				get {
					if (id_getReliersList == IntPtr.Zero)
						id_getReliersList = JNIEnv.GetMethodID (class_ref, "getReliersList", "()Ljava/util/List;");
					return global::Android.Runtime.JavaList<global::Com.Urbanairship.Push.Proto.Messages.Relier>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_getReliersList), JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr id_getSecret;
			public string Secret {
				[Register ("getSecret", "()Ljava/lang/String;", "GetGetSecretHandler")]
				get {
					if (id_getSecret == IntPtr.Zero)
						id_getSecret = JNIEnv.GetMethodID (class_ref, "getSecret", "()Ljava/lang/String;");
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getSecret), JniHandleOwnership.TransferLocalRef);
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

			static IntPtr id_getUaVersion;
			public string UaVersion {
				[Register ("getUaVersion", "()Ljava/lang/String;", "GetGetUaVersionHandler")]
				get {
					if (id_getUaVersion == IntPtr.Zero)
						id_getUaVersion = JNIEnv.GetMethodID (class_ref, "getUaVersion", "()Ljava/lang/String;");
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getUaVersion), JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr id_getReliers_I;
			[Register ("getReliers", "(I)Lcom/urbanairship/push/proto/Messages$Relier;", "")]
			public global::Com.Urbanairship.Push.Proto.Messages.Relier GetReliers (int p0)
			{
				if (id_getReliers_I == IntPtr.Zero)
					id_getReliers_I = JNIEnv.GetMethodID (class_ref, "getReliers", "(I)Lcom/urbanairship/push/proto/Messages$Relier;");
				return Java.Lang.Object.GetObject<global::Com.Urbanairship.Push.Proto.Messages.Relier> (JNIEnv.CallObjectMethod  (Handle, id_getReliers_I, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			}

			static IntPtr id_newBuilder;
			[Register ("newBuilder", "()Lcom/urbanairship/push/proto/Messages$Register$Builder;", "")]
			public static global::Com.Urbanairship.Push.Proto.Messages.Register.Builder NewBuilder ()
			{
				if (id_newBuilder == IntPtr.Zero)
					id_newBuilder = JNIEnv.GetStaticMethodID (class_ref, "newBuilder", "()Lcom/urbanairship/push/proto/Messages$Register$Builder;");
				return Java.Lang.Object.GetObject<global::Com.Urbanairship.Push.Proto.Messages.Register.Builder> (JNIEnv.CallStaticObjectMethod  (class_ref, id_newBuilder), JniHandleOwnership.TransferLocalRef);
			}

			static IntPtr id_newBuilder_Lcom_urbanairship_push_proto_Messages_Register_;
			[Register ("newBuilder", "(Lcom/urbanairship/push/proto/Messages$Register;)Lcom/urbanairship/push/proto/Messages$Register$Builder;", "")]
			public static global::Com.Urbanairship.Push.Proto.Messages.Register.Builder NewBuilder (global::Com.Urbanairship.Push.Proto.Messages.Register p0)
			{
				if (id_newBuilder_Lcom_urbanairship_push_proto_Messages_Register_ == IntPtr.Zero)
					id_newBuilder_Lcom_urbanairship_push_proto_Messages_Register_ = JNIEnv.GetStaticMethodID (class_ref, "newBuilder", "(Lcom/urbanairship/push/proto/Messages$Register;)Lcom/urbanairship/push/proto/Messages$Register$Builder;");
				global::Com.Urbanairship.Push.Proto.Messages.Register.Builder __ret = Java.Lang.Object.GetObject<global::Com.Urbanairship.Push.Proto.Messages.Register.Builder> (JNIEnv.CallStaticObjectMethod  (class_ref, id_newBuilder_Lcom_urbanairship_push_proto_Messages_Register_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
				return __ret;
			}

			static IntPtr id_newBuilderForType;
			[Register ("newBuilderForType", "()Lcom/urbanairship/push/proto/Messages$Register$Builder;", "")]
			public global::Com.Urbanairship.Push.Proto.Messages.Register.Builder NewBuilderForType ()
			{
				if (id_newBuilderForType == IntPtr.Zero)
					id_newBuilderForType = JNIEnv.GetMethodID (class_ref, "newBuilderForType", "()Lcom/urbanairship/push/proto/Messages$Register$Builder;");
				return Java.Lang.Object.GetObject<global::Com.Urbanairship.Push.Proto.Messages.Register.Builder> (JNIEnv.CallObjectMethod  (Handle, id_newBuilderForType), JniHandleOwnership.TransferLocalRef);
			}

			static IntPtr id_parseDelimitedFrom_Ljava_io_InputStream_;
			[Register ("parseDelimitedFrom", "(Ljava/io/InputStream;)Lcom/urbanairship/push/proto/Messages$Register;", "")]
			public static global::Com.Urbanairship.Push.Proto.Messages.Register ParseDelimitedFrom (global::System.IO.Stream p0)
			{
				if (id_parseDelimitedFrom_Ljava_io_InputStream_ == IntPtr.Zero)
					id_parseDelimitedFrom_Ljava_io_InputStream_ = JNIEnv.GetStaticMethodID (class_ref, "parseDelimitedFrom", "(Ljava/io/InputStream;)Lcom/urbanairship/push/proto/Messages$Register;");
				IntPtr native_p0 = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (p0);
				global::Com.Urbanairship.Push.Proto.Messages.Register __ret = Java.Lang.Object.GetObject<global::Com.Urbanairship.Push.Proto.Messages.Register> (JNIEnv.CallStaticObjectMethod  (class_ref, id_parseDelimitedFrom_Ljava_io_InputStream_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
				JNIEnv.DeleteLocalRef (native_p0);
				return __ret;
			}

			static IntPtr id_parseDelimitedFrom_Ljava_io_InputStream_Lcom_google_protobuf_ExtensionRegistryLite_;
			[Register ("parseDelimitedFrom", "(Ljava/io/InputStream;Lcom/google/protobuf/ExtensionRegistryLite;)Lcom/urbanairship/push/proto/Messages$Register;", "")]
			public static global::Com.Urbanairship.Push.Proto.Messages.Register ParseDelimitedFrom (global::System.IO.Stream p0, global::Com.Google.Protobuf.ExtensionRegistryLite p1)
			{
				if (id_parseDelimitedFrom_Ljava_io_InputStream_Lcom_google_protobuf_ExtensionRegistryLite_ == IntPtr.Zero)
					id_parseDelimitedFrom_Ljava_io_InputStream_Lcom_google_protobuf_ExtensionRegistryLite_ = JNIEnv.GetStaticMethodID (class_ref, "parseDelimitedFrom", "(Ljava/io/InputStream;Lcom/google/protobuf/ExtensionRegistryLite;)Lcom/urbanairship/push/proto/Messages$Register;");
				IntPtr native_p0 = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (p0);
				global::Com.Urbanairship.Push.Proto.Messages.Register __ret = Java.Lang.Object.GetObject<global::Com.Urbanairship.Push.Proto.Messages.Register> (JNIEnv.CallStaticObjectMethod  (class_ref, id_parseDelimitedFrom_Ljava_io_InputStream_Lcom_google_protobuf_ExtensionRegistryLite_, new JValue (native_p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
				JNIEnv.DeleteLocalRef (native_p0);
				return __ret;
			}

			static IntPtr id_parseFrom_arrayB;
			[Register ("parseFrom", "([B)Lcom/urbanairship/push/proto/Messages$Register;", "")]
			public static global::Com.Urbanairship.Push.Proto.Messages.Register ParseFrom (byte[] p0)
			{
				if (id_parseFrom_arrayB == IntPtr.Zero)
					id_parseFrom_arrayB = JNIEnv.GetStaticMethodID (class_ref, "parseFrom", "([B)Lcom/urbanairship/push/proto/Messages$Register;");
				IntPtr native_p0 = JNIEnv.NewArray (p0);
				global::Com.Urbanairship.Push.Proto.Messages.Register __ret = Java.Lang.Object.GetObject<global::Com.Urbanairship.Push.Proto.Messages.Register> (JNIEnv.CallStaticObjectMethod  (class_ref, id_parseFrom_arrayB, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				return __ret;
			}

			static IntPtr id_parseFrom_arrayBLcom_google_protobuf_ExtensionRegistryLite_;
			[Register ("parseFrom", "([BLcom/google/protobuf/ExtensionRegistryLite;)Lcom/urbanairship/push/proto/Messages$Register;", "")]
			public static global::Com.Urbanairship.Push.Proto.Messages.Register ParseFrom (byte[] p0, global::Com.Google.Protobuf.ExtensionRegistryLite p1)
			{
				if (id_parseFrom_arrayBLcom_google_protobuf_ExtensionRegistryLite_ == IntPtr.Zero)
					id_parseFrom_arrayBLcom_google_protobuf_ExtensionRegistryLite_ = JNIEnv.GetStaticMethodID (class_ref, "parseFrom", "([BLcom/google/protobuf/ExtensionRegistryLite;)Lcom/urbanairship/push/proto/Messages$Register;");
				IntPtr native_p0 = JNIEnv.NewArray (p0);
				global::Com.Urbanairship.Push.Proto.Messages.Register __ret = Java.Lang.Object.GetObject<global::Com.Urbanairship.Push.Proto.Messages.Register> (JNIEnv.CallStaticObjectMethod  (class_ref, id_parseFrom_arrayBLcom_google_protobuf_ExtensionRegistryLite_, new JValue (native_p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				return __ret;
			}

			static IntPtr id_parseFrom_Lcom_google_protobuf_ByteString_;
			[Register ("parseFrom", "(Lcom/google/protobuf/ByteString;)Lcom/urbanairship/push/proto/Messages$Register;", "")]
			public static global::Com.Urbanairship.Push.Proto.Messages.Register ParseFrom (global::Com.Google.Protobuf.ByteString p0)
			{
				if (id_parseFrom_Lcom_google_protobuf_ByteString_ == IntPtr.Zero)
					id_parseFrom_Lcom_google_protobuf_ByteString_ = JNIEnv.GetStaticMethodID (class_ref, "parseFrom", "(Lcom/google/protobuf/ByteString;)Lcom/urbanairship/push/proto/Messages$Register;");
				global::Com.Urbanairship.Push.Proto.Messages.Register __ret = Java.Lang.Object.GetObject<global::Com.Urbanairship.Push.Proto.Messages.Register> (JNIEnv.CallStaticObjectMethod  (class_ref, id_parseFrom_Lcom_google_protobuf_ByteString_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
				return __ret;
			}

			static IntPtr id_parseFrom_Lcom_google_protobuf_ByteString_Lcom_google_protobuf_ExtensionRegistryLite_;
			[Register ("parseFrom", "(Lcom/google/protobuf/ByteString;Lcom/google/protobuf/ExtensionRegistryLite;)Lcom/urbanairship/push/proto/Messages$Register;", "")]
			public static global::Com.Urbanairship.Push.Proto.Messages.Register ParseFrom (global::Com.Google.Protobuf.ByteString p0, global::Com.Google.Protobuf.ExtensionRegistryLite p1)
			{
				if (id_parseFrom_Lcom_google_protobuf_ByteString_Lcom_google_protobuf_ExtensionRegistryLite_ == IntPtr.Zero)
					id_parseFrom_Lcom_google_protobuf_ByteString_Lcom_google_protobuf_ExtensionRegistryLite_ = JNIEnv.GetStaticMethodID (class_ref, "parseFrom", "(Lcom/google/protobuf/ByteString;Lcom/google/protobuf/ExtensionRegistryLite;)Lcom/urbanairship/push/proto/Messages$Register;");
				global::Com.Urbanairship.Push.Proto.Messages.Register __ret = Java.Lang.Object.GetObject<global::Com.Urbanairship.Push.Proto.Messages.Register> (JNIEnv.CallStaticObjectMethod  (class_ref, id_parseFrom_Lcom_google_protobuf_ByteString_Lcom_google_protobuf_ExtensionRegistryLite_, new JValue (p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
				return __ret;
			}

			static IntPtr id_parseFrom_Lcom_google_protobuf_CodedInputStream_;
			[Register ("parseFrom", "(Lcom/google/protobuf/CodedInputStream;)Lcom/urbanairship/push/proto/Messages$Register;", "")]
			public static global::Com.Urbanairship.Push.Proto.Messages.Register ParseFrom (global::Com.Google.Protobuf.CodedInputStream p0)
			{
				if (id_parseFrom_Lcom_google_protobuf_CodedInputStream_ == IntPtr.Zero)
					id_parseFrom_Lcom_google_protobuf_CodedInputStream_ = JNIEnv.GetStaticMethodID (class_ref, "parseFrom", "(Lcom/google/protobuf/CodedInputStream;)Lcom/urbanairship/push/proto/Messages$Register;");
				global::Com.Urbanairship.Push.Proto.Messages.Register __ret = Java.Lang.Object.GetObject<global::Com.Urbanairship.Push.Proto.Messages.Register> (JNIEnv.CallStaticObjectMethod  (class_ref, id_parseFrom_Lcom_google_protobuf_CodedInputStream_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
				return __ret;
			}

			static IntPtr id_parseFrom_Lcom_google_protobuf_CodedInputStream_Lcom_google_protobuf_ExtensionRegistryLite_;
			[Register ("parseFrom", "(Lcom/google/protobuf/CodedInputStream;Lcom/google/protobuf/ExtensionRegistryLite;)Lcom/urbanairship/push/proto/Messages$Register;", "")]
			public static global::Com.Urbanairship.Push.Proto.Messages.Register ParseFrom (global::Com.Google.Protobuf.CodedInputStream p0, global::Com.Google.Protobuf.ExtensionRegistryLite p1)
			{
				if (id_parseFrom_Lcom_google_protobuf_CodedInputStream_Lcom_google_protobuf_ExtensionRegistryLite_ == IntPtr.Zero)
					id_parseFrom_Lcom_google_protobuf_CodedInputStream_Lcom_google_protobuf_ExtensionRegistryLite_ = JNIEnv.GetStaticMethodID (class_ref, "parseFrom", "(Lcom/google/protobuf/CodedInputStream;Lcom/google/protobuf/ExtensionRegistryLite;)Lcom/urbanairship/push/proto/Messages$Register;");
				global::Com.Urbanairship.Push.Proto.Messages.Register __ret = Java.Lang.Object.GetObject<global::Com.Urbanairship.Push.Proto.Messages.Register> (JNIEnv.CallStaticObjectMethod  (class_ref, id_parseFrom_Lcom_google_protobuf_CodedInputStream_Lcom_google_protobuf_ExtensionRegistryLite_, new JValue (p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
				return __ret;
			}

			static IntPtr id_parseFrom_Ljava_io_InputStream_;
			[Register ("parseFrom", "(Ljava/io/InputStream;)Lcom/urbanairship/push/proto/Messages$Register;", "")]
			public static global::Com.Urbanairship.Push.Proto.Messages.Register ParseFrom (global::System.IO.Stream p0)
			{
				if (id_parseFrom_Ljava_io_InputStream_ == IntPtr.Zero)
					id_parseFrom_Ljava_io_InputStream_ = JNIEnv.GetStaticMethodID (class_ref, "parseFrom", "(Ljava/io/InputStream;)Lcom/urbanairship/push/proto/Messages$Register;");
				IntPtr native_p0 = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (p0);
				global::Com.Urbanairship.Push.Proto.Messages.Register __ret = Java.Lang.Object.GetObject<global::Com.Urbanairship.Push.Proto.Messages.Register> (JNIEnv.CallStaticObjectMethod  (class_ref, id_parseFrom_Ljava_io_InputStream_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
				JNIEnv.DeleteLocalRef (native_p0);
				return __ret;
			}

			static IntPtr id_parseFrom_Ljava_io_InputStream_Lcom_google_protobuf_ExtensionRegistryLite_;
			[Register ("parseFrom", "(Ljava/io/InputStream;Lcom/google/protobuf/ExtensionRegistryLite;)Lcom/urbanairship/push/proto/Messages$Register;", "")]
			public static global::Com.Urbanairship.Push.Proto.Messages.Register ParseFrom (global::System.IO.Stream p0, global::Com.Google.Protobuf.ExtensionRegistryLite p1)
			{
				if (id_parseFrom_Ljava_io_InputStream_Lcom_google_protobuf_ExtensionRegistryLite_ == IntPtr.Zero)
					id_parseFrom_Ljava_io_InputStream_Lcom_google_protobuf_ExtensionRegistryLite_ = JNIEnv.GetStaticMethodID (class_ref, "parseFrom", "(Ljava/io/InputStream;Lcom/google/protobuf/ExtensionRegistryLite;)Lcom/urbanairship/push/proto/Messages$Register;");
				IntPtr native_p0 = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (p0);
				global::Com.Urbanairship.Push.Proto.Messages.Register __ret = Java.Lang.Object.GetObject<global::Com.Urbanairship.Push.Proto.Messages.Register> (JNIEnv.CallStaticObjectMethod  (class_ref, id_parseFrom_Ljava_io_InputStream_Lcom_google_protobuf_ExtensionRegistryLite_, new JValue (native_p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
				JNIEnv.DeleteLocalRef (native_p0);
				return __ret;
			}

			static IntPtr id_toBuilder;
			[Register ("toBuilder", "()Lcom/urbanairship/push/proto/Messages$Register$Builder;", "")]
			public global::Com.Urbanairship.Push.Proto.Messages.Register.Builder ToBuilder ()
			{
				if (id_toBuilder == IntPtr.Zero)
					id_toBuilder = JNIEnv.GetMethodID (class_ref, "toBuilder", "()Lcom/urbanairship/push/proto/Messages$Register$Builder;");
				return Java.Lang.Object.GetObject<global::Com.Urbanairship.Push.Proto.Messages.Register.Builder> (JNIEnv.CallObjectMethod  (Handle, id_toBuilder), JniHandleOwnership.TransferLocalRef);
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

		[global::Android.Runtime.Register ("com/urbanairship/push/proto/Messages$RegistrationEnvelope", DoNotGenerateAcw=true)]
		public sealed partial class RegistrationEnvelope : global::Com.Google.Protobuf.GeneratedMessageLite {


			[Register ("APID_FIELD_NUMBER")]
			public const int ApidFieldNumber = (int) 1;

			[Register ("REGISTRATION_FIELD_NUMBER")]
			public const int RegistrationFieldNumber = (int) 2;
			[global::Android.Runtime.Register ("com/urbanairship/push/proto/Messages$RegistrationEnvelope$Builder", DoNotGenerateAcw=true)]
			public new sealed partial class Builder : global::Com.Google.Protobuf.GeneratedMessageLite.Builder {

				internal static IntPtr java_class_handle;
				internal static IntPtr class_ref {
					get {
						return JNIEnv.FindClass ("com/urbanairship/push/proto/Messages$RegistrationEnvelope$Builder", ref java_class_handle);
					}
				}

				protected override IntPtr ThresholdClass {
					get { return class_ref; }
				}

				protected override global::System.Type ThresholdType {
					get { return typeof (Builder); }
				}

				internal Builder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

				static IntPtr id_getApid;
				public string Apid {
					[Register ("getApid", "()Ljava/lang/String;", "GetGetApidHandler")]
					get {
						if (id_getApid == IntPtr.Zero)
							id_getApid = JNIEnv.GetMethodID (class_ref, "getApid", "()Ljava/lang/String;");
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getApid), JniHandleOwnership.TransferLocalRef);
					}
				}

				static IntPtr id_getDefaultInstanceForType;
				public override global::Com.Urbanairship.Push.Proto.Messages.RegistrationEnvelope DefaultInstanceForType {
					[Register ("getDefaultInstanceForType", "()Lcom/urbanairship/push/proto/Messages$RegistrationEnvelope;", "GetGetDefaultInstanceForTypeHandler")]
					get {
						if (id_getDefaultInstanceForType == IntPtr.Zero)
							id_getDefaultInstanceForType = JNIEnv.GetMethodID (class_ref, "getDefaultInstanceForType", "()Lcom/urbanairship/push/proto/Messages$RegistrationEnvelope;");
						return Java.Lang.Object.GetObject<global::Com.Urbanairship.Push.Proto.Messages.RegistrationEnvelope> (JNIEnv.CallObjectMethod  (Handle, id_getDefaultInstanceForType), JniHandleOwnership.TransferLocalRef);
					}
				}

				static IntPtr id_hasApid;
				public bool HasApid {
					[Register ("hasApid", "()Z", "GetHasApidHandler")]
					get {
						if (id_hasApid == IntPtr.Zero)
							id_hasApid = JNIEnv.GetMethodID (class_ref, "hasApid", "()Z");
						return JNIEnv.CallBooleanMethod  (Handle, id_hasApid);
					}
				}

				static IntPtr id_hasRegistration;
				public bool HasRegistration {
					[Register ("hasRegistration", "()Z", "GetHasRegistrationHandler")]
					get {
						if (id_hasRegistration == IntPtr.Zero)
							id_hasRegistration = JNIEnv.GetMethodID (class_ref, "hasRegistration", "()Z");
						return JNIEnv.CallBooleanMethod  (Handle, id_hasRegistration);
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

				static IntPtr id_getRegistration;
				public global::Com.Google.Protobuf.ByteString Registration {
					[Register ("getRegistration", "()Lcom/google/protobuf/ByteString;", "GetGetRegistrationHandler")]
					get {
						if (id_getRegistration == IntPtr.Zero)
							id_getRegistration = JNIEnv.GetMethodID (class_ref, "getRegistration", "()Lcom/google/protobuf/ByteString;");
						return Java.Lang.Object.GetObject<global::Com.Google.Protobuf.ByteString> (JNIEnv.CallObjectMethod  (Handle, id_getRegistration), JniHandleOwnership.TransferLocalRef);
					}
				}

				static IntPtr id_build;
				[Register ("build", "()Lcom/urbanairship/push/proto/Messages$RegistrationEnvelope;", "")]
				public global::Com.Urbanairship.Push.Proto.Messages.RegistrationEnvelope Build ()
				{
					if (id_build == IntPtr.Zero)
						id_build = JNIEnv.GetMethodID (class_ref, "build", "()Lcom/urbanairship/push/proto/Messages$RegistrationEnvelope;");
					return Java.Lang.Object.GetObject<global::Com.Urbanairship.Push.Proto.Messages.RegistrationEnvelope> (JNIEnv.CallObjectMethod  (Handle, id_build), JniHandleOwnership.TransferLocalRef);
				}

				static IntPtr id_buildPartial;
				[Register ("buildPartial", "()Lcom/urbanairship/push/proto/Messages$RegistrationEnvelope;", "")]
				public global::Com.Urbanairship.Push.Proto.Messages.RegistrationEnvelope BuildPartial ()
				{
					if (id_buildPartial == IntPtr.Zero)
						id_buildPartial = JNIEnv.GetMethodID (class_ref, "buildPartial", "()Lcom/urbanairship/push/proto/Messages$RegistrationEnvelope;");
					return Java.Lang.Object.GetObject<global::Com.Urbanairship.Push.Proto.Messages.RegistrationEnvelope> (JNIEnv.CallObjectMethod  (Handle, id_buildPartial), JniHandleOwnership.TransferLocalRef);
				}

				static IntPtr id_clear;
				[Register ("clear", "()Lcom/urbanairship/push/proto/Messages$RegistrationEnvelope$Builder;", "")]
				public global::Com.Urbanairship.Push.Proto.Messages.RegistrationEnvelope.Builder Clear ()
				{
					if (id_clear == IntPtr.Zero)
						id_clear = JNIEnv.GetMethodID (class_ref, "clear", "()Lcom/urbanairship/push/proto/Messages$RegistrationEnvelope$Builder;");
					return Java.Lang.Object.GetObject<global::Com.Urbanairship.Push.Proto.Messages.RegistrationEnvelope.Builder> (JNIEnv.CallObjectMethod  (Handle, id_clear), JniHandleOwnership.TransferLocalRef);
				}

				static IntPtr id_clearApid;
				[Register ("clearApid", "()Lcom/urbanairship/push/proto/Messages$RegistrationEnvelope$Builder;", "")]
				public global::Com.Urbanairship.Push.Proto.Messages.RegistrationEnvelope.Builder ClearApid ()
				{
					if (id_clearApid == IntPtr.Zero)
						id_clearApid = JNIEnv.GetMethodID (class_ref, "clearApid", "()Lcom/urbanairship/push/proto/Messages$RegistrationEnvelope$Builder;");
					return Java.Lang.Object.GetObject<global::Com.Urbanairship.Push.Proto.Messages.RegistrationEnvelope.Builder> (JNIEnv.CallObjectMethod  (Handle, id_clearApid), JniHandleOwnership.TransferLocalRef);
				}

				static IntPtr id_clearRegistration;
				[Register ("clearRegistration", "()Lcom/urbanairship/push/proto/Messages$RegistrationEnvelope$Builder;", "")]
				public global::Com.Urbanairship.Push.Proto.Messages.RegistrationEnvelope.Builder ClearRegistration ()
				{
					if (id_clearRegistration == IntPtr.Zero)
						id_clearRegistration = JNIEnv.GetMethodID (class_ref, "clearRegistration", "()Lcom/urbanairship/push/proto/Messages$RegistrationEnvelope$Builder;");
					return Java.Lang.Object.GetObject<global::Com.Urbanairship.Push.Proto.Messages.RegistrationEnvelope.Builder> (JNIEnv.CallObjectMethod  (Handle, id_clearRegistration), JniHandleOwnership.TransferLocalRef);
				}

				static IntPtr id_internalGetResult;
				[Register ("internalGetResult", "()Lcom/urbanairship/push/proto/Messages$RegistrationEnvelope;", "")]
				protected override global::Com.Urbanairship.Push.Proto.Messages.RegistrationEnvelope InternalGetResult ()
				{
					if (id_internalGetResult == IntPtr.Zero)
						id_internalGetResult = JNIEnv.GetMethodID (class_ref, "internalGetResult", "()Lcom/urbanairship/push/proto/Messages$RegistrationEnvelope;");
					return Java.Lang.Object.GetObject<global::Com.Urbanairship.Push.Proto.Messages.RegistrationEnvelope> (JNIEnv.CallObjectMethod  (Handle, id_internalGetResult), JniHandleOwnership.TransferLocalRef);
				}

				static IntPtr id_mergeFrom_Lcom_google_protobuf_CodedInputStream_Lcom_google_protobuf_ExtensionRegistryLite_;
				[Register ("mergeFrom", "(Lcom/google/protobuf/CodedInputStream;Lcom/google/protobuf/ExtensionRegistryLite;)Lcom/urbanairship/push/proto/Messages$RegistrationEnvelope$Builder;", "")]
				public override global::Com.Urbanairship.Push.Proto.Messages.RegistrationEnvelope.Builder MergeFrom (global::Com.Google.Protobuf.CodedInputStream p0, global::Com.Google.Protobuf.ExtensionRegistryLite p1)
				{
					if (id_mergeFrom_Lcom_google_protobuf_CodedInputStream_Lcom_google_protobuf_ExtensionRegistryLite_ == IntPtr.Zero)
						id_mergeFrom_Lcom_google_protobuf_CodedInputStream_Lcom_google_protobuf_ExtensionRegistryLite_ = JNIEnv.GetMethodID (class_ref, "mergeFrom", "(Lcom/google/protobuf/CodedInputStream;Lcom/google/protobuf/ExtensionRegistryLite;)Lcom/urbanairship/push/proto/Messages$RegistrationEnvelope$Builder;");
					global::Com.Urbanairship.Push.Proto.Messages.RegistrationEnvelope.Builder __ret = Java.Lang.Object.GetObject<global::Com.Urbanairship.Push.Proto.Messages.RegistrationEnvelope.Builder> (JNIEnv.CallObjectMethod  (Handle, id_mergeFrom_Lcom_google_protobuf_CodedInputStream_Lcom_google_protobuf_ExtensionRegistryLite_, new JValue (p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
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

				static IntPtr id_mergeFrom_Lcom_urbanairship_push_proto_Messages_RegistrationEnvelope_;
				[Register ("mergeFrom", "(Lcom/urbanairship/push/proto/Messages$RegistrationEnvelope;)Lcom/urbanairship/push/proto/Messages$RegistrationEnvelope$Builder;", "")]
				public global::Com.Urbanairship.Push.Proto.Messages.RegistrationEnvelope.Builder MergeFrom (global::Com.Urbanairship.Push.Proto.Messages.RegistrationEnvelope p0)
				{
					if (id_mergeFrom_Lcom_urbanairship_push_proto_Messages_RegistrationEnvelope_ == IntPtr.Zero)
						id_mergeFrom_Lcom_urbanairship_push_proto_Messages_RegistrationEnvelope_ = JNIEnv.GetMethodID (class_ref, "mergeFrom", "(Lcom/urbanairship/push/proto/Messages$RegistrationEnvelope;)Lcom/urbanairship/push/proto/Messages$RegistrationEnvelope$Builder;");
					global::Com.Urbanairship.Push.Proto.Messages.RegistrationEnvelope.Builder __ret = Java.Lang.Object.GetObject<global::Com.Urbanairship.Push.Proto.Messages.RegistrationEnvelope.Builder> (JNIEnv.CallObjectMethod  (Handle, id_mergeFrom_Lcom_urbanairship_push_proto_Messages_RegistrationEnvelope_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
					return __ret;
				}

				static IntPtr id_setApid_Ljava_lang_String_;
				[Register ("setApid", "(Ljava/lang/String;)Lcom/urbanairship/push/proto/Messages$RegistrationEnvelope$Builder;", "")]
				public global::Com.Urbanairship.Push.Proto.Messages.RegistrationEnvelope.Builder SetApid (string p0)
				{
					if (id_setApid_Ljava_lang_String_ == IntPtr.Zero)
						id_setApid_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setApid", "(Ljava/lang/String;)Lcom/urbanairship/push/proto/Messages$RegistrationEnvelope$Builder;");
					IntPtr native_p0 = JNIEnv.NewString (p0);
					global::Com.Urbanairship.Push.Proto.Messages.RegistrationEnvelope.Builder __ret = Java.Lang.Object.GetObject<global::Com.Urbanairship.Push.Proto.Messages.RegistrationEnvelope.Builder> (JNIEnv.CallObjectMethod  (Handle, id_setApid_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
					JNIEnv.DeleteLocalRef (native_p0);
					return __ret;
				}

				static IntPtr id_setRegistration_Lcom_google_protobuf_ByteString_;
				[Register ("setRegistration", "(Lcom/google/protobuf/ByteString;)Lcom/urbanairship/push/proto/Messages$RegistrationEnvelope$Builder;", "")]
				public global::Com.Urbanairship.Push.Proto.Messages.RegistrationEnvelope.Builder SetRegistration (global::Com.Google.Protobuf.ByteString p0)
				{
					if (id_setRegistration_Lcom_google_protobuf_ByteString_ == IntPtr.Zero)
						id_setRegistration_Lcom_google_protobuf_ByteString_ = JNIEnv.GetMethodID (class_ref, "setRegistration", "(Lcom/google/protobuf/ByteString;)Lcom/urbanairship/push/proto/Messages$RegistrationEnvelope$Builder;");
					global::Com.Urbanairship.Push.Proto.Messages.RegistrationEnvelope.Builder __ret = Java.Lang.Object.GetObject<global::Com.Urbanairship.Push.Proto.Messages.RegistrationEnvelope.Builder> (JNIEnv.CallObjectMethod  (Handle, id_setRegistration_Lcom_google_protobuf_ByteString_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
					return __ret;
				}

			}

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/urbanairship/push/proto/Messages$RegistrationEnvelope", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (RegistrationEnvelope); }
			}

			internal RegistrationEnvelope (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_getApid;
			public string Apid {
				[Register ("getApid", "()Ljava/lang/String;", "GetGetApidHandler")]
				get {
					if (id_getApid == IntPtr.Zero)
						id_getApid = JNIEnv.GetMethodID (class_ref, "getApid", "()Ljava/lang/String;");
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getApid), JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr id_getDefaultInstance;
			public static global::Com.Urbanairship.Push.Proto.Messages.RegistrationEnvelope DefaultInstance {
				[Register ("getDefaultInstance", "()Lcom/urbanairship/push/proto/Messages$RegistrationEnvelope;", "GetGetDefaultInstanceHandler")]
				get {
					if (id_getDefaultInstance == IntPtr.Zero)
						id_getDefaultInstance = JNIEnv.GetStaticMethodID (class_ref, "getDefaultInstance", "()Lcom/urbanairship/push/proto/Messages$RegistrationEnvelope;");
					return Java.Lang.Object.GetObject<global::Com.Urbanairship.Push.Proto.Messages.RegistrationEnvelope> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getDefaultInstance), JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr id_getDefaultInstanceForType;
			public override global::Com.Urbanairship.Push.Proto.Messages.RegistrationEnvelope DefaultInstanceForType {
				[Register ("getDefaultInstanceForType", "()Lcom/urbanairship/push/proto/Messages$RegistrationEnvelope;", "GetGetDefaultInstanceForTypeHandler")]
				get {
					if (id_getDefaultInstanceForType == IntPtr.Zero)
						id_getDefaultInstanceForType = JNIEnv.GetMethodID (class_ref, "getDefaultInstanceForType", "()Lcom/urbanairship/push/proto/Messages$RegistrationEnvelope;");
					return Java.Lang.Object.GetObject<global::Com.Urbanairship.Push.Proto.Messages.RegistrationEnvelope> (JNIEnv.CallObjectMethod  (Handle, id_getDefaultInstanceForType), JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr id_hasApid;
			public bool HasApid {
				[Register ("hasApid", "()Z", "GetHasApidHandler")]
				get {
					if (id_hasApid == IntPtr.Zero)
						id_hasApid = JNIEnv.GetMethodID (class_ref, "hasApid", "()Z");
					return JNIEnv.CallBooleanMethod  (Handle, id_hasApid);
				}
			}

			static IntPtr id_hasRegistration;
			public bool HasRegistration {
				[Register ("hasRegistration", "()Z", "GetHasRegistrationHandler")]
				get {
					if (id_hasRegistration == IntPtr.Zero)
						id_hasRegistration = JNIEnv.GetMethodID (class_ref, "hasRegistration", "()Z");
					return JNIEnv.CallBooleanMethod  (Handle, id_hasRegistration);
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

			static IntPtr id_getRegistration;
			public global::Com.Google.Protobuf.ByteString Registration {
				[Register ("getRegistration", "()Lcom/google/protobuf/ByteString;", "GetGetRegistrationHandler")]
				get {
					if (id_getRegistration == IntPtr.Zero)
						id_getRegistration = JNIEnv.GetMethodID (class_ref, "getRegistration", "()Lcom/google/protobuf/ByteString;");
					return Java.Lang.Object.GetObject<global::Com.Google.Protobuf.ByteString> (JNIEnv.CallObjectMethod  (Handle, id_getRegistration), JniHandleOwnership.TransferLocalRef);
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
			[Register ("newBuilder", "()Lcom/urbanairship/push/proto/Messages$RegistrationEnvelope$Builder;", "")]
			public static global::Com.Urbanairship.Push.Proto.Messages.RegistrationEnvelope.Builder NewBuilder ()
			{
				if (id_newBuilder == IntPtr.Zero)
					id_newBuilder = JNIEnv.GetStaticMethodID (class_ref, "newBuilder", "()Lcom/urbanairship/push/proto/Messages$RegistrationEnvelope$Builder;");
				return Java.Lang.Object.GetObject<global::Com.Urbanairship.Push.Proto.Messages.RegistrationEnvelope.Builder> (JNIEnv.CallStaticObjectMethod  (class_ref, id_newBuilder), JniHandleOwnership.TransferLocalRef);
			}

			static IntPtr id_newBuilder_Lcom_urbanairship_push_proto_Messages_RegistrationEnvelope_;
			[Register ("newBuilder", "(Lcom/urbanairship/push/proto/Messages$RegistrationEnvelope;)Lcom/urbanairship/push/proto/Messages$RegistrationEnvelope$Builder;", "")]
			public static global::Com.Urbanairship.Push.Proto.Messages.RegistrationEnvelope.Builder NewBuilder (global::Com.Urbanairship.Push.Proto.Messages.RegistrationEnvelope p0)
			{
				if (id_newBuilder_Lcom_urbanairship_push_proto_Messages_RegistrationEnvelope_ == IntPtr.Zero)
					id_newBuilder_Lcom_urbanairship_push_proto_Messages_RegistrationEnvelope_ = JNIEnv.GetStaticMethodID (class_ref, "newBuilder", "(Lcom/urbanairship/push/proto/Messages$RegistrationEnvelope;)Lcom/urbanairship/push/proto/Messages$RegistrationEnvelope$Builder;");
				global::Com.Urbanairship.Push.Proto.Messages.RegistrationEnvelope.Builder __ret = Java.Lang.Object.GetObject<global::Com.Urbanairship.Push.Proto.Messages.RegistrationEnvelope.Builder> (JNIEnv.CallStaticObjectMethod  (class_ref, id_newBuilder_Lcom_urbanairship_push_proto_Messages_RegistrationEnvelope_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
				return __ret;
			}

			static IntPtr id_newBuilderForType;
			[Register ("newBuilderForType", "()Lcom/urbanairship/push/proto/Messages$RegistrationEnvelope$Builder;", "")]
			public global::Com.Urbanairship.Push.Proto.Messages.RegistrationEnvelope.Builder NewBuilderForType ()
			{
				if (id_newBuilderForType == IntPtr.Zero)
					id_newBuilderForType = JNIEnv.GetMethodID (class_ref, "newBuilderForType", "()Lcom/urbanairship/push/proto/Messages$RegistrationEnvelope$Builder;");
				return Java.Lang.Object.GetObject<global::Com.Urbanairship.Push.Proto.Messages.RegistrationEnvelope.Builder> (JNIEnv.CallObjectMethod  (Handle, id_newBuilderForType), JniHandleOwnership.TransferLocalRef);
			}

			static IntPtr id_parseDelimitedFrom_Ljava_io_InputStream_;
			[Register ("parseDelimitedFrom", "(Ljava/io/InputStream;)Lcom/urbanairship/push/proto/Messages$RegistrationEnvelope;", "")]
			public static global::Com.Urbanairship.Push.Proto.Messages.RegistrationEnvelope ParseDelimitedFrom (global::System.IO.Stream p0)
			{
				if (id_parseDelimitedFrom_Ljava_io_InputStream_ == IntPtr.Zero)
					id_parseDelimitedFrom_Ljava_io_InputStream_ = JNIEnv.GetStaticMethodID (class_ref, "parseDelimitedFrom", "(Ljava/io/InputStream;)Lcom/urbanairship/push/proto/Messages$RegistrationEnvelope;");
				IntPtr native_p0 = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (p0);
				global::Com.Urbanairship.Push.Proto.Messages.RegistrationEnvelope __ret = Java.Lang.Object.GetObject<global::Com.Urbanairship.Push.Proto.Messages.RegistrationEnvelope> (JNIEnv.CallStaticObjectMethod  (class_ref, id_parseDelimitedFrom_Ljava_io_InputStream_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
				JNIEnv.DeleteLocalRef (native_p0);
				return __ret;
			}

			static IntPtr id_parseDelimitedFrom_Ljava_io_InputStream_Lcom_google_protobuf_ExtensionRegistryLite_;
			[Register ("parseDelimitedFrom", "(Ljava/io/InputStream;Lcom/google/protobuf/ExtensionRegistryLite;)Lcom/urbanairship/push/proto/Messages$RegistrationEnvelope;", "")]
			public static global::Com.Urbanairship.Push.Proto.Messages.RegistrationEnvelope ParseDelimitedFrom (global::System.IO.Stream p0, global::Com.Google.Protobuf.ExtensionRegistryLite p1)
			{
				if (id_parseDelimitedFrom_Ljava_io_InputStream_Lcom_google_protobuf_ExtensionRegistryLite_ == IntPtr.Zero)
					id_parseDelimitedFrom_Ljava_io_InputStream_Lcom_google_protobuf_ExtensionRegistryLite_ = JNIEnv.GetStaticMethodID (class_ref, "parseDelimitedFrom", "(Ljava/io/InputStream;Lcom/google/protobuf/ExtensionRegistryLite;)Lcom/urbanairship/push/proto/Messages$RegistrationEnvelope;");
				IntPtr native_p0 = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (p0);
				global::Com.Urbanairship.Push.Proto.Messages.RegistrationEnvelope __ret = Java.Lang.Object.GetObject<global::Com.Urbanairship.Push.Proto.Messages.RegistrationEnvelope> (JNIEnv.CallStaticObjectMethod  (class_ref, id_parseDelimitedFrom_Ljava_io_InputStream_Lcom_google_protobuf_ExtensionRegistryLite_, new JValue (native_p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
				JNIEnv.DeleteLocalRef (native_p0);
				return __ret;
			}

			static IntPtr id_parseFrom_arrayB;
			[Register ("parseFrom", "([B)Lcom/urbanairship/push/proto/Messages$RegistrationEnvelope;", "")]
			public static global::Com.Urbanairship.Push.Proto.Messages.RegistrationEnvelope ParseFrom (byte[] p0)
			{
				if (id_parseFrom_arrayB == IntPtr.Zero)
					id_parseFrom_arrayB = JNIEnv.GetStaticMethodID (class_ref, "parseFrom", "([B)Lcom/urbanairship/push/proto/Messages$RegistrationEnvelope;");
				IntPtr native_p0 = JNIEnv.NewArray (p0);
				global::Com.Urbanairship.Push.Proto.Messages.RegistrationEnvelope __ret = Java.Lang.Object.GetObject<global::Com.Urbanairship.Push.Proto.Messages.RegistrationEnvelope> (JNIEnv.CallStaticObjectMethod  (class_ref, id_parseFrom_arrayB, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				return __ret;
			}

			static IntPtr id_parseFrom_arrayBLcom_google_protobuf_ExtensionRegistryLite_;
			[Register ("parseFrom", "([BLcom/google/protobuf/ExtensionRegistryLite;)Lcom/urbanairship/push/proto/Messages$RegistrationEnvelope;", "")]
			public static global::Com.Urbanairship.Push.Proto.Messages.RegistrationEnvelope ParseFrom (byte[] p0, global::Com.Google.Protobuf.ExtensionRegistryLite p1)
			{
				if (id_parseFrom_arrayBLcom_google_protobuf_ExtensionRegistryLite_ == IntPtr.Zero)
					id_parseFrom_arrayBLcom_google_protobuf_ExtensionRegistryLite_ = JNIEnv.GetStaticMethodID (class_ref, "parseFrom", "([BLcom/google/protobuf/ExtensionRegistryLite;)Lcom/urbanairship/push/proto/Messages$RegistrationEnvelope;");
				IntPtr native_p0 = JNIEnv.NewArray (p0);
				global::Com.Urbanairship.Push.Proto.Messages.RegistrationEnvelope __ret = Java.Lang.Object.GetObject<global::Com.Urbanairship.Push.Proto.Messages.RegistrationEnvelope> (JNIEnv.CallStaticObjectMethod  (class_ref, id_parseFrom_arrayBLcom_google_protobuf_ExtensionRegistryLite_, new JValue (native_p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				return __ret;
			}

			static IntPtr id_parseFrom_Lcom_google_protobuf_ByteString_;
			[Register ("parseFrom", "(Lcom/google/protobuf/ByteString;)Lcom/urbanairship/push/proto/Messages$RegistrationEnvelope;", "")]
			public static global::Com.Urbanairship.Push.Proto.Messages.RegistrationEnvelope ParseFrom (global::Com.Google.Protobuf.ByteString p0)
			{
				if (id_parseFrom_Lcom_google_protobuf_ByteString_ == IntPtr.Zero)
					id_parseFrom_Lcom_google_protobuf_ByteString_ = JNIEnv.GetStaticMethodID (class_ref, "parseFrom", "(Lcom/google/protobuf/ByteString;)Lcom/urbanairship/push/proto/Messages$RegistrationEnvelope;");
				global::Com.Urbanairship.Push.Proto.Messages.RegistrationEnvelope __ret = Java.Lang.Object.GetObject<global::Com.Urbanairship.Push.Proto.Messages.RegistrationEnvelope> (JNIEnv.CallStaticObjectMethod  (class_ref, id_parseFrom_Lcom_google_protobuf_ByteString_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
				return __ret;
			}

			static IntPtr id_parseFrom_Lcom_google_protobuf_ByteString_Lcom_google_protobuf_ExtensionRegistryLite_;
			[Register ("parseFrom", "(Lcom/google/protobuf/ByteString;Lcom/google/protobuf/ExtensionRegistryLite;)Lcom/urbanairship/push/proto/Messages$RegistrationEnvelope;", "")]
			public static global::Com.Urbanairship.Push.Proto.Messages.RegistrationEnvelope ParseFrom (global::Com.Google.Protobuf.ByteString p0, global::Com.Google.Protobuf.ExtensionRegistryLite p1)
			{
				if (id_parseFrom_Lcom_google_protobuf_ByteString_Lcom_google_protobuf_ExtensionRegistryLite_ == IntPtr.Zero)
					id_parseFrom_Lcom_google_protobuf_ByteString_Lcom_google_protobuf_ExtensionRegistryLite_ = JNIEnv.GetStaticMethodID (class_ref, "parseFrom", "(Lcom/google/protobuf/ByteString;Lcom/google/protobuf/ExtensionRegistryLite;)Lcom/urbanairship/push/proto/Messages$RegistrationEnvelope;");
				global::Com.Urbanairship.Push.Proto.Messages.RegistrationEnvelope __ret = Java.Lang.Object.GetObject<global::Com.Urbanairship.Push.Proto.Messages.RegistrationEnvelope> (JNIEnv.CallStaticObjectMethod  (class_ref, id_parseFrom_Lcom_google_protobuf_ByteString_Lcom_google_protobuf_ExtensionRegistryLite_, new JValue (p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
				return __ret;
			}

			static IntPtr id_parseFrom_Lcom_google_protobuf_CodedInputStream_;
			[Register ("parseFrom", "(Lcom/google/protobuf/CodedInputStream;)Lcom/urbanairship/push/proto/Messages$RegistrationEnvelope;", "")]
			public static global::Com.Urbanairship.Push.Proto.Messages.RegistrationEnvelope ParseFrom (global::Com.Google.Protobuf.CodedInputStream p0)
			{
				if (id_parseFrom_Lcom_google_protobuf_CodedInputStream_ == IntPtr.Zero)
					id_parseFrom_Lcom_google_protobuf_CodedInputStream_ = JNIEnv.GetStaticMethodID (class_ref, "parseFrom", "(Lcom/google/protobuf/CodedInputStream;)Lcom/urbanairship/push/proto/Messages$RegistrationEnvelope;");
				global::Com.Urbanairship.Push.Proto.Messages.RegistrationEnvelope __ret = Java.Lang.Object.GetObject<global::Com.Urbanairship.Push.Proto.Messages.RegistrationEnvelope> (JNIEnv.CallStaticObjectMethod  (class_ref, id_parseFrom_Lcom_google_protobuf_CodedInputStream_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
				return __ret;
			}

			static IntPtr id_parseFrom_Lcom_google_protobuf_CodedInputStream_Lcom_google_protobuf_ExtensionRegistryLite_;
			[Register ("parseFrom", "(Lcom/google/protobuf/CodedInputStream;Lcom/google/protobuf/ExtensionRegistryLite;)Lcom/urbanairship/push/proto/Messages$RegistrationEnvelope;", "")]
			public static global::Com.Urbanairship.Push.Proto.Messages.RegistrationEnvelope ParseFrom (global::Com.Google.Protobuf.CodedInputStream p0, global::Com.Google.Protobuf.ExtensionRegistryLite p1)
			{
				if (id_parseFrom_Lcom_google_protobuf_CodedInputStream_Lcom_google_protobuf_ExtensionRegistryLite_ == IntPtr.Zero)
					id_parseFrom_Lcom_google_protobuf_CodedInputStream_Lcom_google_protobuf_ExtensionRegistryLite_ = JNIEnv.GetStaticMethodID (class_ref, "parseFrom", "(Lcom/google/protobuf/CodedInputStream;Lcom/google/protobuf/ExtensionRegistryLite;)Lcom/urbanairship/push/proto/Messages$RegistrationEnvelope;");
				global::Com.Urbanairship.Push.Proto.Messages.RegistrationEnvelope __ret = Java.Lang.Object.GetObject<global::Com.Urbanairship.Push.Proto.Messages.RegistrationEnvelope> (JNIEnv.CallStaticObjectMethod  (class_ref, id_parseFrom_Lcom_google_protobuf_CodedInputStream_Lcom_google_protobuf_ExtensionRegistryLite_, new JValue (p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
				return __ret;
			}

			static IntPtr id_parseFrom_Ljava_io_InputStream_;
			[Register ("parseFrom", "(Ljava/io/InputStream;)Lcom/urbanairship/push/proto/Messages$RegistrationEnvelope;", "")]
			public static global::Com.Urbanairship.Push.Proto.Messages.RegistrationEnvelope ParseFrom (global::System.IO.Stream p0)
			{
				if (id_parseFrom_Ljava_io_InputStream_ == IntPtr.Zero)
					id_parseFrom_Ljava_io_InputStream_ = JNIEnv.GetStaticMethodID (class_ref, "parseFrom", "(Ljava/io/InputStream;)Lcom/urbanairship/push/proto/Messages$RegistrationEnvelope;");
				IntPtr native_p0 = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (p0);
				global::Com.Urbanairship.Push.Proto.Messages.RegistrationEnvelope __ret = Java.Lang.Object.GetObject<global::Com.Urbanairship.Push.Proto.Messages.RegistrationEnvelope> (JNIEnv.CallStaticObjectMethod  (class_ref, id_parseFrom_Ljava_io_InputStream_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
				JNIEnv.DeleteLocalRef (native_p0);
				return __ret;
			}

			static IntPtr id_parseFrom_Ljava_io_InputStream_Lcom_google_protobuf_ExtensionRegistryLite_;
			[Register ("parseFrom", "(Ljava/io/InputStream;Lcom/google/protobuf/ExtensionRegistryLite;)Lcom/urbanairship/push/proto/Messages$RegistrationEnvelope;", "")]
			public static global::Com.Urbanairship.Push.Proto.Messages.RegistrationEnvelope ParseFrom (global::System.IO.Stream p0, global::Com.Google.Protobuf.ExtensionRegistryLite p1)
			{
				if (id_parseFrom_Ljava_io_InputStream_Lcom_google_protobuf_ExtensionRegistryLite_ == IntPtr.Zero)
					id_parseFrom_Ljava_io_InputStream_Lcom_google_protobuf_ExtensionRegistryLite_ = JNIEnv.GetStaticMethodID (class_ref, "parseFrom", "(Ljava/io/InputStream;Lcom/google/protobuf/ExtensionRegistryLite;)Lcom/urbanairship/push/proto/Messages$RegistrationEnvelope;");
				IntPtr native_p0 = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (p0);
				global::Com.Urbanairship.Push.Proto.Messages.RegistrationEnvelope __ret = Java.Lang.Object.GetObject<global::Com.Urbanairship.Push.Proto.Messages.RegistrationEnvelope> (JNIEnv.CallStaticObjectMethod  (class_ref, id_parseFrom_Ljava_io_InputStream_Lcom_google_protobuf_ExtensionRegistryLite_, new JValue (native_p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
				JNIEnv.DeleteLocalRef (native_p0);
				return __ret;
			}

			static IntPtr id_toBuilder;
			[Register ("toBuilder", "()Lcom/urbanairship/push/proto/Messages$RegistrationEnvelope$Builder;", "")]
			public global::Com.Urbanairship.Push.Proto.Messages.RegistrationEnvelope.Builder ToBuilder ()
			{
				if (id_toBuilder == IntPtr.Zero)
					id_toBuilder = JNIEnv.GetMethodID (class_ref, "toBuilder", "()Lcom/urbanairship/push/proto/Messages$RegistrationEnvelope$Builder;");
				return Java.Lang.Object.GetObject<global::Com.Urbanairship.Push.Proto.Messages.RegistrationEnvelope.Builder> (JNIEnv.CallObjectMethod  (Handle, id_toBuilder), JniHandleOwnership.TransferLocalRef);
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

		[global::Android.Runtime.Register ("com/urbanairship/push/proto/Messages$RegistrationResponse", DoNotGenerateAcw=true)]
		public sealed partial class RegistrationResponse : global::Com.Google.Protobuf.GeneratedMessageLite {


			[Register ("INVALID_RELIERS_FIELD_NUMBER")]
			public const int InvalidReliersFieldNumber = (int) 2;

			[Register ("VALID_RELIERS_FIELD_NUMBER")]
			public const int ValidReliersFieldNumber = (int) 1;
			[global::Android.Runtime.Register ("com/urbanairship/push/proto/Messages$RegistrationResponse$Builder", DoNotGenerateAcw=true)]
			public new sealed partial class Builder : global::Com.Google.Protobuf.GeneratedMessageLite.Builder {

				internal static IntPtr java_class_handle;
				internal static IntPtr class_ref {
					get {
						return JNIEnv.FindClass ("com/urbanairship/push/proto/Messages$RegistrationResponse$Builder", ref java_class_handle);
					}
				}

				protected override IntPtr ThresholdClass {
					get { return class_ref; }
				}

				protected override global::System.Type ThresholdType {
					get { return typeof (Builder); }
				}

				internal Builder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

				static IntPtr id_getDefaultInstanceForType;
				public override global::Com.Urbanairship.Push.Proto.Messages.RegistrationResponse DefaultInstanceForType {
					[Register ("getDefaultInstanceForType", "()Lcom/urbanairship/push/proto/Messages$RegistrationResponse;", "GetGetDefaultInstanceForTypeHandler")]
					get {
						if (id_getDefaultInstanceForType == IntPtr.Zero)
							id_getDefaultInstanceForType = JNIEnv.GetMethodID (class_ref, "getDefaultInstanceForType", "()Lcom/urbanairship/push/proto/Messages$RegistrationResponse;");
						return Java.Lang.Object.GetObject<global::Com.Urbanairship.Push.Proto.Messages.RegistrationResponse> (JNIEnv.CallObjectMethod  (Handle, id_getDefaultInstanceForType), JniHandleOwnership.TransferLocalRef);
					}
				}

				static IntPtr id_getInvalidReliersCount;
				public int InvalidReliersCount {
					[Register ("getInvalidReliersCount", "()I", "GetGetInvalidReliersCountHandler")]
					get {
						if (id_getInvalidReliersCount == IntPtr.Zero)
							id_getInvalidReliersCount = JNIEnv.GetMethodID (class_ref, "getInvalidReliersCount", "()I");
						return JNIEnv.CallIntMethod  (Handle, id_getInvalidReliersCount);
					}
				}

				static IntPtr id_getInvalidReliersList;
				public global::System.Collections.Generic.IList<global::Com.Urbanairship.Push.Proto.Messages.Relier> InvalidReliersList {
					[Register ("getInvalidReliersList", "()Ljava/util/List;", "GetGetInvalidReliersListHandler")]
					get {
						if (id_getInvalidReliersList == IntPtr.Zero)
							id_getInvalidReliersList = JNIEnv.GetMethodID (class_ref, "getInvalidReliersList", "()Ljava/util/List;");
						return global::Android.Runtime.JavaList<global::Com.Urbanairship.Push.Proto.Messages.Relier>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_getInvalidReliersList), JniHandleOwnership.TransferLocalRef);
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

				static IntPtr id_getValidReliersCount;
				public int ValidReliersCount {
					[Register ("getValidReliersCount", "()I", "GetGetValidReliersCountHandler")]
					get {
						if (id_getValidReliersCount == IntPtr.Zero)
							id_getValidReliersCount = JNIEnv.GetMethodID (class_ref, "getValidReliersCount", "()I");
						return JNIEnv.CallIntMethod  (Handle, id_getValidReliersCount);
					}
				}

				static IntPtr id_getValidReliersList;
				public global::System.Collections.Generic.IList<global::Com.Urbanairship.Push.Proto.Messages.Relier> ValidReliersList {
					[Register ("getValidReliersList", "()Ljava/util/List;", "GetGetValidReliersListHandler")]
					get {
						if (id_getValidReliersList == IntPtr.Zero)
							id_getValidReliersList = JNIEnv.GetMethodID (class_ref, "getValidReliersList", "()Ljava/util/List;");
						return global::Android.Runtime.JavaList<global::Com.Urbanairship.Push.Proto.Messages.Relier>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_getValidReliersList), JniHandleOwnership.TransferLocalRef);
					}
				}

				static IntPtr id_addInvalidReliers_Lcom_urbanairship_push_proto_Messages_Relier_;
				[Register ("addInvalidReliers", "(Lcom/urbanairship/push/proto/Messages$Relier;)Lcom/urbanairship/push/proto/Messages$RegistrationResponse$Builder;", "")]
				public global::Com.Urbanairship.Push.Proto.Messages.RegistrationResponse.Builder AddInvalidReliers (global::Com.Urbanairship.Push.Proto.Messages.Relier p0)
				{
					if (id_addInvalidReliers_Lcom_urbanairship_push_proto_Messages_Relier_ == IntPtr.Zero)
						id_addInvalidReliers_Lcom_urbanairship_push_proto_Messages_Relier_ = JNIEnv.GetMethodID (class_ref, "addInvalidReliers", "(Lcom/urbanairship/push/proto/Messages$Relier;)Lcom/urbanairship/push/proto/Messages$RegistrationResponse$Builder;");
					global::Com.Urbanairship.Push.Proto.Messages.RegistrationResponse.Builder __ret = Java.Lang.Object.GetObject<global::Com.Urbanairship.Push.Proto.Messages.RegistrationResponse.Builder> (JNIEnv.CallObjectMethod  (Handle, id_addInvalidReliers_Lcom_urbanairship_push_proto_Messages_Relier_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
					return __ret;
				}

				static IntPtr id_addInvalidReliers_Lcom_urbanairship_push_proto_Messages_Relier_Builder_;
				[Register ("addInvalidReliers", "(Lcom/urbanairship/push/proto/Messages$Relier$Builder;)Lcom/urbanairship/push/proto/Messages$RegistrationResponse$Builder;", "")]
				public global::Com.Urbanairship.Push.Proto.Messages.RegistrationResponse.Builder AddInvalidReliers (global::Com.Urbanairship.Push.Proto.Messages.Relier.Builder p0)
				{
					if (id_addInvalidReliers_Lcom_urbanairship_push_proto_Messages_Relier_Builder_ == IntPtr.Zero)
						id_addInvalidReliers_Lcom_urbanairship_push_proto_Messages_Relier_Builder_ = JNIEnv.GetMethodID (class_ref, "addInvalidReliers", "(Lcom/urbanairship/push/proto/Messages$Relier$Builder;)Lcom/urbanairship/push/proto/Messages$RegistrationResponse$Builder;");
					global::Com.Urbanairship.Push.Proto.Messages.RegistrationResponse.Builder __ret = Java.Lang.Object.GetObject<global::Com.Urbanairship.Push.Proto.Messages.RegistrationResponse.Builder> (JNIEnv.CallObjectMethod  (Handle, id_addInvalidReliers_Lcom_urbanairship_push_proto_Messages_Relier_Builder_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
					return __ret;
				}

				static IntPtr id_addValidReliers_Lcom_urbanairship_push_proto_Messages_Relier_;
				[Register ("addValidReliers", "(Lcom/urbanairship/push/proto/Messages$Relier;)Lcom/urbanairship/push/proto/Messages$RegistrationResponse$Builder;", "")]
				public global::Com.Urbanairship.Push.Proto.Messages.RegistrationResponse.Builder AddValidReliers (global::Com.Urbanairship.Push.Proto.Messages.Relier p0)
				{
					if (id_addValidReliers_Lcom_urbanairship_push_proto_Messages_Relier_ == IntPtr.Zero)
						id_addValidReliers_Lcom_urbanairship_push_proto_Messages_Relier_ = JNIEnv.GetMethodID (class_ref, "addValidReliers", "(Lcom/urbanairship/push/proto/Messages$Relier;)Lcom/urbanairship/push/proto/Messages$RegistrationResponse$Builder;");
					global::Com.Urbanairship.Push.Proto.Messages.RegistrationResponse.Builder __ret = Java.Lang.Object.GetObject<global::Com.Urbanairship.Push.Proto.Messages.RegistrationResponse.Builder> (JNIEnv.CallObjectMethod  (Handle, id_addValidReliers_Lcom_urbanairship_push_proto_Messages_Relier_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
					return __ret;
				}

				static IntPtr id_addValidReliers_Lcom_urbanairship_push_proto_Messages_Relier_Builder_;
				[Register ("addValidReliers", "(Lcom/urbanairship/push/proto/Messages$Relier$Builder;)Lcom/urbanairship/push/proto/Messages$RegistrationResponse$Builder;", "")]
				public global::Com.Urbanairship.Push.Proto.Messages.RegistrationResponse.Builder AddValidReliers (global::Com.Urbanairship.Push.Proto.Messages.Relier.Builder p0)
				{
					if (id_addValidReliers_Lcom_urbanairship_push_proto_Messages_Relier_Builder_ == IntPtr.Zero)
						id_addValidReliers_Lcom_urbanairship_push_proto_Messages_Relier_Builder_ = JNIEnv.GetMethodID (class_ref, "addValidReliers", "(Lcom/urbanairship/push/proto/Messages$Relier$Builder;)Lcom/urbanairship/push/proto/Messages$RegistrationResponse$Builder;");
					global::Com.Urbanairship.Push.Proto.Messages.RegistrationResponse.Builder __ret = Java.Lang.Object.GetObject<global::Com.Urbanairship.Push.Proto.Messages.RegistrationResponse.Builder> (JNIEnv.CallObjectMethod  (Handle, id_addValidReliers_Lcom_urbanairship_push_proto_Messages_Relier_Builder_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
					return __ret;
				}

				static IntPtr id_build;
				[Register ("build", "()Lcom/urbanairship/push/proto/Messages$RegistrationResponse;", "")]
				public global::Com.Urbanairship.Push.Proto.Messages.RegistrationResponse Build ()
				{
					if (id_build == IntPtr.Zero)
						id_build = JNIEnv.GetMethodID (class_ref, "build", "()Lcom/urbanairship/push/proto/Messages$RegistrationResponse;");
					return Java.Lang.Object.GetObject<global::Com.Urbanairship.Push.Proto.Messages.RegistrationResponse> (JNIEnv.CallObjectMethod  (Handle, id_build), JniHandleOwnership.TransferLocalRef);
				}

				static IntPtr id_buildPartial;
				[Register ("buildPartial", "()Lcom/urbanairship/push/proto/Messages$RegistrationResponse;", "")]
				public global::Com.Urbanairship.Push.Proto.Messages.RegistrationResponse BuildPartial ()
				{
					if (id_buildPartial == IntPtr.Zero)
						id_buildPartial = JNIEnv.GetMethodID (class_ref, "buildPartial", "()Lcom/urbanairship/push/proto/Messages$RegistrationResponse;");
					return Java.Lang.Object.GetObject<global::Com.Urbanairship.Push.Proto.Messages.RegistrationResponse> (JNIEnv.CallObjectMethod  (Handle, id_buildPartial), JniHandleOwnership.TransferLocalRef);
				}

				static IntPtr id_clear;
				[Register ("clear", "()Lcom/urbanairship/push/proto/Messages$RegistrationResponse$Builder;", "")]
				public global::Com.Urbanairship.Push.Proto.Messages.RegistrationResponse.Builder Clear ()
				{
					if (id_clear == IntPtr.Zero)
						id_clear = JNIEnv.GetMethodID (class_ref, "clear", "()Lcom/urbanairship/push/proto/Messages$RegistrationResponse$Builder;");
					return Java.Lang.Object.GetObject<global::Com.Urbanairship.Push.Proto.Messages.RegistrationResponse.Builder> (JNIEnv.CallObjectMethod  (Handle, id_clear), JniHandleOwnership.TransferLocalRef);
				}

				static IntPtr id_clearInvalidReliers;
				[Register ("clearInvalidReliers", "()Lcom/urbanairship/push/proto/Messages$RegistrationResponse$Builder;", "")]
				public global::Com.Urbanairship.Push.Proto.Messages.RegistrationResponse.Builder ClearInvalidReliers ()
				{
					if (id_clearInvalidReliers == IntPtr.Zero)
						id_clearInvalidReliers = JNIEnv.GetMethodID (class_ref, "clearInvalidReliers", "()Lcom/urbanairship/push/proto/Messages$RegistrationResponse$Builder;");
					return Java.Lang.Object.GetObject<global::Com.Urbanairship.Push.Proto.Messages.RegistrationResponse.Builder> (JNIEnv.CallObjectMethod  (Handle, id_clearInvalidReliers), JniHandleOwnership.TransferLocalRef);
				}

				static IntPtr id_clearValidReliers;
				[Register ("clearValidReliers", "()Lcom/urbanairship/push/proto/Messages$RegistrationResponse$Builder;", "")]
				public global::Com.Urbanairship.Push.Proto.Messages.RegistrationResponse.Builder ClearValidReliers ()
				{
					if (id_clearValidReliers == IntPtr.Zero)
						id_clearValidReliers = JNIEnv.GetMethodID (class_ref, "clearValidReliers", "()Lcom/urbanairship/push/proto/Messages$RegistrationResponse$Builder;");
					return Java.Lang.Object.GetObject<global::Com.Urbanairship.Push.Proto.Messages.RegistrationResponse.Builder> (JNIEnv.CallObjectMethod  (Handle, id_clearValidReliers), JniHandleOwnership.TransferLocalRef);
				}

				static IntPtr id_getInvalidReliers_I;
				[Register ("getInvalidReliers", "(I)Lcom/urbanairship/push/proto/Messages$Relier;", "")]
				public global::Com.Urbanairship.Push.Proto.Messages.Relier GetInvalidReliers (int p0)
				{
					if (id_getInvalidReliers_I == IntPtr.Zero)
						id_getInvalidReliers_I = JNIEnv.GetMethodID (class_ref, "getInvalidReliers", "(I)Lcom/urbanairship/push/proto/Messages$Relier;");
					return Java.Lang.Object.GetObject<global::Com.Urbanairship.Push.Proto.Messages.Relier> (JNIEnv.CallObjectMethod  (Handle, id_getInvalidReliers_I, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
				}

				static IntPtr id_getValidReliers_I;
				[Register ("getValidReliers", "(I)Lcom/urbanairship/push/proto/Messages$Relier;", "")]
				public global::Com.Urbanairship.Push.Proto.Messages.Relier GetValidReliers (int p0)
				{
					if (id_getValidReliers_I == IntPtr.Zero)
						id_getValidReliers_I = JNIEnv.GetMethodID (class_ref, "getValidReliers", "(I)Lcom/urbanairship/push/proto/Messages$Relier;");
					return Java.Lang.Object.GetObject<global::Com.Urbanairship.Push.Proto.Messages.Relier> (JNIEnv.CallObjectMethod  (Handle, id_getValidReliers_I, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
				}

				static IntPtr id_internalGetResult;
				[Register ("internalGetResult", "()Lcom/urbanairship/push/proto/Messages$RegistrationResponse;", "")]
				protected override global::Com.Urbanairship.Push.Proto.Messages.RegistrationResponse InternalGetResult ()
				{
					if (id_internalGetResult == IntPtr.Zero)
						id_internalGetResult = JNIEnv.GetMethodID (class_ref, "internalGetResult", "()Lcom/urbanairship/push/proto/Messages$RegistrationResponse;");
					return Java.Lang.Object.GetObject<global::Com.Urbanairship.Push.Proto.Messages.RegistrationResponse> (JNIEnv.CallObjectMethod  (Handle, id_internalGetResult), JniHandleOwnership.TransferLocalRef);
				}

				static IntPtr id_mergeFrom_Lcom_google_protobuf_CodedInputStream_Lcom_google_protobuf_ExtensionRegistryLite_;
				[Register ("mergeFrom", "(Lcom/google/protobuf/CodedInputStream;Lcom/google/protobuf/ExtensionRegistryLite;)Lcom/urbanairship/push/proto/Messages$RegistrationResponse$Builder;", "")]
				public override global::Com.Urbanairship.Push.Proto.Messages.RegistrationResponse.Builder MergeFrom (global::Com.Google.Protobuf.CodedInputStream p0, global::Com.Google.Protobuf.ExtensionRegistryLite p1)
				{
					if (id_mergeFrom_Lcom_google_protobuf_CodedInputStream_Lcom_google_protobuf_ExtensionRegistryLite_ == IntPtr.Zero)
						id_mergeFrom_Lcom_google_protobuf_CodedInputStream_Lcom_google_protobuf_ExtensionRegistryLite_ = JNIEnv.GetMethodID (class_ref, "mergeFrom", "(Lcom/google/protobuf/CodedInputStream;Lcom/google/protobuf/ExtensionRegistryLite;)Lcom/urbanairship/push/proto/Messages$RegistrationResponse$Builder;");
					global::Com.Urbanairship.Push.Proto.Messages.RegistrationResponse.Builder __ret = Java.Lang.Object.GetObject<global::Com.Urbanairship.Push.Proto.Messages.RegistrationResponse.Builder> (JNIEnv.CallObjectMethod  (Handle, id_mergeFrom_Lcom_google_protobuf_CodedInputStream_Lcom_google_protobuf_ExtensionRegistryLite_, new JValue (p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
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

				static IntPtr id_mergeFrom_Lcom_urbanairship_push_proto_Messages_RegistrationResponse_;
				[Register ("mergeFrom", "(Lcom/urbanairship/push/proto/Messages$RegistrationResponse;)Lcom/urbanairship/push/proto/Messages$RegistrationResponse$Builder;", "")]
				public global::Com.Urbanairship.Push.Proto.Messages.RegistrationResponse.Builder MergeFrom (global::Com.Urbanairship.Push.Proto.Messages.RegistrationResponse p0)
				{
					if (id_mergeFrom_Lcom_urbanairship_push_proto_Messages_RegistrationResponse_ == IntPtr.Zero)
						id_mergeFrom_Lcom_urbanairship_push_proto_Messages_RegistrationResponse_ = JNIEnv.GetMethodID (class_ref, "mergeFrom", "(Lcom/urbanairship/push/proto/Messages$RegistrationResponse;)Lcom/urbanairship/push/proto/Messages$RegistrationResponse$Builder;");
					global::Com.Urbanairship.Push.Proto.Messages.RegistrationResponse.Builder __ret = Java.Lang.Object.GetObject<global::Com.Urbanairship.Push.Proto.Messages.RegistrationResponse.Builder> (JNIEnv.CallObjectMethod  (Handle, id_mergeFrom_Lcom_urbanairship_push_proto_Messages_RegistrationResponse_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
					return __ret;
				}

				static IntPtr id_setInvalidReliers_ILcom_urbanairship_push_proto_Messages_Relier_;
				[Register ("setInvalidReliers", "(ILcom/urbanairship/push/proto/Messages$Relier;)Lcom/urbanairship/push/proto/Messages$RegistrationResponse$Builder;", "")]
				public global::Com.Urbanairship.Push.Proto.Messages.RegistrationResponse.Builder SetInvalidReliers (int p0, global::Com.Urbanairship.Push.Proto.Messages.Relier p1)
				{
					if (id_setInvalidReliers_ILcom_urbanairship_push_proto_Messages_Relier_ == IntPtr.Zero)
						id_setInvalidReliers_ILcom_urbanairship_push_proto_Messages_Relier_ = JNIEnv.GetMethodID (class_ref, "setInvalidReliers", "(ILcom/urbanairship/push/proto/Messages$Relier;)Lcom/urbanairship/push/proto/Messages$RegistrationResponse$Builder;");
					global::Com.Urbanairship.Push.Proto.Messages.RegistrationResponse.Builder __ret = Java.Lang.Object.GetObject<global::Com.Urbanairship.Push.Proto.Messages.RegistrationResponse.Builder> (JNIEnv.CallObjectMethod  (Handle, id_setInvalidReliers_ILcom_urbanairship_push_proto_Messages_Relier_, new JValue (p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
					return __ret;
				}

				static IntPtr id_setInvalidReliers_ILcom_urbanairship_push_proto_Messages_Relier_Builder_;
				[Register ("setInvalidReliers", "(ILcom/urbanairship/push/proto/Messages$Relier$Builder;)Lcom/urbanairship/push/proto/Messages$RegistrationResponse$Builder;", "")]
				public global::Com.Urbanairship.Push.Proto.Messages.RegistrationResponse.Builder SetInvalidReliers (int p0, global::Com.Urbanairship.Push.Proto.Messages.Relier.Builder p1)
				{
					if (id_setInvalidReliers_ILcom_urbanairship_push_proto_Messages_Relier_Builder_ == IntPtr.Zero)
						id_setInvalidReliers_ILcom_urbanairship_push_proto_Messages_Relier_Builder_ = JNIEnv.GetMethodID (class_ref, "setInvalidReliers", "(ILcom/urbanairship/push/proto/Messages$Relier$Builder;)Lcom/urbanairship/push/proto/Messages$RegistrationResponse$Builder;");
					global::Com.Urbanairship.Push.Proto.Messages.RegistrationResponse.Builder __ret = Java.Lang.Object.GetObject<global::Com.Urbanairship.Push.Proto.Messages.RegistrationResponse.Builder> (JNIEnv.CallObjectMethod  (Handle, id_setInvalidReliers_ILcom_urbanairship_push_proto_Messages_Relier_Builder_, new JValue (p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
					return __ret;
				}

				static IntPtr id_setValidReliers_ILcom_urbanairship_push_proto_Messages_Relier_;
				[Register ("setValidReliers", "(ILcom/urbanairship/push/proto/Messages$Relier;)Lcom/urbanairship/push/proto/Messages$RegistrationResponse$Builder;", "")]
				public global::Com.Urbanairship.Push.Proto.Messages.RegistrationResponse.Builder SetValidReliers (int p0, global::Com.Urbanairship.Push.Proto.Messages.Relier p1)
				{
					if (id_setValidReliers_ILcom_urbanairship_push_proto_Messages_Relier_ == IntPtr.Zero)
						id_setValidReliers_ILcom_urbanairship_push_proto_Messages_Relier_ = JNIEnv.GetMethodID (class_ref, "setValidReliers", "(ILcom/urbanairship/push/proto/Messages$Relier;)Lcom/urbanairship/push/proto/Messages$RegistrationResponse$Builder;");
					global::Com.Urbanairship.Push.Proto.Messages.RegistrationResponse.Builder __ret = Java.Lang.Object.GetObject<global::Com.Urbanairship.Push.Proto.Messages.RegistrationResponse.Builder> (JNIEnv.CallObjectMethod  (Handle, id_setValidReliers_ILcom_urbanairship_push_proto_Messages_Relier_, new JValue (p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
					return __ret;
				}

				static IntPtr id_setValidReliers_ILcom_urbanairship_push_proto_Messages_Relier_Builder_;
				[Register ("setValidReliers", "(ILcom/urbanairship/push/proto/Messages$Relier$Builder;)Lcom/urbanairship/push/proto/Messages$RegistrationResponse$Builder;", "")]
				public global::Com.Urbanairship.Push.Proto.Messages.RegistrationResponse.Builder SetValidReliers (int p0, global::Com.Urbanairship.Push.Proto.Messages.Relier.Builder p1)
				{
					if (id_setValidReliers_ILcom_urbanairship_push_proto_Messages_Relier_Builder_ == IntPtr.Zero)
						id_setValidReliers_ILcom_urbanairship_push_proto_Messages_Relier_Builder_ = JNIEnv.GetMethodID (class_ref, "setValidReliers", "(ILcom/urbanairship/push/proto/Messages$Relier$Builder;)Lcom/urbanairship/push/proto/Messages$RegistrationResponse$Builder;");
					global::Com.Urbanairship.Push.Proto.Messages.RegistrationResponse.Builder __ret = Java.Lang.Object.GetObject<global::Com.Urbanairship.Push.Proto.Messages.RegistrationResponse.Builder> (JNIEnv.CallObjectMethod  (Handle, id_setValidReliers_ILcom_urbanairship_push_proto_Messages_Relier_Builder_, new JValue (p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
					return __ret;
				}

			}

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/urbanairship/push/proto/Messages$RegistrationResponse", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (RegistrationResponse); }
			}

			internal RegistrationResponse (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_getDefaultInstance;
			public static global::Com.Urbanairship.Push.Proto.Messages.RegistrationResponse DefaultInstance {
				[Register ("getDefaultInstance", "()Lcom/urbanairship/push/proto/Messages$RegistrationResponse;", "GetGetDefaultInstanceHandler")]
				get {
					if (id_getDefaultInstance == IntPtr.Zero)
						id_getDefaultInstance = JNIEnv.GetStaticMethodID (class_ref, "getDefaultInstance", "()Lcom/urbanairship/push/proto/Messages$RegistrationResponse;");
					return Java.Lang.Object.GetObject<global::Com.Urbanairship.Push.Proto.Messages.RegistrationResponse> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getDefaultInstance), JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr id_getDefaultInstanceForType;
			public override global::Com.Urbanairship.Push.Proto.Messages.RegistrationResponse DefaultInstanceForType {
				[Register ("getDefaultInstanceForType", "()Lcom/urbanairship/push/proto/Messages$RegistrationResponse;", "GetGetDefaultInstanceForTypeHandler")]
				get {
					if (id_getDefaultInstanceForType == IntPtr.Zero)
						id_getDefaultInstanceForType = JNIEnv.GetMethodID (class_ref, "getDefaultInstanceForType", "()Lcom/urbanairship/push/proto/Messages$RegistrationResponse;");
					return Java.Lang.Object.GetObject<global::Com.Urbanairship.Push.Proto.Messages.RegistrationResponse> (JNIEnv.CallObjectMethod  (Handle, id_getDefaultInstanceForType), JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr id_getInvalidReliersCount;
			public int InvalidReliersCount {
				[Register ("getInvalidReliersCount", "()I", "GetGetInvalidReliersCountHandler")]
				get {
					if (id_getInvalidReliersCount == IntPtr.Zero)
						id_getInvalidReliersCount = JNIEnv.GetMethodID (class_ref, "getInvalidReliersCount", "()I");
					return JNIEnv.CallIntMethod  (Handle, id_getInvalidReliersCount);
				}
			}

			static IntPtr id_getInvalidReliersList;
			public global::System.Collections.Generic.IList<global::Com.Urbanairship.Push.Proto.Messages.Relier> InvalidReliersList {
				[Register ("getInvalidReliersList", "()Ljava/util/List;", "GetGetInvalidReliersListHandler")]
				get {
					if (id_getInvalidReliersList == IntPtr.Zero)
						id_getInvalidReliersList = JNIEnv.GetMethodID (class_ref, "getInvalidReliersList", "()Ljava/util/List;");
					return global::Android.Runtime.JavaList<global::Com.Urbanairship.Push.Proto.Messages.Relier>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_getInvalidReliersList), JniHandleOwnership.TransferLocalRef);
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

			static IntPtr id_getSerializedSize;
			public override int SerializedSize {
				[Register ("getSerializedSize", "()I", "GetGetSerializedSizeHandler")]
				get {
					if (id_getSerializedSize == IntPtr.Zero)
						id_getSerializedSize = JNIEnv.GetMethodID (class_ref, "getSerializedSize", "()I");
					return JNIEnv.CallIntMethod  (Handle, id_getSerializedSize);
				}
			}

			static IntPtr id_getValidReliersCount;
			public int ValidReliersCount {
				[Register ("getValidReliersCount", "()I", "GetGetValidReliersCountHandler")]
				get {
					if (id_getValidReliersCount == IntPtr.Zero)
						id_getValidReliersCount = JNIEnv.GetMethodID (class_ref, "getValidReliersCount", "()I");
					return JNIEnv.CallIntMethod  (Handle, id_getValidReliersCount);
				}
			}

			static IntPtr id_getValidReliersList;
			public global::System.Collections.Generic.IList<global::Com.Urbanairship.Push.Proto.Messages.Relier> ValidReliersList {
				[Register ("getValidReliersList", "()Ljava/util/List;", "GetGetValidReliersListHandler")]
				get {
					if (id_getValidReliersList == IntPtr.Zero)
						id_getValidReliersList = JNIEnv.GetMethodID (class_ref, "getValidReliersList", "()Ljava/util/List;");
					return global::Android.Runtime.JavaList<global::Com.Urbanairship.Push.Proto.Messages.Relier>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_getValidReliersList), JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr id_getInvalidReliers_I;
			[Register ("getInvalidReliers", "(I)Lcom/urbanairship/push/proto/Messages$Relier;", "")]
			public global::Com.Urbanairship.Push.Proto.Messages.Relier GetInvalidReliers (int p0)
			{
				if (id_getInvalidReliers_I == IntPtr.Zero)
					id_getInvalidReliers_I = JNIEnv.GetMethodID (class_ref, "getInvalidReliers", "(I)Lcom/urbanairship/push/proto/Messages$Relier;");
				return Java.Lang.Object.GetObject<global::Com.Urbanairship.Push.Proto.Messages.Relier> (JNIEnv.CallObjectMethod  (Handle, id_getInvalidReliers_I, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			}

			static IntPtr id_getValidReliers_I;
			[Register ("getValidReliers", "(I)Lcom/urbanairship/push/proto/Messages$Relier;", "")]
			public global::Com.Urbanairship.Push.Proto.Messages.Relier GetValidReliers (int p0)
			{
				if (id_getValidReliers_I == IntPtr.Zero)
					id_getValidReliers_I = JNIEnv.GetMethodID (class_ref, "getValidReliers", "(I)Lcom/urbanairship/push/proto/Messages$Relier;");
				return Java.Lang.Object.GetObject<global::Com.Urbanairship.Push.Proto.Messages.Relier> (JNIEnv.CallObjectMethod  (Handle, id_getValidReliers_I, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			}

			static IntPtr id_newBuilder;
			[Register ("newBuilder", "()Lcom/urbanairship/push/proto/Messages$RegistrationResponse$Builder;", "")]
			public static global::Com.Urbanairship.Push.Proto.Messages.RegistrationResponse.Builder NewBuilder ()
			{
				if (id_newBuilder == IntPtr.Zero)
					id_newBuilder = JNIEnv.GetStaticMethodID (class_ref, "newBuilder", "()Lcom/urbanairship/push/proto/Messages$RegistrationResponse$Builder;");
				return Java.Lang.Object.GetObject<global::Com.Urbanairship.Push.Proto.Messages.RegistrationResponse.Builder> (JNIEnv.CallStaticObjectMethod  (class_ref, id_newBuilder), JniHandleOwnership.TransferLocalRef);
			}

			static IntPtr id_newBuilder_Lcom_urbanairship_push_proto_Messages_RegistrationResponse_;
			[Register ("newBuilder", "(Lcom/urbanairship/push/proto/Messages$RegistrationResponse;)Lcom/urbanairship/push/proto/Messages$RegistrationResponse$Builder;", "")]
			public static global::Com.Urbanairship.Push.Proto.Messages.RegistrationResponse.Builder NewBuilder (global::Com.Urbanairship.Push.Proto.Messages.RegistrationResponse p0)
			{
				if (id_newBuilder_Lcom_urbanairship_push_proto_Messages_RegistrationResponse_ == IntPtr.Zero)
					id_newBuilder_Lcom_urbanairship_push_proto_Messages_RegistrationResponse_ = JNIEnv.GetStaticMethodID (class_ref, "newBuilder", "(Lcom/urbanairship/push/proto/Messages$RegistrationResponse;)Lcom/urbanairship/push/proto/Messages$RegistrationResponse$Builder;");
				global::Com.Urbanairship.Push.Proto.Messages.RegistrationResponse.Builder __ret = Java.Lang.Object.GetObject<global::Com.Urbanairship.Push.Proto.Messages.RegistrationResponse.Builder> (JNIEnv.CallStaticObjectMethod  (class_ref, id_newBuilder_Lcom_urbanairship_push_proto_Messages_RegistrationResponse_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
				return __ret;
			}

			static IntPtr id_newBuilderForType;
			[Register ("newBuilderForType", "()Lcom/urbanairship/push/proto/Messages$RegistrationResponse$Builder;", "")]
			public global::Com.Urbanairship.Push.Proto.Messages.RegistrationResponse.Builder NewBuilderForType ()
			{
				if (id_newBuilderForType == IntPtr.Zero)
					id_newBuilderForType = JNIEnv.GetMethodID (class_ref, "newBuilderForType", "()Lcom/urbanairship/push/proto/Messages$RegistrationResponse$Builder;");
				return Java.Lang.Object.GetObject<global::Com.Urbanairship.Push.Proto.Messages.RegistrationResponse.Builder> (JNIEnv.CallObjectMethod  (Handle, id_newBuilderForType), JniHandleOwnership.TransferLocalRef);
			}

			static IntPtr id_parseDelimitedFrom_Ljava_io_InputStream_;
			[Register ("parseDelimitedFrom", "(Ljava/io/InputStream;)Lcom/urbanairship/push/proto/Messages$RegistrationResponse;", "")]
			public static global::Com.Urbanairship.Push.Proto.Messages.RegistrationResponse ParseDelimitedFrom (global::System.IO.Stream p0)
			{
				if (id_parseDelimitedFrom_Ljava_io_InputStream_ == IntPtr.Zero)
					id_parseDelimitedFrom_Ljava_io_InputStream_ = JNIEnv.GetStaticMethodID (class_ref, "parseDelimitedFrom", "(Ljava/io/InputStream;)Lcom/urbanairship/push/proto/Messages$RegistrationResponse;");
				IntPtr native_p0 = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (p0);
				global::Com.Urbanairship.Push.Proto.Messages.RegistrationResponse __ret = Java.Lang.Object.GetObject<global::Com.Urbanairship.Push.Proto.Messages.RegistrationResponse> (JNIEnv.CallStaticObjectMethod  (class_ref, id_parseDelimitedFrom_Ljava_io_InputStream_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
				JNIEnv.DeleteLocalRef (native_p0);
				return __ret;
			}

			static IntPtr id_parseDelimitedFrom_Ljava_io_InputStream_Lcom_google_protobuf_ExtensionRegistryLite_;
			[Register ("parseDelimitedFrom", "(Ljava/io/InputStream;Lcom/google/protobuf/ExtensionRegistryLite;)Lcom/urbanairship/push/proto/Messages$RegistrationResponse;", "")]
			public static global::Com.Urbanairship.Push.Proto.Messages.RegistrationResponse ParseDelimitedFrom (global::System.IO.Stream p0, global::Com.Google.Protobuf.ExtensionRegistryLite p1)
			{
				if (id_parseDelimitedFrom_Ljava_io_InputStream_Lcom_google_protobuf_ExtensionRegistryLite_ == IntPtr.Zero)
					id_parseDelimitedFrom_Ljava_io_InputStream_Lcom_google_protobuf_ExtensionRegistryLite_ = JNIEnv.GetStaticMethodID (class_ref, "parseDelimitedFrom", "(Ljava/io/InputStream;Lcom/google/protobuf/ExtensionRegistryLite;)Lcom/urbanairship/push/proto/Messages$RegistrationResponse;");
				IntPtr native_p0 = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (p0);
				global::Com.Urbanairship.Push.Proto.Messages.RegistrationResponse __ret = Java.Lang.Object.GetObject<global::Com.Urbanairship.Push.Proto.Messages.RegistrationResponse> (JNIEnv.CallStaticObjectMethod  (class_ref, id_parseDelimitedFrom_Ljava_io_InputStream_Lcom_google_protobuf_ExtensionRegistryLite_, new JValue (native_p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
				JNIEnv.DeleteLocalRef (native_p0);
				return __ret;
			}

			static IntPtr id_parseFrom_arrayB;
			[Register ("parseFrom", "([B)Lcom/urbanairship/push/proto/Messages$RegistrationResponse;", "")]
			public static global::Com.Urbanairship.Push.Proto.Messages.RegistrationResponse ParseFrom (byte[] p0)
			{
				if (id_parseFrom_arrayB == IntPtr.Zero)
					id_parseFrom_arrayB = JNIEnv.GetStaticMethodID (class_ref, "parseFrom", "([B)Lcom/urbanairship/push/proto/Messages$RegistrationResponse;");
				IntPtr native_p0 = JNIEnv.NewArray (p0);
				global::Com.Urbanairship.Push.Proto.Messages.RegistrationResponse __ret = Java.Lang.Object.GetObject<global::Com.Urbanairship.Push.Proto.Messages.RegistrationResponse> (JNIEnv.CallStaticObjectMethod  (class_ref, id_parseFrom_arrayB, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				return __ret;
			}

			static IntPtr id_parseFrom_arrayBLcom_google_protobuf_ExtensionRegistryLite_;
			[Register ("parseFrom", "([BLcom/google/protobuf/ExtensionRegistryLite;)Lcom/urbanairship/push/proto/Messages$RegistrationResponse;", "")]
			public static global::Com.Urbanairship.Push.Proto.Messages.RegistrationResponse ParseFrom (byte[] p0, global::Com.Google.Protobuf.ExtensionRegistryLite p1)
			{
				if (id_parseFrom_arrayBLcom_google_protobuf_ExtensionRegistryLite_ == IntPtr.Zero)
					id_parseFrom_arrayBLcom_google_protobuf_ExtensionRegistryLite_ = JNIEnv.GetStaticMethodID (class_ref, "parseFrom", "([BLcom/google/protobuf/ExtensionRegistryLite;)Lcom/urbanairship/push/proto/Messages$RegistrationResponse;");
				IntPtr native_p0 = JNIEnv.NewArray (p0);
				global::Com.Urbanairship.Push.Proto.Messages.RegistrationResponse __ret = Java.Lang.Object.GetObject<global::Com.Urbanairship.Push.Proto.Messages.RegistrationResponse> (JNIEnv.CallStaticObjectMethod  (class_ref, id_parseFrom_arrayBLcom_google_protobuf_ExtensionRegistryLite_, new JValue (native_p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				return __ret;
			}

			static IntPtr id_parseFrom_Lcom_google_protobuf_ByteString_;
			[Register ("parseFrom", "(Lcom/google/protobuf/ByteString;)Lcom/urbanairship/push/proto/Messages$RegistrationResponse;", "")]
			public static global::Com.Urbanairship.Push.Proto.Messages.RegistrationResponse ParseFrom (global::Com.Google.Protobuf.ByteString p0)
			{
				if (id_parseFrom_Lcom_google_protobuf_ByteString_ == IntPtr.Zero)
					id_parseFrom_Lcom_google_protobuf_ByteString_ = JNIEnv.GetStaticMethodID (class_ref, "parseFrom", "(Lcom/google/protobuf/ByteString;)Lcom/urbanairship/push/proto/Messages$RegistrationResponse;");
				global::Com.Urbanairship.Push.Proto.Messages.RegistrationResponse __ret = Java.Lang.Object.GetObject<global::Com.Urbanairship.Push.Proto.Messages.RegistrationResponse> (JNIEnv.CallStaticObjectMethod  (class_ref, id_parseFrom_Lcom_google_protobuf_ByteString_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
				return __ret;
			}

			static IntPtr id_parseFrom_Lcom_google_protobuf_ByteString_Lcom_google_protobuf_ExtensionRegistryLite_;
			[Register ("parseFrom", "(Lcom/google/protobuf/ByteString;Lcom/google/protobuf/ExtensionRegistryLite;)Lcom/urbanairship/push/proto/Messages$RegistrationResponse;", "")]
			public static global::Com.Urbanairship.Push.Proto.Messages.RegistrationResponse ParseFrom (global::Com.Google.Protobuf.ByteString p0, global::Com.Google.Protobuf.ExtensionRegistryLite p1)
			{
				if (id_parseFrom_Lcom_google_protobuf_ByteString_Lcom_google_protobuf_ExtensionRegistryLite_ == IntPtr.Zero)
					id_parseFrom_Lcom_google_protobuf_ByteString_Lcom_google_protobuf_ExtensionRegistryLite_ = JNIEnv.GetStaticMethodID (class_ref, "parseFrom", "(Lcom/google/protobuf/ByteString;Lcom/google/protobuf/ExtensionRegistryLite;)Lcom/urbanairship/push/proto/Messages$RegistrationResponse;");
				global::Com.Urbanairship.Push.Proto.Messages.RegistrationResponse __ret = Java.Lang.Object.GetObject<global::Com.Urbanairship.Push.Proto.Messages.RegistrationResponse> (JNIEnv.CallStaticObjectMethod  (class_ref, id_parseFrom_Lcom_google_protobuf_ByteString_Lcom_google_protobuf_ExtensionRegistryLite_, new JValue (p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
				return __ret;
			}

			static IntPtr id_parseFrom_Lcom_google_protobuf_CodedInputStream_;
			[Register ("parseFrom", "(Lcom/google/protobuf/CodedInputStream;)Lcom/urbanairship/push/proto/Messages$RegistrationResponse;", "")]
			public static global::Com.Urbanairship.Push.Proto.Messages.RegistrationResponse ParseFrom (global::Com.Google.Protobuf.CodedInputStream p0)
			{
				if (id_parseFrom_Lcom_google_protobuf_CodedInputStream_ == IntPtr.Zero)
					id_parseFrom_Lcom_google_protobuf_CodedInputStream_ = JNIEnv.GetStaticMethodID (class_ref, "parseFrom", "(Lcom/google/protobuf/CodedInputStream;)Lcom/urbanairship/push/proto/Messages$RegistrationResponse;");
				global::Com.Urbanairship.Push.Proto.Messages.RegistrationResponse __ret = Java.Lang.Object.GetObject<global::Com.Urbanairship.Push.Proto.Messages.RegistrationResponse> (JNIEnv.CallStaticObjectMethod  (class_ref, id_parseFrom_Lcom_google_protobuf_CodedInputStream_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
				return __ret;
			}

			static IntPtr id_parseFrom_Lcom_google_protobuf_CodedInputStream_Lcom_google_protobuf_ExtensionRegistryLite_;
			[Register ("parseFrom", "(Lcom/google/protobuf/CodedInputStream;Lcom/google/protobuf/ExtensionRegistryLite;)Lcom/urbanairship/push/proto/Messages$RegistrationResponse;", "")]
			public static global::Com.Urbanairship.Push.Proto.Messages.RegistrationResponse ParseFrom (global::Com.Google.Protobuf.CodedInputStream p0, global::Com.Google.Protobuf.ExtensionRegistryLite p1)
			{
				if (id_parseFrom_Lcom_google_protobuf_CodedInputStream_Lcom_google_protobuf_ExtensionRegistryLite_ == IntPtr.Zero)
					id_parseFrom_Lcom_google_protobuf_CodedInputStream_Lcom_google_protobuf_ExtensionRegistryLite_ = JNIEnv.GetStaticMethodID (class_ref, "parseFrom", "(Lcom/google/protobuf/CodedInputStream;Lcom/google/protobuf/ExtensionRegistryLite;)Lcom/urbanairship/push/proto/Messages$RegistrationResponse;");
				global::Com.Urbanairship.Push.Proto.Messages.RegistrationResponse __ret = Java.Lang.Object.GetObject<global::Com.Urbanairship.Push.Proto.Messages.RegistrationResponse> (JNIEnv.CallStaticObjectMethod  (class_ref, id_parseFrom_Lcom_google_protobuf_CodedInputStream_Lcom_google_protobuf_ExtensionRegistryLite_, new JValue (p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
				return __ret;
			}

			static IntPtr id_parseFrom_Ljava_io_InputStream_;
			[Register ("parseFrom", "(Ljava/io/InputStream;)Lcom/urbanairship/push/proto/Messages$RegistrationResponse;", "")]
			public static global::Com.Urbanairship.Push.Proto.Messages.RegistrationResponse ParseFrom (global::System.IO.Stream p0)
			{
				if (id_parseFrom_Ljava_io_InputStream_ == IntPtr.Zero)
					id_parseFrom_Ljava_io_InputStream_ = JNIEnv.GetStaticMethodID (class_ref, "parseFrom", "(Ljava/io/InputStream;)Lcom/urbanairship/push/proto/Messages$RegistrationResponse;");
				IntPtr native_p0 = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (p0);
				global::Com.Urbanairship.Push.Proto.Messages.RegistrationResponse __ret = Java.Lang.Object.GetObject<global::Com.Urbanairship.Push.Proto.Messages.RegistrationResponse> (JNIEnv.CallStaticObjectMethod  (class_ref, id_parseFrom_Ljava_io_InputStream_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
				JNIEnv.DeleteLocalRef (native_p0);
				return __ret;
			}

			static IntPtr id_parseFrom_Ljava_io_InputStream_Lcom_google_protobuf_ExtensionRegistryLite_;
			[Register ("parseFrom", "(Ljava/io/InputStream;Lcom/google/protobuf/ExtensionRegistryLite;)Lcom/urbanairship/push/proto/Messages$RegistrationResponse;", "")]
			public static global::Com.Urbanairship.Push.Proto.Messages.RegistrationResponse ParseFrom (global::System.IO.Stream p0, global::Com.Google.Protobuf.ExtensionRegistryLite p1)
			{
				if (id_parseFrom_Ljava_io_InputStream_Lcom_google_protobuf_ExtensionRegistryLite_ == IntPtr.Zero)
					id_parseFrom_Ljava_io_InputStream_Lcom_google_protobuf_ExtensionRegistryLite_ = JNIEnv.GetStaticMethodID (class_ref, "parseFrom", "(Ljava/io/InputStream;Lcom/google/protobuf/ExtensionRegistryLite;)Lcom/urbanairship/push/proto/Messages$RegistrationResponse;");
				IntPtr native_p0 = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (p0);
				global::Com.Urbanairship.Push.Proto.Messages.RegistrationResponse __ret = Java.Lang.Object.GetObject<global::Com.Urbanairship.Push.Proto.Messages.RegistrationResponse> (JNIEnv.CallStaticObjectMethod  (class_ref, id_parseFrom_Ljava_io_InputStream_Lcom_google_protobuf_ExtensionRegistryLite_, new JValue (native_p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
				JNIEnv.DeleteLocalRef (native_p0);
				return __ret;
			}

			static IntPtr id_toBuilder;
			[Register ("toBuilder", "()Lcom/urbanairship/push/proto/Messages$RegistrationResponse$Builder;", "")]
			public global::Com.Urbanairship.Push.Proto.Messages.RegistrationResponse.Builder ToBuilder ()
			{
				if (id_toBuilder == IntPtr.Zero)
					id_toBuilder = JNIEnv.GetMethodID (class_ref, "toBuilder", "()Lcom/urbanairship/push/proto/Messages$RegistrationResponse$Builder;");
				return Java.Lang.Object.GetObject<global::Com.Urbanairship.Push.Proto.Messages.RegistrationResponse.Builder> (JNIEnv.CallObjectMethod  (Handle, id_toBuilder), JniHandleOwnership.TransferLocalRef);
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

		[global::Android.Runtime.Register ("com/urbanairship/push/proto/Messages$Relier", DoNotGenerateAcw=true)]
		public sealed partial class Relier : global::Com.Google.Protobuf.GeneratedMessageLite {


			[Register ("APP_KEY_FIELD_NUMBER")]
			public const int AppKeyFieldNumber = (int) 2;

			[Register ("PACKAGE_FIELD_NUMBER")]
			public const int PackageFieldNumber = (int) 1;
			[global::Android.Runtime.Register ("com/urbanairship/push/proto/Messages$Relier$Builder", DoNotGenerateAcw=true)]
			public new sealed partial class Builder : global::Com.Google.Protobuf.GeneratedMessageLite.Builder {

				internal static IntPtr java_class_handle;
				internal static IntPtr class_ref {
					get {
						return JNIEnv.FindClass ("com/urbanairship/push/proto/Messages$Relier$Builder", ref java_class_handle);
					}
				}

				protected override IntPtr ThresholdClass {
					get { return class_ref; }
				}

				protected override global::System.Type ThresholdType {
					get { return typeof (Builder); }
				}

				internal Builder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

				static IntPtr id_getAppKey;
				public string AppKey {
					[Register ("getAppKey", "()Ljava/lang/String;", "GetGetAppKeyHandler")]
					get {
						if (id_getAppKey == IntPtr.Zero)
							id_getAppKey = JNIEnv.GetMethodID (class_ref, "getAppKey", "()Ljava/lang/String;");
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getAppKey), JniHandleOwnership.TransferLocalRef);
					}
				}

				static IntPtr id_getDefaultInstanceForType;
				public override global::Com.Urbanairship.Push.Proto.Messages.Relier DefaultInstanceForType {
					[Register ("getDefaultInstanceForType", "()Lcom/urbanairship/push/proto/Messages$Relier;", "GetGetDefaultInstanceForTypeHandler")]
					get {
						if (id_getDefaultInstanceForType == IntPtr.Zero)
							id_getDefaultInstanceForType = JNIEnv.GetMethodID (class_ref, "getDefaultInstanceForType", "()Lcom/urbanairship/push/proto/Messages$Relier;");
						return Java.Lang.Object.GetObject<global::Com.Urbanairship.Push.Proto.Messages.Relier> (JNIEnv.CallObjectMethod  (Handle, id_getDefaultInstanceForType), JniHandleOwnership.TransferLocalRef);
					}
				}

				static IntPtr id_hasAppKey;
				public bool HasAppKey {
					[Register ("hasAppKey", "()Z", "GetHasAppKeyHandler")]
					get {
						if (id_hasAppKey == IntPtr.Zero)
							id_hasAppKey = JNIEnv.GetMethodID (class_ref, "hasAppKey", "()Z");
						return JNIEnv.CallBooleanMethod  (Handle, id_hasAppKey);
					}
				}

				static IntPtr id_hasPackage;
				public bool HasPackage {
					[Register ("hasPackage", "()Z", "GetHasPackageHandler")]
					get {
						if (id_hasPackage == IntPtr.Zero)
							id_hasPackage = JNIEnv.GetMethodID (class_ref, "hasPackage", "()Z");
						return JNIEnv.CallBooleanMethod  (Handle, id_hasPackage);
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

				static IntPtr id_getPackage;
				public string Package {
					[Register ("getPackage", "()Ljava/lang/String;", "GetGetPackageHandler")]
					get {
						if (id_getPackage == IntPtr.Zero)
							id_getPackage = JNIEnv.GetMethodID (class_ref, "getPackage", "()Ljava/lang/String;");
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getPackage), JniHandleOwnership.TransferLocalRef);
					}
				}

				static IntPtr id_build;
				[Register ("build", "()Lcom/urbanairship/push/proto/Messages$Relier;", "")]
				public global::Com.Urbanairship.Push.Proto.Messages.Relier Build ()
				{
					if (id_build == IntPtr.Zero)
						id_build = JNIEnv.GetMethodID (class_ref, "build", "()Lcom/urbanairship/push/proto/Messages$Relier;");
					return Java.Lang.Object.GetObject<global::Com.Urbanairship.Push.Proto.Messages.Relier> (JNIEnv.CallObjectMethod  (Handle, id_build), JniHandleOwnership.TransferLocalRef);
				}

				static IntPtr id_buildPartial;
				[Register ("buildPartial", "()Lcom/urbanairship/push/proto/Messages$Relier;", "")]
				public global::Com.Urbanairship.Push.Proto.Messages.Relier BuildPartial ()
				{
					if (id_buildPartial == IntPtr.Zero)
						id_buildPartial = JNIEnv.GetMethodID (class_ref, "buildPartial", "()Lcom/urbanairship/push/proto/Messages$Relier;");
					return Java.Lang.Object.GetObject<global::Com.Urbanairship.Push.Proto.Messages.Relier> (JNIEnv.CallObjectMethod  (Handle, id_buildPartial), JniHandleOwnership.TransferLocalRef);
				}

				static IntPtr id_clear;
				[Register ("clear", "()Lcom/urbanairship/push/proto/Messages$Relier$Builder;", "")]
				public global::Com.Urbanairship.Push.Proto.Messages.Relier.Builder Clear ()
				{
					if (id_clear == IntPtr.Zero)
						id_clear = JNIEnv.GetMethodID (class_ref, "clear", "()Lcom/urbanairship/push/proto/Messages$Relier$Builder;");
					return Java.Lang.Object.GetObject<global::Com.Urbanairship.Push.Proto.Messages.Relier.Builder> (JNIEnv.CallObjectMethod  (Handle, id_clear), JniHandleOwnership.TransferLocalRef);
				}

				static IntPtr id_clearAppKey;
				[Register ("clearAppKey", "()Lcom/urbanairship/push/proto/Messages$Relier$Builder;", "")]
				public global::Com.Urbanairship.Push.Proto.Messages.Relier.Builder ClearAppKey ()
				{
					if (id_clearAppKey == IntPtr.Zero)
						id_clearAppKey = JNIEnv.GetMethodID (class_ref, "clearAppKey", "()Lcom/urbanairship/push/proto/Messages$Relier$Builder;");
					return Java.Lang.Object.GetObject<global::Com.Urbanairship.Push.Proto.Messages.Relier.Builder> (JNIEnv.CallObjectMethod  (Handle, id_clearAppKey), JniHandleOwnership.TransferLocalRef);
				}

				static IntPtr id_clearPackage;
				[Register ("clearPackage", "()Lcom/urbanairship/push/proto/Messages$Relier$Builder;", "")]
				public global::Com.Urbanairship.Push.Proto.Messages.Relier.Builder ClearPackage ()
				{
					if (id_clearPackage == IntPtr.Zero)
						id_clearPackage = JNIEnv.GetMethodID (class_ref, "clearPackage", "()Lcom/urbanairship/push/proto/Messages$Relier$Builder;");
					return Java.Lang.Object.GetObject<global::Com.Urbanairship.Push.Proto.Messages.Relier.Builder> (JNIEnv.CallObjectMethod  (Handle, id_clearPackage), JniHandleOwnership.TransferLocalRef);
				}

				static IntPtr id_internalGetResult;
				[Register ("internalGetResult", "()Lcom/urbanairship/push/proto/Messages$Relier;", "")]
				protected override global::Com.Urbanairship.Push.Proto.Messages.Relier InternalGetResult ()
				{
					if (id_internalGetResult == IntPtr.Zero)
						id_internalGetResult = JNIEnv.GetMethodID (class_ref, "internalGetResult", "()Lcom/urbanairship/push/proto/Messages$Relier;");
					return Java.Lang.Object.GetObject<global::Com.Urbanairship.Push.Proto.Messages.Relier> (JNIEnv.CallObjectMethod  (Handle, id_internalGetResult), JniHandleOwnership.TransferLocalRef);
				}

				static IntPtr id_mergeFrom_Lcom_google_protobuf_CodedInputStream_Lcom_google_protobuf_ExtensionRegistryLite_;
				[Register ("mergeFrom", "(Lcom/google/protobuf/CodedInputStream;Lcom/google/protobuf/ExtensionRegistryLite;)Lcom/urbanairship/push/proto/Messages$Relier$Builder;", "")]
				public override global::Com.Urbanairship.Push.Proto.Messages.Relier.Builder MergeFrom (global::Com.Google.Protobuf.CodedInputStream p0, global::Com.Google.Protobuf.ExtensionRegistryLite p1)
				{
					if (id_mergeFrom_Lcom_google_protobuf_CodedInputStream_Lcom_google_protobuf_ExtensionRegistryLite_ == IntPtr.Zero)
						id_mergeFrom_Lcom_google_protobuf_CodedInputStream_Lcom_google_protobuf_ExtensionRegistryLite_ = JNIEnv.GetMethodID (class_ref, "mergeFrom", "(Lcom/google/protobuf/CodedInputStream;Lcom/google/protobuf/ExtensionRegistryLite;)Lcom/urbanairship/push/proto/Messages$Relier$Builder;");
					global::Com.Urbanairship.Push.Proto.Messages.Relier.Builder __ret = Java.Lang.Object.GetObject<global::Com.Urbanairship.Push.Proto.Messages.Relier.Builder> (JNIEnv.CallObjectMethod  (Handle, id_mergeFrom_Lcom_google_protobuf_CodedInputStream_Lcom_google_protobuf_ExtensionRegistryLite_, new JValue (p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
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

				static IntPtr id_mergeFrom_Lcom_urbanairship_push_proto_Messages_Relier_;
				[Register ("mergeFrom", "(Lcom/urbanairship/push/proto/Messages$Relier;)Lcom/urbanairship/push/proto/Messages$Relier$Builder;", "")]
				public global::Com.Urbanairship.Push.Proto.Messages.Relier.Builder MergeFrom (global::Com.Urbanairship.Push.Proto.Messages.Relier p0)
				{
					if (id_mergeFrom_Lcom_urbanairship_push_proto_Messages_Relier_ == IntPtr.Zero)
						id_mergeFrom_Lcom_urbanairship_push_proto_Messages_Relier_ = JNIEnv.GetMethodID (class_ref, "mergeFrom", "(Lcom/urbanairship/push/proto/Messages$Relier;)Lcom/urbanairship/push/proto/Messages$Relier$Builder;");
					global::Com.Urbanairship.Push.Proto.Messages.Relier.Builder __ret = Java.Lang.Object.GetObject<global::Com.Urbanairship.Push.Proto.Messages.Relier.Builder> (JNIEnv.CallObjectMethod  (Handle, id_mergeFrom_Lcom_urbanairship_push_proto_Messages_Relier_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
					return __ret;
				}

				static IntPtr id_setAppKey_Ljava_lang_String_;
				[Register ("setAppKey", "(Ljava/lang/String;)Lcom/urbanairship/push/proto/Messages$Relier$Builder;", "")]
				public global::Com.Urbanairship.Push.Proto.Messages.Relier.Builder SetAppKey (string p0)
				{
					if (id_setAppKey_Ljava_lang_String_ == IntPtr.Zero)
						id_setAppKey_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setAppKey", "(Ljava/lang/String;)Lcom/urbanairship/push/proto/Messages$Relier$Builder;");
					IntPtr native_p0 = JNIEnv.NewString (p0);
					global::Com.Urbanairship.Push.Proto.Messages.Relier.Builder __ret = Java.Lang.Object.GetObject<global::Com.Urbanairship.Push.Proto.Messages.Relier.Builder> (JNIEnv.CallObjectMethod  (Handle, id_setAppKey_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
					JNIEnv.DeleteLocalRef (native_p0);
					return __ret;
				}

				static IntPtr id_setPackage_Ljava_lang_String_;
				[Register ("setPackage", "(Ljava/lang/String;)Lcom/urbanairship/push/proto/Messages$Relier$Builder;", "")]
				public global::Com.Urbanairship.Push.Proto.Messages.Relier.Builder SetPackage (string p0)
				{
					if (id_setPackage_Ljava_lang_String_ == IntPtr.Zero)
						id_setPackage_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setPackage", "(Ljava/lang/String;)Lcom/urbanairship/push/proto/Messages$Relier$Builder;");
					IntPtr native_p0 = JNIEnv.NewString (p0);
					global::Com.Urbanairship.Push.Proto.Messages.Relier.Builder __ret = Java.Lang.Object.GetObject<global::Com.Urbanairship.Push.Proto.Messages.Relier.Builder> (JNIEnv.CallObjectMethod  (Handle, id_setPackage_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
					JNIEnv.DeleteLocalRef (native_p0);
					return __ret;
				}

			}

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/urbanairship/push/proto/Messages$Relier", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Relier); }
			}

			internal Relier (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_getAppKey;
			public string AppKey {
				[Register ("getAppKey", "()Ljava/lang/String;", "GetGetAppKeyHandler")]
				get {
					if (id_getAppKey == IntPtr.Zero)
						id_getAppKey = JNIEnv.GetMethodID (class_ref, "getAppKey", "()Ljava/lang/String;");
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getAppKey), JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr id_getDefaultInstance;
			public static global::Com.Urbanairship.Push.Proto.Messages.Relier DefaultInstance {
				[Register ("getDefaultInstance", "()Lcom/urbanairship/push/proto/Messages$Relier;", "GetGetDefaultInstanceHandler")]
				get {
					if (id_getDefaultInstance == IntPtr.Zero)
						id_getDefaultInstance = JNIEnv.GetStaticMethodID (class_ref, "getDefaultInstance", "()Lcom/urbanairship/push/proto/Messages$Relier;");
					return Java.Lang.Object.GetObject<global::Com.Urbanairship.Push.Proto.Messages.Relier> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getDefaultInstance), JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr id_getDefaultInstanceForType;
			public override global::Com.Urbanairship.Push.Proto.Messages.Relier DefaultInstanceForType {
				[Register ("getDefaultInstanceForType", "()Lcom/urbanairship/push/proto/Messages$Relier;", "GetGetDefaultInstanceForTypeHandler")]
				get {
					if (id_getDefaultInstanceForType == IntPtr.Zero)
						id_getDefaultInstanceForType = JNIEnv.GetMethodID (class_ref, "getDefaultInstanceForType", "()Lcom/urbanairship/push/proto/Messages$Relier;");
					return Java.Lang.Object.GetObject<global::Com.Urbanairship.Push.Proto.Messages.Relier> (JNIEnv.CallObjectMethod  (Handle, id_getDefaultInstanceForType), JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr id_hasAppKey;
			public bool HasAppKey {
				[Register ("hasAppKey", "()Z", "GetHasAppKeyHandler")]
				get {
					if (id_hasAppKey == IntPtr.Zero)
						id_hasAppKey = JNIEnv.GetMethodID (class_ref, "hasAppKey", "()Z");
					return JNIEnv.CallBooleanMethod  (Handle, id_hasAppKey);
				}
			}

			static IntPtr id_hasPackage;
			public bool HasPackage {
				[Register ("hasPackage", "()Z", "GetHasPackageHandler")]
				get {
					if (id_hasPackage == IntPtr.Zero)
						id_hasPackage = JNIEnv.GetMethodID (class_ref, "hasPackage", "()Z");
					return JNIEnv.CallBooleanMethod  (Handle, id_hasPackage);
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

			static IntPtr id_getPackage;
			public string Package {
				[Register ("getPackage", "()Ljava/lang/String;", "GetGetPackageHandler")]
				get {
					if (id_getPackage == IntPtr.Zero)
						id_getPackage = JNIEnv.GetMethodID (class_ref, "getPackage", "()Ljava/lang/String;");
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getPackage), JniHandleOwnership.TransferLocalRef);
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
			[Register ("newBuilder", "()Lcom/urbanairship/push/proto/Messages$Relier$Builder;", "")]
			public static global::Com.Urbanairship.Push.Proto.Messages.Relier.Builder NewBuilder ()
			{
				if (id_newBuilder == IntPtr.Zero)
					id_newBuilder = JNIEnv.GetStaticMethodID (class_ref, "newBuilder", "()Lcom/urbanairship/push/proto/Messages$Relier$Builder;");
				return Java.Lang.Object.GetObject<global::Com.Urbanairship.Push.Proto.Messages.Relier.Builder> (JNIEnv.CallStaticObjectMethod  (class_ref, id_newBuilder), JniHandleOwnership.TransferLocalRef);
			}

			static IntPtr id_newBuilder_Lcom_urbanairship_push_proto_Messages_Relier_;
			[Register ("newBuilder", "(Lcom/urbanairship/push/proto/Messages$Relier;)Lcom/urbanairship/push/proto/Messages$Relier$Builder;", "")]
			public static global::Com.Urbanairship.Push.Proto.Messages.Relier.Builder NewBuilder (global::Com.Urbanairship.Push.Proto.Messages.Relier p0)
			{
				if (id_newBuilder_Lcom_urbanairship_push_proto_Messages_Relier_ == IntPtr.Zero)
					id_newBuilder_Lcom_urbanairship_push_proto_Messages_Relier_ = JNIEnv.GetStaticMethodID (class_ref, "newBuilder", "(Lcom/urbanairship/push/proto/Messages$Relier;)Lcom/urbanairship/push/proto/Messages$Relier$Builder;");
				global::Com.Urbanairship.Push.Proto.Messages.Relier.Builder __ret = Java.Lang.Object.GetObject<global::Com.Urbanairship.Push.Proto.Messages.Relier.Builder> (JNIEnv.CallStaticObjectMethod  (class_ref, id_newBuilder_Lcom_urbanairship_push_proto_Messages_Relier_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
				return __ret;
			}

			static IntPtr id_newBuilderForType;
			[Register ("newBuilderForType", "()Lcom/urbanairship/push/proto/Messages$Relier$Builder;", "")]
			public global::Com.Urbanairship.Push.Proto.Messages.Relier.Builder NewBuilderForType ()
			{
				if (id_newBuilderForType == IntPtr.Zero)
					id_newBuilderForType = JNIEnv.GetMethodID (class_ref, "newBuilderForType", "()Lcom/urbanairship/push/proto/Messages$Relier$Builder;");
				return Java.Lang.Object.GetObject<global::Com.Urbanairship.Push.Proto.Messages.Relier.Builder> (JNIEnv.CallObjectMethod  (Handle, id_newBuilderForType), JniHandleOwnership.TransferLocalRef);
			}

			static IntPtr id_parseDelimitedFrom_Ljava_io_InputStream_;
			[Register ("parseDelimitedFrom", "(Ljava/io/InputStream;)Lcom/urbanairship/push/proto/Messages$Relier;", "")]
			public static global::Com.Urbanairship.Push.Proto.Messages.Relier ParseDelimitedFrom (global::System.IO.Stream p0)
			{
				if (id_parseDelimitedFrom_Ljava_io_InputStream_ == IntPtr.Zero)
					id_parseDelimitedFrom_Ljava_io_InputStream_ = JNIEnv.GetStaticMethodID (class_ref, "parseDelimitedFrom", "(Ljava/io/InputStream;)Lcom/urbanairship/push/proto/Messages$Relier;");
				IntPtr native_p0 = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (p0);
				global::Com.Urbanairship.Push.Proto.Messages.Relier __ret = Java.Lang.Object.GetObject<global::Com.Urbanairship.Push.Proto.Messages.Relier> (JNIEnv.CallStaticObjectMethod  (class_ref, id_parseDelimitedFrom_Ljava_io_InputStream_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
				JNIEnv.DeleteLocalRef (native_p0);
				return __ret;
			}

			static IntPtr id_parseDelimitedFrom_Ljava_io_InputStream_Lcom_google_protobuf_ExtensionRegistryLite_;
			[Register ("parseDelimitedFrom", "(Ljava/io/InputStream;Lcom/google/protobuf/ExtensionRegistryLite;)Lcom/urbanairship/push/proto/Messages$Relier;", "")]
			public static global::Com.Urbanairship.Push.Proto.Messages.Relier ParseDelimitedFrom (global::System.IO.Stream p0, global::Com.Google.Protobuf.ExtensionRegistryLite p1)
			{
				if (id_parseDelimitedFrom_Ljava_io_InputStream_Lcom_google_protobuf_ExtensionRegistryLite_ == IntPtr.Zero)
					id_parseDelimitedFrom_Ljava_io_InputStream_Lcom_google_protobuf_ExtensionRegistryLite_ = JNIEnv.GetStaticMethodID (class_ref, "parseDelimitedFrom", "(Ljava/io/InputStream;Lcom/google/protobuf/ExtensionRegistryLite;)Lcom/urbanairship/push/proto/Messages$Relier;");
				IntPtr native_p0 = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (p0);
				global::Com.Urbanairship.Push.Proto.Messages.Relier __ret = Java.Lang.Object.GetObject<global::Com.Urbanairship.Push.Proto.Messages.Relier> (JNIEnv.CallStaticObjectMethod  (class_ref, id_parseDelimitedFrom_Ljava_io_InputStream_Lcom_google_protobuf_ExtensionRegistryLite_, new JValue (native_p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
				JNIEnv.DeleteLocalRef (native_p0);
				return __ret;
			}

			static IntPtr id_parseFrom_arrayB;
			[Register ("parseFrom", "([B)Lcom/urbanairship/push/proto/Messages$Relier;", "")]
			public static global::Com.Urbanairship.Push.Proto.Messages.Relier ParseFrom (byte[] p0)
			{
				if (id_parseFrom_arrayB == IntPtr.Zero)
					id_parseFrom_arrayB = JNIEnv.GetStaticMethodID (class_ref, "parseFrom", "([B)Lcom/urbanairship/push/proto/Messages$Relier;");
				IntPtr native_p0 = JNIEnv.NewArray (p0);
				global::Com.Urbanairship.Push.Proto.Messages.Relier __ret = Java.Lang.Object.GetObject<global::Com.Urbanairship.Push.Proto.Messages.Relier> (JNIEnv.CallStaticObjectMethod  (class_ref, id_parseFrom_arrayB, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				return __ret;
			}

			static IntPtr id_parseFrom_arrayBLcom_google_protobuf_ExtensionRegistryLite_;
			[Register ("parseFrom", "([BLcom/google/protobuf/ExtensionRegistryLite;)Lcom/urbanairship/push/proto/Messages$Relier;", "")]
			public static global::Com.Urbanairship.Push.Proto.Messages.Relier ParseFrom (byte[] p0, global::Com.Google.Protobuf.ExtensionRegistryLite p1)
			{
				if (id_parseFrom_arrayBLcom_google_protobuf_ExtensionRegistryLite_ == IntPtr.Zero)
					id_parseFrom_arrayBLcom_google_protobuf_ExtensionRegistryLite_ = JNIEnv.GetStaticMethodID (class_ref, "parseFrom", "([BLcom/google/protobuf/ExtensionRegistryLite;)Lcom/urbanairship/push/proto/Messages$Relier;");
				IntPtr native_p0 = JNIEnv.NewArray (p0);
				global::Com.Urbanairship.Push.Proto.Messages.Relier __ret = Java.Lang.Object.GetObject<global::Com.Urbanairship.Push.Proto.Messages.Relier> (JNIEnv.CallStaticObjectMethod  (class_ref, id_parseFrom_arrayBLcom_google_protobuf_ExtensionRegistryLite_, new JValue (native_p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				return __ret;
			}

			static IntPtr id_parseFrom_Lcom_google_protobuf_ByteString_;
			[Register ("parseFrom", "(Lcom/google/protobuf/ByteString;)Lcom/urbanairship/push/proto/Messages$Relier;", "")]
			public static global::Com.Urbanairship.Push.Proto.Messages.Relier ParseFrom (global::Com.Google.Protobuf.ByteString p0)
			{
				if (id_parseFrom_Lcom_google_protobuf_ByteString_ == IntPtr.Zero)
					id_parseFrom_Lcom_google_protobuf_ByteString_ = JNIEnv.GetStaticMethodID (class_ref, "parseFrom", "(Lcom/google/protobuf/ByteString;)Lcom/urbanairship/push/proto/Messages$Relier;");
				global::Com.Urbanairship.Push.Proto.Messages.Relier __ret = Java.Lang.Object.GetObject<global::Com.Urbanairship.Push.Proto.Messages.Relier> (JNIEnv.CallStaticObjectMethod  (class_ref, id_parseFrom_Lcom_google_protobuf_ByteString_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
				return __ret;
			}

			static IntPtr id_parseFrom_Lcom_google_protobuf_ByteString_Lcom_google_protobuf_ExtensionRegistryLite_;
			[Register ("parseFrom", "(Lcom/google/protobuf/ByteString;Lcom/google/protobuf/ExtensionRegistryLite;)Lcom/urbanairship/push/proto/Messages$Relier;", "")]
			public static global::Com.Urbanairship.Push.Proto.Messages.Relier ParseFrom (global::Com.Google.Protobuf.ByteString p0, global::Com.Google.Protobuf.ExtensionRegistryLite p1)
			{
				if (id_parseFrom_Lcom_google_protobuf_ByteString_Lcom_google_protobuf_ExtensionRegistryLite_ == IntPtr.Zero)
					id_parseFrom_Lcom_google_protobuf_ByteString_Lcom_google_protobuf_ExtensionRegistryLite_ = JNIEnv.GetStaticMethodID (class_ref, "parseFrom", "(Lcom/google/protobuf/ByteString;Lcom/google/protobuf/ExtensionRegistryLite;)Lcom/urbanairship/push/proto/Messages$Relier;");
				global::Com.Urbanairship.Push.Proto.Messages.Relier __ret = Java.Lang.Object.GetObject<global::Com.Urbanairship.Push.Proto.Messages.Relier> (JNIEnv.CallStaticObjectMethod  (class_ref, id_parseFrom_Lcom_google_protobuf_ByteString_Lcom_google_protobuf_ExtensionRegistryLite_, new JValue (p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
				return __ret;
			}

			static IntPtr id_parseFrom_Lcom_google_protobuf_CodedInputStream_;
			[Register ("parseFrom", "(Lcom/google/protobuf/CodedInputStream;)Lcom/urbanairship/push/proto/Messages$Relier;", "")]
			public static global::Com.Urbanairship.Push.Proto.Messages.Relier ParseFrom (global::Com.Google.Protobuf.CodedInputStream p0)
			{
				if (id_parseFrom_Lcom_google_protobuf_CodedInputStream_ == IntPtr.Zero)
					id_parseFrom_Lcom_google_protobuf_CodedInputStream_ = JNIEnv.GetStaticMethodID (class_ref, "parseFrom", "(Lcom/google/protobuf/CodedInputStream;)Lcom/urbanairship/push/proto/Messages$Relier;");
				global::Com.Urbanairship.Push.Proto.Messages.Relier __ret = Java.Lang.Object.GetObject<global::Com.Urbanairship.Push.Proto.Messages.Relier> (JNIEnv.CallStaticObjectMethod  (class_ref, id_parseFrom_Lcom_google_protobuf_CodedInputStream_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
				return __ret;
			}

			static IntPtr id_parseFrom_Lcom_google_protobuf_CodedInputStream_Lcom_google_protobuf_ExtensionRegistryLite_;
			[Register ("parseFrom", "(Lcom/google/protobuf/CodedInputStream;Lcom/google/protobuf/ExtensionRegistryLite;)Lcom/urbanairship/push/proto/Messages$Relier;", "")]
			public static global::Com.Urbanairship.Push.Proto.Messages.Relier ParseFrom (global::Com.Google.Protobuf.CodedInputStream p0, global::Com.Google.Protobuf.ExtensionRegistryLite p1)
			{
				if (id_parseFrom_Lcom_google_protobuf_CodedInputStream_Lcom_google_protobuf_ExtensionRegistryLite_ == IntPtr.Zero)
					id_parseFrom_Lcom_google_protobuf_CodedInputStream_Lcom_google_protobuf_ExtensionRegistryLite_ = JNIEnv.GetStaticMethodID (class_ref, "parseFrom", "(Lcom/google/protobuf/CodedInputStream;Lcom/google/protobuf/ExtensionRegistryLite;)Lcom/urbanairship/push/proto/Messages$Relier;");
				global::Com.Urbanairship.Push.Proto.Messages.Relier __ret = Java.Lang.Object.GetObject<global::Com.Urbanairship.Push.Proto.Messages.Relier> (JNIEnv.CallStaticObjectMethod  (class_ref, id_parseFrom_Lcom_google_protobuf_CodedInputStream_Lcom_google_protobuf_ExtensionRegistryLite_, new JValue (p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
				return __ret;
			}

			static IntPtr id_parseFrom_Ljava_io_InputStream_;
			[Register ("parseFrom", "(Ljava/io/InputStream;)Lcom/urbanairship/push/proto/Messages$Relier;", "")]
			public static global::Com.Urbanairship.Push.Proto.Messages.Relier ParseFrom (global::System.IO.Stream p0)
			{
				if (id_parseFrom_Ljava_io_InputStream_ == IntPtr.Zero)
					id_parseFrom_Ljava_io_InputStream_ = JNIEnv.GetStaticMethodID (class_ref, "parseFrom", "(Ljava/io/InputStream;)Lcom/urbanairship/push/proto/Messages$Relier;");
				IntPtr native_p0 = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (p0);
				global::Com.Urbanairship.Push.Proto.Messages.Relier __ret = Java.Lang.Object.GetObject<global::Com.Urbanairship.Push.Proto.Messages.Relier> (JNIEnv.CallStaticObjectMethod  (class_ref, id_parseFrom_Ljava_io_InputStream_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
				JNIEnv.DeleteLocalRef (native_p0);
				return __ret;
			}

			static IntPtr id_parseFrom_Ljava_io_InputStream_Lcom_google_protobuf_ExtensionRegistryLite_;
			[Register ("parseFrom", "(Ljava/io/InputStream;Lcom/google/protobuf/ExtensionRegistryLite;)Lcom/urbanairship/push/proto/Messages$Relier;", "")]
			public static global::Com.Urbanairship.Push.Proto.Messages.Relier ParseFrom (global::System.IO.Stream p0, global::Com.Google.Protobuf.ExtensionRegistryLite p1)
			{
				if (id_parseFrom_Ljava_io_InputStream_Lcom_google_protobuf_ExtensionRegistryLite_ == IntPtr.Zero)
					id_parseFrom_Ljava_io_InputStream_Lcom_google_protobuf_ExtensionRegistryLite_ = JNIEnv.GetStaticMethodID (class_ref, "parseFrom", "(Ljava/io/InputStream;Lcom/google/protobuf/ExtensionRegistryLite;)Lcom/urbanairship/push/proto/Messages$Relier;");
				IntPtr native_p0 = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (p0);
				global::Com.Urbanairship.Push.Proto.Messages.Relier __ret = Java.Lang.Object.GetObject<global::Com.Urbanairship.Push.Proto.Messages.Relier> (JNIEnv.CallStaticObjectMethod  (class_ref, id_parseFrom_Ljava_io_InputStream_Lcom_google_protobuf_ExtensionRegistryLite_, new JValue (native_p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
				JNIEnv.DeleteLocalRef (native_p0);
				return __ret;
			}

			static IntPtr id_toBuilder;
			[Register ("toBuilder", "()Lcom/urbanairship/push/proto/Messages$Relier$Builder;", "")]
			public global::Com.Urbanairship.Push.Proto.Messages.Relier.Builder ToBuilder ()
			{
				if (id_toBuilder == IntPtr.Zero)
					id_toBuilder = JNIEnv.GetMethodID (class_ref, "toBuilder", "()Lcom/urbanairship/push/proto/Messages$Relier$Builder;");
				return Java.Lang.Object.GetObject<global::Com.Urbanairship.Push.Proto.Messages.Relier.Builder> (JNIEnv.CallObjectMethod  (Handle, id_toBuilder), JniHandleOwnership.TransferLocalRef);
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

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/urbanairship/push/proto/Messages", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Messages); }
		}

		internal Messages (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

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
