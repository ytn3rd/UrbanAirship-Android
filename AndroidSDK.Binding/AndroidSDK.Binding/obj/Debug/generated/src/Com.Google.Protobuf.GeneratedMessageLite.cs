using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Protobuf {

	[global::Android.Runtime.Register ("com/google/protobuf/GeneratedMessageLite", DoNotGenerateAcw=true)]
	public abstract partial class GeneratedMessageLite : global::Com.Google.Protobuf.AbstractMessageLite {

		[global::Android.Runtime.Register ("com/google/protobuf/GeneratedMessageLite$Builder", DoNotGenerateAcw=true)]
		public new abstract partial class Builder : global::Com.Google.Protobuf.AbstractMessageLite.Builder {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/google/protobuf/GeneratedMessageLite$Builder", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Builder); }
			}

			protected Builder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor;
			[Register (".ctor", "()V", "")]
			protected Builder () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				if (GetType () != typeof (Builder)) {
					SetHandle (global::Android.Runtime.JNIEnv.CreateInstance (GetType (), "()V"), JniHandleOwnership.TransferLocalRef);
					return;
				}

				if (id_ctor == IntPtr.Zero)
					id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
				SetHandle (JNIEnv.NewObject (class_ref, id_ctor), JniHandleOwnership.TransferLocalRef);
			}

			protected abstract override global::Java.Lang.Object RawDefaultInstanceForType { [Register ("getDefaultInstanceForType", "()Lcom/google/protobuf/GeneratedMessageLite;", "GetGetDefaultInstanceForTypeHandler")] get; }

			static Delegate cb_clone;
#pragma warning disable 0169
			static Delegate GetCloneHandler ()
			{
				if (cb_clone == null)
					cb_clone = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Clone);
				return cb_clone;
			}

			static IntPtr n_Clone (IntPtr jnienv, IntPtr native__this)
			{
				Builder __this = Java.Lang.Object.GetObject<Builder> (native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.Clone ());
			}
#pragma warning restore 0169

			static IntPtr id_clone;
			[Register ("clone", "()Ljava/lang/Object;", "GetCloneHandler")]
			public override global::Java.Lang.Object Clone ()
			{
				if (id_clone == IntPtr.Zero)
					id_clone = JNIEnv.GetMethodID (class_ref, "clone", "()Ljava/lang/Object;");

				if (GetType () == ThresholdType)
					return (Java.Lang.Object) Java.Lang.Object.GetObject<Java.Lang.Object> (JNIEnv.CallObjectMethod  (Handle, id_clone), JniHandleOwnership.TransferLocalRef);
				else
					return (Java.Lang.Object) Java.Lang.Object.GetObject<Java.Lang.Object> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_clone), JniHandleOwnership.TransferLocalRef);
			}

			static Delegate cb_internalGetResult;
#pragma warning disable 0169
			static Delegate GetInternalGetResultHandler ()
			{
				if (cb_internalGetResult == null)
					cb_internalGetResult = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_InternalGetResult);
				return cb_internalGetResult;
			}

			static IntPtr n_InternalGetResult (IntPtr jnienv, IntPtr native__this)
			{
				Builder __this = Java.Lang.Object.GetObject<Builder> (native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.InternalGetResult ());
			}
#pragma warning restore 0169

			[Register ("internalGetResult", "()Lcom/google/protobuf/GeneratedMessageLite;", "GetInternalGetResultHandler")]
			protected abstract global::Java.Lang.Object InternalGetResult ();

			static Delegate cb_mergeFrom_Lcom_google_protobuf_GeneratedMessageLite_;
#pragma warning disable 0169
			static Delegate GetMergeFrom_Lcom_google_protobuf_GeneratedMessageLite_Handler ()
			{
				if (cb_mergeFrom_Lcom_google_protobuf_GeneratedMessageLite_ == null)
					cb_mergeFrom_Lcom_google_protobuf_GeneratedMessageLite_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_MergeFrom_Lcom_google_protobuf_GeneratedMessageLite_);
				return cb_mergeFrom_Lcom_google_protobuf_GeneratedMessageLite_;
			}

			static IntPtr n_MergeFrom_Lcom_google_protobuf_GeneratedMessageLite_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				Builder __this = Java.Lang.Object.GetObject<Builder> (native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Object p0 = Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.MergeFrom (p0));
				return __ret;
			}
#pragma warning restore 0169

			[Register ("mergeFrom", "(Lcom/google/protobuf/GeneratedMessageLite;)Ljava/lang/Object;", "GetMergeFrom_Lcom_google_protobuf_GeneratedMessageLite_Handler")]
			public abstract global::Java.Lang.Object MergeFrom (global::Java.Lang.Object p0);

			static Delegate cb_parseUnknownField_Lcom_google_protobuf_CodedInputStream_Lcom_google_protobuf_ExtensionRegistryLite_I;
