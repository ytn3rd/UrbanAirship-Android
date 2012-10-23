using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Protobuf {

	[global::Android.Runtime.Register ("com/google/protobuf/ExtensionRegistryLite", DoNotGenerateAcw=true)]
	public partial class ExtensionRegistryLite : global::Java.Lang.Object {

		[global::Android.Runtime.Register ("com/google/protobuf/ExtensionRegistryLite$ObjectIntPair", DoNotGenerateAcw=true)]
		public sealed partial class ObjectIntPair : global::Java.Lang.Object {

			internal ObjectIntPair (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/protobuf/ExtensionRegistryLite", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ExtensionRegistryLite); }
		}

		protected ExtensionRegistryLite (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_getEmptyRegistry;
		public static global::Com.Google.Protobuf.ExtensionRegistryLite EmptyRegistry {
			[Register ("getEmptyRegistry", "()Lcom/google/protobuf/ExtensionRegistryLite;", "GetGetEmptyRegistryHandler")]
			get {
				if (id_getEmptyRegistry == IntPtr.Zero)
					id_getEmptyRegistry = JNIEnv.GetStaticMethodID (class_ref, "getEmptyRegistry", "()Lcom/google/protobuf/ExtensionRegistryLite;");
				return Java.Lang.Object.GetObject<global::Com.Google.Protobuf.ExtensionRegistryLite> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getEmptyRegistry), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getUnmodifiable;
#pragma warning disable 0169
		static Delegate GetGetUnmodifiableHandler ()
		{
			if (cb_getUnmodifiable == null)
				cb_getUnmodifiable = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetUnmodifiable);
			return cb_getUnmodifiable;
		}

		static IntPtr n_GetUnmodifiable (IntPtr jnienv, IntPtr native__this)
		{
			ExtensionRegistryLite __this = Java.Lang.Object.GetObject<ExtensionRegistryLite> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Unmodifiable);
		}
#pragma warning restore 0169

		static IntPtr id_getUnmodifiable;
		public virtual global::Com.Google.Protobuf.ExtensionRegistryLite Unmodifiable {
			[Register ("getUnmodifiable", "()Lcom/google/protobuf/ExtensionRegistryLite;", "GetGetUnmodifiableHandler")]
			get {
				if (id_getUnmodifiable == IntPtr.Zero)
					id_getUnmodifiable = JNIEnv.GetMethodID (class_ref, "getUnmodifiable", "()Lcom/google/protobuf/ExtensionRegistryLite;");

				if (GetType () == ThresholdType)
					return Java.Lang.Object.GetObject<global::Com.Google.Protobuf.ExtensionRegistryLite> (JNIEnv.CallObjectMethod  (Handle, id_getUnmodifiable), JniHandleOwnership.TransferLocalRef);
				else
					return Java.Lang.Object.GetObject<global::Com.Google.Protobuf.ExtensionRegistryLite> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getUnmodifiable), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_add_Lcom_google_protobuf_GeneratedMessageLite_GeneratedExtension_;
		[Register ("add", "(Lcom/google/protobuf/GeneratedMessageLite$GeneratedExtension;)V", "")]
		public void Add (global::Com.Google.Protobuf.GeneratedMessageLite.GeneratedExtension p0)
		{
			if (id_add_Lcom_google_protobuf_GeneratedMessageLite_GeneratedExtension_ == IntPtr.Zero)
				id_add_Lcom_google_protobuf_GeneratedMessageLite_GeneratedExtension_ = JNIEnv.GetMethodID (class_ref, "add", "(Lcom/google/protobuf/GeneratedMessageLite$GeneratedExtension;)V");
			JNIEnv.CallVoidMethod  (Handle, id_add_Lcom_google_protobuf_GeneratedMessageLite_GeneratedExtension_, new JValue (p0));
		}

		static Delegate cb_findLiteExtensionByNumber_Lcom_google_protobuf_MessageLite_I;
#pragma warning disable 0169
		static Delegate GetFindLiteExtensionByNumber_Lcom_google_protobuf_MessageLite_IHandler ()
		{
			if (cb_findLiteExtensionByNumber_Lcom_google_protobuf_MessageLite_I == null)
				cb_findLiteExtensionByNumber_Lcom_google_protobuf_MessageLite_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, IntPtr>) n_FindLiteExtensionByNumber_Lcom_google_protobuf_MessageLite_I);
			return cb_findLiteExtensionByNumber_Lcom_google_protobuf_MessageLite_I;
		}

		static IntPtr n_FindLiteExtensionByNumber_Lcom_google_protobuf_MessageLite_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			ExtensionRegistryLite __this = Java.Lang.Object.GetObject<ExtensionRegistryLite> (native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.FindLiteExtensionByNumber (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_findLiteExtensionByNumber_Lcom_google_protobuf_MessageLite_I;
		[Register ("findLiteExtensionByNumber", "(Lcom/google/protobuf/MessageLite;I)Lcom/google/protobuf/GeneratedMessageLite$GeneratedExtension;", "GetFindLiteExtensionByNumber_Lcom_google_protobuf_MessageLite_IHandler")]
		public virtual global::Com.Google.Protobuf.GeneratedMessageLite.GeneratedExtension FindLiteExtensionByNumber (global::Java.Lang.Object p0, int p1)
		{
			if (id_findLiteExtensionByNumber_Lcom_google_protobuf_MessageLite_I == IntPtr.Zero)
				id_findLiteExtensionByNumber_Lcom_google_protobuf_MessageLite_I = JNIEnv.GetMethodID (class_ref, "findLiteExtensionByNumber", "(Lcom/google/protobuf/MessageLite;I)Lcom/google/protobuf/GeneratedMessageLite$GeneratedExtension;");
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);

			global::Com.Google.Protobuf.GeneratedMessageLite.GeneratedExtension __ret;
			if (GetType () == ThresholdType)
				__ret = Java.Lang.Object.GetObject<global::Com.Google.Protobuf.GeneratedMessageLite.GeneratedExtension> (JNIEnv.CallObjectMethod  (Handle, id_findLiteExtensionByNumber_Lcom_google_protobuf_MessageLite_I, new JValue (native_p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = Java.Lang.Object.GetObject<global::Com.Google.Protobuf.GeneratedMessageLite.GeneratedExtension> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_findLiteExtensionByNumber_Lcom_google_protobuf_MessageLite_I, new JValue (native_p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static IntPtr id_newInstance;
		[Register ("newInstance", "()Lcom/google/protobuf/ExtensionRegistryLite;", "")]
		public static global::Com.Google.Protobuf.ExtensionRegistryLite NewInstance ()
		{
			if (id_newInstance == IntPtr.Zero)
				id_newInstance = JNIEnv.GetStaticMethodID (class_ref, "newInstance", "()Lcom/google/protobuf/ExtensionRegistryLite;");
			return Java.Lang.Object.GetObject<global::Com.Google.Protobuf.ExtensionRegistryLite> (JNIEnv.CallStaticObjectMethod  (class_ref, id_newInstance), JniHandleOwnership.TransferLocalRef);
		}

	}
}
