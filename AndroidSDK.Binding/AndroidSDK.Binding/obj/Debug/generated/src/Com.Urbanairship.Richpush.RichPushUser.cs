using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Urbanairship.Richpush {

	[global::Android.Runtime.Register ("com/urbanairship/richpush/RichPushUser", DoNotGenerateAcw=true)]
	public partial class RichPushUser : global::Java.Lang.Object {

		[global::Android.Runtime.Register ("com/urbanairship/richpush/RichPushUser$UserPreferences", DoNotGenerateAcw=true)]
		public partial class UserPreferences : global::Com.Urbanairship.Preferences {

			protected UserPreferences (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/urbanairship/richpush/RichPushUser", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (RichPushUser); }
		}

		protected RichPushUser (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		[Register (".ctor", "()V", "")]
		public RichPushUser () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (RichPushUser)) {
				SetHandle (global::Android.Runtime.JNIEnv.CreateInstance (GetType (), "()V"), JniHandleOwnership.TransferLocalRef);
				return;
			}

			if (id_ctor == IntPtr.Zero)
				id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
			SetHandle (JNIEnv.NewObject (class_ref, id_ctor), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_getAlias;
#pragma warning disable 0169
		static Delegate GetGetAliasHandler ()
		{
			if (cb_getAlias == null)
				cb_getAlias = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAlias);
			return cb_getAlias;
		}

		static IntPtr n_GetAlias (IntPtr jnienv, IntPtr native__this)
		{
			RichPushUser __this = Java.Lang.Object.GetObject<RichPushUser> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Alias);
		}
#pragma warning restore 0169

		static Delegate cb_setAlias_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetAlias_Ljava_lang_String_Handler ()
		{
			if (cb_setAlias_Ljava_lang_String_ == null)
				cb_setAlias_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetAlias_Ljava_lang_String_);
			return cb_setAlias_Ljava_lang_String_;
		}

		static void n_SetAlias_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			RichPushUser __this = Java.Lang.Object.GetObject<RichPushUser> (native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Alias = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getAlias;
		static IntPtr id_setAlias_Ljava_lang_String_;
		public virtual string Alias {
			[Register ("getAlias", "()Ljava/lang/String;", "GetGetAliasHandler")]
			get {
				if (id_getAlias == IntPtr.Zero)
					id_getAlias = JNIEnv.GetMethodID (class_ref, "getAlias", "()Ljava/lang/String;");

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getAlias), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getAlias), JniHandleOwnership.TransferLocalRef);
			}
			[Register ("setAlias", "(Ljava/lang/String;)V", "GetSetAlias_Ljava_lang_String_Handler")]
			set {
				if (id_setAlias_Ljava_lang_String_ == IntPtr.Zero)
					id_setAlias_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setAlias", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setAlias_Ljava_lang_String_, new JValue (native_value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_setAlias_Ljava_lang_String_, new JValue (native_value));
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static Delegate cb_getId;
#pragma warning disable 0169
		static Delegate GetGetIdHandler ()
		{
			if (cb_getId == null)
				cb_getId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetId);
			return cb_getId;
		}

		static IntPtr n_GetId (IntPtr jnienv, IntPtr native__this)
		{
			RichPushUser __this = Java.Lang.Object.GetObject<RichPushUser> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Id);
		}
#pragma warning restore 0169

		static IntPtr id_getId;
		public virtual string Id {
			[Register ("getId", "()Ljava/lang/String;", "GetGetIdHandler")]
			get {
				if (id_getId == IntPtr.Zero)
					id_getId = JNIEnv.GetMethodID (class_ref, "getId", "()Ljava/lang/String;");

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getId), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getId), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getInbox;
#pragma warning disable 0169
		static Delegate GetGetInboxHandler ()
		{
			if (cb_getInbox == null)
				cb_getInbox = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetInbox);
			return cb_getInbox;
		}

		static IntPtr n_GetInbox (IntPtr jnienv, IntPtr native__this)
		{
			RichPushUser __this = Java.Lang.Object.GetObject<RichPushUser> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Inbox);
		}