#pragma warning disable 0169
			static Delegate GetParseUnknownField_Lcom_google_protobuf_CodedInputStream_Lcom_google_protobuf_ExtensionRegistryLite_IHandler ()
			{
				if (cb_parseUnknownField_Lcom_google_protobuf_CodedInputStream_Lcom_google_protobuf_ExtensionRegistryLite_I == null)
					cb_parseUnknownField_Lcom_google_protobuf_CodedInputStream_Lcom_google_protobuf_ExtensionRegistryLite_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, int, bool>) n_ParseUnknownField_Lcom_google_protobuf_CodedInputStream_Lcom_google_protobuf_ExtensionRegistryLite_I);
				return cb_parseUnknownField_Lcom_google_protobuf_CodedInputStream_Lcom_google_protobuf_ExtensionRegistryLite_I;
			}

			static bool n_ParseUnknownField_Lcom_google_protobuf_CodedInputStream_Lcom_google_protobuf_ExtensionRegistryLite_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, int p2)
			{
				Builder __this = Java.Lang.Object.GetObject<Builder> (native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Google.Protobuf.CodedInputStream p0 = Java.Lang.Object.GetObject<global::Com.Google.Protobuf.CodedInputStream> (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Com.Google.Protobuf.ExtensionRegistryLite p1 = Java.Lang.Object.GetObject<global::Com.Google.Protobuf.ExtensionRegistryLite> (native_p1, JniHandleOwnership.DoNotTransfer);
				bool __ret = __this.ParseUnknownField (p0, p1, p2);
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_parseUnknownField_Lcom_google_protobuf_CodedInputStream_Lcom_google_protobuf_ExtensionRegistryLite_I;
			[Register ("parseUnknownField", "(Lcom/google/protobuf/CodedInputStream;Lcom/google/protobuf/ExtensionRegistryLite;I)Z", "GetParseUnknownField_Lcom_google_protobuf_CodedInputStream_Lcom_google_protobuf_ExtensionRegistryLite_IHandler")]
			protected virtual bool ParseUnknownField (global::Com.Google.Protobuf.CodedInputStream p0, global::Com.Google.Protobuf.ExtensionRegistryLite p1, int p2)
			{
				if (id_parseUnknownField_Lcom_google_protobuf_CodedInputStream_Lcom_google_protobuf_ExtensionRegistryLite_I == IntPtr.Zero)
					id_parseUnknownField_Lcom_google_protobuf_CodedInputStream_Lcom_google_protobuf_ExtensionRegistryLite_I = JNIEnv.GetMethodID (class_ref, "parseUnknownField", "(Lcom/google/protobuf/CodedInputStream;Lcom/google/protobuf/ExtensionRegistryLite;I)Z");

				bool __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod  (Handle, id_parseUnknownField_Lcom_google_protobuf_CodedInputStream_Lcom_google_protobuf_ExtensionRegistryLite_I, new JValue (p0), new JValue (p1), new JValue (p2));
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, id_parseUnknownField_Lcom_google_protobuf_CodedInputStream_Lcom_google_protobuf_ExtensionRegistryLite_I, new JValue (p0), new JValue (p1), new JValue (p2));
				return __ret;
			}

		}

		[global::Android.Runtime.Register ("com/google/protobuf/GeneratedMessageLite$Builder", DoNotGenerateAcw=true)]
		internal partial class BuilderInvoker : Builder {

			public BuilderInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

			protected override global::System.Type ThresholdType {
				get { return typeof (BuilderInvoker); }
			}

			static IntPtr id_getDefaultInstanceForType;
			protected override global::Java.Lang.Object RawDefaultInstanceForType {
				[Register ("getDefaultInstanceForType", "()Lcom/google/protobuf/GeneratedMessageLite;", "GetGetDefaultInstanceForTypeHandler")]
				get {
					if (id_getDefaultInstanceForType == IntPtr.Zero)
						id_getDefaultInstanceForType = JNIEnv.GetMethodID (class_ref, "getDefaultInstanceForType", "()Lcom/google/protobuf/GeneratedMessageLite;");
					return (Java.Lang.Object) Java.Lang.Object.GetObject<Java.Lang.Object> (JNIEnv.CallObjectMethod  (Handle, id_getDefaultInstanceForType), JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr id_internalGetResult;
			[Register ("internalGetResult", "()Lcom/google/protobuf/GeneratedMessageLite;", "GetInternalGetResultHandler")]
			protected override global::Java.Lang.Object InternalGetResult ()
			{
				if (id_internalGetResult == IntPtr.Zero)
					id_internalGetResult = JNIEnv.GetMethodID (class_ref, "internalGetResult", "()Lcom/google/protobuf/GeneratedMessageLite;");
				return (Java.Lang.Object) Java.Lang.Object.GetObject<Java.Lang.Object> (JNIEnv.CallObjectMethod  (Handle, id_internalGetResult), JniHandleOwnership.TransferLocalRef);
			}

			static IntPtr id_mergeFrom_Lcom_google_protobuf_GeneratedMessageLite_;
			[Register ("mergeFrom", "(Lcom/google/protobuf/GeneratedMessageLite;)Ljava/lang/Object;", "GetMergeFrom_Lcom_google_protobuf_GeneratedMessageLite_Handler")]
			public override global::Java.Lang.Object MergeFrom (global::Java.Lang.Object p0)
			{
				if (id_mergeFrom_Lcom_google_protobuf_GeneratedMessageLite_ == IntPtr.Zero)
					id_mergeFrom_Lcom_google_protobuf_GeneratedMessageLite_ = JNIEnv.GetMethodID (class_ref, "mergeFrom", "(Lcom/google/protobuf/GeneratedMessageLite;)Ljava/lang/Object;");
				IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
				global::Java.Lang.Object __ret = (Java.Lang.Object) Java.Lang.Object.GetObject<Java.Lang.Object> (JNIEnv.CallObjectMethod  (Handle, id_mergeFrom_Lcom_google_protobuf_GeneratedMessageLite_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
				JNIEnv.DeleteLocalRef (native_p0);
				return __ret;
			}

			static IntPtr id_clone;
			[Register ("clone", "()Ljava/lang/Object;", "GetCloneHandler")]
			public override global::Java.Lang.Object Clone ()
			{
				if (id_clone == IntPtr.Zero)
					id_clone = JNIEnv.GetMethodID (class_ref, "clone", "()Ljava/lang/Object;");
				return (Java.Lang.Object) Java.Lang.Object.GetObject<Java.Lang.Object> (JNIEnv.CallObjectMethod  (Handle, id_clone), JniHandleOwnership.TransferLocalRef);
			}

			static IntPtr id_mergeFrom_Lcom_google_protobuf_CodedInputStream_Lcom_google_protobuf_ExtensionRegistryLite_;
			[Register ("mergeFrom", "(Lcom/google/protobuf/CodedInputStream;Lcom/google/protobuf/ExtensionRegistryLite;)Ljava/lang/Object;", "GetMergeFrom_Lcom_google_protobuf_CodedInputStream_Lcom_google_protobuf_ExtensionRegistryLite_Handler")]
			public override global::Java.Lang.Object MergeFrom (global::Com.Google.Protobuf.CodedInputStream p0, global::Com.Google.Protobuf.ExtensionRegistryLite p1)
			{
				if (id_mergeFrom_Lcom_google_protobuf_CodedInputStream_Lcom_google_protobuf_ExtensionRegistryLite_ == IntPtr.Zero)
					id_mergeFrom_Lcom_google_protobuf_CodedInputStream_Lcom_google_protobuf_ExtensionRegistryLite_ = JNIEnv.GetMethodID (class_ref, "mergeFrom", "(Lcom/google/protobuf/CodedInputStream;Lcom/google/protobuf/ExtensionRegistryLite;)Ljava/lang/Object;");
				global::Java.Lang.Object __ret = (Java.Lang.Object) Java.Lang.Object.GetObject<Java.Lang.Object> (JNIEnv.CallObjectMethod  (Handle, id_mergeFrom_Lcom_google_protobuf_CodedInputStream_Lcom_google_protobuf_ExtensionRegistryLite_, new JValue (p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
				return __ret;
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
			[Register ("build", "()Lcom/google/protobuf/MessageLite;", "GetBuildHandler")]
			public override global::Com.Google.Protobuf.IMessageLite Build ()
			{
				if (id_build == IntPtr.Zero)
					id_build = JNIEnv.GetMethodID (class_ref, "build", "()Lcom/google/protobuf/MessageLite;");
				return Java.Lang.Object.GetObject<global::Com.Google.Protobuf.IMessageLite> (JNIEnv.CallObjectMethod  (Handle, id_build), JniHandleOwnership.TransferLocalRef);
			}

			static IntPtr id_buildPartial;
			[Register ("buildPartial", "()Lcom/google/protobuf/MessageLite;", "GetBuildPartialHandler")]
			public override global::Com.Google.Protobuf.IMessageLite BuildPartial ()
			{
				if (id_buildPartial == IntPtr.Zero)
					id_buildPartial = JNIEnv.GetMethodID (class_ref, "buildPartial", "()Lcom/google/protobuf/MessageLite;");
				return Java.Lang.Object.GetObject<global::Com.Google.Protobuf.IMessageLite> (JNIEnv.CallObjectMethod  (Handle, id_buildPartial), JniHandleOwnership.TransferLocalRef);
			}

			static IntPtr id_clear;
			[Register ("clear", "()Lcom/google/protobuf/MessageLite$Builder;", "GetClearHandler")]
			public override global::Com.Google.Protobuf.IMessageLiteBuilder Clear ()
			{
				if (id_clear == IntPtr.Zero)
					id_clear = JNIEnv.GetMethodID (class_ref, "clear", "()Lcom/google/protobuf/MessageLite$Builder;");
				return Java.Lang.Object.GetObject<global::Com.Google.Protobuf.IMessageLiteBuilder> (JNIEnv.CallObjectMethod  (Handle, id_clear), JniHandleOwnership.TransferLocalRef);
			}

		}


		[global::Android.Runtime.Register ("com/google/protobuf/GeneratedMessageLite$ExtendableBuilder", DoNotGenerateAcw=true)]
		public abstract partial class ExtendableBuilder : global::Com.Google.Protobuf.GeneratedMessageLite.Builder {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/google/protobuf/GeneratedMessageLite$ExtendableBuilder", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (ExtendableBuilder); }
			}

			protected ExtendableBuilder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor;
			[Register (".ctor", "()V", "")]
			protected ExtendableBuilder () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				if (GetType () != typeof (ExtendableBuilder)) {
					SetHandle (global::Android.Runtime.JNIEnv.CreateInstance (GetType (), "()V"), JniHandleOwnership.TransferLocalRef);
					return;
				}

				if (id_ctor == IntPtr.Zero)
					id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
				SetHandle (JNIEnv.NewObject (class_ref, id_ctor), JniHandleOwnership.TransferLocalRef);
			}

			static IntPtr id_addExtension_Lcom_google_protobuf_GeneratedMessageLite_GeneratedExtension_Ljava_lang_Object_;
			[Register ("addExtension", "(Lcom/google/protobuf/GeneratedMessageLite$GeneratedExtension;Ljava/lang/Object;)Lcom/google/protobuf/GeneratedMessageLite$ExtendableBuilder;", "")]
			public global::Java.Lang.Object AddExtension (global::Com.Google.Protobuf.GeneratedMessageLite.GeneratedExtension p0, global::Java.Lang.Object p1)
			{
				if (id_addExtension_Lcom_google_protobuf_GeneratedMessageLite_GeneratedExtension_Ljava_lang_Object_ == IntPtr.Zero)
					id_addExtension_Lcom_google_protobuf_GeneratedMessageLite_GeneratedExtension_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "addExtension", "(Lcom/google/protobuf/GeneratedMessageLite$GeneratedExtension;Ljava/lang/Object;)Lcom/google/protobuf/GeneratedMessageLite$ExtendableBuilder;");
				IntPtr native_p1 = JNIEnv.ToLocalJniHandle (p1);
				global::Java.Lang.Object __ret = (Java.Lang.Object) Java.Lang.Object.GetObject<Java.Lang.Object> (JNIEnv.CallObjectMethod  (Handle, id_addExtension_Lcom_google_protobuf_GeneratedMessageLite_GeneratedExtension_Ljava_lang_Object_, new JValue (p0), new JValue (native_p1)), JniHandleOwnership.TransferLocalRef);
				JNIEnv.DeleteLocalRef (native_p1);
				return __ret;
			}

			static IntPtr id_clearExtension_Lcom_google_protobuf_GeneratedMessageLite_GeneratedExtension_;
			[Register ("clearExtension", "(Lcom/google/protobuf/GeneratedMessageLite$GeneratedExtension;)Lcom/google/protobuf/GeneratedMessageLite$ExtendableBuilder;", "")]
			public global::Java.Lang.Object ClearExtension (global::Com.Google.Protobuf.GeneratedMessageLite.GeneratedExtension p0)
			{
				if (id_clearExtension_Lcom_google_protobuf_GeneratedMessageLite_GeneratedExtension_ == IntPtr.Zero)
					id_clearExtension_Lcom_google_protobuf_GeneratedMessageLite_GeneratedExtension_ = JNIEnv.GetMethodID (class_ref, "clearExtension", "(Lcom/google/protobuf/GeneratedMessageLite$GeneratedExtension;)Lcom/google/protobuf/GeneratedMessageLite$ExtendableBuilder;");
				global::Java.Lang.Object __ret = (Java.Lang.Object) Java.Lang.Object.GetObject<Java.Lang.Object> (JNIEnv.CallObjectMethod  (Handle, id_clearExtension_Lcom_google_protobuf_GeneratedMessageLite_GeneratedExtension_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
				return __ret;
			}

			static IntPtr id_getExtension_Lcom_google_protobuf_GeneratedMessageLite_GeneratedExtension_;
			[Register ("getExtension", "(Lcom/google/protobuf/GeneratedMessageLite$GeneratedExtension;)Ljava/lang/Object;", "")]
			public global::Java.Lang.Object GetExtension (global::Com.Google.Protobuf.GeneratedMessageLite.GeneratedExtension p0)
			{
				if (id_getExtension_Lcom_google_protobuf_GeneratedMessageLite_GeneratedExtension_ == IntPtr.Zero)
					id_getExtension_Lcom_google_protobuf_GeneratedMessageLite_GeneratedExtension_ = JNIEnv.GetMethodID (class_ref, "getExtension", "(Lcom/google/protobuf/GeneratedMessageLite$GeneratedExtension;)Ljava/lang/Object;");
				global::Java.Lang.Object __ret = (Java.Lang.Object) Java.Lang.Object.GetObject<Java.Lang.Object> (JNIEnv.CallObjectMethod  (Handle, id_getExtension_Lcom_google_protobuf_GeneratedMessageLite_GeneratedExtension_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
				return __ret;
			}

			static IntPtr id_getExtension_Lcom_google_protobuf_GeneratedMessageLite_GeneratedExtension_I;
			[Register ("getExtension", "(Lcom/google/protobuf/GeneratedMessageLite$GeneratedExtension;I)Ljava/lang/Object;", "")]
			public global::Java.Lang.Object GetExtension (global::Com.Google.Protobuf.GeneratedMessageLite.GeneratedExtension p0, int p1)
			{
				if (id_getExtension_Lcom_google_protobuf_GeneratedMessageLite_GeneratedExtension_I == IntPtr.Zero)
					id_getExtension_Lcom_google_protobuf_GeneratedMessageLite_GeneratedExtension_I = JNIEnv.GetMethodID (class_ref, "getExtension", "(Lcom/google/protobuf/GeneratedMessageLite$GeneratedExtension;I)Ljava/lang/Object;");
				global::Java.Lang.Object __ret = (Java.Lang.Object) Java.Lang.Object.GetObject<Java.Lang.Object> (JNIEnv.CallObjectMethod  (Handle, id_getExtension_Lcom_google_protobuf_GeneratedMessageLite_GeneratedExtension_I, new JValue (p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
				return __ret;
			}

			static IntPtr id_getExtensionCount_Lcom_google_protobuf_GeneratedMessageLite_GeneratedExtension_;
			[Register ("getExtensionCount", "(Lcom/google/protobuf/GeneratedMessageLite$GeneratedExtension;)I", "")]
			public int GetExtensionCount (global::Com.Google.Protobuf.GeneratedMessageLite.GeneratedExtension p0)
			{
				if (id_getExtensionCount_Lcom_google_protobuf_GeneratedMessageLite_GeneratedExtension_ == IntPtr.Zero)
					id_getExtensionCount_Lcom_google_protobuf_GeneratedMessageLite_GeneratedExtension_ = JNIEnv.GetMethodID (class_ref, "getExtensionCount", "(Lcom/google/protobuf/GeneratedMessageLite$GeneratedExtension;)I");
				int __ret = JNIEnv.CallIntMethod  (Handle, id_getExtensionCount_Lcom_google_protobuf_GeneratedMessageLite_GeneratedExtension_, new JValue (p0));
				return __ret;
			}

			static IntPtr id_hasExtension_Lcom_google_protobuf_GeneratedMessageLite_GeneratedExtension_;
			[Register ("hasExtension", "(Lcom/google/protobuf/GeneratedMessageLite$GeneratedExtension;)Z", "")]
			public bool HasExtension (global::Com.Google.Protobuf.GeneratedMessageLite.GeneratedExtension p0)
			{
				if (id_hasExtension_Lcom_google_protobuf_GeneratedMessageLite_GeneratedExtension_ == IntPtr.Zero)
					id_hasExtension_Lcom_google_protobuf_GeneratedMessageLite_GeneratedExtension_ = JNIEnv.GetMethodID (class_ref, "hasExtension", "(Lcom/google/protobuf/GeneratedMessageLite$GeneratedExtension;)Z");
				bool __ret = JNIEnv.CallBooleanMethod  (Handle, id_hasExtension_Lcom_google_protobuf_GeneratedMessageLite_GeneratedExtension_, new JValue (p0));
				return __ret;
			}

			static Delegate cb_internalGetResult;
#pragma warning disable 0169
			static Delegate GetInternalGetResultHandler ()
			{
				if (cb_internalGetResult == null)
					cb_internalGetResult = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_InternalGetResult);
				return cb_internalGetResult;
			}

			static IntPtr n_InternalGetResult (IntPtr jnienv, IntPtr native__this)
			{
				ExtendableBuilder __this = Java.Lang.Object.GetObject<ExtendableBuilder> (native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.InternalGetResult ());
			}
#pragma warning restore 0169

			[Register ("internalGetResult", "()Lcom/google/protobuf/GeneratedMessageLite$ExtendableMessage;", "GetInternalGetResultHandler")]
			protected abstract global::Java.Lang.Object InternalGetResult ();

			static IntPtr id_mergeExtensionFields_Lcom_google_protobuf_GeneratedMessageLite_ExtendableMessage_;
			[Register ("mergeExtensionFields", "(Lcom/google/protobuf/GeneratedMessageLite$ExtendableMessage;)V", "")]
			protected void MergeExtensionFields (global::Java.Lang.Object p0)
			{
				if (id_mergeExtensionFields_Lcom_google_protobuf_GeneratedMessageLite_ExtendableMessage_ == IntPtr.Zero)
					id_mergeExtensionFields_Lcom_google_protobuf_GeneratedMessageLite_ExtendableMessage_ = JNIEnv.GetMethodID (class_ref, "mergeExtensionFields", "(Lcom/google/protobuf/GeneratedMessageLite$ExtendableMessage;)V");
				IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
				JNIEnv.CallVoidMethod  (Handle, id_mergeExtensionFields_Lcom_google_protobuf_GeneratedMessageLite_ExtendableMessage_, new JValue (native_p0));
				JNIEnv.DeleteLocalRef (native_p0);
			}

			static IntPtr id_setExtension_Lcom_google_protobuf_GeneratedMessageLite_GeneratedExtension_Ljava_lang_Object_;
			[Register ("setExtension", "(Lcom/google/protobuf/GeneratedMessageLite$GeneratedExtension;Ljava/lang/Object;)Lcom/google/protobuf/GeneratedMessageLite$ExtendableBuilder;", "")]
			public global::Java.Lang.Object SetExtension (global::Com.Google.Protobuf.GeneratedMessageLite.GeneratedExtension p0, global::Java.Lang.Object p1)
			{
				if (id_setExtension_Lcom_google_protobuf_GeneratedMessageLite_GeneratedExtension_Ljava_lang_Object_ == IntPtr.Zero)
					id_setExtension_Lcom_google_protobuf_GeneratedMessageLite_GeneratedExtension_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "setExtension", "(Lcom/google/protobuf/GeneratedMessageLite$GeneratedExtension;Ljava/lang/Object;)Lcom/google/protobuf/GeneratedMessageLite$ExtendableBuilder;");
				IntPtr native_p1 = JNIEnv.ToLocalJniHandle (p1);
				global::Java.Lang.Object __ret = (Java.Lang.Object) Java.Lang.Object.GetObject<Java.Lang.Object> (JNIEnv.CallObjectMethod  (Handle, id_setExtension_Lcom_google_protobuf_GeneratedMessageLite_GeneratedExtension_Ljava_lang_Object_, new JValue (p0), new JValue (native_p1)), JniHandleOwnership.TransferLocalRef);
				JNIEnv.DeleteLocalRef (native_p1);
				return __ret;
			}

			static IntPtr id_setExtension_Lcom_google_protobuf_GeneratedMessageLite_GeneratedExtension_ILjava_lang_Object_;
			[Register ("setExtension", "(Lcom/google/protobuf/GeneratedMessageLite$GeneratedExtension;ILjava/lang/Object;)Lcom/google/protobuf/GeneratedMessageLite$ExtendableBuilder;", "")]
			public global::Java.Lang.Object SetExtension (global::Com.Google.Protobuf.GeneratedMessageLite.GeneratedExtension p0, int p1, global::Java.Lang.Object p2)
			{
				if (id_setExtension_Lcom_google_protobuf_GeneratedMessageLite_GeneratedExtension_ILjava_lang_Object_ == IntPtr.Zero)
					id_setExtension_Lcom_google_protobuf_GeneratedMessageLite_GeneratedExtension_ILjava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "setExtension", "(Lcom/google/protobuf/GeneratedMessageLite$GeneratedExtension;ILjava/lang/Object;)Lcom/google/protobuf/GeneratedMessageLite$ExtendableBuilder;");
				IntPtr native_p2 = JNIEnv.ToLocalJniHandle (p2);
				global::Java.Lang.Object __ret = (Java.Lang.Object) Java.Lang.Object.GetObject<Java.Lang.Object> (JNIEnv.CallObjectMethod  (Handle, id_setExtension_Lcom_google_protobuf_GeneratedMessageLite_GeneratedExtension_ILjava_lang_Object_, new JValue (p0), new JValue (p1), new JValue (native_p2)), JniHandleOwnership.TransferLocalRef);
				JNIEnv.DeleteLocalRef (native_p2);
				return __ret;
			}

		}

		[global::Android.Runtime.Register ("com/google/protobuf/GeneratedMessageLite$ExtendableBuilder", DoNotGenerateAcw=true)]
		internal partial class ExtendableBuilderInvoker : ExtendableBuilder {

			public ExtendableBuilderInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

			protected override global::System.Type ThresholdType {
				get { return typeof (ExtendableBuilderInvoker); }
			}

			static IntPtr id_internalGetResult;
			[Register ("internalGetResult", "()Lcom/google/protobuf/GeneratedMessageLite$ExtendableMessage;", "GetInternalGetResultHandler")]
			protected override global::Java.Lang.Object InternalGetResult ()
			{
				if (id_internalGetResult == IntPtr.Zero)
					id_internalGetResult = JNIEnv.GetMethodID (class_ref, "internalGetResult", "()Lcom/google/protobuf/GeneratedMessageLite$ExtendableMessage;");
				return (Java.Lang.Object) Java.Lang.Object.GetObject<Java.Lang.Object> (JNIEnv.CallObjectMethod  (Handle, id_internalGetResult), JniHandleOwnership.TransferLocalRef);
			}

			static IntPtr id_getDefaultInstanceForType;
			protected override global::Java.Lang.Object RawDefaultInstanceForType {
				[Register ("getDefaultInstanceForType", "()Lcom/google/protobuf/GeneratedMessageLite;", "GetGetDefaultInstanceForTypeHandler")]
				get {
					if (id_getDefaultInstanceForType == IntPtr.Zero)
						id_getDefaultInstanceForType = JNIEnv.GetMethodID (class_ref, "getDefaultInstanceForType", "()Lcom/google/protobuf/GeneratedMessageLite;");
					return (Java.Lang.Object) Java.Lang.Object.GetObject<Java.Lang.Object> (JNIEnv.CallObjectMethod  (Handle, id_getDefaultInstanceForType), JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr id_internalGetResult;
			[Register ("internalGetResult", "()Lcom/google/protobuf/GeneratedMessageLite;", "GetInternalGetResultHandler")]
			protected override global::Java.Lang.Object InternalGetResult ()
			{
				if (id_internalGetResult == IntPtr.Zero)
					id_internalGetResult = JNIEnv.GetMethodID (class_ref, "internalGetResult", "()Lcom/google/protobuf/GeneratedMessageLite;");
				return (Java.Lang.Object) Java.Lang.Object.GetObject<Java.Lang.Object> (JNIEnv.CallObjectMethod  (Handle, id_internalGetResult), JniHandleOwnership.TransferLocalRef);
			}

			static IntPtr id_mergeFrom_Lcom_google_protobuf_GeneratedMessageLite_;
			[Register ("mergeFrom", "(Lcom/google/protobuf/GeneratedMessageLite;)Ljava/lang/Object;", "GetMergeFrom_Lcom_google_protobuf_GeneratedMessageLite_Handler")]
			public override global::Java.Lang.Object MergeFrom (global::Java.Lang.Object p0)
			{
				if (id_mergeFrom_Lcom_google_protobuf_GeneratedMessageLite_ == IntPtr.Zero)
					id_mergeFrom_Lcom_google_protobuf_GeneratedMessageLite_ = JNIEnv.GetMethodID (class_ref, "mergeFrom", "(Lcom/google/protobuf/GeneratedMessageLite;)Ljava/lang/Object;");
				IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
				global::Java.Lang.Object __ret = (Java.Lang.Object) Java.Lang.Object.GetObject<Java.Lang.Object> (JNIEnv.CallObjectMethod  (Handle, id_mergeFrom_Lcom_google_protobuf_GeneratedMessageLite_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
				JNIEnv.DeleteLocalRef (native_p0);
				return __ret;
			}

			static IntPtr id_clone;
			[Register ("clone", "()Ljava/lang/Object;", "GetCloneHandler")]
			public override global::Java.Lang.Object Clone ()
			{
				if (id_clone == IntPtr.Zero)
					id_clone = JNIEnv.GetMethodID (class_ref, "clone", "()Ljava/lang/Object;");
				return (Java.Lang.Object) Java.Lang.Object.GetObject<Java.Lang.Object> (JNIEnv.CallObjectMethod  (Handle, id_clone), JniHandleOwnership.TransferLocalRef);
			}

			static IntPtr id_mergeFrom_Lcom_google_protobuf_CodedInputStream_Lcom_google_protobuf_ExtensionRegistryLite_;
			[Register ("mergeFrom", "(Lcom/google/protobuf/CodedInputStream;Lcom/google/protobuf/ExtensionRegistryLite;)Ljava/lang/Object;", "GetMergeFrom_Lcom_google_protobuf_CodedInputStream_Lcom_google_protobuf_ExtensionRegistryLite_Handler")]
			public override global::Java.Lang.Object MergeFrom (global::Com.Google.Protobuf.CodedInputStream p0, global::Com.Google.Protobuf.ExtensionRegistryLite p1)
			{
				if (id_mergeFrom_Lcom_google_protobuf_CodedInputStream_Lcom_google_protobuf_ExtensionRegistryLite_ == IntPtr.Zero)
					id_mergeFrom_Lcom_google_protobuf_CodedInputStream_Lcom_google_protobuf_ExtensionRegistryLite_ = JNIEnv.GetMethodID (class_ref, "mergeFrom", "(Lcom/google/protobuf/CodedInputStream;Lcom/google/protobuf/ExtensionRegistryLite;)Ljava/lang/Object;");
				global::Java.Lang.Object __ret = (Java.Lang.Object) Java.Lang.Object.GetObject<Java.Lang.Object> (JNIEnv.CallObjectMethod  (Handle, id_mergeFrom_Lcom_google_protobuf_CodedInputStream_Lcom_google_protobuf_ExtensionRegistryLite_, new JValue (p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
				return __ret;
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
			[Register ("build", "()Lcom/google/protobuf/MessageLite;", "GetBuildHandler")]
			public override global::Com.Google.Protobuf.IMessageLite Build ()
			{
				if (id_build == IntPtr.Zero)
					id_build = JNIEnv.GetMethodID (class_ref, "build", "()Lcom/google/protobuf/MessageLite;");
				return Java.Lang.Object.GetObject<global::Com.Google.Protobuf.IMessageLite> (JNIEnv.CallObjectMethod  (Handle, id_build), JniHandleOwnership.TransferLocalRef);
			}

			static IntPtr id_buildPartial;
			[Register ("buildPartial", "()Lcom/google/protobuf/MessageLite;", "GetBuildPartialHandler")]
			public override global::Com.Google.Protobuf.IMessageLite BuildPartial ()
			{
				if (id_buildPartial == IntPtr.Zero)
					id_buildPartial = JNIEnv.GetMethodID (class_ref, "buildPartial", "()Lcom/google/protobuf/MessageLite;");
				return Java.Lang.Object.GetObject<global::Com.Google.Protobuf.IMessageLite> (JNIEnv.CallObjectMethod  (Handle, id_buildPartial), JniHandleOwnership.TransferLocalRef);
			}

			static IntPtr id_clear;
			[Register ("clear", "()Lcom/google/protobuf/MessageLite$Builder;", "GetClearHandler")]
			public override global::Com.Google.Protobuf.IMessageLiteBuilder Clear ()
			{
				if (id_clear == IntPtr.Zero)
					id_clear = JNIEnv.GetMethodID (class_ref, "clear", "()Lcom/google/protobuf/MessageLite$Builder;");
				return Java.Lang.Object.GetObject<global::Com.Google.Protobuf.IMessageLiteBuilder> (JNIEnv.CallObjectMethod  (Handle, id_clear), JniHandleOwnership.TransferLocalRef);
			}

		}


		[global::Android.Runtime.Register ("com/google/protobuf/GeneratedMessageLite$ExtendableMessage", DoNotGenerateAcw=true)]
		public abstract partial class ExtendableMessage : global::Com.Google.Protobuf.GeneratedMessageLite {

			[global::Android.Runtime.Register ("com/google/protobuf/GeneratedMessageLite$ExtendableMessage$ExtensionWriter", DoNotGenerateAcw=true)]
			protected internal partial class ExtensionWriter : global::Java.Lang.Object {

				internal static IntPtr java_class_handle;
				internal static IntPtr class_ref {
					get {
						return JNIEnv.FindClass ("com/google/protobuf/GeneratedMessageLite$ExtendableMessage$ExtensionWriter", ref java_class_handle);
					}
				}

				protected override IntPtr ThresholdClass {
					get { return class_ref; }
				}

				protected override global::System.Type ThresholdType {
					get { return typeof (ExtensionWriter); }
				}

				protected ExtensionWriter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

				static Delegate cb_writeUntil_ILcom_google_protobuf_CodedOutputStream_;
#pragma warning disable 0169
				static Delegate GetWriteUntil_ILcom_google_protobuf_CodedOutputStream_Handler ()
				{
					if (cb_writeUntil_ILcom_google_protobuf_CodedOutputStream_ == null)
						cb_writeUntil_ILcom_google_protobuf_CodedOutputStream_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr>) n_WriteUntil_ILcom_google_protobuf_CodedOutputStream_);
					return cb_writeUntil_ILcom_google_protobuf_CodedOutputStream_;
				}

				static void n_WriteUntil_ILcom_google_protobuf_CodedOutputStream_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
				{
					ExtensionWriter __this = Java.Lang.Object.GetObject<ExtensionWriter> (native__this, JniHandleOwnership.DoNotTransfer);
					global::Com.Google.Protobuf.CodedOutputStream p1 = Java.Lang.Object.GetObject<global::Com.Google.Protobuf.CodedOutputStream> (native_p1, JniHandleOwnership.DoNotTransfer);
					__this.WriteUntil (p0, p1);
				}
#pragma warning restore 0169

				static IntPtr id_writeUntil_ILcom_google_protobuf_CodedOutputStream_;
				[Register ("writeUntil", "(ILcom/google/protobuf/CodedOutputStream;)V", "GetWriteUntil_ILcom_google_protobuf_CodedOutputStream_Handler")]
				public virtual void WriteUntil (int p0, global::Com.Google.Protobuf.CodedOutputStream p1)
				{
					if (id_writeUntil_ILcom_google_protobuf_CodedOutputStream_ == IntPtr.Zero)
						id_writeUntil_ILcom_google_protobuf_CodedOutputStream_ = JNIEnv.GetMethodID (class_ref, "writeUntil", "(ILcom/google/protobuf/CodedOutputStream;)V");

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_writeUntil_ILcom_google_protobuf_CodedOutputStream_, new JValue (p0), new JValue (p1));
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_writeUntil_ILcom_google_protobuf_CodedOutputStream_, new JValue (p0), new JValue (p1));
				}

			}

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/google/protobuf/GeneratedMessageLite$ExtendableMessage", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (ExtendableMessage); }
			}

			protected ExtendableMessage (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor;
			[Register (".ctor", "()V", "")]
			protected ExtendableMessage () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				if (GetType () != typeof (ExtendableMessage)) {
					SetHandle (global::Android.Runtime.JNIEnv.CreateInstance (GetType (), "()V"), JniHandleOwnership.TransferLocalRef);
					return;
				}

				if (id_ctor == IntPtr.Zero)
					id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
				SetHandle (JNIEnv.NewObject (class_ref, id_ctor), JniHandleOwnership.TransferLocalRef);
			}

			static Delegate cb_extensionsAreInitialized;
#pragma warning disable 0169
			static Delegate GetExtensionsAreInitializedHandler ()
			{
				if (cb_extensionsAreInitialized == null)
					cb_extensionsAreInitialized = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_ExtensionsAreInitialized);
				return cb_extensionsAreInitialized;
			}

			static bool n_ExtensionsAreInitialized (IntPtr jnienv, IntPtr native__this)
			{
				ExtendableMessage __this = Java.Lang.Object.GetObject<ExtendableMessage> (native__this, JniHandleOwnership.DoNotTransfer);
				return __this.ExtensionsAreInitialized ();
			}
#pragma warning restore 0169

			static IntPtr id_extensionsAreInitialized;
			[Register ("extensionsAreInitialized", "()Z", "GetExtensionsAreInitializedHandler")]
			protected virtual bool ExtensionsAreInitialized ()
			{
				if (id_extensionsAreInitialized == IntPtr.Zero)
					id_extensionsAreInitialized = JNIEnv.GetMethodID (class_ref, "extensionsAreInitialized", "()Z");

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_extensionsAreInitialized);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, id_extensionsAreInitialized);
			}

			static Delegate cb_extensionsSerializedSize;
#pragma warning disable 0169
			static Delegate GetExtensionsSerializedSizeHandler ()
			{
				if (cb_extensionsSerializedSize == null)
					cb_extensionsSerializedSize = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_ExtensionsSerializedSize);
				return cb_extensionsSerializedSize;
			}

			static int n_ExtensionsSerializedSize (IntPtr jnienv, IntPtr native__this)
			{
				ExtendableMessage __this = Java.Lang.Object.GetObject<ExtendableMessage> (native__this, JniHandleOwnership.DoNotTransfer);
				return __this.ExtensionsSerializedSize ();
			}
#pragma warning restore 0169

			static IntPtr id_extensionsSerializedSize;
			[Register ("extensionsSerializedSize", "()I", "GetExtensionsSerializedSizeHandler")]
			protected virtual int ExtensionsSerializedSize ()
			{
				if (id_extensionsSerializedSize == IntPtr.Zero)
					id_extensionsSerializedSize = JNIEnv.GetMethodID (class_ref, "extensionsSerializedSize", "()I");

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_extensionsSerializedSize);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, id_extensionsSerializedSize);
			}

			static Delegate cb_extensionsSerializedSizeAsMessageSet;
#pragma warning disable 0169
			static Delegate GetExtensionsSerializedSizeAsMessageSetHandler ()
			{
				if (cb_extensionsSerializedSizeAsMessageSet == null)
					cb_extensionsSerializedSizeAsMessageSet = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_ExtensionsSerializedSizeAsMessageSet);
				return cb_extensionsSerializedSizeAsMessageSet;
			}

			static int n_ExtensionsSerializedSizeAsMessageSet (IntPtr jnienv, IntPtr native__this)
			{
				ExtendableMessage __this = Java.Lang.Object.GetObject<ExtendableMessage> (native__this, JniHandleOwnership.DoNotTransfer);
				return __this.ExtensionsSerializedSizeAsMessageSet ();
			}
#pragma warning restore 0169

			static IntPtr id_extensionsSerializedSizeAsMessageSet;
			[Register ("extensionsSerializedSizeAsMessageSet", "()I", "GetExtensionsSerializedSizeAsMessageSetHandler")]
			protected virtual int ExtensionsSerializedSizeAsMessageSet ()
			{
				if (id_extensionsSerializedSizeAsMessageSet == IntPtr.Zero)
					id_extensionsSerializedSizeAsMessageSet = JNIEnv.GetMethodID (class_ref, "extensionsSerializedSizeAsMessageSet", "()I");

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_extensionsSerializedSizeAsMessageSet);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, id_extensionsSerializedSizeAsMessageSet);
			}

			static IntPtr id_getExtension_Lcom_google_protobuf_GeneratedMessageLite_GeneratedExtension_;
			[Register ("getExtension", "(Lcom/google/protobuf/GeneratedMessageLite$GeneratedExtension;)Ljava/lang/Object;", "")]
			public global::Java.Lang.Object GetExtension (global::Com.Google.Protobuf.GeneratedMessageLite.GeneratedExtension p0)
			{
				if (id_getExtension_Lcom_google_protobuf_GeneratedMessageLite_GeneratedExtension_ == IntPtr.Zero)
					id_getExtension_Lcom_google_protobuf_GeneratedMessageLite_GeneratedExtension_ = JNIEnv.GetMethodID (class_ref, "getExtension", "(Lcom/google/protobuf/GeneratedMessageLite$GeneratedExtension;)Ljava/lang/Object;");
				global::Java.Lang.Object __ret = (Java.Lang.Object) Java.Lang.Object.GetObject<Java.Lang.Object> (JNIEnv.CallObjectMethod  (Handle, id_getExtension_Lcom_google_protobuf_GeneratedMessageLite_GeneratedExtension_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
				return __ret;
			}

			static IntPtr id_getExtension_Lcom_google_protobuf_GeneratedMessageLite_GeneratedExtension_I;
			[Register ("getExtension", "(Lcom/google/protobuf/GeneratedMessageLite$GeneratedExtension;I)Ljava/lang/Object;", "")]
			public global::Java.Lang.Object GetExtension (global::Com.Google.Protobuf.GeneratedMessageLite.GeneratedExtension p0, int p1)
			{
				if (id_getExtension_Lcom_google_protobuf_GeneratedMessageLite_GeneratedExtension_I == IntPtr.Zero)
					id_getExtension_Lcom_google_protobuf_GeneratedMessageLite_GeneratedExtension_I = JNIEnv.GetMethodID (class_ref, "getExtension", "(Lcom/google/protobuf/GeneratedMessageLite$GeneratedExtension;I)Ljava/lang/Object;");
				global::Java.Lang.Object __ret = (Java.Lang.Object) Java.Lang.Object.GetObject<Java.Lang.Object> (JNIEnv.CallObjectMethod  (Handle, id_getExtension_Lcom_google_protobuf_GeneratedMessageLite_GeneratedExtension_I, new JValue (p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
				return __ret;
			}

			static IntPtr id_getExtensionCount_Lcom_google_protobuf_GeneratedMessageLite_GeneratedExtension_;
			[Register ("getExtensionCount", "(Lcom/google/protobuf/GeneratedMessageLite$GeneratedExtension;)I", "")]
			public int GetExtensionCount (global::Com.Google.Protobuf.GeneratedMessageLite.GeneratedExtension p0)
			{
				if (id_getExtensionCount_Lcom_google_protobuf_GeneratedMessageLite_GeneratedExtension_ == IntPtr.Zero)
					id_getExtensionCount_Lcom_google_protobuf_GeneratedMessageLite_GeneratedExtension_ = JNIEnv.GetMethodID (class_ref, "getExtensionCount", "(Lcom/google/protobuf/GeneratedMessageLite$GeneratedExtension;)I");
				int __ret = JNIEnv.CallIntMethod  (Handle, id_getExtensionCount_Lcom_google_protobuf_GeneratedMessageLite_GeneratedExtension_, new JValue (p0));
				return __ret;
			}

			static IntPtr id_hasExtension_Lcom_google_protobuf_GeneratedMessageLite_GeneratedExtension_;
			[Register ("hasExtension", "(Lcom/google/protobuf/GeneratedMessageLite$GeneratedExtension;)Z", "")]
			public bool HasExtension (global::Com.Google.Protobuf.GeneratedMessageLite.GeneratedExtension p0)
			{
				if (id_hasExtension_Lcom_google_protobuf_GeneratedMessageLite_GeneratedExtension_ == IntPtr.Zero)
					id_hasExtension_Lcom_google_protobuf_GeneratedMessageLite_GeneratedExtension_ = JNIEnv.GetMethodID (class_ref, "hasExtension", "(Lcom/google/protobuf/GeneratedMessageLite$GeneratedExtension;)Z");
				bool __ret = JNIEnv.CallBooleanMethod  (Handle, id_hasExtension_Lcom_google_protobuf_GeneratedMessageLite_GeneratedExtension_, new JValue (p0));
				return __ret;
			}

		}

		[global::Android.Runtime.Register ("com/google/protobuf/GeneratedMessageLite$ExtendableMessage", DoNotGenerateAcw=true)]
		internal partial class ExtendableMessageInvoker : ExtendableMessage {

			public ExtendableMessageInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

			protected override global::System.Type ThresholdType {
				get { return typeof (ExtendableMessageInvoker); }
			}

			static IntPtr id_getDefaultInstanceForType;
			public override global::Com.Google.Protobuf.IMessageLite DefaultInstanceForType {
				[Register ("getDefaultInstanceForType", "()Lcom/google/protobuf/MessageLite;", "GetGetDefaultInstanceForTypeHandler")]
				get {
					if (id_getDefaultInstanceForType == IntPtr.Zero)
						id_getDefaultInstanceForType = JNIEnv.GetMethodID (class_ref, "getDefaultInstanceForType", "()Lcom/google/protobuf/MessageLite;");
					return Java.Lang.Object.GetObject<global::Com.Google.Protobuf.IMessageLite> (JNIEnv.CallObjectMethod  (Handle, id_getDefaultInstanceForType), JniHandleOwnership.TransferLocalRef);
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

			static IntPtr id_newBuilderForType;
			[Register ("newBuilderForType", "()Lcom/google/protobuf/MessageLite$Builder;", "GetNewBuilderForTypeHandler")]
			public override global::Com.Google.Protobuf.IMessageLiteBuilder NewBuilderForType ()
			{
				if (id_newBuilderForType == IntPtr.Zero)
					id_newBuilderForType = JNIEnv.GetMethodID (class_ref, "newBuilderForType", "()Lcom/google/protobuf/MessageLite$Builder;");
				return Java.Lang.Object.GetObject<global::Com.Google.Protobuf.IMessageLiteBuilder> (JNIEnv.CallObjectMethod  (Handle, id_newBuilderForType), JniHandleOwnership.TransferLocalRef);
			}

			static IntPtr id_toBuilder;
			[Register ("toBuilder", "()Lcom/google/protobuf/MessageLite$Builder;", "GetToBuilderHandler")]
			public override global::Com.Google.Protobuf.IMessageLiteBuilder ToBuilder ()
			{
				if (id_toBuilder == IntPtr.Zero)
					id_toBuilder = JNIEnv.GetMethodID (class_ref, "toBuilder", "()Lcom/google/protobuf/MessageLite$Builder;");
				return Java.Lang.Object.GetObject<global::Com.Google.Protobuf.IMessageLiteBuilder> (JNIEnv.CallObjectMethod  (Handle, id_toBuilder), JniHandleOwnership.TransferLocalRef);
			}

			static IntPtr id_writeTo_Lcom_google_protobuf_CodedOutputStream_;
			[Register ("writeTo", "(Lcom/google/protobuf/CodedOutputStream;)V", "GetWriteTo_Lcom_google_protobuf_CodedOutputStream_Handler")]
			public override void WriteTo (global::Com.Google.Protobuf.CodedOutputStream p0)
			{
				if (id_writeTo_Lcom_google_protobuf_CodedOutputStream_ == IntPtr.Zero)
					id_writeTo_Lcom_google_protobuf_CodedOutputStream_ = JNIEnv.GetMethodID (class_ref, "writeTo", "(Lcom/google/protobuf/CodedOutputStream;)V");
				JNIEnv.CallVoidMethod  (Handle, id_writeTo_Lcom_google_protobuf_CodedOutputStream_, new JValue (p0));
			}

		}


		[global::Android.Runtime.Register ("com/google/protobuf/GeneratedMessageLite$ExtensionDescriptor", DoNotGenerateAcw=true)]
		public sealed partial class ExtensionDescriptor : global::Java.Lang.Object {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/google/protobuf/GeneratedMessageLite$ExtensionDescriptor", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (ExtensionDescriptor); }
			}

			internal ExtensionDescriptor (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_getEnumType;
			public global::Com.Google.Protobuf.Internal.IEnumLiteMap EnumType {
				[Register ("getEnumType", "()Lcom/google/protobuf/Internal$EnumLiteMap;", "GetGetEnumTypeHandler")]
				get {
					if (id_getEnumType == IntPtr.Zero)
						id_getEnumType = JNIEnv.GetMethodID (class_ref, "getEnumType", "()Lcom/google/protobuf/Internal$EnumLiteMap;");
					return Java.Lang.Object.GetObject<global::Com.Google.Protobuf.Internal.IEnumLiteMap> (JNIEnv.CallObjectMethod  (Handle, id_getEnumType), JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr id_isPacked;
			public bool IsPacked {
				[Register ("isPacked", "()Z", "GetIsPackedHandler")]
				get {
					if (id_isPacked == IntPtr.Zero)
						id_isPacked = JNIEnv.GetMethodID (class_ref, "isPacked", "()Z");
					return JNIEnv.CallBooleanMethod  (Handle, id_isPacked);
				}
			}

			static IntPtr id_isRepeated;
			public bool IsRepeated {
				[Register ("isRepeated", "()Z", "GetIsRepeatedHandler")]
				get {
					if (id_isRepeated == IntPtr.Zero)
						id_isRepeated = JNIEnv.GetMethodID (class_ref, "isRepeated", "()Z");
					return JNIEnv.CallBooleanMethod  (Handle, id_isRepeated);
				}
			}

			static IntPtr id_getLiteJavaType;
			public global::Com.Google.Protobuf.WireFormat.JavaType LiteJavaType {
				[Register ("getLiteJavaType", "()Lcom/google/protobuf/WireFormat$JavaType;", "GetGetLiteJavaTypeHandler")]
				get {
					if (id_getLiteJavaType == IntPtr.Zero)
						id_getLiteJavaType = JNIEnv.GetMethodID (class_ref, "getLiteJavaType", "()Lcom/google/protobuf/WireFormat$JavaType;");
					return Java.Lang.Object.GetObject<global::Com.Google.Protobuf.WireFormat.JavaType> (JNIEnv.CallObjectMethod  (Handle, id_getLiteJavaType), JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr id_getLiteType;
			public global::Com.Google.Protobuf.WireFormat.FieldType LiteType {
				[Register ("getLiteType", "()Lcom/google/protobuf/WireFormat$FieldType;", "GetGetLiteTypeHandler")]
				get {
					if (id_getLiteType == IntPtr.Zero)
						id_getLiteType = JNIEnv.GetMethodID (class_ref, "getLiteType", "()Lcom/google/protobuf/WireFormat$FieldType;");
					return Java.Lang.Object.GetObject<global::Com.Google.Protobuf.WireFormat.FieldType> (JNIEnv.CallObjectMethod  (Handle, id_getLiteType), JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr id_getNumber;
			public int Number {
				[Register ("getNumber", "()I", "GetGetNumberHandler")]
				get {
					if (id_getNumber == IntPtr.Zero)
						id_getNumber = JNIEnv.GetMethodID (class_ref, "getNumber", "()I");
					return JNIEnv.CallIntMethod  (Handle, id_getNumber);
				}
			}

			static IntPtr id_compareTo_Ljava_lang_Object_;
			[Register ("compareTo", "(Ljava/lang/Object;)I", "")]
			public int CompareTo (global::Java.Lang.Object p0)
			{
				if (id_compareTo_Ljava_lang_Object_ == IntPtr.Zero)
					id_compareTo_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "compareTo", "(Ljava/lang/Object;)I");
				int __ret = JNIEnv.CallIntMethod  (Handle, id_compareTo_Ljava_lang_Object_, new JValue (p0));
				return __ret;
			}

			static IntPtr id_internalMergeFrom_Lcom_google_protobuf_MessageLite_Builder_Lcom_google_protobuf_MessageLite_;
			[Register ("internalMergeFrom", "(Lcom/google/protobuf/MessageLite$Builder;Lcom/google/protobuf/MessageLite;)Lcom/google/protobuf/MessageLite$Builder;", "")]
			public global::Com.Google.Protobuf.IMessageLiteBuilder InternalMergeFrom (global::Com.Google.Protobuf.IMessageLiteBuilder p0, global::Com.Google.Protobuf.IMessageLite p1)
			{
				if (id_internalMergeFrom_Lcom_google_protobuf_MessageLite_Builder_Lcom_google_protobuf_MessageLite_ == IntPtr.Zero)
					id_internalMergeFrom_Lcom_google_protobuf_MessageLite_Builder_Lcom_google_protobuf_MessageLite_ = JNIEnv.GetMethodID (class_ref, "internalMergeFrom", "(Lcom/google/protobuf/MessageLite$Builder;Lcom/google/protobuf/MessageLite;)Lcom/google/protobuf/MessageLite$Builder;");
				global::Com.Google.Protobuf.IMessageLiteBuilder __ret = Java.Lang.Object.GetObject<global::Com.Google.Protobuf.IMessageLiteBuilder> (JNIEnv.CallObjectMethod  (Handle, id_internalMergeFrom_Lcom_google_protobuf_MessageLite_Builder_Lcom_google_protobuf_MessageLite_, new JValue (p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
				return __ret;
			}

		}

		[global::Android.Runtime.Register ("com/google/protobuf/GeneratedMessageLite$GeneratedExtension", DoNotGenerateAcw=true)]
		public sealed partial class GeneratedExtension : global::Java.Lang.Object {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/google/protobuf/GeneratedMessageLite$GeneratedExtension", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (GeneratedExtension); }
			}

			internal GeneratedExtension (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_getContainingTypeDefaultInstance;
			public global::Java.Lang.Object ContainingTypeDefaultInstance {
				[Register ("getContainingTypeDefaultInstance", "()Lcom/google/protobuf/MessageLite;", "GetGetContainingTypeDefaultInstanceHandler")]
				get {
					if (id_getContainingTypeDefaultInstance == IntPtr.Zero)
						id_getContainingTypeDefaultInstance = JNIEnv.GetMethodID (class_ref, "getContainingTypeDefaultInstance", "()Lcom/google/protobuf/MessageLite;");
					return (Java.Lang.Object) Java.Lang.Object.GetObject<Java.Lang.Object> (JNIEnv.CallObjectMethod  (Handle, id_getContainingTypeDefaultInstance), JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr id_getMessageDefaultInstance;
			public global::Com.Google.Protobuf.IMessageLite MessageDefaultInstance {
				[Register ("getMessageDefaultInstance", "()Lcom/google/protobuf/MessageLite;", "GetGetMessageDefaultInstanceHandler")]
				get {
					if (id_getMessageDefaultInstance == IntPtr.Zero)
						id_getMessageDefaultInstance = JNIEnv.GetMethodID (class_ref, "getMessageDefaultInstance", "()Lcom/google/protobuf/MessageLite;");
					return Java.Lang.Object.GetObject<global::Com.Google.Protobuf.IMessageLite> (JNIEnv.CallObjectMethod  (Handle, id_getMessageDefaultInstance), JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr id_getNumber;
			public int Number {
				[Register ("getNumber", "()I", "GetGetNumberHandler")]
				get {
					if (id_getNumber == IntPtr.Zero)
						id_getNumber = JNIEnv.GetMethodID (class_ref, "getNumber", "()I");
					return JNIEnv.CallIntMethod  (Handle, id_getNumber);
				}
			}

			static IntPtr id_internalInitRepeated_Lcom_google_protobuf_MessageLite_Lcom_google_protobuf_MessageLite_Lcom_google_protobuf_Internal_EnumLiteMap_ILcom_google_protobuf_WireFormat_FieldType_Z;
			[Register ("internalInitRepeated", "(Lcom/google/protobuf/MessageLite;Lcom/google/protobuf/MessageLite;Lcom/google/protobuf/Internal$EnumLiteMap;ILcom/google/protobuf/WireFormat$FieldType;Z)V", "")]
			public void InternalInitRepeated (global::Java.Lang.Object p0, global::Com.Google.Protobuf.IMessageLite p1, global::Com.Google.Protobuf.Internal.IEnumLiteMap p2, int p3, global::Com.Google.Protobuf.WireFormat.FieldType p4, bool p5)
			{
				if (id_internalInitRepeated_Lcom_google_protobuf_MessageLite_Lcom_google_protobuf_MessageLite_Lcom_google_protobuf_Internal_EnumLiteMap_ILcom_google_protobuf_WireFormat_FieldType_Z == IntPtr.Zero)
					id_internalInitRepeated_Lcom_google_protobuf_MessageLite_Lcom_google_protobuf_MessageLite_Lcom_google_protobuf_Internal_EnumLiteMap_ILcom_google_protobuf_WireFormat_FieldType_Z = JNIEnv.GetMethodID (class_ref, "internalInitRepeated", "(Lcom/google/protobuf/MessageLite;Lcom/google/protobuf/MessageLite;Lcom/google/protobuf/Internal$EnumLiteMap;ILcom/google/protobuf/WireFormat$FieldType;Z)V");
				IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
				JNIEnv.CallVoidMethod  (Handle, id_internalInitRepeated_Lcom_google_protobuf_MessageLite_Lcom_google_protobuf_MessageLite_Lcom_google_protobuf_Internal_EnumLiteMap_ILcom_google_protobuf_WireFormat_FieldType_Z, new JValue (native_p0), new JValue (p1), new JValue (p2), new JValue (p3), new JValue (p4), new JValue (p5));
				JNIEnv.DeleteLocalRef (native_p0);
			}

			static IntPtr id_internalInitSingular_Lcom_google_protobuf_MessageLite_Ljava_lang_Object_Lcom_google_protobuf_MessageLite_Lcom_google_protobuf_Internal_EnumLiteMap_ILcom_google_protobuf_WireFormat_FieldType_;
			[Register ("internalInitSingular", "(Lcom/google/protobuf/MessageLite;Ljava/lang/Object;Lcom/google/protobuf/MessageLite;Lcom/google/protobuf/Internal$EnumLiteMap;ILcom/google/protobuf/WireFormat$FieldType;)V", "")]
			public void InternalInitSingular (global::Java.Lang.Object p0, global::Java.Lang.Object p1, global::Com.Google.Protobuf.IMessageLite p2, global::Com.Google.Protobuf.Internal.IEnumLiteMap p3, int p4, global::Com.Google.Protobuf.WireFormat.FieldType p5)
			{
				if (id_internalInitSingular_Lcom_google_protobuf_MessageLite_Ljava_lang_Object_Lcom_google_protobuf_MessageLite_Lcom_google_protobuf_Internal_EnumLiteMap_ILcom_google_protobuf_WireFormat_FieldType_ == IntPtr.Zero)
					id_internalInitSingular_Lcom_google_protobuf_MessageLite_Ljava_lang_Object_Lcom_google_protobuf_MessageLite_Lcom_google_protobuf_Internal_EnumLiteMap_ILcom_google_protobuf_WireFormat_FieldType_ = JNIEnv.GetMethodID (class_ref, "internalInitSingular", "(Lcom/google/protobuf/MessageLite;Ljava/lang/Object;Lcom/google/protobuf/MessageLite;Lcom/google/protobuf/Internal$EnumLiteMap;ILcom/google/protobuf/WireFormat$FieldType;)V");
				IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
				IntPtr native_p1 = JNIEnv.ToLocalJniHandle (p1);
				JNIEnv.CallVoidMethod  (Handle, id_internalInitSingular_Lcom_google_protobuf_MessageLite_Ljava_lang_Object_Lcom_google_protobuf_MessageLite_Lcom_google_protobuf_Internal_EnumLiteMap_ILcom_google_protobuf_WireFormat_FieldType_, new JValue (native_p0), new JValue (native_p1), new JValue (p2), new JValue (p3), new JValue (p4), new JValue (p5));
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/protobuf/GeneratedMessageLite", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (GeneratedMessageLite); }
		}

		protected GeneratedMessageLite (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		[Register (".ctor", "()V", "")]
		protected GeneratedMessageLite () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (GeneratedMessageLite)) {
				SetHandle (global::Android.Runtime.JNIEnv.CreateInstance (GetType (), "()V"), JniHandleOwnership.TransferLocalRef);
				return;
			}

			if (id_ctor == IntPtr.Zero)
				id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
			SetHandle (JNIEnv.NewObject (class_ref, id_ctor), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_newGeneratedExtension;
		[Register ("newGeneratedExtension", "()Lcom/google/protobuf/GeneratedMessageLite$GeneratedExtension;", "")]
		public static global::Com.Google.Protobuf.GeneratedMessageLite.GeneratedExtension NewGeneratedExtension ()
		{
			if (id_newGeneratedExtension == IntPtr.Zero)
				id_newGeneratedExtension = JNIEnv.GetStaticMethodID (class_ref, "newGeneratedExtension", "()Lcom/google/protobuf/GeneratedMessageLite$GeneratedExtension;");
			return Java.Lang.Object.GetObject<global::Com.Google.Protobuf.GeneratedMessageLite.GeneratedExtension> (JNIEnv.CallStaticObjectMethod  (class_ref, id_newGeneratedExtension), JniHandleOwnership.TransferLocalRef);
		}

	}

	[global::Android.Runtime.Register ("com/google/protobuf/GeneratedMessageLite", DoNotGenerateAcw=true)]
	internal partial class GeneratedMessageLiteInvoker : GeneratedMessageLite {

		public GeneratedMessageLiteInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (GeneratedMessageLiteInvoker); }
		}

		static IntPtr id_getDefaultInstanceForType;
		public override global::Com.Google.Protobuf.IMessageLite DefaultInstanceForType {
			[Register ("getDefaultInstanceForType", "()Lcom/google/protobuf/MessageLite;", "GetGetDefaultInstanceForTypeHandler")]
			get {
				if (id_getDefaultInstanceForType == IntPtr.Zero)
					id_getDefaultInstanceForType = JNIEnv.GetMethodID (class_ref, "getDefaultInstanceForType", "()Lcom/google/protobuf/MessageLite;");
				return Java.Lang.Object.GetObject<global::Com.Google.Protobuf.IMessageLite> (JNIEnv.CallObjectMethod  (Handle, id_getDefaultInstanceForType), JniHandleOwnership.TransferLocalRef);
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

		static IntPtr id_newBuilderForType;
		[Register ("newBuilderForType", "()Lcom/google/protobuf/MessageLite$Builder;", "GetNewBuilderForTypeHandler")]
		public override global::Com.Google.Protobuf.IMessageLiteBuilder NewBuilderForType ()
		{
			if (id_newBuilderForType == IntPtr.Zero)
				id_newBuilderForType = JNIEnv.GetMethodID (class_ref, "newBuilderForType", "()Lcom/google/protobuf/MessageLite$Builder;");
			return Java.Lang.Object.GetObject<global::Com.Google.Protobuf.IMessageLiteBuilder> (JNIEnv.CallObjectMethod  (Handle, id_newBuilderForType), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_toBuilder;
		[Register ("toBuilder", "()Lcom/google/protobuf/MessageLite$Builder;", "GetToBuilderHandler")]
		public override global::Com.Google.Protobuf.IMessageLiteBuilder ToBuilder ()
		{
			if (id_toBuilder == IntPtr.Zero)
				id_toBuilder = JNIEnv.GetMethodID (class_ref, "toBuilder", "()Lcom/google/protobuf/MessageLite$Builder;");
			return Java.Lang.Object.GetObject<global::Com.Google.Protobuf.IMessageLiteBuilder> (JNIEnv.CallObjectMethod  (Handle, id_toBuilder), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_writeTo_Lcom_google_protobuf_CodedOutputStream_;
		[Register ("writeTo", "(Lcom/google/protobuf/CodedOutputStream;)V", "GetWriteTo_Lcom_google_protobuf_CodedOutputStream_Handler")]
		public override void WriteTo (global::Com.Google.Protobuf.CodedOutputStream p0)
		{
			if (id_writeTo_Lcom_google_protobuf_CodedOutputStream_ == IntPtr.Zero)
				id_writeTo_Lcom_google_protobuf_CodedOutputStream_ = JNIEnv.GetMethodID (class_ref, "writeTo", "(Lcom/google/protobuf/CodedOutputStream;)V");
			JNIEnv.CallVoidMethod  (Handle, id_writeTo_Lcom_google_protobuf_CodedOutputStream_, new JValue (p0));
		}

	}

}
