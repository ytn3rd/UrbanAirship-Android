using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Urbanairship.Push.Embedded {

	[global::Android.Runtime.Register ("com/urbanairship/push/embedded/Crypto", DoNotGenerateAcw=true)]
	public partial class Crypto : global::Java.Lang.Object {

		[global::Android.Runtime.Register ("com/urbanairship/push/embedded/Crypto$NullUUID", DoNotGenerateAcw=true)]
		public partial class NullUUID : global::Java.Lang.Exception {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/urbanairship/push/embedded/Crypto$NullUUID", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (NullUUID); }
			}

			protected NullUUID (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lcom_urbanairship_push_embedded_Crypto_;
			[Register (".ctor", "(Lcom/urbanairship/push/embedded/Crypto;)V", "")]
			public NullUUID (global::Com.Urbanairship.Push.Embedded.Crypto __self) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				if (GetType () != typeof (NullUUID)) {
					SetHandle (global::Android.Runtime.JNIEnv.CreateInstance (GetType (), "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";)V", new JValue (__self)), JniHandleOwnership.TransferLocalRef);
					return;
				}

				if (id_ctor_Lcom_urbanairship_push_embedded_Crypto_ == IntPtr.Zero)
					id_ctor_Lcom_urbanairship_push_embedded_Crypto_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/urbanairship/push/embedded/Crypto;)V");
				SetHandle (JNIEnv.NewObject (class_ref, id_ctor_Lcom_urbanairship_push_embedded_Crypto_, new JValue (__self)), JniHandleOwnership.TransferLocalRef);
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/urbanairship/push/embedded/Crypto", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Crypto); }
		}

		protected Crypto (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_util_UUID_;
		[Register (".ctor", "(Ljava/util/UUID;)V", "")]
		public Crypto (global::Java.Util.UUID p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (Crypto)) {
				SetHandle (global::Android.Runtime.JNIEnv.CreateInstance (GetType (), "(Ljava/util/UUID;)V", new JValue (p0)), JniHandleOwnership.TransferLocalRef);
				return;
			}

			if (id_ctor_Ljava_util_UUID_ == IntPtr.Zero)
				id_ctor_Ljava_util_UUID_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/util/UUID;)V");
			SetHandle (JNIEnv.NewObject (class_ref, id_ctor_Ljava_util_UUID_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_decrypt_arrayB;
#pragma warning disable 0169
		static Delegate GetDecrypt_arrayBHandler ()
		{
			if (cb_decrypt_arrayB == null)
				cb_decrypt_arrayB = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Decrypt_arrayB);
			return cb_decrypt_arrayB;
		}

		static IntPtr n_Decrypt_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			Crypto __this = Java.Lang.Object.GetObject<Crypto> (native__this, JniHandleOwnership.DoNotTransfer);
			byte[] p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			IntPtr __ret = JNIEnv.NewArray (__this.Decrypt (p0));
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_decrypt_arrayB;
		[Register ("decrypt", "([B)[B", "GetDecrypt_arrayBHandler")]
		public virtual byte[] Decrypt (byte[] p0)
		{
			if (id_decrypt_arrayB == IntPtr.Zero)
				id_decrypt_arrayB = JNIEnv.GetMethodID (class_ref, "decrypt", "([B)[B");
			IntPtr native_p0 = JNIEnv.NewArray (p0);

			byte[] __ret;
			if (GetType () == ThresholdType)
				__ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_decrypt_arrayB, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef, typeof (byte));
			else
				__ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_decrypt_arrayB, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef, typeof (byte));
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			return __ret;
		}

		static Delegate cb_encrypt_arrayB;
#pragma warning disable 0169
		static Delegate GetEncrypt_arrayBHandler ()
		{
			if (cb_encrypt_arrayB == null)
				cb_encrypt_arrayB = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Encrypt_arrayB);
			return cb_encrypt_arrayB;
		}

		static IntPtr n_Encrypt_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			Crypto __this = Java.Lang.Object.GetObject<Crypto> (native__this, JniHandleOwnership.DoNotTransfer);
			byte[] p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			IntPtr __ret = JNIEnv.NewArray (__this.Encrypt (p0));
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_encrypt_arrayB;
		[Register ("encrypt", "([B)[B", "GetEncrypt_arrayBHandler")]
		public virtual byte[] Encrypt (byte[] p0)
		{
			if (id_encrypt_arrayB == IntPtr.Zero)
				id_encrypt_arrayB = JNIEnv.GetMethodID (class_ref, "encrypt", "([B)[B");
			IntPtr native_p0 = JNIEnv.NewArray (p0);

			byte[] __ret;
			if (GetType () == ThresholdType)
				__ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_encrypt_arrayB, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef, typeof (byte));
			else
				__ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_encrypt_arrayB, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef, typeof (byte));
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			return __ret;
		}

	}
}
