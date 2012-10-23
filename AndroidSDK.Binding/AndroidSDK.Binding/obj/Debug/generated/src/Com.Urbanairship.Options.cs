using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Urbanairship {

	[global::Android.Runtime.Register ("com/urbanairship/Options", DoNotGenerateAcw=true)]
	public abstract partial class Options : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/urbanairship/Options", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Options); }
		}

		protected Options (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		[Register (".ctor", "()V", "")]
		public Options () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (Options)) {
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
			Options __this = Java.Lang.Object.GetObject<Options> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.DefaultPropertiesFilename);
		}
#pragma warning restore 0169

		public abstract string DefaultPropertiesFilename { [Register ("getDefaultPropertiesFilename", "()Ljava/lang/String;", "GetGetDefaultPropertiesFilenameHandler")] get; }

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
			Options __this = Java.Lang.Object.GetObject<Options> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsValid;
		}
#pragma warning restore 0169

		public abstract bool IsValid { [Register ("isValid", "()Z", "GetIsValidHandler")] get; }

		static Delegate cb_loadFromProperties_Landroid_content_Context_;
#pragma warning disable 0169
		static Delegate GetLoadFromProperties_Landroid_content_Context_Handler ()
		{
			if (cb_loadFromProperties_Landroid_content_Context_ == null)
				cb_loadFromProperties_Landroid_content_Context_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_LoadFromProperties_Landroid_content_Context_);
			return cb_loadFromProperties_Landroid_content_Context_;
		}

		static void n_LoadFromProperties_Landroid_content_Context_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			Options __this = Java.Lang.Object.GetObject<Options> (native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.LoadFromProperties (p0);
		}
#pragma warning restore 0169

		static IntPtr id_loadFromProperties_Landroid_content_Context_;
		[Register ("loadFromProperties", "(Landroid/content/Context;)V", "GetLoadFromProperties_Landroid_content_Context_Handler")]
		public virtual void LoadFromProperties (global::Android.Content.Context p0)
		{
			if (id_loadFromProperties_Landroid_content_Context_ == IntPtr.Zero)
				id_loadFromProperties_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "loadFromProperties", "(Landroid/content/Context;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_loadFromProperties_Landroid_content_Context_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_loadFromProperties_Landroid_content_Context_, new JValue (p0));
		}

		static Delegate cb_loadFromProperties_Landroid_content_Context_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetLoadFromProperties_Landroid_content_Context_Ljava_lang_String_Handler ()
		{
			if (cb_loadFromProperties_Landroid_content_Context_Ljava_lang_String_ == null)
				cb_loadFromProperties_Landroid_content_Context_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_LoadFromProperties_Landroid_content_Context_Ljava_lang_String_);
			return cb_loadFromProperties_Landroid_content_Context_Ljava_lang_String_;
		}

		static void n_LoadFromProperties_Landroid_content_Context_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			Options __this = Java.Lang.Object.GetObject<Options> (native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.LoadFromProperties (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_loadFromProperties_Landroid_content_Context_Ljava_lang_String_;
		[Register ("loadFromProperties", "(Landroid/content/Context;Ljava/lang/String;)V", "GetLoadFromProperties_Landroid_content_Context_Ljava_lang_String_Handler")]
		public virtual void LoadFromProperties (global::Android.Content.Context p0, string p1)
		{
			if (id_loadFromProperties_Landroid_content_Context_Ljava_lang_String_ == IntPtr.Zero)
				id_loadFromProperties_Landroid_content_Context_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "loadFromProperties", "(Landroid/content/Context;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_loadFromProperties_Landroid_content_Context_Ljava_lang_String_, new JValue (p0), new JValue (native_p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_loadFromProperties_Landroid_content_Context_Ljava_lang_String_, new JValue (p0), new JValue (native_p1));
			JNIEnv.DeleteLocalRef (native_p1);
		}

	}

	[global::Android.Runtime.Register ("com/urbanairship/Options", DoNotGenerateAcw=true)]
	internal partial class OptionsInvoker : Options {

		public OptionsInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (OptionsInvoker); }
		}

		static IntPtr id_getDefaultPropertiesFilename;
		public override string DefaultPropertiesFilename {
			[Register ("getDefaultPropertiesFilename", "()Ljava/lang/String;", "GetGetDefaultPropertiesFilenameHandler")]
			get {
				if (id_getDefaultPropertiesFilename == IntPtr.Zero)
					id_getDefaultPropertiesFilename = JNIEnv.GetMethodID (class_ref, "getDefaultPropertiesFilename", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getDefaultPropertiesFilename), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_isValid;
		public override bool IsValid {
			[Register ("isValid", "()Z", "GetIsValidHandler")]
			get {
				if (id_isValid == IntPtr.Zero)
					id_isValid = JNIEnv.GetMethodID (class_ref, "isValid", "()Z");
				return JNIEnv.CallBooleanMethod  (Handle, id_isValid);
			}
		}

	}

}