#pragma warning restore 0169

		static IntPtr id_getInbox;
		public virtual global::Com.Urbanairship.Richpush.RichPushInbox Inbox {
			[Register ("getInbox", "()Lcom/urbanairship/richpush/RichPushInbox;", "GetGetInboxHandler")]
			get {
				if (id_getInbox == IntPtr.Zero)
					id_getInbox = JNIEnv.GetMethodID (class_ref, "getInbox", "()Lcom/urbanairship/richpush/RichPushInbox;");

				if (GetType () == ThresholdType)
					return Java.Lang.Object.GetObject<global::Com.Urbanairship.Richpush.RichPushInbox> (JNIEnv.CallObjectMethod  (Handle, id_getInbox), JniHandleOwnership.TransferLocalRef);
				else
					return Java.Lang.Object.GetObject<global::Com.Urbanairship.Richpush.RichPushInbox> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getInbox), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_isCreated;
		public static bool IsCreated {
			[Register ("isCreated", "()Z", "GetIsCreatedHandler")]
			get {
				if (id_isCreated == IntPtr.Zero)
					id_isCreated = JNIEnv.GetStaticMethodID (class_ref, "isCreated", "()Z");
				return JNIEnv.CallStaticBooleanMethod  (class_ref, id_isCreated);
			}
		}

		static Delegate cb_getPassword;
#pragma warning disable 0169
		static Delegate GetGetPasswordHandler ()
		{
			if (cb_getPassword == null)
				cb_getPassword = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPassword);
			return cb_getPassword;
		}

		static IntPtr n_GetPassword (IntPtr jnienv, IntPtr native__this)
		{
			RichPushUser __this = Java.Lang.Object.GetObject<RichPushUser> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Password);
		}
#pragma warning restore 0169

		static IntPtr id_getPassword;
		public virtual string Password {
			[Register ("getPassword", "()Ljava/lang/String;", "GetGetPasswordHandler")]
			get {
				if (id_getPassword == IntPtr.Zero)
					id_getPassword = JNIEnv.GetMethodID (class_ref, "getPassword", "()Ljava/lang/String;");

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getPassword), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getPassword), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_addApid_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetAddApid_Ljava_lang_String_Handler ()
		{
			if (cb_addApid_Ljava_lang_String_ == null)
				cb_addApid_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_AddApid_Ljava_lang_String_);
			return cb_addApid_Ljava_lang_String_;
		}

		static void n_AddApid_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			RichPushUser __this = Java.Lang.Object.GetObject<RichPushUser> (native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AddApid (p0);
		}
#pragma warning restore 0169

		static IntPtr id_addApid_Ljava_lang_String_;
		[Register ("addApid", "(Ljava/lang/String;)V", "GetAddApid_Ljava_lang_String_Handler")]
		public virtual void AddApid (string p0)
		{
			if (id_addApid_Ljava_lang_String_ == IntPtr.Zero)
				id_addApid_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "addApid", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_addApid_Ljava_lang_String_, new JValue (native_p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_addApid_Ljava_lang_String_, new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_addTag_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetAddTag_Ljava_lang_String_Handler ()
		{
			if (cb_addTag_Ljava_lang_String_ == null)
				cb_addTag_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_AddTag_Ljava_lang_String_);
			return cb_addTag_Ljava_lang_String_;
		}

		static void n_AddTag_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			RichPushUser __this = Java.Lang.Object.GetObject<RichPushUser> (native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AddTag (p0);
		}
#pragma warning restore 0169

		static IntPtr id_addTag_Ljava_lang_String_;
		[Register ("addTag", "(Ljava/lang/String;)V", "GetAddTag_Ljava_lang_String_Handler")]
		public virtual void AddTag (string p0)
		{
			if (id_addTag_Ljava_lang_String_ == IntPtr.Zero)
				id_addTag_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "addTag", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_addTag_Ljava_lang_String_, new JValue (native_p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_addTag_Ljava_lang_String_, new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
		}

	}
}
