using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Protobuf {

	[Register ("com/google/protobuf/MessageLite$Builder", "", "Com.Google.Protobuf.IMessageLiteBuilderInvoker")]
	public partial interface IMessageLiteBuilder : global::Java.Lang.ICloneable {

		global::Com.Google.Protobuf.IMessageLite DefaultInstanceForType {
			[Register ("getDefaultInstanceForType", "()Lcom/google/protobuf/MessageLite;", "GetGetDefaultInstanceForTypeHandler:Com.Google.Protobuf.IMessageLiteBuilderInvoker, AndroidSDK.Binding")] get;
		}

		bool IsInitialized {
			[Register ("isInitialized", "()Z", "GetIsInitializedHandler:Com.Google.Protobuf.IMessageLiteBuilderInvoker, AndroidSDK.Binding")] get;
		}

		[Register ("build", "()Lcom/google/protobuf/MessageLite;", "GetBuildHandler:Com.Google.Protobuf.IMessageLiteBuilderInvoker, AndroidSDK.Binding")]
		global::Com.Google.Protobuf.IMessageLite Build ();

		[Register ("buildPartial", "()Lcom/google/protobuf/MessageLite;", "GetBuildPartialHandler:Com.Google.Protobuf.IMessageLiteBuilderInvoker, AndroidSDK.Binding")]
		global::Com.Google.Protobuf.IMessageLite BuildPartial ();

		[Register ("clear", "()Lcom/google/protobuf/MessageLite$Builder;", "GetClearHandler:Com.Google.Protobuf.IMessageLiteBuilderInvoker, AndroidSDK.Binding")]
		global::Com.Google.Protobuf.IMessageLiteBuilder Clear ();

		[Register ("clone", "()Lcom/google/protobuf/MessageLite$Builder;", "GetCloneHandler:Com.Google.Protobuf.IMessageLiteBuilderInvoker, AndroidSDK.Binding")]
		global::Com.Google.Protobuf.IMessageLiteBuilder Clone ();

		[Register ("mergeDelimitedFrom", "(Ljava/io/InputStream;)Z", "GetMergeDelimitedFrom_Ljava_io_InputStream_Handler:Com.Google.Protobuf.IMessageLiteBuilderInvoker, AndroidSDK.Binding")]
		bool MergeDelimitedFrom (global::System.IO.Stream p0);

		[Register ("mergeDelimitedFrom", "(Ljava/io/InputStream;Lcom/google/protobuf/ExtensionRegistryLite;)Z", "GetMergeDelimitedFrom_Ljava_io_InputStream_Lcom_google_protobuf_ExtensionRegistryLite_Handler:Com.Google.Protobuf.IMessageLiteBuilderInvoker, AndroidSDK.Binding")]
		bool MergeDelimitedFrom (global::System.IO.Stream p0, global::Com.Google.Protobuf.ExtensionRegistryLite p1);

		[Register ("mergeFrom", "([B)Lcom/google/protobuf/MessageLite$Builder;", "GetMergeFrom_arrayBHandler:Com.Google.Protobuf.IMessageLiteBuilderInvoker, AndroidSDK.Binding")]
		global::Com.Google.Protobuf.IMessageLiteBuilder MergeFrom (byte[] p0);

		[Register ("mergeFrom", "([BLcom/google/protobuf/ExtensionRegistryLite;)Lcom/google/protobuf/MessageLite$Builder;", "GetMergeFrom_arrayBLcom_google_protobuf_ExtensionRegistryLite_Handler:Com.Google.Protobuf.IMessageLiteBuilderInvoker, AndroidSDK.Binding")]
		global::Com.Google.Protobuf.IMessageLiteBuilder MergeFrom (byte[] p0, global::Com.Google.Protobuf.ExtensionRegistryLite p1);

		[Register ("mergeFrom", "([BII)Lcom/google/protobuf/MessageLite$Builder;", "GetMergeFrom_arrayBIIHandler:Com.Google.Protobuf.IMessageLiteBuilderInvoker, AndroidSDK.Binding")]
		global::Com.Google.Protobuf.IMessageLiteBuilder MergeFrom (byte[] p0, int p1, int p2);

		[Register ("mergeFrom", "([BIILcom/google/protobuf/ExtensionRegistryLite;)Lcom/google/protobuf/MessageLite$Builder;", "GetMergeFrom_arrayBIILcom_google_protobuf_ExtensionRegistryLite_Handler:Com.Google.Protobuf.IMessageLiteBuilderInvoker, AndroidSDK.Binding")]
		global::Com.Google.Protobuf.IMessageLiteBuilder MergeFrom (byte[] p0, int p1, int p2, global::Com.Google.Protobuf.ExtensionRegistryLite p3);

		[Register ("mergeFrom", "(Lcom/google/protobuf/ByteString;)Lcom/google/protobuf/MessageLite$Builder;", "GetMergeFrom_Lcom_google_protobuf_ByteString_Handler:Com.Google.Protobuf.IMessageLiteBuilderInvoker, AndroidSDK.Binding")]
		global::Com.Google.Protobuf.IMessageLiteBuilder MergeFrom (global::Com.Google.Protobuf.ByteString p0);

		[Register ("mergeFrom", "(Lcom/google/protobuf/ByteString;Lcom/google/protobuf/ExtensionRegistryLite;)Lcom/google/protobuf/MessageLite$Builder;", "GetMergeFrom_Lcom_google_protobuf_ByteString_Lcom_google_protobuf_ExtensionRegistryLite_Handler:Com.Google.Protobuf.IMessageLiteBuilderInvoker, AndroidSDK.Binding")]
		global::Com.Google.Protobuf.IMessageLiteBuilder MergeFrom (global::Com.Google.Protobuf.ByteString p0, global::Com.Google.Protobuf.ExtensionRegistryLite p1);

		[Register ("mergeFrom", "(Lcom/google/protobuf/CodedInputStream;)Lcom/google/protobuf/MessageLite$Builder;", "GetMergeFrom_Lcom_google_protobuf_CodedInputStream_Handler:Com.Google.Protobuf.IMessageLiteBuilderInvoker, AndroidSDK.Binding")]
		global::Com.Google.Protobuf.IMessageLiteBuilder MergeFrom (global::Com.Google.Protobuf.CodedInputStream p0);

		[Register ("mergeFrom", "(Lcom/google/protobuf/CodedInputStream;Lcom/google/protobuf/ExtensionRegistryLite;)Lcom/google/protobuf/MessageLite$Builder;", "GetMergeFrom_Lcom_google_protobuf_CodedInputStream_Lcom_google_protobuf_ExtensionRegistryLite_Handler:Com.Google.Protobuf.IMessageLiteBuilderInvoker, AndroidSDK.Binding")]
		global::Com.Google.Protobuf.IMessageLiteBuilder MergeFrom (global::Com.Google.Protobuf.CodedInputStream p0, global::Com.Google.Protobuf.ExtensionRegistryLite p1);

		[Register ("mergeFrom", "(Ljava/io/InputStream;)Lcom/google/protobuf/MessageLite$Builder;", "GetMergeFrom_Ljava_io_InputStream_Handler:Com.Google.Protobuf.IMessageLiteBuilderInvoker, AndroidSDK.Binding")]
		global::Com.Google.Protobuf.IMessageLiteBuilder MergeFrom (global::System.IO.Stream p0);

		[Register ("mergeFrom", "(Ljava/io/InputStream;Lcom/google/protobuf/ExtensionRegistryLite;)Lcom/google/protobuf/MessageLite$Builder;", "GetMergeFrom_Ljava_io_InputStream_Lcom_google_protobuf_ExtensionRegistryLite_Handler:Com.Google.Protobuf.IMessageLiteBuilderInvoker, AndroidSDK.Binding")]
		global::Com.Google.Protobuf.IMessageLiteBuilder MergeFrom (global::System.IO.Stream p0, global::Com.Google.Protobuf.ExtensionRegistryLite p1);

	}

	[global::Android.Runtime.Register ("com/google/protobuf/MessageLite$Builder", DoNotGenerateAcw=true)]
	internal class IMessageLiteBuilderInvoker : Java.Lang.Object, IMessageLiteBuilder {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/google/protobuf/MessageLite$Builder");
		IntPtr class_ref;

		public static IMessageLiteBuilder GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IMessageLiteBuilder> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.google.protobuf.MessageLite.Builder"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IMessageLiteBuilderInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (IMessageLiteBuilderInvoker); }
		}

		static Delegate cb_getDefaultInstanceForType;
#pragma warning disable 0169
		static Delegate GetGetDefaultInstanceForTypeHandler ()
		{
			if (cb_getDefaultInstanceForType == null)
				cb_getDefaultInstanceForType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDefaultInstanceForType);
			return cb_getDefaultInstanceForType;
		}

		static IntPtr n_GetDefaultInstanceForType (IntPtr jnienv, IntPtr native__this)
		{
			IMessageLiteBuilder __this = Java.Lang.Object.GetObject<IMessageLiteBuilder> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.DefaultInstanceForType);
		}
