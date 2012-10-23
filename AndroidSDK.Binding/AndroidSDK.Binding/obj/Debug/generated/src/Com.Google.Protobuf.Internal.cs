using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Protobuf {

	[global::Android.Runtime.Register ("com/google/protobuf/Internal", DoNotGenerateAcw=true)]
	public partial class Internal : global::Java.Lang.Object {

		[Register ("com/google/protobuf/Internal$EnumLite", "", "Com.Google.Protobuf.Internal/IEnumLiteInvoker")]
		public partial interface IEnumLite : IJavaObject {

			int Number {
				[Register ("getNumber", "()I", "GetGetNumberHandler:Com.Google.Protobuf.Internal/IEnumLiteInvoker, AndroidSDK.Binding")] get;
			}

		}

		[global::Android.Runtime.Register ("com/google/protobuf/Internal$EnumLite", DoNotGenerateAcw=true)]
		internal class IEnumLiteInvoker : Java.Lang.Object, IEnumLite {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/google/protobuf/Internal$EnumLite");
			IntPtr class_ref;

			public static IEnumLite GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return Java.Lang.Object.GetObject<IEnumLite> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.google.protobuf.Internal.EnumLite"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IEnumLiteInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override System.Type ThresholdType {
				get { return typeof (IEnumLiteInvoker); }
			}

			static Delegate cb_getNumber;
#pragma warning disable 0169
			static Delegate GetGetNumberHandler ()
			{
				if (cb_getNumber == null)
					cb_getNumber = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetNumber);
				return cb_getNumber;
			}

			static int n_GetNumber (IntPtr jnienv, IntPtr native__this)
			{
				IEnumLite __this = Java.Lang.Object.GetObject<IEnumLite> (native__this, JniHandleOwnership.DoNotTransfer);
				return __this.Number;
			}
#pragma warning restore 0169

			IntPtr id_getNumber;
			public int Number {
				get {
					if (id_getNumber == IntPtr.Zero)
						id_getNumber = JNIEnv.GetMethodID (class_ref, "getNumber", "()I");
					return JNIEnv.CallIntMethod (Handle, id_getNumber);
				}
			}

		}


		[Register ("com/google/protobuf/Internal$EnumLiteMap", "", "Com.Google.Protobuf.Internal/IEnumLiteMapInvoker")]
		public partial interface IEnumLiteMap : IJavaObject {

			[Register ("findValueByNumber", "(I)Ljava/lang/Object;", "GetFindValueByNumber_IHandler:Com.Google.Protobuf.Internal/IEnumLiteMapInvoker, AndroidSDK.Binding")]
			global::Java.Lang.Object FindValueByNumber (int p0);

		}

		[global::Android.Runtime.Register ("com/google/protobuf/Internal$EnumLiteMap", DoNotGenerateAcw=true)]
		internal class IEnumLiteMapInvoker : Java.Lang.Object, IEnumLiteMap {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/google/protobuf/Internal$EnumLiteMap");
			IntPtr class_ref;

			public static IEnumLiteMap GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return Java.Lang.Object.GetObject<IEnumLiteMap> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.google.protobuf.Internal.EnumLiteMap"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IEnumLiteMapInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override System.Type ThresholdType {
				get { return typeof (IEnumLiteMapInvoker); }
			}

			static Delegate cb_findValueByNumber_I;
#pragma warning disable 0169
			static Delegate GetFindValueByNumber_IHandler ()
			{
				if (cb_findValueByNumber_I == null)
					cb_findValueByNumber_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_FindValueByNumber_I);
				return cb_findValueByNumber_I;
			}

			static IntPtr n_FindValueByNumber_I (IntPtr jnienv, IntPtr native__this, int p0)
			{
				IEnumLiteMap __this = Java.Lang.Object.GetObject<IEnumLiteMap> (native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.FindValueByNumber (p0));
			}
#pragma warning restore 0169

			IntPtr id_findValueByNumber_I;
			public global::Java.Lang.Object FindValueByNumber (int p0)
			{
				if (id_findValueByNumber_I == IntPtr.Zero)
					id_findValueByNumber_I = JNIEnv.GetMethodID (class_ref, "findValueByNumber", "(I)Ljava/lang/Object;");
				return (Java.Lang.Object) Java.Lang.Object.GetObject<Java.Lang.Object> (JNIEnv.CallObjectMethod (Handle, id_findValueByNumber_I, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			}

		}


		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/protobuf/Internal", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Internal); }
		}

		protected Internal (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		[Register (".ctor", "()V", "")]
		public Internal () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (Internal)) {
				SetHandle (global::Android.Runtime.JNIEnv.CreateInstance (GetType (), "()V"), JniHandleOwnership.TransferLocalRef);
				return;
			}

			if (id_ctor == IntPtr.Zero)
				id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
			SetHandle (JNIEnv.NewObject (class_ref, id_ctor), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_bytesDefaultValue_Ljava_lang_String_;
		[Register ("bytesDefaultValue", "(Ljava/lang/String;)Lcom/google/protobuf/ByteString;", "")]
		public static global::Com.Google.Protobuf.ByteString BytesDefaultValue (string p0)
		{
			if (id_bytesDefaultValue_Ljava_lang_String_ == IntPtr.Zero)
				id_bytesDefaultValue_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "bytesDefaultValue", "(Ljava/lang/String;)Lcom/google/protobuf/ByteString;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			global::Com.Google.Protobuf.ByteString __ret = Java.Lang.Object.GetObject<global::Com.Google.Protobuf.ByteString> (JNIEnv.CallStaticObjectMethod  (class_ref, id_bytesDefaultValue_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static IntPtr id_stringDefaultValue_Ljava_lang_String_;
		[Register ("stringDefaultValue", "(Ljava/lang/String;)Ljava/lang/String;", "")]
		public static string StringDefaultValue (string p0)
		{
			if (id_stringDefaultValue_Ljava_lang_String_ == IntPtr.Zero)
				id_stringDefaultValue_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "stringDefaultValue", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_stringDefaultValue_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

	}
}
