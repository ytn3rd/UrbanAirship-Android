using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Urbanairship {

	[global::Android.Runtime.Register ("com/urbanairship/Preferences", DoNotGenerateAcw=true)]
	public abstract partial class Preferences : global::Java.Lang.Object {

		[global::Android.Runtime.Register ("com/urbanairship/Preferences$Preference", DoNotGenerateAcw=true)]
		public partial class Preference : global::Java.Lang.Object {

			[global::Android.Runtime.Register ("com/urbanairship/Preferences$Preference$PreferencesObserver", DoNotGenerateAcw=true)]
			public partial class PreferencesObserver : global::Android.Database.ContentObserver {

				internal static IntPtr java_class_handle;
				internal static IntPtr class_ref {
					get {
						return JNIEnv.FindClass ("com/urbanairship/Preferences$Preference$PreferencesObserver", ref java_class_handle);
					}
				}

				protected override IntPtr ThresholdClass {
					get { return class_ref; }
				}

				protected override global::System.Type ThresholdType {
					get { return typeof (PreferencesObserver); }
				}

				protected PreferencesObserver (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

				static IntPtr id_ctor_Lcom_urbanairship_Preferences_Preference_;
				[Register (".ctor", "(Lcom/urbanairship/Preferences$Preference;)V", "")]
				public PreferencesObserver (global::Com.Urbanairship.Preferences.Preference __self) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
				{
					if (Handle != IntPtr.Zero)
						return;

					if (GetType () != typeof (PreferencesObserver)) {
						SetHandle (global::Android.Runtime.JNIEnv.CreateInstance (GetType (), "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";)V", new JValue (__self)), JniHandleOwnership.TransferLocalRef);
						return;
					}

					if (id_ctor_Lcom_urbanairship_Preferences_Preference_ == IntPtr.Zero)
						id_ctor_Lcom_urbanairship_Preferences_Preference_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/urbanairship/Preferences$Preference;)V");
					SetHandle (JNIEnv.NewObject (class_ref, id_ctor_Lcom_urbanairship_Preferences_Preference_, new JValue (__self)), JniHandleOwnership.TransferLocalRef);
				}

			}

			protected Preference (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/urbanairship/Preferences", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Preferences); }
		}

		protected Preferences (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_;
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public Preferences (global::Android.Content.Context p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (Preferences)) {
				SetHandle (global::Android.Runtime.JNIEnv.CreateInstance (GetType (), "(Landroid/content/Context;)V", new JValue (p0)), JniHandleOwnership.TransferLocalRef);
				return;
			}

			if (id_ctor_Landroid_content_Context_ == IntPtr.Zero)
				id_ctor_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;)V");
			SetHandle (JNIEnv.NewObject (class_ref, id_ctor_Landroid_content_Context_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_getBoolean_Ljava_lang_String_Z;
#pragma warning disable 0169
		static Delegate GetGetBoolean_Ljava_lang_String_ZHandler ()
		{
			if (cb_getBoolean_Ljava_lang_String_Z == null)
				cb_getBoolean_Ljava_lang_String_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool, bool>) n_GetBoolean_Ljava_lang_String_Z);
			return cb_getBoolean_Ljava_lang_String_Z;
		}

		static bool n_GetBoolean_Ljava_lang_String_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, bool p1)
		{
			Preferences __this = Java.Lang.Object.GetObject<Preferences> (native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.GetBoolean (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getBoolean_Ljava_lang_String_Z;
		[Register ("getBoolean", "(Ljava/lang/String;Z)Z", "GetGetBoolean_Ljava_lang_String_ZHandler")]
		public virtual bool GetBoolean (string p0, bool p1)
		{
			if (id_getBoolean_Ljava_lang_String_Z == IntPtr.Zero)
				id_getBoolean_Ljava_lang_String_Z = JNIEnv.GetMethodID (class_ref, "getBoolean", "(Ljava/lang/String;Z)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			bool __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallBooleanMethod  (Handle, id_getBoolean_Ljava_lang_String_Z, new JValue (native_p0), new JValue (p1));
			else
				__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, id_getBoolean_Ljava_lang_String_Z, new JValue (native_p0), new JValue (p1));
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_getInt_Ljava_lang_String_I;
#pragma warning disable 0169
		static Delegate GetGetInt_Ljava_lang_String_IHandler ()
		{
			if (cb_getInt_Ljava_lang_String_I == null)
				cb_getInt_Ljava_lang_String_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, int>) n_GetInt_Ljava_lang_String_I);
			return cb_getInt_Ljava_lang_String_I;
		}

		static int n_GetInt_Ljava_lang_String_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			Preferences __this = Java.Lang.Object.GetObject<Preferences> (native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.GetInt (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getInt_Ljava_lang_String_I;
		[Register ("getInt", "(Ljava/lang/String;I)I", "GetGetInt_Ljava_lang_String_IHandler")]
		public virtual int GetInt (string p0, int p1)
		{
			if (id_getInt_Ljava_lang_String_I == IntPtr.Zero)
				id_getInt_Ljava_lang_String_I = JNIEnv.GetMethodID (class_ref, "getInt", "(Ljava/lang/String;I)I");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			int __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallIntMethod  (Handle, id_getInt_Ljava_lang_String_I, new JValue (native_p0), new JValue (p1));
			else
				__ret = JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, id_getInt_Ljava_lang_String_I, new JValue (native_p0), new JValue (p1));
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_getLong_Ljava_lang_String_J;
#pragma warning disable 0169
		static Delegate GetGetLong_Ljava_lang_String_JHandler ()
		{
			if (cb_getLong_Ljava_lang_String_J == null)
				cb_getLong_Ljava_lang_String_J = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, long, long>) n_GetLong_Ljava_lang_String_J);
			return cb_getLong_Ljava_lang_String_J;
		}

		static long n_GetLong_Ljava_lang_String_J (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, long p1)
		{
			Preferences __this = Java.Lang.Object.GetObject<Preferences> (native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			long __ret = __this.GetLong (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getLong_Ljava_lang_String_J;
		[Register ("getLong", "(Ljava/lang/String;J)J", "GetGetLong_Ljava_lang_String_JHandler")]
		public virtual long GetLong (string p0, long p1)
		{
			if (id_getLong_Ljava_lang_String_J == IntPtr.Zero)
				id_getLong_Ljava_lang_String_J = JNIEnv.GetMethodID (class_ref, "getLong", "(Ljava/lang/String;J)J");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			long __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallLongMethod  (Handle, id_getLong_Ljava_lang_String_J, new JValue (native_p0), new JValue (p1));
			else
				__ret = JNIEnv.CallNonvirtualLongMethod  (Handle, ThresholdClass, id_getLong_Ljava_lang_String_J, new JValue (native_p0), new JValue (p1));
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_getString_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetString_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_getString_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_getString_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_GetString_Ljava_lang_String_Ljava_lang_String_);
			return cb_getString_Ljava_lang_String_Ljava_lang_String_;
		}

		static IntPtr n_GetString_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			Preferences __this = Java.Lang.Object.GetObject<Preferences> (native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GetString (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getString_Ljava_lang_String_Ljava_lang_String_;
		[Register ("getString", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", "GetGetString_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual string GetString (string p0, string p1)
		{
			if (id_getString_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_getString_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getString", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);

			string __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getString_Ljava_lang_String_Ljava_lang_String_, new JValue (native_p0), new JValue (native_p1)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getString_Ljava_lang_String_Ljava_lang_String_, new JValue (native_p0), new JValue (native_p1)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			return __ret;
		}

		static Delegate cb_migratePreferencesFromFileToDb_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetMigratePreferencesFromFileToDb_Ljava_lang_String_Handler ()
		{
			if (cb_migratePreferencesFromFileToDb_Ljava_lang_String_ == null)
				cb_migratePreferencesFromFileToDb_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_MigratePreferencesFromFileToDb_Ljava_lang_String_);
			return cb_migratePreferencesFromFileToDb_Ljava_lang_String_;
		}

		static void n_MigratePreferencesFromFileToDb_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			Preferences __this = Java.Lang.Object.GetObject<Preferences> (native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.MigratePreferencesFromFileToDb (p0);
		}
#pragma warning restore 0169

		static IntPtr id_migratePreferencesFromFileToDb_Ljava_lang_String_;
		[Register ("migratePreferencesFromFileToDb", "(Ljava/lang/String;)V", "GetMigratePreferencesFromFileToDb_Ljava_lang_String_Handler")]
		protected virtual void MigratePreferencesFromFileToDb (string p0)
		{
			if (id_migratePreferencesFromFileToDb_Ljava_lang_String_ == IntPtr.Zero)
				id_migratePreferencesFromFileToDb_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "migratePreferencesFromFileToDb", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_migratePreferencesFromFileToDb_Ljava_lang_String_, new JValue (native_p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_migratePreferencesFromFileToDb_Ljava_lang_String_, new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_put_Ljava_lang_String_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetPut_Ljava_lang_String_Ljava_lang_Object_Handler ()
		{
			if (cb_put_Ljava_lang_String_Ljava_lang_Object_ == null)
				cb_put_Ljava_lang_String_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_Put_Ljava_lang_String_Ljava_lang_Object_);
			return cb_put_Ljava_lang_String_Ljava_lang_Object_;
		}

		static void n_Put_Ljava_lang_String_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			Preferences __this = Java.Lang.Object.GetObject<Preferences> (native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p1 = Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Put (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_put_Ljava_lang_String_Ljava_lang_Object_;
		[Register ("put", "(Ljava/lang/String;Ljava/lang/Object;)V", "GetPut_Ljava_lang_String_Ljava_lang_Object_Handler")]
		public virtual void Put (string p0, global::Java.Lang.Object p1)
		{
			if (id_put_Ljava_lang_String_Ljava_lang_Object_ == IntPtr.Zero)
				id_put_Ljava_lang_String_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "put", "(Ljava/lang/String;Ljava/lang/Object;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_put_Ljava_lang_String_Ljava_lang_Object_, new JValue (native_p0), new JValue (p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_put_Ljava_lang_String_Ljava_lang_Object_, new JValue (native_p0), new JValue (p1));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_remove_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetRemove_Ljava_lang_String_Handler ()
		{
			if (cb_remove_Ljava_lang_String_ == null)
				cb_remove_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Remove_Ljava_lang_String_);
			return cb_remove_Ljava_lang_String_;
		}

		static void n_Remove_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			Preferences __this = Java.Lang.Object.GetObject<Preferences> (native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Remove (p0);
		}
#pragma warning restore 0169

		static IntPtr id_remove_Ljava_lang_String_;
		[Register ("remove", "(Ljava/lang/String;)V", "GetRemove_Ljava_lang_String_Handler")]
		public virtual void Remove (string p0)
		{
			if (id_remove_Ljava_lang_String_ == IntPtr.Zero)
				id_remove_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "remove", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_remove_Ljava_lang_String_, new JValue (native_p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_remove_Ljava_lang_String_, new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
		}

	}

	[global::Android.Runtime.Register ("com/urbanairship/Preferences", DoNotGenerateAcw=true)]
	internal partial class PreferencesInvoker : Preferences {

		public PreferencesInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (PreferencesInvoker); }
		}

	}

}
