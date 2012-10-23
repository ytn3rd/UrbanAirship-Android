using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Urbanairship {

	[global::Android.Runtime.Register ("com/urbanairship/InternalOptions", DoNotGenerateAcw=true)]
	public partial class InternalOptions : global::Com.Urbanairship.Options {


		static IntPtr useTestCluster_jfieldId;

		[Register ("useTestCluster")]
		public bool UseTestCluster {
			get {
				if (useTestCluster_jfieldId == IntPtr.Zero)
					useTestCluster_jfieldId = JNIEnv.GetFieldID (class_ref, "useTestCluster", "Z");
				return JNIEnv.GetBooleanField (Handle, useTestCluster_jfieldId);
			}
			set {
				if (useTestCluster_jfieldId == IntPtr.Zero)
					useTestCluster_jfieldId = JNIEnv.GetFieldID (class_ref, "useTestCluster", "Z");
				JNIEnv.SetField (Handle, useTestCluster_jfieldId, value);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/urbanairship/InternalOptions", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (InternalOptions); }
		}

		protected InternalOptions (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		[Register (".ctor", "()V", "")]
		public InternalOptions () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (InternalOptions)) {
				SetHandle (global::Android.Runtime.JNIEnv.CreateInstance (GetType (), "()V"), JniHandleOwnership.TransferLocalRef);
				return;
			}

			if (id_ctor == IntPtr.Zero)
				id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
			SetHandle (JNIEnv.NewObject (class_ref, id_ctor), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_getDefaultPropertiesFilename;
#pragma warning disable 0169
		static Delegate GetGetDefaultPropertiesFilenameHandler ()
		{
			if (cb_getDefaultPropertiesFilename == null)
				cb_getDefaultPropertiesFilename = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDefaultPropertiesFilename);
			return cb_getDefaultPropertiesFilename;
		}

		static IntPtr n_GetDefaultPropertiesFilename (IntPtr jnienv, IntPtr native__this)
		{
			InternalOptions __this = Java.Lang.Object.GetObject<InternalOptions> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.DefaultPropertiesFilename);
		}
#pragma warning restore 0169

		static IntPtr id_getDefaultPropertiesFilename;
		public override string DefaultPropertiesFilename {
			[Register ("getDefaultPropertiesFilename", "()Ljava/lang/String;", "GetGetDefaultPropertiesFilenameHandler")]
			get {
				if (id_getDefaultPropertiesFilename == IntPtr.Zero)
					id_getDefaultPropertiesFilename = JNIEnv.GetMethodID (class_ref, "getDefaultPropertiesFilename", "()Ljava/lang/String;");

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getDefaultPropertiesFilename), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getDefaultPropertiesFilename), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_isValid;
#pragma warning disable 0169
		static Delegate GetIsValidHandler ()
		{
			if (cb_isValid == null)
				cb_isValid = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsValid);
			return cb_isValid;
		}

		static bool n_IsValid (IntPtr jnienv, IntPtr native__this)
		{
			InternalOptions __this = Java.Lang.Object.GetObject<InternalOptions> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsValid;
		}
#pragma warning restore 0169

		static IntPtr id_isValid;
		public override bool IsValid {
			[Register ("isValid", "()Z", "GetIsValidHandler")]
			get {
				if (id_isValid == IntPtr.Zero)
					id_isValid = JNIEnv.GetMethodID (class_ref, "isValid", "()Z");

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_isValid);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, id_isValid);
			}
		}

		static IntPtr id_loadDefaultOptions_Landroid_content_Context_;
		[Register ("loadDefaultOptions", "(Landroid/content/Context;)Lcom/urbanairship/InternalOptions;", "")]
		public static global::Com.Urbanairship.InternalOptions LoadDefaultOptions (global::Android.Content.Context p0)
		{
			if (id_loadDefaultOptions_Landroid_content_Context_ == IntPtr.Zero)
				id_loadDefaultOptions_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "loadDefaultOptions", "(Landroid/content/Context;)Lcom/urbanairship/InternalOptions;");
			global::Com.Urbanairship.InternalOptions __ret = Java.Lang.Object.GetObject<global::Com.Urbanairship.InternalOptions> (JNIEnv.CallStaticObjectMethod  (class_ref, id_loadDefaultOptions_Landroid_content_Context_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

	}
}
