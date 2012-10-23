using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Protobuf {

	[global::Android.Runtime.Register ("com/google/protobuf/AbstractMessageLite", DoNotGenerateAcw=true)]
	public abstract partial class AbstractMessageLite : global::Java.Lang.Object, global::Com.Google.Protobuf.IMessageLite {

		[global::Android.Runtime.Register ("com/google/protobuf/AbstractMessageLite$Builder", DoNotGenerateAcw=true)]
		public abstract partial class Builder : global::Java.Lang.Object, global::Com.Google.Protobuf.IMessageLiteBuilder {

			[global::Android.Runtime.Register ("com/google/protobuf/AbstractMessageLite$Builder$LimitedInputStream", DoNotGenerateAcw=true)]
			public sealed partial class LimitedInputStream : global::Java.IO.FilterInputStream {

				internal LimitedInputStream (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			}

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/google/protobuf/AbstractMessageLite$Builder", ref java_class_handle);
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
			public Builder () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

			[Register ("clone", "()Ljava/lang/Object;", "GetCloneHandler")]
			public abstract global::Java.Lang.Object Clone ();

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
				Builder __this = Java.Lang.Object.GetObject<Builder> (native__this, JniHandleOwnership.DoNotTransfer);
				System.IO.Stream p0 = global::Android.Runtime.InputStreamInvoker.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
				bool __ret = __this.MergeDelimitedFrom (p0);
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_mergeDelimitedFrom_Ljava_io_InputStream_;
			[Register ("mergeDelimitedFrom", "(Ljava/io/InputStream;)Z", "GetMergeDelimitedFrom_Ljava_io_InputStream_Handler")]
			public virtual bool MergeDelimitedFrom (global::System.IO.Stream p0)
			{
				if (id_mergeDelimitedFrom_Ljava_io_InputStream_ == IntPtr.Zero)
					id_mergeDelimitedFrom_Ljava_io_InputStream_ = JNIEnv.GetMethodID (class_ref, "mergeDelimitedFrom", "(Ljava/io/InputStream;)Z");
				IntPtr native_p0 = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (p0);

				bool __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod  (Handle, id_mergeDelimitedFrom_Ljava_io_InputStream_, new JValue (native_p0));
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, id_mergeDelimitedFrom_Ljava_io_InputStream_, new JValue (native_p0));
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
				Builder __this = Java.Lang.Object.GetObject<Builder> (native__this, JniHandleOwnership.DoNotTransfer);
				System.IO.Stream p0 = global::Android.Runtime.InputStreamInvoker.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Com.Google.Protobuf.ExtensionRegistryLite p1 = Java.Lang.Object.GetObject<global::Com.Google.Protobuf.ExtensionRegistryLite> (native_p1, JniHandleOwnership.DoNotTransfer);
				bool __ret = __this.MergeDelimitedFrom (p0, p1);
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_mergeDelimitedFrom_Ljava_io_InputStream_Lcom_google_protobuf_ExtensionRegistryLite_;
			[Register ("mergeDelimitedFrom", "(Ljava/io/InputStream;Lcom/google/protobuf/ExtensionRegistryLite;)Z", "GetMergeDelimitedFrom_Ljava_io_InputStream_Lcom_google_protobuf_ExtensionRegistryLite_Handler")]
			public virtual bool MergeDelimitedFrom (global::System.IO.Stream p0, global::Com.Google.Protobuf.ExtensionRegistryLite p1)
			{
				if (id_mergeDelimitedFrom_Ljava_io_InputStream_Lcom_google_protobuf_ExtensionRegistryLite_ == IntPtr.Zero)
					id_mergeDelimitedFrom_Ljava_io_InputStream_Lcom_google_protobuf_ExtensionRegistryLite_ = JNIEnv.GetMethodID (class_ref, "mergeDelimitedFrom", "(Ljava/io/InputStream;Lcom/google/protobuf/ExtensionRegistryLite;)Z");
				IntPtr native_p0 = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (p0);

				bool __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod  (Handle, id_mergeDelimitedFrom_Ljava_io_InputStream_Lcom_google_protobuf_ExtensionRegistryLite_, new JValue (native_p0), new JValue (p1));
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, id_mergeDelimitedFrom_Ljava_io_InputStream_Lcom_google_protobuf_ExtensionRegistryLite_, new JValue (native_p0), new JValue (p1));
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
				Builder __this = Java.Lang.Object.GetObject<Builder> (native__this, JniHandleOwnership.DoNotTransfer);
				byte[] p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.MergeFrom (p0));
				if (p0 != null)
					JNIEnv.CopyArray (p0, native_p0);
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_mergeFrom_arrayB;
			[Register ("mergeFrom", "([B)Ljava/lang/Object;", "GetMergeFrom_arrayBHandler")]
			public virtual global::Java.Lang.Object MergeFrom (byte[] p0)
			{
				if (id_mergeFrom_arrayB == IntPtr.Zero)
					id_mergeFrom_arrayB = JNIEnv.GetMethodID (class_ref, "mergeFrom", "([B)Ljava/lang/Object;");
				IntPtr native_p0 = JNIEnv.NewArray (p0);

				global::Java.Lang.Object __ret;
				if (GetType () == ThresholdType)
					__ret = (Java.Lang.Object) Java.Lang.Object.GetObject<Java.Lang.Object> (JNIEnv.CallObjectMethod  (Handle, id_mergeFrom_arrayB, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
				else
					__ret = (Java.Lang.Object) Java.Lang.Object.GetObject<Java.Lang.Object> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_mergeFrom_arrayB, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
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
				Builder __this = Java.Lang.Object.GetObject<Builder> (native__this, JniHandleOwnership.DoNotTransfer);
				byte[] p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
				global::Com.Google.Protobuf.ExtensionRegistryLite p1 = Java.Lang.Object.GetObject<global::Com.Google.Protobuf.ExtensionRegistryLite> (native_p1, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.MergeFrom (p0, p1));
				if (p0 != null)
					JNIEnv.CopyArray (p0, native_p0);
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_mergeFrom_arrayBLcom_google_protobuf_ExtensionRegistryLite_;
			[Register ("mergeFrom", "([BLcom/google/protobuf/ExtensionRegistryLite;)Ljava/lang/Object;", "GetMergeFrom_arrayBLcom_google_protobuf_ExtensionRegistryLite_Handler")]
			public virtual global::Java.Lang.Object MergeFrom (byte[] p0, global::Com.Google.Protobuf.ExtensionRegistryLite p1)
			{
				if (id_mergeFrom_arrayBLcom_google_protobuf_ExtensionRegistryLite_ == IntPtr.Zero)
					id_mergeFrom_arrayBLcom_google_protobuf_ExtensionRegistryLite_ = JNIEnv.GetMethodID (class_ref, "mergeFrom", "([BLcom/google/protobuf/ExtensionRegistryLite;)Ljava/lang/Object;");
				IntPtr native_p0 = JNIEnv.NewArray (p0);

				global::Java.Lang.Object __ret;
				if (GetType () == ThresholdType)
					__ret = (Java.Lang.Object) Java.Lang.Object.GetObject<Java.Lang.Object> (JNIEnv.CallObjectMethod  (Handle, id_mergeFrom_arrayBLcom_google_protobuf_ExtensionRegistryLite_, new JValue (native_p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
				else
					__ret = (Java.Lang.Object) Java.Lang.Object.GetObject<Java.Lang.Object> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_mergeFrom_arrayBLcom_google_protobuf_ExtensionRegistryLite_, new JValue (native_p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
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
				Builder __this = Java.Lang.Object.GetObject<Builder> (native__this, JniHandleOwnership.DoNotTransfer);
				byte[] p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.MergeFrom (p0, p1, p2));
				if (p0 != null)
					JNIEnv.CopyArray (p0, native_p0);
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_mergeFrom_arrayBII;
			[Register ("mergeFrom", "([BII)Ljava/lang/Object;", "GetMergeFrom_arrayBIIHandler")]
			public virtual global::Java.Lang.Object MergeFrom (byte[] p0, int p1, int p2)
			{
				if (id_mergeFrom_arrayBII == IntPtr.Zero)
					id_mergeFrom_arrayBII = JNIEnv.GetMethodID (class_ref, "mergeFrom", "([BII)Ljava/lang/Object;");
				IntPtr native_p0 = JNIEnv.NewArray (p0);

				global::Java.Lang.Object __ret;
				if (GetType () == ThresholdType)
					__ret = (Java.Lang.Object) Java.Lang.Object.GetObject<Java.Lang.Object> (JNIEnv.CallObjectMethod  (Handle, id_mergeFrom_arrayBII, new JValue (native_p0), new JValue (p1), new JValue (p2)), JniHandleOwnership.TransferLocalRef);
				else
					__ret = (Java.Lang.Object) Java.Lang.Object.GetObject<Java.Lang.Object> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_mergeFrom_arrayBII, new JValue (native_p0), new JValue (p1), new JValue (p2)), JniHandleOwnership.TransferLocalRef);
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
				Builder __this = Java.Lang.Object.GetObject<Builder> (native__this, JniHandleOwnership.DoNotTransfer);
				byte[] p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
				global::Com.Google.Protobuf.ExtensionRegistryLite p3 = Java.Lang.Object.GetObject<global::Com.Google.Protobuf.ExtensionRegistryLite> (native_p3, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.MergeFrom (p0, p1, p2, p3));
				if (p0 != null)
					JNIEnv.CopyArray (p0, native_p0);
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_mergeFrom_arrayBIILcom_google_protobuf_ExtensionRegistryLite_;
			[Register ("mergeFrom", "([BIILcom/google/protobuf/ExtensionRegistryLite;)Ljava/lang/Object;", "GetMergeFrom_arrayBIILcom_google_protobuf_ExtensionRegistryLite_Handler")]
			public virtual global::Java.Lang.Object MergeFrom (byte[] p0, int p1, int p2, global::Com.Google.Protobuf.ExtensionRegistryLite p3)
			{
				if (id_mergeFrom_arrayBIILcom_google_protobuf_ExtensionRegistryLite_ == IntPtr.Zero)
					id_mergeFrom_arrayBIILcom_google_protobuf_ExtensionRegistryLite_ = JNIEnv.GetMethodID (class_ref, "mergeFrom", "([BIILcom/google/protobuf/ExtensionRegistryLite;)Ljava/lang/Object;");
				IntPtr native_p0 = JNIEnv.NewArray (p0);

				global::Java.Lang.Object __ret;
				if (GetType () == ThresholdType)
					__ret = (Java.Lang.Object) Java.Lang.Object.GetObject<Java.Lang.Object> (JNIEnv.CallObjectMethod  (Handle, id_mergeFrom_arrayBIILcom_google_protobuf_ExtensionRegistryLite_, new JValue (native_p0), new JValue (p1), new JValue (p2), new JValue (p3)), JniHandleOwnership.TransferLocalRef);
				else
					__ret = (Java.Lang.Object) Java.Lang.Object.GetObject<Java.Lang.Object> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_mergeFrom_arrayBIILcom_google_protobuf_ExtensionRegistryLite_, new JValue (native_p0), new JValue (p1), new JValue (p2), new JValue (p3)), JniHandleOwnership.TransferLocalRef);
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
				Builder __this = Java.Lang.Object.GetObject<Builder> (native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Google.Protobuf.ByteString p0 = Java.Lang.Object.GetObject<global::Com.Google.Protobuf.ByteString> (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.MergeFrom (p0));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_mergeFrom_Lcom_google_protobuf_ByteString_;
			[Register ("mergeFrom", "(Lcom/google/protobuf/ByteString;)Ljava/lang/Object;", "GetMergeFrom_Lcom_google_protobuf_ByteString_Handler")]
			public virtual global::Java.Lang.Object MergeFrom (global::Com.Google.Protobuf.ByteString p0)
			{
				if (id_mergeFrom_Lcom_google_protobuf_ByteString_ == IntPtr.Zero)
					id_mergeFrom_Lcom_google_protobuf_ByteString_ = JNIEnv.GetMethodID (class_ref, "mergeFrom", "(Lcom/google/protobuf/ByteString;)Ljava/lang/Object;");

				global::Java.Lang.Object __ret;
				if (GetType () == ThresholdType)
					__ret = (Java.Lang.Object) Java.Lang.Object.GetObject<Java.Lang.Object> (JNIEnv.CallObjectMethod  (Handle, id_mergeFrom_Lcom_google_protobuf_ByteString_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
				else
					__ret = (Java.Lang.Object) Java.Lang.Object.GetObject<Java.Lang.Object> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_mergeFrom_Lcom_google_protobuf_ByteString_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
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
				Builder __this = Java.Lang.Object.GetObject<Builder> (native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Google.Protobuf.ByteString p0 = Java.Lang.Object.GetObject<global::Com.Google.Protobuf.ByteString> (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Com.Google.Protobuf.ExtensionRegistryLite p1 = Java.Lang.Object.GetObject<global::Com.Google.Protobuf.ExtensionRegistryLite> (native_p1, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.MergeFrom (p0, p1));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_mergeFrom_Lcom_google_protobuf_ByteString_Lcom_google_protobuf_ExtensionRegistryLite_;
			[Register ("mergeFrom", "(Lcom/google/protobuf/ByteString;Lcom/google/protobuf/ExtensionRegistryLite;)Ljava/lang/Object;", "GetMergeFrom_Lcom_google_protobuf_ByteString_Lcom_google_protobuf_ExtensionRegistryLite_Handler")]
			public virtual global::Java.Lang.Object MergeFrom (global::Com.Google.Protobuf.ByteString p0, global::Com.Google.Protobuf.ExtensionRegistryLite p1)
			{
				if (id_mergeFrom_Lcom_google_protobuf_ByteString_Lcom_google_protobuf_ExtensionRegistryLite_ == IntPtr.Zero)
					id_mergeFrom_Lcom_google_protobuf_ByteString_Lcom_google_protobuf_ExtensionRegistryLite_ = JNIEnv.GetMethodID (class_ref, "mergeFrom", "(Lcom/google/protobuf/ByteString;Lcom/google/protobuf/ExtensionRegistryLite;)Ljava/lang/Object;");

				global::Java.Lang.Object __ret;
				if (GetType () == ThresholdType)
					__ret = (Java.Lang.Object) Java.Lang.Object.GetObject<Java.Lang.Object> (JNIEnv.CallObjectMethod  (Handle, id_mergeFrom_Lcom_google_protobuf_ByteString_Lcom_google_protobuf_ExtensionRegistryLite_, new JValue (p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
				else
					__ret = (Java.Lang.Object) Java.Lang.Object.GetObject<Java.Lang.Object> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_mergeFrom_Lcom_google_protobuf_ByteString_Lcom_google_protobuf_ExtensionRegistryLite_, new JValue (p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
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
				Builder __this = Java.Lang.Object.GetObject<Builder> (native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Google.Protobuf.CodedInputStream p0 = Java.Lang.Object.GetObject<global::Com.Google.Protobuf.CodedInputStream> (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.MergeFrom (p0));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_mergeFrom_Lcom_google_protobuf_CodedInputStream_;
			[Register ("mergeFrom", "(Lcom/google/protobuf/CodedInputStream;)Ljava/lang/Object;", "GetMergeFrom_Lcom_google_protobuf_CodedInputStream_Handler")]
			public virtual global::Java.Lang.Object MergeFrom (global::Com.Google.Protobuf.CodedInputStream p0)
			{
				if (id_mergeFrom_Lcom_google_protobuf_CodedInputStream_ == IntPtr.Zero)
					id_mergeFrom_Lcom_google_protobuf_CodedInputStream_ = JNIEnv.GetMethodID (class_ref, "mergeFrom", "(Lcom/google/protobuf/CodedInputStream;)Ljava/lang/Object;");

				global::Java.Lang.Object __ret;
				if (GetType () == ThresholdType)
					__ret = (Java.Lang.Object) Java.Lang.Object.GetObject<Java.Lang.Object> (JNIEnv.CallObjectMethod  (Handle, id_mergeFrom_Lcom_google_protobuf_CodedInputStream_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
				else
					__ret = (Java.Lang.Object) Java.Lang.Object.GetObject<Java.Lang.Object> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_mergeFrom_Lcom_google_protobuf_CodedInputStream_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
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
				Builder __this = Java.Lang.Object.GetObject<Builder> (native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Google.Protobuf.CodedInputStream p0 = Java.Lang.Object.GetObject<global::Com.Google.Protobuf.CodedInputStream> (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Com.Google.Protobuf.ExtensionRegistryLite p1 = Java.Lang.Object.GetObject<global::Com.Google.Protobuf.ExtensionRegistryLite> (native_p1, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.MergeFrom (p0, p1));
				return __ret;
			}
#pragma warning restore 0169

			[Register ("mergeFrom", "(Lcom/google/protobuf/CodedInputStream;Lcom/google/protobuf/ExtensionRegistryLite;)Ljava/lang/Object;", "GetMergeFrom_Lcom_google_protobuf_CodedInputStream_Lcom_google_protobuf_ExtensionRegistryLite_Handler")]
			public abstract global::Java.Lang.Object MergeFrom (global::Com.Google.Protobuf.CodedInputStream p0, global::Com.Google.Protobuf.ExtensionRegistryLite p1);

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
				Builder __this = Java.Lang.Object.GetObject<Builder> (native__this, JniHandleOwnership.DoNotTransfer);
				System.IO.Stream p0 = global::Android.Runtime.InputStreamInvoker.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.MergeFrom (p0));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_mergeFrom_Ljava_io_InputStream_;
			[Register ("mergeFrom", "(Ljava/io/InputStream;)Ljava/lang/Object;", "GetMergeFrom_Ljava_io_InputStream_Handler")]
			public virtual global::Java.Lang.Object MergeFrom (global::System.IO.Stream p0)
			{
				if (id_mergeFrom_Ljava_io_InputStream_ == IntPtr.Zero)
					id_mergeFrom_Ljava_io_InputStream_ = JNIEnv.GetMethodID (class_ref, "mergeFrom", "(Ljava/io/InputStream;)Ljava/lang/Object;");
				IntPtr native_p0 = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (p0);

				global::Java.Lang.Object __ret;
				if (GetType () == ThresholdType)
					__ret = (Java.Lang.Object) Java.Lang.Object.GetObject<Java.Lang.Object> (JNIEnv.CallObjectMethod  (Handle, id_mergeFrom_Ljava_io_InputStream_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
				else
					__ret = (Java.Lang.Object) Java.Lang.Object.GetObject<Java.Lang.Object> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_mergeFrom_Ljava_io_InputStream_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
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
				Builder __this = Java.Lang.Object.GetObject<Builder> (native__this, JniHandleOwnership.DoNotTransfer);
				System.IO.Stream p0 = global::Android.Runtime.InputStreamInvoker.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Com.Google.Protobuf.ExtensionRegistryLite p1 = Java.Lang.Object.GetObject<global::Com.Google.Protobuf.ExtensionRegistryLite> (native_p1, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.MergeFrom (p0, p1));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_mergeFrom_Ljava_io_InputStream_Lcom_google_protobuf_ExtensionRegistryLite_;
			[Register ("mergeFrom", "(Ljava/io/InputStream;Lcom/google/protobuf/ExtensionRegistryLite;)Ljava/lang/Object;", "GetMergeFrom_Ljava_io_InputStream_Lcom_google_protobuf_ExtensionRegistryLite_Handler")]
			public virtual global::Java.Lang.Object MergeFrom (global::System.IO.Stream p0, global::Com.Google.Protobuf.ExtensionRegistryLite p1)
			{
				if (id_mergeFrom_Ljava_io_InputStream_Lcom_google_protobuf_ExtensionRegistryLite_ == IntPtr.Zero)
					id_mergeFrom_Ljava_io_InputStream_Lcom_google_protobuf_ExtensionRegistryLite_ = JNIEnv.GetMethodID (class_ref, "mergeFrom", "(Ljava/io/InputStream;Lcom/google/protobuf/ExtensionRegistryLite;)Ljava/lang/Object;");
				IntPtr native_p0 = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (p0);

				global::Java.Lang.Object __ret;
				if (GetType () == ThresholdType)
					__ret = (Java.Lang.Object) Java.Lang.Object.GetObject<Java.Lang.Object> (JNIEnv.CallObjectMethod  (Handle, id_mergeFrom_Ljava_io_InputStream_Lcom_google_protobuf_ExtensionRegistryLite_, new JValue (native_p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
				else
					__ret = (Java.Lang.Object) Java.Lang.Object.GetObject<Java.Lang.Object> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_mergeFrom_Ljava_io_InputStream_Lcom_google_protobuf_ExtensionRegistryLite_, new JValue (native_p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
				JNIEnv.DeleteLocalRef (native_p0);
				return __ret;
			}

			static IntPtr id_newUninitializedMessageException_Lcom_google_protobuf_MessageLite_;
			[Register ("newUninitializedMessageException", "(Lcom/google/protobuf/MessageLite;)Lcom/google/protobuf/UninitializedMessageException;", "")]
			protected static global::Com.Google.Protobuf.UninitializedMessageException NewUninitializedMessageException (global::Com.Google.Protobuf.IMessageLite p0)
			{
				if (id_newUninitializedMessageException_Lcom_google_protobuf_MessageLite_ == IntPtr.Zero)
					id_newUninitializedMessageException_Lcom_google_protobuf_MessageLite_ = JNIEnv.GetStaticMethodID (class_ref, "newUninitializedMessageException", "(Lcom/google/protobuf/MessageLite;)Lcom/google/protobuf/UninitializedMessageException;");
				global::Com.Google.Protobuf.UninitializedMessageException __ret = Java.Lang.Object.GetObject<global::Com.Google.Protobuf.UninitializedMessageException> (JNIEnv.CallStaticObjectMethod  (class_ref, id_newUninitializedMessageException_Lcom_google_protobuf_MessageLite_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
				return __ret;
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
				Builder __this = Java.Lang.Object.GetObject<Builder> (native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.Build ());
			}
#pragma warning restore 0169

			[Register ("build", "()Lcom/google/protobuf/MessageLite;", "GetBuildHandler")]
			public abstract global::Com.Google.Protobuf.IMessageLite Build ();

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
				Builder __this = Java.Lang.Object.GetObject<Builder> (native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.BuildPartial ());
			}
#pragma warning restore 0169

			[Register ("buildPartial", "()Lcom/google/protobuf/MessageLite;", "GetBuildPartialHandler")]
			public abstract global::Com.Google.Protobuf.IMessageLite BuildPartial ();

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
				Builder __this = Java.Lang.Object.GetObject<Builder> (native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.Clear ());
			}
#pragma warning restore 0169

			[Register ("clear", "()Lcom/google/protobuf/MessageLite$Builder;", "GetClearHandler")]
			public abstract global::Com.Google.Protobuf.IMessageLiteBuilder Clear ();

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
				Builder __this = Java.Lang.Object.GetObject<Builder> (native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.DefaultInstanceForType);
			}
#pragma warning restore 0169

			public abstract global::Com.Google.Protobuf.IMessageLite DefaultInstanceForType { [Register ("getDefaultInstanceForType", "()Lcom/google/protobuf/MessageLite;", "GetGetDefaultInstanceForTypeHandler")] get; }

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
				Builder __this = Java.Lang.Object.GetObject<Builder> (native__this, JniHandleOwnership.DoNotTransfer);
				return __this.IsInitialized;
			}
#pragma warning restore 0169

			public abstract bool IsInitialized { [Register ("isInitialized", "()Z", "GetIsInitializedHandler")] get; }

		}

		[global::Android.Runtime.Register ("com/google/protobuf/AbstractMessageLite$Builder", DoNotGenerateAcw=true)]
		internal partial class BuilderInvoker : Builder {

			public BuilderInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

			protected override global::System.Type ThresholdType {
				get { return typeof (BuilderInvoker); }
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


		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/protobuf/AbstractMessageLite", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AbstractMessageLite); }
		}

		protected AbstractMessageLite (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		[Register (".ctor", "()V", "")]
		public AbstractMessageLite () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (AbstractMessageLite)) {
				SetHandle (global::Android.Runtime.JNIEnv.CreateInstance (GetType (), "()V"), JniHandleOwnership.TransferLocalRef);
				return;
			}

			if (id_ctor == IntPtr.Zero)
				id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
			SetHandle (JNIEnv.NewObject (class_ref, id_ctor), JniHandleOwnership.TransferLocalRef);
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
			AbstractMessageLite __this = Java.Lang.Object.GetObject<AbstractMessageLite> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.ToByteArray ());
		}
#pragma warning restore 0169

		static IntPtr id_toByteArray;
		[Register ("toByteArray", "()[B", "GetToByteArrayHandler")]
		public virtual byte[] ToByteArray ()
		{
			if (id_toByteArray == IntPtr.Zero)
				id_toByteArray = JNIEnv.GetMethodID (class_ref, "toByteArray", "()[B");

			if (GetType () == ThresholdType)
				return (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_toByteArray), JniHandleOwnership.TransferLocalRef, typeof (byte));
			else
				return (byte[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_toByteArray), JniHandleOwnership.TransferLocalRef, typeof (byte));
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
			AbstractMessageLite __this = Java.Lang.Object.GetObject<AbstractMessageLite> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ToByteString ());
		}
#pragma warning restore 0169

		static IntPtr id_toByteString;
		[Register ("toByteString", "()Lcom/google/protobuf/ByteString;", "GetToByteStringHandler")]
		public virtual global::Com.Google.Protobuf.ByteString ToByteString ()
		{
			if (id_toByteString == IntPtr.Zero)
				id_toByteString = JNIEnv.GetMethodID (class_ref, "toByteString", "()Lcom/google/protobuf/ByteString;");

			if (GetType () == ThresholdType)
				return Java.Lang.Object.GetObject<global::Com.Google.Protobuf.ByteString> (JNIEnv.CallObjectMethod  (Handle, id_toByteString), JniHandleOwnership.TransferLocalRef);
			else
				return Java.Lang.Object.GetObject<global::Com.Google.Protobuf.ByteString> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_toByteString), JniHandleOwnership.TransferLocalRef);
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
			AbstractMessageLite __this = Java.Lang.Object.GetObject<AbstractMessageLite> (native__this, JniHandleOwnership.DoNotTransfer);
			System.IO.Stream p0 = global::Android.Runtime.OutputStreamInvoker.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.WriteDelimitedTo (p0);
		}
#pragma warning restore 0169

		static IntPtr id_writeDelimitedTo_Ljava_io_OutputStream_;
		[Register ("writeDelimitedTo", "(Ljava/io/OutputStream;)V", "GetWriteDelimitedTo_Ljava_io_OutputStream_Handler")]
		public virtual void WriteDelimitedTo (global::System.IO.Stream p0)
		{
			if (id_writeDelimitedTo_Ljava_io_OutputStream_ == IntPtr.Zero)
				id_writeDelimitedTo_Ljava_io_OutputStream_ = JNIEnv.GetMethodID (class_ref, "writeDelimitedTo", "(Ljava/io/OutputStream;)V");
			IntPtr native_p0 = global::Android.Runtime.OutputStreamAdapter.ToLocalJniHandle (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_writeDelimitedTo_Ljava_io_OutputStream_, new JValue (native_p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_writeDelimitedTo_Ljava_io_OutputStream_, new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
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
			AbstractMessageLite __this = Java.Lang.Object.GetObject<AbstractMessageLite> (native__this, JniHandleOwnership.DoNotTransfer);
			System.IO.Stream p0 = global::Android.Runtime.OutputStreamInvoker.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.WriteTo (p0);
		}
#pragma warning restore 0169

		static IntPtr id_writeTo_Ljava_io_OutputStream_;
		[Register ("writeTo", "(Ljava/io/OutputStream;)V", "GetWriteTo_Ljava_io_OutputStream_Handler")]
		public virtual void WriteTo (global::System.IO.Stream p0)
		{
			if (id_writeTo_Ljava_io_OutputStream_ == IntPtr.Zero)
				id_writeTo_Ljava_io_OutputStream_ = JNIEnv.GetMethodID (class_ref, "writeTo", "(Ljava/io/OutputStream;)V");
			IntPtr native_p0 = global::Android.Runtime.OutputStreamAdapter.ToLocalJniHandle (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_writeTo_Ljava_io_OutputStream_, new JValue (native_p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_writeTo_Ljava_io_OutputStream_, new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
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
			AbstractMessageLite __this = Java.Lang.Object.GetObject<AbstractMessageLite> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.NewBuilderForType ());
		}
#pragma warning restore 0169

		[Register ("newBuilderForType", "()Lcom/google/protobuf/MessageLite$Builder;", "GetNewBuilderForTypeHandler")]
		public abstract global::Com.Google.Protobuf.IMessageLiteBuilder NewBuilderForType ();

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
			AbstractMessageLite __this = Java.Lang.Object.GetObject<AbstractMessageLite> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ToBuilder ());
		}
#pragma warning restore 0169

		[Register ("toBuilder", "()Lcom/google/protobuf/MessageLite$Builder;", "GetToBuilderHandler")]
		public abstract global::Com.Google.Protobuf.IMessageLiteBuilder ToBuilder ();

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
			AbstractMessageLite __this = Java.Lang.Object.GetObject<AbstractMessageLite> (native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Google.Protobuf.CodedOutputStream p0 = Java.Lang.Object.GetObject<global::Com.Google.Protobuf.CodedOutputStream> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.WriteTo (p0);
		}
#pragma warning restore 0169

		[Register ("writeTo", "(Lcom/google/protobuf/CodedOutputStream;)V", "GetWriteTo_Lcom_google_protobuf_CodedOutputStream_Handler")]
		public abstract void WriteTo (global::Com.Google.Protobuf.CodedOutputStream p0);

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
			AbstractMessageLite __this = Java.Lang.Object.GetObject<AbstractMessageLite> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.DefaultInstanceForType);
		}
#pragma warning restore 0169

		public abstract global::Com.Google.Protobuf.IMessageLite DefaultInstanceForType { [Register ("getDefaultInstanceForType", "()Lcom/google/protobuf/MessageLite;", "GetGetDefaultInstanceForTypeHandler")] get; }

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
			AbstractMessageLite __this = Java.Lang.Object.GetObject<AbstractMessageLite> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsInitialized;
		}
#pragma warning restore 0169

		public abstract bool IsInitialized { [Register ("isInitialized", "()Z", "GetIsInitializedHandler")] get; }

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
			AbstractMessageLite __this = Java.Lang.Object.GetObject<AbstractMessageLite> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SerializedSize;
		}
#pragma warning restore 0169

		public abstract int SerializedSize { [Register ("getSerializedSize", "()I", "GetGetSerializedSizeHandler")] get; }

	}

	[global::Android.Runtime.Register ("com/google/protobuf/AbstractMessageLite", DoNotGenerateAcw=true)]
	internal partial class AbstractMessageLiteInvoker : AbstractMessageLite {

		public AbstractMessageLiteInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (AbstractMessageLiteInvoker); }
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