#pragma warning restore 0169

		IntPtr id_getDefaultInstanceForType;
		public global::Com.Google.Protobuf.IMessageLite DefaultInstanceForType {
			get {
				if (id_getDefaultInstanceForType == IntPtr.Zero)
					id_getDefaultInstanceForType = JNIEnv.GetMethodID (class_ref, "getDefaultInstanceForType", "()Lcom/google/protobuf/MessageLite;");
				return Java.Lang.Object.GetObject<global::Com.Google.Protobuf.IMessageLite> (JNIEnv.CallObjectMethod (Handle, id_getDefaultInstanceForType), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_isInitialized;
#pragma warning disable 0169
		static Delegate GetIsInitializedHandler ()
		{
			if (cb_isInitialized == null)
				cb_isInitialized = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsInitialized);
			return cb_isInitialized;
		}

		static bool n_IsInitialized (IntPtr jnienv, IntPtr native__this)
		{
			IMessageLiteBuilder __this = Java.Lang.Object.GetObject<IMessageLiteBuilder> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsInitialized;
		}
#pragma warning restore 0169

		IntPtr id_isInitialized;
		public bool IsInitialized {
			get {
				if (id_isInitialized == IntPtr.Zero)
					id_isInitialized = JNIEnv.GetMethodID (class_ref, "isInitialized", "()Z");
				return JNIEnv.CallBooleanMethod (Handle, id_isInitialized);
			}
		}

		static Delegate cb_build;
#pragma warning disable 0169
		static Delegate GetBuildHandler ()
		{
			if (cb_build == null)
				cb_build = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Build);
			return cb_build;
		}

		static IntPtr n_Build (IntPtr jnienv, IntPtr native__this)
		{
			IMessageLiteBuilder __this = Java.Lang.Object.GetObject<IMessageLiteBuilder> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Build ());
		}
#pragma warning restore 0169

		IntPtr id_build;
		public global::Com.Google.Protobuf.IMessageLite Build ()
		{
			if (id_build == IntPtr.Zero)
				id_build = JNIEnv.GetMethodID (class_ref, "build", "()Lcom/google/protobuf/MessageLite;");
			return Java.Lang.Object.GetObject<global::Com.Google.Protobuf.IMessageLite> (JNIEnv.CallObjectMethod (Handle, id_build), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_buildPartial;
#pragma warning disable 0169
		static Delegate GetBuildPartialHandler ()
		{
			if (cb_buildPartial == null)
				cb_buildPartial = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_BuildPartial);
			return cb_buildPartial;
		}

		static IntPtr n_BuildPartial (IntPtr jnienv, IntPtr native__this)
		{
			IMessageLiteBuilder __this = Java.Lang.Object.GetObject<IMessageLiteBuilder> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.BuildPartial ());
		}
#pragma warning restore 0169

		IntPtr id_buildPartial;
		public global::Com.Google.Protobuf.IMessageLite BuildPartial ()
		{
			if (id_buildPartial == IntPtr.Zero)
				id_buildPartial = JNIEnv.GetMethodID (class_ref, "buildPartial", "()Lcom/google/protobuf/MessageLite;");
			return Java.Lang.Object.GetObject<global::Com.Google.Protobuf.IMessageLite> (JNIEnv.CallObjectMethod (Handle, id_buildPartial), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_clear;
#pragma warning disable 0169
		static Delegate GetClearHandler ()
		{
			if (cb_clear == null)
				cb_clear = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Clear);
			return cb_clear;
		}

		static IntPtr n_Clear (IntPtr jnienv, IntPtr native__this)
		{
			IMessageLiteBuilder __this = Java.Lang.Object.GetObject<IMessageLiteBuilder> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Clear ());
		}
#pragma warning restore 0169

		IntPtr id_clear;
		public global::Com.Google.Protobuf.IMessageLiteBuilder Clear ()
		{
			if (id_clear == IntPtr.Zero)
				id_clear = JNIEnv.GetMethodID (class_ref, "clear", "()Lcom/google/protobuf/MessageLite$Builder;");
			return Java.Lang.Object.GetObject<global::Com.Google.Protobuf.IMessageLiteBuilder> (JNIEnv.CallObjectMethod (Handle, id_clear), JniHandleOwnership.TransferLocalRef);
		}

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
			IMessageLiteBuilder __this = Java.Lang.Object.GetObject<IMessageLiteBuilder> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Clone ());
		}
