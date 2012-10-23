using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Urbanairship.Push.Embedded {

	[global::Android.Runtime.Register ("com/urbanairship/push/embedded/BoxOfficeClient", DoNotGenerateAcw=true)]
	public partial class BoxOfficeClient : global::Java.Lang.Object {

		[global::Android.Runtime.Register ("com/urbanairship/push/embedded/BoxOfficeClient$BoxOfficeException", DoNotGenerateAcw=true)]
		public partial class BoxOfficeException : global::Java.Lang.Exception {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/urbanairship/push/embedded/BoxOfficeClient$BoxOfficeException", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (BoxOfficeException); }
			}

			protected BoxOfficeException (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Ljava_lang_String_;
			[Register (".ctor", "(Ljava/lang/String;)V", "")]
			public BoxOfficeException (string p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				IntPtr native_p0 = JNIEnv.NewString (p0);;
				if (GetType () != typeof (BoxOfficeException)) {
					SetHandle (global::Android.Runtime.JNIEnv.CreateInstance (GetType (), "(Ljava/lang/String;)V", new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
					JNIEnv.DeleteLocalRef (native_p0);
					return;
				}

				if (id_ctor_Ljava_lang_String_ == IntPtr.Zero)
					id_ctor_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;)V");
				SetHandle (JNIEnv.NewObject (class_ref, id_ctor_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
				JNIEnv.DeleteLocalRef (native_p0);
			}

		}

		[global::Android.Runtime.Register ("com/urbanairship/push/embedded/BoxOfficeClient$FatalBoxOfficeException", DoNotGenerateAcw=true)]
		public partial class FatalBoxOfficeException : global::Com.Urbanairship.Push.Embedded.BoxOfficeClient.BoxOfficeException {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/urbanairship/push/embedded/BoxOfficeClient$FatalBoxOfficeException", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (FatalBoxOfficeException); }
			}

			protected FatalBoxOfficeException (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Ljava_lang_String_;
			[Register (".ctor", "(Ljava/lang/String;)V", "")]
			public FatalBoxOfficeException (string p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				IntPtr native_p0 = JNIEnv.NewString (p0);;
				if (GetType () != typeof (FatalBoxOfficeException)) {
					SetHandle (global::Android.Runtime.JNIEnv.CreateInstance (GetType (), "(Ljava/lang/String;)V", new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
					JNIEnv.DeleteLocalRef (native_p0);
					return;
				}

				if (id_ctor_Ljava_lang_String_ == IntPtr.Zero)
					id_ctor_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;)V");
				SetHandle (JNIEnv.NewObject (class_ref, id_ctor_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
				JNIEnv.DeleteLocalRef (native_p0);
			}

		}

		[global::Android.Runtime.Register ("com/urbanairship/push/embedded/BoxOfficeClient$FirstRunForbiddenException", DoNotGenerateAcw=true)]
		public partial class FirstRunForbiddenException : global::Com.Urbanairship.Push.Embedded.BoxOfficeClient.FatalBoxOfficeException {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/urbanairship/push/embedded/BoxOfficeClient$FirstRunForbiddenException", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (FirstRunForbiddenException); }
			}

			protected FirstRunForbiddenException (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Ljava_lang_String_;
			[Register (".ctor", "(Ljava/lang/String;)V", "")]
			public FirstRunForbiddenException (string p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				IntPtr native_p0 = JNIEnv.NewString (p0);;
				if (GetType () != typeof (FirstRunForbiddenException)) {
					SetHandle (global::Android.Runtime.JNIEnv.CreateInstance (GetType (), "(Ljava/lang/String;)V", new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
					JNIEnv.DeleteLocalRef (native_p0);
					return;
				}

				if (id_ctor_Ljava_lang_String_ == IntPtr.Zero)
					id_ctor_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;)V");
				SetHandle (JNIEnv.NewObject (class_ref, id_ctor_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
				JNIEnv.DeleteLocalRef (native_p0);
			}

		}

		[global::Android.Runtime.Register ("com/urbanairship/push/embedded/BoxOfficeClient$HeliumServer", DoNotGenerateAcw=true)]
		protected internal partial class HeliumServer : global::Java.Lang.Object {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/urbanairship/push/embedded/BoxOfficeClient$HeliumServer", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (HeliumServer); }
			}

			protected HeliumServer (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lcom_urbanairship_push_embedded_BoxOfficeClient_Ljava_lang_String_;
			[Register (".ctor", "(Lcom/urbanairship/push/embedded/BoxOfficeClient;Ljava/lang/String;)V", "")]
			public HeliumServer (global::Com.Urbanairship.Push.Embedded.BoxOfficeClient __self, string p1) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				IntPtr native_p1 = JNIEnv.NewString (p1);;
				if (GetType () != typeof (HeliumServer)) {
					SetHandle (global::Android.Runtime.JNIEnv.CreateInstance (GetType (), "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";Ljava/lang/String;)V", new JValue (__self), new JValue (native_p1)), JniHandleOwnership.TransferLocalRef);
					JNIEnv.DeleteLocalRef (native_p1);
					return;
				}

				if (id_ctor_Lcom_urbanairship_push_embedded_BoxOfficeClient_Ljava_lang_String_ == IntPtr.Zero)
					id_ctor_Lcom_urbanairship_push_embedded_BoxOfficeClient_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/urbanairship/push/embedded/BoxOfficeClient;Ljava/lang/String;)V");
				SetHandle (JNIEnv.NewObject (class_ref, id_ctor_Lcom_urbanairship_push_embedded_BoxOfficeClient_Ljava_lang_String_, new JValue (__self), new JValue (native_p1)), JniHandleOwnership.TransferLocalRef);
				JNIEnv.DeleteLocalRef (native_p1);
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
				HeliumServer __this = Java.Lang.Object.GetObject<HeliumServer> (native__this, JniHandleOwnership.DoNotTransfer);
				return __this.IsValid;
			}
#pragma warning restore 0169

			static IntPtr id_isValid;
			public virtual bool IsValid {
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

		}

		[global::Android.Runtime.Register ("com/urbanairship/push/embedded/BoxOfficeClient$InvalidSecretException", DoNotGenerateAcw=true)]
		public partial class InvalidSecretException : global::Com.Urbanairship.Push.Embedded.BoxOfficeClient.BoxOfficeException {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/urbanairship/push/embedded/BoxOfficeClient$InvalidSecretException", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (InvalidSecretException); }
			}

			protected InvalidSecretException (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Ljava_lang_String_;
			[Register (".ctor", "(Ljava/lang/String;)V", "")]
			public InvalidSecretException (string p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				IntPtr native_p0 = JNIEnv.NewString (p0);;
				if (GetType () != typeof (InvalidSecretException)) {
					SetHandle (global::Android.Runtime.JNIEnv.CreateInstance (GetType (), "(Ljava/lang/String;)V", new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
					JNIEnv.DeleteLocalRef (native_p0);
					return;
				}

				if (id_ctor_Ljava_lang_String_ == IntPtr.Zero)
					id_ctor_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;)V");
				SetHandle (JNIEnv.NewObject (class_ref, id_ctor_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
				JNIEnv.DeleteLocalRef (native_p0);
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/urbanairship/push/embedded/BoxOfficeClient", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BoxOfficeClient); }
		}

		protected BoxOfficeClient (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		[Register (".ctor", "()V", "")]
		public BoxOfficeClient () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (BoxOfficeClient)) {
				SetHandle (global::Android.Runtime.JNIEnv.CreateInstance (GetType (), "()V"), JniHandleOwnership.TransferLocalRef);
				return;
			}

			if (id_ctor == IntPtr.Zero)
				id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
			SetHandle (JNIEnv.NewObject (class_ref, id_ctor), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_getEncryptionKey;
#pragma warning disable 0169
		static Delegate GetGetEncryptionKeyHandler ()
		{
			if (cb_getEncryptionKey == null)
				cb_getEncryptionKey = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetEncryptionKey);
			return cb_getEncryptionKey;
		}

		static IntPtr n_GetEncryptionKey (IntPtr jnienv, IntPtr native__this)
		{
			BoxOfficeClient __this = Java.Lang.Object.GetObject<BoxOfficeClient> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.EncryptionKey);
		}
#pragma warning restore 0169

		static IntPtr id_getEncryptionKey;
		protected virtual global::Java.Util.UUID EncryptionKey {
			[Register ("getEncryptionKey", "()Ljava/util/UUID;", "GetGetEncryptionKeyHandler")]
			get {
				if (id_getEncryptionKey == IntPtr.Zero)
					id_getEncryptionKey = JNIEnv.GetMethodID (class_ref, "getEncryptionKey", "()Ljava/util/UUID;");

				if (GetType () == ThresholdType)
					return Java.Lang.Object.GetObject<global::Java.Util.UUID> (JNIEnv.CallObjectMethod  (Handle, id_getEncryptionKey), JniHandleOwnership.TransferLocalRef);
				else
					return Java.Lang.Object.GetObject<global::Java.Util.UUID> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getEncryptionKey), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_firstRun;
#pragma warning disable 0169
		static Delegate GetFirstRunHandler ()
		{
			if (cb_firstRun == null)
				cb_firstRun = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_FirstRun);
			return cb_firstRun;
		}

		static IntPtr n_FirstRun (IntPtr jnienv, IntPtr native__this)
		{
			BoxOfficeClient __this = Java.Lang.Object.GetObject<BoxOfficeClient> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.FirstRun ());
		}
#pragma warning restore 0169

		static IntPtr id_firstRun;
		[Register ("firstRun", "()Ljava/lang/String;", "GetFirstRunHandler")]
		public virtual string FirstRun ()
		{
			if (id_firstRun == IntPtr.Zero)
				id_firstRun = JNIEnv.GetMethodID (class_ref, "firstRun", "()Ljava/lang/String;");

			if (GetType () == ThresholdType)
				return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_firstRun), JniHandleOwnership.TransferLocalRef);
			else
				return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_firstRun), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_incrementFailureCount;
#pragma warning disable 0169
		static Delegate GetIncrementFailureCountHandler ()
		{
			if (cb_incrementFailureCount == null)
				cb_incrementFailureCount = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_IncrementFailureCount);
			return cb_incrementFailureCount;
		}

		static void n_IncrementFailureCount (IntPtr jnienv, IntPtr native__this)
		{
			BoxOfficeClient __this = Java.Lang.Object.GetObject<BoxOfficeClient> (native__this, JniHandleOwnership.DoNotTransfer);
			__this.IncrementFailureCount ();
		}
#pragma warning restore 0169

		static IntPtr id_incrementFailureCount;
		[Register ("incrementFailureCount", "()V", "GetIncrementFailureCountHandler")]
		protected virtual void IncrementFailureCount ()
		{
			if (id_incrementFailureCount == IntPtr.Zero)
				id_incrementFailureCount = JNIEnv.GetMethodID (class_ref, "incrementFailureCount", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_incrementFailureCount);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_incrementFailureCount);
		}

		static Delegate cb_lookup;
#pragma warning disable 0169
		static Delegate GetLookupHandler ()
		{
			if (cb_lookup == null)
				cb_lookup = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Lookup);
			return cb_lookup;
		}

		static IntPtr n_Lookup (IntPtr jnienv, IntPtr native__this)
		{
			BoxOfficeClient __this = Java.Lang.Object.GetObject<BoxOfficeClient> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Lookup ());
		}
#pragma warning restore 0169

		static IntPtr id_lookup;
		[Register ("lookup", "()Ljava/lang/String;", "GetLookupHandler")]
		public virtual string Lookup ()
		{
			if (id_lookup == IntPtr.Zero)
				id_lookup = JNIEnv.GetMethodID (class_ref, "lookup", "()Ljava/lang/String;");

			if (GetType () == ThresholdType)
				return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_lookup), JniHandleOwnership.TransferLocalRef);
			else
				return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_lookup), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_resetFailureCount;
#pragma warning disable 0169
		static Delegate GetResetFailureCountHandler ()
		{
			if (cb_resetFailureCount == null)
				cb_resetFailureCount = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ResetFailureCount);
			return cb_resetFailureCount;
		}

		static void n_ResetFailureCount (IntPtr jnienv, IntPtr native__this)
		{
			BoxOfficeClient __this = Java.Lang.Object.GetObject<BoxOfficeClient> (native__this, JniHandleOwnership.DoNotTransfer);
			__this.ResetFailureCount ();
		}
#pragma warning restore 0169

		static IntPtr id_resetFailureCount;
		[Register ("resetFailureCount", "()V", "GetResetFailureCountHandler")]
		protected virtual void ResetFailureCount ()
		{
			if (id_resetFailureCount == IntPtr.Zero)
				id_resetFailureCount = JNIEnv.GetMethodID (class_ref, "resetFailureCount", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_resetFailureCount);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_resetFailureCount);
		}

	}
}