#pragma warning restore 0169

		IntPtr id_clone;
		public global::Com.Google.Protobuf.IMessageLiteBuilder Clone ()
		{
			if (id_clone == IntPtr.Zero)
				id_clone = JNIEnv.GetMethodID (class_ref, "clone", "()Lcom/google/protobuf/MessageLite$Builder;");
			return Java.Lang.Object.GetObject<global::Com.Google.Protobuf.IMessageLiteBuilder> (JNIEnv.CallObjectMethod (Handle, id_clone), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_mergeDelimitedFrom_Ljava_io_InputStream_;
#pragma warning disable 0169
		static Delegate GetMergeDelimitedFrom_Ljava_io_InputStream_Handler ()
		{
			if (cb_mergeDelimitedFrom_Ljava_io_InputStream_ == null)
				cb_mergeDelimitedFrom_Ljava_io_InputStream_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_MergeDelimitedFrom_Ljava_io_InputStream_);
			return cb_mergeDelimitedFrom_Ljava_io_InputStream_;
		}

		static bool n_MergeDelimitedFrom_Ljava_io_InputStream_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			IMessageLiteBuilder __this = Java.Lang.Object.GetObject<IMessageLiteBuilder> (native__this, JniHandleOwnership.DoNotTransfer);
			System.IO.Stream p0 = global::Android.Runtime.InputStreamInvoker.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.MergeDelimitedFrom (p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_mergeDelimitedFrom_Ljava_io_InputStream_;
		public bool MergeDelimitedFrom (global::System.IO.Stream p0)
		{
			if (id_mergeDelimitedFrom_Ljava_io_InputStream_ == IntPtr.Zero)
				id_mergeDelimitedFrom_Ljava_io_InputStream_ = JNIEnv.GetMethodID (class_ref, "mergeDelimitedFrom", "(Ljava/io/InputStream;)Z");
			IntPtr native_p0 = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (p0);
			bool __ret = JNIEnv.CallBooleanMethod (Handle, id_mergeDelimitedFrom_Ljava_io_InputStream_, new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_mergeDelimitedFrom_Ljava_io_InputStream_Lcom_google_protobuf_ExtensionRegistryLite_;
#pragma warning disable 0169
		static Delegate GetMergeDelimitedFrom_Ljava_io_InputStream_Lcom_google_protobuf_ExtensionRegistryLite_Handler ()
		{
			if (cb_mergeDelimitedFrom_Ljava_io_InputStream_Lcom_google_protobuf_ExtensionRegistryLite_ == null)
				cb_mergeDelimitedFrom_Ljava_io_InputStream_Lcom_google_protobuf_ExtensionRegistryLite_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_MergeDelimitedFrom_Ljava_io_InputStream_Lcom_google_protobuf_ExtensionRegistryLite_);
			return cb_mergeDelimitedFrom_Ljava_io_InputStream_Lcom_google_protobuf_ExtensionRegistryLite_;
		}

		static bool n_MergeDelimitedFrom_Ljava_io_InputStream_Lcom_google_protobuf_ExtensionRegistryLite_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			IMessageLiteBuilder __this = Java.Lang.Object.GetObject<IMessageLiteBuilder> (native__this, JniHandleOwnership.DoNotTransfer);
			System.IO.Stream p0 = global::Android.Runtime.InputStreamInvoker.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Google.Protobuf.ExtensionRegistryLite p1 = Java.Lang.Object.GetObject<global::Com.Google.Protobuf.ExtensionRegistryLite> (native_p1, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.MergeDelimitedFrom (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_mergeDelimitedFrom_Ljava_io_InputStream_Lcom_google_protobuf_ExtensionRegistryLite_;
		public bool MergeDelimitedFrom (global::System.IO.Stream p0, global::Com.Google.Protobuf.ExtensionRegistryLite p1)
		{
			if (id_mergeDelimitedFrom_Ljava_io_InputStream_Lcom_google_protobuf_ExtensionRegistryLite_ == IntPtr.Zero)
				id_mergeDelimitedFrom_Ljava_io_InputStream_Lcom_google_protobuf_ExtensionRegistryLite_ = JNIEnv.GetMethodID (class_ref, "mergeDelimitedFrom", "(Ljava/io/InputStream;Lcom/google/protobuf/ExtensionRegistryLite;)Z");
			IntPtr native_p0 = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (p0);
			bool __ret = JNIEnv.CallBooleanMethod (Handle, id_mergeDelimitedFrom_Ljava_io_InputStream_Lcom_google_protobuf_ExtensionRegistryLite_, new JValue (native_p0), new JValue (p1));
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_mergeFrom_arrayB;
#pragma warning disable 0169
		static Delegate GetMergeFrom_arrayBHandler ()
		{
			if (cb_mergeFrom_arrayB == null)
				cb_mergeFrom_arrayB = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_MergeFrom_arrayB);
			return cb_mergeFrom_arrayB;
		}

		static IntPtr n_MergeFrom_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			IMessageLiteBuilder __this = Java.Lang.Object.GetObject<IMessageLiteBuilder> (native__this, JniHandleOwnership.DoNotTransfer);
			byte[] p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.MergeFrom (p0));
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_mergeFrom_arrayB;
		public global::Com.Google.Protobuf.IMessageLiteBuilder MergeFrom (byte[] p0)
		{
			if (id_mergeFrom_arrayB == IntPtr.Zero)
				id_mergeFrom_arrayB = JNIEnv.GetMethodID (class_ref, "mergeFrom", "([B)Lcom/google/protobuf/MessageLite$Builder;");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			global::Com.Google.Protobuf.IMessageLiteBuilder __ret = Java.Lang.Object.GetObject<global::Com.Google.Protobuf.IMessageLiteBuilder> (JNIEnv.CallObjectMethod (Handle, id_mergeFrom_arrayB, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			return __ret;
		}

		static Delegate cb_mergeFrom_arrayBLcom_google_protobuf_ExtensionRegistryLite_;
#pragma warning disable 0169
		static Delegate GetMergeFrom_arrayBLcom_google_protobuf_ExtensionRegistryLite_Handler ()
		{
			if (cb_mergeFrom_arrayBLcom_google_protobuf_ExtensionRegistryLite_ == null)
				cb_mergeFrom_arrayBLcom_google_protobuf_ExtensionRegistryLite_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_MergeFrom_arrayBLcom_google_protobuf_ExtensionRegistryLite_);
			return cb_mergeFrom_arrayBLcom_google_protobuf_ExtensionRegistryLite_;
		}

		static IntPtr n_MergeFrom_arrayBLcom_google_protobuf_ExtensionRegistryLite_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			IMessageLiteBuilder __this = Java.Lang.Object.GetObject<IMessageLiteBuilder> (native__this, JniHandleOwnership.DoNotTransfer);
			byte[] p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			global::Com.Google.Protobuf.ExtensionRegistryLite p1 = Java.Lang.Object.GetObject<global::Com.Google.Protobuf.ExtensionRegistryLite> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.MergeFrom (p0, p1));
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_mergeFrom_arrayBLcom_google_protobuf_ExtensionRegistryLite_;
		public global::Com.Google.Protobuf.IMessageLiteBuilder MergeFrom (byte[] p0, global::Com.Google.Protobuf.ExtensionRegistryLite p1)
		{
			if (id_mergeFrom_arrayBLcom_google_protobuf_ExtensionRegistryLite_ == IntPtr.Zero)
				id_mergeFrom_arrayBLcom_google_protobuf_ExtensionRegistryLite_ = JNIEnv.GetMethodID (class_ref, "mergeFrom", "([BLcom/google/protobuf/ExtensionRegistryLite;)Lcom/google/protobuf/MessageLite$Builder;");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			global::Com.Google.Protobuf.IMessageLiteBuilder __ret = Java.Lang.Object.GetObject<global::Com.Google.Protobuf.IMessageLiteBuilder> (JNIEnv.CallObjectMethod (Handle, id_mergeFrom_arrayBLcom_google_protobuf_ExtensionRegistryLite_, new JValue (native_p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			return __ret;
		}

		static Delegate cb_mergeFrom_arrayBII;
#pragma warning disable 0169
		static Delegate GetMergeFrom_arrayBIIHandler ()
		{
			if (cb_mergeFrom_arrayBII == null)
				cb_mergeFrom_arrayBII = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, int, IntPtr>) n_MergeFrom_arrayBII);
			return cb_mergeFrom_arrayBII;
		}

		static IntPtr n_MergeFrom_arrayBII (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, int p2)
		{
			IMessageLiteBuilder __this = Java.Lang.Object.GetObject<IMessageLiteBuilder> (native__this, JniHandleOwnership.DoNotTransfer);
			byte[] p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.MergeFrom (p0, p1, p2));
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_mergeFrom_arrayBII;
		public global::Com.Google.Protobuf.IMessageLiteBuilder MergeFrom (byte[] p0, int p1, int p2)
		{
			if (id_mergeFrom_arrayBII == IntPtr.Zero)
				id_mergeFrom_arrayBII = JNIEnv.GetMethodID (class_ref, "mergeFrom", "([BII)Lcom/google/protobuf/MessageLite$Builder;");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			global::Com.Google.Protobuf.IMessageLiteBuilder __ret = Java.Lang.Object.GetObject<global::Com.Google.Protobuf.IMessageLiteBuilder> (JNIEnv.CallObjectMethod (Handle, id_mergeFrom_arrayBII, new JValue (native_p0), new JValue (p1), new JValue (p2)), JniHandleOwnership.TransferLocalRef);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			return __ret;
		}

		static Delegate cb_mergeFrom_arrayBIILcom_google_protobuf_ExtensionRegistryLite_;
#pragma warning disable 0169
		static Delegate GetMergeFrom_arrayBIILcom_google_protobuf_ExtensionRegistryLite_Handler ()
		{
			if (cb_mergeFrom_arrayBIILcom_google_protobuf_ExtensionRegistryLite_ == null)
				cb_mergeFrom_arrayBIILcom_google_protobuf_ExtensionRegistryLite_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, int, IntPtr, IntPtr>) n_MergeFrom_arrayBIILcom_google_protobuf_ExtensionRegistryLite_);
			return cb_mergeFrom_arrayBIILcom_google_protobuf_ExtensionRegistryLite_;
		}

		static IntPtr n_MergeFrom_arrayBIILcom_google_protobuf_ExtensionRegistryLite_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, int p2, IntPtr native_p3)
		{
			IMessageLiteBuilder __this = Java.Lang.Object.GetObject<IMessageLiteBuilder> (native__this, JniHandleOwnership.DoNotTransfer);
			byte[] p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			global::Com.Google.Protobuf.ExtensionRegistryLite p3 = Java.Lang.Object.GetObject<global::Com.Google.Protobuf.ExtensionRegistryLite> (native_p3, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.MergeFrom (p0, p1, p2, p3));
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_mergeFrom_arrayBIILcom_google_protobuf_ExtensionRegistryLite_;
		public global::Com.Google.Protobuf.IMessageLiteBuilder MergeFrom (byte[] p0, int p1, int p2, global::Com.Google.Protobuf.ExtensionRegistryLite p3)
		{
			if (id_mergeFrom_arrayBIILcom_google_protobuf_ExtensionRegistryLite_ == IntPtr.Zero)
				id_mergeFrom_arrayBIILcom_google_protobuf_ExtensionRegistryLite_ = JNIEnv.GetMethodID (class_ref, "mergeFrom", "([BIILcom/google/protobuf/ExtensionRegistryLite;)Lcom/google/protobuf/MessageLite$Builder;");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			global::Com.Google.Protobuf.IMessageLiteBuilder __ret = Java.Lang.Object.GetObject<global::Com.Google.Protobuf.IMessageLiteBuilder> (JNIEnv.CallObjectMethod (Handle, id_mergeFrom_arrayBIILcom_google_protobuf_ExtensionRegistryLite_, new JValue (native_p0), new JValue (p1), new JValue (p2), new JValue (p3)), JniHandleOwnership.TransferLocalRef);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			return __ret;
		}

		static Delegate cb_mergeFrom_Lcom_google_protobuf_ByteString_;
#pragma warning disable 0169
		static Delegate GetMergeFrom_Lcom_google_protobuf_ByteString_Handler ()
		{
			if (cb_mergeFrom_Lcom_google_protobuf_ByteString_ == null)
				cb_mergeFrom_Lcom_google_protobuf_ByteString_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_MergeFrom_Lcom_google_protobuf_ByteString_);
			return cb_mergeFrom_Lcom_google_protobuf_ByteString_;
		}

		static IntPtr n_MergeFrom_Lcom_google_protobuf_ByteString_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			IMessageLiteBuilder __this = Java.Lang.Object.GetObject<IMessageLiteBuilder> (native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Google.Protobuf.ByteString p0 = Java.Lang.Object.GetObject<global::Com.Google.Protobuf.ByteString> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.MergeFrom (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_mergeFrom_Lcom_google_protobuf_ByteString_;
		public global::Com.Google.Protobuf.IMessageLiteBuilder MergeFrom (global::Com.Google.Protobuf.ByteString p0)
		{
			if (id_mergeFrom_Lcom_google_protobuf_ByteString_ == IntPtr.Zero)
				id_mergeFrom_Lcom_google_protobuf_ByteString_ = JNIEnv.GetMethodID (class_ref, "mergeFrom", "(Lcom/google/protobuf/ByteString;)Lcom/google/protobuf/MessageLite$Builder;");
			global::Com.Google.Protobuf.IMessageLiteBuilder __ret = Java.Lang.Object.GetObject<global::Com.Google.Protobuf.IMessageLiteBuilder> (JNIEnv.CallObjectMethod (Handle, id_mergeFrom_Lcom_google_protobuf_ByteString_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_mergeFrom_Lcom_google_protobuf_ByteString_Lcom_google_protobuf_ExtensionRegistryLite_;
#pragma warning disable 0169
		static Delegate GetMergeFrom_Lcom_google_protobuf_ByteString_Lcom_google_protobuf_ExtensionRegistryLite_Handler ()
		{
			if (cb_mergeFrom_Lcom_google_protobuf_ByteString_Lcom_google_protobuf_ExtensionRegistryLite_ == null)
				cb_mergeFrom_Lcom_google_protobuf_ByteString_Lcom_google_protobuf_ExtensionRegistryLite_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_MergeFrom_Lcom_google_protobuf_ByteString_Lcom_google_protobuf_ExtensionRegistryLite_);
			return cb_mergeFrom_Lcom_google_protobuf_ByteString_Lcom_google_protobuf_ExtensionRegistryLite_;
		}

		static IntPtr n_MergeFrom_Lcom_google_protobuf_ByteString_Lcom_google_protobuf_ExtensionRegistryLite_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			IMessageLiteBuilder __this = Java.Lang.Object.GetObject<IMessageLiteBuilder> (native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Google.Protobuf.ByteString p0 = Java.Lang.Object.GetObject<global::Com.Google.Protobuf.ByteString> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Google.Protobuf.ExtensionRegistryLite p1 = Java.Lang.Object.GetObject<global::Com.Google.Protobuf.ExtensionRegistryLite> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.MergeFrom (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_mergeFrom_Lcom_google_protobuf_ByteString_Lcom_google_protobuf_ExtensionRegistryLite_;
		public global::Com.Google.Protobuf.IMessageLiteBuilder MergeFrom (global::Com.Google.Protobuf.ByteString p0, global::Com.Google.Protobuf.ExtensionRegistryLite p1)
		{
			if (id_mergeFrom_Lcom_google_protobuf_ByteString_Lcom_google_protobuf_ExtensionRegistryLite_ == IntPtr.Zero)
				id_mergeFrom_Lcom_google_protobuf_ByteString_Lcom_google_protobuf_ExtensionRegistryLite_ = JNIEnv.GetMethodID (class_ref, "mergeFrom", "(Lcom/google/protobuf/ByteString;Lcom/google/protobuf/ExtensionRegistryLite;)Lcom/google/protobuf/MessageLite$Builder;");
			global::Com.Google.Protobuf.IMessageLiteBuilder __ret = Java.Lang.Object.GetObject<global::Com.Google.Protobuf.IMessageLiteBuilder> (JNIEnv.CallObjectMethod (Handle, id_mergeFrom_Lcom_google_protobuf_ByteString_Lcom_google_protobuf_ExtensionRegistryLite_, new JValue (p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_mergeFrom_Lcom_google_protobuf_CodedInputStream_;
#pragma warning disable 0169
		static Delegate GetMergeFrom_Lcom_google_protobuf_CodedInputStream_Handler ()
		{
			if (cb_mergeFrom_Lcom_google_protobuf_CodedInputStream_ == null)
				cb_mergeFrom_Lcom_google_protobuf_CodedInputStream_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_MergeFrom_Lcom_google_protobuf_CodedInputStream_);
			return cb_mergeFrom_Lcom_google_protobuf_CodedInputStream_;
		}

		static IntPtr n_MergeFrom_Lcom_google_protobuf_CodedInputStream_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			IMessageLiteBuilder __this = Java.Lang.Object.GetObject<IMessageLiteBuilder> (native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Google.Protobuf.CodedInputStream p0 = Java.Lang.Object.GetObject<global::Com.Google.Protobuf.CodedInputStream> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.MergeFrom (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_mergeFrom_Lcom_google_protobuf_CodedInputStream_;
		public global::Com.Google.Protobuf.IMessageLiteBuilder MergeFrom (global::Com.Google.Protobuf.CodedInputStream p0)
		{
			if (id_mergeFrom_Lcom_google_protobuf_CodedInputStream_ == IntPtr.Zero)
				id_mergeFrom_Lcom_google_protobuf_CodedInputStream_ = JNIEnv.GetMethodID (class_ref, "mergeFrom", "(Lcom/google/protobuf/CodedInputStream;)Lcom/google/protobuf/MessageLite$Builder;");
			global::Com.Google.Protobuf.IMessageLiteBuilder __ret = Java.Lang.Object.GetObject<global::Com.Google.Protobuf.IMessageLiteBuilder> (JNIEnv.CallObjectMethod (Handle, id_mergeFrom_Lcom_google_protobuf_CodedInputStream_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_mergeFrom_Lcom_google_protobuf_CodedInputStream_Lcom_google_protobuf_ExtensionRegistryLite_;
#pragma warning disable 0169
		static Delegate GetMergeFrom_Lcom_google_protobuf_CodedInputStream_Lcom_google_protobuf_ExtensionRegistryLite_Handler ()
		{
			if (cb_mergeFrom_Lcom_google_protobuf_CodedInputStream_Lcom_google_protobuf_ExtensionRegistryLite_ == null)
				cb_mergeFrom_Lcom_google_protobuf_CodedInputStream_Lcom_google_protobuf_ExtensionRegistryLite_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_MergeFrom_Lcom_google_protobuf_CodedInputStream_Lcom_google_protobuf_ExtensionRegistryLite_);
			return cb_mergeFrom_Lcom_google_protobuf_CodedInputStream_Lcom_google_protobuf_ExtensionRegistryLite_;
		}

		static IntPtr n_MergeFrom_Lcom_google_protobuf_CodedInputStream_Lcom_google_protobuf_ExtensionRegistryLite_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			IMessageLiteBuilder __this = Java.Lang.Object.GetObject<IMessageLiteBuilder> (native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Google.Protobuf.CodedInputStream p0 = Java.Lang.Object.GetObject<global::Com.Google.Protobuf.CodedInputStream> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Google.Protobuf.ExtensionRegistryLite p1 = Java.Lang.Object.GetObject<global::Com.Google.Protobuf.ExtensionRegistryLite> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.MergeFrom (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_mergeFrom_Lcom_google_protobuf_CodedInputStream_Lcom_google_protobuf_ExtensionRegistryLite_;
		public global::Com.Google.Protobuf.IMessageLiteBuilder MergeFrom (global::Com.Google.Protobuf.CodedInputStream p0, global::Com.Google.Protobuf.ExtensionRegistryLite p1)
		{
			if (id_mergeFrom_Lcom_google_protobuf_CodedInputStream_Lcom_google_protobuf_ExtensionRegistryLite_ == IntPtr.Zero)
				id_mergeFrom_Lcom_google_protobuf_CodedInputStream_Lcom_google_protobuf_ExtensionRegistryLite_ = JNIEnv.GetMethodID (class_ref, "mergeFrom", "(Lcom/google/protobuf/CodedInputStream;Lcom/google/protobuf/ExtensionRegistryLite;)Lcom/google/protobuf/MessageLite$Builder;");
			global::Com.Google.Protobuf.IMessageLiteBuilder __ret = Java.Lang.Object.GetObject<global::Com.Google.Protobuf.IMessageLiteBuilder> (JNIEnv.CallObjectMethod (Handle, id_mergeFrom_Lcom_google_protobuf_CodedInputStream_Lcom_google_protobuf_ExtensionRegistryLite_, new JValue (p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_mergeFrom_Ljava_io_InputStream_;
#pragma warning disable 0169
		static Delegate GetMergeFrom_Ljava_io_InputStream_Handler ()
		{
			if (cb_mergeFrom_Ljava_io_InputStream_ == null)
				cb_mergeFrom_Ljava_io_InputStream_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_MergeFrom_Ljava_io_InputStream_);
			return cb_mergeFrom_Ljava_io_InputStream_;
		}

		static IntPtr n_MergeFrom_Ljava_io_InputStream_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			IMessageLiteBuilder __this = Java.Lang.Object.GetObject<IMessageLiteBuilder> (native__this, JniHandleOwnership.DoNotTransfer);
			System.IO.Stream p0 = global::Android.Runtime.InputStreamInvoker.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.MergeFrom (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_mergeFrom_Ljava_io_InputStream_;
		public global::Com.Google.Protobuf.IMessageLiteBuilder MergeFrom (global::System.IO.Stream p0)
		{
			if (id_mergeFrom_Ljava_io_InputStream_ == IntPtr.Zero)
				id_mergeFrom_Ljava_io_InputStream_ = JNIEnv.GetMethodID (class_ref, "mergeFrom", "(Ljava/io/InputStream;)Lcom/google/protobuf/MessageLite$Builder;");
			IntPtr native_p0 = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (p0);
			global::Com.Google.Protobuf.IMessageLiteBuilder __ret = Java.Lang.Object.GetObject<global::Com.Google.Protobuf.IMessageLiteBuilder> (JNIEnv.CallObjectMethod (Handle, id_mergeFrom_Ljava_io_InputStream_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_mergeFrom_Ljava_io_InputStream_Lcom_google_protobuf_ExtensionRegistryLite_;
#pragma warning disable 0169
		static Delegate GetMergeFrom_Ljava_io_InputStream_Lcom_google_protobuf_ExtensionRegistryLite_Handler ()
		{
			if (cb_mergeFrom_Ljava_io_InputStream_Lcom_google_protobuf_ExtensionRegistryLite_ == null)
				cb_mergeFrom_Ljava_io_InputStream_Lcom_google_protobuf_ExtensionRegistryLite_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_MergeFrom_Ljava_io_InputStream_Lcom_google_protobuf_ExtensionRegistryLite_);
			return cb_mergeFrom_Ljava_io_InputStream_Lcom_google_protobuf_ExtensionRegistryLite_;
		}

		static IntPtr n_MergeFrom_Ljava_io_InputStream_Lcom_google_protobuf_ExtensionRegistryLite_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			IMessageLiteBuilder __this = Java.Lang.Object.GetObject<IMessageLiteBuilder> (native__this, JniHandleOwnership.DoNotTransfer);
			System.IO.Stream p0 = global::Android.Runtime.InputStreamInvoker.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Google.Protobuf.ExtensionRegistryLite p1 = Java.Lang.Object.GetObject<global::Com.Google.Protobuf.ExtensionRegistryLite> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.MergeFrom (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_mergeFrom_Ljava_io_InputStream_Lcom_google_protobuf_ExtensionRegistryLite_;
		public global::Com.Google.Protobuf.IMessageLiteBuilder MergeFrom (global::System.IO.Stream p0, global::Com.Google.Protobuf.ExtensionRegistryLite p1)
		{
			if (id_mergeFrom_Ljava_io_InputStream_Lcom_google_protobuf_ExtensionRegistryLite_ == IntPtr.Zero)
				id_mergeFrom_Ljava_io_InputStream_Lcom_google_protobuf_ExtensionRegistryLite_ = JNIEnv.GetMethodID (class_ref, "mergeFrom", "(Ljava/io/InputStream;Lcom/google/protobuf/ExtensionRegistryLite;)Lcom/google/protobuf/MessageLite$Builder;");
			IntPtr native_p0 = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (p0);
			global::Com.Google.Protobuf.IMessageLiteBuilder __ret = Java.Lang.Object.GetObject<global::Com.Google.Protobuf.IMessageLiteBuilder> (JNIEnv.CallObjectMethod (Handle, id_mergeFrom_Ljava_io_InputStream_Lcom_google_protobuf_ExtensionRegistryLite_, new JValue (native_p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

	}


	[Register ("com/google/protobuf/MessageLite", "", "Com.Google.Protobuf.IMessageLiteInvoker")]
	public partial interface IMessageLite : IJavaObject {

		global::Com.Google.Protobuf.IMessageLite DefaultInstanceForType {
			[Register ("getDefaultInstanceForType", "()Lcom/google/protobuf/MessageLite;", "GetGetDefaultInstanceForTypeHandler:Com.Google.Protobuf.IMessageLiteInvoker, AndroidSDK.Binding")] get;
		}

		bool IsInitialized {
			[Register ("isInitialized", "()Z", "GetIsInitializedHandler:Com.Google.Protobuf.IMessageLiteInvoker, AndroidSDK.Binding")] get;
		}

		int SerializedSize {
			[Register ("getSerializedSize", "()I", "GetGetSerializedSizeHandler:Com.Google.Protobuf.IMessageLiteInvoker, AndroidSDK.Binding")] get;
		}

		[Register ("newBuilderForType", "()Lcom/google/protobuf/MessageLite$Builder;", "GetNewBuilderForTypeHandler:Com.Google.Protobuf.IMessageLiteInvoker, AndroidSDK.Binding")]
		global::Com.Google.Protobuf.IMessageLiteBuilder NewBuilderForType ();

		[Register ("toBuilder", "()Lcom/google/protobuf/MessageLite$Builder;", "GetToBuilderHandler:Com.Google.Protobuf.IMessageLiteInvoker, AndroidSDK.Binding")]
		global::Com.Google.Protobuf.IMessageLiteBuilder ToBuilder ();

		[Register ("toByteArray", "()[B", "GetToByteArrayHandler:Com.Google.Protobuf.IMessageLiteInvoker, AndroidSDK.Binding")]
		byte[] ToByteArray ();

		[Register ("toByteString", "()Lcom/google/protobuf/ByteString;", "GetToByteStringHandler:Com.Google.Protobuf.IMessageLiteInvoker, AndroidSDK.Binding")]
		global::Com.Google.Protobuf.ByteString ToByteString ();

		[Register ("writeDelimitedTo", "(Ljava/io/OutputStream;)V", "GetWriteDelimitedTo_Ljava_io_OutputStream_Handler:Com.Google.Protobuf.IMessageLiteInvoker, AndroidSDK.Binding")]
		void WriteDelimitedTo (global::System.IO.Stream p0);

		[Register ("writeTo", "(Lcom/google/protobuf/CodedOutputStream;)V", "GetWriteTo_Lcom_google_protobuf_CodedOutputStream_Handler:Com.Google.Protobuf.IMessageLiteInvoker, AndroidSDK.Binding")]
		void WriteTo (global::Com.Google.Protobuf.CodedOutputStream p0);

		[Register ("writeTo", "(Ljava/io/OutputStream;)V", "GetWriteTo_Ljava_io_OutputStream_Handler:Com.Google.Protobuf.IMessageLiteInvoker, AndroidSDK.Binding")]
		void WriteTo (global::System.IO.Stream p0);

	}

	[global::Android.Runtime.Register ("com/google/protobuf/MessageLite", DoNotGenerateAcw=true)]
	internal class IMessageLiteInvoker : Java.Lang.Object, IMessageLite {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/google/protobuf/MessageLite");
		IntPtr class_ref;

		public static IMessageLite GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IMessageLite> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.google.protobuf.MessageLite"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IMessageLiteInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (IMessageLiteInvoker); }
		}

		static Delegate cb_getDefaultInstanceForType;
#pragma warning disable 0169
		static Delegate GetGetDefaultInstanceForTypeHandler ()
		{
			if (cb_getDefaultInstanceForType == null)
				cb_getDefaultInstanceForType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDefaultInstanceForType);
			return cb_getDefaultInstanceForType;
		}

		static IntPtr n_GetDefaultInstanceForType (IntPtr jnienv, IntPtr native__this)
		{
			IMessageLite __this = Java.Lang.Object.GetObject<IMessageLite> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.DefaultInstanceForType);
		}
#pragma warning restore 0169

		IntPtr id_getDefaultInstanceForType;
		public global::Com.Google.Protobuf.IMessageLite DefaultInstanceForType {
			get {
				if (id_getDefaultInstanceForType == IntPtr.Zero)
					id_getDefaultInstanceForType = JNIEnv.GetMethodID (class_ref, "getDefaultInstanceForType", "()Lcom/google/protobuf/MessageLite;");
				return Java.Lang.Object.GetObject<global::Com.Google.Protobuf.IMessageLite> (JNIEnv.CallObjectMethod (Handle, id_getDefaultInstanceForType), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_isInitialized;
#pragma warning disable 0169
		static Delegate GetIsInitializedHandler ()
		{
			if (cb_isInitialized == null)
				cb_isInitialized = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsInitialized);
			return cb_isInitialized;
		}

		static bool n_IsInitialized (IntPtr jnienv, IntPtr native__this)
		{
			IMessageLite __this = Java.Lang.Object.GetObject<IMessageLite> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsInitialized;
		}
#pragma warning restore 0169

		IntPtr id_isInitialized;
		public bool IsInitialized {
			get {
				if (id_isInitialized == IntPtr.Zero)
					id_isInitialized = JNIEnv.GetMethodID (class_ref, "isInitialized", "()Z");
				return JNIEnv.CallBooleanMethod (Handle, id_isInitialized);
			}
		}

		static Delegate cb_getSerializedSize;
#pragma warning disable 0169
		static Delegate GetGetSerializedSizeHandler ()
		{
			if (cb_getSerializedSize == null)
				cb_getSerializedSize = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetSerializedSize);
			return cb_getSerializedSize;
		}

		static int n_GetSerializedSize (IntPtr jnienv, IntPtr native__this)
		{
			IMessageLite __this = Java.Lang.Object.GetObject<IMessageLite> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SerializedSize;
		}
#pragma warning restore 0169

		IntPtr id_getSerializedSize;
		public int SerializedSize {
			get {
				if (id_getSerializedSize == IntPtr.Zero)
					id_getSerializedSize = JNIEnv.GetMethodID (class_ref, "getSerializedSize", "()I");
				return JNIEnv.CallIntMethod (Handle, id_getSerializedSize);
			}
		}

		static Delegate cb_newBuilderForType;
#pragma warning disable 0169
		static Delegate GetNewBuilderForTypeHandler ()
		{
			if (cb_newBuilderForType == null)
				cb_newBuilderForType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_NewBuilderForType);
			return cb_newBuilderForType;
		}

		static IntPtr n_NewBuilderForType (IntPtr jnienv, IntPtr native__this)
		{
			IMessageLite __this = Java.Lang.Object.GetObject<IMessageLite> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.NewBuilderForType ());
		}
#pragma warning restore 0169

		IntPtr id_newBuilderForType;
		public global::Com.Google.Protobuf.IMessageLiteBuilder NewBuilderForType ()
		{
			if (id_newBuilderForType == IntPtr.Zero)
				id_newBuilderForType = JNIEnv.GetMethodID (class_ref, "newBuilderForType", "()Lcom/google/protobuf/MessageLite$Builder;");
			return Java.Lang.Object.GetObject<global::Com.Google.Protobuf.IMessageLiteBuilder> (JNIEnv.CallObjectMethod (Handle, id_newBuilderForType), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_toBuilder;
#pragma warning disable 0169
		static Delegate GetToBuilderHandler ()
		{
			if (cb_toBuilder == null)
				cb_toBuilder = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_ToBuilder);
			return cb_toBuilder;
		}

		static IntPtr n_ToBuilder (IntPtr jnienv, IntPtr native__this)
		{
			IMessageLite __this = Java.Lang.Object.GetObject<IMessageLite> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ToBuilder ());
		}
#pragma warning restore 0169

		IntPtr id_toBuilder;
		public global::Com.Google.Protobuf.IMessageLiteBuilder ToBuilder ()
		{
			if (id_toBuilder == IntPtr.Zero)
				id_toBuilder = JNIEnv.GetMethodID (class_ref, "toBuilder", "()Lcom/google/protobuf/MessageLite$Builder;");
			return Java.Lang.Object.GetObject<global::Com.Google.Protobuf.IMessageLiteBuilder> (JNIEnv.CallObjectMethod (Handle, id_toBuilder), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_toByteArray;
#pragma warning disable 0169
		static Delegate GetToByteArrayHandler ()
		{
			if (cb_toByteArray == null)
				cb_toByteArray = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_ToByteArray);
			return cb_toByteArray;
		}

		static IntPtr n_ToByteArray (IntPtr jnienv, IntPtr native__this)
		{
			IMessageLite __this = Java.Lang.Object.GetObject<IMessageLite> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.ToByteArray ());
		}
#pragma warning restore 0169

		IntPtr id_toByteArray;
		public byte[] ToByteArray ()
		{
			if (id_toByteArray == IntPtr.Zero)
				id_toByteArray = JNIEnv.GetMethodID (class_ref, "toByteArray", "()[B");
			return (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (Handle, id_toByteArray), JniHandleOwnership.TransferLocalRef, typeof (byte));
		}

		static Delegate cb_toByteString;
#pragma warning disable 0169
		static Delegate GetToByteStringHandler ()
		{
			if (cb_toByteString == null)
				cb_toByteString = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_ToByteString);
			return cb_toByteString;
		}

		static IntPtr n_ToByteString (IntPtr jnienv, IntPtr native__this)
		{
			IMessageLite __this = Java.Lang.Object.GetObject<IMessageLite> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ToByteString ());
		}
#pragma warning restore 0169

		IntPtr id_toByteString;
		public global::Com.Google.Protobuf.ByteString ToByteString ()
		{
			if (id_toByteString == IntPtr.Zero)
				id_toByteString = JNIEnv.GetMethodID (class_ref, "toByteString", "()Lcom/google/protobuf/ByteString;");
			return Java.Lang.Object.GetObject<global::Com.Google.Protobuf.ByteString> (JNIEnv.CallObjectMethod (Handle, id_toByteString), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_writeDelimitedTo_Ljava_io_OutputStream_;
#pragma warning disable 0169
		static Delegate GetWriteDelimitedTo_Ljava_io_OutputStream_Handler ()
		{
			if (cb_writeDelimitedTo_Ljava_io_OutputStream_ == null)
				cb_writeDelimitedTo_Ljava_io_OutputStream_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_WriteDelimitedTo_Ljava_io_OutputStream_);
			return cb_writeDelimitedTo_Ljava_io_OutputStream_;
		}

		static void n_WriteDelimitedTo_Ljava_io_OutputStream_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			IMessageLite __this = Java.Lang.Object.GetObject<IMessageLite> (native__this, JniHandleOwnership.DoNotTransfer);
			System.IO.Stream p0 = global::Android.Runtime.OutputStreamInvoker.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.WriteDelimitedTo (p0);
		}
#pragma warning restore 0169

		IntPtr id_writeDelimitedTo_Ljava_io_OutputStream_;
		public void WriteDelimitedTo (global::System.IO.Stream p0)
		{
			if (id_writeDelimitedTo_Ljava_io_OutputStream_ == IntPtr.Zero)
				id_writeDelimitedTo_Ljava_io_OutputStream_ = JNIEnv.GetMethodID (class_ref, "writeDelimitedTo", "(Ljava/io/OutputStream;)V");
			IntPtr native_p0 = global::Android.Runtime.OutputStreamAdapter.ToLocalJniHandle (p0);
			JNIEnv.CallVoidMethod (Handle, id_writeDelimitedTo_Ljava_io_OutputStream_, new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_writeTo_Lcom_google_protobuf_CodedOutputStream_;
#pragma warning disable 0169
		static Delegate GetWriteTo_Lcom_google_protobuf_CodedOutputStream_Handler ()
		{
			if (cb_writeTo_Lcom_google_protobuf_CodedOutputStream_ == null)
				cb_writeTo_Lcom_google_protobuf_CodedOutputStream_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_WriteTo_Lcom_google_protobuf_CodedOutputStream_);
			return cb_writeTo_Lcom_google_protobuf_CodedOutputStream_;
		}

		static void n_WriteTo_Lcom_google_protobuf_CodedOutputStream_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			IMessageLite __this = Java.Lang.Object.GetObject<IMessageLite> (native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Google.Protobuf.CodedOutputStream p0 = Java.Lang.Object.GetObject<global::Com.Google.Protobuf.CodedOutputStream> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.WriteTo (p0);
		}
#pragma warning restore 0169

		IntPtr id_writeTo_Lcom_google_protobuf_CodedOutputStream_;
		public void WriteTo (global::Com.Google.Protobuf.CodedOutputStream p0)
		{
			if (id_writeTo_Lcom_google_protobuf_CodedOutputStream_ == IntPtr.Zero)
				id_writeTo_Lcom_google_protobuf_CodedOutputStream_ = JNIEnv.GetMethodID (class_ref, "writeTo", "(Lcom/google/protobuf/CodedOutputStream;)V");
			JNIEnv.CallVoidMethod (Handle, id_writeTo_Lcom_google_protobuf_CodedOutputStream_, new JValue (p0));
		}

		static Delegate cb_writeTo_Ljava_io_OutputStream_;
#pragma warning disable 0169
		static Delegate GetWriteTo_Ljava_io_OutputStream_Handler ()
		{
			if (cb_writeTo_Ljava_io_OutputStream_ == null)
				cb_writeTo_Ljava_io_OutputStream_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_WriteTo_Ljava_io_OutputStream_);
			return cb_writeTo_Ljava_io_OutputStream_;
		}

		static void n_WriteTo_Ljava_io_OutputStream_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			IMessageLite __this = Java.Lang.Object.GetObject<IMessageLite> (native__this, JniHandleOwnership.DoNotTransfer);
			System.IO.Stream p0 = global::Android.Runtime.OutputStreamInvoker.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.WriteTo (p0);
		}
#pragma warning restore 0169

		IntPtr id_writeTo_Ljava_io_OutputStream_;
		public void WriteTo (global::System.IO.Stream p0)
		{
			if (id_writeTo_Ljava_io_OutputStream_ == IntPtr.Zero)
				id_writeTo_Ljava_io_OutputStream_ = JNIEnv.GetMethodID (class_ref, "writeTo", "(Ljava/io/OutputStream;)V");
			IntPtr native_p0 = global::Android.Runtime.OutputStreamAdapter.ToLocalJniHandle (p0);
			JNIEnv.CallVoidMethod (Handle, id_writeTo_Ljava_io_OutputStream_, new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
		}

	}

}
